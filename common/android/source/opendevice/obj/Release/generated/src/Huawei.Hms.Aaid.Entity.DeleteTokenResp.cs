using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Aaid.Entity {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenResp']"
	[global::Android.Runtime.Register ("com/huawei/hms/aaid/entity/DeleteTokenResp", DoNotGenerateAcw=true)]
	public partial class DeleteTokenResp : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/aaid/entity/DeleteTokenResp", typeof (DeleteTokenResp));
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

		protected DeleteTokenResp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenResp']/constructor[@name='DeleteTokenResp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DeleteTokenResp ()
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

		static Delegate cb_getRetCode;
#pragma warning disable 0169
		static Delegate GetGetRetCodeHandler ()
		{
			if (cb_getRetCode == null)
				cb_getRetCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRetCode);
			return cb_getRetCode;
		}

		static int n_GetRetCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RetCode;
		}
#pragma warning restore 0169

		static Delegate cb_setRetCode_I;
#pragma warning disable 0169
		static Delegate GetSetRetCode_IHandler ()
		{
			if (cb_setRetCode_I == null)
				cb_setRetCode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRetCode_I);
			return cb_setRetCode_I;
		}

		static void n_SetRetCode_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Aaid.Entity.DeleteTokenResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RetCode = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int RetCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenResp']/method[@name='getRetCode' and count(parameter)=0]"
			[Register ("getRetCode", "()I", "GetGetRetCodeHandler")]
			get {
				const string __id = "getRetCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.aaid.entity']/class[@name='DeleteTokenResp']/method[@name='setRetCode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRetCode", "(I)V", "GetSetRetCode_IHandler")]
			set {
				const string __id = "setRetCode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
