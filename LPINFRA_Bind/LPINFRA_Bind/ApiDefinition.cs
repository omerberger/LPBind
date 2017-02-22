using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace LPINFRA_SHARP
{
	//[Static]
	[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const _Nonnull SRWebSocketErrorDomain;
		[Field("SRWebSocketErrorDomain", "__Internal")]
		NSString SRWebSocketErrorDomain { get; }

		// extern NSString *const _Nonnull SRHTTPResponseErrorKey;
		[Field("SRHTTPResponseErrorKey", "__Internal")]
		NSString SRHTTPResponseErrorKey { get; }
	}

	// @interface SRWebSocket : NSObject <NSStreamDelegate>
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface SRWebSocket : INSStreamDelegate
	{
		// @property (nonatomic) int closeCode;
		[Export("closeCode")]
		int CloseCode { get; set; }

		[Wrap("WeakDelegate")]
		[NullAllowed]
		SRWebSocketDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<SRWebSocketDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, strong) dispatch_queue_t _Nullable delegateDispatchQueue;
		[NullAllowed, Export("delegateDispatchQueue", ArgumentSemantic.Strong)]
		DispatchQueue DelegateDispatchQueue { get; set; }

		// @property (nonatomic, strong) NSOperationQueue * _Nullable delegateOperationQueue;
		[NullAllowed, Export("delegateOperationQueue", ArgumentSemantic.Strong)]
		NSOperationQueue DelegateOperationQueue { get; set; }

		// @property (readonly, assign, atomic) SRReadyState readyState;
		[Export("readyState", ArgumentSemantic.Assign)]
		SRReadyState ReadyState { get; }

		// @property (readonly, nonatomic, strong) NSURL * _Nullable url;
		[NullAllowed, Export("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; }

		// @property (readonly, assign, nonatomic) CFHTTPMessageRef _Nullable receivedHTTPHeaders;
		[NullAllowed, Export("receivedHTTPHeaders", ArgumentSemantic.Assign)]
		unsafe CFHTTPMessageRef* ReceivedHTTPHeaders { get; }

		// @property (copy, nonatomic) NSArray<NSHTTPCookie *> * _Nullable requestCookies;
		[NullAllowed, Export("requestCookies", ArgumentSemantic.Copy)]
		NSHttpCookie[] RequestCookies { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable protocol;
		[NullAllowed, Export("protocol")]
		string Protocol { get; }

		// @property (readonly, assign, nonatomic) BOOL allowsUntrustedSSLCertificates;
		[Export("allowsUntrustedSSLCertificates")]
		bool AllowsUntrustedSSLCertificates { get; }

		// -(instancetype _Nonnull)initWithURLRequest:(NSURLRequest * _Nonnull)request;
		[Export("initWithURLRequest:")]
		IntPtr Constructor(NSUrlRequest request);

		// -(instancetype _Nonnull)initWithURLRequest:(NSURLRequest * _Nonnull)request securityPolicy:(SRSecurityPolicy * _Nonnull)securityPolicy;
		[Export("initWithURLRequest:securityPolicy:")]
		IntPtr Constructor(NSUrlRequest request, SRSecurityPolicy securityPolicy);

		// -(instancetype _Nonnull)initWithURLRequest:(NSURLRequest * _Nonnull)request protocols:(NSArray<NSString *> * _Nullable)protocols;
		[Export("initWithURLRequest:protocols:")]
		IntPtr Constructor(NSUrlRequest request, [NullAllowed] string[] protocols);

		// -(instancetype _Nonnull)initWithURLRequest:(NSURLRequest * _Nonnull)request protocols:(NSArray<NSString *> * _Nullable)protocols allowsUntrustedSSLCertificates:(BOOL)allowsUntrustedSSLCertificates;
		[Export("initWithURLRequest:protocols:allowsUntrustedSSLCertificates:")]
		IntPtr Constructor(NSUrlRequest request, [NullAllowed] string[] protocols, bool allowsUntrustedSSLCertificates);

		// -(instancetype _Nonnull)initWithURLRequest:(NSURLRequest * _Nonnull)request protocols:(NSArray<NSString *> * _Nullable)protocols securityPolicy:(SRSecurityPolicy * _Nonnull)securityPolicy __attribute__((objc_designated_initializer));
		[Export("initWithURLRequest:protocols:securityPolicy:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSUrlRequest request, [NullAllowed] string[] protocols, SRSecurityPolicy securityPolicy);

		// -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)url;
		[Export("initWithURL:")]
		IntPtr Constructor(NSUrl url);

		// -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)url protocols:(NSArray<NSString *> * _Nullable)protocols;
		[Export("initWithURL:protocols:")]
		IntPtr Constructor(NSUrl url, [NullAllowed] string[] protocols);

		// -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)url securityPolicy:(SRSecurityPolicy * _Nonnull)securityPolicy;
		[Export("initWithURL:securityPolicy:")]
		IntPtr Constructor(NSUrl url, SRSecurityPolicy securityPolicy);

		// -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)url protocols:(NSArray<NSString *> * _Nullable)protocols allowsUntrustedSSLCertificates:(BOOL)allowsUntrustedSSLCertificates;
		[Export("initWithURL:protocols:allowsUntrustedSSLCertificates:")]
		IntPtr Constructor(NSUrl url, [NullAllowed] string[] protocols, bool allowsUntrustedSSLCertificates);

		// -(void)scheduleInRunLoop:(NSRunLoop * _Nonnull)runLoop forMode:(NSString * _Nonnull)mode;
		[Export("scheduleInRunLoop:forMode:")]
		void ScheduleInRunLoop(NSRunLoop runLoop, string mode);

		// -(void)unscheduleFromRunLoop:(NSRunLoop * _Nonnull)runLoop forMode:(NSString * _Nonnull)mode;
		[Export("unscheduleFromRunLoop:forMode:")]
		void UnscheduleFromRunLoop(NSRunLoop runLoop, string mode);

		// -(void)open;
		[Export("open")]
		void Open();

		// -(void)close;
		[Export("close")]
		void Close();

		// -(void)closeWithCode:(NSInteger)code reason:(NSString * _Nullable)reason;
		[Export("closeWithCode:reason:")]
		void CloseWithCode(nint code, [NullAllowed] string reason);

		// -(void)send:(id _Nullable)message __attribute__((deprecated("Please use `sendString:error:` or `sendData:error:` instead.")));
		[Export("send:")]
		void Send([NullAllowed] NSObject message);

		// -(BOOL)sendString:(NSString * _Nonnull)string error:(NSError * _Nullable * _Nullable)error;
		[Export("sendString:error:")]
		bool SendString(string @string, [NullAllowed] out NSError error);

		// -(BOOL)sendData:(NSData * _Nullable)data error:(NSError * _Nullable * _Nullable)error;
		[Export("sendData:error:")]
		bool SendData([NullAllowed] NSData data, [NullAllowed] out NSError error);

		// -(BOOL)sendDataNoCopy:(NSData * _Nullable)data error:(NSError * _Nullable * _Nullable)error;
		[Export("sendDataNoCopy:error:")]
		bool SendDataNoCopy([NullAllowed] NSData data, [NullAllowed] out NSError error);

		// -(BOOL)sendPing:(NSData * _Nullable)data error:(NSError * _Nullable * _Nullable)error;
		[Export("sendPing:error:")]
		bool SendPing([NullAllowed] NSData data, [NullAllowed] out NSError error);
	}

	// @protocol SRWebSocketDelegate <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface SRWebSocketDelegate
	{
		// @optional -(void)webSocket:(SRWebSocket * _Nonnull)webSocket didReceiveMessage:(id _Nonnull)message;
		[Export("webSocket:didReceiveMessage:")]
		void WebSocket(SRWebSocket webSocket, NSObject message);

		// @optional -(void)webSocket:(SRWebSocket * _Nonnull)webSocket didReceiveMessageWithString:(NSString * _Nonnull)string;
		[Export("webSocket:didReceiveMessageWithString:")]
		void WebSocket(SRWebSocket webSocket, string @string);

		// @optional -(void)webSocket:(SRWebSocket * _Nonnull)webSocket didReceiveMessageWithData:(NSData * _Nonnull)data;
		[Export("webSocket:didReceiveMessageWithData:")]
		void WebSocket(SRWebSocket webSocket, NSData data);

		// @optional -(void)webSocketDidOpen:(SRWebSocket * _Nonnull)webSocket;
		[Export("webSocketDidOpen:")]
		void WebSocketDidOpen(SRWebSocket webSocket);

		// @optional -(void)webSocket:(SRWebSocket * _Nonnull)webSocket didFailWithError:(NSError * _Nonnull)error;
		[Export("webSocket:didFailWithError:")]
		void WebSocket(SRWebSocket webSocket, NSError error);

		// @optional -(void)webSocket:(SRWebSocket * _Nonnull)webSocket didCloseWithCode:(NSInteger)code reason:(NSString * _Nullable)reason wasClean:(BOOL)wasClean;
		[Export("webSocket:didCloseWithCode:reason:wasClean:")]
		void WebSocket(SRWebSocket webSocket, nint code, [NullAllowed] string reason, bool wasClean);

		// @optional -(void)webSocket:(SRWebSocket * _Nonnull)webSocket didReceivePingWithData:(NSData * _Nullable)data;
		[Export("webSocket:didReceivePingWithData:")]
		void WebSocket(SRWebSocket webSocket, [NullAllowed] NSData data);

		// @optional -(void)webSocket:(SRWebSocket * _Nonnull)webSocket didReceivePong:(NSData * _Nullable)pongData;
		[Export("webSocket:didReceivePong:")]
		void WebSocket(SRWebSocket webSocket, [NullAllowed] NSData pongData);

		// @optional -(BOOL)webSocketShouldConvertTextFrameToString:(SRWebSocket * _Nonnull)webSocket;
		[Export("webSocketShouldConvertTextFrameToString:")]
		bool WebSocketShouldConvertTextFrameToString(SRWebSocket webSocket);
	}

	// typedef void (^SRDelegateBlock)(id<SRWebSocketDelegate> _Nullable, SRDelegateAvailableMethods);
	delegate void SRDelegateBlock([NullAllowed] SRWebSocketDelegate arg0, SRDelegateAvailableMethods arg1);

	// @interface SRDelegateController : NSObject
	[BaseType(typeof(NSObject))]
	interface SRDelegateController
	{
		[Wrap("WeakDelegate")]
		[NullAllowed]
		SRWebSocketDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<SRWebSocketDelegate> _Nullable delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, atomic) SRDelegateAvailableMethods availableDelegateMethods;
		[Export("availableDelegateMethods")]
		SRDelegateAvailableMethods AvailableDelegateMethods { get; }

		// @property (nonatomic, strong) dispatch_queue_t _Nullable dispatchQueue;
		[NullAllowed, Export("dispatchQueue", ArgumentSemantic.Strong)]
		DispatchQueue DispatchQueue { get; set; }

		// @property (nonatomic, strong) NSOperationQueue * _Nullable operationQueue;
		[NullAllowed, Export("operationQueue", ArgumentSemantic.Strong)]
		NSOperationQueue OperationQueue { get; set; }

		// -(void)performDelegateBlock:(SRDelegateBlock _Nonnull)block;
		[Export("performDelegateBlock:")]
		void PerformDelegateBlock(SRDelegateBlock block);

		// -(void)performDelegateQueueBlock:(dispatch_block_t _Nonnull)block;
		[Export("performDelegateQueueBlock:")]
		void PerformDelegateQueueBlock(dispatch_block_t block);
	}

	// @interface SRSecurityPolicy : NSObject
	[BaseType(typeof(NSObject))]
	interface SRSecurityPolicy
	{
		// +(instancetype _Nonnull)defaultPolicy;
		[Static]
		[Export("defaultPolicy")]
		SRSecurityPolicy DefaultPolicy();

		// +(instancetype _Nonnull)pinnningPolicyWithCertificates:(NSArray * _Nonnull)pinnedCertificates;
		[Static]
		[Export("pinnningPolicyWithCertificates:")]
		[Verify(StronglyTypedNSArray)]
		SRSecurityPolicy PinnningPolicyWithCertificates(NSObject[] pinnedCertificates);

		// -(instancetype _Nonnull)initWithCertificateChainValidationEnabled:(BOOL)enabled __attribute__((objc_designated_initializer));
		[Export("initWithCertificateChainValidationEnabled:")]
		[DesignatedInitializer]
		IntPtr Constructor(bool enabled);

		// -(void)updateSecurityOptionsInStream:(NSStream * _Nonnull)stream;
		[Export("updateSecurityOptionsInStream:")]
		void UpdateSecurityOptionsInStream(NSStream stream);

		// -(BOOL)evaluateServerTrust:(SecTrustRef _Nonnull)serverTrust forDomain:(NSString * _Nonnull)domain;
		[Export("evaluateServerTrust:forDomain:")]
		unsafe bool EvaluateServerTrust(SecTrustRef* serverTrust, string domain);
	}

	// typedef size_t (^stream_scanner)(NSData *);
	delegate nuint stream_scanner(NSData arg0);

	// typedef void (^data_callback)(SRWebSocket *, NSData *);
	delegate void data_callback(SRWebSocket arg0, NSData arg1);

	// @interface SRIOConsumer : NSObject
	[BaseType(typeof(NSObject))]
	interface SRIOConsumer
	{
		// @property (readonly, copy, nonatomic) stream_scanner consumer;
		[Export("consumer", ArgumentSemantic.Copy)]
		stream_scanner Consumer { get; }

		// @property (readonly, copy, nonatomic) data_callback handler;
		[Export("handler", ArgumentSemantic.Copy)]
		data_callback Handler { get; }

		// @property (assign, nonatomic) size_t bytesNeeded;
		[Export("bytesNeeded")]
		nuint BytesNeeded { get; set; }

		// @property (readonly, assign, nonatomic) BOOL readToCurrentFrame;
		[Export("readToCurrentFrame")]
		bool ReadToCurrentFrame { get; }

		// @property (readonly, assign, nonatomic) BOOL unmaskBytes;
		[Export("unmaskBytes")]
		bool UnmaskBytes { get; }

		// -(void)resetWithScanner:(stream_scanner)scanner handler:(data_callback)handler bytesNeeded:(size_t)bytesNeeded readToCurrentFrame:(BOOL)readToCurrentFrame unmaskBytes:(BOOL)unmaskBytes;
		[Export("resetWithScanner:handler:bytesNeeded:readToCurrentFrame:unmaskBytes:")]
		void ResetWithScanner(stream_scanner scanner, data_callback handler, nuint bytesNeeded, bool readToCurrentFrame, bool unmaskBytes);
	}

	// @interface SRIOConsumerPool : NSObject
	[BaseType(typeof(NSObject))]
	interface SRIOConsumerPool
	{
		// -(instancetype)initWithBufferCapacity:(NSUInteger)poolSize;
		[Export("initWithBufferCapacity:")]
		IntPtr Constructor(nuint poolSize);

		// -(SRIOConsumer *)consumerWithScanner:(stream_scanner)scanner handler:(data_callback)handler bytesNeeded:(size_t)bytesNeeded readToCurrentFrame:(BOOL)readToCurrentFrame unmaskBytes:(BOOL)unmaskBytes;
		[Export("consumerWithScanner:handler:bytesNeeded:readToCurrentFrame:unmaskBytes:")]
		SRIOConsumer ConsumerWithScanner(stream_scanner scanner, data_callback handler, nuint bytesNeeded, bool readToCurrentFrame, bool unmaskBytes);

		// -(void)returnConsumer:(SRIOConsumer *)consumer;
		[Export("returnConsumer:")]
		void ReturnConsumer(SRIOConsumer consumer);
	}

	// @interface SRRunLoopThread : NSThread
	[BaseType(typeof(NSThread))]
	interface SRRunLoopThread
	{
		// @property (readonly, nonatomic, strong) NSRunLoop * _Nonnull runLoop;
		[Export("runLoop", ArgumentSemantic.Strong)]
		NSRunLoop RunLoop { get; }

		// +(instancetype _Nonnull)sharedThread;
		[Static]
		[Export("sharedThread")]
		SRRunLoopThread SharedThread();
	}

	// @interface LPBSMobileProvision (UIApplication)
	[Category]
	[BaseType(typeof(UIApplication))]
	interface UIApplication_LPBSMobileProvision
	{
		// -(UIApplicationReleaseMode)releaseMode;
		[Export("releaseMode")]
		[Verify(MethodToProperty)]
		UIApplicationReleaseMode ReleaseMode { get; }
	}

	// @interface LPNetworkHelper : NSObject
	[BaseType(typeof(NSObject))]
	interface LPNetworkHelper
	{
		// +(NSString *)getExternalIPAddress;
		[Static]
		[Export("getExternalIPAddress")]
		[Verify(MethodToProperty)]
		string ExternalIPAddress { get; }
	}

	// @interface Workaround (CIContext)
	[Category]
	[BaseType(typeof(CIContext))]
	interface CIContext_Workaround
	{
		// +(CIContext * _Nonnull)lp_contextWithOptions:(NSDictionary<NSString *,id> * _Nullable)options;
		[Static]
		[Export("lp_contextWithOptions:")]
		CIContext Lp_contextWithOptions([NullAllowed] NSDictionary<NSString, NSObject> options);
	}

	[Static]
	[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double InfraVersionNumber;
		[Field("InfraVersionNumber", "__Internal")]
		double InfraVersionNumber { get; }

		// extern const unsigned char [] InfraVersionString;
		[Field("InfraVersionString", "__Internal")]
		byte[] InfraVersionString { get; }
	}
}