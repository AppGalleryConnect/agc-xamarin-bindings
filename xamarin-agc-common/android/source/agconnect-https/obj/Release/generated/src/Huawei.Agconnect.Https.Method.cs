using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Agconnect.Https {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Method']"
	[global::Android.Runtime.Register ("com/huawei/agconnect/https/Method", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"HttpsRequest"})]
	public abstract partial class Method : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Method.Get']"
		[global::Android.Runtime.Register ("com/huawei/agconnect/https/Method$Get", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"HttpsRequest"})]
		public partial class Get : global::Huawei.Agconnect.Https.Method {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/Method$Get", typeof (Get));
			internal static new IntPtr class_ref {
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

			protected Get (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Method.Get']/constructor[@name='Method.Get' and count(parameter)=1 and parameter[1][@type='HttpsRequest']]"
			[Register (".ctor", "(Ljava/lang/Object;)V", "")]
			public unsafe Get (global::Java.Lang.Object p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Object;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p0);
				}
			}

			static Delegate cb_create;
#pragma warning disable 0169
			static Delegate GetCreateHandler ()
			{
				if (cb_create == null)
					cb_create = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Create);
				return cb_create;
			}

			static IntPtr n_Create (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.Method.Get> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Create ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Method.Get']/method[@name='create' and count(parameter)=0]"
			[Register ("create", "()Lokhttp3/Request$Builder;", "GetCreateHandler")]
			public virtual unsafe global::Square.OkHttp3.Request.Builder Create ()
			{
				const string __id = "create.()Lokhttp3/Request$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Square.OkHttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Method.Post']"
		[global::Android.Runtime.Register ("com/huawei/agconnect/https/Method$Post", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"HttpsRequest"})]
		public partial class Post : global::Huawei.Agconnect.Https.Method {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/Method$Post", typeof (Post));
			internal static new IntPtr class_ref {
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

			protected Post (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Method.Post']/constructor[@name='Method.Post' and count(parameter)=2 and parameter[1][@type='HttpsRequest'] and parameter[2][@type='com.huawei.agconnect.https.Adapter.Factory']]"
			[Register (".ctor", "(Ljava/lang/Object;Lcom/huawei/agconnect/https/Adapter$Factory;)V", "")]
			public unsafe Post (global::Java.Lang.Object p0, global::Huawei.Agconnect.Https.AdapterFactory p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Object;Lcom/huawei/agconnect/https/Adapter$Factory;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			static Delegate cb_create;
#pragma warning disable 0169
			static Delegate GetCreateHandler ()
			{
				if (cb_create == null)
					cb_create = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Create);
				return cb_create;
			}

			static IntPtr n_Create (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.Method.Post> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Create ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Method.Post']/method[@name='create' and count(parameter)=0]"
			[Register ("create", "()Lokhttp3/Request$Builder;", "GetCreateHandler")]
			public virtual unsafe global::Square.OkHttp3.Request.Builder Create ()
			{
				const string __id = "create.()Lokhttp3/Request$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Square.OkHttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_createBody_Lokhttp3_Request_Builder_Lokhttp3_RequestBody_;
#pragma warning disable 0169
			static Delegate GetCreateBody_Lokhttp3_Request_Builder_Lokhttp3_RequestBody_Handler ()
			{
				if (cb_createBody_Lokhttp3_Request_Builder_Lokhttp3_RequestBody_ == null)
					cb_createBody_Lokhttp3_Request_Builder_Lokhttp3_RequestBody_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_CreateBody_Lokhttp3_Request_Builder_Lokhttp3_RequestBody_);
				return cb_createBody_Lokhttp3_Request_Builder_Lokhttp3_RequestBody_;
			}

			static IntPtr n_CreateBody_Lokhttp3_Request_Builder_Lokhttp3_RequestBody_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Https.Method.Post> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Square.OkHttp3.Request.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Square.OkHttp3.RequestBody> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateBody (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Method.Post']/method[@name='createBody' and count(parameter)=2 and parameter[1][@type='okhttp3.Request.Builder'] and parameter[2][@type='okhttp3.RequestBody']]"
			[Register ("createBody", "(Lokhttp3/Request$Builder;Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;", "GetCreateBody_Lokhttp3_Request_Builder_Lokhttp3_RequestBody_Handler")]
			public virtual unsafe global::Square.OkHttp3.Request.Builder CreateBody (global::Square.OkHttp3.Request.Builder p0, global::Square.OkHttp3.RequestBody p1)
			{
				const string __id = "createBody.(Lokhttp3/Request$Builder;Lokhttp3/RequestBody;)Lokhttp3/Request$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Square.OkHttp3.Request.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Method.Put']"
		[global::Android.Runtime.Register ("com/huawei/agconnect/https/Method$Put", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"HttpsRequest"})]
		public partial class Put : global::Huawei.Agconnect.Https.Method.Post {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/Method$Put", typeof (Put));
			internal static new IntPtr class_ref {
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

			protected Put (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Method.Put']/constructor[@name='Method.Put' and count(parameter)=2 and parameter[1][@type='HttpsRequest'] and parameter[2][@type='com.huawei.agconnect.https.Adapter.Factory']]"
			[Register (".ctor", "(Ljava/lang/Object;Lcom/huawei/agconnect/https/Adapter$Factory;)V", "")]
			public unsafe Put (global::Java.Lang.Object p0, global::Huawei.Agconnect.Https.AdapterFactory p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/Object;Lcom/huawei/agconnect/https/Adapter$Factory;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/Method", typeof (Method));
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

		protected Method (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.agconnect.https']/class[@name='Method']/constructor[@name='Method' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Method ()
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

	[global::Android.Runtime.Register ("com/huawei/agconnect/https/Method", DoNotGenerateAcw=true)]
	internal partial class MethodInvoker : Method {

		public MethodInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/https/Method", typeof (MethodInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
