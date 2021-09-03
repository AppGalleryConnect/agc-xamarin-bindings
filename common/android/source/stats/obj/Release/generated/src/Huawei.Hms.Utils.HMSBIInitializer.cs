using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSBIInitializer']"
	[global::Android.Runtime.Register ("com/huawei/hms/utils/HMSBIInitializer", DoNotGenerateAcw=true)]
	public partial class HMSBIInitializer : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSBIInitializer']/field[@name='b']"
		[Register ("b")]
		public global::Java.Util.Concurrent.Atomic.AtomicBoolean B {
			get {
				const string __id = "b.Ljava/util/concurrent/atomic/AtomicBoolean;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.Atomic.AtomicBoolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Ljava/util/concurrent/atomic/AtomicBoolean;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSBIInitializer']/field[@name='c']"
		[Register ("c")]
		public bool C {
			get {
				const string __id = "c.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "c.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSBIInitializer']/field[@name='d']"
		[Register ("d")]
		public static global::Java.Lang.Object D {
			get {
				const string __id = "d.Ljava/lang/Object;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSBIInitializer']/field[@name='e']"
		[Register ("e")]
		public static global::Huawei.Hms.Utils.HMSBIInitializer E {
			get {
				const string __id = "e.Lcom/huawei/hms/utils/HMSBIInitializer;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.HMSBIInitializer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "e.Lcom/huawei/hms/utils/HMSBIInitializer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/HMSBIInitializer", typeof (HMSBIInitializer));
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

		protected HMSBIInitializer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSBIInitializer']/constructor[@name='HMSBIInitializer' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe HMSBIInitializer (global::Android.Content.Context p0)
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

		static Delegate cb_isInit;
#pragma warning disable 0169
		static Delegate GetIsInitHandler ()
		{
			if (cb_isInit == null)
				cb_isInit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsInit);
			return cb_isInit;
		}

		static bool n_IsInit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.HMSBIInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInit;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsInit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSBIInitializer']/method[@name='isInit' and count(parameter)=0]"
			[Register ("isInit", "()Z", "GetIsInitHandler")]
			get {
				const string __id = "isInit.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSBIInitializer']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)V", "")]
		public unsafe void A (string p0)
		{
			const string __id = "a.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSBIInitializer']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/huawei/hms/utils/HMSBIInitializer;", "")]
		public static unsafe global::Huawei.Hms.Utils.HMSBIInitializer GetInstance (global::Android.Content.Context p0)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/huawei/hms/utils/HMSBIInitializer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.HMSBIInitializer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_initBI;
#pragma warning disable 0169
		static Delegate GetInitBIHandler ()
		{
			if (cb_initBI == null)
				cb_initBI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_InitBI);
			return cb_initBI;
		}

		static void n_InitBI (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.HMSBIInitializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitBI ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSBIInitializer']/method[@name='initBI' and count(parameter)=0]"
		[Register ("initBI", "()V", "GetInitBIHandler")]
		public virtual unsafe void InitBI ()
		{
			const string __id = "initBI.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
