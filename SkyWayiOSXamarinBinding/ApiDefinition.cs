using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using CoreFoundation;
using SkyWay;

namespace SkyWay.API
{
	// @interface SKWPeerError : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface SKWPeerError : INSCopying
	{
		// @property (readonly, nonatomic) SKWPeerErrorEnum type;
		[Export("type")]
		SKWPeerErrorEnum Type { get; }

		// @property (readonly, nonatomic) NSString * message;
		[Export("message")]
		string Message { get; }

		// @property (readonly, nonatomic) NSError * error;
		[Export("error")]
		NSError Error { get; }
	}
	/*
	// @protocol RTCPeerConnectionDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface RTCPeerConnectionDelegate
	{
		// @required -(void)peerConnection:(RTCPeerConnection *)peerConnection signalingStateChanged:(RTCSignalingState)stateChanged;
		[Abstract]
		[Export("peerConnection:signalingStateChanged:")]
		void PeerConnection(RTCPeerConnection peerConnection, RTCSignalingState stateChanged);

		// @required -(void)peerConnection:(RTCPeerConnection *)peerConnection addedStream:(RTCMediaStream *)stream;
		[Abstract]
		[Export("peerConnection:addedStream:")]
		void PeerConnection(RTCPeerConnection peerConnection, RTCMediaStream stream);

		// @required -(void)peerConnection:(RTCPeerConnection *)peerConnection removedStream:(RTCMediaStream *)stream;
		[Abstract]
		[Export("peerConnection:removedStream:")]
		void PeerConnection(RTCPeerConnection peerConnection, RTCMediaStream stream);

		// @required -(void)peerConnectionOnRenegotiationNeeded:(RTCPeerConnection *)peerConnection;
		[Abstract]
		[Export("peerConnectionOnRenegotiationNeeded:")]
		void PeerConnectionOnRenegotiationNeeded(RTCPeerConnection peerConnection);

		// @required -(void)peerConnection:(RTCPeerConnection *)peerConnection iceConnectionChanged:(RTCICEConnectionState)newState;
		[Abstract]
		[Export("peerConnection:iceConnectionChanged:")]
		void PeerConnection(RTCPeerConnection peerConnection, RTCICEConnectionState newState);

		// @required -(void)peerConnection:(RTCPeerConnection *)peerConnection iceGatheringChanged:(RTCICEGatheringState)newState;
		[Abstract]
		[Export("peerConnection:iceGatheringChanged:")]
		void PeerConnection(RTCPeerConnection peerConnection, RTCICEGatheringState newState);

		// @required -(void)peerConnection:(RTCPeerConnection *)peerConnection gotICECandidate:(RTCICECandidate *)candidate;
		[Abstract]
		[Export("peerConnection:gotICECandidate:")]
		void PeerConnection(RTCPeerConnection peerConnection, RTCICECandidate candidate);

		// @required -(void)peerConnection:(RTCPeerConnection *)peerConnection didOpenDataChannel:(RTCDataChannel *)dataChannel;
		[Abstract]
		[Export("peerConnection:didOpenDataChannel:")]
		void PeerConnection(RTCPeerConnection peerConnection, RTCDataChannel dataChannel);
	}
	*/ /*
	// @interface RTCPeerConnection : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface RTCPeerConnection
	{
		[Wrap("WeakDelegate")]
		RTCPeerConnectionDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<RTCPeerConnectionDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) NSArray * localStreams;
		[Export("localStreams", ArgumentSemantic.Strong)]
		[Verify(StronglyTypedNSArray)]
		NSObject[] LocalStreams { get; }

		// @property (readonly, assign, nonatomic) RTCSessionDescription * localDescription;
		[Export("localDescription", ArgumentSemantic.Assign)]
		RTCSessionDescription LocalDescription { get; }

		// @property (readonly, assign, nonatomic) RTCSessionDescription * remoteDescription;
		[Export("remoteDescription", ArgumentSemantic.Assign)]
		RTCSessionDescription RemoteDescription { get; }

		// @property (readonly, assign, nonatomic) RTCSignalingState signalingState;
		[Export("signalingState", ArgumentSemantic.Assign)]
		RTCSignalingState SignalingState { get; }

		// @property (readonly, assign, nonatomic) RTCICEConnectionState iceConnectionState;
		[Export("iceConnectionState", ArgumentSemantic.Assign)]
		RTCICEConnectionState IceConnectionState { get; }

		// @property (readonly, assign, nonatomic) RTCICEGatheringState iceGatheringState;
		[Export("iceGatheringState", ArgumentSemantic.Assign)]
		RTCICEGatheringState IceGatheringState { get; }

		// -(BOOL)addStream:(RTCMediaStream *)stream;
		[Export("addStream:")]
		bool AddStream(RTCMediaStream stream);

		// -(void)removeStream:(RTCMediaStream *)stream;
		[Export("removeStream:")]
		void RemoveStream(RTCMediaStream stream);

		// -(RTCDataChannel *)createDataChannelWithLabel:(NSString *)label config:(RTCDataChannelInit *)config;
		[Export("createDataChannelWithLabel:config:")]
		RTCDataChannel CreateDataChannelWithLabel(string label, RTCDataChannelInit config);

		// -(void)createOfferWithDelegate:(id<RTCSessionDescriptionDelegate>)delegate constraints:(RTCMediaConstraints *)constraints;
		[Export("createOfferWithDelegate:constraints:")]
		void CreateOfferWithDelegate(RTCSessionDescriptionDelegate @delegate, RTCMediaConstraints constraints);

		// -(void)createAnswerWithDelegate:(id<RTCSessionDescriptionDelegate>)delegate constraints:(RTCMediaConstraints *)constraints;
		[Export("createAnswerWithDelegate:constraints:")]
		void CreateAnswerWithDelegate(RTCSessionDescriptionDelegate @delegate, RTCMediaConstraints constraints);

		// -(void)setLocalDescriptionWithDelegate:(id<RTCSessionDescriptionDelegate>)delegate sessionDescription:(RTCSessionDescription *)sdp;
		[Export("setLocalDescriptionWithDelegate:sessionDescription:")]
		void SetLocalDescriptionWithDelegate(RTCSessionDescriptionDelegate @delegate, RTCSessionDescription sdp);

		// -(void)setRemoteDescriptionWithDelegate:(id<RTCSessionDescriptionDelegate>)delegate sessionDescription:(RTCSessionDescription *)sdp;
		[Export("setRemoteDescriptionWithDelegate:sessionDescription:")]
		void SetRemoteDescriptionWithDelegate(RTCSessionDescriptionDelegate @delegate, RTCSessionDescription sdp);

		// -(BOOL)setConfiguration:(RTCConfiguration *)configuration;
		[Export("setConfiguration:")]
		bool SetConfiguration(RTCConfiguration configuration);

		// -(BOOL)addICECandidate:(RTCICECandidate *)candidate;
		[Export("addICECandidate:")]
		bool AddICECandidate(RTCICECandidate candidate);

		// -(void)close;
		[Export("close")]
		void Close();

		// -(BOOL)getStatsWithDelegate:(id<RTCStatsDelegate>)delegate mediaStreamTrack:(RTCMediaStreamTrack *)mediaStreamTrack statsOutputLevel:(RTCStatsOutputLevel)statsOutputLevel;
		[Export("getStatsWithDelegate:mediaStreamTrack:statsOutputLevel:")]
		bool GetStatsWithDelegate(RTCStatsDelegate @delegate, RTCMediaStreamTrack mediaStreamTrack, RTCStatsOutputLevel statsOutputLevel);
	}
	*/
	// @interface SKWConnection : NSObject
	[BaseType(typeof(NSObject))]
	interface SKWConnection
	{
		// @property (readonly, nonatomic) NSString * connectionId;
		[Export("connectionId")]
		string ConnectionId { get; }

