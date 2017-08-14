using System;
using ObjCRuntime;

namespace SkyWay
{
//[Native]
public enum SKWPeerErrorEnum : int
{
	NoError = 0,
	BrowserIncompatible = -1,
	Disconnected = -2,
	InvalidId = -3,
	InvalidKey = -4,
	Network = -5,
	PeerUnavailable = -6,
	SslUnavailable = -7,
	ServerError = -8,
	SocketError = -9,
	SocketClosed = -10,
	UnavailableId = -11,
	Webrtc = -20
}

public enum RTCICEConnectionState : uint
{
	New,
	Checking,
	Connected,
	Completed,
	Failed,
	Disconnected,
	Closed,
	Max
}

public enum RTCICEGatheringState : uint
{
	New,
	Gathering,
	Complete
}

public enum RTCSignalingState : uint
{
	Stable,
	HaveLocalOffer,
	HaveLocalPrAnswer,
	HaveRemoteOffer,
	HaveRemotePrAnswer,
	Closed
}

public enum RTCStatsOutputLevel : uint
{
	Standard,
	Debug
}

public enum RTCSourceState : uint
{
	Initializing,
	Live,
	Ended,
	Muted
}

public enum RTCTrackState : uint
{
	Live,
	Ended
}

//[Native]
public enum SKWSerializationEnum : uint
{
	Binary = 0,
	BinaryUtf8 = 1,
	Json = 2,
	None = 3
}

public enum RTCDataChannelState : uint
{
	Connecting,
	Open,
	Closing,
	Closed
}

//[Native]
public enum SKWDataConnectionEventEnum : uint
{
	Open,
	Data,
	Close,
	Error
}

//[Native]
public enum SKWCameraPositionEnum : uint
{
	Unspecified = 0,
	Back = 1,
	Front = 2
}

//[Native]
public enum SKWCameraModeEnum : uint
{
	Switchable = 0,
	Adjustable = 1
}

//[Native]
public enum SKWMediaConnectionEventEnum : uint
{
	Stream,
	RemoveStream,
	Close,
	Error
}

//[Native]
public enum SKWPeerTypeEnum : uint
{
	Skyway = 0,
	Peerjs = 1
}

//[Native]
public enum SKWDebugLevelEnum : uint
{
	NoLogs = 0,
	OnlyError = 1,
	ErrorAndWarning = 2,
	AllLogs = 3
}

//[Native]
public enum SKWPeerEventEnum : uint
{
	Open,
	Connection,
	Call,
	Close,
	Disconnected,
	Error,
	Reachability
}
}