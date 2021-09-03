using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Adapter.Sysobs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/interface[@name='SystemNotifier']"
	[Register ("com/huawei/hms/adapter/sysobs/SystemNotifier", "", "Huawei.Hms.Adapter.Sysobs.ISystemNotifierInvoker")]
	public partial interface ISystemNotifier : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/interface[@name='SystemNotifier']/method[@name='notifyObservers' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String']]"
		[Register ("notifyObservers", "(Landroid/content/Intent;Ljava/lang/String;)V", "GetNotifyObservers_Landroid_content_Intent_Ljava_lang_String_Handler:Huawei.Hms.Adapter.Sysobs.ISystemNotifierInvoker, Huawei.Hms.Availableupdate")]
		void NotifyObservers (global::Android.Content.Intent p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/interface[@name='SystemNotifier']/method[@name='notifyObservers' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("notifyObservers", "(I)V", "GetNotifyObservers_IHandler:Huawei.Hms.Adapter.Sysobs.ISystemNotifierInvoker, Huawei.Hms.Availableupdate")]
		void NotifyObservers (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/interface[@name='SystemNotifier']/method[@name='registerObserver' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.adapter.sysobs.SystemObserver']]"
		[Register ("registerObserver", "(Lcom/huawei/hms/adapter/sysobs/SystemObserver;)V", "GetRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_Handler:Huawei.Hms.Adapter.Sysobs.ISystemNotifierInvoker, Huawei.Hms.Availableupdate")]
		void RegisterObserver (global::Huawei.Hms.Adapter.Sysobs.ISystemObserver p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter.sysobs']/interface[@name='SystemNotifier']/method[@name='unRegisterObserver' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.adapter.sysobs.SystemObserver']]"
		[Register ("unRegisterObserver", "(Lcom/huawei/hms/adapter/sysobs/SystemObserver;)V", "GetUnRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_Handler:Huawei.Hms.Adapter.Sysobs.ISystemNotifierInvoker, Huawei.Hms.Availableupdate")]
		void UnRegisterObserver (global::Huawei.Hms.Adapter.Sysobs.ISystemObserver p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/adapter/sysobs/SystemNotifier", DoNotGenerateAcw=true)]
	internal partial class ISystemNotifierInvoker : global::Java.Lang.Object, ISystemNotifier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/adapter/sysobs/SystemNotifier", typeof (ISystemNotifierInvoker));

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

		public static ISystemNotifier GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISystemNotifier> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.adapter.sysobs.SystemNotifier"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISystemNotifierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_notifyObservers_Landroid_content_Intent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetNotifyObservers_Landroid_content_Intent_Ljava_lang_String_Handler ()
		{
			if (cb_notifyObservers_Landroid_content_Intent_Ljava_lang_String_ == null)
				cb_notifyObservers_Landroid_content_Intent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_NotifyObservers_Landroid_content_Intent_Ljava_lang_String_);
			return cb_notifyObservers_Landroid_content_Intent_Ljava_lang_String_;
		}

		static void n_NotifyObservers_Landroid_content_Intent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Sysobs.ISystemNotifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.NotifyObservers (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_notifyObservers_Landroid_content_Intent_Ljava_lang_String_;
		public unsafe void NotifyObservers (global::Android.Content.Intent p0, string p1)
		{
			if (id_notifyObservers_Landroid_content_Intent_Ljava_lang_String_ == IntPtr.Zero)
				id_notifyObservers_Landroid_content_Intent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "notifyObservers", "(Landroid/content/Intent;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyObservers_Landroid_content_Intent_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_notifyObservers_I;
#pragma warning disable 0169
		static Delegate GetNotifyObservers_IHandler ()
		{
			if (cb_notifyObservers_I == null)
				cb_notifyObservers_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_NotifyObservers_I);
			return cb_notifyObservers_I;
		}

		static void n_NotifyObservers_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Sysobs.ISystemNotifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyObservers (p0);
		}
#pragma warning restore 0169

		IntPtr id_notifyObservers_I;
		public unsafe void NotifyObservers (int p0)
		{
			if (id_notifyObservers_I == IntPtr.Zero)
				id_notifyObservers_I = JNIEnv.GetMethodID (class_ref, "notifyObservers", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notifyObservers_I, __args);
		}

		static Delegate cb_registerObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_;
#pragma warning disable 0169
		static Delegate GetRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_Handler ()
		{
			if (cb_registerObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_ == null)
				cb_registerObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_);
			return cb_registerObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_;
		}

		static void n_RegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Sysobs.ISystemNotifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Adapter.Sysobs.ISystemObserver)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Sysobs.ISystemObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegisterObserver (p0);
		}
#pragma warning restore 0169

		IntPtr id_registerObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_;
		public unsafe void RegisterObserver (global::Huawei.Hms.Adapter.Sysobs.ISystemObserver p0)
		{
			if (id_registerObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_ == IntPtr.Zero)
				id_registerObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_ = JNIEnv.GetMethodID (class_ref, "registerObserver", "(Lcom/huawei/hms/adapter/sysobs/SystemObserver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_registerObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_, __args);
		}

		static Delegate cb_unRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_;
#pragma warning disable 0169
		static Delegate GetUnRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_Handler ()
		{
			if (cb_unRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_ == null)
				cb_unRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_UnRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_);
			return cb_unRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_;
		}

		static void n_UnRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Sysobs.ISystemNotifier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Adapter.Sysobs.ISystemObserver)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.Sysobs.ISystemObserver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisterObserver (p0);
		}
#pragma warning restore 0169

		IntPtr id_unRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_;
		public unsafe void UnRegisterObserver (global::Huawei.Hms.Adapter.Sysobs.ISystemObserver p0)
		{
			if (id_unRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_ == IntPtr.Zero)
				id_unRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_ = JNIEnv.GetMethodID (class_ref, "unRegisterObserver", "(Lcom/huawei/hms/adapter/sysobs/SystemObserver;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unRegisterObserver_Lcom_huawei_hms_adapter_sysobs_SystemObserver_, __args);
		}

	}

}