		// @property (readonly, nonatomic) NSDictionary * payload;
		[Export("payload")]
		NSDictionary Payload { get; }

		// @property (readonly, nonatomic) NSString * metadata;
		[Export("metadata")]
		string Metadata { get; }

		// @property (readonly, nonatomic) BOOL isOpen;
		[Export("isOpen")]
		bool IsOpen { get; }

		// @property (readonly, nonatomic) NSString * peer;
		[Export("peer")]
		string Peer { get; }

		// @property (readonly, nonatomic) NSString * type;
		[Export("type")]
		string Type { get; }

		// @property (readonly, nonatomic) NSString * label;
		[Export("label")]
		string Label { get; }

		// @property (readonly, nonatomic) BOOL reliable;
		[Export("reliable")]
		bool Reliable { get; }

		// @property (readonly, nonatomic) SKWSerializationEnum serialization;
		[Export("serialization")]
		SKWSerializationEnum Serialization { get; }

		// @property (readonly, nonatomic, weak) SKWPeer * provider;
		[Export("provider", ArgumentSemantic.Weak)]
		SKWPeer Provider { get; }

		// @property (readonly, nonatomic) RTCPeerConnection * peerConnection;
		[Export("peerConnection")]
		IntPtr PeerConnection { get; }
		//RTCPeerConnection PeerConnection { get; }

