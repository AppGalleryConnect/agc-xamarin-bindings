using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Support.Api.Client {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResultsCreator']"
	[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/PendingResultsCreator", DoNotGenerateAcw=true)]
	public sealed partial class PendingResultsCreator : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResultsCreator.DiscardedPendingResult']"
		[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/PendingResultsCreator$DiscardedPendingResult", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.huawei.hms.support.api.client.Result"})]
		public partial class DiscardedPendingResult : global::Huawei.Hms.Support.Api.Client.EmptyPendingResult {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/PendingResultsCreator$DiscardedPendingResult", typeof (DiscardedPendingResult));
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

			protected DiscardedPendingResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResultsCreator.DiscardedPendingResult']/constructor[@name='PendingResultsCreator.DiscardedPendingResult' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe DiscardedPendingResult ()
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResultsCreator.DiscardedPendingResult']/constructor[@name='PendingResultsCreator.DiscardedPendingResult' and count(parameter)=1 and parameter[1][@type='R']]"
			[Register (".ctor", "(Lcom/huawei/hms/support/api/client/Result;)V", "")]
			public unsafe DiscardedPendingResult (global::Java.Lang.Object p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/huawei/hms/support/api/client/Result;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResultsCreator.InstantPendingResult']"
		[global::Android.Runtime.Register ("com/huawei/hms/support/api/client/PendingResultsCreator$InstantPendingResult", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.huawei.hms.support.api.client.Result"})]
		public partial class InstantPendingResult : global::Huawei.Hms.Support.Api.Client.EmptyPendingResult {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/PendingResultsCreator$InstantPendingResult", typeof (InstantPendingResult));
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

			protected InstantPendingResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResultsCreator.InstantPendingResult']/constructor[@name='PendingResultsCreator.InstantPendingResult' and count(parameter)=1 and parameter[1][@type='R']]"
			[Register (".ctor", "(Lcom/huawei/hms/support/api/client/Result;)V", "")]
			public unsafe InstantPendingResult (global::Java.Lang.Object p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/huawei/hms/support/api/client/Result;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p0);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/support/api/client/PendingResultsCreator", typeof (PendingResultsCreator));
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

		internal PendingResultsCreator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResultsCreator']/constructor[@name='PendingResultsCreator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PendingResultsCreator ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResultsCreator']/method[@name='discardedPendingResult' and count(parameter)=0]"
		[Register ("discardedPendingResult", "()Lcom/huawei/hms/support/api/client/PendingResult;", "")]
		public static unsafe global::Huawei.Hms.Support.Api.Client.PendingResult InvokeDiscardedPendingResult ()
		{
			const string __id = "discardedPendingResult.()Lcom/huawei/hms/support/api/client/PendingResult;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResultsCreator']/method[@name='discardedPendingResult' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register ("discardedPendingResult", "(Lcom/huawei/hms/support/api/client/Result;)Lcom/huawei/hms/support/api/client/PendingResult;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.huawei.hms.support.api.client.Result"})]
		public static unsafe global::Huawei.Hms.Support.Api.Client.PendingResult InvokeDiscardedPendingResult (global::Java.Lang.Object p0)
		{
			const string __id = "discardedPendingResult.(Lcom/huawei/hms/support/api/client/Result;)Lcom/huawei/hms/support/api/client/PendingResult;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResultsCreator']/method[@name='instantPendingResult' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.Status']]"
		[Register ("instantPendingResult", "(Lcom/huawei/hms/support/api/client/Status;)Lcom/huawei/hms/support/api/client/PendingResult;", "")]
		public static unsafe global::Huawei.Hms.Support.Api.Client.PendingResult InvokeInstantPendingResult (global::Huawei.Hms.Support.Api.Client.Status p0)
		{
			const string __id = "instantPendingResult.(Lcom/huawei/hms/support/api/client/Status;)Lcom/huawei/hms/support/api/client/PendingResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.support.api.client']/class[@name='PendingResultsCreator']/method[@name='instantPendingResult' and count(parameter)=1 and parameter[1][@type='R']]"
		[Register ("instantPendingResult", "(Lcom/huawei/hms/support/api/client/Result;)Lcom/huawei/hms/common/api/OptionalPendingResult;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R extends com.huawei.hms.support.api.client.Result"})]
		public static unsafe global::Huawei.Hms.Common.Api.OptionalPendingResult InvokeInstantPendingResult (global::Java.Lang.Object p0)
		{
			const string __id = "instantPendingResult.(Lcom/huawei/hms/support/api/client/Result;)Lcom/huawei/hms/common/api/OptionalPendingResult;";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Api.OptionalPendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
