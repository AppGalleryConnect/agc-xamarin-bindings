using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common.Hianalytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsHelper']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/hianalytics/HianalyticsHelper", DoNotGenerateAcw=true)]
	public partial class HianalyticsHelper : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/hianalytics/HianalyticsHelper", typeof (HianalyticsHelper));
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

		protected HianalyticsHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsHelper Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsHelper']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/huawei/hms/framework/common/hianalytics/HianalyticsHelper;", "")]
			get {
				const string __id = "getInstance.()Lcom/huawei/hms/framework/common/hianalytics/HianalyticsHelper;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsHelper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getReportExecutor;
#pragma warning disable 0169
		static Delegate GetGetReportExecutorHandler ()
		{
			if (cb_getReportExecutor == null)
				cb_getReportExecutor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetReportExecutor);
			return cb_getReportExecutor;
		}

		static IntPtr n_GetReportExecutor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ReportExecutor);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Concurrent.IExecutorService ReportExecutor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsHelper']/method[@name='getReportExecutor' and count(parameter)=0]"
			[Register ("getReportExecutor", "()Ljava/util/concurrent/ExecutorService;", "GetGetReportExecutorHandler")]
			get {
				const string __id = "getReportExecutor.()Ljava/util/concurrent/ExecutorService;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IExecutorService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEnableReport_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsEnableReport_Landroid_content_Context_Handler ()
		{
			if (cb_isEnableReport_Landroid_content_Context_ == null)
				cb_isEnableReport_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsEnableReport_Landroid_content_Context_);
			return cb_isEnableReport_Landroid_content_Context_;
		}

		static bool n_IsEnableReport_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsEnableReport (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsHelper']/method[@name='isEnableReport' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isEnableReport", "(Landroid/content/Context;)Z", "GetIsEnableReport_Landroid_content_Context_Handler")]
		public virtual unsafe bool IsEnableReport (global::Android.Content.Context p0)
		{
			const string __id = "isEnableReport.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_isEnableReportNoSeed_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsEnableReportNoSeed_Landroid_content_Context_Handler ()
		{
			if (cb_isEnableReportNoSeed_Landroid_content_Context_ == null)
				cb_isEnableReportNoSeed_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsEnableReportNoSeed_Landroid_content_Context_);
			return cb_isEnableReportNoSeed_Landroid_content_Context_;
		}

		static bool n_IsEnableReportNoSeed_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsEnableReportNoSeed (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsHelper']/method[@name='isEnableReportNoSeed' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isEnableReportNoSeed", "(Landroid/content/Context;)Z", "GetIsEnableReportNoSeed_Landroid_content_Context_Handler")]
		public virtual unsafe bool IsEnableReportNoSeed (global::Android.Content.Context p0)
		{
			const string __id = "isEnableReportNoSeed.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onEvent_Ljava_util_LinkedHashMap_;
#pragma warning disable 0169
		static Delegate GetOnEvent_Ljava_util_LinkedHashMap_Handler ()
		{
			if (cb_onEvent_Ljava_util_LinkedHashMap_ == null)
				cb_onEvent_Ljava_util_LinkedHashMap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnEvent_Ljava_util_LinkedHashMap_);
			return cb_onEvent_Ljava_util_LinkedHashMap_;
		}

		static void n_OnEvent_Ljava_util_LinkedHashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsHelper']/method[@name='onEvent' and count(parameter)=1 and parameter[1][@type='java.util.LinkedHashMap&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onEvent", "(Ljava/util/LinkedHashMap;)V", "GetOnEvent_Ljava_util_LinkedHashMap_Handler")]
		public virtual unsafe void OnEvent (global::Java.Util.LinkedHashMap p0)
		{
			const string __id = "onEvent.(Ljava/util/LinkedHashMap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onEvent_Ljava_util_LinkedHashMap_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnEvent_Ljava_util_LinkedHashMap_Ljava_lang_String_Handler ()
		{
			if (cb_onEvent_Ljava_util_LinkedHashMap_Ljava_lang_String_ == null)
				cb_onEvent_Ljava_util_LinkedHashMap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnEvent_Ljava_util_LinkedHashMap_Ljava_lang_String_);
			return cb_onEvent_Ljava_util_LinkedHashMap_Ljava_lang_String_;
		}

		static void n_OnEvent_Ljava_util_LinkedHashMap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsHelper']/method[@name='onEvent' and count(parameter)=2 and parameter[1][@type='java.util.LinkedHashMap&lt;java.lang.String, java.lang.String&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("onEvent", "(Ljava/util/LinkedHashMap;Ljava/lang/String;)V", "GetOnEvent_Ljava_util_LinkedHashMap_Ljava_lang_String_Handler")]
		public virtual unsafe void OnEvent (global::Java.Util.LinkedHashMap p0, string p1)
		{
			const string __id = "onEvent.(Ljava/util/LinkedHashMap;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_reportException_Ljava_lang_Throwable_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReportException_Ljava_lang_Throwable_Ljava_lang_String_Handler ()
		{
			if (cb_reportException_Ljava_lang_Throwable_Ljava_lang_String_ == null)
				cb_reportException_Ljava_lang_Throwable_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_ReportException_Ljava_lang_Throwable_Ljava_lang_String_);
			return cb_reportException_Ljava_lang_Throwable_Ljava_lang_String_;
		}

		static void n_ReportException_Ljava_lang_Throwable_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ReportException (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsHelper']/method[@name='reportException' and count(parameter)=2 and parameter[1][@type='java.lang.Throwable'] and parameter[2][@type='java.lang.String']]"
		[Register ("reportException", "(Ljava/lang/Throwable;Ljava/lang/String;)V", "GetReportException_Ljava_lang_Throwable_Ljava_lang_String_Handler")]
		public virtual unsafe void ReportException (global::Java.Lang.Throwable p0, string p1)
		{
			const string __id = "reportException.(Ljava/lang/Throwable;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_setHaTag_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHaTag_Ljava_lang_String_Handler ()
		{
			if (cb_setHaTag_Ljava_lang_String_ == null)
				cb_setHaTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetHaTag_Ljava_lang_String_);
			return cb_setHaTag_Ljava_lang_String_;
		}

		static void n_SetHaTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.HianalyticsHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetHaTag (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='HianalyticsHelper']/method[@name='setHaTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setHaTag", "(Ljava/lang/String;)V", "GetSetHaTag_Ljava_lang_String_Handler")]
		public virtual unsafe void SetHaTag (string p0)
		{
			const string __id = "setHaTag.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
