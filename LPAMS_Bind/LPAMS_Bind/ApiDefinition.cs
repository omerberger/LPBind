using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace LPAMS_SHARP
{
	//[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double AMSVersionNumber;
		[Field("AMSVersionNumber", "__Internal")]
		double AMSVersionNumber { get; }

		// extern const unsigned char [] AMSVersionString;
		[Field("AMSVersionString", "__Internal")]
		byte[] AMSVersionString { get; }
	}
}
