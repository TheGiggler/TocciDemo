// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gRPC/protos/geoservice.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Geo {
  public static partial class EndpointReportingService
  {
    static readonly string __ServiceName = "Geo.EndpointReportingService";

    static readonly grpc::Marshaller<global::Geo.EndpointDataRequest> __Marshaller_Geo_EndpointDataRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Geo.EndpointDataRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Geo.EndPointDataResponse> __Marshaller_Geo_EndPointDataResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Geo.EndPointDataResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Geo.EndpointDataRequest, global::Geo.EndPointDataResponse> __Method_GetReport = new grpc::Method<global::Geo.EndpointDataRequest, global::Geo.EndPointDataResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetReport",
        __Marshaller_Geo_EndpointDataRequest,
        __Marshaller_Geo_EndPointDataResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Geo.GeoserviceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of EndpointReportingService</summary>
    public abstract partial class EndpointReportingServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Geo.EndPointDataResponse> GetReport(global::Geo.EndpointDataRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(EndpointReportingServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetReport, serviceImpl.GetReport).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, EndpointReportingServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetReport, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Geo.EndpointDataRequest, global::Geo.EndPointDataResponse>(serviceImpl.GetReport));
    }

  }
}
#endregion
