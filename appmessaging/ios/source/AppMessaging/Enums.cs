using System;
using ObjCRuntime;

namespace Huawei.Agconnect.Appmessaging
{

    public enum AGCAppMessagingDisplayMessageType : long
    {
        Unknown,
        Card,
        Picture,
        Banner
    }


    public enum AGCAppMessagingFrequencyType : long
    {
        Once = 1,
        OnceXDay = 2,
        XPreDay = 3
    }


    public enum AGCAppMessagingDismissType : long
    {
        Click,
        ClickOutside,
        Auto,
        Swipe
    }


    public enum AGCAppMessagingDefaultDisplayLocation : long
    {
        Center,
        Bottom
    }


}