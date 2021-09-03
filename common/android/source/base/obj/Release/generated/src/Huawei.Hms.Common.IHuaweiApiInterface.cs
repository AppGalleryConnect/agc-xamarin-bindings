using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.common']/interface[@name='HuaweiApiInterface']"
	[Register ("com/huawei/hms/common/HuaweiApiInterface", "", "Huawei.Hms.Common.IHuaweiApiInterfaceInvoker")]
	public partial interface IHuaweiApiInterface : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/interface[@name='HuaweiApiInterface']/method[@name='setInnerHms' and count(parameter)=0]"
		[Register ("setInnerHms", "()V", "GetSetInnerHmsHandler:Huawei.Hms.Common.IHuaweiApiInterfaceInvoker, Huawei.Hms.Base")]
		void SetInnerHms ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/interface[@name='HuaweiApiInterface']/method[@name='setSubAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSubAppId", "(Ljava/lang/String;)V", "GetSetSubAppId_Ljava_lang_String_Handler:Huawei.Hms.Common.IHuaweiApiInterfaceInvoker, Huawei.Hms.Base")]
		void SetSubAppId (string p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/HuaweiApiInterface", DoNotGenerateAcw=true)]
	internal partial class IHuaweiApiInterfaceInvoker : global::Java.Lang.Object, IHuaweiApiInterface {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/HuaweiApiInterface", typeof (IHuaweiApiInterfaceInvoker));

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

		public static IHuaweiApiInterface GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHuaweiApiInterface> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.common.HuaweiApiInterface"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHuaweiApiInterfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_setInnerHms;
#pragma warning disable 0169
		static Delegate GetSetInnerHmsHandler ()
		{
			if (cb_setInnerHms == null)
				cb_setInnerHms = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetInnerHms);
			return cb_setInnerHms;
		}

		static void n_SetInnerHms (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.IHuaweiApiInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInnerHms ();
		}
#pragma warning restore 0169

		IntPtr id_setInnerHms;
		public unsafe void SetInnerHms ()
		{
			if (id_setInnerHms == IntPtr.Zero)
				id_setInnerHms = JNIEnv.GetMethodID (class_ref, "setInnerHms", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInnerHms);
		}

		static Delegate cb_setSubAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSubAppId_Ljava_lang_String_Handler ()
		{
			if (cb_setSubAppId_Ljava_lang_String_ == null)
				cb_setSubAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSubAppId_Ljava_lang_String_);
			return cb_setSubAppId_Ljava_lang_String_;
		}

		static void n_SetSubAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.IHuaweiApiInterface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetSubAppId (p0);
		}
#pragma warning restore 0169

		IntPtr id_setSubAppId_Ljava_lang_String_;
		public unsafe void SetSubAppId (string p0)
		{
			if (id_setSubAppId_Ljava_lang_String_ == IntPtr.Zero)
				id_setSubAppId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSubAppId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSubAppId_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
