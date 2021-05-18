using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Size {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.size']/class[@name='Size']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/size/Size", DoNotGenerateAcw=true)]
	public partial class Size : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/size/Size", typeof (Size));
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

		protected Size (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.size']/class[@name='Size']/constructor[@name='Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Size (int p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.size']/class[@name='Size']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "")]
			get {
				const string __id = "getHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.size']/class[@name='Size']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "")]
			get {
				const string __id = "getWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.size']/class[@name='Size']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed unsafe bool Equals (global::Java.Lang.Object p0)
		{
			const string __id = "equals.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.size']/class[@name='Size']/method[@name='parseSize' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseSize", "(Ljava/lang/String;)Lcom/huawei/hms/common/size/Size;", "")]
		public static unsafe global::Huawei.Hms.Common.Size.Size ParseSize (string p0)
		{
			const string __id = "parseSize.(Ljava/lang/String;)Lcom/huawei/hms/common/size/Size;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Size.Size> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.size']/class[@name='Size']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
