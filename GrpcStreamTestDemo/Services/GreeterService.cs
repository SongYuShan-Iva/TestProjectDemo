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
        /// ˫����
        /// </summary>
        /// <param name="requestStream">������</param>
        /// <param name="responseStream">��Ӧ��</param>
        /// <param name="context">������</param>
        /// <returns></returns>
        public override async Task BothStreamPing(IAsyncStreamReader<PingRequest> requestStream, IServerStreamWriter<PingReply> responseStream, ServerCallContext context)
        {

            while (!context.CancellationToken.IsCancellationRequested && await requestStream.MoveNext())
            {
                string msg = requestStream.Current.MessageId;
                Console.WriteLine($"����ģ�飺{msg}");
                await Task.Delay(500);
                if (!context.CancellationToken.IsCancellationRequested)
                {
                    await responseStream.WriteAsync(new PingReply()
                    {
                        Message = $"{msg}ģ��������"
                    });
                }
            } 
        }
    }
}
