using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']"
	[global::Android.Runtime.Register ("com/huawei/hms/api/ConnectionResult", DoNotGenerateAcw=true)]
	public sealed partial class ConnectionResult : global::Java.Lang.Object, global::Android.OS.IParcelable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='API_UNAVAILABLE']"
		[Register ("API_UNAVAILABLE")]
		public const int ApiUnavailable = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='BINDFAIL_RESOLUTION_BACKGROUND']"
		[Register ("BINDFAIL_RESOLUTION_BACKGROUND")]
		public const int BindfailResolutionBackground = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='BINDFAIL_RESOLUTION_REQUIRED']"
		[Register ("BINDFAIL_RESOLUTION_REQUIRED")]
		public const int BindfailResolutionRequired = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='CANCELED']"
		[Register ("CANCELED")]
		public const int Canceled = (int) 13;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='DEVELOPER_ERROR']"
		[Register ("DEVELOPER_ERROR")]
		public const int DeveloperError = (int) 10;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='DRIVE_EXTERNAL_STORAGE_REQUIRED']"
		[Register ("DRIVE_EXTERNAL_STORAGE_REQUIRED")]
		public const int DriveExternalStorageRequired = (int) 9002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public const int InternalError = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='INTERRUPTED']"
		[Register ("INTERRUPTED")]
		public const int Interrupted = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='INVALID_ACCOUNT']"
		[Register ("INVALID_ACCOUNT")]
		public const int InvalidAccount = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='LICENSE_CHECK_FAILED']"
		[Register ("LICENSE_CHECK_FAILED")]
		public const int LicenseCheckFailed = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='NETWORK_ERROR']"
		[Register ("NETWORK_ERROR")]
		public const int NetworkError = (int) 9000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='RESOLUTION_REQUIRED']"
		[Register ("RESOLUTION_REQUIRED")]
		public const int ResolutionRequired = (int) 9001;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='RESTRICTED_PROFILE']"
		[Register ("RESTRICTED_PROFILE")]
		public const int RestrictedProfile = (int) 9003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='SERVICE_DISABLED']"
		[Register ("SERVICE_DISABLED")]
		public const int ServiceDisabled = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='SERVICE_INVALID']"
		[Register ("SERVICE_INVALID")]
		public const int ServiceInvalid = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='SERVICE_MISSING']"
		[Register ("SERVICE_MISSING")]
		public const int ServiceMissing = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='SERVICE_MISSING_PERMISSION']"
		[Register ("SERVICE_MISSING_PERMISSION")]
		public const int ServiceMissingPermission = (int) 19;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='SERVICE_UNSUPPORTED']"
		[Register ("SERVICE_UNSUPPORTED")]
		public const int ServiceUnsupported = (int) 21;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='SERVICE_UPDATING']"
		[Register ("SERVICE_UPDATING")]
		public const int ServiceUpdating = (int) 9004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='SERVICE_VERSION_UPDATE_REQUIRED']"
		[Register ("SERVICE_VERSION_UPDATE_REQUIRED")]
		public const int ServiceVersionUpdateRequired = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='SIGN_IN_FAILED']"
		[Register ("SIGN_IN_FAILED")]
		public const int SignInFailed = (int) 9005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='SIGN_IN_REQUIRED']"
		[Register ("SIGN_IN_REQUIRED")]
		public const int SignInRequired = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public const int Success = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/field[@name='TIMEOUT']"
		[Register ("TIMEOUT")]
		public const int Timeout = (int) 14;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/ConnectionResult", typeof (ConnectionResult));
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

		internal ConnectionResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/constructor[@name='ConnectionResult' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe ConnectionResult (int p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/constructor[@name='ConnectionResult' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.app.PendingIntent']]"
		[Register (".ctor", "(ILandroid/app/PendingIntent;)V", "")]
		public unsafe ConnectionResult (int p0, global::Android.App.PendingIntent p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILandroid/app/PendingIntent;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/constructor[@name='ConnectionResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.app.PendingIntent'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(ILandroid/app/PendingIntent;Ljava/lang/String;)V", "")]
		public unsafe ConnectionResult (int p0, global::Android.App.PendingIntent p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILandroid/app/PendingIntent;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				global::System.GC.KeepAlive (p1);
			}
		}

		public unsafe int ErrorCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register ("getErrorCode", "()I", "")]
			get {
				const string __id = "getErrorCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string ErrorMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/method[@name='getErrorMessage' and count(parameter)=0]"
			[Register ("getErrorMessage", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getErrorMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool HasResolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/method[@name='hasResolution' and count(parameter)=0]"
			[Register ("hasResolution", "()Z", "")]
			get {
				const string __id = "hasResolution.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "")]
			get {
				const string __id = "isSuccess.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.App.PendingIntent Resolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/method[@name='getResolution' and count(parameter)=0]"
			[Register ("getResolution", "()Landroid/app/PendingIntent;", "")]
			get {
				const string __id = "getResolution.()Landroid/app/PendingIntent;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "")]
		public unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/method[@name='startResolutionForResult' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("startResolutionForResult", "(Landroid/app/Activity;I)V", "")]
		public unsafe void StartResolutionForResult (global::Android.App.Activity p0, int p1)
		{
			const string __id = "startResolutionForResult.(Landroid/app/Activity;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='ConnectionResult']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((int) p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
