using System;
using ObjCRuntime;

namespace Huawei.Agconnect.Applinking
{

	[Native]
	public enum AGCShortLinkingLength : long
	{
		Short,
		Long
	}

	[Native]
	public enum AGCLinkingPreviewType : long
	{
		AppInfo = 1,
		SocialInfo = 2
	}

	[Native]
	public enum AGCLinkingAndroidOpenType : long
	{
		AppGallery = 1,
		LocalMarket = 2,
		CustomURL = 3
	}




}




