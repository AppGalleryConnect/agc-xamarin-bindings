using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Update.Ui {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']"
	[global::Android.Runtime.Register ("com/huawei/hms/update/ui/UpdateBean", DoNotGenerateAcw=true)]
	public partial class UpdateBean : global::Java.Lang.Object, global::Java.IO.ISerializable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/field[@name='e']"
		[Register ("e")]
		public string E {
			get {
				const string __id = "e.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "e.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/field[@name='f']"
		[Register ("f")]
		public global::System.Collections.IList F {
			get {
				const string __id = "f.Ljava/util/ArrayList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "f.Ljava/util/ArrayList;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/field[@name='g']"
		[Register ("g")]
		public bool G {
			get {
				const string __id = "g.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "g.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/update/ui/UpdateBean", typeof (UpdateBean));
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

		protected UpdateBean (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/constructor[@name='UpdateBean' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UpdateBean ()
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

		static Delegate cb_getClientAppName;
#pragma warning disable 0169
		static Delegate GetGetClientAppNameHandler ()
		{
			if (cb_getClientAppName == null)
				cb_getClientAppName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetClientAppName);
			return cb_getClientAppName;
		}

		static IntPtr n_GetClientAppName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ClientAppName);
		}
#pragma warning restore 0169

		static Delegate cb_setClientAppName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientAppName_Ljava_lang_String_Handler ()
		{
			if (cb_setClientAppName_Ljava_lang_String_ == null)
				cb_setClientAppName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientAppName_Ljava_lang_String_);
			return cb_setClientAppName_Ljava_lang_String_;
		}

		static void n_SetClientAppName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ClientAppName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ClientAppName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='getClientAppName' and count(parameter)=0]"
			[Register ("getClientAppName", "()Ljava/lang/String;", "GetGetClientAppNameHandler")]
			get {
				const string __id = "getClientAppName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='setClientAppName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setClientAppName", "(Ljava/lang/String;)V", "GetSetClientAppName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setClientAppName.(Ljava/lang/String;)V";
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

		static Delegate cb_isNeedConfirm;
#pragma warning disable 0169
		static Delegate GetIsNeedConfirmHandler ()
		{
			if (cb_isNeedConfirm == null)
				cb_isNeedConfirm = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNeedConfirm);
			return cb_isNeedConfirm;
		}

		static bool n_IsNeedConfirm (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedConfirm;
		}
#pragma warning restore 0169

		static Delegate cb_setNeedConfirm_Z;
#pragma warning disable 0169
		static Delegate GetSetNeedConfirm_ZHandler ()
		{
			if (cb_setNeedConfirm_Z == null)
				cb_setNeedConfirm_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetNeedConfirm_Z);
			return cb_setNeedConfirm_Z;
		}

		static void n_SetNeedConfirm_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NeedConfirm = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool NeedConfirm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='isNeedConfirm' and count(parameter)=0]"
			[Register ("isNeedConfirm", "()Z", "GetIsNeedConfirmHandler")]
			get {
				const string __id = "isNeedConfirm.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='setNeedConfirm' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setNeedConfirm", "(Z)V", "GetSetNeedConfirm_ZHandler")]
			set {
				const string __id = "setNeedConfirm.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTypeList;
#pragma warning disable 0169
		static Delegate GetGetTypeListHandler ()
		{
			if (cb_getTypeList == null)
				cb_getTypeList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTypeList);
			return cb_getTypeList;
		}

		static IntPtr n_GetTypeList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.TypeList);
		}
