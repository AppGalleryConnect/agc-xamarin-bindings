using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/Status", DoNotGenerateAcw=true)]
	public sealed partial class Status : global::Huawei.Hms.Support.Api.Client.Result, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/field[@name='CoreException']"
		[Register ("CoreException")]
		public static global::Huawei.Hms.Support.Api.Client.Status CoreException {
			get {
				const string __id = "CoreException.Lcom/huawei/hms/support/api/client/Status;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/field[@name='FAILURE']"
		[Register ("FAILURE")]
		public static global::Huawei.Hms.Support.Api.Client.Status Failure {
			get {
				const string __id = "FAILURE.Lcom/huawei/hms/support/api/client/Status;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/field[@name='MessageNotFound']"
		[Register ("MessageNotFound")]
		public static global::Huawei.Hms.Support.Api.Client.Status MessageNotFound {
			get {
				const string __id = "MessageNotFound.Lcom/huawei/hms/support/api/client/Status;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/field[@name='RESULT_CANCELED']"
		[Register ("RESULT_CANCELED")]
		public static global::Huawei.Hms.Support.Api.Client.Status ResultCanceled {
			get {
				const string __id = "RESULT_CANCELED.Lcom/huawei/hms/support/api/client/Status;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/field[@name='RESULT_DEAD_CLIENT']"
		[Register ("RESULT_DEAD_CLIENT")]
		public static global::Huawei.Hms.Support.Api.Client.Status ResultDeadClient {
			get {
				const string __id = "RESULT_DEAD_CLIENT.Lcom/huawei/hms/support/api/client/Status;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/field[@name='RESULT_INTERNAL_ERROR']"
		[Register ("RESULT_INTERNAL_ERROR")]
		public static global::Huawei.Hms.Support.Api.Client.Status ResultInternalError {
			get {
				const string __id = "RESULT_INTERNAL_ERROR.Lcom/huawei/hms/support/api/client/Status;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/field[@name='RESULT_INTERRUPTED']"
		[Register ("RESULT_INTERRUPTED")]
		public static global::Huawei.Hms.Support.Api.Client.Status ResultInterrupted {
			get {
				const string __id = "RESULT_INTERRUPTED.Lcom/huawei/hms/support/api/client/Status;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/field[@name='RESULT_TIMEOUT']"
		[Register ("RESULT_TIMEOUT")]
		public static global::Huawei.Hms.Support.Api.Client.Status ResultTimeout {
			get {
				const string __id = "RESULT_TIMEOUT.Lcom/huawei/hms/support/api/client/Status;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/field[@name='SUCCESS']"
		[Register ("SUCCESS")]
		public static global::Huawei.Hms.Support.Api.Client.Status Success {
			get {
				const string __id = "SUCCESS.Lcom/huawei/hms/support/api/client/Status;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.Status> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/Status", typeof (Status));
		internal static new IntPtr class_ref {
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

		internal Status (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/constructor[@name='Status' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe Status (int p0)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/constructor[@name='Status' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe Status (int p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/constructor[@name='Status' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.app.PendingIntent']]"
		[Register (".ctor", "(ILjava/lang/String;Landroid/app/PendingIntent;)V", "")]
		public unsafe Status (int p0, string p1, global::Android.App.PendingIntent p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Landroid/app/PendingIntent;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/constructor[@name='Status' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Intent']]"
		[Register (".ctor", "(ILjava/lang/String;Landroid/content/Intent;)V", "")]
		public unsafe Status (int p0, string p1, global::Android.Content.Intent p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;Landroid/content/Intent;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		public unsafe string ErrorString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/method[@name='getErrorString' and count(parameter)=0]"
			[Register ("getErrorString", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getErrorString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool HasResolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/method[@name='hasResolution' and count(parameter)=0]"
			[Register ("hasResolution", "()Z", "")]
			get {
				const string __id = "hasResolution.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "")]
			get {
				const string __id = "isCanceled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsInterrupted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/method[@name='isInterrupted' and count(parameter)=0]"
			[Register ("isInterrupted", "()Z", "")]
			get {
				const string __id = "isInterrupted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "")]
			get {
				const string __id = "isSuccess.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.App.PendingIntent Resolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/method[@name='getResolution' and count(parameter)=0]"
			[Register ("getResolution", "()Landroid/app/PendingIntent;", "")]
			get {
				const string __id = "getResolution.()Landroid/app/PendingIntent;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.PendingIntent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "")]
			get {
				const string __id = "getStatusCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string StatusMessage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/method[@name='getStatusMessage' and count(parameter)=0]"
			[Register ("getStatusMessage", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getStatusMessage.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/method[@name='describeContents' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/method[@name='startResolutionForResult' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("startResolutionForResult", "(Landroid/app/Activity;I)V", "")]
		public unsafe void StartResolutionForResult (global::Android.App.Activity p0, int p1)
		{
			const string __id = "startResolutionForResult.(Landroid/app/Activity;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='Status']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
