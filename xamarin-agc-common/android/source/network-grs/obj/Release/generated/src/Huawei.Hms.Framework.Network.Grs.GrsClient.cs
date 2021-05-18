using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Network.Grs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsClient']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/network/grs/GrsClient", DoNotGenerateAcw=true)]
	public partial class GrsClient : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/network/grs/GrsClient", typeof (GrsClient));
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

		protected GrsClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsClient']/constructor[@name='GrsClient' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.huawei.hms.framework.network.grs.GrsBaseInfo']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/huawei/hms/framework/network/grs/GrsBaseInfo;)V", "")]
		public unsafe GrsClient (global::Android.Content.Context p0, global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/huawei/hms/framework/network/grs/GrsBaseInfo;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_ayncGetGrsUrl_Ljava_lang_String_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlCallBack_;
#pragma warning disable 0169
		static Delegate GetAyncGetGrsUrl_Ljava_lang_String_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlCallBack_Handler ()
		{
			if (cb_ayncGetGrsUrl_Ljava_lang_String_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlCallBack_ == null)
				cb_ayncGetGrsUrl_Ljava_lang_String_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlCallBack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_AyncGetGrsUrl_Ljava_lang_String_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlCallBack_);
			return cb_ayncGetGrsUrl_Ljava_lang_String_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlCallBack_;
		}

		static void n_AyncGetGrsUrl_Ljava_lang_String_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Huawei.Hms.Framework.Network.Grs.IQueryUrlCallBack)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.IQueryUrlCallBack> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AyncGetGrsUrl (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsClient']/method[@name='ayncGetGrsUrl' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.huawei.hms.framework.network.grs.IQueryUrlCallBack']]"
		[Register ("ayncGetGrsUrl", "(Ljava/lang/String;Ljava/lang/String;Lcom/huawei/hms/framework/network/grs/IQueryUrlCallBack;)V", "GetAyncGetGrsUrl_Ljava_lang_String_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlCallBack_Handler")]
		public virtual unsafe void AyncGetGrsUrl (string p0, string p1, global::Huawei.Hms.Framework.Network.Grs.IQueryUrlCallBack p2)
		{
			const string __id = "ayncGetGrsUrl.(Ljava/lang/String;Ljava/lang/String;Lcom/huawei/hms/framework/network/grs/IQueryUrlCallBack;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_ayncGetGrsUrls_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlsCallBack_;
#pragma warning disable 0169
		static Delegate GetAyncGetGrsUrls_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlsCallBack_Handler ()
		{
			if (cb_ayncGetGrsUrls_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlsCallBack_ == null)
				cb_ayncGetGrsUrls_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlsCallBack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_AyncGetGrsUrls_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlsCallBack_);
			return cb_ayncGetGrsUrls_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlsCallBack_;
		}

		static void n_AyncGetGrsUrls_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlsCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Framework.Network.Grs.IQueryUrlsCallBack)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.IQueryUrlsCallBack> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AyncGetGrsUrls (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsClient']/method[@name='ayncGetGrsUrls' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.huawei.hms.framework.network.grs.IQueryUrlsCallBack']]"
		[Register ("ayncGetGrsUrls", "(Ljava/lang/String;Lcom/huawei/hms/framework/network/grs/IQueryUrlsCallBack;)V", "GetAyncGetGrsUrls_Ljava_lang_String_Lcom_huawei_hms_framework_network_grs_IQueryUrlsCallBack_Handler")]
		public virtual unsafe void AyncGetGrsUrls (string p0, global::Huawei.Hms.Framework.Network.Grs.IQueryUrlsCallBack p1)
		{
			const string __id = "ayncGetGrsUrls.(Ljava/lang/String;Lcom/huawei/hms/framework/network/grs/IQueryUrlsCallBack;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_clearSp;
#pragma warning disable 0169
		static Delegate GetClearSpHandler ()
		{
			if (cb_clearSp == null)
				cb_clearSp = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearSp);
			return cb_clearSp;
		}

		static void n_ClearSp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearSp ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsClient']/method[@name='clearSp' and count(parameter)=0]"
		[Register ("clearSp", "()V", "GetClearSpHandler")]
		public virtual unsafe void ClearSp ()
		{
			const string __id = "clearSp.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_forceExpire;
#pragma warning disable 0169
		static Delegate GetForceExpireHandler ()
		{
			if (cb_forceExpire == null)
				cb_forceExpire = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_ForceExpire);
			return cb_forceExpire;
		}

		static bool n_ForceExpire (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ForceExpire ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsClient']/method[@name='forceExpire' and count(parameter)=0]"
		[Register ("forceExpire", "()Z", "GetForceExpireHandler")]
		public virtual unsafe bool ForceExpire ()
		{
			const string __id = "forceExpire.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_synGetGrsUrl_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSynGetGrsUrl_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_synGetGrsUrl_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_synGetGrsUrl_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_SynGetGrsUrl_Ljava_lang_String_Ljava_lang_String_);
			return cb_synGetGrsUrl_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_SynGetGrsUrl_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.SynGetGrsUrl (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsClient']/method[@name='synGetGrsUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("synGetGrsUrl", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetSynGetGrsUrl_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string SynGetGrsUrl (string p0, string p1)
		{
			const string __id = "synGetGrsUrl.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_synGetGrsUrls_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSynGetGrsUrls_Ljava_lang_String_Handler ()
		{
			if (cb_synGetGrsUrls_Ljava_lang_String_ == null)
				cb_synGetGrsUrls_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SynGetGrsUrls_Ljava_lang_String_);
			return cb_synGetGrsUrls_Ljava_lang_String_;
		}

		static IntPtr n_SynGetGrsUrls_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.SynGetGrsUrls (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsClient']/method[@name='synGetGrsUrls' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("synGetGrsUrls", "(Ljava/lang/String;)Ljava/util/Map;", "GetSynGetGrsUrls_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> SynGetGrsUrls (string p0)
		{
			const string __id = "synGetGrsUrls.(Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
