using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Agconnect.Https {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Service.Factory']"
	[global::Android.Runtime.Register ("com/huawei/agconnect/https/Service$Factory", DoNotGenerateAcw=true)]
	public partial class ServiceFactory : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/Service$Factory", typeof (ServiceFactory));
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

		protected ServiceFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Service.Factory']/constructor[@name='Service.Factory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ServiceFactory ()
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

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.agconnect.https']/interface[@name='Service']"
	[Register ("com/huawei/agconnect/https/Service", "", "Huawei.Agconnect.Https.IServiceInvoker")]
	public partial interface IService : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/interface[@name='Service']/method[@name='execute' and count(parameter)=1 and parameter[1][@type='com.huawei.agconnect.https.Method']]"
		[Register ("execute", "(Lcom/huawei/agconnect/https/Method;)Lcom/huawei/hmf/tasks/Task;", "GetExecute_Lcom_huawei_agconnect_https_Method_Handler:Huawei.Agconnect.Https.IServiceInvoker, Huawei.Agconnect.AgconnectHttps")]
		global::Huawei.Hmf.Tasks.Task Execute (global::Huawei.Agconnect.Https.Method p0);

	}

	[global::Android.Runtime.Register ("com/huawei/agconnect/https/Service", DoNotGenerateAcw=true)]
	internal partial class IServiceInvoker : global::Java.Lang.Object, IService {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/Service", typeof (IServiceInvoker));

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

		public static IService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.agconnect.https.Service"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_execute_Lcom_huawei_agconnect_https_Method_;
#pragma warning disable 0169
		static Delegate GetExecute_Lcom_huawei_agconnect_https_Method_Handler ()
		{
			if (cb_execute_Lcom_huawei_agconnect_https_Method_ == null)
				cb_execute_Lcom_huawei_agconnect_https_Method_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Execute_Lcom_huawei_agconnect_https_Method_);
			return cb_execute_Lcom_huawei_agconnect_https_Method_;
		}

		static IntPtr n_Execute_Lcom_huawei_agconnect_https_Method_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.IService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.Method> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Execute (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_execute_Lcom_huawei_agconnect_https_Method_;
		public unsafe global::Huawei.Hmf.Tasks.Task Execute (global::Huawei.Agconnect.Https.Method p0)
		{
			if (id_execute_Lcom_huawei_agconnect_https_Method_ == IntPtr.Zero)
				id_execute_Lcom_huawei_agconnect_https_Method_ = JNIEnv.GetMethodID (class_ref, "execute", "(Lcom/huawei/agconnect/https/Method;)Lcom/huawei/hmf/tasks/Task;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Huawei.Hmf.Tasks.Task> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_execute_Lcom_huawei_agconnect_https_Method_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
