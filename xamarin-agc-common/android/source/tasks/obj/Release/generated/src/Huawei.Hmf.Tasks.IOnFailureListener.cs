using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hmf.Tasks {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hmf.tasks']/interface[@name='OnFailureListener']"
	[Register ("com/huawei/hmf/tasks/OnFailureListener", "", "Huawei.Hmf.Tasks.IOnFailureListenerInvoker")]
	public partial interface IOnFailureListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hmf.tasks']/interface[@name='OnFailureListener']/method[@name='onFailure' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onFailure", "(Ljava/lang/Exception;)V", "GetOnFailure_Ljava_lang_Exception_Handler:Huawei.Hmf.Tasks.IOnFailureListenerInvoker, Huawei.Hmf.Tasks")]
		void OnFailure (global::Java.Lang.Exception p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hmf/tasks/OnFailureListener", DoNotGenerateAcw=true)]
	internal partial class IOnFailureListenerInvoker : global::Java.Lang.Object, IOnFailureListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hmf/tasks/OnFailureListener", typeof (IOnFailureListenerInvoker));

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

		public static IOnFailureListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnFailureListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hmf.tasks.OnFailureListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnFailureListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onFailure_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnFailure_Ljava_lang_Exception_Handler ()
		{
			if (cb_onFailure_Ljava_lang_Exception_ == null)
				cb_onFailure_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFailure_Ljava_lang_Exception_);
			return cb_onFailure_Ljava_lang_Exception_;
		}

		static void n_OnFailure_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.IOnFailureListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnFailure (p0);
		}
#pragma warning restore 0169

		IntPtr id_onFailure_Ljava_lang_Exception_;
		public unsafe void OnFailure (global::Java.Lang.Exception p0)
		{
			if (id_onFailure_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onFailure_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onFailure", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onFailure_Ljava_lang_Exception_, __args);
		}

	}

	// event args for com.huawei.hmf.tasks.OnFailureListener.onFailure
	public partial class FailureEventArgs : global::System.EventArgs {

		public FailureEventArgs (global::Java.Lang.Exception p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Exception p0;
		public global::Java.Lang.Exception P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/huawei/hmf/tasks/OnFailureListenerImplementor")]
	internal sealed partial class IOnFailureListenerImplementor : global::Java.Lang.Object, IOnFailureListener {

		object sender;

		public IOnFailureListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/huawei/hmf/tasks/OnFailureListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<FailureEventArgs> Handler;
#pragma warning restore 0649

		public void OnFailure (global::Java.Lang.Exception p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new FailureEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnFailureListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