#pragma warning restore 0169

		static Delegate cb_setTypeList_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSetTypeList_Ljava_util_ArrayList_Handler ()
		{
			if (cb_setTypeList_Ljava_util_ArrayList_ == null)
				cb_setTypeList_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTypeList_Ljava_util_ArrayList_);
			return cb_setTypeList_Ljava_util_ArrayList_;
		}

		static void n_SetTypeList_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TypeList = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.IList TypeList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='getTypeList' and count(parameter)=0]"
			[Register ("getTypeList", "()Ljava/util/ArrayList;", "GetGetTypeListHandler")]
			get {
				const string __id = "getTypeList.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='setTypeList' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList']]"
			[Register ("setTypeList", "(Ljava/util/ArrayList;)V", "GetSetTypeList_Ljava_util_ArrayList_Handler")]
			set {
				const string __id = "setTypeList.(Ljava/util/ArrayList;)V";
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_A);
			return cb_a;
		}

		static IntPtr n_A (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.A ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Ljava/lang/String;", "GetAHandler")]
		public virtual unsafe string A ()
		{
			const string __id = "a.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='a' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("a", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object A (global::Java.Lang.Object p0)
		{
			const string __id = "a.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_b;
#pragma warning disable 0169
		static Delegate GetBHandler ()
		{
			if (cb_b == null)
				cb_b = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_B);
			return cb_b;
		}

		static IntPtr n_B (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.B ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()Ljava/lang/String;", "GetBHandler")]
		public virtual unsafe string B ()
		{
			const string __id = "b.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_C);
			return cb_c;
		}

		static int n_C (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.C ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()I", "GetCHandler")]
		public virtual unsafe int C ()
		{
			const string __id = "c.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_d;
#pragma warning disable 0169
		static Delegate GetDHandler ()
		{
			if (cb_d == null)
				cb_d = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_D);
			return cb_d;
		}

		static bool n_D (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.D ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='d' and count(parameter)=0]"
		[Register ("d", "()Z", "GetDHandler")]
		public virtual unsafe bool D ()
		{
			const string __id = "d.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setClientAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientAppId_Ljava_lang_String_Handler ()
		{
			if (cb_setClientAppId_Ljava_lang_String_ == null)
				cb_setClientAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientAppId_Ljava_lang_String_);
			return cb_setClientAppId_Ljava_lang_String_;
		}

		static void n_SetClientAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetClientAppId (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='setClientAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setClientAppId", "(Ljava/lang/String;)V", "GetSetClientAppId_Ljava_lang_String_Handler")]
		public virtual unsafe void SetClientAppId (string p0)
		{
			const string __id = "setClientAppId.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setClientPackageName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetClientPackageName_Ljava_lang_String_Handler ()
		{
			if (cb_setClientPackageName_Ljava_lang_String_ == null)
				cb_setClientPackageName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetClientPackageName_Ljava_lang_String_);
			return cb_setClientPackageName_Ljava_lang_String_;
		}

		static void n_SetClientPackageName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetClientPackageName (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='setClientPackageName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setClientPackageName", "(Ljava/lang/String;)V", "GetSetClientPackageName_Ljava_lang_String_Handler")]
		public virtual unsafe void SetClientPackageName (string p0)
		{
			const string __id = "setClientPackageName.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setClientVersionCode_I;
#pragma warning disable 0169
		static Delegate GetSetClientVersionCode_IHandler ()
		{
			if (cb_setClientVersionCode_I == null)
				cb_setClientVersionCode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetClientVersionCode_I);
			return cb_setClientVersionCode_I;
		}

		static void n_SetClientVersionCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetClientVersionCode (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='setClientVersionCode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setClientVersionCode", "(I)V", "GetSetClientVersionCode_IHandler")]
		public virtual unsafe void SetClientVersionCode (int p0)
		{
			const string __id = "setClientVersionCode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHmsOrApkUpgrade_Z;
#pragma warning disable 0169
		static Delegate GetSetHmsOrApkUpgrade_ZHandler ()
		{
			if (cb_setHmsOrApkUpgrade_Z == null)
				cb_setHmsOrApkUpgrade_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetHmsOrApkUpgrade_Z);
			return cb_setHmsOrApkUpgrade_Z;
		}

		static void n_SetHmsOrApkUpgrade_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Ui.UpdateBean> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHmsOrApkUpgrade (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.ui']/class[@name='UpdateBean']/method[@name='setHmsOrApkUpgrade' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHmsOrApkUpgrade", "(Z)V", "GetSetHmsOrApkUpgrade_ZHandler")]
		public virtual unsafe void SetHmsOrApkUpgrade (bool p0)
		{
			const string __id = "setHmsOrApkUpgrade.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
