using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='IPCTransport']"
	[global::Android.Runtime.Register ("com/huawei/hms/api/IPCTransport", DoNotGenerateAcw=true)]
	public partial class IPCTransport : global::Java.Lang.Object, global::Huawei.Hms.Support.Api.Transport.IDatagramTransport {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/IPCTransport", typeof (IPCTransport));
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

		protected IPCTransport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='IPCTransport']/constructor[@name='IPCTransport' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.huawei.hms.core.aidl.IMessageEntity'] and parameter[3][@type='java.lang.Class&lt;? extends com.huawei.hms.core.aidl.IMessageEntity&gt;']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/Class;)V", "")]
		public unsafe IPCTransport (string p0, global::Huawei.Hms.Core.Aidl.IMessageEntity p1, global::Java.Lang.Class p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/Class;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='IPCTransport']/constructor[@name='IPCTransport' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.huawei.hms.core.aidl.IMessageEntity'] and parameter[3][@type='java.lang.Class&lt;? extends com.huawei.hms.core.aidl.IMessageEntity&gt;'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/Class;I)V", "")]
		public unsafe IPCTransport (string p0, global::Huawei.Hms.Core.Aidl.IMessageEntity p1, global::Java.Lang.Class p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/huawei/hms/core/aidl/IMessageEntity;Ljava/lang/Class;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='IPCTransport']/method[@name='post' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='com.huawei.hms.support.api.transport.DatagramTransport.CallBack']]"
		[Register ("post", "(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/transport/DatagramTransport$CallBack;)V", "")]
		public unsafe void Post (global::Huawei.Hms.Support.Api.Client.IApiClient p0, global::Huawei.Hms.Support.Api.Transport.IDatagramTransportCallBack p1)
		{
			const string __id = "post.(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/transport/DatagramTransport$CallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='IPCTransport']/method[@name='send' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.support.api.client.ApiClient'] and parameter[2][@type='com.huawei.hms.support.api.transport.DatagramTransport.CallBack']]"
		[Register ("send", "(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/transport/DatagramTransport$CallBack;)V", "")]
		public unsafe void Send (global::Huawei.Hms.Support.Api.Client.IApiClient p0, global::Huawei.Hms.Support.Api.Transport.IDatagramTransportCallBack p1)
		{
			const string __id = "send.(Lcom/huawei/hms/support/api/client/ApiClient;Lcom/huawei/hms/support/api/transport/DatagramTransport$CallBack;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

	}
}
