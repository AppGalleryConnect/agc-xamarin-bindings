using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Entity.Auth {

	[Register ("com/huawei/hms/support/api/entity/auth/AuthCode$ErrorCode", DoNotGenerateAcw=true)]
	public abstract class AuthCodeErrorCode : Java.Lang.Object {

		internal AuthCodeErrorCode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/interface[@name='AuthCode.ErrorCode']/field[@name='CERT_FINGERPRINT_EMPTY']"
		[Register ("CERT_FINGERPRINT_EMPTY")]
		public const int CertFingerprintEmpty = (int) 907135702;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/interface[@name='AuthCode.ErrorCode']/field[@name='GET_SCOPE_ERROR']"
		[Register ("GET_SCOPE_ERROR")]
		public const int GetScopeError = (int) 907135700;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/interface[@name='AuthCode.ErrorCode']/field[@name='PERMISSION_LIST_EMPTY']"
		[Register ("PERMISSION_LIST_EMPTY")]
		public const int PermissionListEmpty = (int) 907135703;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/interface[@name='AuthCode.ErrorCode']/field[@name='SCOPE_LIST_EMPTY']"
		[Register ("SCOPE_LIST_EMPTY")]
		public const int ScopeListEmpty = (int) 907135701;
	}

	[Register ("com/huawei/hms/support/api/entity/auth/AuthCode$ErrorCode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AuthCodeErrorCode' type. This type will be removed in a future release.", error: true)]
	public abstract class AuthCodeErrorCodeConsts : AuthCodeErrorCode {

		private AuthCodeErrorCodeConsts ()
		{
		}
	}


	[Register ("com/huawei/hms/support/api/entity/auth/AuthCode$StatusCode", DoNotGenerateAcw=true)]
	public abstract class AuthCodeStatusCode : Java.Lang.Object {

		internal AuthCodeStatusCode ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/interface[@name='AuthCode.StatusCode']/field[@name='AUTH_INFO_NOT_EXIST']"
		[Register ("AUTH_INFO_NOT_EXIST")]
		public const int AuthInfoNotExist = (int) 6002;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/interface[@name='AuthCode.StatusCode']/field[@name='CERT_FINGERPRINT_ERROR']"
		[Register ("CERT_FINGERPRINT_ERROR")]
		public const int CertFingerprintError = (int) 6003;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/interface[@name='AuthCode.StatusCode']/field[@name='OK']"
		[Register ("OK")]
		public const int Ok = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/interface[@name='AuthCode.StatusCode']/field[@name='PERMISSION_EXPIRED']"
		[Register ("PERMISSION_EXPIRED")]
		public const int PermissionExpired = (int) 6006;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/interface[@name='AuthCode.StatusCode']/field[@name='PERMISSION_NOT_AUTHORIZED']"
		[Register ("PERMISSION_NOT_AUTHORIZED")]
		public const int PermissionNotAuthorized = (int) 6005;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/interface[@name='AuthCode.StatusCode']/field[@name='PERMISSION_NOT_EXIST']"
		[Register ("PERMISSION_NOT_EXIST")]
		public const int PermissionNotExist = (int) 6004;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/interface[@name='AuthCode.StatusCode']/field[@name='WAITING_CONNECT']"
		[Register ("WAITING_CONNECT")]
		public const int WaitingConnect = (int) 6001;
	}

	[Register ("com/huawei/hms/support/api/entity/auth/AuthCode$StatusCode", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AuthCodeStatusCode' type. This type will be removed in a future release.", error: true)]
	public abstract class AuthCodeStatusCodeConsts : AuthCodeStatusCode {

		private AuthCodeStatusCodeConsts ()
		{
		}
	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.support.api.entity.auth']/interface[@name='AuthCode']"
	[Register ("com/huawei/hms/support/api/entity/auth/AuthCode", "", "Huawei.Hms.Support.Api.Entity.Auth.IAuthCodeInvoker")]
	public partial interface IAuthCode : IJavaObject, IJavaPeerable {

	}

	[global::Android.Runtime.Register ("com/huawei/hms/support/api/entity/auth/AuthCode", DoNotGenerateAcw=true)]
	internal partial class IAuthCodeInvoker : global::Java.Lang.Object, IAuthCode {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/entity/auth/AuthCode", typeof (IAuthCodeInvoker));

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

		public static IAuthCode GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthCode> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.support.api.entity.auth.AuthCode"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthCodeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}

}
