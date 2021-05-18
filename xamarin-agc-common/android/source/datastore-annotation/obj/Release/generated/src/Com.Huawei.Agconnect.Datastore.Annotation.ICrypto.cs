using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Huawei.Agconnect.Datastore.Annotation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.agconnect.datastore.annotation']/interface[@name='ICrypto']"
	[Register ("com/huawei/agconnect/datastore/annotation/ICrypto", "", "Com.Huawei.Agconnect.Datastore.Annotation.ICryptoInvoker")]
	public partial interface ICrypto : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.annotation']/interface[@name='ICrypto']/method[@name='decrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("decrypt", "(Ljava/lang/String;)Ljava/lang/String;", "GetDecrypt_Ljava_lang_String_Handler:Com.Huawei.Agconnect.Datastore.Annotation.ICryptoInvoker, Huawei.Agconnect.DatastoreAnnotation")]
		string Decrypt (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.annotation']/interface[@name='ICrypto']/method[@name='encrypt' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("encrypt", "(Ljava/lang/String;)Ljava/lang/String;", "GetEncrypt_Ljava_lang_String_Handler:Com.Huawei.Agconnect.Datastore.Annotation.ICryptoInvoker, Huawei.Agconnect.DatastoreAnnotation")]
		string Encrypt (string p0);

	}

	[global::Android.Runtime.Register ("com/huawei/agconnect/datastore/annotation/ICrypto", DoNotGenerateAcw=true)]
	internal partial class ICryptoInvoker : global::Java.Lang.Object, ICrypto {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/datastore/annotation/ICrypto", typeof (ICryptoInvoker));

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

		public static ICrypto GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICrypto> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.agconnect.datastore.annotation.ICrypto"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICryptoInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_decrypt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDecrypt_Ljava_lang_String_Handler ()
		{
			if (cb_decrypt_Ljava_lang_String_ == null)
				cb_decrypt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Decrypt_Ljava_lang_String_);
			return cb_decrypt_Ljava_lang_String_;
		}

		static IntPtr n_Decrypt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Datastore.Annotation.ICrypto> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Decrypt (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decrypt_Ljava_lang_String_;
		public unsafe string Decrypt (string p0)
		{
			if (id_decrypt_Ljava_lang_String_ == IntPtr.Zero)
				id_decrypt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "decrypt", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_decrypt_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_encrypt_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEncrypt_Ljava_lang_String_Handler ()
		{
			if (cb_encrypt_Ljava_lang_String_ == null)
				cb_encrypt_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Encrypt_Ljava_lang_String_);
			return cb_encrypt_Ljava_lang_String_;
		}

		static IntPtr n_Encrypt_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Datastore.Annotation.ICrypto> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encrypt (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_encrypt_Ljava_lang_String_;
		public unsafe string Encrypt (string p0)
		{
			if (id_encrypt_Ljava_lang_String_ == IntPtr.Zero)
				id_encrypt_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "encrypt", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encrypt_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
