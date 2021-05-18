using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Huawei.Updatesdk.Service.Appmgr.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']"
	[global::Android.Runtime.Register ("com/huawei/updatesdk/service/appmgr/bean/AppInfoAdapter", DoNotGenerateAcw=true)]
	public partial class AppInfoAdapter : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/updatesdk/service/appmgr/bean/AppInfoAdapter", typeof (AppInfoAdapter));
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

		protected AppInfoAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/constructor[@name='AppInfoAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppInfoAdapter ()
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

		static Delegate cb_getAppId;
#pragma warning disable 0169
		static Delegate GetGetAppIdHandler ()
		{
			if (cb_getAppId == null)
				cb_getAppId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAppId);
			return cb_getAppId;
		}

		static IntPtr n_GetAppId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppId);
		}
#pragma warning restore 0169

		static Delegate cb_setAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppId_Ljava_lang_String_Handler ()
		{
			if (cb_setAppId_Ljava_lang_String_ == null)
				cb_setAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAppId_Ljava_lang_String_);
			return cb_setAppId_Ljava_lang_String_;
		}

		static void n_SetAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AppId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='getAppId' and count(parameter)=0]"
			[Register ("getAppId", "()Ljava/lang/String;", "GetGetAppIdHandler")]
			get {
				const string __id = "getAppId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='setAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppId", "(Ljava/lang/String;)V", "GetSetAppId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAppId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAppStorePkgName;
#pragma warning disable 0169
		static Delegate GetGetAppStorePkgNameHandler ()
		{
			if (cb_getAppStorePkgName == null)
				cb_getAppStorePkgName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAppStorePkgName);
			return cb_getAppStorePkgName;
		}

		static IntPtr n_GetAppStorePkgName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppStorePkgName);
		}
#pragma warning restore 0169

		static Delegate cb_setAppStorePkgName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppStorePkgName_Ljava_lang_String_Handler ()
		{
			if (cb_setAppStorePkgName_Ljava_lang_String_ == null)
				cb_setAppStorePkgName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAppStorePkgName_Ljava_lang_String_);
			return cb_setAppStorePkgName_Ljava_lang_String_;
		}

		static void n_SetAppStorePkgName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppStorePkgName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AppStorePkgName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='getAppStorePkgName' and count(parameter)=0]"
			[Register ("getAppStorePkgName", "()Ljava/lang/String;", "GetGetAppStorePkgNameHandler")]
			get {
				const string __id = "getAppStorePkgName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='setAppStorePkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppStorePkgName", "(Ljava/lang/String;)V", "GetSetAppStorePkgName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAppStorePkgName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBusiness;
#pragma warning disable 0169
		static Delegate GetGetBusinessHandler ()
		{
			if (cb_getBusiness == null)
				cb_getBusiness = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBusiness);
			return cb_getBusiness;
		}

		static IntPtr n_GetBusiness (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Business);
		}
#pragma warning restore 0169

		static Delegate cb_setBusiness_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBusiness_Ljava_lang_String_Handler ()
		{
			if (cb_setBusiness_Ljava_lang_String_ == null)
				cb_setBusiness_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetBusiness_Ljava_lang_String_);
			return cb_setBusiness_Ljava_lang_String_;
		}

		static void n_SetBusiness_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Business = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Business {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='getBusiness' and count(parameter)=0]"
			[Register ("getBusiness", "()Ljava/lang/String;", "GetGetBusinessHandler")]
			get {
				const string __id = "getBusiness.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='setBusiness' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBusiness", "(Ljava/lang/String;)V", "GetSetBusiness_Ljava_lang_String_Handler")]
			set {
				const string __id = "setBusiness.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCarrierId;
#pragma warning disable 0169
		static Delegate GetGetCarrierIdHandler ()
		{
			if (cb_getCarrierId == null)
				cb_getCarrierId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCarrierId);
			return cb_getCarrierId;
		}

		static IntPtr n_GetCarrierId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CarrierId);
		}
#pragma warning restore 0169

		static Delegate cb_setCarrierId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCarrierId_Ljava_lang_String_Handler ()
		{
			if (cb_setCarrierId_Ljava_lang_String_ == null)
				cb_setCarrierId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCarrierId_Ljava_lang_String_);
			return cb_setCarrierId_Ljava_lang_String_;
		}

		static void n_SetCarrierId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CarrierId = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string CarrierId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='getCarrierId' and count(parameter)=0]"
			[Register ("getCarrierId", "()Ljava/lang/String;", "GetGetCarrierIdHandler")]
			get {
				const string __id = "getCarrierId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='setCarrierId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCarrierId", "(Ljava/lang/String;)V", "GetSetCarrierId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCarrierId.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinIntervalDay;
		}
#pragma warning restore 0169

		static Delegate cb_setMinIntervalDay_I;
