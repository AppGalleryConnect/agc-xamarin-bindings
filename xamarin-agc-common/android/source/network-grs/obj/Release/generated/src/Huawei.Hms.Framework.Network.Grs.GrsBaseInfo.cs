using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Network.Grs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/network/grs/GrsBaseInfo", DoNotGenerateAcw=true)]
	public partial class GrsBaseInfo : global::Java.Lang.Object, global::Java.Lang.ICloneable {

		[Register ("com/huawei/hms/framework/network/grs/GrsBaseInfo$CountryCodeSource", DoNotGenerateAcw=true)]
		public abstract class CountryCodeSource : Java.Lang.Object {

			internal CountryCodeSource ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/interface[@name='GrsBaseInfo.CountryCodeSource']/field[@name='APP']"
			[Register ("APP")]
			public const string App = (string) "APP";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/interface[@name='GrsBaseInfo.CountryCodeSource']/field[@name='LOCALE_INFO']"
			[Register ("LOCALE_INFO")]
			public const string LocaleInfo = (string) "LOCALE_INFO";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/interface[@name='GrsBaseInfo.CountryCodeSource']/field[@name='NETWORK_COUNTRY']"
			[Register ("NETWORK_COUNTRY")]
			public const string NetworkCountry = (string) "NETWORK_COUNTRY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/interface[@name='GrsBaseInfo.CountryCodeSource']/field[@name='SIM_COUNTRY']"
			[Register ("SIM_COUNTRY")]
			public const string SimCountry = (string) "SIM_COUNTRY";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/interface[@name='GrsBaseInfo.CountryCodeSource']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public const string Unknown = (string) "UNKNOWN";

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/interface[@name='GrsBaseInfo.CountryCodeSource']/field[@name='VENDOR_COUNTRY']"
			[Register ("VENDOR_COUNTRY")]
			public const string VendorCountry = (string) "VENDOR_COUNTRY";

			// The following are fields from: java.lang.annotation.Annotation

			// The following are fields from: Android.Runtime.IJavaObject

			// The following are fields from: System.IDisposable

			// The following are fields from: Java.Interop.IJavaPeerable
		}

		[Register ("com/huawei/hms/framework/network/grs/GrsBaseInfo$CountryCodeSource", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'CountryCodeSource' type. This type will be removed in a future release.", error: true)]
		public abstract class CountryCodeSourceConsts : CountryCodeSource {

			private CountryCodeSourceConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/interface[@name='GrsBaseInfo.CountryCodeSource']"
		[Register ("com/huawei/hms/framework/network/grs/GrsBaseInfo$CountryCodeSource", "", "Huawei.Hms.Framework.Network.Grs.GrsBaseInfo/ICountryCodeSourceInvoker")]
		public partial interface ICountryCodeSource : global::Java.Lang.Annotation.IAnnotation {

		}

		[global::Android.Runtime.Register ("com/huawei/hms/framework/network/grs/GrsBaseInfo$CountryCodeSource", DoNotGenerateAcw=true)]
		internal partial class ICountryCodeSourceInvoker : global::Java.Lang.Object, ICountryCodeSource {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/network/grs/GrsBaseInfo$CountryCodeSource", typeof (ICountryCodeSourceInvoker));

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

			public static ICountryCodeSource GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICountryCodeSource> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.framework.network.grs.GrsBaseInfo.CountryCodeSource"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICountryCodeSourceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo.ICountryCodeSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo.ICountryCodeSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo.ICountryCodeSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo.ICountryCodeSource> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/network/grs/GrsBaseInfo", typeof (GrsBaseInfo));
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

		protected GrsBaseInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/constructor[@name='GrsBaseInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GrsBaseInfo ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/constructor[@name='GrsBaseInfo' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe GrsBaseInfo (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

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

		static Delegate cb_getAndroidVersion;
#pragma warning disable 0169
		static Delegate GetGetAndroidVersionHandler ()
		{
			if (cb_getAndroidVersion == null)
				cb_getAndroidVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAndroidVersion);
			return cb_getAndroidVersion;
		}

		static IntPtr n_GetAndroidVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AndroidVersion);
		}
#pragma warning restore 0169

		static Delegate cb_setAndroidVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAndroidVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setAndroidVersion_Ljava_lang_String_ == null)
				cb_setAndroidVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAndroidVersion_Ljava_lang_String_);
			return cb_setAndroidVersion_Ljava_lang_String_;
		}

		static void n_SetAndroidVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AndroidVersion = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AndroidVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='getAndroidVersion' and count(parameter)=0]"
			[Register ("getAndroidVersion", "()Ljava/lang/String;", "GetGetAndroidVersionHandler")]
			get {
				const string __id = "getAndroidVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='setAndroidVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAndroidVersion", "(Ljava/lang/String;)V", "GetSetAndroidVersion_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAndroidVersion.(Ljava/lang/String;)V";
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

		static Delegate cb_getAppName;
#pragma warning disable 0169
		static Delegate GetGetAppNameHandler ()
		{
			if (cb_getAppName == null)
				cb_getAppName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAppName);
			return cb_getAppName;
		}

		static IntPtr n_GetAppName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppName);
		}
