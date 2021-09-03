using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='CoreBaseResponse']"
	[global::Android.Runtime.Register ("com/huawei/hms/adapter/CoreBaseResponse", DoNotGenerateAcw=true)]
	public partial class CoreBaseResponse : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/adapter/CoreBaseResponse", typeof (CoreBaseResponse));
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

		protected CoreBaseResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='CoreBaseResponse']/constructor[@name='CoreBaseResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CoreBaseResponse ()
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

		static Delegate cb_getIntent;
#pragma warning disable 0169
		static Delegate GetGetIntentHandler ()
		{
			if (cb_getIntent == null)
				cb_getIntent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIntent);
			return cb_getIntent;
		}

		static IntPtr n_GetIntent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.CoreBaseResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Intent);
		}
#pragma warning restore 0169

		static Delegate cb_setIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSetIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_setIntent_Landroid_content_Intent_ == null)
				cb_setIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIntent_Landroid_content_Intent_);
			return cb_setIntent_Landroid_content_Intent_;
		}

		static void n_SetIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.CoreBaseResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Intent = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Intent Intent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='CoreBaseResponse']/method[@name='getIntent' and count(parameter)=0]"
			[Register ("getIntent", "()Landroid/content/Intent;", "GetGetIntentHandler")]
			get {
				const string __id = "getIntent.()Landroid/content/Intent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='CoreBaseResponse']/method[@name='setIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
			[Register ("setIntent", "(Landroid/content/Intent;)V", "GetSetIntent_Landroid_content_Intent_Handler")]
			set {
				const string __id = "setIntent.(Landroid/content/Intent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getJsonBody;
#pragma warning disable 0169
		static Delegate GetGetJsonBodyHandler ()
		{
			if (cb_getJsonBody == null)
				cb_getJsonBody = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetJsonBody);
			return cb_getJsonBody;
		}

		static IntPtr n_GetJsonBody (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.CoreBaseResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.JsonBody);
		}
#pragma warning restore 0169

		static Delegate cb_setJsonBody_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetJsonBody_Ljava_lang_String_Handler ()
		{
			if (cb_setJsonBody_Ljava_lang_String_ == null)
				cb_setJsonBody_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetJsonBody_Ljava_lang_String_);
			return cb_setJsonBody_Ljava_lang_String_;
		}

		static void n_SetJsonBody_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.CoreBaseResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.JsonBody = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string JsonBody {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='CoreBaseResponse']/method[@name='getJsonBody' and count(parameter)=0]"
			[Register ("getJsonBody", "()Ljava/lang/String;", "GetGetJsonBodyHandler")]
			get {
				const string __id = "getJsonBody.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='CoreBaseResponse']/method[@name='setJsonBody' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setJsonBody", "(Ljava/lang/String;)V", "GetSetJsonBody_Ljava_lang_String_Handler")]
			set {
				const string __id = "setJsonBody.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getJsonHeader;
#pragma warning disable 0169
		static Delegate GetGetJsonHeaderHandler ()
		{
			if (cb_getJsonHeader == null)
				cb_getJsonHeader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetJsonHeader);
			return cb_getJsonHeader;
		}

		static IntPtr n_GetJsonHeader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.CoreBaseResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.JsonHeader);
		}
#pragma warning restore 0169

		static Delegate cb_setJsonHeader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetJsonHeader_Ljava_lang_String_Handler ()
		{
			if (cb_setJsonHeader_Ljava_lang_String_ == null)
				cb_setJsonHeader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetJsonHeader_Ljava_lang_String_);
			return cb_setJsonHeader_Ljava_lang_String_;
		}

		static void n_SetJsonHeader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.CoreBaseResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.JsonHeader = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string JsonHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='CoreBaseResponse']/method[@name='getJsonHeader' and count(parameter)=0]"
			[Register ("getJsonHeader", "()Ljava/lang/String;", "GetGetJsonHeaderHandler")]
			get {
				const string __id = "getJsonHeader.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='CoreBaseResponse']/method[@name='setJsonHeader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setJsonHeader", "(Ljava/lang/String;)V", "GetSetJsonHeader_Ljava_lang_String_Handler")]
			set {
				const string __id = "setJsonHeader.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPendingIntent;
#pragma warning disable 0169
		static Delegate GetGetPendingIntentHandler ()
		{
			if (cb_getPendingIntent == null)
				cb_getPendingIntent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPendingIntent);
			return cb_getPendingIntent;
		}

		static IntPtr n_GetPendingIntent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.CoreBaseResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PendingIntent);
		}
#pragma warning restore 0169

		static Delegate cb_setPendingIntent_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetSetPendingIntent_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_setPendingIntent_Landroid_app_PendingIntent_ == null)
				cb_setPendingIntent_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPendingIntent_Landroid_app_PendingIntent_);
			return cb_setPendingIntent_Landroid_app_PendingIntent_;
		}

		static void n_SetPendingIntent_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.CoreBaseResponse> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PendingIntent = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.PendingIntent PendingIntent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='CoreBaseResponse']/method[@name='getPendingIntent' and count(parameter)=0]"
			[Register ("getPendingIntent", "()Landroid/app/PendingIntent;", "GetGetPendingIntentHandler")]
			get {
				const string __id = "getPendingIntent.()Landroid/app/PendingIntent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='CoreBaseResponse']/method[@name='setPendingIntent' and count(parameter)=1 and parameter[1][@type='android.app.PendingIntent']]"
			[Register ("setPendingIntent", "(Landroid/app/PendingIntent;)V", "GetSetPendingIntent_Landroid_app_PendingIntent_Handler")]
			set {
				const string __id = "setPendingIntent.(Landroid/app/PendingIntent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
