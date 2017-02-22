using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace LPMESSAGINGSDK_SHARP
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double LPTTTAttributedLabelVersionNumber;
		[Field ("LPTTTAttributedLabelVersionNumber", "__Internal")]
		double LPTTTAttributedLabelVersionNumber { get; }

		// extern const unsigned char [] LPTTTAttributedLabelVersionString;
		[Field ("LPTTTAttributedLabelVersionString", "__Internal")]
		byte[] LPTTTAttributedLabelVersionString { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const kTTTStrikeOutAttributeName;
		[Field ("kTTTStrikeOutAttributeName", "__Internal")]
		NSString kTTTStrikeOutAttributeName { get; }

		// extern NSString *const kTTTBackgroundFillColorAttributeName;
		[Field ("kTTTBackgroundFillColorAttributeName", "__Internal")]
		NSString kTTTBackgroundFillColorAttributeName { get; }

		// extern NSString *const kTTTBackgroundFillPaddingAttributeName;
		[Field ("kTTTBackgroundFillPaddingAttributeName", "__Internal")]
		NSString kTTTBackgroundFillPaddingAttributeName { get; }

		// extern NSString *const kTTTBackgroundStrokeColorAttributeName;
		[Field ("kTTTBackgroundStrokeColorAttributeName", "__Internal")]
		NSString kTTTBackgroundStrokeColorAttributeName { get; }

		// extern NSString *const kTTTBackgroundLineWidthAttributeName;
		[Field ("kTTTBackgroundLineWidthAttributeName", "__Internal")]
		NSString kTTTBackgroundLineWidthAttributeName { get; }

		// extern NSString *const kTTTBackgroundCornerRadiusAttributeName;
		[Field ("kTTTBackgroundCornerRadiusAttributeName", "__Internal")]
		NSString kTTTBackgroundCornerRadiusAttributeName { get; }
	}

	// @protocol LPTTTAttributedLabel <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface LPTTTAttributedLabel
	{
		// @required @property (copy, nonatomic) id text;
		[Abstract]
		[Export ("text", ArgumentSemantic.Copy)]
		NSObject Text { get; set; }
	}

	// @interface LPTTTAttributedLabel : UILabel <LPTTTAttributedLabel, UIGestureRecognizerDelegate>
	[BaseType (typeof(UILabel))]
	[DisableDefaultCtor]
	interface LPTTTAttributedLabel : ILPTTTAttributedLabel, IUIGestureRecognizerDelegate
	{
		[Wrap ("WeakDelegate")]
		LPTTTAttributedLabelDelegate Delegate { get; set; }

		// @property (nonatomic, unsafe_unretained) id<LPTTTAttributedLabelDelegate> delegate __attribute__((iboutlet));
		[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; set; }

		// @property (assign, nonatomic) NSTextCheckingTypes enabledTextCheckingTypes;
		[Export ("enabledTextCheckingTypes")]
		ulong EnabledTextCheckingTypes { get; set; }

		// @property (readonly, nonatomic, strong) NSArray * links;
		[Export ("links", ArgumentSemantic.Strong)]
		[Verify (StronglyTypedNSArray)]
		NSObject[] Links { get; }

		// @property (nonatomic, strong) NSDictionary * linkAttributes;
		[Export ("linkAttributes", ArgumentSemantic.Strong)]
		NSDictionary LinkAttributes { get; set; }

		// @property (nonatomic, strong) NSDictionary * activeLinkAttributes;
		[Export ("activeLinkAttributes", ArgumentSemantic.Strong)]
		NSDictionary ActiveLinkAttributes { get; set; }

		// @property (nonatomic, strong) NSDictionary * inactiveLinkAttributes;
		[Export ("inactiveLinkAttributes", ArgumentSemantic.Strong)]
		NSDictionary InactiveLinkAttributes { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets linkBackgroundEdgeInset;
		[Export ("linkBackgroundEdgeInset", ArgumentSemantic.Assign)]
		UIEdgeInsets LinkBackgroundEdgeInset { get; set; }

		// @property (assign, nonatomic) BOOL extendsLinkTouchArea;
		[Export ("extendsLinkTouchArea")]
		bool ExtendsLinkTouchArea { get; set; }

		// @property (assign, nonatomic) CGFloat shadowRadius;
		[Export ("shadowRadius")]
		nfloat ShadowRadius { get; set; }

		// @property (assign, nonatomic) CGFloat highlightedShadowRadius;
		[Export ("highlightedShadowRadius")]
		nfloat HighlightedShadowRadius { get; set; }

		// @property (assign, nonatomic) CGSize highlightedShadowOffset;
		[Export ("highlightedShadowOffset", ArgumentSemantic.Assign)]
		CGSize HighlightedShadowOffset { get; set; }

		// @property (nonatomic, strong) UIColor * highlightedShadowColor;
		[Export ("highlightedShadowColor", ArgumentSemantic.Strong)]
		UIColor HighlightedShadowColor { get; set; }

		// @property (assign, nonatomic) CGFloat kern;
		[Export ("kern")]
		nfloat Kern { get; set; }

		// @property (assign, nonatomic) CGFloat firstLineIndent;
		[Export ("firstLineIndent")]
		nfloat FirstLineIndent { get; set; }

		// @property (assign, nonatomic) CGFloat lineSpacing;
		[Export ("lineSpacing")]
		nfloat LineSpacing { get; set; }

		// @property (assign, nonatomic) CGFloat minimumLineHeight;
		[Export ("minimumLineHeight")]
		nfloat MinimumLineHeight { get; set; }

		// @property (assign, nonatomic) CGFloat maximumLineHeight;
		[Export ("maximumLineHeight")]
		nfloat MaximumLineHeight { get; set; }

		// @property (assign, nonatomic) CGFloat lineHeightMultiple;
		[Export ("lineHeightMultiple")]
		nfloat LineHeightMultiple { get; set; }

		// @property (assign, nonatomic) UIEdgeInsets textInsets;
		[Export ("textInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets TextInsets { get; set; }

		// @property (assign, nonatomic) LPTTTAttributedLabelVerticalAlignment verticalAlignment;
		[Export ("verticalAlignment", ArgumentSemantic.Assign)]
		LPTTTAttributedLabelVerticalAlignment VerticalAlignment { get; set; }

		// @property (nonatomic, strong) NSAttributedString * attributedTruncationToken;
		[Export ("attributedTruncationToken", ArgumentSemantic.Strong)]
		NSAttributedString AttributedTruncationToken { get; set; }

		// @property (readonly, nonatomic, strong) UILongPressGestureRecognizer * longPressGestureRecognizer;
		[Export ("longPressGestureRecognizer", ArgumentSemantic.Strong)]
		UILongPressGestureRecognizer LongPressGestureRecognizer { get; }

		// +(CGSize)sizeThatFitsAttributedString:(NSAttributedString *)attributedString withConstraints:(CGSize)size limitedToNumberOfLines:(NSUInteger)numberOfLines;
		[Static]
		[Export ("sizeThatFitsAttributedString:withConstraints:limitedToNumberOfLines:")]
		CGSize SizeThatFitsAttributedString (NSAttributedString attributedString, CGSize size, nuint numberOfLines);

		// -(void)setText:(id)text;
		[Export ("setText:")]
		void SetText (NSObject text);

		// -(void)setText:(id)text afterInheritingLabelAttributesAndConfiguringWithBlock:(NSMutableAttributedString *(^)(NSMutableAttributedString *))block;
		[Export ("setText:afterInheritingLabelAttributesAndConfiguringWithBlock:")]
		void SetText (NSObject text, Func<NSMutableAttributedString, NSMutableAttributedString> block);

		// @property (readwrite, copy, nonatomic) NSAttributedString * attributedText;
		[Export ("attributedText", ArgumentSemantic.Copy)]
		NSAttributedString AttributedText { get; set; }

		// -(void)addLink:(LPTTTAttributedLabelLink *)link;
		[Export ("addLink:")]
		void AddLink (LPTTTAttributedLabelLink link);

		// -(LPTTTAttributedLabelLink *)addLinkWithTextCheckingResult:(NSTextCheckingResult *)result;
		[Export ("addLinkWithTextCheckingResult:")]
		LPTTTAttributedLabelLink AddLinkWithTextCheckingResult (NSTextCheckingResult result);

		// -(LPTTTAttributedLabelLink *)addLinkWithTextCheckingResult:(NSTextCheckingResult *)result attributes:(NSDictionary *)attributes;
		[Export ("addLinkWithTextCheckingResult:attributes:")]
		LPTTTAttributedLabelLink AddLinkWithTextCheckingResult (NSTextCheckingResult result, NSDictionary attributes);

		// -(LPTTTAttributedLabelLink *)addLinkToURL:(NSURL *)url withRange:(NSRange)range;
		[Export ("addLinkToURL:withRange:")]
		LPTTTAttributedLabelLink AddLinkToURL (NSUrl url, NSRange range);

		// -(LPTTTAttributedLabelLink *)addLinkToAddress:(NSDictionary *)addressComponents withRange:(NSRange)range;
		[Export ("addLinkToAddress:withRange:")]
		LPTTTAttributedLabelLink AddLinkToAddress (NSDictionary addressComponents, NSRange range);

		// -(LPTTTAttributedLabelLink *)addLinkToPhoneNumber:(NSString *)phoneNumber withRange:(NSRange)range;
		[Export ("addLinkToPhoneNumber:withRange:")]
		LPTTTAttributedLabelLink AddLinkToPhoneNumber (string phoneNumber, NSRange range);

		// -(LPTTTAttributedLabelLink *)addLinkToDate:(NSDate *)date withRange:(NSRange)range;
		[Export ("addLinkToDate:withRange:")]
		LPTTTAttributedLabelLink AddLinkToDate (NSDate date, NSRange range);

		// -(LPTTTAttributedLabelLink *)addLinkToDate:(NSDate *)date timeZone:(NSTimeZone *)timeZone duration:(NSTimeInterval)duration withRange:(NSRange)range;
		[Export ("addLinkToDate:timeZone:duration:withRange:")]
		LPTTTAttributedLabelLink AddLinkToDate (NSDate date, NSTimeZone timeZone, double duration, NSRange range);

		// -(LPTTTAttributedLabelLink *)addLinkToTransitInformation:(NSDictionary *)components withRange:(NSRange)range;
		[Export ("addLinkToTransitInformation:withRange:")]
		LPTTTAttributedLabelLink AddLinkToTransitInformation (NSDictionary components, NSRange range);

		// -(BOOL)containslinkAtPoint:(CGPoint)point;
		[Export ("containslinkAtPoint:")]
		bool ContainslinkAtPoint (CGPoint point);

		// -(LPTTTAttributedLabelLink *)linkAtPoint:(CGPoint)point;
		[Export ("linkAtPoint:")]
		LPTTTAttributedLabelLink LinkAtPoint (CGPoint point);
	}

	// @protocol LPTTTAttributedLabelDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface LPTTTAttributedLabelDelegate
	{
		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didSelectLinkWithURL:(NSURL *)url;
		[Export ("attributedLabel:didSelectLinkWithURL:")]
		void DidSelectLinkWithURL (LPTTTAttributedLabel label, NSUrl url);

		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didSelectLinkWithAddress:(NSDictionary *)addressComponents;
		[Export ("attributedLabel:didSelectLinkWithAddress:")]
		void DidSelectLinkWithAddress (LPTTTAttributedLabel label, NSDictionary addressComponents);

		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didSelectLinkWithPhoneNumber:(NSString *)phoneNumber;
		[Export ("attributedLabel:didSelectLinkWithPhoneNumber:")]
		void DidSelectLinkWithPhoneNumber (LPTTTAttributedLabel label, string phoneNumber);

		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didSelectLinkWithDate:(NSDate *)date;
		[Export ("attributedLabel:didSelectLinkWithDate:")]
		void DidSelectLinkWithDate (LPTTTAttributedLabel label, NSDate date);

		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didSelectLinkWithDate:(NSDate *)date timeZone:(NSTimeZone *)timeZone duration:(NSTimeInterval)duration;
		[Export ("attributedLabel:didSelectLinkWithDate:timeZone:duration:")]
		void DidSelectLinkWithDate (LPTTTAttributedLabel label, NSDate date, NSTimeZone timeZone, double duration);

		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didSelectLinkWithTransitInformation:(NSDictionary *)components;
		[Export ("attributedLabel:didSelectLinkWithTransitInformation:")]
		void DidSelectLinkWithTransitInformation (LPTTTAttributedLabel label, NSDictionary components);

		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didSelectLinkWithTextCheckingResult:(NSTextCheckingResult *)result;
		[Export ("attributedLabel:didSelectLinkWithTextCheckingResult:")]
		void DidSelectLinkWithTextCheckingResult (LPTTTAttributedLabel label, NSTextCheckingResult result);

		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didLongPressLinkWithURL:(NSURL *)url atPoint:(CGPoint)point;
		[Export ("attributedLabel:didLongPressLinkWithURL:atPoint:")]
		void DidLongPressLinkWithURL (LPTTTAttributedLabel label, NSUrl url, CGPoint point);

		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didLongPressLinkWithAddress:(NSDictionary *)addressComponents atPoint:(CGPoint)point;
		[Export ("attributedLabel:didLongPressLinkWithAddress:atPoint:")]
		void DidLongPressLinkWithAddress (LPTTTAttributedLabel label, NSDictionary addressComponents, CGPoint point);

		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didLongPressLinkWithPhoneNumber:(NSString *)phoneNumber atPoint:(CGPoint)point;
		[Export ("attributedLabel:didLongPressLinkWithPhoneNumber:atPoint:")]
		void DidLongPressLinkWithPhoneNumber (LPTTTAttributedLabel label, string phoneNumber, CGPoint point);

		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didLongPressLinkWithDate:(NSDate *)date atPoint:(CGPoint)point;
		[Export ("attributedLabel:didLongPressLinkWithDate:atPoint:")]
		void DidLongPressLinkWithDate (LPTTTAttributedLabel label, NSDate date, CGPoint point);

		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didLongPressLinkWithDate:(NSDate *)date timeZone:(NSTimeZone *)timeZone duration:(NSTimeInterval)duration atPoint:(CGPoint)point;
		[Export ("attributedLabel:didLongPressLinkWithDate:timeZone:duration:atPoint:")]
		void DidLongPressLinkWithDate (LPTTTAttributedLabel label, NSDate date, NSTimeZone timeZone, double duration, CGPoint point);

		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didLongPressLinkWithTransitInformation:(NSDictionary *)components atPoint:(CGPoint)point;
		[Export ("attributedLabel:didLongPressLinkWithTransitInformation:atPoint:")]
		void DidLongPressLinkWithTransitInformation (LPTTTAttributedLabel label, NSDictionary components, CGPoint point);

		// @optional -(void)attributedLabel:(LPTTTAttributedLabel *)label didLongPressLinkWithTextCheckingResult:(NSTextCheckingResult *)result atPoint:(CGPoint)point;
		[Export ("attributedLabel:didLongPressLinkWithTextCheckingResult:atPoint:")]
		void DidLongPressLinkWithTextCheckingResult (LPTTTAttributedLabel label, NSTextCheckingResult result, CGPoint point);
	}

	// @interface LPTTTAttributedLabelLink : NSObject <NSCoding>
	[BaseType (typeof(NSObject))]
	interface LPTTTAttributedLabelLink : INSCoding
	{
		// @property (readonly, nonatomic, strong) NSTextCheckingResult * result;
		[Export ("result", ArgumentSemantic.Strong)]
		NSTextCheckingResult Result { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * attributes;
		[Export ("attributes", ArgumentSemantic.Copy)]
		NSDictionary Attributes { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * activeAttributes;
		[Export ("activeAttributes", ArgumentSemantic.Copy)]
		NSDictionary ActiveAttributes { get; }

		// @property (readonly, copy, nonatomic) NSDictionary * inactiveAttributes;
		[Export ("inactiveAttributes", ArgumentSemantic.Copy)]
		NSDictionary InactiveAttributes { get; }

		// @property (copy, nonatomic) NSString * accessibilityValue;
		[Export ("accessibilityValue")]
		string AccessibilityValue { get; set; }

		// @property (copy, nonatomic) LPTTTAttributedLabelLinkBlock linkTapBlock;
		[Export ("linkTapBlock", ArgumentSemantic.Copy)]
		LPTTTAttributedLabelLinkBlock LinkTapBlock { get; set; }

		// @property (copy, nonatomic) LPTTTAttributedLabelLinkBlock linkLongPressBlock;
		[Export ("linkLongPressBlock", ArgumentSemantic.Copy)]
		LPTTTAttributedLabelLinkBlock LinkLongPressBlock { get; set; }

		// -(instancetype)initWithAttributes:(NSDictionary *)attributes activeAttributes:(NSDictionary *)activeAttributes inactiveAttributes:(NSDictionary *)inactiveAttributes textCheckingResult:(NSTextCheckingResult *)result;
		[Export ("initWithAttributes:activeAttributes:inactiveAttributes:textCheckingResult:")]
		IntPtr Constructor (NSDictionary attributes, NSDictionary activeAttributes, NSDictionary inactiveAttributes, NSTextCheckingResult result);

		// -(instancetype)initWithAttributesFromLabel:(LPTTTAttributedLabel *)label textCheckingResult:(NSTextCheckingResult *)result;
		[Export ("initWithAttributesFromLabel:textCheckingResult:")]
		IntPtr Constructor (LPTTTAttributedLabel label, NSTextCheckingResult result);
	}

	// typedef void (^LPTTTAttributedLabelLinkBlock)(LPTTTAttributedLabel *, LPTTTAttributedLabelLink *);
	delegate void LPTTTAttributedLabelLinkBlock (LPTTTAttributedLabel arg0, LPTTTAttributedLabelLink arg1);

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double LPMessagingSDKVersionNumber;
		[Field ("LPMessagingSDKVersionNumber", "__Internal")]
		double LPMessagingSDKVersionNumber { get; }

		// extern const unsigned char [] LPMessagingSDKVersionString;
		[Field ("LPMessagingSDKVersionString", "__Internal")]
		byte[] LPMessagingSDKVersionString { get; }
	}
}