#pragma warning disable 0169
		static Delegate GetSetMinIntervalDay_IHandler ()
		{
			if (cb_setMinIntervalDay_I == null)
				cb_setMinIntervalDay_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMinIntervalDay_I);
			return cb_setMinIntervalDay_I;
		}

		static void n_SetMinIntervalDay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinIntervalDay = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int MinIntervalDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='getMinIntervalDay' and count(parameter)=0]"
			[Register ("getMinIntervalDay", "()I", "GetGetMinIntervalDayHandler")]
			get {
				const string __id = "getMinIntervalDay.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='setMinIntervalDay' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMinIntervalDay", "(I)V", "GetSetMinIntervalDay_IHandler")]
			set {
				const string __id = "setMinIntervalDay.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MustBtnOne;
		}
#pragma warning restore 0169

		static Delegate cb_setMustBtnOne_Z;
#pragma warning disable 0169
		static Delegate GetSetMustBtnOne_ZHandler ()
		{
			if (cb_setMustBtnOne_Z == null)
				cb_setMustBtnOne_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetMustBtnOne_Z);
			return cb_setMustBtnOne_Z;
		}

		static void n_SetMustBtnOne_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MustBtnOne = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool MustBtnOne {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='isMustBtnOne' and count(parameter)=0]"
			[Register ("isMustBtnOne", "()Z", "GetIsMustBtnOneHandler")]
			get {
				const string __id = "isMustBtnOne.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='setMustBtnOne' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setMustBtnOne", "(Z)V", "GetSetMustBtnOne_ZHandler")]
			set {
				const string __id = "setMustBtnOne.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.PackageList);
		}
#pragma warning restore 0169

		static Delegate cb_setPackageList_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetPackageList_Ljava_util_List_Handler ()
		{
			if (cb_setPackageList_Ljava_util_List_ == null)
				cb_setPackageList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPackageList_Ljava_util_List_);
			return cb_setPackageList_Ljava_util_List_;
		}

		static void n_SetPackageList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<string>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PackageList = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> PackageList {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='getPackageList' and count(parameter)=0]"
			[Register ("getPackageList", "()Ljava/util/List;", "GetGetPackageListHandler")]
			get {
				const string __id = "getPackageList.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='setPackageList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setPackageList", "(Ljava/util/List;)V", "GetSetPackageList_Ljava_util_List_Handler")]
			set {
				const string __id = "setPackageList.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ServiceZone);
		}
#pragma warning restore 0169

		static Delegate cb_setServiceZone_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetServiceZone_Ljava_lang_String_Handler ()
		{
			if (cb_setServiceZone_Ljava_lang_String_ == null)
				cb_setServiceZone_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetServiceZone_Ljava_lang_String_);
			return cb_setServiceZone_Ljava_lang_String_;
		}

		static void n_SetServiceZone_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ServiceZone = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string ServiceZone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='getServiceZone' and count(parameter)=0]"
			[Register ("getServiceZone", "()Ljava/lang/String;", "GetGetServiceZoneHandler")]
			get {
				const string __id = "getServiceZone.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='setServiceZone' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setServiceZone", "(Ljava/lang/String;)V", "GetSetServiceZone_Ljava_lang_String_Handler")]
			set {
				const string __id = "setServiceZone.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowImmediate;
		}
#pragma warning restore 0169

		static Delegate cb_setShowImmediate_Z;
#pragma warning disable 0169
		static Delegate GetSetShowImmediate_ZHandler ()
		{
			if (cb_setShowImmediate_Z == null)
				cb_setShowImmediate_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetShowImmediate_Z);
			return cb_setShowImmediate_Z;
		}

		static void n_SetShowImmediate_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowImmediate = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool ShowImmediate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='isShowImmediate' and count(parameter)=0]"
			[Register ("isShowImmediate", "()Z", "GetIsShowImmediateHandler")]
			get {
				const string __id = "isShowImmediate.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='setShowImmediate' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowImmediate", "(Z)V", "GetSetShowImmediate_ZHandler")]
			set {
				const string __id = "setShowImmediate.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TargetPkgName);
		}
#pragma warning restore 0169

		static Delegate cb_setTargetPkgName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTargetPkgName_Ljava_lang_String_Handler ()
		{
			if (cb_setTargetPkgName_Ljava_lang_String_ == null)
				cb_setTargetPkgName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTargetPkgName_Ljava_lang_String_);
			return cb_setTargetPkgName_Ljava_lang_String_;
		}

		static void n_SetTargetPkgName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Updatesdk.Service.Appmgr.Bean.AppInfoAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.TargetPkgName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string TargetPkgName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='getTargetPkgName' and count(parameter)=0]"
			[Register ("getTargetPkgName", "()Ljava/lang/String;", "GetGetTargetPkgNameHandler")]
			get {
				const string __id = "getTargetPkgName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.updatesdk.service.appmgr.bean']/class[@name='AppInfoAdapter']/method[@name='setTargetPkgName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTargetPkgName", "(Ljava/lang/String;)V", "GetSetTargetPkgName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTargetPkgName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

	}
}
