using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Aaid.Plugin {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/interface[@name='PushProxy']"
	[Register ("com/huawei/hms/aaid/plugin/PushProxy", "", "Huawei.Hms.Aaid.Plugin.IPushProxyInvoker")]
	public partial interface IPushProxy : IJavaObject, IJavaPeerable {

		global::Org.Json.JSONObject Platform {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/interface[@name='PushProxy']/method[@name='getPlatform' and count(parameter)=0]"
			[Register ("getPlatform", "()Lorg/json/JSONObject;", "GetGetPlatformHandler:Huawei.Hms.Aaid.Plugin.IPushProxyInvoker, Huawei.Hms.Opendevice")] get;
		}

		string ProxyType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/interface[@name='PushProxy']/method[@name='getProxyType' and count(parameter)=0]"
			[Register ("getProxyType", "()Ljava/lang/String;", "GetGetProxyTypeHandler:Huawei.Hms.Aaid.Plugin.IPushProxyInvoker, Huawei.Hms.Opendevice")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/interface[@name='PushProxy']/method[@name='deleteAllToken' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("deleteAllToken", "(Landroid/content/Context;)V", "GetDeleteAllToken_Landroid_content_Context_Handler:Huawei.Hms.Aaid.Plugin.IPushProxyInvoker, Huawei.Hms.Opendevice")]
		void DeleteAllToken (global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/interface[@name='PushProxy']/method[@name='deleteToken' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("deleteToken", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetDeleteToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler:Huawei.Hms.Aaid.Plugin.IPushProxyInvoker, Huawei.Hms.Opendevice")]
		void DeleteToken (global::Android.Content.Context p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/interface[@name='PushProxy']/method[@name='getToken' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("getToken", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V", "GetGetToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler:Huawei.Hms.Aaid.Plugin.IPushProxyInvoker, Huawei.Hms.Opendevice")]
		void GetToken (global::Android.Content.Context p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/interface[@name='PushProxy']/method[@name='subscribe' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("subscribe", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/huawei/hmf/tasks/Task;", "GetSubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler:Huawei.Hms.Aaid.Plugin.IPushProxyInvoker, Huawei.Hms.Opendevice")]
		global::Huawei.Hmf.Tasks.Task Subscribe (global::Android.Content.Context p0, string p1, string p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/interface[@name='PushProxy']/method[@name='turnOff' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("turnOff", "(Landroid/content/Context;Ljava/lang/String;)Lcom/huawei/hmf/tasks/Task;", "GetTurnOff_Landroid_content_Context_Ljava_lang_String_Handler:Huawei.Hms.Aaid.Plugin.IPushProxyInvoker, Huawei.Hms.Opendevice")]
		global::Huawei.Hmf.Tasks.Task TurnOff (global::Android.Content.Context p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/interface[@name='PushProxy']/method[@name='turnOn' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("turnOn", "(Landroid/content/Context;Ljava/lang/String;)Lcom/huawei/hmf/tasks/Task;", "GetTurnOn_Landroid_content_Context_Ljava_lang_String_Handler:Huawei.Hms.Aaid.Plugin.IPushProxyInvoker, Huawei.Hms.Opendevice")]
		global::Huawei.Hmf.Tasks.Task TurnOn (global::Android.Content.Context p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.plugin']/interface[@name='PushProxy']/method[@name='unsubscribe' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("unsubscribe", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/huawei/hmf/tasks/Task;", "GetUnsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler:Huawei.Hms.Aaid.Plugin.IPushProxyInvoker, Huawei.Hms.Opendevice")]
		global::Huawei.Hmf.Tasks.Task Unsubscribe (global::Android.Content.Context p0, string p1, string p2);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/aaid/plugin/PushProxy", DoNotGenerateAcw=true)]
	internal partial class IPushProxyInvoker : global::Java.Lang.Object, IPushProxy {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/aaid/plugin/PushProxy", typeof (IPushProxyInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IPushProxy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPushProxy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.aaid.plugin.PushProxy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPushProxyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getPlatform;
#pragma warning disable 0169
		static Delegate GetGetPlatformHandler ()
		{
			if (cb_getPlatform == null)
				cb_getPlatform = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPlatform);
			return cb_getPlatform;
		}

		static IntPtr n_GetPlatform (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Plugin.IPushProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Platform);
		}
#pragma warning restore 0169

		IntPtr id_getPlatform;
		public unsafe global::Org.Json.JSONObject Platform {
			get {
				if (id_getPlatform == IntPtr.Zero)
					id_getPlatform = JNIEnv.GetMethodID (class_ref, "getPlatform", "()Lorg/json/JSONObject;");
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPlatform), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getProxyType;
#pragma warning disable 0169
		static Delegate GetGetProxyTypeHandler ()
		{
			if (cb_getProxyType == null)
				cb_getProxyType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProxyType);
			return cb_getProxyType;
		}

		static IntPtr n_GetProxyType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Plugin.IPushProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProxyType);
		}
#pragma warning restore 0169

		IntPtr id_getProxyType;
		public unsafe string ProxyType {
			get {
				if (id_getProxyType == IntPtr.Zero)
					id_getProxyType = JNIEnv.GetMethodID (class_ref, "getProxyType", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getProxyType), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_deleteAllToken_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetDeleteAllToken_Landroid_content_Context_Handler ()
		{
			if (cb_deleteAllToken_Landroid_content_Context_ == null)
				cb_deleteAllToken_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DeleteAllToken_Landroid_content_Context_);
			return cb_deleteAllToken_Landroid_content_Context_;
		}

		static void n_DeleteAllToken_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Plugin.IPushProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAllToken (p0);
		}
#pragma warning restore 0169

		IntPtr id_deleteAllToken_Landroid_content_Context_;
		public unsafe void DeleteAllToken (global::Android.Content.Context p0)
		{
			if (id_deleteAllToken_Landroid_content_Context_ == IntPtr.Zero)
				id_deleteAllToken_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "deleteAllToken", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAllToken_Landroid_content_Context_, __args);
		}

		static Delegate cb_deleteToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_deleteToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_deleteToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_DeleteToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_deleteToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_DeleteToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Plugin.IPushProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.DeleteToken (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_deleteToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void DeleteToken (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_deleteToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_deleteToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "deleteToken", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_GetToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_GetToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Plugin.IPushProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.GetToken (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void GetToken (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getToken", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getToken_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
		}

		static Delegate cb_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Plugin.IPushProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Subscribe (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Huawei.Hmf.Tasks.Task Subscribe (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "subscribe", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/huawei/hmf/tasks/Task;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_turnOff_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTurnOff_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_turnOff_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_turnOff_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_TurnOff_Landroid_content_Context_Ljava_lang_String_);
			return cb_turnOff_Landroid_content_Context_Ljava_lang_String_;
		}

		static IntPtr n_TurnOff_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Plugin.IPushProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TurnOff (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_turnOff_Landroid_content_Context_Ljava_lang_String_;
		public unsafe global::Huawei.Hmf.Tasks.Task TurnOff (global::Android.Content.Context p0, string p1)
		{
			if (id_turnOff_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_turnOff_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "turnOff", "(Landroid/content/Context;Ljava/lang/String;)Lcom/huawei/hmf/tasks/Task;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_turnOff_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_turnOn_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTurnOn_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_turnOn_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_turnOn_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_TurnOn_Landroid_content_Context_Ljava_lang_String_);
			return cb_turnOn_Landroid_content_Context_Ljava_lang_String_;
		}

		static IntPtr n_TurnOn_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Plugin.IPushProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TurnOn (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_turnOn_Landroid_content_Context_Ljava_lang_String_;
		public unsafe global::Huawei.Hmf.Tasks.Task TurnOn (global::Android.Content.Context p0, string p1)
		{
			if (id_turnOn_Landroid_content_Context_Ljava_lang_String_ == IntPtr.Zero)
				id_turnOn_Landroid_content_Context_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "turnOn", "(Landroid/content/Context;Ljava/lang/String;)Lcom/huawei/hmf/tasks/Task;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			var __ret = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_turnOn_Landroid_content_Context_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_L) n_Unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_);
			return cb_unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Plugin.IPushProxy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unsubscribe (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_;
		public unsafe global::Huawei.Hmf.Tasks.Task Unsubscribe (global::Android.Content.Context p0, string p1, string p2)
		{
			if (id_unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "unsubscribe", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/String;)Lcom/huawei/hmf/tasks/Task;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			var __ret = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unsubscribe_Landroid_content_Context_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}

}
