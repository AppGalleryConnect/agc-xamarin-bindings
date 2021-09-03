using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Aaid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceIdEx']"
	[global::Android.Runtime.Register ("com/huawei/hms/aaid/HmsInstanceIdEx", DoNotGenerateAcw=true)]
	public partial class HmsInstanceIdEx : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceIdEx']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "HmsInstanceIdEx";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceIdEx']/field[@name='b']"
		[Register ("b")]
		public global::Com.Huawei.Hms.Aaid.Utils.PushPreferences B {
			get {
				const string __id = "b.Lcom/huawei/hms/aaid/utils/PushPreferences;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Lcom/huawei/hms/aaid/utils/PushPreferences;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceIdEx']/field[@name='c']"
		[Register ("c")]
		public global::Huawei.Hms.Common.HuaweiApi C {
			get {
				const string __id = "c.Lcom/huawei/hms/common/HuaweiApi;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lcom/huawei/hms/common/HuaweiApi;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/aaid/HmsInstanceIdEx", typeof (HmsInstanceIdEx));
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

		protected HmsInstanceIdEx (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceIdEx']/constructor[@name='HmsInstanceIdEx' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe HmsInstanceIdEx (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceIdEx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Token);
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hmf.Tasks.Task Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceIdEx']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Lcom/huawei/hmf/tasks/Task;", "GetGetTokenHandler")]
			get {
				const string __id = "getToken.()Lcom/huawei/hmf/tasks/Task;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceIdEx']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("a", "(Ljava/lang/Exception;)Lcom/huawei/hmf/tasks/Task;", "")]
		public unsafe global::Huawei.Hmf.Tasks.Task A (global::Java.Lang.Exception p0)
		{
			const string __id = "a.(Ljava/lang/Exception;)Lcom/huawei/hmf/tasks/Task;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceIdEx']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public unsafe string A (string p0)
		{
			const string __id = "a.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteAAID_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteAAID_Ljava_lang_String_Handler ()
		{
			if (cb_deleteAAID_Ljava_lang_String_ == null)
				cb_deleteAAID_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DeleteAAID_Ljava_lang_String_);
			return cb_deleteAAID_Ljava_lang_String_;
		}

		static void n_DeleteAAID_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceIdEx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAAID (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceIdEx']/method[@name='deleteAAID' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteAAID", "(Ljava/lang/String;)V", "GetDeleteAAID_Ljava_lang_String_Handler")]
		public virtual unsafe void DeleteAAID (string p0)
		{
			const string __id = "deleteAAID.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getAAId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAAId_Ljava_lang_String_Handler ()
		{
			if (cb_getAAId_Ljava_lang_String_ == null)
				cb_getAAId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAAId_Ljava_lang_String_);
			return cb_getAAId_Ljava_lang_String_;
		}

		static IntPtr n_GetAAId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceIdEx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetAAId (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceIdEx']/method[@name='getAAId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAAId", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetAAId_Ljava_lang_String_Handler")]
		public virtual unsafe string GetAAId (string p0)
		{
			const string __id = "getAAId.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getCreationTime_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCreationTime_Ljava_lang_String_Handler ()
		{
			if (cb_getCreationTime_Ljava_lang_String_ == null)
				cb_getCreationTime_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_GetCreationTime_Ljava_lang_String_);
			return cb_getCreationTime_Ljava_lang_String_;
		}

		static long n_GetCreationTime_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceIdEx> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetCreationTime (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceIdEx']/method[@name='getCreationTime' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCreationTime", "(Ljava/lang/String;)J", "GetGetCreationTime_Ljava_lang_String_Handler")]
		public virtual unsafe long GetCreationTime (string p0)
		{
			const string __id = "getCreationTime.(Ljava/lang/String;)J";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceIdEx']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/huawei/hms/aaid/HmsInstanceIdEx;", "")]
		public static unsafe global::Huawei.Hms.Aaid.HmsInstanceIdEx GetInstance (global::Android.Content.Context p0)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/huawei/hms/aaid/HmsInstanceIdEx;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceIdEx> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
