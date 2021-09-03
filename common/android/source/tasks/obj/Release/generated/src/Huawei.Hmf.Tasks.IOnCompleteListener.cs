using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hmf.Tasks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hmf.tasks']/interface[@name='OnCompleteListener']"
	[Register ("com/huawei/hmf/tasks/OnCompleteListener", "", "Huawei.Hmf.Tasks.IOnCompleteListenerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"TResult"})]
	public partial interface IOnCompleteListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/interface[@name='OnCompleteListener']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.Task&lt;TResult&gt;']]"
		[Register ("onComplete", "(Lcom/huawei/hmf/tasks/Task;)V", "GetOnComplete_Lcom_huawei_hmf_tasks_Task_Handler:Huawei.Hmf.Tasks.IOnCompleteListenerInvoker, Huawei.Hmf.Tasks")]
		void OnComplete (global::Huawei.Hmf.Tasks.Task p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hmf/tasks/OnCompleteListener", DoNotGenerateAcw=true)]
	internal partial class IOnCompleteListenerInvoker : global::Java.Lang.Object, IOnCompleteListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hmf/tasks/OnCompleteListener", typeof (IOnCompleteListenerInvoker));

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

		public static IOnCompleteListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnCompleteListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hmf.tasks.OnCompleteListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnCompleteListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onComplete_Lcom_huawei_hmf_tasks_Task_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Lcom_huawei_hmf_tasks_Task_Handler ()
		{
			if (cb_onComplete_Lcom_huawei_hmf_tasks_Task_ == null)
				cb_onComplete_Lcom_huawei_hmf_tasks_Task_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnComplete_Lcom_huawei_hmf_tasks_Task_);
			return cb_onComplete_Lcom_huawei_hmf_tasks_Task_;
		}

		static void n_OnComplete_Lcom_huawei_hmf_tasks_Task_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnCompleteListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (p0);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Lcom_huawei_hmf_tasks_Task_;
		public unsafe void OnComplete (global::Huawei.Hmf.Tasks.Task p0)
		{
			if (id_onComplete_Lcom_huawei_hmf_tasks_Task_ == IntPtr.Zero)
				id_onComplete_Lcom_huawei_hmf_tasks_Task_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Lcom/huawei/hmf/tasks/Task;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Lcom_huawei_hmf_tasks_Task_, __args);
		}

	}

	// event args for com.huawei.hmf.tasks.OnCompleteListener.onComplete
	public partial class CompleteEventArgs : global::System.EventArgs {

		public CompleteEventArgs (global::Huawei.Hmf.Tasks.Task p0)
		{
			this.p0 = p0;
		}

		global::Huawei.Hmf.Tasks.Task p0;
		public global::Huawei.Hmf.Tasks.Task P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/huawei/hmf/tasks/OnCompleteListenerImplementor")]
	internal sealed partial class IOnCompleteListenerImplementor : global::Java.Lang.Object, IOnCompleteListener {

		object sender;

		public IOnCompleteListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/huawei/hmf/tasks/OnCompleteListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<CompleteEventArgs> Handler;
#pragma warning restore 0649

		public void OnComplete (global::Huawei.Hmf.Tasks.Task p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new CompleteEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnCompleteListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
