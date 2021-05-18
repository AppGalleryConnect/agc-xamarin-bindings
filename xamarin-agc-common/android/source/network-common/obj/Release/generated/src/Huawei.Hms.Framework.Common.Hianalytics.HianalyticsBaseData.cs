using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common.Hianalytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsBaseData']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/hianalytics/HianalyticsBaseData", DoNotGenerateAcw=true)]
	public abstract partial class HianalyticsBaseData : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsBaseData']/field[@name='SDK_NAME']"
		[Register ("SDK_NAME")]
		protected const string SdkName = (string) "sdk_name";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/hianalytics/HianalyticsBaseData", typeof (HianalyticsBaseData));
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

		protected HianalyticsBaseData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsBaseData']/constructor[@name='HianalyticsBaseData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HianalyticsBaseData ()
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

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsBaseData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsBaseData']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/util/LinkedHashMap;", "GetGetHandler")]
		public virtual unsafe global::Java.Util.LinkedHashMap Get ()
		{
			const string __id = "get.()Ljava/util/LinkedHashMap;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsBaseData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsBaseData']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)Lcom/huawei/hms/framework/common/hianalytics/HianalyticsBaseData;", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsBaseData Put (string p0, string p1)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/String;)Lcom/huawei/hms/framework/common/hianalytics/HianalyticsBaseData;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsBaseData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_put_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_JHandler ()
		{
			if (cb_put_Ljava_lang_String_J == null)
				cb_put_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_L) n_Put_Ljava_lang_String_J);
			return cb_put_Ljava_lang_String_J;
		}

		static IntPtr n_Put_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsBaseData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsBaseData']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("put", "(Ljava/lang/String;J)Lcom/huawei/hms/framework/common/hianalytics/HianalyticsBaseData;", "GetPut_Ljava_lang_String_JHandler")]
		public virtual unsafe global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsBaseData Put (string p0, long p1)
		{
			const string __id = "put.(Ljava/lang/String;J)Lcom/huawei/hms/framework/common/hianalytics/HianalyticsBaseData;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsBaseData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_util_LinkedHashMap_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_util_LinkedHashMap_Handler ()
		{
			if (cb_put_Ljava_util_LinkedHashMap_ == null)
				cb_put_Ljava_util_LinkedHashMap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Put_Ljava_util_LinkedHashMap_);
			return cb_put_Ljava_util_LinkedHashMap_;
		}

		static IntPtr n_Put_Ljava_util_LinkedHashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsBaseData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsBaseData']/method[@name='put' and count(parameter)=1 and parameter[1][@type='java.util.LinkedHashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("put", "(Ljava/util/LinkedHashMap;)Lcom/huawei/hms/framework/common/hianalytics/HianalyticsBaseData;", "GetPut_Ljava_util_LinkedHashMap_Handler")]
		public virtual unsafe global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsBaseData Put (global::Java.Util.LinkedHashMap p0)
		{
			const string __id = "put.(Ljava/util/LinkedHashMap;)Lcom/huawei/hms/framework/common/hianalytics/HianalyticsBaseData;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsBaseData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/hianalytics/HianalyticsBaseData", DoNotGenerateAcw=true)]
	internal partial class HianalyticsBaseDataInvoker : HianalyticsBaseData {

		public HianalyticsBaseDataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/hianalytics/HianalyticsBaseData", typeof (HianalyticsBaseDataInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
