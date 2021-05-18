using System;

using ObjCRuntime;
using Foundation;
using UIKit;


namespace Huawei.Agconnect.Appmessaging
{

    // @interface AGCAppMessaging : NSObject
    [DisableDefaultCtor]
    [BaseType(typeof(NSObject))]
    interface AGCAppMessaging
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        IAGCAppMessagingDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<AGCAppMessagingDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic) id<AGCAppMessagingDisplayDelegate> _Nonnull displayComponent;
        [Export("displayComponent", ArgumentSemantic.Assign)]
        IAGCAppMessagingDisplayDelegate DisplayComponent { get; set; }

        // @property (nonatomic) BOOL isFetchMessageEnable;
        [Export("isFetchMessageEnable")]
        bool IsFetchMessageEnable { get; set; }

        // @property (nonatomic) BOOL isDisplayEnable;
        [Export("isDisplayEnable")]
        bool IsDisplayEnable { get; set; }

        // +(instancetype _Nonnull)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        AGCAppMessaging GetSharedInstance();

        // -(void)triggerEvent:(NSString * _Nonnull)eventId;
        [Export("triggerEvent:")]
        void TriggerEvent(string eventId);
    }

    // @interface AGCAppMessagingActionButton : NSObject
    [BaseType(typeof(NSObject))]
    public interface AGCAppMessagingActionButton
    {
        // @property (readonly, nonatomic) NSString * _Nullable text;
        [NullAllowed, Export("text")]
        string Text { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull textColor;
        [Export("textColor")]
        UIColor TextColor { get; }

        // @property (readonly, nonatomic) NSURL * _Nullable actionURL;
        [NullAllowed, Export("actionURL")]
        NSUrl ActionURL { get; }

        // -(instancetype _Nonnull)initWithActionURL:(NSURL * _Nonnull)url;
        [Export("initWithActionURL:")]
        IntPtr Constructor(NSUrl url);
    }

    // @interface AGCAppMessagingDisplayMessage : NSObject
    [BaseType(typeof(NSObject))]
    public interface AGCAppMessagingDisplayMessage
    {
        // @property (readonly, nonatomic) NSInteger messageId;
        [Export("messageId")]
        nint MessageId { get; }

        // @property (readonly, nonatomic) AGCAppMessagingDisplayMessageType messageType;
        [Export("messageType")]
        AGCAppMessagingDisplayMessageType MessageType { get; }

        // @property (readonly, nonatomic) NSDate * _Nonnull startTime;
        [Export("startTime")]
        NSDate StartTime { get; }

        // @property (readonly, nonatomic) NSDate * _Nullable endTime;
        [NullAllowed, Export("endTime")]
        NSDate EndTime { get; }

        // @property (readonly, nonatomic) AGCAppMessagingFrequencyType frequencyType;
        [Export("frequencyType")]
        AGCAppMessagingFrequencyType FrequencyType { get; }

        // @property (readonly, nonatomic) NSInteger frequencyValue;
        [Export("frequencyValue")]
        nint FrequencyValue { get; }

        // @property (readonly, nonatomic) BOOL isTest;
        [Export("isTest")]
        bool IsTest { get; }

        // @property (readonly, nonatomic) NSArray<NSString *> * _Nonnull triggerEvents;
        [Export("triggerEvents")]
        string[] TriggerEvents { get; }
    }

    // @interface AGCAppMessagingBannerDisplay : AGCAppMessagingDisplayMessage
    [BaseType(typeof(AGCAppMessagingDisplayMessage))]
    interface AGCAppMessagingBannerDisplay
    {
        // @property (readonly, nonatomic) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor")]
        UIColor BackgroundColor { get; }

        // @property (readonly, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull titleColor;
        [Export("titleColor")]
        UIColor TitleColor { get; }

        // @property (readonly, nonatomic) NSString * _Nullable body;
        [NullAllowed, Export("body")]
        string Body { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull bodyColor;
        [Export("bodyColor")]
        UIColor BodyColor { get; }

        // @property (readonly, nonatomic) NSURL * _Nullable pictureURL;
        [NullAllowed, Export("pictureURL")]
        NSUrl PictureURL { get; }

        // @property (readonly, nonatomic) NSURL * _Nullable actionURL;
        [NullAllowed, Export("actionURL")]
        NSUrl ActionURL { get; }
    }

    // @interface AGCAppMessagingCardDisplay : AGCAppMessagingDisplayMessage
    [BaseType(typeof(AGCAppMessagingDisplayMessage))]
    interface AGCAppMessagingCardDisplay
    {
        // @property (readonly, nonatomic) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor")]
        UIColor BackgroundColor { get; }

        // @property (readonly, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull titleColor;
        [Export("titleColor")]
        UIColor TitleColor { get; }

        // @property (readonly, nonatomic) NSString * _Nullable body;
        [NullAllowed, Export("body")]
        string Body { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull bodyColor;
        [Export("bodyColor")]
        UIColor BodyColor { get; }

        // @property (readonly, nonatomic) NSURL * _Nullable portraitPictureURL;
        [NullAllowed, Export("portraitPictureURL")]
        NSUrl PortraitPictureURL { get; }

        // @property (readonly, nonatomic) NSURL * _Nullable landscapePictureURL;
        [NullAllowed, Export("landscapePictureURL")]
        NSUrl LandscapePictureURL { get; }

        // @property (readonly, nonatomic) AGCAppMessagingActionButton * _Nullable majorButton;
        [NullAllowed, Export("majorButton")]
        AGCAppMessagingActionButton MajorButton { get; }

        // @property (readonly, nonatomic) AGCAppMessagingActionButton * _Nullable minorButton;
        [NullAllowed, Export("minorButton")]
        AGCAppMessagingActionButton MinorButton { get; }
    }

    // @interface AGCAppMessagingPictureDisplay : AGCAppMessagingDisplayMessage
    [BaseType(typeof(AGCAppMessagingDisplayMessage))]
    interface AGCAppMessagingPictureDisplay
    {
        // @property (readonly, nonatomic) NSURL * _Nullable pictureURL;
        [NullAllowed, Export("pictureURL")]
        NSUrl PictureURL { get; }

        // @property (readonly, nonatomic) NSURL * _Nullable actionURL;
        [NullAllowed, Export("actionURL")]
        NSUrl ActionURL { get; }
    }

    interface IAGCAppMessagingDelegate { }

    // @protocol AGCAppMessagingDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface AGCAppMessagingDelegate
    {
        // @optional -(void)appMessagingOnDisplay:(AGCAppMessagingDisplayMessage * _Nonnull)message;
        [Export("appMessagingOnDisplay:")]
        void AppMessagingOnDisplay(AGCAppMessagingDisplayMessage message);

        // @optional -(void)appMessagingOnClick:(AGCAppMessagingDisplayMessage * _Nonnull)message button:(AGCAppMessagingActionButton * _Nonnull)button;
        [Export("appMessagingOnClick:button:")]
        void AppMessagingOnClick(AGCAppMessagingDisplayMessage message, AGCAppMessagingActionButton button);

        // @optional -(void)appMessagingOnDismiss:(AGCAppMessagingDisplayMessage * _Nonnull)message dismissType:(AGCAppMessagingDismissType)dismissType;
        [Export("appMessagingOnDismiss:dismissType:")]
        void AppMessagingOnDismiss(AGCAppMessagingDisplayMessage message, AGCAppMessagingDismissType dismissType);

        // @optional -(void)appMessagingOnError:(AGCAppMessagingDisplayMessage * _Nonnull)message;
        [Export("appMessagingOnError:")]
        void AppMessagingOnError(AGCAppMessagingDisplayMessage message);
    }


    interface IAGCAppMessagingDisplayDelegate { }

    // @protocol AGCAppMessagingDisplayDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface AGCAppMessagingDisplayDelegate
    {
        // @required -(void)appMessageDisplay:(AGCAppMessagingDisplayMessage * _Nonnull)message delegate:(id<AGCAppMessagingDelegate> _Nonnull)delegate;
        [Abstract]
        [Export("appMessageDisplay:delegate:")]
        void SetDisplayDelegate(AGCAppMessagingDisplayMessage message, IAGCAppMessagingDelegate displayDelegate);
    }

    interface IAGCAppMessagingDisplayImageCacheSource { }

    // @protocol AGCAppMessagingDisplayImageCacheSource <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface AGCAppMessagingDisplayImageCacheSource
    {
        // @required -(void)appMessagingLoadImage:(NSURL * _Nonnull)url completion:(void (^ _Nullable)(NSData * _Nullable, NSError * _Nullable))completion;
        [Abstract]
        [Export("appMessagingLoadImage:completion:")]
        [Async]
        void Completion(NSUrl url, [NullAllowed] Action<NSData, NSError> completion);
    }

    // @interface AGCAppMessagingDefaultDisplay : NSObject <AGCAppMessagingDisplayDelegate>
    [BaseType(typeof(NSObject))]
    interface AGCAppMessagingDefaultDisplay : IAGCAppMessagingDisplayDelegate
    {
        // @property (nonatomic) AGCAppMessagingDefaultDisplayLocation defaultLocation;
        [Export("defaultLocation", ArgumentSemantic.Assign)]
        AGCAppMessagingDefaultDisplayLocation DefaultLocation { get; set; }

        // @property (nonatomic, weak) id<AGCAppMessagingDisplayImageCacheSource> _Nullable imageCacheSource;
        [NullAllowed, Export("imageCacheSource", ArgumentSemantic.Weak)]
        IAGCAppMessagingDisplayImageCacheSource ImageCacheSource { get; set; }

        // +(instancetype _Nonnull)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        AGCAppMessagingDefaultDisplay GetSharedInstance();
    }

}