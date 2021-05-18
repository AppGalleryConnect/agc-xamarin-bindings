using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hmf.Tasks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hmf.tasks']/interface[@name='OnCanceledListener']"
	[Register ("com/huawei/hmf/tasks/OnCanceledListener", "", "Huawei.Hmf.Tasks.IOnCanceledListenerInvoker")]
	public partial interface IOnCanceledListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/interface[@name='OnCanceledListener']/method[@name='onCanceled' and count(parameter)=0]"
		[Register ("onCanceled", "()V", "GetOnCanceledHandler:Huawei.Hmf.Tasks.IOnCanceledListenerInvoker, Huawei.Hmf.Tasks")]
		void OnCanceled ();

	}

	[global::Android.Runtime.Register ("com/huawei/hmf/tasks/OnCanceledListener", DoNotGenerateAcw=true)]
	internal partial class IOnCanceledListenerInvoker : global::Java.Lang.Object, IOnCanceledListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hmf/tasks/OnCanceledListener", typeof (IOnCanceledListenerInvoker));

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

		public static IOnCanceledListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnCanceledListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hmf.tasks.OnCanceledListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnCanceledListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCanceled;
#pragma warning disable 0169
		static Delegate GetOnCanceledHandler ()
		{
			if (cb_onCanceled == null)
				cb_onCanceled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCanceled);
			return cb_onCanceled;
		}

		static void n_OnCanceled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnCanceledListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCanceled ();
		}
#pragma warning restore 0169

		IntPtr id_onCanceled;
		public unsafe void OnCanceled ()
		{
			if (id_onCanceled == IntPtr.Zero)
				id_onCanceled = JNIEnv.GetMethodID (class_ref, "onCanceled", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCanceled);
		}

	}

	[global::Android.Runtime.Register ("mono/com/huawei/hmf/tasks/OnCanceledListenerImplementor")]
	internal sealed partial class IOnCanceledListenerImplementor : global::Java.Lang.Object, IOnCanceledListener {

		object sender;

		public IOnCanceledListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/huawei/hmf/tasks/OnCanceledListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnCanceled ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IOnCanceledListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
