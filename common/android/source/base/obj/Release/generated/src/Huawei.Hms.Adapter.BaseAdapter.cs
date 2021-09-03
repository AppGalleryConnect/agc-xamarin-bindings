using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Adapter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BaseAdapter']"
	[global::Android.Runtime.Register ("com/huawei/hms/adapter/BaseAdapter", DoNotGenerateAcw=true)]
	public partial class BaseAdapter : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.adapter']/interface[@name='BaseAdapter.BaseCallBack']"
		[Register ("com/huawei/hms/adapter/BaseAdapter$BaseCallBack", "", "Huawei.Hms.Adapter.BaseAdapter/IBaseCallBackInvoker")]
		public partial interface IBaseCallBack : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/interface[@name='BaseAdapter.BaseCallBack']/method[@name='onComplete' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Parcelable']]"
			[Register ("onComplete", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Parcelable;)V", "GetOnComplete_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_Handler:Huawei.Hms.Adapter.BaseAdapter/IBaseCallBackInvoker, Huawei.Hms.Base")]
			void OnComplete (string p0, string p1, global::Android.OS.IParcelable p2);

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/interface[@name='BaseAdapter.BaseCallBack']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("onError", "(Ljava/lang/String;)V", "GetOnError_Ljava_lang_String_Handler:Huawei.Hms.Adapter.BaseAdapter/IBaseCallBackInvoker, Huawei.Hms.Base")]
			void OnError (string p0);

		}

		[global::Android.Runtime.Register ("com/huawei/hms/adapter/BaseAdapter$BaseCallBack", DoNotGenerateAcw=true)]
		internal partial class IBaseCallBackInvoker : global::Java.Lang.Object, IBaseCallBack {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/adapter/BaseAdapter$BaseCallBack", typeof (IBaseCallBackInvoker));

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

			public static IBaseCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IBaseCallBack> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.adapter.BaseAdapter.BaseCallBack"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IBaseCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onComplete_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_;
#pragma warning disable 0169
			static Delegate GetOnComplete_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_Handler ()
			{
				if (cb_onComplete_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_ == null)
					cb_onComplete_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_V) n_OnComplete_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_);
				return cb_onComplete_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_;
			}

			static void n_OnComplete_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BaseAdapter.IBaseCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
				var p2 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p2, JniHandleOwnership.DoNotTransfer);
				__this.OnComplete (p0, p1, p2);
			}
#pragma warning restore 0169

			IntPtr id_onComplete_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_;
			public unsafe void OnComplete (string p0, string p1, global::Android.OS.IParcelable p2)
			{
				if (id_onComplete_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_ == IntPtr.Zero)
					id_onComplete_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Parcelable;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}

			static Delegate cb_onError_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetOnError_Ljava_lang_String_Handler ()
			{
				if (cb_onError_Ljava_lang_String_ == null)
					cb_onError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnError_Ljava_lang_String_);
				return cb_onError_Ljava_lang_String_;
			}

			static void n_OnError_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BaseAdapter.IBaseCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnError (p0);
			}
#pragma warning restore 0169

			IntPtr id_onError_Ljava_lang_String_;
			public unsafe void OnError (string p0)
			{
				if (id_onError_Ljava_lang_String_ == IntPtr.Zero)
					id_onError_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/String;)V");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BaseAdapter.BaseRequestResultCallback']"
		[global::Android.Runtime.Register ("com/huawei/hms/adapter/BaseAdapter$BaseRequestResultCallback", DoNotGenerateAcw=true)]
		public partial class BaseRequestResultCallback : global::Java.Lang.Object, global::Huawei.Hms.Support.Api.Client.IResultCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/adapter/BaseAdapter$BaseRequestResultCallback", typeof (BaseRequestResultCallback));
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

			protected BaseRequestResultCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BaseAdapter.BaseRequestResultCallback']/constructor[@name='BaseAdapter.BaseRequestResultCallback' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.adapter.BaseAdapter']]"
			[Register (".ctor", "(Lcom/huawei/hms/adapter/BaseAdapter;)V", "")]
			public unsafe BaseRequestResultCallback (global::Huawei.Hms.Adapter.BaseAdapter __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (__self);
				}
			}

			static Delegate cb_onResult_Lcom_huawei_hms_support_api_ResolveResult_;
