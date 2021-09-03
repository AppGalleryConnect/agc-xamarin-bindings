using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Network.Grs {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/interface[@name='IQueryUrlsCallBack']"
	[Register ("com/huawei/hms/framework/network/grs/IQueryUrlsCallBack", "", "Huawei.Hms.Framework.Network.Grs.IQueryUrlsCallBackInvoker")]
	public partial interface IQueryUrlsCallBack : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/interface[@name='IQueryUrlsCallBack']/method[@name='onCallBackFail' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("onCallBackFail", "(I)V", "GetOnCallBackFail_IHandler:Huawei.Hms.Framework.Network.Grs.IQueryUrlsCallBackInvoker, Huawei.Hms.NetworkGrs")]
		void OnCallBackFail (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/interface[@name='IQueryUrlsCallBack']/method[@name='onCallBackSuccess' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("onCallBackSuccess", "(Ljava/util/Map;)V", "GetOnCallBackSuccess_Ljava_util_Map_Handler:Huawei.Hms.Framework.Network.Grs.IQueryUrlsCallBackInvoker, Huawei.Hms.NetworkGrs")]
		void OnCallBackSuccess (global::System.Collections.Generic.IDictionary<string, string> p0);

	}

	[global::Android.Runtime.Register ("com/huawei/hms/framework/network/grs/IQueryUrlsCallBack", DoNotGenerateAcw=true)]
	internal partial class IQueryUrlsCallBackInvoker : global::Java.Lang.Object, IQueryUrlsCallBack {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/network/grs/IQueryUrlsCallBack", typeof (IQueryUrlsCallBackInvoker));

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

		public static IQueryUrlsCallBack GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IQueryUrlsCallBack> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.framework.network.grs.IQueryUrlsCallBack"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IQueryUrlsCallBackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCallBackFail_I;
#pragma warning disable 0169
		static Delegate GetOnCallBackFail_IHandler ()
		{
			if (cb_onCallBackFail_I == null)
				cb_onCallBackFail_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnCallBackFail_I);
			return cb_onCallBackFail_I;
		}

		static void n_OnCallBackFail_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.IQueryUrlsCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCallBackFail (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCallBackFail_I;
		public unsafe void OnCallBackFail (int p0)
		{
			if (id_onCallBackFail_I == IntPtr.Zero)
				id_onCallBackFail_I = JNIEnv.GetMethodID (class_ref, "onCallBackFail", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCallBackFail_I, __args);
		}

		static Delegate cb_onCallBackSuccess_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetOnCallBackSuccess_Ljava_util_Map_Handler ()
		{
			if (cb_onCallBackSuccess_Ljava_util_Map_ == null)
				cb_onCallBackSuccess_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCallBackSuccess_Ljava_util_Map_);
			return cb_onCallBackSuccess_Ljava_util_Map_;
		}

		static void n_OnCallBackSuccess_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.IQueryUrlsCallBack> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCallBackSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onCallBackSuccess_Ljava_util_Map_;
		public unsafe void OnCallBackSuccess (global::System.Collections.Generic.IDictionary<string, string> p0)
		{
			if (id_onCallBackSuccess_Ljava_util_Map_ == IntPtr.Zero)
				id_onCallBackSuccess_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "onCallBackSuccess", "(Ljava/util/Map;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCallBackSuccess_Ljava_util_Map_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
