using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hmf.Tasks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hmf.tasks']/interface[@name='Continuation']"
	[Register ("com/huawei/hmf/tasks/Continuation", "", "Huawei.Hmf.Tasks.IContinuationInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"TResult", "TContinuationResult"})]
	public partial interface IContinuation : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/interface[@name='Continuation']/method[@name='then' and count(parameter)=1 and parameter[1][@type='com.huawei.hmf.tasks.Task&lt;TResult&gt;']]"
		[Register ("then", "(Lcom/huawei/hmf/tasks/Task;)Ljava/lang/Object;", "GetThen_Lcom_huawei_hmf_tasks_Task_Handler:Huawei.Hmf.Tasks.IContinuationInvoker, Huawei.Hmf.Tasks")]
		global::Java.Lang.Object Then (global::Huawei.Hmf.Tasks.Task p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hmf/tasks/Continuation", DoNotGenerateAcw=true)]
	internal partial class IContinuationInvoker : global::Java.Lang.Object, IContinuation {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hmf/tasks/Continuation", typeof (IContinuationInvoker));

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

		public static IContinuation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IContinuation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hmf.tasks.Continuation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IContinuationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_then_Lcom_huawei_hmf_tasks_Task_;
#pragma warning disable 0169
		static Delegate GetThen_Lcom_huawei_hmf_tasks_Task_Handler ()
		{
			if (cb_then_Lcom_huawei_hmf_tasks_Task_ == null)
				cb_then_Lcom_huawei_hmf_tasks_Task_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Then_Lcom_huawei_hmf_tasks_Task_);
			return cb_then_Lcom_huawei_hmf_tasks_Task_;
		}

		static IntPtr n_Then_Lcom_huawei_hmf_tasks_Task_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IContinuation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Then (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_then_Lcom_huawei_hmf_tasks_Task_;
		public unsafe global::Java.Lang.Object Then (global::Huawei.Hmf.Tasks.Task p0)
		{
			if (id_then_Lcom_huawei_hmf_tasks_Task_ == IntPtr.Zero)
				id_then_Lcom_huawei_hmf_tasks_Task_ = JNIEnv.GetMethodID (class_ref, "then", "(Lcom/huawei/hmf/tasks/Task;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_then_Lcom_huawei_hmf_tasks_Task_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
