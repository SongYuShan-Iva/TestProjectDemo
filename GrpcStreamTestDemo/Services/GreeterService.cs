using Google.Protobuf;
using Grpc.Core;
using GrpcStreamTestDemo;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace GrpcStreamTestDemo.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }

        /// <summary>
        /// 双向流
        /// </summary>
        /// <param name="requestStream">请求流</param>
        /// <param name="responseStream">响应流</param>
        /// <param name="context">上下文</param>
        /// <returns></returns>
        public override async Task BothStreamPing(IAsyncStreamReader<PingRequest> requestStream, IServerStreamWriter<PingReply> responseStream, ServerCallContext context)
        {

            while (!context.CancellationToken.IsCancellationRequested && await requestStream.MoveNext())
            {
                string msg = requestStream.Current.MessageId;
                Console.WriteLine($"加载模块：{msg}");
                await Task.Delay(500);
                if (!context.CancellationToken.IsCancellationRequested)
                {
                    await responseStream.WriteAsync(new PingReply()
                    {
                        Message = $"{msg}模块加载完成"
                    });
                }
            } 
        }
    }
}
