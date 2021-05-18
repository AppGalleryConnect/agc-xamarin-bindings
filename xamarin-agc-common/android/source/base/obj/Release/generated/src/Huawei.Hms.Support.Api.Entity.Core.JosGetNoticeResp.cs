using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosGetNoticeResp']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/core/JosGetNoticeResp", DoNotGenerateAcw=true)]
	public partial class JosGetNoticeResp : global::Huawei.Hms.Support.Api.Entity.Core.JosBaseResp {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/core/JosGetNoticeResp", typeof (JosGetNoticeResp));
		internal static new IntPtr class_ref {
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

		protected JosGetNoticeResp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosGetNoticeResp']/constructor[@name='JosGetNoticeResp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JosGetNoticeResp ()
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

		static Delegate cb_getNoticeIntent;
#pragma warning disable 0169
		static Delegate GetGetNoticeIntentHandler ()
		{
			if (cb_getNoticeIntent == null)
				cb_getNoticeIntent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetNoticeIntent);
			return cb_getNoticeIntent;
		}

		static IntPtr n_GetNoticeIntent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.JosGetNoticeResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NoticeIntent);
		}
#pragma warning restore 0169

		static Delegate cb_setNoticeIntent_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSetNoticeIntent_Landroid_content_Intent_Handler ()
		{
			if (cb_setNoticeIntent_Landroid_content_Intent_ == null)
				cb_setNoticeIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetNoticeIntent_Landroid_content_Intent_);
			return cb_setNoticeIntent_Landroid_content_Intent_;
		}

		static void n_SetNoticeIntent_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.JosGetNoticeResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.NoticeIntent = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Intent NoticeIntent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosGetNoticeResp']/method[@name='getNoticeIntent' and count(parameter)=0]"
			[Register ("getNoticeIntent", "()Landroid/content/Intent;", "GetGetNoticeIntentHandler")]
			get {
				const string __id = "getNoticeIntent.()Landroid/content/Intent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosGetNoticeResp']/method[@name='setNoticeIntent' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
			[Register ("setNoticeIntent", "(Landroid/content/Intent;)V", "GetSetNoticeIntent_Landroid_content_Intent_Handler")]
			set {
				const string __id = "setNoticeIntent.(Landroid/content/Intent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

	}
}
