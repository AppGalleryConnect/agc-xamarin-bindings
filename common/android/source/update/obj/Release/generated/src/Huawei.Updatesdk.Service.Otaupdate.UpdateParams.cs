using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Updatesdk.Service.Otaupdate {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams']"
	[global::Android.Runtime.Register ("com/huawei/updatesdk/service/otaupdate/UpdateParams", DoNotGenerateAcw=true)]
	public partial class UpdateParams : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams.Builder']"
		[global::Android.Runtime.Register ("com/huawei/updatesdk/service/otaupdate/UpdateParams$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/updatesdk/service/otaupdate/UpdateParams$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams.Builder']/constructor[@name='UpdateParams.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/huawei/updatesdk/service/otaupdate/UpdateParams;", "")]
			public unsafe global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams Build ()
			{
				const string __id = "build.()Lcom/huawei/updatesdk/service/otaupdate/UpdateParams;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams.Builder']/method[@name='setIsShowImmediate' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setIsShowImmediate", "(Z)Lcom/huawei/updatesdk/service/otaupdate/UpdateParams$Builder;", "")]
			public unsafe global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams.Builder SetIsShowImmediate (bool p0)
			{
				const string __id = "setIsShowImmediate.(Z)Lcom/huawei/updatesdk/service/otaupdate/UpdateParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams.Builder']/method[@name='setMinIntervalDay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMinIntervalDay", "(I)Lcom/huawei/updatesdk/service/otaupdate/UpdateParams$Builder;", "")]
			public unsafe global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams.Builder SetMinIntervalDay (int p0)
			{
				const string __id = "setMinIntervalDay.(I)Lcom/huawei/updatesdk/service/otaupdate/UpdateParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams.Builder']/method[@name='setMustBtnOne' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMustBtnOne", "(Z)Lcom/huawei/updatesdk/service/otaupdate/UpdateParams$Builder;", "")]
			public unsafe global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams.Builder SetMustBtnOne (bool p0)
			{
				const string __id = "setMustBtnOne.(Z)Lcom/huawei/updatesdk/service/otaupdate/UpdateParams$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams.Builder']/method[@name='setPackageList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setPackageList", "(Ljava/util/List;)Lcom/huawei/updatesdk/service/otaupdate/UpdateParams$Builder;", "")]
			public unsafe global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams.Builder SetPackageList (global::System.Collections.Generic.IList<string> p0)
			{
				const string __id = "setPackageList.(Ljava/util/List;)Lcom/huawei/updatesdk/service/otaupdate/UpdateParams$Builder;";
				IntPtr native_p0 = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams.Builder']/method[@name='setServiceZone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServiceZone", "(Ljava/lang/String;)Lcom/huawei/updatesdk/service/otaupdate/UpdateParams$Builder;", "")]
			public unsafe global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams.Builder SetServiceZone (string p0)
			{
				const string __id = "setServiceZone.(Ljava/lang/String;)Lcom/huawei/updatesdk/service/otaupdate/UpdateParams$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams.Builder']/method[@name='setTargetPkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTargetPkgName", "(Ljava/lang/String;)Lcom/huawei/updatesdk/service/otaupdate/UpdateParams$Builder;", "")]
			public unsafe global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams.Builder SetTargetPkgName (string p0)
			{
				const string __id = "setTargetPkgName.(Ljava/lang/String;)Lcom/huawei/updatesdk/service/otaupdate/UpdateParams$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/updatesdk/service/otaupdate/UpdateParams", typeof (UpdateParams));
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

		protected UpdateParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isMustBtnOne;
#pragma warning disable 0169
		static Delegate GetIsMustBtnOneHandler ()
		{
			if (cb_isMustBtnOne == null)
				cb_isMustBtnOne = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMustBtnOne);
			return cb_isMustBtnOne;
		}

		static bool n_IsMustBtnOne (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMustBtnOne;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMustBtnOne {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams']/method[@name='isMustBtnOne' and count(parameter)=0]"
			[Register ("isMustBtnOne", "()Z", "GetIsMustBtnOneHandler")]
			get {
				const string __id = "isMustBtnOne.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isShowImmediate;
#pragma warning disable 0169
		static Delegate GetIsShowImmediateHandler ()
		{
			if (cb_isShowImmediate == null)
				cb_isShowImmediate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsShowImmediate);
			return cb_isShowImmediate;
		}

		static bool n_IsShowImmediate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShowImmediate;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsShowImmediate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams']/method[@name='isShowImmediate' and count(parameter)=0]"
			[Register ("isShowImmediate", "()Z", "GetIsShowImmediateHandler")]
			get {
				const string __id = "isShowImmediate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMinIntervalDay;
#pragma warning disable 0169
		static Delegate GetGetMinIntervalDayHandler ()
		{
			if (cb_getMinIntervalDay == null)
				cb_getMinIntervalDay = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMinIntervalDay);
			return cb_getMinIntervalDay;
		}

		static int n_GetMinIntervalDay (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinIntervalDay;
		}
#pragma warning restore 0169

		public virtual unsafe int MinIntervalDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams']/method[@name='getMinIntervalDay' and count(parameter)=0]"
			[Register ("getMinIntervalDay", "()I", "GetGetMinIntervalDayHandler")]
			get {
				const string __id = "getMinIntervalDay.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPackageList;
#pragma warning disable 0169
		static Delegate GetGetPackageListHandler ()
		{
			if (cb_getPackageList == null)
				cb_getPackageList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPackageList);
			return cb_getPackageList;
		}

		static IntPtr n_GetPackageList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.PackageList);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> PackageList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams']/method[@name='getPackageList' and count(parameter)=0]"
			[Register ("getPackageList", "()Ljava/util/List;", "GetGetPackageListHandler")]
			get {
				const string __id = "getPackageList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getServiceZone;
#pragma warning disable 0169
		static Delegate GetGetServiceZoneHandler ()
		{
			if (cb_getServiceZone == null)
				cb_getServiceZone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetServiceZone);
			return cb_getServiceZone;
		}

		static IntPtr n_GetServiceZone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceZone);
		}
#pragma warning restore 0169

		public virtual unsafe string ServiceZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams']/method[@name='getServiceZone' and count(parameter)=0]"
			[Register ("getServiceZone", "()Ljava/lang/String;", "GetGetServiceZoneHandler")]
			get {
				const string __id = "getServiceZone.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTargetPkgName;
#pragma warning disable 0169
		static Delegate GetGetTargetPkgNameHandler ()
		{
			if (cb_getTargetPkgName == null)
				cb_getTargetPkgName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTargetPkgName);
			return cb_getTargetPkgName;
		}

		static IntPtr n_GetTargetPkgName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TargetPkgName);
		}
#pragma warning restore 0169

		public virtual unsafe string TargetPkgName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams']/method[@name='getTargetPkgName' and count(parameter)=0]"
			[Register ("getTargetPkgName", "()Ljava/lang/String;", "GetGetTargetPkgNameHandler")]
			get {
				const string __id = "getTargetPkgName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_resetParamList;
#pragma warning disable 0169
		static Delegate GetResetParamListHandler ()
		{
			if (cb_resetParamList == null)
				cb_resetParamList = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ResetParamList);
			return cb_resetParamList;
		}

		static void n_ResetParamList (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Updatesdk.Service.Otaupdate.UpdateParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetParamList ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.otaupdate']/class[@name='UpdateParams']/method[@name='resetParamList' and count(parameter)=0]"
		[Register ("resetParamList", "()V", "GetResetParamListHandler")]
		public virtual unsafe void ResetParamList ()
		{
			const string __id = "resetParamList.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
