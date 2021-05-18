using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Opendevice {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='OaidResp']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/opendevice/OaidResp", DoNotGenerateAcw=true)]
	public partial class OaidResp : global::Huawei.Hms.Core.Aidl.AbstractMessageEntity {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='OaidResp']/field[@name='isTrackLimited']"
		[Register ("isTrackLimited")]
		public bool IsTrackLimited {
			get {
				const string __id = "isTrackLimited.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isTrackLimited.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/opendevice/OaidResp", typeof (OaidResp));
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

		protected OaidResp (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='OaidResp']/constructor[@name='OaidResp' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OaidResp ()
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

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Opendevice.OaidResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		static Delegate cb_setId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetId_Ljava_lang_String_Handler ()
		{
			if (cb_setId_Ljava_lang_String_ == null)
				cb_setId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetId_Ljava_lang_String_);
			return cb_setId_Ljava_lang_String_;
		}

		static void n_SetId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Opendevice.OaidResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Id = p0;
		}
#pragma warning restore 0169

		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='OaidResp']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='OaidResp']/method[@name='setId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setId", "(Ljava/lang/String;)V", "GetSetId_Ljava_lang_String_Handler")]
			set {
				const string __id = "setId.(Ljava/lang/String;)V";
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

		static Delegate cb_getSettingIntent;
#pragma warning disable 0169
		static Delegate GetGetSettingIntentHandler ()
		{
			if (cb_getSettingIntent == null)
				cb_getSettingIntent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSettingIntent);
			return cb_getSettingIntent;
		}

		static IntPtr n_GetSettingIntent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Opendevice.OaidResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SettingIntent);
		}
#pragma warning restore 0169

		static Delegate cb_setSettingIntent_Landroid_app_PendingIntent_;
#pragma warning disable 0169
		static Delegate GetSetSettingIntent_Landroid_app_PendingIntent_Handler ()
		{
			if (cb_setSettingIntent_Landroid_app_PendingIntent_ == null)
				cb_setSettingIntent_Landroid_app_PendingIntent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSettingIntent_Landroid_app_PendingIntent_);
			return cb_setSettingIntent_Landroid_app_PendingIntent_;
		}

		static void n_SetSettingIntent_Landroid_app_PendingIntent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Opendevice.OaidResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SettingIntent = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.App.PendingIntent SettingIntent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='OaidResp']/method[@name='getSettingIntent' and count(parameter)=0]"
			[Register ("getSettingIntent", "()Landroid/app/PendingIntent;", "GetGetSettingIntentHandler")]
			get {
				const string __id = "getSettingIntent.()Landroid/app/PendingIntent;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='OaidResp']/method[@name='setSettingIntent' and count(parameter)=1 and parameter[1][@type='android.app.PendingIntent']]"
			[Register ("setSettingIntent", "(Landroid/app/PendingIntent;)V", "GetSetSettingIntent_Landroid_app_PendingIntent_Handler")]
			set {
				const string __id = "setSettingIntent.(Landroid/app/PendingIntent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_isTrackLimited;
#pragma warning disable 0169
		static Delegate GetIsTrackLimitedHandler ()
		{
			if (cb_isTrackLimited == null)
				cb_isTrackLimited = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTrackLimited);
			return cb_isTrackLimited;
		}

		static bool n_IsTrackLimited (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Opendevice.OaidResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackLimited;
		}
#pragma warning restore 0169

		static Delegate cb_setTrackLimited_Z;
#pragma warning disable 0169
		static Delegate GetSetTrackLimited_ZHandler ()
		{
			if (cb_setTrackLimited_Z == null)
				cb_setTrackLimited_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetTrackLimited_Z);
			return cb_setTrackLimited_Z;
		}

		static void n_SetTrackLimited_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Entity.Opendevice.OaidResp> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TrackLimited = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool TrackLimited {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='OaidResp']/method[@name='isTrackLimited' and count(parameter)=0]"
			[Register ("isTrackLimited", "()Z", "GetIsTrackLimitedHandler")]
			get {
				const string __id = "isTrackLimited.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.entity.opendevice']/class[@name='OaidResp']/method[@name='setTrackLimited' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTrackLimited", "(Z)V", "GetSetTrackLimited_ZHandler")]
			set {
				const string __id = "setTrackLimited.(Z)V";
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
