using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Uı {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractPromptDialog']"
	[global::Android.Runtime.Register ("com/huawei/hms/ui/AbstractPromptDialog", DoNotGenerateAcw=true)]
	public abstract partial class AbstractPromptDialog : global::Huawei.Hms.Uı.AbstractDialog {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/ui/AbstractPromptDialog", typeof (AbstractPromptDialog));
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

		protected AbstractPromptDialog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractPromptDialog']/constructor[@name='AbstractPromptDialog' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractPromptDialog ()
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

		static Delegate cb_onGetNegativeButtonString_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnGetNegativeButtonString_Landroid_content_Context_Handler ()
		{
			if (cb_onGetNegativeButtonString_Landroid_content_Context_ == null)
				cb_onGetNegativeButtonString_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnGetNegativeButtonString_Landroid_content_Context_);
			return cb_onGetNegativeButtonString_Landroid_content_Context_;
		}

		static IntPtr n_OnGetNegativeButtonString_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractPromptDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.OnGetNegativeButtonString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractPromptDialog']/method[@name='onGetNegativeButtonString' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onGetNegativeButtonString", "(Landroid/content/Context;)Ljava/lang/String;", "GetOnGetNegativeButtonString_Landroid_content_Context_Handler")]
		public override unsafe string OnGetNegativeButtonString (global::Android.Content.Context p0)
		{
			const string __id = "onGetNegativeButtonString.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_onGetTitleString_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetOnGetTitleString_Landroid_content_Context_Handler ()
		{
			if (cb_onGetTitleString_Landroid_content_Context_ == null)
				cb_onGetTitleString_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_OnGetTitleString_Landroid_content_Context_);
			return cb_onGetTitleString_Landroid_content_Context_;
		}

		static IntPtr n_OnGetTitleString_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Uı.AbstractPromptDialog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.OnGetTitleString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractPromptDialog']/method[@name='onGetTitleString' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onGetTitleString", "(Landroid/content/Context;)Ljava/lang/String;", "GetOnGetTitleString_Landroid_content_Context_Handler")]
		public override unsafe string OnGetTitleString (global::Android.Content.Context p0)
		{
			const string __id = "onGetTitleString.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/ui/AbstractPromptDialog", DoNotGenerateAcw=true)]
	internal partial class AbstractPromptDialogInvoker : AbstractPromptDialog {

		public AbstractPromptDialogInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/ui/AbstractPromptDialog", typeof (AbstractPromptDialogInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='onGetMessageString' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onGetMessageString", "(Landroid/content/Context;)Ljava/lang/String;", "GetOnGetMessageString_Landroid_content_Context_Handler")]
		public override unsafe string OnGetMessageString (global::Android.Content.Context p0)
		{
			const string __id = "onGetMessageString.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.ui']/class[@name='AbstractDialog']/method[@name='onGetPositiveButtonString' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("onGetPositiveButtonString", "(Landroid/content/Context;)Ljava/lang/String;", "GetOnGetPositiveButtonString_Landroid_content_Context_Handler")]
		public override unsafe string OnGetPositiveButtonString (global::Android.Content.Context p0)
		{
			const string __id = "onGetPositiveButtonString.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

}
