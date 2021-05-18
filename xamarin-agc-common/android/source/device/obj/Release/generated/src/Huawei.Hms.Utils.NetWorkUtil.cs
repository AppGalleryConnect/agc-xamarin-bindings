using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil']"
	[global::Android.Runtime.Register ("com/huawei/hms/utils/NetWorkUtil", DoNotGenerateAcw=true)]
	public abstract partial class NetWorkUtil : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil.NetType']"
		[global::Android.Runtime.Register ("com/huawei/hms/utils/NetWorkUtil$NetType", DoNotGenerateAcw=true)]
		public sealed partial class NetType : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil.NetType']/field[@name='NET']"
			[Register ("NET")]
			public const int Net = (int) -2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil.NetType']/field[@name='TYPE_2G']"
			[Register ("TYPE_2G")]
			public const int Type2g = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil.NetType']/field[@name='TYPE_3G']"
			[Register ("TYPE_3G")]
			public const int Type3g = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil.NetType']/field[@name='TYPE_4G']"
			[Register ("TYPE_4G")]
			public const int Type4g = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil.NetType']/field[@name='TYPE_5G']"
			[Register ("TYPE_5G")]
			public const int Type5g = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil.NetType']/field[@name='TYPE_NEED_INIT']"
			[Register ("TYPE_NEED_INIT")]
			public const int TypeNeedInit = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil.NetType']/field[@name='TYPE_OTHER']"
			[Register ("TYPE_OTHER")]
			public const int TypeOther = (int) 6;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil.NetType']/field[@name='TYPE_UNKNOWN']"
			[Register ("TYPE_UNKNOWN")]
			public const int TypeUnknown = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil.NetType']/field[@name='TYPE_WIFI']"
			[Register ("TYPE_WIFI")]
			public const int TypeWifi = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil.NetType']/field[@name='WAP']"
			[Register ("WAP")]
			public const int Wap = (int) -3;
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/NetWorkUtil$NetType", typeof (NetType));
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

			internal NetType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil.NetType']/constructor[@name='NetWorkUtil.NetType' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe NetType ()
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/NetWorkUtil", typeof (NetWorkUtil));
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

		protected NetWorkUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil']/constructor[@name='NetWorkUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NetWorkUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("a", "(Landroid/content/Context;)Landroid/net/NetworkInfo;", "")]
		public static unsafe global::Android.Net.NetworkInfo A (global::Android.Content.Context p0)
		{
			const string __id = "a.(Landroid/content/Context;)Landroid/net/NetworkInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Net.NetworkInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.net.NetworkInfo']]"
		[Register ("a", "(Landroid/net/NetworkInfo;)I", "")]
		public static unsafe int A (global::Android.Net.NetworkInfo p0)
		{
			const string __id = "a.(Landroid/net/NetworkInfo;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='NetWorkUtil']/method[@name='getNetworkType' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getNetworkType", "(Landroid/content/Context;)I", "")]
		public static unsafe int GetNetworkType (global::Android.Content.Context p0)
		{
			const string __id = "getNetworkType.(Landroid/content/Context;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/utils/NetWorkUtil", DoNotGenerateAcw=true)]
	internal partial class NetWorkUtilInvoker : NetWorkUtil {

		public NetWorkUtilInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/NetWorkUtil", typeof (NetWorkUtilInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
