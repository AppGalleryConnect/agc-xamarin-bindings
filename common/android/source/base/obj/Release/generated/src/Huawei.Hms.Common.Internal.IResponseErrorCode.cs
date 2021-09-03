using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='ResponseErrorCode']"
	[Register ("com/huawei/hms/common/internal/ResponseErrorCode", "", "Huawei.Hms.Common.Internal.IResponseErrorCodeInvoker")]
	public partial interface IResponseErrorCode : IJavaObject, IJavaPeerable {

		int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='ResponseErrorCode']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "GetGetErrorCodeHandler:Huawei.Hms.Common.Internal.IResponseErrorCodeInvoker, Huawei.Hms.Base")] get;
		}

		string ErrorReason {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='ResponseErrorCode']/method[@name='getErrorReason' and count(parameter)=0]"
			[Register ("getErrorReason", "()Ljava/lang/String;", "GetGetErrorReasonHandler:Huawei.Hms.Common.Internal.IResponseErrorCodeInvoker, Huawei.Hms.Base")] get;
		}

		global::Android.OS.IParcelable Parcelable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='ResponseErrorCode']/method[@name='getParcelable' and count(parameter)=0]"
			[Register ("getParcelable", "()Landroid/os/Parcelable;", "GetGetParcelableHandler:Huawei.Hms.Common.Internal.IResponseErrorCodeInvoker, Huawei.Hms.Base")] get;
		}

		string Resolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='ResponseErrorCode']/method[@name='getResolution' and count(parameter)=0]"
			[Register ("getResolution", "()Ljava/lang/String;", "GetGetResolutionHandler:Huawei.Hms.Common.Internal.IResponseErrorCodeInvoker, Huawei.Hms.Base")] get;
		}

		int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='ResponseErrorCode']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "GetGetStatusCodeHandler:Huawei.Hms.Common.Internal.IResponseErrorCodeInvoker, Huawei.Hms.Base")] get;
		}

		string TransactionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/interface[@name='ResponseErrorCode']/method[@name='getTransactionId' and count(parameter)=0]"
			[Register ("getTransactionId", "()Ljava/lang/String;", "GetGetTransactionIdHandler:Huawei.Hms.Common.Internal.IResponseErrorCodeInvoker, Huawei.Hms.Base")] get;
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/ResponseErrorCode", DoNotGenerateAcw=true)]
	internal partial class IResponseErrorCodeInvoker : global::Java.Lang.Object, IResponseErrorCode {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/ResponseErrorCode", typeof (IResponseErrorCodeInvoker));

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

		public static IResponseErrorCode GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IResponseErrorCode> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.common.internal.ResponseErrorCode"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IResponseErrorCodeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getErrorCode;
#pragma warning disable 0169
		static Delegate GetGetErrorCodeHandler ()
		{
			if (cb_getErrorCode == null)
				cb_getErrorCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetErrorCode);
			return cb_getErrorCode;
		}

		static int n_GetErrorCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IResponseErrorCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorCode;
		}
#pragma warning restore 0169

		IntPtr id_getErrorCode;
		public unsafe int ErrorCode {
			get {
				if (id_getErrorCode == IntPtr.Zero)
					id_getErrorCode = JNIEnv.GetMethodID (class_ref, "getErrorCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getErrorCode);
			}
		}

		static Delegate cb_getErrorReason;
#pragma warning disable 0169
		static Delegate GetGetErrorReasonHandler ()
		{
			if (cb_getErrorReason == null)
				cb_getErrorReason = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetErrorReason);
			return cb_getErrorReason;
		}

		static IntPtr n_GetErrorReason (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IResponseErrorCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ErrorReason);
		}
#pragma warning restore 0169

		IntPtr id_getErrorReason;
		public unsafe string ErrorReason {
			get {
				if (id_getErrorReason == IntPtr.Zero)
					id_getErrorReason = JNIEnv.GetMethodID (class_ref, "getErrorReason", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorReason), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getParcelable;
#pragma warning disable 0169
		static Delegate GetGetParcelableHandler ()
		{
			if (cb_getParcelable == null)
				cb_getParcelable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParcelable);
			return cb_getParcelable;
		}

		static IntPtr n_GetParcelable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IResponseErrorCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Parcelable);
		}
#pragma warning restore 0169

		IntPtr id_getParcelable;
		public unsafe global::Android.OS.IParcelable Parcelable {
			get {
				if (id_getParcelable == IntPtr.Zero)
					id_getParcelable = JNIEnv.GetMethodID (class_ref, "getParcelable", "()Landroid/os/Parcelable;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getParcelable), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getResolution;
#pragma warning disable 0169
		static Delegate GetGetResolutionHandler ()
		{
			if (cb_getResolution == null)
				cb_getResolution = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetResolution);
			return cb_getResolution;
		}

		static IntPtr n_GetResolution (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IResponseErrorCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Resolution);
		}
#pragma warning restore 0169

		IntPtr id_getResolution;
		public unsafe string Resolution {
			get {
				if (id_getResolution == IntPtr.Zero)
					id_getResolution = JNIEnv.GetMethodID (class_ref, "getResolution", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getResolution), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getStatusCode;
#pragma warning disable 0169
		static Delegate GetGetStatusCodeHandler ()
		{
			if (cb_getStatusCode == null)
				cb_getStatusCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStatusCode);
			return cb_getStatusCode;
		}

		static int n_GetStatusCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IResponseErrorCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatusCode;
		}
#pragma warning restore 0169

		IntPtr id_getStatusCode;
		public unsafe int StatusCode {
			get {
				if (id_getStatusCode == IntPtr.Zero)
					id_getStatusCode = JNIEnv.GetMethodID (class_ref, "getStatusCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getStatusCode);
			}
		}

		static Delegate cb_getTransactionId;
#pragma warning disable 0169
		static Delegate GetGetTransactionIdHandler ()
		{
			if (cb_getTransactionId == null)
				cb_getTransactionId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTransactionId);
			return cb_getTransactionId;
		}

		static IntPtr n_GetTransactionId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.IResponseErrorCode> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransactionId);
		}
#pragma warning restore 0169

		IntPtr id_getTransactionId;
		public unsafe string TransactionId {
			get {
				if (id_getTransactionId == IntPtr.Zero)
					id_getTransactionId = JNIEnv.GetMethodID (class_ref, "getTransactionId", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransactionId), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
