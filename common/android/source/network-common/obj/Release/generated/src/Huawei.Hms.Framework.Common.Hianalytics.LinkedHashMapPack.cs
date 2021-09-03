using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common.Hianalytics {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='LinkedHashMapPack']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/hianalytics/LinkedHashMapPack", DoNotGenerateAcw=true)]
	public partial class LinkedHashMapPack : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/hianalytics/LinkedHashMapPack", typeof (LinkedHashMapPack));
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

		protected LinkedHashMapPack (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='LinkedHashMapPack']/constructor[@name='LinkedHashMapPack' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LinkedHashMapPack ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.LinkedHashMapPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.All);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.LinkedHashMap All {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='LinkedHashMapPack']/method[@name='getAll' and count(parameter)=0]"
			[Register ("getAll", "()Ljava/util/LinkedHashMap;", "GetGetAllHandler")]
			get {
				const string __id = "getAll.()Ljava/util/LinkedHashMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.LinkedHashMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_put_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_ZHandler ()
		{
			if (cb_put_Ljava_lang_String_Z == null)
				cb_put_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_Put_Ljava_lang_String_Z);
			return cb_put_Ljava_lang_String_Z;
		}

		static IntPtr n_Put_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.LinkedHashMapPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='LinkedHashMapPack']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("put", "(Ljava/lang/String;Z)Lcom/huawei/hms/framework/common/hianalytics/LinkedHashMapPack;", "GetPut_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Huawei.Hms.Framework.Common.Hianalytics.LinkedHashMapPack Put (string p0, bool p1)
		{
			const string __id = "put.(Ljava/lang/String;Z)Lcom/huawei/hms/framework/common/hianalytics/LinkedHashMapPack;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.LinkedHashMapPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_Put_Ljava_lang_String_Ljava_lang_String_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_Put_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.LinkedHashMapPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='LinkedHashMapPack']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;)Lcom/huawei/hms/framework/common/hianalytics/LinkedHashMapPack;", "GetPut_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe global::Huawei.Hms.Framework.Common.Hianalytics.LinkedHashMapPack Put (string p0, string p1)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/String;)Lcom/huawei/hms/framework/common/hianalytics/LinkedHashMapPack;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.LinkedHashMapPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_put_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_JHandler ()
		{
			if (cb_put_Ljava_lang_String_J == null)
				cb_put_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_L) n_Put_Ljava_lang_String_J);
			return cb_put_Ljava_lang_String_J;
		}

		static IntPtr n_Put_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.LinkedHashMapPack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Put (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common.hianalytics']/class[@name='LinkedHashMapPack']/method[@name='put' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("put", "(Ljava/lang/String;J)Lcom/huawei/hms/framework/common/hianalytics/LinkedHashMapPack;", "GetPut_Ljava_lang_String_JHandler")]
		public virtual unsafe global::Huawei.Hms.Framework.Common.Hianalytics.LinkedHashMapPack Put (string p0, long p1)
		{
			const string __id = "put.(Ljava/lang/String;J)Lcom/huawei/hms/framework/common/hianalytics/LinkedHashMapPack;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.Hianalytics.LinkedHashMapPack> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