		// -(void)getPeerConnectionState:(BOOL)bOutputDebug callback:(void (^)(NSArray *))callback;
		[Export("getPeerConnectionState:callback:")]
		void GetPeerConnectionState(bool bOutputDebug, Action<NSArray> callback);
	}

	// @interface SKWConnectOption : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface SKWConnectOption : INSCopying
	{
		// @property (nonatomic) NSString * label;
		[Export("label")]
		string Label { get; set; }

		// @property (nonatomic) NSString * metadata;
		[Export("metadata")]
		string Metadata { get; set; }

		// @property (nonatomic) SKWSerializationEnum serialization;
		[Export("serialization", ArgumentSemantic.Assign)]
		SKWSerializationEnum Serialization { get; set; }

		// @property (nonatomic) BOOL reliable;
		[Export("reliable")]
		bool Reliable { get; set; }
	}

	// @interface RTCDataChannelInit : NSObject
	[BaseType(typeof(NSObject))]
	interface RTCDataChannelInit
	{
		// @property (nonatomic) BOOL isOrdered;
		[Export("isOrdered")]
		bool IsOrdered { get; set; }

		// @property (nonatomic) NSInteger maxRetransmitTimeMs;
		[Export("maxRetransmitTimeMs")]
		nint MaxRetransmitTimeMs { get; set; }

		// @property (nonatomic) NSInteger maxRetransmits;
		[Export("maxRetransmits")]
		nint MaxRetransmits { get; set; }

		// @property (nonatomic) BOOL isNegotiated;
		[Export("isNegotiated")]
		bool IsNegotiated { get; set; }

		// @property (nonatomic) NSInteger streamId;
		[Export("streamId")]
		nint StreamId { get; set; }

		// @property (nonatomic) NSString * protocol;
		[Export("protocol")]
		string Protocol { get; set; }
	}

	// @interface RTCDataBuffer : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface RTCDataBuffer
	{
		// @property (readonly, nonatomic) NSData * data;
		[Export("data")]
		NSData Data { get; }

		// @property (readonly, nonatomic) BOOL isBinary;
		[Export("isBinary")]
		bool IsBinary { get; }

		// -(instancetype)initWithData:(NSData *)data isBinary:(BOOL)isBinary;
		[Export("initWithData:isBinary:")]
		IntPtr Constructor(NSData data, bool isBinary);
	}

	// @protocol RTCDataChannelDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface RTCDataChannelDelegate
	{
		// @required -(void)channelDidChangeState:(RTCDataChannel *)channel;
		[Abstract]
		[Export("channelDidChangeState:")]
		void ChannelDidChangeState(RTCDataChannel channel);

		// @required -(void)channel:(RTCDataChannel *)channel didReceiveMessageWithBuffer:(RTCDataBuffer *)buffer;
		[Abstract]
		[Export("channel:didReceiveMessageWithBuffer:")]
		void Channel(RTCDataChannel channel, RTCDataBuffer buffer);

		// @optional -(void)channel:(RTCDataChannel *)channel didChangeBufferedAmount:(NSUInteger)amount;
		[Export("channel:didChangeBufferedAmount:")]
		void Channel(RTCDataChannel channel, nuint amount);
	}

