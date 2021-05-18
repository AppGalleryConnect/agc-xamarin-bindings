using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='AbstractDataBuffer']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/data/AbstractDataBuffer", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class AbstractDataBuffer : global::Huawei.Hms.Support.Api.Client.Result, global::Huawei.Hms.Common.Data.IDataBuffer {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='AbstractDataBuffer']/field[@name='mDataHolder']"
		[Register ("mDataHolder")]
		protected global::Huawei.Hms.Common.Data.DataHolder MDataHolder {
			get {
				const string __id = "mDataHolder.Lcom/huawei/hms/common/data/DataHolder;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataHolder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDataHolder.Lcom/huawei/hms/common/data/DataHolder;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/AbstractDataBuffer", typeof (AbstractDataBuffer));
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

		protected AbstractDataBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='AbstractDataBuffer']/constructor[@name='AbstractDataBuffer' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.data.DataHolder']]"
		[Register (".ctor", "(Lcom/huawei/hms/common/data/DataHolder;)V", "")]
		protected unsafe AbstractDataBuffer (global::Huawei.Hms.Common.Data.DataHolder p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/common/data/DataHolder;)V";

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

		static Delegate cb_getCount;
#pragma warning disable 0169
		static Delegate GetGetCountHandler ()
		{
			if (cb_getCount == null)
				cb_getCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCount);
			return cb_getCount;
		}

		static int n_GetCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.AbstractDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		public virtual unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='AbstractDataBuffer']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler")]
			get {
				const string __id = "getCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isClosed;
#pragma warning disable 0169
		static Delegate GetIsClosedHandler ()
		{
			if (cb_isClosed == null)
				cb_isClosed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsClosed);
			return cb_isClosed;
		}

		static bool n_IsClosed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.AbstractDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='AbstractDataBuffer']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler")]
			get {
				const string __id = "isClosed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMetadata;
#pragma warning disable 0169
		static Delegate GetGetMetadataHandler ()
		{
			if (cb_getMetadata == null)
				cb_getMetadata = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMetadata);
			return cb_getMetadata;
		}

		static IntPtr n_GetMetadata (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.AbstractDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.OS.Bundle Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='AbstractDataBuffer']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Landroid/os/Bundle;", "GetGetMetadataHandler")]
			get {
				const string __id = "getMetadata.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='AbstractDataBuffer']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.AbstractDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='AbstractDataBuffer']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public abstract global::Java.Lang.Object Get (int p0);

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.AbstractDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='AbstractDataBuffer']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator Iterator ()
		{
			const string __id = "iterator.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.AbstractDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='AbstractDataBuffer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_singleRefIterator;
#pragma warning disable 0169
		static Delegate GetSingleRefIteratorHandler ()
		{
			if (cb_singleRefIterator == null)
				cb_singleRefIterator = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_SingleRefIterator);
			return cb_singleRefIterator;
		}

		static IntPtr n_SingleRefIterator (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.AbstractDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SingleRefIterator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='AbstractDataBuffer']/method[@name='singleRefIterator' and count(parameter)=0]"
		[Register ("singleRefIterator", "()Ljava/util/Iterator;", "GetSingleRefIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator SingleRefIterator ()
		{
			const string __id = "singleRefIterator.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/data/AbstractDataBuffer", DoNotGenerateAcw=true)]
	internal partial class AbstractDataBufferInvoker : AbstractDataBuffer, global::Huawei.Hms.Common.Data.IDataBuffer {

		public AbstractDataBufferInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/AbstractDataBuffer", typeof (AbstractDataBufferInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='AbstractDataBuffer']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public override unsafe global::Java.Lang.Object Get (int p0)
		{
			const string __id = "get.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
