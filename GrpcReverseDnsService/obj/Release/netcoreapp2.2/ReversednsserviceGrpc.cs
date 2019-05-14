// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gRPC/protos/reversednsservice.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ReverseDns {
  public static partial class ReverseDnsService
  {
    static readonly string __ServiceName = "ReverseDns.ReverseDnsService";

    static readonly grpc::Marshaller<global::ReverseDns.EndpointDataRequest> __Marshaller_ReverseDns_EndpointDataRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ReverseDns.EndpointDataRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::ReverseDns.EndPointDataResponse> __Marshaller_ReverseDns_EndPointDataResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::ReverseDns.EndPointDataResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::ReverseDns.EndpointDataRequest, global::ReverseDns.EndPointDataResponse> __Method_GetReport = new grpc::Method<global::ReverseDns.EndpointDataRequest, global::ReverseDns.EndPointDataResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetReport",
        __Marshaller_ReverseDns_EndpointDataRequest,
        __Marshaller_ReverseDns_EndPointDataResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ReverseDns.ReversednsserviceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ReverseDnsService</summary>
    public abstract partial class ReverseDnsServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::ReverseDns.EndPointDataResponse> GetReport(global::ReverseDns.EndpointDataRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ReverseDnsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetReport, serviceImpl.GetReport).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ReverseDnsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetReport, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ReverseDns.EndpointDataRequest, global::ReverseDns.EndPointDataResponse>(serviceImpl.GetReport));
    }

  }
}
#endregion