#pragma warning disable 0169
			static Delegate GetOnResult_Lcom_huawei_hms_support_api_ResolveResult_Handler ()
			{
				if (cb_onResult_Lcom_huawei_hms_support_api_ResolveResult_ == null)
					cb_onResult_Lcom_huawei_hms_support_api_ResolveResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnResult_Lcom_huawei_hms_support_api_ResolveResult_);
				return cb_onResult_Lcom_huawei_hms_support_api_ResolveResult_;
			}

			static void n_OnResult_Lcom_huawei_hms_support_api_ResolveResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BaseAdapter.BaseRequestResultCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.ResolveResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnResult (p0);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BaseAdapter.BaseRequestResultCallback']/method[@name='onResult' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.ResolveResult&lt;com.huawei.hms.adapter.CoreBaseResponse&gt;']]"
			[Register ("onResult", "(Lcom/huawei/hms/support/api/ResolveResult;)V", "GetOnResult_Lcom_huawei_hms_support_api_ResolveResult_Handler")]
			public virtual unsafe void OnResult (global::Huawei.Hms.Support.Api.ResolveResult p0)
			{
				const string __id = "onResult.(Lcom/huawei/hms/support/api/ResolveResult;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// This method is explicitly implemented as a member of an instantiated Huawei.Hms.Support.Api.Client.IResultCallback
			void global::Huawei.Hms.Support.Api.Client.IResultCallback.OnResult (global::Java.Lang.Object p0)
			{
				OnResult (global::Java.Interop.JavaObjectExtensions.JavaCast<global::Huawei.Hms.Support.Api.ResolveResult>(p0));
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/adapter/BaseAdapter", typeof (BaseAdapter));
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

		protected BaseAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BaseAdapter']/constructor[@name='BaseAdapter' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient']]"
		[Register (".ctor", "(Lcom/huawei/hms/support/api/client/ApiClient;)V", "")]
		public unsafe BaseAdapter (global::Huawei.Hms.Support.Api.Client.IApiClient p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/support/api/client/ApiClient;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BaseAdapter']/constructor[@name='BaseAdapter' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='android.app.Activity']]"
		[Register (".ctor", "(Lcom/huawei/hms/support/api/client/ApiClient;Landroid/app/Activity;)V", "")]
		public unsafe BaseAdapter (global::Huawei.Hms.Support.Api.Client.IApiClient p0, global::Android.App.Activity p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/support/api/client/ApiClient;Landroid/app/Activity;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_baseRequest_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_Lcom_huawei_hms_adapter_BaseAdapter_BaseCallBack_;
#pragma warning disable 0169
		static Delegate GetBaseRequest_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_Lcom_huawei_hms_adapter_BaseAdapter_BaseCallBack_Handler ()
		{
			if (cb_baseRequest_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_Lcom_huawei_hms_adapter_BaseAdapter_BaseCallBack_ == null)
				cb_baseRequest_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_Lcom_huawei_hms_adapter_BaseAdapter_BaseCallBack_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_BaseRequest_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_Lcom_huawei_hms_adapter_BaseAdapter_BaseCallBack_);
			return cb_baseRequest_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_Lcom_huawei_hms_adapter_BaseAdapter_BaseCallBack_;
		}

		static void n_BaseRequest_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_Lcom_huawei_hms_adapter_BaseAdapter_BaseCallBack_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BaseAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Huawei.Hms.Adapter.BaseAdapter.IBaseCallBack)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Adapter.BaseAdapter.IBaseCallBack> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.BaseRequest (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.adapter']/class[@name='BaseAdapter']/method[@name='baseRequest' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Parcelable'] and parameter[4][@type='com.huawei.hms.adapter.BaseAdapter.BaseCallBack']]"
		[Register ("baseRequest", "(Ljava/lang/String;Ljava/lang/String;Landroid/os/Parcelable;Lcom/huawei/hms/adapter/BaseAdapter$BaseCallBack;)V", "GetBaseRequest_Ljava_lang_String_Ljava_lang_String_Landroid_os_Parcelable_Lcom_huawei_hms_adapter_BaseAdapter_BaseCallBack_Handler")]
		public virtual unsafe void BaseRequest (string p0, string p1, global::Android.OS.IParcelable p2, global::Huawei.Hms.Adapter.BaseAdapter.IBaseCallBack p3)
		{
			const string __id = "baseRequest.(Ljava/lang/String;Ljava/lang/String;Landroid/os/Parcelable;Lcom/huawei/hms/adapter/BaseAdapter$BaseCallBack;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

	}
}
