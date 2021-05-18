using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Huawei.Hms.Aaid.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']"
	[global::Android.Runtime.Register ("com/huawei/hms/aaid/utils/PushPreferences", DoNotGenerateAcw=true)]
	public partial class PushPreferences : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/field[@name='a']"
		[Register ("a")]
		public global::Android.Content.ISharedPreferences A {
			get {
				const string __id = "a.Landroid/content/SharedPreferences;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Landroid/content/SharedPreferences;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/aaid/utils/PushPreferences", typeof (PushPreferences));
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

		protected PushPreferences (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/constructor[@name='PushPreferences' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Landroid/content/Context;Ljava/lang/String;)V", "")]
		public unsafe PushPreferences (global::Android.Content.Context p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getAll;
#pragma warning disable 0169
		static Delegate GetGetAllHandler ()
		{
			if (cb_getAll == null)
				cb_getAll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAll);
			return cb_getAll;
		}

		static IntPtr n_GetAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, object>.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IDictionary<string, object> All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/Map;", "GetGetAllHandler")]
			get {
				const string __id = "getAll.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<string, object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Clear);
			return cb_clear;
		}

		static bool n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()Z", "GetClearHandler")]
		public virtual unsafe bool Clear ()
		{
			const string __id = "clear.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ContainsKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='containsKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getBoolean_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_Handler ()
		{
			if (cb_getBoolean_Ljava_lang_String_ == null)
				cb_getBoolean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_GetBoolean_Ljava_lang_String_);
			return cb_getBoolean_Ljava_lang_String_;
		}

		static bool n_GetBoolean_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBoolean", "(Ljava/lang/String;)Z", "GetGetBoolean_Ljava_lang_String_Handler")]
		public virtual unsafe bool GetBoolean (string p0)
		{
			const string __id = "getBoolean.(Ljava/lang/String;)Z";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInt (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='getInt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getLong_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Handler ()
		{
			if (cb_getLong_Ljava_lang_String_ == null)
				cb_getLong_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_GetLong_Ljava_lang_String_);
			return cb_getLong_Ljava_lang_String_;
		}

		static long n_GetLong_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLong", "(Ljava/lang/String;)J", "GetGetLong_Ljava_lang_String_Handler")]
		public virtual unsafe long GetLong (string p0)
		{
			const string __id = "getLong.(Ljava/lang/String;)J";
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Read);
			return cb_read;
		}

		static IntPtr n_Read (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Read ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()Landroid/content/ContentValues;", "GetReadHandler")]
		public virtual unsafe global::Android.Content.ContentValues Read ()
		{
			const string __id = "read.()Landroid/content/ContentValues;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveKey_Ljava_lang_String_Handler ()
		{
			if (cb_removeKey_Ljava_lang_String_ == null)
				cb_removeKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveKey_Ljava_lang_String_);
			return cb_removeKey_Ljava_lang_String_;
		}

		static bool n_RemoveKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveKey (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='removeKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeKey", "(Ljava/lang/String;)Z", "GetRemoveKey_Ljava_lang_String_Handler")]
		public virtual unsafe bool RemoveKey (string p0)
		{
			const string __id = "removeKey.(Ljava/lang/String;)Z";
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

		static Delegate cb_removeKey_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveKey_arrayLjava_lang_String_Handler ()
		{
			if (cb_removeKey_arrayLjava_lang_String_ == null)
				cb_removeKey_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveKey_arrayLjava_lang_String_);
			return cb_removeKey_arrayLjava_lang_String_;
		}

		static bool n_RemoveKey_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			bool __ret = __this.RemoveKey (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='removeKey' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("removeKey", "([Ljava/lang/String;)Z", "GetRemoveKey_arrayLjava_lang_String_Handler")]
		public virtual unsafe bool RemoveKey (string[] p0)
		{
			const string __id = "removeKey.([Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_save_Ljava_lang_String_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSave_Ljava_lang_String_Ljava_lang_Object_Handler ()
		{
			if (cb_save_Ljava_lang_String_Ljava_lang_Object_ == null)
				cb_save_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_Save_Ljava_lang_String_Ljava_lang_Object_);
			return cb_save_Ljava_lang_String_Ljava_lang_Object_;
		}

		static bool n_Save_Ljava_lang_String_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Save (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='save' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object']]"
		[Register ("save", "(Ljava/lang/String;Ljava/lang/Object;)Z", "GetSave_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public virtual unsafe bool Save (string p0, global::Java.Lang.Object p1)
		{
			const string __id = "save.(Ljava/lang/String;Ljava/lang/Object;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_saveBoolean_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetSaveBoolean_Ljava_lang_String_ZHandler ()
		{
			if (cb_saveBoolean_Ljava_lang_String_Z == null)
				cb_saveBoolean_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_V) n_SaveBoolean_Ljava_lang_String_Z);
			return cb_saveBoolean_Ljava_lang_String_Z;
		}

		static void n_SaveBoolean_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveBoolean (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='saveBoolean' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("saveBoolean", "(Ljava/lang/String;Z)V", "GetSaveBoolean_Ljava_lang_String_ZHandler")]
		public virtual unsafe void SaveBoolean (string p0, bool p1)
		{
			const string __id = "saveBoolean.(Ljava/lang/String;Z)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_saveInt_Ljava_lang_String_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetSaveInt_Ljava_lang_String_Ljava_lang_Integer_Handler ()
		{
			if (cb_saveInt_Ljava_lang_String_Ljava_lang_Integer_ == null)
				cb_saveInt_Ljava_lang_String_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SaveInt_Ljava_lang_String_Ljava_lang_Integer_);
			return cb_saveInt_Ljava_lang_String_Ljava_lang_Integer_;
		}

		static void n_SaveInt_Ljava_lang_String_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SaveInt (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='saveInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("saveInt", "(Ljava/lang/String;Ljava/lang/Integer;)V", "GetSaveInt_Ljava_lang_String_Ljava_lang_Integer_Handler")]
		public virtual unsafe void SaveInt (string p0, global::Java.Lang.Integer p1)
		{
			const string __id = "saveInt.(Ljava/lang/String;Ljava/lang/Integer;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_saveLong_Ljava_lang_String_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSaveLong_Ljava_lang_String_Ljava_lang_Long_Handler ()
		{
			if (cb_saveLong_Ljava_lang_String_Ljava_lang_Long_ == null)
				cb_saveLong_Ljava_lang_String_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SaveLong_Ljava_lang_String_Ljava_lang_Long_);
			return cb_saveLong_Ljava_lang_String_Ljava_lang_Long_;
		}

		static void n_SaveLong_Ljava_lang_String_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SaveLong (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='saveLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long']]"
		[Register ("saveLong", "(Ljava/lang/String;Ljava/lang/Long;)V", "GetSaveLong_Ljava_lang_String_Ljava_lang_Long_Handler")]
		public virtual unsafe void SaveLong (string p0, global::Java.Lang.Long p1)
		{
			const string __id = "saveLong.(Ljava/lang/String;Ljava/lang/Long;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_saveMap_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSaveMap_Ljava_util_Map_Handler ()
		{
			if (cb_saveMap_Ljava_util_Map_ == null)
				cb_saveMap_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SaveMap_Ljava_util_Map_);
			return cb_saveMap_Ljava_util_Map_;
		}

		static void n_SaveMap_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveMap (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='saveMap' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("saveMap", "(Ljava/util/Map;)V", "GetSaveMap_Ljava_util_Map_Handler")]
		public virtual unsafe void SaveMap (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			const string __id = "saveMap.(Ljava/util/Map;)V";
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_saveString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_saveString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_saveString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_SaveString_Ljava_lang_String_Ljava_lang_String_);
			return cb_saveString_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_SaveString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SaveString (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='saveString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("saveString", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetSaveString_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool SaveString (string p0, string p1)
		{
			const string __id = "saveString.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_write_Landroid_content_ContentValues_;
#pragma warning disable 0169
		static Delegate GetWrite_Landroid_content_ContentValues_Handler ()
		{
			if (cb_write_Landroid_content_ContentValues_ == null)
				cb_write_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Write_Landroid_content_ContentValues_);
			return cb_write_Landroid_content_ContentValues_;
		}

		static bool n_Write_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Hms.Aaid.Utils.PushPreferences> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Write (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.utils']/class[@name='PushPreferences']/method[@name='write' and count(parameter)=1 and parameter[1][@type='android.content.ContentValues']]"
		[Register ("write", "(Landroid/content/ContentValues;)Z", "GetWrite_Landroid_content_ContentValues_Handler")]
		public virtual unsafe bool Write (global::Android.Content.ContentValues p0)
		{
			const string __id = "write.(Landroid/content/ContentValues;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
