using System;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace LPINFRA_SHARP
{
	[Native]
	public enum SRReadyState : nint
	{
		Connecting = 0,
		Open = 1,
		Closing = 2,
		Closed = 3
	}

	[Native]
	public enum SRStatusCode : nint
	{
		CodeNormal = 1000,
		CodeGoingAway = 1001,
		CodeProtocolError = 1002,
		CodeUnhandledType = 1003,
		NoStatusReceived = 1005,
		CodeAbnormal = 1006,
		CodeInvalidUTF8 = 1007,
		CodePolicyViolated = 1008,
		CodeMessageTooBig = 1009,
		CodeMissingExtension = 1010,
		CodeInternalError = 1011,
		CodeServiceRestart = 1012,
		CodeTryAgainLater = 1013,
		CodeTLSHandshake = 1015
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct SRDelegateAvailableMethods
	{
		public bool didReceiveMessage;

		public bool didReceiveMessageWithString;

		public bool didReceiveMessageWithData;

		public bool didOpen;

		public bool didFailWithError;

		public bool didCloseWithCode;

		public bool didReceivePing;

		public bool didReceivePong;

		public bool shouldConvertTextFrameToString;
	}

	static class CFunctions
	{
		// extern NSData * _Nonnull SRSHA1HashFromString (NSString * _Nonnull string);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern NSData SRSHA1HashFromString (NSString @string);

		// extern NSData * _Nonnull SRSHA1HashFromBytes (const char * _Nonnull bytes, size_t length);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe NSData SRSHA1HashFromBytes (sbyte* bytes, nuint length);

		// extern NSString * _Nonnull SRBase64EncodedStringFromData (NSData * _Nonnull data);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern NSString SRBase64EncodedStringFromData (NSData data);

		// extern NSString * _Nonnull SRURLOrigin (NSURL * _Nonnull url);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern NSString SRURLOrigin (NSUrl url);

		// extern BOOL SRURLRequiresSSL (NSURL * _Nonnull url);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern bool SRURLRequiresSSL (NSUrl url);

		// extern NSString * _Nullable SRBasicAuthorizationHeaderFromURL (NSURL * _Nonnull url);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern NSString SRBasicAuthorizationHeaderFromURL (NSUrl url);

		// extern NSString * _Nullable SRStreamNetworkServiceTypeFromURLRequest (NSURLRequest * _Nonnull request);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern NSString SRStreamNetworkServiceTypeFromURLRequest (NSUrlRequest request);

		// extern NSError * _Nonnull SRErrorWithDomainCodeDescription (NSString * _Nonnull domain, NSInteger code, NSString * _Nonnull description);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern NSError SRErrorWithDomainCodeDescription (NSString domain, nint code, NSString description);

		// extern NSError * _Nonnull SRErrorWithCodeDescription (NSInteger code, NSString * _Nonnull description);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern NSError SRErrorWithCodeDescription (nint code, NSString description);

		// extern NSError * _Nonnull SRErrorWithCodeDescriptionUnderlyingError (NSInteger code, NSString * _Nonnull description, NSError * _Nonnull underlyingError);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern NSError SRErrorWithCodeDescriptionUnderlyingError (nint code, NSString description, NSError underlyingError);

		// extern NSError * _Nonnull SRHTTPErrorWithCodeDescription (NSInteger httpCode, NSInteger errorCode, NSString * _Nonnull description);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern NSError SRHTTPErrorWithCodeDescription (nint httpCode, nint errorCode, NSString description);

		// NSException * _Nullable tryBlock (void (^ _Nonnull)(void) tryBlock) __attribute__((always_inline));
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern NSException tryBlock (Action tryBlock);
	}

	[Native]
	public enum UIApplicationReleaseMode : nint
	{
		Unknown,
		Sim,
		Dev,
		AdHoc,
		AppStore,
		Enterprise
	}
}
