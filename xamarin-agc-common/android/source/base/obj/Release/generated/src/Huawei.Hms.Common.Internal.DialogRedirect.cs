using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='DialogRedirect']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/DialogRedirect", DoNotGenerateAcw=true)]
	public abstract partial class DialogRedirect : global::Java.Lang.Object, global::Android.Content.IDialogInterfaceOnClickListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/DialogRedirect", typeof (DialogRedirect));
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

		protected DialogRedirect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='DialogRedirect']/constructor[@name='DialogRedirect' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DialogRedirect ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='DialogRedirect']/method[@name='getInstance' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='int']]"
		[Register ("getInstance", "(Landroid/app/Activity;Landroid/content/Intent;I)Lcom/huawei/hms/common/internal/DialogRedirect;", "")]
		public static unsafe global::Huawei.Hms.Common.Internal.DialogRedirect GetInstance (global::Android.App.Activity p0, global::Android.Content.Intent p1, int p2)
		{
			const string __id = "getInstance.(Landroid/app/Activity;Landroid/content/Intent;I)Lcom/huawei/hms/common/internal/DialogRedirect;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.DialogRedirect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_onClick_Landroid_content_DialogInterface_I;
#pragma warning disable 0169
		static Delegate GetOnClick_Landroid_content_DialogInterface_IHandler ()
		{
			if (cb_onClick_Landroid_content_DialogInterface_I == null)
				cb_onClick_Landroid_content_DialogInterface_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnClick_Landroid_content_DialogInterface_I);
			return cb_onClick_Landroid_content_DialogInterface_I;
		}

		static void n_OnClick_Landroid_content_DialogInterface_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.DialogRedirect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Android.Content.IDialogInterface)global::Java.Lang.Object.GetObject<global::Android.Content.IDialogInterface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnClick (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='DialogRedirect']/method[@name='onClick' and count(parameter)=2 and parameter[1][@type='android.content.DialogInterface'] and parameter[2][@type='int']]"
		[Register ("onClick", "(Landroid/content/DialogInterface;I)V", "GetOnClick_Landroid_content_DialogInterface_IHandler")]
		public virtual unsafe void OnClick (global::Android.Content.IDialogInterface p0, int p1)
		{
			const string __id = "onClick.(Landroid/content/DialogInterface;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_redirect;
#pragma warning disable 0169
		static Delegate GetRedirectHandler ()
		{
			if (cb_redirect == null)
				cb_redirect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Redirect);
			return cb_redirect;
		}

		static void n_Redirect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Internal.DialogRedirect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Redirect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='DialogRedirect']/method[@name='redirect' and count(parameter)=0]"
		[Register ("redirect", "()V", "GetRedirectHandler")]
		protected abstract void Redirect ();

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/internal/DialogRedirect", DoNotGenerateAcw=true)]
	internal partial class DialogRedirectInvoker : DialogRedirect {

		public DialogRedirectInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/internal/DialogRedirect", typeof (DialogRedirectInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.internal']/class[@name='DialogRedirect']/method[@name='redirect' and count(parameter)=0]"
		[Register ("redirect", "()V", "GetRedirectHandler")]
		protected override unsafe void Redirect ()
		{
			const string __id = "redirect.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

}
