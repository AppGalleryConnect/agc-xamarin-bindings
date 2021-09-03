using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Updatesdk.Service.Otaupdate {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='CheckUpdateCallBack']"
	[Register ("com/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack", "", "Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBackInvoker")]
	public partial interface ICheckUpdateCallBack : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='CheckUpdateCallBack']/method[@name='onMarketInstallInfo' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onMarketInstallInfo", "(Landroid/content/Intent;)V", "GetOnMarketInstallInfo_Landroid_content_Intent_Handler:Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBackInvoker, Huawei.Hms.Update")]
		void OnMarketInstallInfo (global::Android.Content.Intent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='CheckUpdateCallBack']/method[@name='onMarketStoreError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onMarketStoreError", "(I)V", "GetOnMarketStoreError_IHandler:Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBackInvoker, Huawei.Hms.Update")]
		void OnMarketStoreError (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='CheckUpdateCallBack']/method[@name='onUpdateInfo' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("onUpdateInfo", "(Landroid/content/Intent;)V", "GetOnUpdateInfo_Landroid_content_Intent_Handler:Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBackInvoker, Huawei.Hms.Update")]
		void OnUpdateInfo (global::Android.Content.Intent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/interface[@name='CheckUpdateCallBack']/method[@name='onUpdateStoreError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onUpdateStoreError", "(I)V", "GetOnUpdateStoreError_IHandler:Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBackInvoker, Huawei.Hms.Update")]
		void OnUpdateStoreError (int p0);

	}

	[global::Android.Runtime.Register ("com/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack", DoNotGenerateAcw=true)]
	internal partial class ICheckUpdateCallBackInvoker : global::Java.Lang.Object, ICheckUpdateCallBack {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/updatesdk/service/otaupdate/CheckUpdateCallBack", typeof (ICheckUpdateCallBackInvoker));

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

		public static ICheckUpdateCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICheckUpdateCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.updatesdk.service.otaupdate.CheckUpdateCallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICheckUpdateCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMarketInstallInfo_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnMarketInstallInfo_Landroid_content_Intent_Handler ()
		{
			if (cb_onMarketInstallInfo_Landroid_content_Intent_ == null)
				cb_onMarketInstallInfo_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnMarketInstallInfo_Landroid_content_Intent_);
			return cb_onMarketInstallInfo_Landroid_content_Intent_;
		}

		static void n_OnMarketInstallInfo_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMarketInstallInfo (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMarketInstallInfo_Landroid_content_Intent_;
		public unsafe void OnMarketInstallInfo (global::Android.Content.Intent p0)
		{
			if (id_onMarketInstallInfo_Landroid_content_Intent_ == IntPtr.Zero)
				id_onMarketInstallInfo_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onMarketInstallInfo", "(Landroid/content/Intent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMarketInstallInfo_Landroid_content_Intent_, __args);
		}

		static Delegate cb_onMarketStoreError_I;
#pragma warning disable 0169
		static Delegate GetOnMarketStoreError_IHandler ()
		{
			if (cb_onMarketStoreError_I == null)
				cb_onMarketStoreError_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnMarketStoreError_I);
			return cb_onMarketStoreError_I;
		}

		static void n_OnMarketStoreError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnMarketStoreError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMarketStoreError_I;
		public unsafe void OnMarketStoreError (int p0)
		{
			if (id_onMarketStoreError_I == IntPtr.Zero)
				id_onMarketStoreError_I = JNIEnv.GetMethodID (class_ref, "onMarketStoreError", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMarketStoreError_I, __args);
		}

		static Delegate cb_onUpdateInfo_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnUpdateInfo_Landroid_content_Intent_Handler ()
		{
			if (cb_onUpdateInfo_Landroid_content_Intent_ == null)
				cb_onUpdateInfo_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnUpdateInfo_Landroid_content_Intent_);
			return cb_onUpdateInfo_Landroid_content_Intent_;
		}

		static void n_OnUpdateInfo_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateInfo (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUpdateInfo_Landroid_content_Intent_;
		public unsafe void OnUpdateInfo (global::Android.Content.Intent p0)
		{
			if (id_onUpdateInfo_Landroid_content_Intent_ == IntPtr.Zero)
				id_onUpdateInfo_Landroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onUpdateInfo", "(Landroid/content/Intent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateInfo_Landroid_content_Intent_, __args);
		}

		static Delegate cb_onUpdateStoreError_I;
#pragma warning disable 0169
		static Delegate GetOnUpdateStoreError_IHandler ()
		{
			if (cb_onUpdateStoreError_I == null)
				cb_onUpdateStoreError_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnUpdateStoreError_I);
			return cb_onUpdateStoreError_I;
		}

		static void n_OnUpdateStoreError_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.ICheckUpdateCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateStoreError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onUpdateStoreError_I;
		public unsafe void OnUpdateStoreError (int p0)
		{
			if (id_onUpdateStoreError_I == IntPtr.Zero)
				id_onUpdateStoreError_I = JNIEnv.GetMethodID (class_ref, "onUpdateStoreError", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdateStoreError_I, __args);
		}

	}

}
