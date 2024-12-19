// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/greet.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcStreamTestDemo {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class Greeter
  {
    static readonly string __ServiceName = "greet.Greeter";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcStreamTestDemo.HelloRequest> __Marshaller_greet_HelloRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcStreamTestDemo.HelloRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcStreamTestDemo.HelloReply> __Marshaller_greet_HelloReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcStreamTestDemo.HelloReply.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcStreamTestDemo.PingRequest> __Marshaller_greet_PingRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcStreamTestDemo.PingRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcStreamTestDemo.PingReply> __Marshaller_greet_PingReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcStreamTestDemo.PingReply.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcStreamTestDemo.HelloRequest, global::GrpcStreamTestDemo.HelloReply> __Method_SayHello = new grpc::Method<global::GrpcStreamTestDemo.HelloRequest, global::GrpcStreamTestDemo.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_greet_HelloRequest,
        __Marshaller_greet_HelloReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcStreamTestDemo.PingRequest, global::GrpcStreamTestDemo.PingReply> __Method_SimplePing = new grpc::Method<global::GrpcStreamTestDemo.PingRequest, global::GrpcStreamTestDemo.PingReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SimplePing",
        __Marshaller_greet_PingRequest,
        __Marshaller_greet_PingReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcStreamTestDemo.PingRequest, global::GrpcStreamTestDemo.PingReply> __Method_ClientStreamPing = new grpc::Method<global::GrpcStreamTestDemo.PingRequest, global::GrpcStreamTestDemo.PingReply>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "ClientStreamPing",
        __Marshaller_greet_PingRequest,
        __Marshaller_greet_PingReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcStreamTestDemo.PingRequest, global::GrpcStreamTestDemo.PingReply> __Method_ServerStreamPing = new grpc::Method<global::GrpcStreamTestDemo.PingRequest, global::GrpcStreamTestDemo.PingReply>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ServerStreamPing",
        __Marshaller_greet_PingRequest,
        __Marshaller_greet_PingReply);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcStreamTestDemo.PingRequest, global::GrpcStreamTestDemo.PingReply> __Method_BothStreamPing = new grpc::Method<global::GrpcStreamTestDemo.PingRequest, global::GrpcStreamTestDemo.PingReply>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "BothStreamPing",
        __Marshaller_greet_PingRequest,
        __Marshaller_greet_PingReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcStreamTestDemo.GreetReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Greeter</summary>
    [grpc::BindServiceMethod(typeof(Greeter), "BindService")]
    public abstract partial class GreeterBase
    {
      /// <summary>
      /// Sends a greeting
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcStreamTestDemo.HelloReply> SayHello(global::GrpcStreamTestDemo.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// ��ͨ RPC
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcStreamTestDemo.PingReply> SimplePing(global::GrpcStreamTestDemo.PingRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// �ͻ�����ʽ RPC
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcStreamTestDemo.PingReply> ClientStreamPing(grpc::IAsyncStreamReader<global::GrpcStreamTestDemo.PingRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// ����������ʽ RPC
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ServerStreamPing(global::GrpcStreamTestDemo.PingRequest request, grpc::IServerStreamWriter<global::GrpcStreamTestDemo.PingReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// ˫����ʽ RPC
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task BothStreamPing(grpc::IAsyncStreamReader<global::GrpcStreamTestDemo.PingRequest> requestStream, grpc::IServerStreamWriter<global::GrpcStreamTestDemo.PingReply> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(GreeterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello)
          .AddMethod(__Method_SimplePing, serviceImpl.SimplePing)
          .AddMethod(__Method_ClientStreamPing, serviceImpl.ClientStreamPing)
          .AddMethod(__Method_ServerStreamPing, serviceImpl.ServerStreamPing)
          .AddMethod(__Method_BothStreamPing, serviceImpl.BothStreamPing).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GreeterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcStreamTestDemo.HelloRequest, global::GrpcStreamTestDemo.HelloReply>(serviceImpl.SayHello));
      serviceBinder.AddMethod(__Method_SimplePing, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcStreamTestDemo.PingRequest, global::GrpcStreamTestDemo.PingReply>(serviceImpl.SimplePing));
      serviceBinder.AddMethod(__Method_ClientStreamPing, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::GrpcStreamTestDemo.PingRequest, global::GrpcStreamTestDemo.PingReply>(serviceImpl.ClientStreamPing));
      serviceBinder.AddMethod(__Method_ServerStreamPing, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GrpcStreamTestDemo.PingRequest, global::GrpcStreamTestDemo.PingReply>(serviceImpl.ServerStreamPing));
      serviceBinder.AddMethod(__Method_BothStreamPing, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::GrpcStreamTestDemo.PingRequest, global::GrpcStreamTestDemo.PingReply>(serviceImpl.BothStreamPing));
    }

  }
}
#endregion