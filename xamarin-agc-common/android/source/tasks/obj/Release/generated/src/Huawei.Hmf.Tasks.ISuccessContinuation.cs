using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hmf.Tasks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hmf.tasks']/interface[@name='SuccessContinuation']"
	[Register ("com/huawei/hmf/tasks/SuccessContinuation", "", "Huawei.Hmf.Tasks.ISuccessContinuationInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"TResult", "TContinuationResult"})]
	public partial interface ISuccessContinuation : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/interface[@name='SuccessContinuation']/method[@name='then' and count(parameter)=1 and parameter[1][@type='TResult']]"
		[Register ("then", "(Ljava/lang/Object;)Lcom/huawei/hmf/tasks/Task;", "GetThen_Ljava_lang_Object_Handler:Huawei.Hmf.Tasks.ISuccessContinuationInvoker, Huawei.Hmf.Tasks")]
		global::Huawei.Hmf.Tasks.Task Then (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hmf/tasks/SuccessContinuation", DoNotGenerateAcw=true)]
	internal partial class ISuccessContinuationInvoker : global::Java.Lang.Object, ISuccessContinuation {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hmf/tasks/SuccessContinuation", typeof (ISuccessContinuationInvoker));

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

		public static ISuccessContinuation GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISuccessContinuation> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hmf.tasks.SuccessContinuation"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISuccessContinuationInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_then_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetThen_Ljava_lang_Object_Handler ()
		{
			if (cb_then_Ljava_lang_Object_ == null)
				cb_then_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Then_Ljava_lang_Object_);
			return cb_then_Ljava_lang_Object_;
		}

		static IntPtr n_Then_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.ISuccessContinuation> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Then (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_then_Ljava_lang_Object_;
		public unsafe global::Huawei.Hmf.Tasks.Task Then (global::Java.Lang.Object p0)
		{
			if (id_then_Ljava_lang_Object_ == IntPtr.Zero)
				id_then_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "then", "(Ljava/lang/Object;)Lcom/huawei/hmf/tasks/Task;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_then_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
