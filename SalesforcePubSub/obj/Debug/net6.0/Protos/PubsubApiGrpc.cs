// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/pubsub_api.proto
// </auto-generated>
// Original file comments:
//
// Salesforce Pub/Sub API Version 1.
//
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Eventbus.V1 {
  /// <summary>
  ///
  /// The Pub/Sub API provides a single interface for publishing and subscribing to platform events, including real-time
  /// event monitoring events, and change data capture events. The Pub/Sub API is a gRPC API that is based on HTTP/2.
  ///
  /// A session token is needed to authenticate. Any of the Salesforce supported
  /// OAuth flows can be used to obtain a session token:
  /// https://help.salesforce.com/articleView?id=sf.remoteaccess_oauth_flows.htm&amp;type=5
  ///
  /// For each RPC, a client needs to pass authentication information
  /// as metadata headers (https://www.grpc.io/docs/guides/concepts/#metadata) with their method call.
  ///
  /// For Salesforce session token authentication, use:
  ///   accesstoken : access token
  ///   instanceurl : Salesforce instance URL
  ///   tenantid : tenant/org id of the client
  ///
  /// StatusException is thrown in case of response failure for any request.
  /// </summary>
  public static partial class PubSub
  {
    static readonly string __ServiceName = "eventbus.v1.PubSub";

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
    static readonly grpc::Marshaller<global::Eventbus.V1.FetchRequest> __Marshaller_eventbus_v1_FetchRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Eventbus.V1.FetchRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Eventbus.V1.FetchResponse> __Marshaller_eventbus_v1_FetchResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Eventbus.V1.FetchResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Eventbus.V1.SchemaRequest> __Marshaller_eventbus_v1_SchemaRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Eventbus.V1.SchemaRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Eventbus.V1.SchemaInfo> __Marshaller_eventbus_v1_SchemaInfo = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Eventbus.V1.SchemaInfo.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Eventbus.V1.TopicRequest> __Marshaller_eventbus_v1_TopicRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Eventbus.V1.TopicRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Eventbus.V1.TopicInfo> __Marshaller_eventbus_v1_TopicInfo = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Eventbus.V1.TopicInfo.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Eventbus.V1.PublishRequest> __Marshaller_eventbus_v1_PublishRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Eventbus.V1.PublishRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Eventbus.V1.PublishResponse> __Marshaller_eventbus_v1_PublishResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Eventbus.V1.PublishResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Eventbus.V1.FetchRequest, global::Eventbus.V1.FetchResponse> __Method_Subscribe = new grpc::Method<global::Eventbus.V1.FetchRequest, global::Eventbus.V1.FetchResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "Subscribe",
        __Marshaller_eventbus_v1_FetchRequest,
        __Marshaller_eventbus_v1_FetchResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Eventbus.V1.SchemaRequest, global::Eventbus.V1.SchemaInfo> __Method_GetSchema = new grpc::Method<global::Eventbus.V1.SchemaRequest, global::Eventbus.V1.SchemaInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSchema",
        __Marshaller_eventbus_v1_SchemaRequest,
        __Marshaller_eventbus_v1_SchemaInfo);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Eventbus.V1.TopicRequest, global::Eventbus.V1.TopicInfo> __Method_GetTopic = new grpc::Method<global::Eventbus.V1.TopicRequest, global::Eventbus.V1.TopicInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTopic",
        __Marshaller_eventbus_v1_TopicRequest,
        __Marshaller_eventbus_v1_TopicInfo);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Eventbus.V1.PublishRequest, global::Eventbus.V1.PublishResponse> __Method_Publish = new grpc::Method<global::Eventbus.V1.PublishRequest, global::Eventbus.V1.PublishResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Publish",
        __Marshaller_eventbus_v1_PublishRequest,
        __Marshaller_eventbus_v1_PublishResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Eventbus.V1.PublishRequest, global::Eventbus.V1.PublishResponse> __Method_PublishStream = new grpc::Method<global::Eventbus.V1.PublishRequest, global::Eventbus.V1.PublishResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "PublishStream",
        __Marshaller_eventbus_v1_PublishRequest,
        __Marshaller_eventbus_v1_PublishResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Eventbus.V1.PubsubApiReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for PubSub</summary>
    public partial class PubSubClient : grpc::ClientBase<PubSubClient>
    {
      /// <summary>Creates a new client for PubSub</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PubSubClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for PubSub that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public PubSubClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PubSubClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected PubSubClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///
      /// Bidirectional streaming RPC to subscribe to a Topic. The subscription is pull-based. A client can request
      /// for more events as it consumes events. This enables a client to handle flow control based on the client's processing speed.
      ///
      /// Typical flow:
      /// 1. Client requests for X number of events via FetchRequest.
      /// 2. Server receives request and delivers events until X events are delivered to the client via one or more FetchResponse messages.
      /// 3. Client consumes the FetchResponse messages as they come.
      /// 4. Client issues new FetchRequest for Y more number of events. This request can
      ///    come before the server has delivered the earlier requested X number of events
      ///    so the client gets a continuous stream of events if any.
      ///
      /// If a client requests more events before the server finishes the last
      /// requested amount, the server appends the new amount to the current amount of
      /// events it still needs to fetch and deliver.
      ///
      /// A client can subscribe at any point in the stream by providing a replay option in the first FetchRequest.
      /// The replay option is honored for the first FetchRequest received from a client. Any subsequent FetchRequests with a
      /// new replay option are ignored. A client needs to call the Subscribe RPC again to restart the subscription
      /// at a new point in the stream.
      ///
      /// The first FetchRequest of the stream identifies the topic to subscribe to.
      /// If any subsequent FetchRequest provides topic_name, it must match what
      /// was provided in the first FetchRequest; otherwise, the RPC returns an error
      /// with INVALID_ARGUMENT status.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Eventbus.V1.FetchRequest, global::Eventbus.V1.FetchResponse> Subscribe(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Subscribe(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///
      /// Bidirectional streaming RPC to subscribe to a Topic. The subscription is pull-based. A client can request
      /// for more events as it consumes events. This enables a client to handle flow control based on the client's processing speed.
      ///
      /// Typical flow:
      /// 1. Client requests for X number of events via FetchRequest.
      /// 2. Server receives request and delivers events until X events are delivered to the client via one or more FetchResponse messages.
      /// 3. Client consumes the FetchResponse messages as they come.
      /// 4. Client issues new FetchRequest for Y more number of events. This request can
      ///    come before the server has delivered the earlier requested X number of events
      ///    so the client gets a continuous stream of events if any.
      ///
      /// If a client requests more events before the server finishes the last
      /// requested amount, the server appends the new amount to the current amount of
      /// events it still needs to fetch and deliver.
      ///
      /// A client can subscribe at any point in the stream by providing a replay option in the first FetchRequest.
      /// The replay option is honored for the first FetchRequest received from a client. Any subsequent FetchRequests with a
      /// new replay option are ignored. A client needs to call the Subscribe RPC again to restart the subscription
      /// at a new point in the stream.
      ///
      /// The first FetchRequest of the stream identifies the topic to subscribe to.
      /// If any subsequent FetchRequest provides topic_name, it must match what
      /// was provided in the first FetchRequest; otherwise, the RPC returns an error
      /// with INVALID_ARGUMENT status.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Eventbus.V1.FetchRequest, global::Eventbus.V1.FetchResponse> Subscribe(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_Subscribe, null, options);
      }
      /// <summary>
      /// Get the event schema for a topic based on a schema ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Eventbus.V1.SchemaInfo GetSchema(global::Eventbus.V1.SchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSchema(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get the event schema for a topic based on a schema ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Eventbus.V1.SchemaInfo GetSchema(global::Eventbus.V1.SchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSchema, null, options, request);
      }
      /// <summary>
      /// Get the event schema for a topic based on a schema ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Eventbus.V1.SchemaInfo> GetSchemaAsync(global::Eventbus.V1.SchemaRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSchemaAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Get the event schema for a topic based on a schema ID.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Eventbus.V1.SchemaInfo> GetSchemaAsync(global::Eventbus.V1.SchemaRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSchema, null, options, request);
      }
      /// <summary>
      ///
      /// Get the topic Information related to the specified topic.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Eventbus.V1.TopicInfo GetTopic(global::Eventbus.V1.TopicRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTopic(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///
      /// Get the topic Information related to the specified topic.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Eventbus.V1.TopicInfo GetTopic(global::Eventbus.V1.TopicRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetTopic, null, options, request);
      }
      /// <summary>
      ///
      /// Get the topic Information related to the specified topic.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Eventbus.V1.TopicInfo> GetTopicAsync(global::Eventbus.V1.TopicRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetTopicAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///
      /// Get the topic Information related to the specified topic.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Eventbus.V1.TopicInfo> GetTopicAsync(global::Eventbus.V1.TopicRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetTopic, null, options, request);
      }
      /// <summary>
      ///
      /// Send a publish request to synchronously publish events to a topic.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Eventbus.V1.PublishResponse Publish(global::Eventbus.V1.PublishRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Publish(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///
      /// Send a publish request to synchronously publish events to a topic.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Eventbus.V1.PublishResponse Publish(global::Eventbus.V1.PublishRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Publish, null, options, request);
      }
      /// <summary>
      ///
      /// Send a publish request to synchronously publish events to a topic.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Eventbus.V1.PublishResponse> PublishAsync(global::Eventbus.V1.PublishRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PublishAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///
      /// Send a publish request to synchronously publish events to a topic.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Eventbus.V1.PublishResponse> PublishAsync(global::Eventbus.V1.PublishRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Publish, null, options, request);
      }
      /// <summary>
      ///
      /// Bidirectional Streaming RPC to publish events to the event bus.
      /// PublishRequest contains the batch of events to publish.
      ///
      /// The first PublishRequest of the stream identifies the topic to publish on.
      /// If any subsequent PublishRequest provides topic_name, it must match what
      /// was provided in the first PublishRequest; otherwise, the RPC returns an error
      /// with INVALID_ARGUMENT status.
      ///
      /// The server returns a PublishResponse for each PublishRequest when publish is
      /// complete for the batch. A client does not have to wait for a PublishResponse
      /// before sending a new PublishRequest, i.e. multiple publish batches can be queued
      /// up, which allows for higher publish rate as a client can asynchronously
      /// publish more events while publishes are still in flight on the server side.
      ///
      /// PublishResponse holds a PublishResult for each event published that indicates success
      /// or failure of the publish. A client can then retry the publish as needed before sending
      /// more PublishRequests for new events to publish.
      ///
      /// A client must send a valid publish request with one or more events every 70 seconds to hold on to the stream.
      /// Otherwise, the server closes the stream and notifies the client. Once the client is notified of the stream closure,
      /// it must make a new PublishStream call to resume publishing.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Eventbus.V1.PublishRequest, global::Eventbus.V1.PublishResponse> PublishStream(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PublishStream(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///
      /// Bidirectional Streaming RPC to publish events to the event bus.
      /// PublishRequest contains the batch of events to publish.
      ///
      /// The first PublishRequest of the stream identifies the topic to publish on.
      /// If any subsequent PublishRequest provides topic_name, it must match what
      /// was provided in the first PublishRequest; otherwise, the RPC returns an error
      /// with INVALID_ARGUMENT status.
      ///
      /// The server returns a PublishResponse for each PublishRequest when publish is
      /// complete for the batch. A client does not have to wait for a PublishResponse
      /// before sending a new PublishRequest, i.e. multiple publish batches can be queued
      /// up, which allows for higher publish rate as a client can asynchronously
      /// publish more events while publishes are still in flight on the server side.
      ///
      /// PublishResponse holds a PublishResult for each event published that indicates success
      /// or failure of the publish. A client can then retry the publish as needed before sending
      /// more PublishRequests for new events to publish.
      ///
      /// A client must send a valid publish request with one or more events every 70 seconds to hold on to the stream.
      /// Otherwise, the server closes the stream and notifies the client. Once the client is notified of the stream closure,
      /// it must make a new PublishStream call to resume publishing.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Eventbus.V1.PublishRequest, global::Eventbus.V1.PublishResponse> PublishStream(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_PublishStream, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override PubSubClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new PubSubClient(configuration);
      }
    }

  }
}
#endregion
