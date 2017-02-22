using System;
using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;


namespace LibTester
{
	// @interface LEStaticLib : NSObject
	[BaseType(typeof(NSObject))]
	interface LEStaticLib 
	{
		// @property (nonatomic, strong) NSString * someString;
		[Export("someString", ArgumentSemantic.Strong)]
		string SomeString { get; set; }

		// -(void)initiateSDK;
		[Export("initiateSDK")]
		void InitiateSDK();

		// -(void)showConversation;
		[Export("showConversation")]
		void ShowConversation();

		// -(NSString *)textFromSDK;
		[Export("textFromSDK")]
		//[Verify(MethodToProperty)]
		string TextFromSDK { get; }

		// +(NSString *)staticTextFromSDK;
		[Static]
		[Export("staticTextFromSDK")]
		//[Verify(MethodToProperty)]
		string StaticTextFromSDK { get; }
	}
}