using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper']"
	[global::Android.Runtime.Register ("com/huawei/hms/utils/PackageManagerHelper", DoNotGenerateAcw=true)]
	public partial class PackageManagerHelper : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper.PackageStates']"
		[global::Android.Runtime.Register ("com/huawei/hms/utils/PackageManagerHelper$PackageStates", DoNotGenerateAcw=true)]
		public sealed partial class PackageStates : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper.PackageStates']/field[@name='DISABLED']"
			[Register ("DISABLED")]
			public static global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates Disabled {
				get {
					const string __id = "DISABLED.Lcom/huawei/hms/utils/PackageManagerHelper$PackageStates;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper.PackageStates']/field[@name='ENABLED']"
			[Register ("ENABLED")]
			public static global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates Enabled {
				get {
					const string __id = "ENABLED.Lcom/huawei/hms/utils/PackageManagerHelper$PackageStates;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper.PackageStates']/field[@name='NOT_INSTALLED']"
			[Register ("NOT_INSTALLED")]
			public static global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates NotInstalled {
				get {
					const string __id = "NOT_INSTALLED.Lcom/huawei/hms/utils/PackageManagerHelper$PackageStates;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper.PackageStates']/field[@name='a']"
			[Register ("a")]
			public static IList<Huawei.Hms.Utils.PackageManagerHelper.PackageStates> A {
				get {
					const string __id = "a.[Lcom/huawei/hms/utils/PackageManagerHelper$PackageStates;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Android.Runtime.JavaArray<global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/PackageManagerHelper$PackageStates", typeof (PackageStates));
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

			internal PackageStates (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper.PackageStates']/constructor[@name='PackageManagerHelper.PackageStates' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
			[Register (".ctor", "(Ljava/lang/String;I)V", "")]
			public unsafe PackageStates (string p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (native_p0);
					__args [1] = new JniArgumentValue (p1);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper.PackageStates']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/huawei/hms/utils/PackageManagerHelper$PackageStates;", "")]
			public static unsafe global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/huawei/hms/utils/PackageManagerHelper$PackageStates;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper.PackageStates']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/huawei/hms/utils/PackageManagerHelper$PackageStates;", "")]
			public static unsafe global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates[] Values ()
			{
				const string __id = "values.()[Lcom/huawei/hms/utils/PackageManagerHelper$PackageStates;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/PackageManagerHelper", typeof (PackageManagerHelper));
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

		protected PackageManagerHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper']/constructor[@name='PackageManagerHelper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PackageManagerHelper (global::Android.Content.Context p0)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper']/method[@name='a' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("a", "(Ljava/lang/String;)[B", "")]
		public unsafe byte[] A (string p0)
		{
			const string __id = "a.(Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getPackageSignature_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPackageSignature_Ljava_lang_String_Handler ()
		{
			if (cb_getPackageSignature_Ljava_lang_String_ == null)
				cb_getPackageSignature_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPackageSignature_Ljava_lang_String_);
			return cb_getPackageSignature_Ljava_lang_String_;
		}

		static IntPtr n_GetPackageSignature_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.PackageManagerHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetPackageSignature (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper']/method[@name='getPackageSignature' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPackageSignature", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetPackageSignature_Ljava_lang_String_Handler")]
		public virtual unsafe string GetPackageSignature (string p0)
		{
			const string __id = "getPackageSignature.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getPackageStates_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPackageStates_Ljava_lang_String_Handler ()
		{
			if (cb_getPackageStates_Ljava_lang_String_ == null)
				cb_getPackageStates_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPackageStates_Ljava_lang_String_);
			return cb_getPackageStates_Ljava_lang_String_;
		}

		static IntPtr n_GetPackageStates_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.PackageManagerHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPackageStates (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper']/method[@name='getPackageStates' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPackageStates", "(Ljava/lang/String;)Lcom/huawei/hms/utils/PackageManagerHelper$PackageStates;", "GetGetPackageStates_Ljava_lang_String_Handler")]
		public virtual unsafe global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates GetPackageStates (string p0)
		{
			const string __id = "getPackageStates.(Ljava/lang/String;)Lcom/huawei/hms/utils/PackageManagerHelper$PackageStates;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.PackageManagerHelper.PackageStates> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getPackageVersionCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPackageVersionCode_Ljava_lang_String_Handler ()
		{
			if (cb_getPackageVersionCode_Ljava_lang_String_ == null)
				cb_getPackageVersionCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetPackageVersionCode_Ljava_lang_String_);
			return cb_getPackageVersionCode_Ljava_lang_String_;
		}

		static int n_GetPackageVersionCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.PackageManagerHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetPackageVersionCode (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper']/method[@name='getPackageVersionCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPackageVersionCode", "(Ljava/lang/String;)I", "GetGetPackageVersionCode_Ljava_lang_String_Handler")]
		public virtual unsafe int GetPackageVersionCode (string p0)
		{
			const string __id = "getPackageVersionCode.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getPackageVersionName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetPackageVersionName_Ljava_lang_String_Handler ()
		{
			if (cb_getPackageVersionName_Ljava_lang_String_ == null)
				cb_getPackageVersionName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetPackageVersionName_Ljava_lang_String_);
			return cb_getPackageVersionName_Ljava_lang_String_;
		}

		static IntPtr n_GetPackageVersionName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.PackageManagerHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetPackageVersionName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper']/method[@name='getPackageVersionName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getPackageVersionName", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetPackageVersionName_Ljava_lang_String_Handler")]
		public virtual unsafe string GetPackageVersionName (string p0)
		{
			const string __id = "getPackageVersionName.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_hasProvider_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasProvider_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_hasProvider_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_hasProvider_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_HasProvider_Ljava_lang_String_Ljava_lang_String_);
			return cb_hasProvider_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_HasProvider_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.PackageManagerHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasProvider (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper']/method[@name='hasProvider' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("hasProvider", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetHasProvider_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool HasProvider (string p0, string p1)
		{
			const string __id = "hasProvider.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_verifyPackageArchive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetVerifyPackageArchive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_verifyPackageArchive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_verifyPackageArchive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_Z) n_VerifyPackageArchive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_verifyPackageArchive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_VerifyPackageArchive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Utils.PackageManagerHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.VerifyPackageArchive (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='PackageManagerHelper']/method[@name='verifyPackageArchive' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("verifyPackageArchive", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z", "GetVerifyPackageArchive_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool VerifyPackageArchive (string p0, string p1, string p2)
		{
			const string __id = "verifyPackageArchive.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