#pragma warning restore 0169

		static Delegate cb_setAppName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppName_Ljava_lang_String_Handler ()
		{
			if (cb_setAppName_Ljava_lang_String_ == null)
				cb_setAppName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAppName_Ljava_lang_String_);
			return cb_setAppName_Ljava_lang_String_;
		}

		static void n_SetAppName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string AppName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='getAppName' and count(parameter)=0]"
			[Register ("getAppName", "()Ljava/lang/String;", "GetGetAppNameHandler")]
			get {
				const string __id = "getAppName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='setAppName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppName", "(Ljava/lang/String;)V", "GetSetAppName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAppName.(Ljava/lang/String;)V";
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

		static Delegate cb_getCountrySource;
#pragma warning disable 0169
		static Delegate GetGetCountrySourceHandler ()
		{
			if (cb_getCountrySource == null)
				cb_getCountrySource = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCountrySource);
			return cb_getCountrySource;
		}

		static IntPtr n_GetCountrySource (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CountrySource);
		}
#pragma warning restore 0169

		static Delegate cb_setCountrySource_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCountrySource_Ljava_lang_String_Handler ()
		{
			if (cb_setCountrySource_Ljava_lang_String_ == null)
				cb_setCountrySource_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCountrySource_Ljava_lang_String_);
			return cb_setCountrySource_Ljava_lang_String_;
		}

		static void n_SetCountrySource_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CountrySource = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string CountrySource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='getCountrySource' and count(parameter)=0]"
			[Register ("getCountrySource", "()Ljava/lang/String;", "GetGetCountrySourceHandler")]
			get {
				const string __id = "getCountrySource.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='setCountrySource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCountrySource", "(Ljava/lang/String;)V", "GetSetCountrySource_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCountrySource.(Ljava/lang/String;)V";
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

		static Delegate cb_getDeviceModel;
#pragma warning disable 0169
		static Delegate GetGetDeviceModelHandler ()
		{
			if (cb_getDeviceModel == null)
				cb_getDeviceModel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDeviceModel);
			return cb_getDeviceModel;
		}

		static IntPtr n_GetDeviceModel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceModel);
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceModel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDeviceModel_Ljava_lang_String_Handler ()
		{
			if (cb_setDeviceModel_Ljava_lang_String_ == null)
				cb_setDeviceModel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDeviceModel_Ljava_lang_String_);
			return cb_setDeviceModel_Ljava_lang_String_;
		}

		static void n_SetDeviceModel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeviceModel = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string DeviceModel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='getDeviceModel' and count(parameter)=0]"
			[Register ("getDeviceModel", "()Ljava/lang/String;", "GetGetDeviceModelHandler")]
			get {
				const string __id = "getDeviceModel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='setDeviceModel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setDeviceModel", "(Ljava/lang/String;)V", "GetSetDeviceModel_Ljava_lang_String_Handler")]
			set {
				const string __id = "setDeviceModel.(Ljava/lang/String;)V";
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

		static Delegate cb_getIssueCountry;
#pragma warning disable 0169
		static Delegate GetGetIssueCountryHandler ()
		{
			if (cb_getIssueCountry == null)
				cb_getIssueCountry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIssueCountry);
			return cb_getIssueCountry;
		}

		static IntPtr n_GetIssueCountry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IssueCountry);
		}
