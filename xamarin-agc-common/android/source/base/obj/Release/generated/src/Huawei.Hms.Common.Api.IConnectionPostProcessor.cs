using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.common.api']/interface[@name='ConnectionPostProcessor']"
	[Register ("com/huawei/hms/common/api/ConnectionPostProcessor", "", "Huawei.Hms.Common.Api.IConnectionPostProcessorInvoker")]
	public partial interface IConnectionPostProcessor : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.api']/interface[@name='ConnectionPostProcessor']/method[@name='run' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient'] and parameter[2][@type='java.lang.ref.WeakReference&lt;android.app.Activity&gt;']]"
		[Register ("run", "(Lcom/huawei/hms/api/HuaweiApiClient;Ljava/lang/ref/WeakReference;)V", "GetRun_Lcom_huawei_hms_api_HuaweiApiClient_Ljava_lang_ref_WeakReference_Handler:Huawei.Hms.Common.Api.IConnectionPostProcessorInvoker, Huawei.Hms.Base")]
		void Run (global::Huawei.Hms.Api.HuaweiApiClient p0, global::Java.Lang.Ref.WeakReference p1);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/api/ConnectionPostProcessor", DoNotGenerateAcw=true)]
	internal partial class IConnectionPostProcessorInvoker : global::Java.Lang.Object, IConnectionPostProcessor {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/api/ConnectionPostProcessor", typeof (IConnectionPostProcessorInvoker));

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

		public static IConnectionPostProcessor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectionPostProcessor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.common.api.ConnectionPostProcessor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectionPostProcessorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_run_Lcom_huawei_hms_api_HuaweiApiClient_Ljava_lang_ref_WeakReference_;
#pragma warning disable 0169
		static Delegate GetRun_Lcom_huawei_hms_api_HuaweiApiClient_Ljava_lang_ref_WeakReference_Handler ()
		{
			if (cb_run_Lcom_huawei_hms_api_HuaweiApiClient_Ljava_lang_ref_WeakReference_ == null)
				cb_run_Lcom_huawei_hms_api_HuaweiApiClient_Ljava_lang_ref_WeakReference_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Run_Lcom_huawei_hms_api_HuaweiApiClient_Ljava_lang_ref_WeakReference_);
			return cb_run_Lcom_huawei_hms_api_HuaweiApiClient_Ljava_lang_ref_WeakReference_;
		}

		static void n_Run_Lcom_huawei_hms_api_HuaweiApiClient_Ljava_lang_ref_WeakReference_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Api.IConnectionPostProcessor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Ref.WeakReference> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Run (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_run_Lcom_huawei_hms_api_HuaweiApiClient_Ljava_lang_ref_WeakReference_;
		public unsafe void Run (global::Huawei.Hms.Api.HuaweiApiClient p0, global::Java.Lang.Ref.WeakReference p1)
		{
			if (id_run_Lcom_huawei_hms_api_HuaweiApiClient_Ljava_lang_ref_WeakReference_ == IntPtr.Zero)
				id_run_Lcom_huawei_hms_api_HuaweiApiClient_Ljava_lang_ref_WeakReference_ = JNIEnv.GetMethodID (class_ref, "run", "(Lcom/huawei/hms/api/HuaweiApiClient;Ljava/lang/ref/WeakReference;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run_Lcom_huawei_hms_api_HuaweiApiClient_Ljava_lang_ref_WeakReference_, __args);
		}

	}

}
