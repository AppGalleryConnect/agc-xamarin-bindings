using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']"
	[global::Android.Runtime.Register ("com/huawei/hms/utils/HMSPackageManager", DoNotGenerateAcw=true)]
	public partial class HMSPackageManager : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/field[@name='d']"
		[Register ("d")]
		public string D {
			get {
				const string __id = "d.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "d.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/field[@name='e']"
		[Register ("e")]
		public int E {
			get {
				const string __id = "e.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "e.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/field[@name='f']"
		[Register ("f")]
		public static global::Huawei.Hms.Utils.HMSPackageManager F {
			get {
				const string __id = "f.Lcom/huawei/hms/utils/HMSPackageManager;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.HMSPackageManager> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "f.Lcom/huawei/hms/utils/HMSPackageManager;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/field[@name='g']"
		[Register ("g")]
		public static global::Java.Lang.Object G {
			get {
				const string __id = "g.Ljava/lang/Object;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/field[@name='h']"
		[Register ("h")]
		public static global::Java.Lang.Object H {
			get {
				const string __id = "h.Ljava/lang/Object;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/HMSPackageManager", typeof (HMSPackageManager));
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

		protected HMSPackageManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/constructor[@name='HMSPackageManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe HMSPackageManager (global::Android.Content.Context p0)
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

		static Delegate cb_getHMSFingerprint;
#pragma warning disable 0169
		static Delegate GetGetHMSFingerprintHandler ()
		{
			if (cb_getHMSFingerprint == null)
				cb_getHMSFingerprint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHMSFingerprint);
			return cb_getHMSFingerprint;
		}

		static IntPtr n_GetHMSFingerprint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.HMSPackageManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HMSFingerprint);
		}
#pragma warning restore 0169

		public virtual unsafe string HMSFingerprint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/method[@name='getHMSFingerprint' and count(parameter)=0]"
			[Register ("getHMSFingerprint", "()Ljava/lang/String;", "GetGetHMSFingerprintHandler")]
			get {
				const string __id = "getHMSFingerprint.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHMSPackageName;
#pragma warning disable 0169
		static Delegate GetGetHMSPackageNameHandler ()
		{
			if (cb_getHMSPackageName == null)
				cb_getHMSPackageName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHMSPackageName);
			return cb_getHMSPackageName;
		}

		static IntPtr n_GetHMSPackageName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.HMSPackageManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HMSPackageName);
		}
#pragma warning restore 0169

		public virtual unsafe string HMSPackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/method[@name='getHMSPackageName' and count(parameter)=0]"
			[Register ("getHMSPackageName", "()Ljava/lang/String;", "GetGetHMSPackageNameHandler")]
			get {
				const string __id = "getHMSPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHMSPackageStates;
#pragma warning disable 0169
		static Delegate GetGetHMSPackageStatesHandler ()
		{
			if (cb_getHMSPackageStates == null)
				cb_getHMSPackageStates = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHMSPackageStates);
			return cb_getHMSPackageStates;
		}

		static IntPtr n_GetHMSPackageStates (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.HMSPackageManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HMSPackageStates);
		}
#pragma warning restore 0169

		public virtual unsafe global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates HMSPackageStates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/method[@name='getHMSPackageStates' and count(parameter)=0]"
			[Register ("getHMSPackageStates", "()Lcom/huawei/hms/utils/PackageManagerHelper$PackageStates;", "GetGetHMSPackageStatesHandler")]
			get {
				const string __id = "getHMSPackageStates.()Lcom/huawei/hms/utils/PackageManagerHelper$PackageStates;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHmsVersionCode;
#pragma warning disable 0169
		static Delegate GetGetHmsVersionCodeHandler ()
		{
			if (cb_getHmsVersionCode == null)
				cb_getHmsVersionCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHmsVersionCode);
			return cb_getHmsVersionCode;
		}

		static int n_GetHmsVersionCode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.HMSPackageManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HmsVersionCode;
		}
#pragma warning restore 0169

		public virtual unsafe int HmsVersionCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/method[@name='getHmsVersionCode' and count(parameter)=0]"
			[Register ("getHmsVersionCode", "()I", "GetGetHmsVersionCodeHandler")]
			get {
				const string __id = "getHmsVersionCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()Landroid/util/Pair;", "")]
		public unsafe global::Android.Util.Pair A ()
		{
			const string __id = "a.()Landroid/util/Pair;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Util.Pair> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/method[@name='a' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public unsafe bool A (string p0, string p1, string p2)
		{
			const string __id = "a.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/method[@name='b' and count(parameter)=0]"
		[Register ("b", "()V", "")]
		public unsafe void B ()
		{
			const string __id = "b.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()Z", "")]
		public unsafe bool C ()
		{
			const string __id = "c.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/huawei/hms/utils/HMSPackageManager;", "")]
		public static unsafe global::Huawei.Hms.Utils.HMSPackageManager GetInstance (global::Android.Content.Context p0)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/huawei/hms/utils/HMSPackageManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.HMSPackageManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_hmsVerHigherThan_I;
#pragma warning disable 0169
		static Delegate GetHmsVerHigherThan_IHandler ()
		{
			if (cb_hmsVerHigherThan_I == null)
				cb_hmsVerHigherThan_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_HmsVerHigherThan_I);
			return cb_hmsVerHigherThan_I;
		}

		static bool n_HmsVerHigherThan_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.HMSPackageManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HmsVerHigherThan (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/method[@name='hmsVerHigherThan' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hmsVerHigherThan", "(I)Z", "GetHmsVerHigherThan_IHandler")]
		public virtual unsafe bool HmsVerHigherThan (int p0)
		{
			const string __id = "hmsVerHigherThan.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isApkUpdateNecessary_I;
#pragma warning disable 0169
		static Delegate GetIsApkUpdateNecessary_IHandler ()
		{
			if (cb_isApkUpdateNecessary_I == null)
				cb_isApkUpdateNecessary_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_IsApkUpdateNecessary_I);
			return cb_isApkUpdateNecessary_I;
		}

		static bool n_IsApkUpdateNecessary_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.HMSPackageManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsApkUpdateNecessary (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/method[@name='isApkUpdateNecessary' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isApkUpdateNecessary", "(I)Z", "GetIsApkUpdateNecessary_IHandler")]
		public virtual unsafe bool IsApkUpdateNecessary (int p0)
		{
			const string __id = "isApkUpdateNecessary.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_refresh;
#pragma warning disable 0169
		static Delegate GetRefreshHandler ()
		{
			if (cb_refresh == null)
				cb_refresh = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Refresh);
			return cb_refresh;
		}

		static void n_Refresh (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.HMSPackageManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Refresh ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='HMSPackageManager']/method[@name='refresh' and count(parameter)=0]"
		[Register ("refresh", "()V", "GetRefreshHandler")]
		public virtual unsafe void Refresh ()
		{
			const string __id = "refresh.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
