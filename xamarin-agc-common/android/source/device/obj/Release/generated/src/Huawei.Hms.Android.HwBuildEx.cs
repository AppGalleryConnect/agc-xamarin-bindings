using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Android {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx']"
	[global::Android.Runtime.Register ("com/huawei/hms/android/HwBuildEx", DoNotGenerateAcw=true)]
	public partial class HwBuildEx : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VERSION']"
		[global::Android.Runtime.Register ("com/huawei/hms/android/HwBuildEx$VERSION", DoNotGenerateAcw=true)]
		public partial class VERSION : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VERSION']/field[@name='EMUI_SDK_INT']"
			[Register ("EMUI_SDK_INT")]
			public static int EmuiSdkInt {
				get {
					const string __id = "EMUI_SDK_INT.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/android/HwBuildEx$VERSION", typeof (VERSION));
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

			protected VERSION (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VERSION']/constructor[@name='HwBuildEx.VERSION' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe VERSION ()
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']"
		[global::Android.Runtime.Register ("com/huawei/hms/android/HwBuildEx$VersionCodes", DoNotGenerateAcw=true)]
		public partial class VersionCodes : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='CUR_DEVELOPMENT']"
			[Register ("CUR_DEVELOPMENT")]
			public const int CurDevelopment = (int) 10000;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_10_0']"
			[Register ("EMUI_10_0")]
			public const int Emui100 = (int) 21;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_1_0']"
			[Register ("EMUI_1_0")]
			public const int Emui10 = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_1_5']"
			[Register ("EMUI_1_5")]
			public const int Emui15 = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_1_6']"
			[Register ("EMUI_1_6")]
			public const int Emui16 = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_2_0_JB']"
			[Register ("EMUI_2_0_JB")]
			public const int Emui20Jb = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_2_0_KK']"
			[Register ("EMUI_2_0_KK")]
			public const int Emui20Kk = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_2_3']"
			[Register ("EMUI_2_3")]
			public const int Emui23 = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_3_0']"
			[Register ("EMUI_3_0")]
			public const int Emui30 = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_3_0_5']"
			[Register ("EMUI_3_0_5")]
			public const int Emui305 = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_3_1']"
			[Register ("EMUI_3_1")]
			public const int Emui31 = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_4_0']"
			[Register ("EMUI_4_0")]
			public const int Emui40 = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_4_1']"
			[Register ("EMUI_4_1")]
			public const int Emui41 = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_5_0']"
			[Register ("EMUI_5_0")]
			public const int Emui50 = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_5_1']"
			[Register ("EMUI_5_1")]
			public const int Emui51 = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_5_1_b10x']"
			[Register ("EMUI_5_1_b10x")]
			public const int EMUI51B10x = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_5_1_b200']"
			[Register ("EMUI_5_1_b200")]
			public const int EMUI51B200 = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_6_0']"
			[Register ("EMUI_6_0")]
			public const int Emui60 = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='EMUI_9_0']"
			[Register ("EMUI_9_0")]
			public const int Emui90 = (int) 17;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/field[@name='UNKNOWN_EMUI']"
			[Register ("UNKNOWN_EMUI")]
			public const int UnknownEmui = (int) 0;
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/android/HwBuildEx$VersionCodes", typeof (VersionCodes));
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

			protected VersionCodes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx.VersionCodes']/constructor[@name='HwBuildEx.VersionCodes' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe VersionCodes ()
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/android/HwBuildEx", typeof (HwBuildEx));
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

		protected HwBuildEx (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx']/constructor[@name='HwBuildEx' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HwBuildEx ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.android']/class[@name='HwBuildEx']/method[@name='getSystemPropertiesInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getSystemPropertiesInt", "(Ljava/lang/String;I)I", "")]
		public static unsafe int GetSystemPropertiesInt (string p0, int p1)
		{
			const string __id = "getSystemPropertiesInt.(Ljava/lang/String;I)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
