using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hmf.Tasks {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='CancellationToken']"
	[global::Android.Runtime.Register ("com/huawei/hmf/tasks/CancellationToken", DoNotGenerateAcw=true)]
	public abstract partial class CancellationToken : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hmf/tasks/CancellationToken", typeof (CancellationToken));
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

		protected CancellationToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='CancellationToken']/constructor[@name='CancellationToken' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CancellationToken ()
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

		static Delegate cb_isCancellationRequested;
#pragma warning disable 0169
		static Delegate GetIsCancellationRequestedHandler ()
		{
			if (cb_isCancellationRequested == null)
				cb_isCancellationRequested = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCancellationRequested);
			return cb_isCancellationRequested;
		}

		static bool n_IsCancellationRequested (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.CancellationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancellationRequested;
		}
#pragma warning restore 0169

		public abstract bool IsCancellationRequested {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='CancellationToken']/method[@name='isCancellationRequested' and count(parameter)=0]"
			[Register ("isCancellationRequested", "()Z", "GetIsCancellationRequestedHandler")] get;
		}

		static Delegate cb_register_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRegister_Ljava_lang_Runnable_Handler ()
		{
			if (cb_register_Ljava_lang_Runnable_ == null)
				cb_register_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Register_Ljava_lang_Runnable_);
			return cb_register_Ljava_lang_Runnable_;
		}

		static IntPtr n_Register_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.CancellationToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Register (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='CancellationToken']/method[@name='register' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("register", "(Ljava/lang/Runnable;)Lcom/huawei/hmf/tasks/CancellationToken;", "GetRegister_Ljava_lang_Runnable_Handler")]
		public abstract global::Huawei.Hmf.Tasks.CancellationToken Register (global::Java.Lang.IRunnable p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hmf/tasks/CancellationToken", DoNotGenerateAcw=true)]
	internal partial class CancellationTokenInvoker : CancellationToken {

		public CancellationTokenInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hmf/tasks/CancellationToken", typeof (CancellationTokenInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe bool IsCancellationRequested {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='CancellationToken']/method[@name='isCancellationRequested' and count(parameter)=0]"
			[Register ("isCancellationRequested", "()Z", "GetIsCancellationRequestedHandler")]
			get {
				const string __id = "isCancellationRequested.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/class[@name='CancellationToken']/method[@name='register' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("register", "(Ljava/lang/Runnable;)Lcom/huawei/hmf/tasks/CancellationToken;", "GetRegister_Ljava_lang_Runnable_Handler")]
		public override unsafe global::Huawei.Hmf.Tasks.CancellationToken Register (global::Java.Lang.IRunnable p0)
		{
			const string __id = "register.(Ljava/lang/Runnable;)Lcom/huawei/hmf/tasks/CancellationToken;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.CancellationToken> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

}