#pragma warning restore 0169

		static Delegate cb_setIssueCountry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIssueCountry_Ljava_lang_String_Handler ()
		{
			if (cb_setIssueCountry_Ljava_lang_String_ == null)
				cb_setIssueCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIssueCountry_Ljava_lang_String_);
			return cb_setIssueCountry_Ljava_lang_String_;
		}

		static void n_SetIssueCountry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IssueCountry = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string IssueCountry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='getIssueCountry' and count(parameter)=0]"
			[Register ("getIssueCountry", "()Ljava/lang/String;", "GetGetIssueCountryHandler")]
			get {
				const string __id = "getIssueCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='setIssueCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIssueCountry", "(Ljava/lang/String;)V", "GetSetIssueCountry_Ljava_lang_String_Handler")]
			set {
				const string __id = "setIssueCountry.(Ljava/lang/String;)V";
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

		static Delegate cb_getRegCountry;
#pragma warning disable 0169
		static Delegate GetGetRegCountryHandler ()
		{
			if (cb_getRegCountry == null)
				cb_getRegCountry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRegCountry);
			return cb_getRegCountry;
		}

		static IntPtr n_GetRegCountry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RegCountry);
		}
#pragma warning restore 0169

		static Delegate cb_setRegCountry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRegCountry_Ljava_lang_String_Handler ()
		{
			if (cb_setRegCountry_Ljava_lang_String_ == null)
				cb_setRegCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRegCountry_Ljava_lang_String_);
			return cb_setRegCountry_Ljava_lang_String_;
		}

		static void n_SetRegCountry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RegCountry = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string RegCountry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='getRegCountry' and count(parameter)=0]"
			[Register ("getRegCountry", "()Ljava/lang/String;", "GetGetRegCountryHandler")]
			get {
				const string __id = "getRegCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='setRegCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRegCountry", "(Ljava/lang/String;)V", "GetSetRegCountry_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRegCountry.(Ljava/lang/String;)V";
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

		static Delegate cb_getRomVersion;
#pragma warning disable 0169
		static Delegate GetGetRomVersionHandler ()
		{
			if (cb_getRomVersion == null)
				cb_getRomVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRomVersion);
			return cb_getRomVersion;
		}

		static IntPtr n_GetRomVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RomVersion);
		}
#pragma warning restore 0169

		static Delegate cb_setRomVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRomVersion_Ljava_lang_String_Handler ()
		{
			if (cb_setRomVersion_Ljava_lang_String_ == null)
				cb_setRomVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRomVersion_Ljava_lang_String_);
			return cb_setRomVersion_Ljava_lang_String_;
		}

		static void n_SetRomVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RomVersion = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string RomVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='getRomVersion' and count(parameter)=0]"
			[Register ("getRomVersion", "()Ljava/lang/String;", "GetGetRomVersionHandler")]
			get {
				const string __id = "getRomVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='setRomVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRomVersion", "(Ljava/lang/String;)V", "GetSetRomVersion_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRomVersion.(Ljava/lang/String;)V";
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

		static Delegate cb_getSerCountry;
#pragma warning disable 0169
		static Delegate GetGetSerCountryHandler ()
		{
			if (cb_getSerCountry == null)
				cb_getSerCountry = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSerCountry);
			return cb_getSerCountry;
		}

		static IntPtr n_GetSerCountry (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SerCountry);
		}
