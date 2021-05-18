using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DBInnerIter']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/data/DBInnerIter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"O"})]
	public partial class DBInnerIter : global::Java.Lang.Object, global::Java.Util.IIterator {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DBInnerIter']/field[@name='dataBuffer']"
		[Register ("dataBuffer")]
		protected global::Huawei.Hms.Common.Data.IDataBuffer DataBuffer {
			get {
				const string __id = "dataBuffer.Lcom/huawei/hms/common/data/DataBuffer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "dataBuffer.Lcom/huawei/hms/common/data/DataBuffer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DBInnerIter']/field[@name='index']"
		[Register ("index")]
		protected int Index {
			get {
				const string __id = "index.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "index.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/DBInnerIter", typeof (DBInnerIter));
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

		protected DBInnerIter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DBInnerIter']/constructor[@name='DBInnerIter' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.data.DataBuffer&lt;O&gt;']]"
		[Register (".ctor", "(Lcom/huawei/hms/common/data/DataBuffer;)V", "")]
		public unsafe DBInnerIter (global::Huawei.Hms.Common.Data.IDataBuffer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/common/data/DataBuffer;)V";

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

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DBInnerIter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DBInnerIter']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DBInnerIter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DBInnerIter']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/Object;", "GetNextHandler")]
		public virtual unsafe global::Java.Lang.Object Next ()
		{
			const string __id = "next.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DBInnerIter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DBInnerIter']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "GetRemoveHandler")]
		public virtual unsafe void Remove ()
		{
			const string __id = "remove.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
