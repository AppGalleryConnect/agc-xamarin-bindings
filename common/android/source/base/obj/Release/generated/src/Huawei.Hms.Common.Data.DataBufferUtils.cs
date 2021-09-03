using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferUtils']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/data/DataBufferUtils", DoNotGenerateAcw=true)]
	public sealed partial class DataBufferUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferUtils']/field[@name='ARGS_BUNDLE']"
		[Register ("ARGS_BUNDLE")]
		public const int ArgsBundle = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferUtils']/field[@name='ARGS_COLUMN']"
		[Register ("ARGS_COLUMN")]
		public const int ArgsColumn = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferUtils']/field[@name='ARGS_CURSOR']"
		[Register ("ARGS_CURSOR")]
		public const int ArgsCursor = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferUtils']/field[@name='ARGS_STATUS']"
		[Register ("ARGS_STATUS")]
		public const int ArgsStatus = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferUtils']/field[@name='ARGS_VERSION']"
		[Register ("ARGS_VERSION")]
		public const int ArgsVersion = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferUtils']/field[@name='NEXT_PAGE']"
		[Register ("NEXT_PAGE")]
		public const string NextPage = (string) "next_page";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferUtils']/field[@name='PREV_PAGE']"
		[Register ("PREV_PAGE")]
		public const string PrevPage = (string) "prev_page";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/DataBufferUtils", typeof (DataBufferUtils));
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

		internal DataBufferUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferUtils']/method[@name='freezeAndClose' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.data.DataBuffer&lt;E&gt;']]"
		[Register ("freezeAndClose", "(Lcom/huawei/hms/common/data/DataBuffer;)Ljava/util/ArrayList;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "E extends com.huawei.hms.common.data.Freezable<T>"})]
		public static unsafe global::System.Collections.IList FreezeAndClose (global::Huawei.Hms.Common.Data.IDataBuffer p0)
		{
			const string __id = "freezeAndClose.(Lcom/huawei/hms/common/data/DataBuffer;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferUtils']/method[@name='hasData' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.data.DataBuffer&lt;?&gt;']]"
		[Register ("hasData", "(Lcom/huawei/hms/common/data/DataBuffer;)Z", "")]
		public static unsafe bool HasData (global::Huawei.Hms.Common.Data.IDataBuffer p0)
		{
			const string __id = "hasData.(Lcom/huawei/hms/common/data/DataBuffer;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferUtils']/method[@name='hasNextPage' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.data.DataBuffer&lt;?&gt;']]"
		[Register ("hasNextPage", "(Lcom/huawei/hms/common/data/DataBuffer;)Z", "")]
		public static unsafe bool HasNextPage (global::Huawei.Hms.Common.Data.IDataBuffer p0)
		{
			const string __id = "hasNextPage.(Lcom/huawei/hms/common/data/DataBuffer;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferUtils']/method[@name='hasPrevPage' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.common.data.DataBuffer&lt;?&gt;']]"
		[Register ("hasPrevPage", "(Lcom/huawei/hms/common/data/DataBuffer;)Z", "")]
		public static unsafe bool HasPrevPage (global::Huawei.Hms.Common.Data.IDataBuffer p0)
		{
			const string __id = "hasPrevPage.(Lcom/huawei/hms/common/data/DataBuffer;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