#pragma warning restore 0169

		static Delegate cb_setSerCountry_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSerCountry_Ljava_lang_String_Handler ()
		{
			if (cb_setSerCountry_Ljava_lang_String_ == null)
				cb_setSerCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSerCountry_Ljava_lang_String_);
			return cb_setSerCountry_Ljava_lang_String_;
		}

		static void n_SetSerCountry_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SerCountry = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string SerCountry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='getSerCountry' and count(parameter)=0]"
			[Register ("getSerCountry", "()Ljava/lang/String;", "GetGetSerCountryHandler")]
			get {
				const string __id = "getSerCountry.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='setSerCountry' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSerCountry", "(Ljava/lang/String;)V", "GetSetSerCountry_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSerCountry.(Ljava/lang/String;)V";
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

		static Delegate cb_getUid;
#pragma warning disable 0169
		static Delegate GetGetUidHandler ()
		{
			if (cb_getUid == null)
				cb_getUid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUid);
			return cb_getUid;
		}

		static IntPtr n_GetUid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Uid);
		}
#pragma warning restore 0169

		static Delegate cb_setUid_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUid_Ljava_lang_String_Handler ()
		{
			if (cb_setUid_Ljava_lang_String_ == null)
				cb_setUid_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUid_Ljava_lang_String_);
			return cb_setUid_Ljava_lang_String_;
		}

		static void n_SetUid_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Uid = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Uid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='getUid' and count(parameter)=0]"
			[Register ("getUid", "()Ljava/lang/String;", "GetGetUidHandler")]
			get {
				const string __id = "getUid.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='setUid' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUid", "(Ljava/lang/String;)V", "GetSetUid_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUid.(Ljava/lang/String;)V";
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

		static Delegate cb_getVersionName;
#pragma warning disable 0169
		static Delegate GetGetVersionNameHandler ()
		{
			if (cb_getVersionName == null)
				cb_getVersionName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVersionName);
			return cb_getVersionName;
		}

		static IntPtr n_GetVersionName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VersionName);
		}
