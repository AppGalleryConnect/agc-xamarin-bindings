using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Updatesdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.updatesdk']/class[@name='UpdateSdkAPI']"
	[global::Android.Runtime.Register ("com/huawei/updatesdk/UpdateSdkAPI", DoNotGenerateAcw=true)]
	public sealed partial class UpdateSdkAPI : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.updatesdk']/class[@name='UpdateSdkAPI']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "UpdateSdk";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/updatesdk/UpdateSdkAPI", typeof (UpdateSdkAPI));
		internal static IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		internal UpdateSdkAPI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.updatesdk']/class[@name='UpdateSdkAPI']/constructor[@name='UpdateSdkAPI' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UpdateSdkAPI ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk']/class[@name='UpdateSdkAPI']/method[@name='checkAppUpdate' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.updatesdk.service.otaupdate.CheckUpdateCallBack'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("checkAppUpdate", "(Landroid/content/Context;Lcom/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack;ZZ)V", "")]
		public static unsafe void CheckAppUpdate (global::Android.Content.Context p0, global::Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBack p1, bool p2, bool p3)
		{
			const string __id = "checkAppUpdate.(Landroid/content/Context;Lcom/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack;ZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk']/class[@name='UpdateSdkAPI']/method[@name='checkAppUpdate' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.updatesdk.service.otaupdate.UpdateParams'] and parameter[3][@type='com.huawei.updatesdk.service.otaupdate.CheckUpdateCallBack']]"
		[Register ("checkAppUpdate", "(Landroid/content/Context;Lcom/huawei/updatesdk/service/otaupdate/UpdateParams;Lcom/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack;)V", "")]
		public static unsafe void CheckAppUpdate (global::Android.Content.Context p0, global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams p1, global::Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBack p2)
		{
			const string __id = "checkAppUpdate.(Landroid/content/Context;Lcom/huawei/updatesdk/service/otaupdate/UpdateParams;Lcom/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk']/class[@name='UpdateSdkAPI']/method[@name='checkAppUpdateByAppInfo' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.updatesdk.service.otaupdate.CheckUpdateCallBack'] and parameter[3][@type='com.huawei.updatesdk.service.appmgr.bean.AppInfoAdapter']]"
		[Register ("checkAppUpdateByAppInfo", "(Landroid/content/Context;Lcom/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack;Lcom/huawei/updatesdk/service/appmgr/bean/AppInfoAdapter;)V", "")]
		public static unsafe void CheckAppUpdateByAppInfo (global::Android.Content.Context p0, global::Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBack p1, global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter p2)
		{
			const string __id = "checkAppUpdateByAppInfo.(Landroid/content/Context;Lcom/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack;Lcom/huawei/updatesdk/service/appmgr/bean/AppInfoAdapter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk']/class[@name='UpdateSdkAPI']/method[@name='checkAppUpdateForHMSKit' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.updatesdk.service.otaupdate.UpdateParams'] and parameter[3][@type='com.huawei.updatesdk.service.otaupdate.CheckUpdateCallBack']]"
		[Register ("checkAppUpdateForHMSKit", "(Landroid/content/Context;Lcom/huawei/updatesdk/service/otaupdate/UpdateParams;Lcom/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack;)V", "")]
		public static unsafe void CheckAppUpdateForHMSKit (global::Android.Content.Context p0, global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams p1, global::Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBack p2)
		{
			const string __id = "checkAppUpdateForHMSKit.(Landroid/content/Context;Lcom/huawei/updatesdk/service/otaupdate/UpdateParams;Lcom/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk']/class[@name='UpdateSdkAPI']/method[@name='checkClientOTAUpdate' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.updatesdk.service.otaupdate.CheckUpdateCallBack'] and parameter[3][@type='boolean'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("checkClientOTAUpdate", "(Landroid/content/Context;Lcom/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack;ZIZ)V", "")]
		public static unsafe void CheckClientOTAUpdate (global::Android.Content.Context p0, global::Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBack p1, bool p2, int p3, bool p4)
		{
			const string __id = "checkClientOTAUpdate.(Landroid/content/Context;Lcom/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack;ZIZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk']/class[@name='UpdateSdkAPI']/method[@name='checkTargetAppUpdate' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.huawei.updatesdk.service.otaupdate.CheckUpdateCallBack']]"
		[Register ("checkTargetAppUpdate", "(Landroid/content/Context;Ljava/lang/String;Lcom/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack;)V", "")]
		public static unsafe void CheckTargetAppUpdate (global::Android.Content.Context p0, string p1, global::Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBack p2)
		{
			const string __id = "checkTargetAppUpdate.(Landroid/content/Context;Ljava/lang/String;Lcom/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk']/class[@name='UpdateSdkAPI']/method[@name='releaseCallBack' and count(parameter)=0]"
		[Register ("releaseCallBack", "()V", "")]
		public static unsafe void ReleaseCallBack ()
		{
			const string __id = "releaseCallBack.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk']/class[@name='UpdateSdkAPI']/method[@name='setAppStorePkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppStorePkgName", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetAppStorePkgName (string p0)
		{
			const string __id = "setAppStorePkgName.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk']/class[@name='UpdateSdkAPI']/method[@name='setServiceZone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setServiceZone", "(Ljava/lang/String;)V", "")]
		public static unsafe void SetServiceZone (string p0)
		{
			const string __id = "setServiceZone.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