	// @interface RTCDataChannel : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface RTCDataChannel
	{
		// @property (readonly, nonatomic) NSString * label;
		[Export("label")]
		string Label { get; }

		// @property (readonly, nonatomic) BOOL isReliable;
		[Export("isReliable")]
		bool IsReliable { get; }

		// @property (readonly, nonatomic) BOOL isOrdered;
		[Export("isOrdered")]
		bool IsOrdered { get; }

		// @property (readonly, nonatomic) NSUInteger maxRetransmitTime;
		[Export("maxRetransmitTime")]
		nuint MaxRetransmitTime { get; }

		// @property (readonly, nonatomic) NSUInteger maxRetransmits;
		[Export("maxRetransmits")]
		nuint MaxRetransmits { get; }

		// @property (readonly, nonatomic) NSString * protocol;
		[Export("protocol")]
		string Protocol { get; }

		// @property (readonly, nonatomic) BOOL isNegotiated;
		[Export("isNegotiated")]
		bool IsNegotiated { get; }

		// @property (readonly, nonatomic) NSInteger streamId;
		[Export("streamId")]
		nint StreamId { get; }

		// @property (readonly, nonatomic) RTCDataChannelState state;
		[Export("state")]
		RTCDataChannelState State { get; }

		// @property (readonly, nonatomic) NSUInteger bufferedAmount;
		[Export("bufferedAmount")]
		nuint BufferedAmount { get; }

		[Wrap("WeakDelegate")]
		RTCDataChannelDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<RTCDataChannelDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)close;
		[Export("close")]
		void Close();

