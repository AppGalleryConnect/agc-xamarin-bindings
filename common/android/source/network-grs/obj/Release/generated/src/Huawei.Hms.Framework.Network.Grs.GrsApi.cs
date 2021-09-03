using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Network.Grs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApi']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/network/grs/GrsApi", DoNotGenerateAcw=true)]
	public partial class GrsApi : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/network/grs/GrsApi", typeof (GrsApi));
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

		protected GrsApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApi']/constructor[@name='GrsApi' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GrsApi ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApi']/method[@name='ayncGetGrsUrl' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.huawei.hms.framework.network.grs.IQueryUrlCallBack']]"
		[Register ("ayncGetGrsUrl", "(Ljava/lang/String;Ljava/lang/String;Lcom/huawei/hms/framework/network/grs/IQueryUrlCallBack;)V", "")]
		public static unsafe void AyncGetGrsUrl (string p0, string p1, global::Huawei.Hms.Framework.Network.Grs.IQueryUrlCallBack p2)
		{
			const string __id = "ayncGetGrsUrl.(Ljava/lang/String;Ljava/lang/String;Lcom/huawei/hms/framework/network/grs/IQueryUrlCallBack;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApi']/method[@name='ayncGetGrsUrls' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.huawei.hms.framework.network.grs.IQueryUrlsCallBack']]"
		[Register ("ayncGetGrsUrls", "(Ljava/lang/String;Lcom/huawei/hms/framework/network/grs/IQueryUrlsCallBack;)V", "")]
		public static unsafe void AyncGetGrsUrls (string p0, global::Huawei.Hms.Framework.Network.Grs.IQueryUrlsCallBack p1)
		{
			const string __id = "ayncGetGrsUrls.(Ljava/lang/String;Lcom/huawei/hms/framework/network/grs/IQueryUrlsCallBack;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApi']/method[@name='clearSp' and count(parameter)=0]"
		[Register ("clearSp", "()V", "")]
		public static unsafe void ClearSp ()
		{
			const string __id = "clearSp.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApi']/method[@name='forceExpire' and count(parameter)=0]"
		[Register ("forceExpire", "()Z", "")]
		public static unsafe bool ForceExpire ()
		{
			const string __id = "forceExpire.()Z";
			try {
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApi']/method[@name='getCountryCode' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("getCountryCode", "(Landroid/content/Context;Z)Lcom/huawei/hms/framework/network/grs/local/model/CountryCodeBean;", "")]
		public static unsafe global::Huawei.Hms.Framework.Network.Grs.Local.Model.CountryCodeBean GetCountryCode (global::Android.Content.Context p0, bool p1)
		{
			const string __id = "getCountryCode.(Landroid/content/Context;Z)Lcom/huawei/hms/framework/network/grs/local/model/CountryCodeBean;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.Local.Model.CountryCodeBean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApi']/method[@name='grsSdkInit' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.framework.network.grs.GrsBaseInfo']]"
		[Register ("grsSdkInit", "(Landroid/content/Context;Lcom/huawei/hms/framework/network/grs/GrsBaseInfo;)I", "")]
		public static unsafe int GrsSdkInit (global::Android.Content.Context p0, global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo p1)
		{
			const string __id = "grsSdkInit.(Landroid/content/Context;Lcom/huawei/hms/framework/network/grs/GrsBaseInfo;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApi']/method[@name='synGetGrsUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("synGetGrsUrl", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SynGetGrsUrl (string p0, string p1)
		{
			const string __id = "synGetGrsUrl.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsApi']/method[@name='synGetGrsUrls' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("synGetGrsUrls", "(Ljava/lang/String;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> SynGetGrsUrls (string p0)
		{
			const string __id = "synGetGrsUrls.(Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
