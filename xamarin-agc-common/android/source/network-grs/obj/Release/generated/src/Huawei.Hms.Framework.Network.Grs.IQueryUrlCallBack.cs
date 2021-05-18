using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Network.Grs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/interface[@name='IQueryUrlCallBack']"
	[Register ("com/huawei/hms/framework/network/grs/IQueryUrlCallBack", "", "Huawei.Hms.Framework.Network.Grs.IQueryUrlCallBackInvoker")]
	public partial interface IQueryUrlCallBack : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/interface[@name='IQueryUrlCallBack']/method[@name='onCallBackFail' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onCallBackFail", "(I)V", "GetOnCallBackFail_IHandler:Huawei.Hms.Framework.Network.Grs.IQueryUrlCallBackInvoker, Huawei.Hms.NetworkGrs")]
		void OnCallBackFail (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/interface[@name='IQueryUrlCallBack']/method[@name='onCallBackSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onCallBackSuccess", "(Ljava/lang/String;)V", "GetOnCallBackSuccess_Ljava_lang_String_Handler:Huawei.Hms.Framework.Network.Grs.IQueryUrlCallBackInvoker, Huawei.Hms.NetworkGrs")]
		void OnCallBackSuccess (string p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/framework/network/grs/IQueryUrlCallBack", DoNotGenerateAcw=true)]
	internal partial class IQueryUrlCallBackInvoker : global::Java.Lang.Object, IQueryUrlCallBack {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/network/grs/IQueryUrlCallBack", typeof (IQueryUrlCallBackInvoker));

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

		public static IQueryUrlCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQueryUrlCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.framework.network.grs.IQueryUrlCallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQueryUrlCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCallBackFail_I;
#pragma warning disable 0169
		static Delegate GetOnCallBackFail_IHandler ()
		{
			if (cb_onCallBackFail_I == null)
				cb_onCallBackFail_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnCallBackFail_I);
			return cb_onCallBackFail_I;
		}

		static void n_OnCallBackFail_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.IQueryUrlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCallBackFail (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCallBackFail_I;
		public unsafe void OnCallBackFail (int p0)
		{
			if (id_onCallBackFail_I == IntPtr.Zero)
				id_onCallBackFail_I = JNIEnv.GetMethodID (class_ref, "onCallBackFail", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCallBackFail_I, __args);
		}

		static Delegate cb_onCallBackSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnCallBackSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onCallBackSuccess_Ljava_lang_String_ == null)
				cb_onCallBackSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCallBackSuccess_Ljava_lang_String_);
			return cb_onCallBackSuccess_Ljava_lang_String_;
		}

		static void n_OnCallBackSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.IQueryUrlCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCallBackSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCallBackSuccess_Ljava_lang_String_;
		public unsafe void OnCallBackSuccess (string p0)
		{
			if (id_onCallBackSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onCallBackSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onCallBackSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCallBackSuccess_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
