using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Hianalytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/hianalytics/HiAnalyticsUtils", DoNotGenerateAcw=true)]
	public partial class HiAnalyticsUtils : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/field[@name='LOCK_INST']"
		[Register ("LOCK_INST")]
		public static global::Java.Lang.Object LockInst {
			get {
				const string __id = "LOCK_INST.Ljava/lang/Object;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/field[@name='LOCK_REPORT']"
		[Register ("LOCK_REPORT")]
		public static global::Java.Lang.Object LockReport {
			get {
				const string __id = "LOCK_REPORT.Ljava/lang/Object;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "HiAnalyticsUtils";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/field[@name='count']"
		[Register ("count")]
		public int Count {
			get {
				const string __id = "count.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "count.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/field[@name='isHianalyticsExist']"
		[Register ("isHianalyticsExist")]
		public bool IsHianalyticsExist {
			get {
				const string __id = "isHianalyticsExist.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isHianalyticsExist.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/field[@name='sInstance']"
		[Register ("sInstance")]
		public static global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils SInstance {
			get {
				const string __id = "sInstance.Lcom/huawei/hms/support/hianalytics/HiAnalyticsUtils;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sInstance.Lcom/huawei/hms/support/hianalytics/HiAnalyticsUtils;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/hianalytics/HiAnalyticsUtils", typeof (HiAnalyticsUtils));
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

		protected HiAnalyticsUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/constructor[@name='HiAnalyticsUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HiAnalyticsUtils ()
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

		static Delegate cb_getInitFlag;
#pragma warning disable 0169
		static Delegate GetGetInitFlagHandler ()
		{
			if (cb_getInitFlag == null)
				cb_getInitFlag = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetInitFlag);
			return cb_getInitFlag;
		}

		static bool n_GetInitFlag (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InitFlag;
		}
#pragma warning restore 0169

		public virtual unsafe bool InitFlag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='getInitFlag' and count(parameter)=0]"
			[Register ("getInitFlag", "()Z", "GetGetInitFlagHandler")]
			get {
				const string __id = "getInitFlag.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/huawei/hms/support/hianalytics/HiAnalyticsUtils;", "")]
			get {
				const string __id = "getInstance.()Lcom/huawei/hms/support/hianalytics/HiAnalyticsUtils;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='convertToLinkedHashMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("convertToLinkedHashMap", "(Ljava/util/Map;)Ljava/util/LinkedHashMap;", "")]
		public static unsafe global::Java.Util.LinkedHashMap ConvertToLinkedHashMap (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			const string __id = "convertToLinkedHashMap.(Ljava/util/Map;)Ljava/util/LinkedHashMap;";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_enableLog;
#pragma warning disable 0169
		static Delegate GetEnableLogHandler ()
		{
			if (cb_enableLog == null)
				cb_enableLog = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_EnableLog);
			return cb_enableLog;
		}

		static void n_EnableLog (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableLog ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='enableLog' and count(parameter)=0]"
		[Register ("enableLog", "()V", "GetEnableLogHandler")]
		public virtual unsafe void EnableLog ()
		{
			const string __id = "enableLog.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_enableLog_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetEnableLog_Landroid_content_Context_Handler ()
		{
			if (cb_enableLog_Landroid_content_Context_ == null)
				cb_enableLog_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_EnableLog_Landroid_content_Context_);
			return cb_enableLog_Landroid_content_Context_;
		}

		static void n_EnableLog_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EnableLog (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='enableLog' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("enableLog", "(Landroid/content/Context;)V", "GetEnableLog_Landroid_content_Context_Handler")]
		public virtual unsafe void EnableLog (global::Android.Content.Context p0)
		{
			const string __id = "enableLog.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_hasError_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetHasError_Landroid_content_Context_Handler ()
		{
			if (cb_hasError_Landroid_content_Context_ == null)
				cb_hasError_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasError_Landroid_content_Context_);
			return cb_hasError_Landroid_content_Context_;
		}

		static bool n_HasError_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasError (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='hasError' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("hasError", "(Landroid/content/Context;)Z", "GetHasError_Landroid_content_Context_Handler")]
		public virtual unsafe bool HasError (global::Android.Content.Context p0)
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnBuoyEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='onBuoyEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='onEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnEvent2 (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='onEvent2' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnNewEvent (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='onNewEvent' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map']]"
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

		static Delegate cb_onNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_I;
#pragma warning disable 0169
		static Delegate GetOnNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_IHandler ()
		{
			if (cb_onNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_I == null)
				cb_onNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLI_V) n_OnNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_I);
			return cb_onNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_I;
		}

		static void n_OnNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnNewEvent (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='onNewEvent' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='int']]"
		[Register ("onNewEvent", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;I)V", "GetOnNewEvent_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_IHandler")]
		public virtual unsafe void OnNewEvent (global::Android.Content.Context p0, string p1, global::System.Collections.IDictionary p2, int p3)
		{
			const string __id = "onNewEvent.(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;I)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_onReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_onReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_onReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_);
			return cb_onReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_OnReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnReport (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='onReport' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map']]"
		[Register ("onReport", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)V", "GetOnReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe void OnReport (global::Android.Content.Context p0, string p1, global::System.Collections.IDictionary p2)
		{
			const string __id = "onReport.(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;)V";
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

		static Delegate cb_onReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_I;
#pragma warning disable 0169
		static Delegate GetOnReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_IHandler ()
		{
			if (cb_onReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_I == null)
				cb_onReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLI_V) n_OnReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_I);
			return cb_onReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_I;
		}

		static void n_OnReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Hianalytics.HiAnalyticsUtils> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnReport (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='onReport' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='int']]"
		[Register ("onReport", "(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;I)V", "GetOnReport_Landroid_content_Context_Ljava_lang_String_Ljava_util_Map_IHandler")]
		public virtual unsafe void OnReport (global::Android.Content.Context p0, string p1, global::System.Collections.IDictionary p2, int p3)
		{
			const string __id = "onReport.(Landroid/content/Context;Ljava/lang/String;Ljava/util/Map;I)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.hianalytics']/class[@name='HiAnalyticsUtils']/method[@name='versionCodeToName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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
