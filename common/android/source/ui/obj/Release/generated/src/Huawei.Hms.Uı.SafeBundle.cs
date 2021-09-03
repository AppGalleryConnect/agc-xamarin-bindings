using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Uı {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeBundle']"
	[global::Android.Runtime.Register ("com/huawei/hms/ui/SafeBundle", DoNotGenerateAcw=true)]
	public partial class SafeBundle : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeBundle']/field[@name='a']"
		[Register ("a")]
		public global::Android.OS.Bundle A {
			get {
				const string __id = "a.Landroid/os/Bundle;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Landroid/os/Bundle;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/ui/SafeBundle", typeof (SafeBundle));
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

		protected SafeBundle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeBundle']/constructor[@name='SafeBundle' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SafeBundle ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeBundle']/constructor[@name='SafeBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register (".ctor", "(Landroid/os/Bundle;)V", "")]
		public unsafe SafeBundle (global::Android.OS.Bundle p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/os/Bundle;)V";

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

		static Delegate cb_getBundle;
#pragma warning disable 0169
		static Delegate GetGetBundleHandler ()
		{
			if (cb_getBundle == null)
				cb_getBundle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBundle);
			return cb_getBundle;
		}

		static IntPtr n_GetBundle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.SafeBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bundle);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Bundle Bundle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeBundle']/method[@name='getBundle' and count(parameter)=0]"
			[Register ("getBundle", "()Landroid/os/Bundle;", "GetGetBundleHandler")]
			get {
				const string __id = "getBundle.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.SafeBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeBundle']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_containsKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetContainsKey_Ljava_lang_String_Handler ()
		{
			if (cb_containsKey_Ljava_lang_String_ == null)
				cb_containsKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_ContainsKey_Ljava_lang_String_);
			return cb_containsKey_Ljava_lang_String_;
		}

		static bool n_ContainsKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.SafeBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeBundle']/method[@name='containsKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("containsKey", "(Ljava/lang/String;)Z", "GetContainsKey_Ljava_lang_String_Handler")]
		public virtual unsafe bool ContainsKey (string p0)
		{
			const string __id = "containsKey.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.SafeBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeBundle']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (string p0)
		{
			const string __id = "get.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getInt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_Handler ()
		{
			if (cb_getInt_Ljava_lang_String_ == null)
				cb_getInt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetInt_Ljava_lang_String_);
			return cb_getInt_Ljava_lang_String_;
		}

		static int n_GetInt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.SafeBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeBundle']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInt", "(Ljava/lang/String;)I", "GetGetInt_Ljava_lang_String_Handler")]
		public virtual unsafe int GetInt (string p0)
		{
			const string __id = "getInt.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetInt_Ljava_lang_String_IHandler ()
		{
			if (cb_getInt_Ljava_lang_String_I == null)
				cb_getInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_I) n_GetInt_Ljava_lang_String_I);
			return cb_getInt_Ljava_lang_String_I;
		}

		static int n_GetInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.SafeBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeBundle']/method[@name='getInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getInt", "(Ljava/lang/String;I)I", "GetGetInt_Ljava_lang_String_IHandler")]
		public virtual unsafe int GetInt (string p0, int p1)
		{
			const string __id = "getInt.(Ljava/lang/String;I)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.SafeBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeBundle']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		public virtual unsafe string GetString (string p0)
		{
			const string __id = "getString.(Ljava/lang/String;)Ljava/lang/String;";
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

		static Delegate cb_getString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_GetString_Ljava_lang_String_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.SafeBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeBundle']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe string GetString (string p0, string p1)
		{
			const string __id = "getString.(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;";
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

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.SafeBundle> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='SafeBundle']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
