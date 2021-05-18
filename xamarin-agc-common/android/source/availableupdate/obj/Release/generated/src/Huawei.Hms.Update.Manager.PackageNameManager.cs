using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Update.Manager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='PackageNameManager']"
	[global::Android.Runtime.Register ("com/huawei/hms/update/manager/PackageNameManager", DoNotGenerateAcw=true)]
	public partial class PackageNameManager : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='PackageNameManager']/field[@name='a']"
		[Register ("a")]
		public global::Android.Content.Context A {
			get {
				const string __id = "a.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='PackageNameManager']/field[@name='b']"
		[Register ("b")]
		public static global::Java.Lang.Object B {
			get {
				const string __id = "b.Ljava/lang/Object;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='PackageNameManager']/field[@name='c']"
		[Register ("c")]
		public static global::Huawei.Hms.Update.Manager.PackageNameManager C {
			get {
				const string __id = "c.Lcom/huawei/hms/update/manager/PackageNameManager;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Manager.PackageNameManager> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "c.Lcom/huawei/hms/update/manager/PackageNameManager;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.update.manager']/interface[@name='PackageNameManager.QueryPublishCallback']"
		[Register ("com/huawei/hms/update/manager/PackageNameManager$QueryPublishCallback", "", "Huawei.Hms.Update.Manager.PackageNameManager/IQueryPublishCallbackInvoker")]
		public partial interface IQueryPublishCallback : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/interface[@name='PackageNameManager.QueryPublishCallback']/method[@name='onQueryResult' and count(parameter)=0]"
			[Register ("onQueryResult", "()V", "GetOnQueryResultHandler:Huawei.Hms.Update.Manager.PackageNameManager/IQueryPublishCallbackInvoker, Huawei.Hms.Availableupdate")]
			void OnQueryResult ();

		}

		[global::Android.Runtime.Register ("com/huawei/hms/update/manager/PackageNameManager$QueryPublishCallback", DoNotGenerateAcw=true)]
		internal partial class IQueryPublishCallbackInvoker : global::Java.Lang.Object, IQueryPublishCallback {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/update/manager/PackageNameManager$QueryPublishCallback", typeof (IQueryPublishCallbackInvoker));

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

			public static IQueryPublishCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IQueryPublishCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.update.manager.PackageNameManager.QueryPublishCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IQueryPublishCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onQueryResult;
#pragma warning disable 0169
			static Delegate GetOnQueryResultHandler ()
			{
				if (cb_onQueryResult == null)
					cb_onQueryResult = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnQueryResult);
				return cb_onQueryResult;
			}

			static void n_OnQueryResult (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Manager.PackageNameManager.IQueryPublishCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnQueryResult ();
			}
#pragma warning restore 0169

			IntPtr id_onQueryResult;
			public unsafe void OnQueryResult ()
			{
				if (id_onQueryResult == IntPtr.Zero)
					id_onQueryResult = JNIEnv.GetMethodID (class_ref, "onQueryResult", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onQueryResult);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/update/manager/PackageNameManager", typeof (PackageNameManager));
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

		protected PackageNameManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='PackageNameManager']/constructor[@name='PackageNameManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PackageNameManager (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='PackageNameManager']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/huawei/hms/update/manager/PackageNameManager;", "")]
		public static unsafe global::Huawei.Hms.Update.Manager.PackageNameManager GetInstance (global::Android.Content.Context p0)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/huawei/hms/update/manager/PackageNameManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Manager.PackageNameManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_queryPackageName_Lcom_huawei_hms_update_manager_PackageNameManager_QueryPublishCallback_;
#pragma warning disable 0169
		static Delegate GetQueryPackageName_Lcom_huawei_hms_update_manager_PackageNameManager_QueryPublishCallback_Handler ()
		{
			if (cb_queryPackageName_Lcom_huawei_hms_update_manager_PackageNameManager_QueryPublishCallback_ == null)
				cb_queryPackageName_Lcom_huawei_hms_update_manager_PackageNameManager_QueryPublishCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_QueryPackageName_Lcom_huawei_hms_update_manager_PackageNameManager_QueryPublishCallback_);
			return cb_queryPackageName_Lcom_huawei_hms_update_manager_PackageNameManager_QueryPublishCallback_;
		}

		static void n_QueryPackageName_Lcom_huawei_hms_update_manager_PackageNameManager_QueryPublishCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Manager.PackageNameManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Update.Manager.PackageNameManager.IQueryPublishCallback)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Update.Manager.PackageNameManager.IQueryPublishCallback> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.QueryPackageName (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='PackageNameManager']/method[@name='queryPackageName' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.update.manager.PackageNameManager.QueryPublishCallback']]"
		[Register ("queryPackageName", "(Lcom/huawei/hms/update/manager/PackageNameManager$QueryPublishCallback;)V", "GetQueryPackageName_Lcom_huawei_hms_update_manager_PackageNameManager_QueryPublishCallback_Handler")]
		public virtual unsafe void QueryPackageName (global::Huawei.Hms.Update.Manager.PackageNameManager.IQueryPublishCallback p0)
		{
			const string __id = "queryPackageName.(Lcom/huawei/hms/update/manager/PackageNameManager$QueryPublishCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
