# agc-xamarin-bindings-deoms
[![license](https://img.shields.io/badge/license-Apache--2.0-green)](./LICENCE)

This repo contains the source code for AGC xamarins Bindings, which are developed by the AppGallery Connect team.

These demos enable access to using specific APIs. For more information
about demos, and how to use them, see
[Official Documentations](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-Guides/agc-get-started).


## Introduction
These are the available bindings in this repository.

| Plugin | Version | Documentation |
|--------|-----|-----|
| [apms](./apms)|[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.iOS.Apms.svg?label=Xamarin.iOS)](./apms/ios) <br>[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.Apms.svg?label=Xamarin.Android)](./apms/android)|[Getting Started](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-Guides/agc-apm-introduction-0000001052247254) <br/>  |
| [applinking](./applinking)|[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.iOS.Applinking.svg?label=Xamarin.iOS)](https://www.nuget.org/packages/Huawei.Agconnect.iOS.Applinking) <br>[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.Applinking.svg?label=Xamarin.Android)](https://www.nuget.org/packages/Huawei.Agconnect.Applinking)|[Getting Started](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-Guides/agc-get-started-xamarin#h1-1617284872937-1) <br/> [API Reference](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-References/applinking-overview-main-0000001076677086) |
| [appmessaging](./appmessaging)|[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.iOS.Appmessaging.svg?label=Xamarin.iOS)](https://www.nuget.org/packages/Huawei.Agconnect.iOS.Appmessaging) <br>[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.Appmessaging.svg?label=Xamarin.Android)](https://www.nuget.org/packages/Huawei.Agconnect.Appmessaging)|[Getting Started](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-Guides/agc-get-started-xamarin#h1-1617284872937-1) <br/> [API Reference](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-References/appmessaging-overview-main-0000001070934262) |
| [authservice](./auth)|[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.iOS.Auth.svg?label=Xamarin.iOS)](https://www.nuget.org/packages/Huawei.Agconnect.iOS.Auth) <br>[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.Auth.svg?label=Xamarin.Android)](https://www.nuget.org/packages/Huawei.Agconnect.Auth) |[Getting Started](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-Guides/agc-get-started-xamarin#h1-1617284872937-1) <br/> [API Reference](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-References/auth-overview-main-0000001098779626) |
| [clouddb](./clouddb)|[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.CloudDatabase.svg?label=Xamarin.Android)](https://www.nuget.org/packages/Huawei.Agconnect.CloudDatabase) |[Getting Started](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-Guides/agc-get-started-xamarin#h1-1617284872937-1) <br/> [API Reference](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-References/clouddb-xamarin-0000001111776788) |
| [cloudfunction](./cloudfunctions)|[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.iOS.Function.svg?label=Xamarin.iOS)](https://www.nuget.org/packages/Huawei.Agconnect.iOS.Function) <br>[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.Function.svg?label=Xamarin.Android)](https://www.nuget.org/packages/Huawei.Agconnect.Function) |[Getting Started](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-Guides/agc-get-started-xamarin#h1-1617284872937-1) <br/> [API Reference](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-References/cloudfunctions-overview-main-0000001097403208) |
| [crash](./crash)|[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.iOS.Crash.svg?label=Xamarin.iOS)](https://www.nuget.org/packages/Huawei.Agconnect.iOS.Crash) <br>[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.Crash.svg?label=Xamarin.Android)](https://www.nuget.org/packages/Huawei.Agconnect.Crash)|[Getting Started](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-Guides/agc-get-started-xamarin#h1-1617284872937-1) <br/> [API Reference](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-References/crash-overview-main-0000001130785207) |
| [remoteconfig](./remoteconfig) | [![version](https://img.shields.io/nuget/v/Huawei.Agconnect.iOS.Remoteconfig.svg?label=Xamarin.iOS)](https://www.nuget.org/packages/Huawei.Agconnect.iOS.Remoteconfig) <br>[![version](https://img.shields.io/nuget/v/Huawei.Agconnect.Remoteconfig.svg?label=Xamarin.Android)](https://www.nuget.org/packages/Huawei.Agconnect.Remoteconfig)|[Getting Started](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-Guides/remoteconfig-xamarin-releasenotes-0000001135676681) <br/> [API Reference](https://developer.huawei.com/consumer/en/doc/development/AppGallery-connect-References/remoteconfig-overview-main-0000001088768192) |


## Precautions
The agc-xamarins-bindings project contains 6 projects. After downloading the code, you can load different nested projects to the IDE as required. And you can run each project independently.

## Question or issues
If you have questions about how to use AppGallery Connect Bindings, try the following options:  
* [Stack Overflow](https://stackoverflow.com/questions/tagged/appgallery) is the best place for any programming questions. Be sure to tag your question with huawei-mobile-services.  
* [Huawei Developer Forum](https://forums.developer.huawei.com/forumPortal/en/home?fid=0101188387844930001) AppGallery Module is great for general questions, or seeking recommendations and opinions.
* [Submit ticket online](https://developer.huawei.com/consumer/en/support/feedback/#/) If you encounter a serious or urgent problem, submit a trouble ticket online to contact Huawei technical support.

If you run into a bug in our samples, please submit an [issue](https://github.com/AppGalleryConnect/agc-android-bindings/issues) to the Repository. Even better you can submit a [Pull Request](https://github.com/AppGalleryConnect/agc-android-bindings/pulls) with a fix.

