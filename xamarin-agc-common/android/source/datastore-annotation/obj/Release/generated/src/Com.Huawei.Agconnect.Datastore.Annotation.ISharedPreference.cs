using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Huawei.Agconnect.Datastore.Annotation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.agconnect.datastore.annotation']/interface[@name='SharedPreference']"
	[Register ("com/huawei/agconnect/datastore/annotation/SharedPreference", "", "Com.Huawei.Agconnect.Datastore.Annotation.ISharedPreferenceInvoker")]
	public partial interface ISharedPreference : global::Java.Lang.Annotation.IAnnotation {

		bool IsDynamic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.annotation']/interface[@name='SharedPreference']/method[@name='isDynamic' and count(parameter)=0]"
			[Register ("isDynamic", "()Z", "GetIsDynamicHandler:Com.Huawei.Agconnect.Datastore.Annotation.ISharedPreferenceInvoker, Huawei.Agconnect.DatastoreAnnotation")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.annotation']/interface[@name='SharedPreference']/method[@name='crypto' and count(parameter)=0]"
		[Register ("crypto", "()Ljava/lang/Class;", "GetCryptoHandler:Com.Huawei.Agconnect.Datastore.Annotation.ISharedPreferenceInvoker, Huawei.Agconnect.DatastoreAnnotation")]
		global::Java.Lang.Class Crypto ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.annotation']/interface[@name='SharedPreference']/method[@name='fileName' and count(parameter)=0]"
		[Register ("fileName", "()Ljava/lang/String;", "GetFileNameHandler:Com.Huawei.Agconnect.Datastore.Annotation.ISharedPreferenceInvoker, Huawei.Agconnect.DatastoreAnnotation")]
		string FileName ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.annotation']/interface[@name='SharedPreference']/method[@name='key' and count(parameter)=0]"
		[Register ("key", "()Ljava/lang/String;", "GetKeyHandler:Com.Huawei.Agconnect.Datastore.Annotation.ISharedPreferenceInvoker, Huawei.Agconnect.DatastoreAnnotation")]
		string Key ();

	}

	[global::Android.Runtime.Register ("com/huawei/agconnect/datastore/annotation/SharedPreference", DoNotGenerateAcw=true)]
	internal partial class ISharedPreferenceInvoker : global::Java.Lang.Object, ISharedPreference {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/datastore/annotation/SharedPreference", typeof (ISharedPreferenceInvoker));

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

		public static ISharedPreference GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISharedPreference> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.agconnect.datastore.annotation.SharedPreference"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISharedPreferenceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_isDynamic;
#pragma warning disable 0169
		static Delegate GetIsDynamicHandler ()
		{
			if (cb_isDynamic == null)
				cb_isDynamic = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDynamic);
			return cb_isDynamic;
		}

		static bool n_IsDynamic (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Datastore.Annotation.ISharedPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDynamic;
		}
#pragma warning restore 0169

		IntPtr id_isDynamic;
		public unsafe bool IsDynamic {
			get {
				if (id_isDynamic == IntPtr.Zero)
					id_isDynamic = JNIEnv.GetMethodID (class_ref, "isDynamic", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDynamic);
			}
		}

		static Delegate cb_crypto;
#pragma warning disable 0169
		static Delegate GetCryptoHandler ()
		{
			if (cb_crypto == null)
				cb_crypto = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Crypto);
			return cb_crypto;
		}

		static IntPtr n_Crypto (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Datastore.Annotation.ISharedPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Crypto ());
		}
#pragma warning restore 0169

		IntPtr id_crypto;
		public unsafe global::Java.Lang.Class Crypto ()
		{
			if (id_crypto == IntPtr.Zero)
				id_crypto = JNIEnv.GetMethodID (class_ref, "crypto", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_crypto), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_fileName;
#pragma warning disable 0169
		static Delegate GetFileNameHandler ()
		{
			if (cb_fileName == null)
				cb_fileName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_FileName);
			return cb_fileName;
		}

		static IntPtr n_FileName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Datastore.Annotation.ISharedPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FileName ());
		}
#pragma warning restore 0169

		IntPtr id_fileName;
		public unsafe string FileName ()
		{
			if (id_fileName == IntPtr.Zero)
				id_fileName = JNIEnv.GetMethodID (class_ref, "fileName", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fileName), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_key;
#pragma warning disable 0169
		static Delegate GetKeyHandler ()
		{
			if (cb_key == null)
				cb_key = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Key);
			return cb_key;
		}

		static IntPtr n_Key (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Datastore.Annotation.ISharedPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Key ());
		}
#pragma warning restore 0169

		IntPtr id_key;
		public unsafe string Key ()
		{
			if (id_key == IntPtr.Zero)
				id_key = JNIEnv.GetMethodID (class_ref, "key", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_key), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Datastore.Annotation.ISharedPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Datastore.Annotation.ISharedPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Datastore.Annotation.ISharedPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Datastore.Annotation.ISharedPreference> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
