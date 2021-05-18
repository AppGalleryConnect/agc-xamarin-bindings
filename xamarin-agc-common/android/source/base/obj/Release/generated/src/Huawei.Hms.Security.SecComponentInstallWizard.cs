using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Security {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.security']/class[@name='SecComponentInstallWizard']"
	[global::Android.Runtime.Register ("com/huawei/hms/security/SecComponentInstallWizard", DoNotGenerateAcw=true)]
	public partial class SecComponentInstallWizard : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.security']/class[@name='SecComponentInstallWizard']/field[@name='PROVIDER_NAME']"
		[Register ("PROVIDER_NAME")]
		public const string ProviderName = (string) "HmsCore_OpenSSL";
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.security']/interface[@name='SecComponentInstallWizard.SecComponentInstallWizardListener']"
		[Register ("com/huawei/hms/security/SecComponentInstallWizard$SecComponentInstallWizardListener", "", "Huawei.Hms.Security.SecComponentInstallWizard/ISecComponentInstallWizardListenerInvoker")]
		public partial interface ISecComponentInstallWizardListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.security']/interface[@name='SecComponentInstallWizard.SecComponentInstallWizardListener']/method[@name='onFailed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onFailed", "(ILandroid/content/Intent;)V", "GetOnFailed_ILandroid_content_Intent_Handler:Huawei.Hms.Security.SecComponentInstallWizard/ISecComponentInstallWizardListenerInvoker, Huawei.Hms.Base")]
			void OnFailed (int p0, global::Android.Content.Intent p1);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.security']/interface[@name='SecComponentInstallWizard.SecComponentInstallWizardListener']/method[@name='onSuccess' and count(parameter)=0]"
			[Register ("onSuccess", "()V", "GetOnSuccessHandler:Huawei.Hms.Security.SecComponentInstallWizard/ISecComponentInstallWizardListenerInvoker, Huawei.Hms.Base")]
			void OnSuccess ();

		}

		[global::Android.Runtime.Register ("com/huawei/hms/security/SecComponentInstallWizard$SecComponentInstallWizardListener", DoNotGenerateAcw=true)]
		internal partial class ISecComponentInstallWizardListenerInvoker : global::Java.Lang.Object, ISecComponentInstallWizardListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/security/SecComponentInstallWizard$SecComponentInstallWizardListener", typeof (ISecComponentInstallWizardListenerInvoker));

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

			public static ISecComponentInstallWizardListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ISecComponentInstallWizardListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.security.SecComponentInstallWizard.SecComponentInstallWizardListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ISecComponentInstallWizardListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onFailed_ILandroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnFailed_ILandroid_content_Intent_Handler ()
			{
				if (cb_onFailed_ILandroid_content_Intent_ == null)
					cb_onFailed_ILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_OnFailed_ILandroid_content_Intent_);
				return cb_onFailed_ILandroid_content_Intent_;
			}

			static void n_OnFailed_ILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Security.SecComponentInstallWizard.ISecComponentInstallWizardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.OnFailed (p0, p1);
			}
#pragma warning restore 0169

			IntPtr id_onFailed_ILandroid_content_Intent_;
			public unsafe void OnFailed (int p0, global::Android.Content.Intent p1)
			{
				if (id_onFailed_ILandroid_content_Intent_ == IntPtr.Zero)
					id_onFailed_ILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onFailed", "(ILandroid/content/Intent;)V");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailed_ILandroid_content_Intent_, __args);
			}

			static Delegate cb_onSuccess;
#pragma warning disable 0169
			static Delegate GetOnSuccessHandler ()
			{
				if (cb_onSuccess == null)
					cb_onSuccess = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnSuccess);
				return cb_onSuccess;
			}

			static void n_OnSuccess (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Security.SecComponentInstallWizard.ISecComponentInstallWizardListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnSuccess ();
			}
#pragma warning restore 0169

			IntPtr id_onSuccess;
			public unsafe void OnSuccess ()
			{
				if (id_onSuccess == IntPtr.Zero)
					id_onSuccess = JNIEnv.GetMethodID (class_ref, "onSuccess", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess);
			}

		}

		// event args for com.huawei.hms.security.SecComponentInstallWizard.SecComponentInstallWizardListener.onFailed
		public partial class FailedEventArgs : global::System.EventArgs {

			public FailedEventArgs (int p0, global::Android.Content.Intent p1)
			{
				this.p0 = p0;
				this.p1 = p1;
			}

			int p0;
			public int P0 {
				get { return p0; }
			}

			global::Android.Content.Intent p1;
			public global::Android.Content.Intent P1 {
				get { return p1; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/huawei/hms/security/SecComponentInstallWizard_SecComponentInstallWizardListenerImplementor")]
		internal sealed partial class ISecComponentInstallWizardListenerImplementor : global::Java.Lang.Object, ISecComponentInstallWizardListener {

			object sender;

			public ISecComponentInstallWizardListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/huawei/hms/security/SecComponentInstallWizard_SecComponentInstallWizardListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<FailedEventArgs> OnFailedHandler;
#pragma warning restore 0649

			public void OnFailed (int p0, global::Android.Content.Intent p1)
			{
				var __h = OnFailedHandler;
				if (__h != null)
					__h (sender, new FailedEventArgs (p0, p1));
			}
#pragma warning disable 0649
			public EventHandler OnSuccessHandler;
#pragma warning restore 0649

			public void OnSuccess ()
			{
				var __h = OnSuccessHandler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (ISecComponentInstallWizardListenerImplementor value)
			{
				return value.OnFailedHandler == null && value.OnSuccessHandler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/security/SecComponentInstallWizard", typeof (SecComponentInstallWizard));
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

		protected SecComponentInstallWizard (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.security']/class[@name='SecComponentInstallWizard']/constructor[@name='SecComponentInstallWizard' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SecComponentInstallWizard ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.security']/class[@name='SecComponentInstallWizard']/method[@name='install' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("install", "(Landroid/content/Context;)V", "")]
		public static unsafe void Install (global::Android.Content.Context p0)
		{
			const string __id = "install.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
