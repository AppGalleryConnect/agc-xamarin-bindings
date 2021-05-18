using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Aaid {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']"
	[global::Android.Runtime.Register ("com/huawei/hms/aaid/HmsInstanceId", DoNotGenerateAcw=true)]
	public partial class HmsInstanceId : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "HmsInstanceId";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/field[@name='b']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/field[@name='c']"
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
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/aaid/HmsInstanceId", typeof (HmsInstanceId));
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

		protected HmsInstanceId (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/constructor[@name='HmsInstanceId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe HmsInstanceId (global::Android.Content.Context p0)
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

		static Delegate cb_getAAID;
#pragma warning disable 0169
		static Delegate GetGetAAIDHandler ()
		{
			if (cb_getAAID == null)
				cb_getAAID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAAID);
			return cb_getAAID;
		}

		static IntPtr n_GetAAID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AAID);
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hmf.Tasks.Task AAID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='getAAID' and count(parameter)=0]"
			[Register ("getAAID", "()Lcom/huawei/hmf/tasks/Task;", "GetGetAAIDHandler")]
			get {
				const string __id = "getAAID.()Lcom/huawei/hmf/tasks/Task;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCreationTime;
#pragma warning disable 0169
		static Delegate GetGetCreationTimeHandler ()
		{
			if (cb_getCreationTime == null)
				cb_getCreationTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetCreationTime);
			return cb_getCreationTime;
		}

		static long n_GetCreationTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreationTime;
		}
#pragma warning restore 0169

		public virtual unsafe long CreationTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='getCreationTime' and count(parameter)=0]"
			[Register ("getCreationTime", "()J", "GetGetCreationTimeHandler")]
			get {
				const string __id = "getCreationTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				const string __id = "getToken.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()V", "")]
		public unsafe void A ()
		{
			const string __id = "a.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.aaid.entity.DeleteTokenReq'] and parameter[2][@type='int']]"
		[Register ("a", "(Lcom/huawei/hms/aaid/entity/DeleteTokenReq;I)V", "")]
		public unsafe void A (global::Huawei.Hms.Aaid.Entity.DeleteTokenReq p0, int p1)
		{
			const string __id = "a.(Lcom/huawei/hms/aaid/entity/DeleteTokenReq;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='a' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.aaid.entity.TokenReq'] and parameter[2][@type='int']]"
		[Register ("a", "(Lcom/huawei/hms/aaid/entity/TokenReq;I)Ljava/lang/String;", "")]
		public unsafe string A (global::Huawei.Hms.Aaid.Entity.TokenReq p0, int p1)
		{
			const string __id = "a.(Lcom/huawei/hms/aaid/entity/TokenReq;I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public unsafe void A (string p0)
		{
			const string __id = "a.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteAAID;
#pragma warning disable 0169
		static Delegate GetDeleteAAIDHandler ()
		{
			if (cb_deleteAAID == null)
				cb_deleteAAID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DeleteAAID);
			return cb_deleteAAID;
		}

		static void n_DeleteAAID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAAID ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='deleteAAID' and count(parameter)=0]"
		[Register ("deleteAAID", "()V", "GetDeleteAAIDHandler")]
		public virtual unsafe void DeleteAAID ()
		{
			const string __id = "deleteAAID.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_deleteToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteToken_Ljava_lang_String_Handler ()
		{
			if (cb_deleteToken_Ljava_lang_String_ == null)
				cb_deleteToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DeleteToken_Ljava_lang_String_);
			return cb_deleteToken_Ljava_lang_String_;
		}

		static void n_DeleteToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteToken (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='deleteToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteToken", "(Ljava/lang/String;)V", "GetDeleteToken_Ljava_lang_String_Handler")]
		public virtual unsafe void DeleteToken (string p0)
		{
			const string __id = "deleteToken.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_deleteToken_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteToken_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_deleteToken_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_deleteToken_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DeleteToken_Ljava_lang_String_Ljava_lang_String_);
			return cb_deleteToken_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_DeleteToken_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.DeleteToken (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='deleteToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("deleteToken", "(Ljava/lang/String;Ljava/lang/String;)V", "GetDeleteToken_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void DeleteToken (string p0, string p1)
		{
			const string __id = "deleteToken.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/huawei/hms/aaid/HmsInstanceId;", "")]
		public static unsafe global::Huawei.Hms.Aaid.HmsInstanceId GetInstance (global::Android.Content.Context p0)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/huawei/hms/aaid/HmsInstanceId;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceId> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetToken_Ljava_lang_String_Handler ()
		{
			if (cb_getToken_Ljava_lang_String_ == null)
				cb_getToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetToken_Ljava_lang_String_);
			return cb_getToken_Ljava_lang_String_;
		}

		static IntPtr n_GetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetToken (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='getToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getToken", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetToken_Ljava_lang_String_Handler")]
		public virtual unsafe string GetToken (string p0)
		{
			const string __id = "getToken.(Ljava/lang/String;)Ljava/lang/String;";
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

		static Delegate cb_getToken_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetToken_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getToken_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getToken_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetToken_Ljava_lang_String_Ljava_lang_String_);
			return cb_getToken_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetToken_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.HmsInstanceId> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetToken (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid']/class[@name='HmsInstanceId']/method[@name='getToken' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getToken", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetToken_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GetToken (string p0, string p1)
		{
			const string __id = "getToken.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
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

	}
}
