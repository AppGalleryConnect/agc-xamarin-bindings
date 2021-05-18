using System;
using Foundation;
using ObjCRuntime;

namespace Huawei.Agconnect.Applinking
{

	// @interface AGCResolvedLink : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCResolvedLink
	{
		// @property (readonly, nonatomic) NSString * _Nonnull deepLink;
		[Export("deepLink")]
		string DeepLink { get; }

		// @property (readonly, nonatomic) NSDate * _Nonnull clickTime;
		[Export("clickTime")]
		NSDate ClickTime { get; }

		// @property (readonly, nonatomic) NSString * _Nullable socialTitle;
		[NullAllowed, Export("socialTitle")]
		string SocialTitle { get; }

		// @property (readonly, nonatomic) NSString * _Nullable socialDescription;
		[NullAllowed, Export("socialDescription")]
		string SocialDescription { get; }

		// @property (readonly, nonatomic) NSString * _Nullable socialImageUrl;
		[NullAllowed, Export("socialImageUrl")]
		string SocialImageUrl { get; }

		// @property (readonly, nonatomic) NSString * _Nullable campaignName;
		[NullAllowed, Export("campaignName")]
		string CampaignName { get; }

		// @property (readonly, nonatomic) NSString * _Nullable campaignSource;
		[NullAllowed, Export("campaignSource")]
		string CampaignSource { get; }

		// @property (readonly, nonatomic) NSString * _Nullable campaignMedium;
		[NullAllowed, Export("campaignMedium")]
		string CampaignMedium { get; }
	}

	// @interface AGCAppLinking : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCAppLinking
	{
		// +(instancetype _Nonnull)sharedInstance __attribute__((swift_name("instance()")));
		[Static]
		[Export("sharedInstance")]
		AGCAppLinking GetSharedInstance();

		// -(void)handleAppLinking:(void (^ _Nonnull)(AGCResolvedLink * _Nullable, NSError * _Nullable))callback;
		[Export("handleAppLinking:")]
		[Async]
		void HandleAppLinking(Action<AGCResolvedLink, NSError> callback);

		// -(BOOL)openDeepLinkURL:(NSURL * _Nonnull)url;
		[Export("openDeepLinkURL:")]
		bool OpenDeepLinkURL(NSUrl url);

		// -(BOOL)continueUserActivity:(NSUserActivity * _Nonnull)userActivity __attribute__((swift_name("continueUserActivity(_:)")));
		[Export("continueUserActivity:")]
		bool ContinueUserActivity(NSUserActivity userActivity);
	}