#pragma warning restore 0169

		static Delegate cb_setVersionName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVersionName_Ljava_lang_String_Handler ()
		{
			if (cb_setVersionName_Ljava_lang_String_ == null)
				cb_setVersionName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVersionName_Ljava_lang_String_);
			return cb_setVersionName_Ljava_lang_String_;
		}

		static void n_SetVersionName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VersionName = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string VersionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='getVersionName' and count(parameter)=0]"
			[Register ("getVersionName", "()Ljava/lang/String;", "GetGetVersionNameHandler")]
			get {
				const string __id = "getVersionName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='setVersionName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVersionName", "(Ljava/lang/String;)V", "GetSetVersionName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setVersionName.(Ljava/lang/String;)V";
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

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lcom/huawei/hms/framework/network/grs/GrsBaseInfo;", "GetCloneHandler")]
		public virtual unsafe global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo Clone ()
		{
			const string __id = "clone.()Lcom/huawei/hms/framework/network/grs/GrsBaseInfo;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_compare_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompare_Ljava_lang_Object_Handler ()
		{
			if (cb_compare_Ljava_lang_Object_ == null)
				cb_compare_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Compare_Ljava_lang_Object_);
			return cb_compare_Ljava_lang_Object_;
		}

		static bool n_Compare_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Compare (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='compare' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("compare", "(Ljava/lang/Object;)Z", "GetCompare_Ljava_lang_Object_Handler")]
		public virtual unsafe bool Compare (global::Java.Lang.Object p0)
		{
			const string __id = "compare.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_copy;
#pragma warning disable 0169
		static Delegate GetCopyHandler ()
		{
			if (cb_copy == null)
				cb_copy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Copy);
			return cb_copy;
		}

		static IntPtr n_Copy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/huawei/hms/framework/network/grs/GrsBaseInfo;", "GetCopyHandler")]
		public virtual unsafe global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo Copy ()
		{
			const string __id = "copy.()Lcom/huawei/hms/framework/network/grs/GrsBaseInfo;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getGrsParasKey_ZZLandroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetGrsParasKey_ZZLandroid_content_Context_Handler ()
		{
			if (cb_getGrsParasKey_ZZLandroid_content_Context_ == null)
				cb_getGrsParasKey_ZZLandroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZZL_L) n_GetGrsParasKey_ZZLandroid_content_Context_);
			return cb_getGrsParasKey_ZZLandroid_content_Context_;
		}

		static IntPtr n_GetGrsParasKey_ZZLandroid_content_Context_ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetGrsParasKey (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='getGrsParasKey' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='android.content.Context']]"
		[Register ("getGrsParasKey", "(ZZLandroid/content/Context;)Ljava/lang/String;", "GetGetGrsParasKey_ZZLandroid_content_Context_Handler")]
		public virtual unsafe string GetGrsParasKey (bool p0, bool p1, global::Android.Content.Context p2)
		{
			const string __id = "getGrsParasKey.(ZZLandroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_getGrsParasTag_ZZLandroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetGrsParasTag_ZZLandroid_content_Context_Handler ()
		{
			if (cb_getGrsParasTag_ZZLandroid_content_Context_ == null)
				cb_getGrsParasTag_ZZLandroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZZL_L) n_GetGrsParasTag_ZZLandroid_content_Context_);
			return cb_getGrsParasTag_ZZLandroid_content_Context_;
		}

		static IntPtr n_GetGrsParasTag_ZZLandroid_content_Context_ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetGrsParasTag (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='getGrsParasTag' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='android.content.Context']]"
		[Register ("getGrsParasTag", "(ZZLandroid/content/Context;)Ljava/lang/String;", "GetGetGrsParasTag_ZZLandroid_content_Context_Handler")]
		public virtual unsafe string GetGrsParasTag (bool p0, bool p1, global::Android.Content.Context p2)
		{
			const string __id = "getGrsParasTag.(ZZLandroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_getGrsReqParamJoint_ZZLjava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetGrsReqParamJoint_ZZLjava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_getGrsReqParamJoint_ZZLjava_lang_String_Landroid_content_Context_ == null)
				cb_getGrsReqParamJoint_ZZLjava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZZLL_L) n_GetGrsReqParamJoint_ZZLjava_lang_String_Landroid_content_Context_);
			return cb_getGrsReqParamJoint_ZZLjava_lang_String_Landroid_content_Context_;
		}

		static IntPtr n_GetGrsReqParamJoint_ZZLjava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, bool p0, bool p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetGrsReqParamJoint (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='getGrsReqParamJoint' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='boolean'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.content.Context']]"
		[Register ("getGrsReqParamJoint", "(ZZLjava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "GetGetGrsReqParamJoint_ZZLjava_lang_String_Landroid_content_Context_Handler")]
		public virtual unsafe string GetGrsReqParamJoint (bool p0, bool p1, string p2, global::Android.Content.Context p3)
		{
			const string __id = "getGrsReqParamJoint.(ZZLjava/lang/String;Landroid/content/Context;)Ljava/lang/String;";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		static Delegate cb_uniqueCode;
#pragma warning disable 0169
		static Delegate GetUniqueCodeHandler ()
		{
			if (cb_uniqueCode == null)
				cb_uniqueCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_UniqueCode);
			return cb_uniqueCode;
		}

		static int n_UniqueCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Network.Grs.GrsBaseInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UniqueCode ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.network.grs']/class[@name='GrsBaseInfo']/method[@name='uniqueCode' and count(parameter)=0]"
		[Register ("uniqueCode", "()I", "GetUniqueCodeHandler")]
		public virtual unsafe int UniqueCode ()
		{
			const string __id = "uniqueCode.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
