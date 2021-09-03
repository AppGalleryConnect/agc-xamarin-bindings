using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Data {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBufferObserver']"
	[Register ("com/huawei/hms/common/data/DataBufferObserver", "", "Huawei.Hms.Common.Data.IDataBufferObserverInvoker")]
	public partial interface IDataBufferObserver : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBufferObserver']/method[@name='onDataChanged' and count(parameter)=0]"
		[Register ("onDataChanged", "()V", "GetOnDataChangedHandler:Huawei.Hms.Common.Data.IDataBufferObserverInvoker, Huawei.Hms.Base")]
		void OnDataChanged ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBufferObserver']/method[@name='onDataRangeChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onDataRangeChanged", "(II)V", "GetOnDataRangeChanged_IIHandler:Huawei.Hms.Common.Data.IDataBufferObserverInvoker, Huawei.Hms.Base")]
		void OnDataRangeChanged (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBufferObserver']/method[@name='onDataRangeInserted' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onDataRangeInserted", "(II)V", "GetOnDataRangeInserted_IIHandler:Huawei.Hms.Common.Data.IDataBufferObserverInvoker, Huawei.Hms.Base")]
		void OnDataRangeInserted (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBufferObserver']/method[@name='onDataRangeMoved' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onDataRangeMoved", "(III)V", "GetOnDataRangeMoved_IIIHandler:Huawei.Hms.Common.Data.IDataBufferObserverInvoker, Huawei.Hms.Base")]
		void OnDataRangeMoved (int p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/interface[@name='DataBufferObserver']/method[@name='onDataRangeRemoved' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onDataRangeRemoved", "(II)V", "GetOnDataRangeRemoved_IIHandler:Huawei.Hms.Common.Data.IDataBufferObserverInvoker, Huawei.Hms.Base")]
		void OnDataRangeRemoved (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/common/data/DataBufferObserver", DoNotGenerateAcw=true)]
	internal partial class IDataBufferObserverInvoker : global::Java.Lang.Object, IDataBufferObserver {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/DataBufferObserver", typeof (IDataBufferObserverInvoker));

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

		public static IDataBufferObserver GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataBufferObserver> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.common.data.DataBufferObserver"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataBufferObserverInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDataChanged;
#pragma warning disable 0169
		static Delegate GetOnDataChangedHandler ()
		{
			if (cb_onDataChanged == null)
				cb_onDataChanged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDataChanged);
			return cb_onDataChanged;
		}

		static void n_OnDataChanged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBufferObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDataChanged ();
		}
#pragma warning restore 0169

		IntPtr id_onDataChanged;
		public unsafe void OnDataChanged ()
		{
			if (id_onDataChanged == IntPtr.Zero)
				id_onDataChanged = JNIEnv.GetMethodID (class_ref, "onDataChanged", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDataChanged);
		}

		static Delegate cb_onDataRangeChanged_II;
#pragma warning disable 0169
		static Delegate GetOnDataRangeChanged_IIHandler ()
		{
			if (cb_onDataRangeChanged_II == null)
				cb_onDataRangeChanged_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnDataRangeChanged_II);
			return cb_onDataRangeChanged_II;
		}

		static void n_OnDataRangeChanged_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBufferObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDataRangeChanged (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDataRangeChanged_II;
		public unsafe void OnDataRangeChanged (int p0, int p1)
		{
			if (id_onDataRangeChanged_II == IntPtr.Zero)
				id_onDataRangeChanged_II = JNIEnv.GetMethodID (class_ref, "onDataRangeChanged", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDataRangeChanged_II, __args);
		}

		static Delegate cb_onDataRangeInserted_II;
#pragma warning disable 0169
		static Delegate GetOnDataRangeInserted_IIHandler ()
		{
			if (cb_onDataRangeInserted_II == null)
				cb_onDataRangeInserted_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnDataRangeInserted_II);
			return cb_onDataRangeInserted_II;
		}

		static void n_OnDataRangeInserted_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBufferObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDataRangeInserted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDataRangeInserted_II;
		public unsafe void OnDataRangeInserted (int p0, int p1)
		{
			if (id_onDataRangeInserted_II == IntPtr.Zero)
				id_onDataRangeInserted_II = JNIEnv.GetMethodID (class_ref, "onDataRangeInserted", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDataRangeInserted_II, __args);
		}

		static Delegate cb_onDataRangeMoved_III;
#pragma warning disable 0169
		static Delegate GetOnDataRangeMoved_IIIHandler ()
		{
			if (cb_onDataRangeMoved_III == null)
				cb_onDataRangeMoved_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_V) n_OnDataRangeMoved_III);
			return cb_onDataRangeMoved_III;
		}

		static void n_OnDataRangeMoved_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBufferObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDataRangeMoved (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onDataRangeMoved_III;
		public unsafe void OnDataRangeMoved (int p0, int p1, int p2)
		{
			if (id_onDataRangeMoved_III == IntPtr.Zero)
				id_onDataRangeMoved_III = JNIEnv.GetMethodID (class_ref, "onDataRangeMoved", "(III)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDataRangeMoved_III, __args);
		}

		static Delegate cb_onDataRangeRemoved_II;
#pragma warning disable 0169
		static Delegate GetOnDataRangeRemoved_IIHandler ()
		{
			if (cb_onDataRangeRemoved_II == null)
				cb_onDataRangeRemoved_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_OnDataRangeRemoved_II);
			return cb_onDataRangeRemoved_II;
		}

		static void n_OnDataRangeRemoved_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.IDataBufferObserver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDataRangeRemoved (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onDataRangeRemoved_II;
		public unsafe void OnDataRangeRemoved (int p0, int p1)
		{
			if (id_onDataRangeRemoved_II == IntPtr.Zero)
				id_onDataRangeRemoved_II = JNIEnv.GetMethodID (class_ref, "onDataRangeRemoved", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDataRangeRemoved_II, __args);
		}

	}

}