	// @interface AGCShortAppLinking : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCShortAppLinking
	{
		// @property (readonly, nonatomic, strong) NSURL * _Nonnull url;
		[Export("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; }

		// @property (readonly, nonatomic, strong) NSURL * _Nonnull testUrl;
		[Export("testUrl", ArgumentSemantic.Strong)]
		NSUrl TestUrl { get; }
	}

	// typedef void (^AGCShortAppLinkingCallBack)(AGCShortAppLinking * _Nullable, NSError * _Nullable);
	delegate void AGCShortAppLinkingCallBack([NullAllowed] AGCShortAppLinking link, [NullAllowed] NSError error);

	// @interface AGCAppLinkingComponents : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCAppLinkingComponents
	{
		// @property (nonatomic, strong) NSString * _Nullable uriPrefix;
		[NullAllowed, Export("uriPrefix", ArgumentSemantic.Strong)]
		string UriPrefix { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable longLink;
		[NullAllowed, Export("longLink", ArgumentSemantic.Strong)]
		string LongLink { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable deepLink;
		[NullAllowed, Export("deepLink", ArgumentSemantic.Strong)]
		string DeepLink { get; set; }

		// @property (nonatomic) AGCLinkingPreviewType previewType;
		[Export("previewType", ArgumentSemantic.Assign)]
		AGCLinkingPreviewType PreviewType { get; set; }

		// @property (nonatomic) NSInteger expireMinute;
		[Export("expireMinute")]
		nint ExpireMinute { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable androidPackageName;
		[NullAllowed, Export("androidPackageName", ArgumentSemantic.Strong)]
		string AndroidPackageName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable androidDeepLink;
		[NullAllowed, Export("androidDeepLink", ArgumentSemantic.Strong)]
		string AndroidDeepLink { get; set; }

		// @property (nonatomic) AGCLinkingAndroidOpenType androidOpenType;
		[Export("androidOpenType", ArgumentSemantic.Assign)]
		AGCLinkingAndroidOpenType AndroidOpenType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable androidFallbackUrl;
		[NullAllowed, Export("androidFallbackUrl", ArgumentSemantic.Strong)]
		string AndroidFallbackUrl { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable iosBundleId;
		[NullAllowed, Export("iosBundleId", ArgumentSemantic.Strong)]
		string IosBundleId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable iosDeepLink;
		[NullAllowed, Export("iosDeepLink", ArgumentSemantic.Strong)]
		string IosDeepLink { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable iosFallbackUrl;
		[NullAllowed, Export("iosFallbackUrl", ArgumentSemantic.Strong)]
		string IosFallbackUrl { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable ipadBundleId;
		[NullAllowed, Export("ipadBundleId", ArgumentSemantic.Strong)]
		string IpadBundleId { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable ipadFallbackUrl;
		[NullAllowed, Export("ipadFallbackUrl", ArgumentSemantic.Strong)]
		string IpadFallbackUrl { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable iTunesConnectMediaType;
		[NullAllowed, Export("iTunesConnectMediaType", ArgumentSemantic.Strong)]
		string ITunesConnectMediaType { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable iTunesConnectAffiliateToken;
		[NullAllowed, Export("iTunesConnectAffiliateToken", ArgumentSemantic.Strong)]
		string ITunesConnectAffiliateToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable iTunesConnectProviderToken;
		[NullAllowed, Export("iTunesConnectProviderToken", ArgumentSemantic.Strong)]
		string ITunesConnectProviderToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable iTunesConnectCampaignToken;
		[NullAllowed, Export("iTunesConnectCampaignToken", ArgumentSemantic.Strong)]
		string ITunesConnectCampaignToken { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable socialTitle;
		[NullAllowed, Export("socialTitle", ArgumentSemantic.Strong)]
		string SocialTitle { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable socialDescription;
		[NullAllowed, Export("socialDescription", ArgumentSemantic.Strong)]
		string SocialDescription { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable socialImageUrl;
		[NullAllowed, Export("socialImageUrl", ArgumentSemantic.Strong)]
		string SocialImageUrl { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable campaignName;
		[NullAllowed, Export("campaignName", ArgumentSemantic.Strong)]
		string CampaignName { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable campaignSource;
		[NullAllowed, Export("campaignSource", ArgumentSemantic.Strong)]
		string CampaignSource { get; set; }

		// @property (nonatomic, strong) NSString * _Nullable campaignMedium;
		[NullAllowed, Export("campaignMedium", ArgumentSemantic.Strong)]
		string CampaignMedium { get; set; }

		// -(NSURL * _Nonnull)buildLongLink;
		[Export("buildLongLink")]
		NSUrl BuildLongLink();

		// -(void)buildShortLink:(AGCShortAppLinkingCallBack _Nonnull)callback;
		[Export("buildShortLink:")]
		[Async]
		void BuildShortLink(AGCShortAppLinkingCallBack callback);

		// -(void)buildShortLink:(AGCShortLinkingLength)length callback:(AGCShortAppLinkingCallBack _Nonnull)callback;
		[Export("buildShortLink:callback:")]
		[Async]
		void BuildShortLink(AGCShortLinkingLength length, AGCShortAppLinkingCallBack callback);
	}
}