using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosGetNoticeReq']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/core/JosGetNoticeReq", DoNotGenerateAcw=true)]
	public partial class JosGetNoticeReq : global::Huawei.Hms.Support.Api.Entity.Core.JosBaseReq {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosGetNoticeReq']/field[@name='NOTICE_TYPE_CONN']"
		[Register ("NOTICE_TYPE_CONN")]
		public const int NoticeTypeConn = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosGetNoticeReq']/field[@name='NOTICE_TYPE_SIGN']"
		[Register ("NOTICE_TYPE_SIGN")]
		public const int NoticeTypeSign = (int) 1;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/core/JosGetNoticeReq", typeof (JosGetNoticeReq));
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

		protected JosGetNoticeReq (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosGetNoticeReq']/constructor[@name='JosGetNoticeReq' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JosGetNoticeReq ()
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

		static Delegate cb_getNoticeType;
#pragma warning disable 0169
		static Delegate GetGetNoticeTypeHandler ()
		{
			if (cb_getNoticeType == null)
				cb_getNoticeType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNoticeType);
			return cb_getNoticeType;
		}

		static int n_GetNoticeType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.JosGetNoticeReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NoticeType;
		}
#pragma warning restore 0169

		static Delegate cb_setNoticeType_I;
#pragma warning disable 0169
		static Delegate GetSetNoticeType_IHandler ()
		{
			if (cb_setNoticeType_I == null)
				cb_setNoticeType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetNoticeType_I);
			return cb_setNoticeType_I;
		}

		static void n_SetNoticeType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.JosGetNoticeReq> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NoticeType = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int NoticeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosGetNoticeReq']/method[@name='getNoticeType' and count(parameter)=0]"
			[Register ("getNoticeType", "()I", "GetGetNoticeTypeHandler")]
			get {
				const string __id = "getNoticeType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='JosGetNoticeReq']/method[@name='setNoticeType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNoticeType", "(I)V", "GetSetNoticeType_IHandler")]
			set {
				const string __id = "setNoticeType.(I)V";
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
