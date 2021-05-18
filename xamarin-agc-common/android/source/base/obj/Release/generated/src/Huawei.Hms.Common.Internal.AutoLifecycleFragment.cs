using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='AutoLifecycleFragment']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/AutoLifecycleFragment", DoNotGenerateAcw=true)]
	public partial class AutoLifecycleFragment : global::Android.App.Fragment {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/AutoLifecycleFragment", typeof (AutoLifecycleFragment));
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

		protected AutoLifecycleFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='AutoLifecycleFragment']/constructor[@name='AutoLifecycleFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AutoLifecycleFragment ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='AutoLifecycleFragment']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("getInstance", "(Landroid/app/Activity;)Lcom/huawei/hms/common/internal/AutoLifecycleFragment;", "")]
		public static unsafe global::Huawei.Hms.Common.Internal.AutoLifecycleFragment GetInstance (global::Android.App.Activity p0)
		{
			const string __id = "getInstance.(Landroid/app/Activity;)Lcom/huawei/hms/common/internal/AutoLifecycleFragment;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.AutoLifecycleFragment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_startAutoMange_ILcom_huawei_hms_api_HuaweiApiClient_;
#pragma warning disable 0169
		static Delegate GetStartAutoMange_ILcom_huawei_hms_api_HuaweiApiClient_Handler ()
		{
			if (cb_startAutoMange_ILcom_huawei_hms_api_HuaweiApiClient_ == null)
				cb_startAutoMange_ILcom_huawei_hms_api_HuaweiApiClient_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_StartAutoMange_ILcom_huawei_hms_api_HuaweiApiClient_);
			return cb_startAutoMange_ILcom_huawei_hms_api_HuaweiApiClient_;
		}

		static void n_StartAutoMange_ILcom_huawei_hms_api_HuaweiApiClient_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.AutoLifecycleFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartAutoMange (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='AutoLifecycleFragment']/method[@name='startAutoMange' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.huawei.hms.api.HuaweiApiClient']]"
		[Register ("startAutoMange", "(ILcom/huawei/hms/api/HuaweiApiClient;)V", "GetStartAutoMange_ILcom_huawei_hms_api_HuaweiApiClient_Handler")]
		public virtual unsafe void StartAutoMange (int p0, global::Huawei.Hms.Api.HuaweiApiClient p1)
		{
			const string __id = "startAutoMange.(ILcom/huawei/hms/api/HuaweiApiClient;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_stopAutoManage_I;
#pragma warning disable 0169
		static Delegate GetStopAutoManage_IHandler ()
		{
			if (cb_stopAutoManage_I == null)
				cb_stopAutoManage_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_StopAutoManage_I);
			return cb_stopAutoManage_I;
		}

		static void n_StopAutoManage_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.AutoLifecycleFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAutoManage (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='AutoLifecycleFragment']/method[@name='stopAutoManage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stopAutoManage", "(I)V", "GetStopAutoManage_IHandler")]
		public virtual unsafe void StopAutoManage (int p0)
		{
			const string __id = "stopAutoManage.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
