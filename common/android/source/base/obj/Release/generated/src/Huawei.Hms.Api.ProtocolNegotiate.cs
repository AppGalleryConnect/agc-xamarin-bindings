using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ProtocolNegotiate']"
	[global::Android.Runtime.Register ("com/huawei/hms/api/ProtocolNegotiate", DoNotGenerateAcw=true)]
	public partial class ProtocolNegotiate : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/ProtocolNegotiate", typeof (ProtocolNegotiate));
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

		protected ProtocolNegotiate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ProtocolNegotiate']/constructor[@name='ProtocolNegotiate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ProtocolNegotiate ()
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

		public static unsafe global::Huawei.Hms.Api.ProtocolNegotiate Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ProtocolNegotiate']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/huawei/hms/api/ProtocolNegotiate;", "")]
			get {
				const string __id = "getInstance.()Lcom/huawei/hms/api/ProtocolNegotiate;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ProtocolNegotiate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVersion);
			return cb_getVersion;
		}

		static int n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ProtocolNegotiate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Version;
		}
#pragma warning restore 0169

		public virtual unsafe int Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ProtocolNegotiate']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()I", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_negotiate_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetNegotiate_Ljava_util_List_Handler ()
		{
			if (cb_negotiate_Ljava_util_List_ == null)
				cb_negotiate_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_Negotiate_Ljava_util_List_);
			return cb_negotiate_Ljava_util_List_;
		}

		static int n_Negotiate_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ProtocolNegotiate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Negotiate (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ProtocolNegotiate']/method[@name='negotiate' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("negotiate", "(Ljava/util/List;)I", "GetNegotiate_Ljava_util_List_Handler")]
		public virtual unsafe int Negotiate (global::System.Collections.Generic.IList<global::Java.Lang.Integer> p0)
		{
			const string __id = "negotiate.(Ljava/util/List;)I";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
