// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/reversednsservice.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ReverseDns {

  /// <summary>Holder for reflection information generated from protos/reversednsservice.proto</summary>
  public static partial class ReversednsserviceReflection {

    #region Descriptor
    /// <summary>File descriptor for protos/reversednsservice.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReversednsserviceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5wcm90b3MvcmV2ZXJzZWRuc3NlcnZpY2UucHJvdG8SClJldmVyc2VEbnMi",
            "MwoTRW5kcG9pbnREYXRhUmVxdWVzdBIQCghlbmRwb2ludBgBIAEoCRIKCgJp",
            "ZBgCIAEoCSJtChRFbmRQb2ludERhdGFSZXNwb25zZRIPCgdtZXNzYWdlGAEg",
            "ASgJEhQKDGVuZHBvaW50ZGF0YRgCIAEoCRIiCgZzdGF0dXMYAyABKA4yEi5S",
            "ZXZlcnNlRG5zLlN0YXR1cxIKCgJpZBgEIAEoCSohCgZTdGF0dXMSCwoHU1VD",
            "Q0VTUxAAEgoKBkZBSUxFRBABMmUKEVJldmVyc2VEbnNTZXJ2aWNlElAKCUdl",
            "dFJlcG9ydBIfLlJldmVyc2VEbnMuRW5kcG9pbnREYXRhUmVxdWVzdBogLlJl",
            "dmVyc2VEbnMuRW5kUG9pbnREYXRhUmVzcG9uc2UiAGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::ReverseDns.Status), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ReverseDns.EndpointDataRequest), global::ReverseDns.EndpointDataRequest.Parser, new[]{ "Endpoint", "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ReverseDns.EndPointDataResponse), global::ReverseDns.EndPointDataResponse.Parser, new[]{ "Message", "Endpointdata", "Status", "Id" }, null, null, null)
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
      get { return global::ReverseDns.ReversednsserviceReflection.Descriptor.MessageTypes[0]; }
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
      get { return global::ReverseDns.ReversednsserviceReflection.Descriptor.MessageTypes[1]; }
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
    private global::ReverseDns.Status status_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::ReverseDns.Status Status {
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
            Status = (global::ReverseDns.Status) input.ReadEnum();
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
