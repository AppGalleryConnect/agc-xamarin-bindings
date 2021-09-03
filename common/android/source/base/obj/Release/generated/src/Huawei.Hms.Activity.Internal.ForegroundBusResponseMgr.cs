using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Activity.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundBusResponseMgr']"
	[global::Android.Runtime.Register ("com/huawei/hms/activity/internal/ForegroundBusResponseMgr", DoNotGenerateAcw=true)]
	public partial class ForegroundBusResponseMgr : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/activity/internal/ForegroundBusResponseMgr", typeof (ForegroundBusResponseMgr));
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

		protected ForegroundBusResponseMgr (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundBusResponseMgr']/constructor[@name='ForegroundBusResponseMgr' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ForegroundBusResponseMgr ()
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

		public static unsafe global::Huawei.Hms.Activity.Internal.ForegroundBusResponseMgr Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundBusResponseMgr']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/huawei/hms/activity/internal/ForegroundBusResponseMgr;", "")]
			get {
				const string __id = "getInstance.()Lcom/huawei/hms/activity/internal/ForegroundBusResponseMgr;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.ForegroundBusResponseMgr> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_get_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Handler ()
		{
			if (cb_get_Ljava_lang_String_ == null)
				cb_get_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Get_Ljava_lang_String_);
			return cb_get_Ljava_lang_String_;
		}

		static IntPtr n_Get_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.ForegroundBusResponseMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundBusResponseMgr']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/huawei/hms/activity/internal/BusResponseCallback;", "GetGet_Ljava_lang_String_Handler")]
		public virtual unsafe global::Huawei.Hms.Activity.Internal.IBusResponseCallback Get (string p0)
		{
			const string __id = "get.(Ljava/lang/String;)Lcom/huawei/hms/activity/internal/BusResponseCallback;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.IBusResponseCallback> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_registerObserver_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_;
#pragma warning disable 0169
		static Delegate GetRegisterObserver_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_Handler ()
		{
			if (cb_registerObserver_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_ == null)
				cb_registerObserver_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_RegisterObserver_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_);
			return cb_registerObserver_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_;
		}

		static void n_RegisterObserver_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.ForegroundBusResponseMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Activity.Internal.IBusResponseCallback)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.IBusResponseCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RegisterObserver (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundBusResponseMgr']/method[@name='registerObserver' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.huawei.hms.activity.internal.BusResponseCallback']]"
		[Register ("registerObserver", "(Ljava/lang/String;Lcom/huawei/hms/activity/internal/BusResponseCallback;)V", "GetRegisterObserver_Ljava_lang_String_Lcom_huawei_hms_activity_internal_BusResponseCallback_Handler")]
		public virtual unsafe void RegisterObserver (string p0, global::Huawei.Hms.Activity.Internal.IBusResponseCallback p1)
		{
			const string __id = "registerObserver.(Ljava/lang/String;Lcom/huawei/hms/activity/internal/BusResponseCallback;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_unRegisterObserver_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetUnRegisterObserver_Ljava_lang_String_Handler ()
		{
			if (cb_unRegisterObserver_Ljava_lang_String_ == null)
				cb_unRegisterObserver_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_UnRegisterObserver_Ljava_lang_String_);
			return cb_unRegisterObserver_Ljava_lang_String_;
		}

		static void n_UnRegisterObserver_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Activity.Internal.ForegroundBusResponseMgr> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnRegisterObserver (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.activity.internal']/class[@name='ForegroundBusResponseMgr']/method[@name='unRegisterObserver' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("unRegisterObserver", "(Ljava/lang/String;)V", "GetUnRegisterObserver_Ljava_lang_String_Handler")]
		public virtual unsafe void UnRegisterObserver (string p0)
		{
			const string __id = "unRegisterObserver.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
