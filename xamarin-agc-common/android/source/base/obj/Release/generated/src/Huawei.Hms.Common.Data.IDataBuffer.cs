using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Data {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBuffer']"
	[Register ("com/huawei/hms/common/data/DataBuffer", "", "Huawei.Hms.Common.Data.IDataBufferInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IDataBuffer : global::Huawei.Hms.Common.Api.IReleasable, global::Java.Lang.IIterable {

		int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBuffer']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "GetGetCountHandler:Huawei.Hms.Common.Data.IDataBufferInvoker, Huawei.Hms.Base")] get;
		}

		bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBuffer']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "GetIsClosedHandler:Huawei.Hms.Common.Data.IDataBufferInvoker, Huawei.Hms.Base")] get;
		}

		global::Android.OS.Bundle Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBuffer']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Landroid/os/Bundle;", "GetGetMetadataHandler:Huawei.Hms.Common.Data.IDataBufferInvoker, Huawei.Hms.Base")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBuffer']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Huawei.Hms.Common.Data.IDataBufferInvoker, Huawei.Hms.Base")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBuffer']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/Object;", "GetGet_IHandler:Huawei.Hms.Common.Data.IDataBufferInvoker, Huawei.Hms.Base")]
		global::Java.Lang.Object Get (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBuffer']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler:Huawei.Hms.Common.Data.IDataBufferInvoker, Huawei.Hms.Base")]
		global::Java.Util.IIterator Iterator ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBuffer']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Huawei.Hms.Common.Data.IDataBufferInvoker, Huawei.Hms.Base")]
		void Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBuffer']/method[@name='singleRefIterator' and count(parameter)=0]"
		[Register ("singleRefIterator", "()Ljava/util/Iterator;", "GetSingleRefIteratorHandler:Huawei.Hms.Common.Data.IDataBufferInvoker, Huawei.Hms.Base")]
		global::Java.Util.IIterator SingleRefIterator ();

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/data/DataBuffer", DoNotGenerateAcw=true)]
	internal partial class IDataBufferInvoker : global::Java.Lang.Object, IDataBuffer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/DataBuffer", typeof (IDataBufferInvoker));

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

		public static IDataBuffer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataBuffer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.common.data.DataBuffer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataBufferInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count;
		}
#pragma warning restore 0169

		IntPtr id_getCount;
		public unsafe int Count {
			get {
				if (id_getCount == IntPtr.Zero)
					id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClosed;
		}
#pragma warning restore 0169

		IntPtr id_isClosed;
		public unsafe bool IsClosed {
			get {
				if (id_isClosed == IntPtr.Zero)
					id_isClosed = JNIEnv.GetMethodID (class_ref, "isClosed", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isClosed);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Metadata);
		}
#pragma warning restore 0169

		IntPtr id_getMetadata;
		public unsafe global::Android.OS.Bundle Metadata {
			get {
				if (id_getMetadata == IntPtr.Zero)
					id_getMetadata = JNIEnv.GetMethodID (class_ref, "getMetadata", "()Landroid/os/Bundle;");
				return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMetadata), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (p0));
		}
#pragma warning restore 0169

		IntPtr id_get_I;
		public unsafe global::Java.Lang.Object Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		IntPtr id_iterator;
		public unsafe global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
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
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SingleRefIterator ());
		}
#pragma warning restore 0169

		IntPtr id_singleRefIterator;
		public unsafe global::Java.Util.IIterator SingleRefIterator ()
		{
			if (id_singleRefIterator == IntPtr.Zero)
				id_singleRefIterator = JNIEnv.GetMethodID (class_ref, "singleRefIterator", "()Ljava/util/Iterator;");
			return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_singleRefIterator), JniHandleOwnership.TransferLocalRef);
		}

	}

}