		// -(BOOL)sendData:(RTCDataBuffer *)data;
		[Export("sendData:")]
		bool SendData(RTCDataBuffer data);
	}

	// @interface SKWDataChannel : RTCDataChannel
	[BaseType(typeof(RTCDataChannel))]
	interface SKWDataChannel
	{
	}

	// @interface SKWDataConnection : SKWConnection
	[BaseType(typeof(SKWConnection))]
	interface SKWDataConnection
	{
		// @property (readonly, nonatomic) SKWDataChannel * dataChannel;
		[Export("dataChannel")]
		SKWDataChannel DataChannel { get; }

		// @property (readonly, nonatomic) NSUInteger bufferSize;
		[Export("bufferSize")]
		nuint BufferSize { get; }

		// -(BOOL)send:(NSObject *)data;
		[Export("send:")]
		bool Send(NSObject data);

		// -(void)close;
		[Export("close")]
		void Close();

		// -(void)on:(SKWDataConnectionEventEnum)event callback:(void (^)(NSObject *))callback;
		[Export("on:callback:")]
		void On(SKWDataConnectionEventEnum @event, Action<NSObject> callback);
	}

	// @interface SKWMediaConstraints : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface SKWMediaConstraints : INSCopying
	{
		// @property (nonatomic) BOOL videoFlag;
		[Export("videoFlag")]
		bool VideoFlag { get; set; }

		// @property (nonatomic) BOOL audioFlag;
		[Export("audioFlag")]
		bool AudioFlag { get; set; }

		// @property (nonatomic) SKWCameraPositionEnum cameraPosition;
		[Export("cameraPosition", ArgumentSemantic.Assign)]
		SKWCameraPositionEnum CameraPosition { get; set; }

		// @property (nonatomic) SKWCameraModeEnum cameraMode;
		[Export("cameraMode", ArgumentSemantic.Assign)]
		SKWCameraModeEnum CameraMode { get; set; }

		// @property (nonatomic) NSUInteger maxWidth;
		[Export("maxWidth")]
		nuint MaxWidth { get; set; }

		// @property (nonatomic) NSUInteger minWidth;
		[Export("minWidth")]
		nuint MinWidth { get; set; }

		// @property (nonatomic) NSUInteger maxHeight;
		[Export("maxHeight")]
		nuint MaxHeight { get; set; }

		// @property (nonatomic) NSUInteger minHeight;
		[Export("minHeight")]
		nuint MinHeight { get; set; }

		// @property (nonatomic) NSUInteger maxFrameRate;
		[Export("maxFrameRate")]
		nuint MaxFrameRate { get; set; }

		// @property (nonatomic) NSUInteger minFrameRate;
		[Export("minFrameRate")]
		nuint MinFrameRate { get; set; }
	}

	// @interface SKWMediaStream : NSObject
	[BaseType(typeof(NSObject))]
	interface SKWMediaStream
	{
		// -(void)close;
		[Export("close")]
		void Close();

		// -(NSUInteger)getVideoTracks;
		[Export("getVideoTracks")]
		//[Verify(MethodToProperty)]
		nuint VideoTracks { get; }

		// -(void)setEnableVideoTrack:(NSUInteger)pos enable:(BOOL)enable;
		[Export("setEnableVideoTrack:enable:")]
		void SetEnableVideoTrack(nuint pos, bool enable);

		// -(BOOL)getEnableVideoTrack:(NSUInteger)pos;
		[Export("getEnableVideoTrack:")]
		bool GetEnableVideoTrack(nuint pos);

		// -(NSUInteger)getAudioTracks;
		[Export("getAudioTracks")]
		//[Verify(MethodToProperty)]
		nuint AudioTracks { get; }

		// -(void)setEnableAudioTrack:(NSUInteger)pos enable:(BOOL)enable;
		[Export("setEnableAudioTrack:enable:")]
		void SetEnableAudioTrack(nuint pos, bool enable);

		// -(BOOL)getEnableAudioTrack:(NSUInteger)pos;
		[Export("getEnableAudioTrack:")]
		bool GetEnableAudioTrack(nuint pos);

		// -(BOOL)setCameraPosition:(SKWCameraPositionEnum)pos;
		[Export("setCameraPosition:")]
		bool SetCameraPosition(SKWCameraPositionEnum pos);

		// -(SKWCameraPositionEnum)getCameraPosition;
		[Export("getCameraPosition")]
		//[Verify(MethodToProperty)]
		SKWCameraPositionEnum CameraPosition { get; }

		// -(BOOL)switchCamera;
		[Export("switchCamera")]
		//[Verify(MethodToProperty)]
		bool SwitchCamera();
		//bool SwitchCamera { get; }
	}

	// @interface SKWNavigator : NSObject
	[BaseType(typeof(NSObject))]
	interface SKWNavigator
	{
		// +(void)initialize:(SKWPeer *)peer;
		[Static]
		[Export("initialize:")]
		void Initialize(SKWPeer peer);

		// +(void)terminate;
		[Static]
		[Export("terminate")]
		void Terminate();

		// +(SKWMediaStream *)getUserMedia:(SKWMediaConstraints *)constraints;
		[Static]
		[Export("getUserMedia:")]
		SKWMediaStream GetUserMedia(SKWMediaConstraints constraints);
	}

	// @interface SKWCallOption : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface SKWCallOption : INSCopying
	{
		// @property (nonatomic) NSString * metadata;
		[Export("metadata")]
		string Metadata { get; set; }
	}

	// @interface SKWVideo : UIView
	[BaseType(typeof(UIView))]
	interface SKWVideo
	{
		// -(BOOL)addSrc:(SKWMediaStream *)stream track:(NSUInteger)trackNo;
		[Export("addSrc:track:")]
		bool AddSrc(SKWMediaStream stream, nuint trackNo);

		// -(BOOL)removeSrc:(SKWMediaStream *)stream track:(NSUInteger)trackNo;
		[Export("removeSrc:track:")]
		bool RemoveSrc(SKWMediaStream stream, nuint trackNo);

		// -(void)setDidChangeVideoSizeCallback:(void (^)(CGSize))callback;
		[Export("setDidChangeVideoSizeCallback:")]
		void SetDidChangeVideoSizeCallback(Action<CGSize> callback);

		// -(void)setMirrorViewing:(BOOL)mirror;
		[Export("setMirrorViewing:")]
		void SetMirrorViewing(bool mirror);
	}

	// @interface SKWMediaConnection : SKWConnection
	[BaseType(typeof(SKWConnection))]
	interface SKWMediaConnection
	{
		// -(void)answer;
		[Export("answer")]
		void Answer();

		// -(void)answer:(SKWMediaStream *)stream;
		[Export("answer:")]
		void Answer(SKWMediaStream stream);

		// -(void)close;
		[Export("close")]
		void Close();

		// -(void)on:(SKWMediaConnectionEventEnum)event callback:(void (^)(NSObject *))callback;
		[Export("on:callback:")]
		void On(SKWMediaConnectionEventEnum _event, Action<NSObject> callback);
	}

	// @interface SKWPeerOption : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface SKWPeerOption : INSCopying
	{
		// @property (nonatomic) SKWPeerTypeEnum type;
		[Export("type", ArgumentSemantic.Assign)]
		SKWPeerTypeEnum Type { get; set; }

		// @property (nonatomic) NSString * key;
		[Export("key")]
		string Key { get; set; }

		// @property (nonatomic) NSString * host;
		[Export("host")]
		string Host { get; set; }

		// @property (nonatomic) NSInteger port;
		[Export("port")]
		nint Port { get; set; }

		// @property (nonatomic) NSString * path;
		[Export("path")]
		string Path { get; set; }

		// @property (nonatomic) BOOL secure;
		[Export("secure")]
		bool Secure { get; set; }

		// @property (nonatomic) NSArray * config;
		[Export("config", ArgumentSemantic.Assign)]
		//[Verify(StronglyTypedNSArray)]
		NSObject[] Config { get; set; }

		// @property (nonatomic) SKWDebugLevelEnum debug;
		[Export("debug", ArgumentSemantic.Assign)]
		SKWDebugLevelEnum Debug { get; set; }

		// @property (nonatomic) NSString * domain;
		[Export("domain")]
		string Domain { get; set; }

		// @property (nonatomic) BOOL turn;
		[Export("turn")]
		bool Turn { get; set; }

		// @property (nonatomic) BOOL useH264;
		[Export("useH264")]
		bool UseH264 { get; set; }
	}

	// @interface SKWIceConfig : NSObject <NSCopying>
	[BaseType(typeof(NSObject))]
	interface SKWIceConfig : INSCopying
	{
		// @property (nonatomic) NSString * url;
		[Export("url")]
		string Url { get; set; }

		// @property (nonatomic) NSString * username;
		[Export("username")]
		string Username { get; set; }

		// @property (nonatomic) NSString * credential;
		[Export("credential")]
		string Credential { get; set; }
	}

	// @interface SKWPeer : NSObject
	[BaseType(typeof(NSObject))]
	interface SKWPeer
	{
		// @property (readonly, nonatomic) NSString * identity;
		[Export("identity")]
		string Identity { get; }

		// @property (readonly, nonatomic) NSMutableDictionary * connections;
		[Export("connections")]
		NSMutableDictionary Connections { get; }

		// @property (readonly, nonatomic) BOOL isDisconnected;
		[Export("isDisconnected")]
		bool IsDisconnected { get; }

		// @property (readonly, nonatomic) BOOL isDestroyed;
		[Export("isDestroyed")]
		bool IsDestroyed { get; }

		// -(instancetype)initWithOptions:(SKWPeerOption *)options;
		[Export("initWithOptions:")]
		IntPtr Constructor(SKWPeerOption options);

		// -(instancetype)initWithId:(NSString *)peerId options:(SKWPeerOption *)options;
		[Export("initWithId:options:")]
		IntPtr Constructor(string peerId, SKWPeerOption options);

		// -(SKWDataConnection *)connectWithId:(NSString *)peerId;
		[Export("connectWithId:")]
		SKWDataConnection ConnectWithId(string peerId);

		// -(SKWDataConnection *)connectWithId:(NSString *)peerId options:(SKWConnectOption *)options;
		[Export("connectWithId:options:")]
		SKWDataConnection ConnectWithId(string peerId, SKWConnectOption options);

		// -(SKWMediaConnection *)callWithId:(NSString *)peerId stream:(SKWMediaStream *)stream;
		[Export("callWithId:stream:")]
		SKWMediaConnection CallWithId(string peerId, SKWMediaStream stream);

		// -(SKWMediaConnection *)callWithId:(NSString *)peerId stream:(SKWMediaStream *)stream options:(SKWCallOption *)options;
		[Export("callWithId:stream:options:")]
		SKWMediaConnection CallWithId(string peerId, SKWMediaStream stream, SKWCallOption options);

		// -(void)on:(SKWPeerEventEnum)event callback:(void (^)(NSObject *))callback;
		[Export("on:callback:")]
		void On(SKWPeerEventEnum _event, Action<NSObject> callback);

		// -(BOOL)disconnect;
		[Export("disconnect")]
		bool Disconnect();
		//[Verify(MethodToProperty)]
		//bool Disconnect { get; }

		// -(void)reconnect;
		[Export("reconnect")]
		void Reconnect();

		// -(BOOL)destroy;
		[Export("destroy")]
		bool Destroy();
		//[Verify(MethodToProperty)]
		//bool Destroy { get; }

		// -(void)listAllPeers:(void (^)(NSArray *))callback;
		[Export("listAllPeers:")]
		void ListAllPeers(Action<NSArray> callback);
	}



	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
	//
}
