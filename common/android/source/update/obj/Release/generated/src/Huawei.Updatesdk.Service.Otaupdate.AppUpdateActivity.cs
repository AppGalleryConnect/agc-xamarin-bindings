using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Updatesdk.Service.Otaupdate {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='AppUpdateActivity']"
	[global::Android.Runtime.Register ("com/huawei/updatesdk/service/otaupdate/AppUpdateActivity", DoNotGenerateAcw=true)]
	public partial class AppUpdateActivity : global::Android.App.Activity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/updatesdk/service/otaupdate/AppUpdateActivity", typeof (AppUpdateActivity));
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

		protected AppUpdateActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='AppUpdateActivity']/constructor[@name='AppUpdateActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppUpdateActivity ()
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

		static Delegate cb_a_I;
#pragma warning disable 0169
		static Delegate GetA_IHandler ()
		{
			if (cb_a_I == null)
				cb_a_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_A_I);
			return cb_a_I;
		}

		static void n_A_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.AppUpdateActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='AppUpdateActivity']/method[@name='a' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("a", "(I)V", "GetA_IHandler")]
		public virtual unsafe void A (int p0)
		{
			const string __id = "a.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_b_I;
#pragma warning disable 0169
		static Delegate GetB_IHandler ()
		{
			if (cb_b_I == null)
				cb_b_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_B_I);
			return cb_b_I;
		}

		static void n_B_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.AppUpdateActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.B (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='AppUpdateActivity']/method[@name='b' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("b", "(I)V", "GetB_IHandler")]
		public virtual unsafe void B (int p0)
		{
			const string __id = "b.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onActivityResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_onActivityResult_IILandroid_content_Intent_ == null)
				cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIL_V) n_OnActivityResult_IILandroid_content_Intent_);
			return cb_onActivityResult_IILandroid_content_Intent_;
		}

		static void n_OnActivityResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.AppUpdateActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Android.App.Result) native_p1;
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResult (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='AppUpdateActivity']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)V", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public virtual unsafe void OnActivityResult (int p0, [global::Android.Runtime.GeneratedEnum] global::Android.App.Result p1, global::Android.Content.Intent p2)
		{
			const string __id = "onActivityResult.(IILandroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((int) p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p2);
			}
		}

	}
}
