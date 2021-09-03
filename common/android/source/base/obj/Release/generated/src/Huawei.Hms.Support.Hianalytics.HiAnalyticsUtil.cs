using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Hianalytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/hianalytics/HiAnalyticsUtil", DoNotGenerateAcw=true)]
	public partial class HiAnalyticsUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/hianalytics/HiAnalyticsUtil", typeof (HiAnalyticsUtil));
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

		protected HiAnalyticsUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/constructor[@name='HiAnalyticsUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HiAnalyticsUtil ()
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

		static Delegate cb_hasError;
#pragma warning disable 0169
		static Delegate GetHasErrorHandler ()
		{
			if (cb_hasError == null)
				cb_hasError = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasError);
			return cb_hasError;
		}

		static bool n_HasError (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasError;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='hasError' and count(parameter)=0]"
			[Register ("hasError", "()Z", "GetHasErrorHandler")]
			get {
				const string __id = "hasError.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtil Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/huawei/hms/support/hianalytics/HiAnalyticsUtil;", "")]
			get {
				const string __id = "getInstance.()Lcom/huawei/hms/support/hianalytics/HiAnalyticsUtil;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtil> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMapForBi_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetMapForBi_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_getMapForBi_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_getMapForBi_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetMapForBi_Landroid_content_Context_Ljava_lang_String_);
			return cb_getMapForBi_Landroid_content_Context_Ljava_lang_String_;
		}

		static IntPtr n_GetMapForBi_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetMapForBi (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='getMapForBi' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("getMapForBi", "(Landroid/content/Context;Ljava/lang/String;)Ljava/util/Map;", "GetGetMapForBi_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> GetMapForBi (global::Android.Content.Context p0, string p1)
		{
			const string __id = "getMapForBi.(Landroid/content/Context;Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getMapFromForegroundRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_;
#pragma warning disable 0169
		static Delegate GetGetMapFromForegroundRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_Handler ()
		{
			if (cb_getMapFromForegroundRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_ == null)
				cb_getMapFromForegroundRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetMapFromForegroundRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_);
			return cb_getMapFromForegroundRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_;
		}

		static IntPtr n_GetMapFromForegroundRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetMapFromForegroundRequestHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='getMapFromForegroundRequestHeader' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.internal.RequestHeader']]"
		[Register ("getMapFromForegroundRequestHeader", "(Lcom/huawei/hms/common/internal/RequestHeader;)Ljava/util/Map;", "GetGetMapFromForegroundRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> GetMapFromForegroundRequestHeader (global::Huawei.Hms.Common.Internal.RequestHeader p0)
		{
			const string __id = "getMapFromForegroundRequestHeader.(Lcom/huawei/hms/common/internal/RequestHeader;)Ljava/util/Map;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='getMapFromForegroundResponseHeader' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.internal.ResponseHeader']]"
		[Register ("getMapFromForegroundResponseHeader", "(Lcom/huawei/hms/common/internal/ResponseHeader;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> GetMapFromForegroundResponseHeader (global::Huawei.Hms.Common.Internal.ResponseHeader p0)
		{
			const string __id = "getMapFromForegroundResponseHeader.(Lcom/huawei/hms/common/internal/ResponseHeader;)Ljava/util/Map;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getMapFromRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_;
#pragma warning disable 0169
		static Delegate GetGetMapFromRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_Handler ()
		{
			if (cb_getMapFromRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_ == null)
				cb_getMapFromRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetMapFromRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_);
			return cb_getMapFromRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_;
		}

		static IntPtr n_GetMapFromRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.RequestHeader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.GetMapFromRequestHeader (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='getMapFromRequestHeader' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.internal.RequestHeader']]"
		[Register ("getMapFromRequestHeader", "(Lcom/huawei/hms/common/internal/RequestHeader;)Ljava/util/Map;", "GetGetMapFromRequestHeader_Lcom_huawei_hms_common_internal_RequestHeader_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> GetMapFromRequestHeader (global::Huawei.Hms.Common.Internal.RequestHeader p0)
		{
			const string __id = "getMapFromRequestHeader.(Lcom/huawei/hms/common/internal/RequestHeader;)Ljava/util/Map;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='getMapFromRequestHeader' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.internal.ResponseHeader']]"
		[Register ("getMapFromRequestHeader", "(Lcom/huawei/hms/common/internal/ResponseHeader;)Ljava/util/Map;", "")]
		public static unsafe global::System.Collections.Generic.IDictionary<string, string> GetMapFromRequestHeader (global::Huawei.Hms.Common.Internal.ResponseHeader p0)
		{
			const string __id = "getMapFromRequestHeader.(Lcom/huawei/hms/common/internal/ResponseHeader;)Ljava/util/Map;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_hasError_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInvokeHasError_Landroid_content_Context_Handler ()
		{
			if (cb_hasError_Landroid_content_Context_ == null)
				cb_hasError_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_InvokeHasError_Landroid_content_Context_);
			return cb_hasError_Landroid_content_Context_;
		}

		static bool n_InvokeHasError_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.InvokeHasError (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='hasError' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("hasError", "(Landroid/content/Context;)Z", "GetInvokeHasError_Landroid_content_Context_Handler")]
		public virtual unsafe bool InvokeHasError (global::Android.Content.Context p0)
		{
			const string __id = "hasError.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onBuoyEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnBuoyEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onBuoyEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onBuoyEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnBuoyEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_onBuoyEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnBuoyEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnBuoyEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='onBuoyEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onBuoyEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetOnBuoyEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void OnBuoyEvent (global::Android.Content.Context p0, string p1, string p2)
		{
			const string __id = "onBuoyEvent.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='onEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetOnEvent_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void OnEvent (global::Android.Content.Context p0, string p1, string p2)
		{
			const string __id = "onEvent.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_);
			return cb_onEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_OnEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='onEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)V", "GetOnEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void OnEvent (global::Android.Content.Context p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			const string __id = "onEvent.(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_onEvent2_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnEvent2_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_onEvent2_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_onEvent2_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnEvent2_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_onEvent2_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_OnEvent2_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent2 (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='onEvent2' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("onEvent2", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetOnEvent2_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void OnEvent2 (global::Android.Content.Context p0, string p1, string p2)
		{
			const string __id = "onEvent2.(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_onNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_onNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_);
			return cb_onNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_OnNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnNewEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='onNewEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map']]"
		[Register ("onNewEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)V", "GetOnNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void OnNewEvent (global::Android.Content.Context p0, string p1, global::System.Collections.IDictionary p2)
		{
			const string __id = "onNewEvent.(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtil']/method[@name='versionCodeToName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("versionCodeToName", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string VersionCodeToName (string p0)
		{
			const string __id = "versionCodeToName.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
