using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Agconnect.Https {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Adapter.Factory']"
	[global::Android.Runtime.Register ("com/huawei/agconnect/https/Adapter$Factory", DoNotGenerateAcw=true)]
	public partial class AdapterFactory : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/Adapter$Factory", typeof (AdapterFactory));
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

		protected AdapterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Adapter.Factory']/constructor[@name='Adapter.Factory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdapterFactory ()
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

		static Delegate cb_requestBodyAdapter;
#pragma warning disable 0169
		static Delegate GetRequestBodyAdapterHandler ()
		{
			if (cb_requestBodyAdapter == null)
				cb_requestBodyAdapter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_RequestBodyAdapter);
			return cb_requestBodyAdapter;
		}

		static IntPtr n_RequestBodyAdapter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.AdapterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestBodyAdapter ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Adapter.Factory']/method[@name='requestBodyAdapter' and count(parameter)=0]"
		[Register ("requestBodyAdapter", "()Lcom/huawei/agconnect/https/Adapter;", "GetRequestBodyAdapterHandler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"F"})]
		public virtual unsafe global::Huawei.Agconnect.Https.IAdapter RequestBodyAdapter ()
		{
			const string __id = "requestBodyAdapter.()Lcom/huawei/agconnect/https/Adapter;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.IAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_responseBodyAdapter_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetResponseBodyAdapter_Ljava_lang_Class_Handler ()
		{
			if (cb_responseBodyAdapter_Ljava_lang_Class_ == null)
				cb_responseBodyAdapter_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ResponseBodyAdapter_Ljava_lang_Class_);
			return cb_responseBodyAdapter_Ljava_lang_Class_;
		}

		static IntPtr n_ResponseBodyAdapter_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.AdapterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ResponseBodyAdapter (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Adapter.Factory']/method[@name='responseBodyAdapter' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("responseBodyAdapter", "(Ljava/lang/Class;)Lcom/huawei/agconnect/https/Adapter;", "GetResponseBodyAdapter_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public virtual unsafe global::Huawei.Agconnect.Https.IAdapter ResponseBodyAdapter (global::Java.Lang.Class p0)
		{
			const string __id = "responseBodyAdapter.(Ljava/lang/Class;)Lcom/huawei/agconnect/https/Adapter;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.IAdapter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.agconnect.https']/interface[@name='Adapter']"
	[Register ("com/huawei/agconnect/https/Adapter", "", "Huawei.Agconnect.Https.IAdapterInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"From", "To"})]
	public partial interface IAdapter : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/interface[@name='Adapter']/method[@name='adapter' and count(parameter)=1 and parameter[1][@type='From']]"
		[Register ("adapter", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetAdapter_Ljava_lang_Object_Handler:Huawei.Agconnect.Https.IAdapterInvoker, Huawei.Agconnect.AgconnectHttps")]
		global::Java.Lang.Object Adapter (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/huawei/agconnect/https/Adapter", DoNotGenerateAcw=true)]
	internal partial class IAdapterInvoker : global::Java.Lang.Object, IAdapter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/Adapter", typeof (IAdapterInvoker));

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

		public static IAdapter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.agconnect.https.Adapter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_adapter_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAdapter_Ljava_lang_Object_Handler ()
		{
			if (cb_adapter_Ljava_lang_Object_ == null)
				cb_adapter_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Adapter_Ljava_lang_Object_);
			return cb_adapter_Ljava_lang_Object_;
		}

		static IntPtr n_Adapter_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.IAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Adapter (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_adapter_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Adapter (global::Java.Lang.Object p0)
		{
			if (id_adapter_Ljava_lang_Object_ == IntPtr.Zero)
				id_adapter_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "adapter", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			var __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_adapter_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
