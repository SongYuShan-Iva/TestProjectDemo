using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Grpc.Net.Client;
using GrpcStreamTestCilent;

namespace GrpcSteamTestClient
{
    internal class Program
    {
        private const string ServiceAddress = "https://localhost:7129";

        static async Task Main(string[] args)
        {
            //发送模块的个数
            const int count = 10;
            //创建Grpc通道
            var channel = GrpcChannel.ForAddress(ServiceAddress);
            //创建Greeter客户端
            var client = new Greeter.GreeterClient(channel);
            //创建双向流对象
            var bothway = client.BothStreamPing();
            //CancellationTokenSource 管理是否关闭流
            //CancellationTokenSource.CancelAfter() 规定时间关闭流
            //CancellationTokenSource.Cancel() 立即关闭流
            var cts = new CancellationTokenSource();
            //响应事件
            var backTask = Task.Run(async () =>
            {
                int current = 0;
                try
                {
                    //从响应流获取数据(cts.Token: 是否关闭流)
                    while (await bothway.ResponseStream.MoveNext(cts.Token))
                    {
                        current++;
                        var back = bothway.ResponseStream.Current;
                        Console.WriteLine($"{back.Message},加载进度{((double)current / count) * 100}%");
                        if (current >= 5)
                        {
                            //关闭流
                            cts.Cancel();
                        }
                    }
                }
                //关闭流异常捕获
                catch (RpcException ex) when (ex.StatusCode == StatusCode.Cancelled)
                {
                    Console.WriteLine("Stream cancelled.");
                }
            });

            for (int i = 0; i < count; i++)
            {
                //请求流写入数据
                await bothway.RequestStream.WriteAsync(new PingRequest()
                {
                    MessageId = i.ToString()
                });
            }

            //等待发送完成
            await bothway.RequestStream.CompleteAsync();

            Console.WriteLine("加载模块发送完毕");
            Console.WriteLine("等待加载...");

            //等待响应完成
            await backTask;

            Console.WriteLine("模块已全部加载完毕");
            Console.ReadKey();
        }
       
         
    }
}
