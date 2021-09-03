using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Api {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.common.api']/interface[@name='HuaweiApiCallable']"
	[Register ("com/huawei/hms/common/api/HuaweiApiCallable", "", "Huawei.Hms.Common.Api.IHuaweiApiCallableInvoker")]
	public partial interface IHuaweiApiCallable : IJavaObject, IJavaPeerable {

		global::Huawei.Hms.Common.HuaweiApi HuaweiApi {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.api']/interface[@name='HuaweiApiCallable']/method[@name='getHuaweiApi' and count(parameter)=0]"
			[Register ("getHuaweiApi", "()Lcom/huawei/hms/common/HuaweiApi;", "GetGetHuaweiApiHandler:Huawei.Hms.Common.Api.IHuaweiApiCallableInvoker, Huawei.Hms.Base")] get;
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/api/HuaweiApiCallable", DoNotGenerateAcw=true)]
	internal partial class IHuaweiApiCallableInvoker : global::Java.Lang.Object, IHuaweiApiCallable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/api/HuaweiApiCallable", typeof (IHuaweiApiCallableInvoker));

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

		public static IHuaweiApiCallable GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHuaweiApiCallable> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.common.api.HuaweiApiCallable"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHuaweiApiCallableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getHuaweiApi;
#pragma warning disable 0169
		static Delegate GetGetHuaweiApiHandler ()
		{
			if (cb_getHuaweiApi == null)
				cb_getHuaweiApi = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHuaweiApi);
			return cb_getHuaweiApi;
		}

		static IntPtr n_GetHuaweiApi (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Api.IHuaweiApiCallable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HuaweiApi);
		}
#pragma warning restore 0169

		IntPtr id_getHuaweiApi;
		public unsafe global::Huawei.Hms.Common.HuaweiApi HuaweiApi {
			get {
				if (id_getHuaweiApi == IntPtr.Zero)
					id_getHuaweiApi = JNIEnv.GetMethodID (class_ref, "getHuaweiApi", "()Lcom/huawei/hms/common/HuaweiApi;");
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.HuaweiApi> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHuaweiApi), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
