// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: gRPC/protos/pingservice.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Ping {

  /// <summary>Holder for reflection information generated from gRPC/protos/pingservice.proto</summary>
  public static partial class PingserviceReflection {

    #region Descriptor
    /// <summary>File descriptor for gRPC/protos/pingservice.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PingserviceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1nUlBDL3Byb3Rvcy9waW5nc2VydmljZS5wcm90bxIEUGluZyIzChNFbmRw",
            "b2ludERhdGFSZXF1ZXN0EhAKCGVuZHBvaW50GAEgASgJEgoKAmlkGAIgASgJ",
            "ImcKFEVuZFBvaW50RGF0YVJlc3BvbnNlEg8KB21lc3NhZ2UYASABKAkSFAoM",
            "ZW5kcG9pbnRkYXRhGAIgASgJEhwKBnN0YXR1cxgDIAEoDjIMLlBpbmcuU3Rh",
            "dHVzEgoKAmlkGAQgASgJKiEKBlN0YXR1cxILCgdTVUNDRVNTEAASCgoGRkFJ",
            "TEVEEAEyUwoLUGluZ1NlcnZpY2USRAoJR2V0UmVwb3J0EhkuUGluZy5FbmRw",
            "b2ludERhdGFSZXF1ZXN0GhouUGluZy5FbmRQb2ludERhdGFSZXNwb25zZSIA",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Ping.Status), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Ping.EndpointDataRequest), global::Ping.EndpointDataRequest.Parser, new[]{ "Endpoint", "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Ping.EndPointDataResponse), global::Ping.EndPointDataResponse.Parser, new[]{ "Message", "Endpointdata", "Status", "Id" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Status {
    [pbr::OriginalName("SUCCESS")] Success = 0,
    [pbr::OriginalName("FAILED")] Failed = 1,
  }

  #endregion

  #region Messages
  public sealed partial class EndpointDataRequest : pb::IMessage<EndpointDataRequest> {
    private static readonly pb::MessageParser<EndpointDataRequest> _parser = new pb::MessageParser<EndpointDataRequest>(() => new EndpointDataRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EndpointDataRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ping.PingserviceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EndpointDataRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EndpointDataRequest(EndpointDataRequest other) : this() {
      endpoint_ = other.endpoint_;
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EndpointDataRequest Clone() {
      return new EndpointDataRequest(this);
    }

    /// <summary>Field number for the "endpoint" field.</summary>
    public const int EndpointFieldNumber = 1;
    private string endpoint_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Endpoint {
      get { return endpoint_; }
      set {
        endpoint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EndpointDataRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EndpointDataRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Endpoint != other.Endpoint) return false;
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Endpoint.Length != 0) hash ^= Endpoint.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Endpoint.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Endpoint);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Endpoint.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Endpoint);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EndpointDataRequest other) {
      if (other == null) {
        return;
      }
      if (other.Endpoint.Length != 0) {
        Endpoint = other.Endpoint;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Endpoint = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The response message with the data
  /// </summary>
  public sealed partial class EndPointDataResponse : pb::IMessage<EndPointDataResponse> {
    private static readonly pb::MessageParser<EndPointDataResponse> _parser = new pb::MessageParser<EndPointDataResponse>(() => new EndPointDataResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EndPointDataResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Ping.PingserviceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EndPointDataResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EndPointDataResponse(EndPointDataResponse other) : this() {
      message_ = other.message_;
      endpointdata_ = other.endpointdata_;
      status_ = other.status_;
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EndPointDataResponse Clone() {
      return new EndPointDataResponse(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "endpointdata" field.</summary>
    public const int EndpointdataFieldNumber = 2;
    private string endpointdata_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Endpointdata {
      get { return endpointdata_; }
      set {
        endpointdata_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::Ping.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Ping.Status Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 4;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EndPointDataResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EndPointDataResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if (Endpointdata != other.Endpointdata) return false;
      if (Status != other.Status) return false;
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (Endpointdata.Length != 0) hash ^= Endpointdata.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (Endpointdata.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Endpointdata);
      }
      if (Status != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (Endpointdata.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Endpointdata);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EndPointDataResponse other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.Endpointdata.Length != 0) {
        Endpointdata = other.Endpointdata;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
          case 18: {
            Endpointdata = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::Ping.Status) input.ReadEnum();
            break;
          }
          case 34: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
