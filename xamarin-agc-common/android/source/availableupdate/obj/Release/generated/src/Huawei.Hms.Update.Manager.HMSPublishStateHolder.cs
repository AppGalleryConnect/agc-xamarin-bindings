using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Update.Manager {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='HMSPublishStateHolder']"
	[global::Android.Runtime.Register ("com/huawei/hms/update/manager/HMSPublishStateHolder", DoNotGenerateAcw=true)]
	public partial class HMSPublishStateHolder : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='HMSPublishStateHolder']/field[@name='NOT_CHECKED']"
		[Register ("NOT_CHECKED")]
		public const int NotChecked = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='HMSPublishStateHolder']/field[@name='NOT_PUBLISHED_YET']"
		[Register ("NOT_PUBLISHED_YET")]
		public const int NotPublishedYet = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='HMSPublishStateHolder']/field[@name='PUBLISHED']"
		[Register ("PUBLISHED")]
		public const int Published = (int) 1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='HMSPublishStateHolder']/field[@name='a']"
		[Register ("a")]
		public static int A {
			get {
				const string __id = "a.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "a.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='HMSPublishStateHolder']/field[@name='b']"
		[Register ("b")]
		public static global::Java.Lang.Object B {
			get {
				const string __id = "b.Ljava/lang/Object;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/update/manager/HMSPublishStateHolder", typeof (HMSPublishStateHolder));
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

		protected HMSPublishStateHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='HMSPublishStateHolder']/constructor[@name='HMSPublishStateHolder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HMSPublishStateHolder ()
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

		public static unsafe int PublishState {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='HMSPublishStateHolder']/method[@name='getPublishState' and count(parameter)=0]"
			[Register ("getPublishState", "()I", "")]
			get {
				const string __id = "getPublishState.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.update.manager']/class[@name='HMSPublishStateHolder']/method[@name='setPublishState' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPublishState", "(I)V", "")]
			set {
				const string __id = "setPublishState.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

	}
}
