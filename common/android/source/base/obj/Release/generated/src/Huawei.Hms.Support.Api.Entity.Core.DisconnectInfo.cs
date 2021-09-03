using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='DisconnectInfo']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/core/DisconnectInfo", DoNotGenerateAcw=true)]
	public partial class DisconnectInfo : global::Java.Lang.Object, global::Huawei.Hms.Core.Aidl.IMessageEntity {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/core/DisconnectInfo", typeof (DisconnectInfo));
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

		protected DisconnectInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='DisconnectInfo']/constructor[@name='DisconnectInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DisconnectInfo ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='DisconnectInfo']/constructor[@name='DisconnectInfo' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.huawei.hms.support.api.entity.auth.Scope&gt;'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/util/List;)V", "")]
		public unsafe DisconnectInfo (global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope> p0, global::System.Collections.Generic.IList<string> p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_getApiNameList;
#pragma warning disable 0169
		static Delegate GetGetApiNameListHandler ()
		{
			if (cb_getApiNameList == null)
				cb_getApiNameList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApiNameList);
			return cb_getApiNameList;
		}

		static IntPtr n_GetApiNameList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.DisconnectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.ApiNameList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> ApiNameList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='DisconnectInfo']/method[@name='getApiNameList' and count(parameter)=0]"
			[Register ("getApiNameList", "()Ljava/util/List;", "GetGetApiNameListHandler")]
			get {
				const string __id = "getApiNameList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScopeList;
#pragma warning disable 0169
		static Delegate GetGetScopeListHandler ()
		{
			if (cb_getScopeList == null)
				cb_getScopeList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScopeList);
			return cb_getScopeList;
		}

		static IntPtr n_GetScopeList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Core.DisconnectInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (__this.ScopeList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope> ScopeList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.core']/class[@name='DisconnectInfo']/method[@name='getScopeList' and count(parameter)=0]"
			[Register ("getScopeList", "()Ljava/util/List;", "GetGetScopeListHandler")]
			get {
				const string __id = "getScopeList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
