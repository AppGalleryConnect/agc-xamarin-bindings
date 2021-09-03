using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Huawei.Agconnect.Datastore.Annotation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.datastore.annotation']/class[@name='DefaultCrypto']"
	[global::Android.Runtime.Register ("com/huawei/agconnect/datastore/annotation/DefaultCrypto", DoNotGenerateAcw=true)]
	public partial class DefaultCrypto : global::Java.Lang.Object, global::Com.Huawei.Agconnect.Datastore.Annotation.ICrypto {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/datastore/annotation/DefaultCrypto", typeof (DefaultCrypto));
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

		protected DefaultCrypto (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.agconnect.datastore.annotation']/class[@name='DefaultCrypto']/constructor[@name='DefaultCrypto' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultCrypto ()
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

		static Delegate cb_decrypt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecrypt_Ljava_lang_String_Handler ()
		{
			if (cb_decrypt_Ljava_lang_String_ == null)
				cb_decrypt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Decrypt_Ljava_lang_String_);
			return cb_decrypt_Ljava_lang_String_;
		}

		static IntPtr n_Decrypt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cipher)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Datastore.Annotation.DefaultCrypto> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cipher = JNIEnv.GetString (native_cipher, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Decrypt (cipher));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.annotation']/class[@name='DefaultCrypto']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decrypt", "(Ljava/lang/String;)Ljava/lang/String;", "GetDecrypt_Ljava_lang_String_Handler")]
		public virtual unsafe string Decrypt (string cipher)
		{
			const string __id = "decrypt.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_cipher = JNIEnv.NewString (cipher);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_cipher);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_cipher);
			}
		}

		static Delegate cb_encrypt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncrypt_Ljava_lang_String_Handler ()
		{
			if (cb_encrypt_Ljava_lang_String_ == null)
				cb_encrypt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Encrypt_Ljava_lang_String_);
			return cb_encrypt_Ljava_lang_String_;
		}

		static IntPtr n_Encrypt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_plain)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Datastore.Annotation.DefaultCrypto> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var plain = JNIEnv.GetString (native_plain, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encrypt (plain));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.annotation']/class[@name='DefaultCrypto']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encrypt", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncrypt_Ljava_lang_String_Handler")]
		public virtual unsafe string Encrypt (string plain)
		{
			const string __id = "encrypt.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_plain = JNIEnv.NewString (plain);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_plain);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_plain);
			}
		}

	}
}
