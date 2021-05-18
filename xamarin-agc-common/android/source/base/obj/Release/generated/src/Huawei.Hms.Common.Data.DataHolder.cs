using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/data/DataHolder", DoNotGenerateAcw=true)]
	public sealed partial class DataHolder : global::Huawei.Hms.Common.Internal.Safeparcel.AbstractSafeParcelable, global::Java.IO.ICloseable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/field[@name='TYPE_BOOLEAN']"
		[Register ("TYPE_BOOLEAN")]
		public const string TypeBoolean = (string) "type_boolean";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/field[@name='TYPE_BYTE_ARRAY']"
		[Register ("TYPE_BYTE_ARRAY")]
		public const string TypeByteArray = (string) "type_byte_array";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/field[@name='TYPE_DOUBLE']"
		[Register ("TYPE_DOUBLE")]
		public const string TypeDouble = (string) "type_double";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/field[@name='TYPE_FLOAT']"
		[Register ("TYPE_FLOAT")]
		public const string TypeFloat = (string) "type_float";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/field[@name='TYPE_INT']"
		[Register ("TYPE_INT")]
		public const string TypeInt = (string) "type_int";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/field[@name='TYPE_LONG']"
		[Register ("TYPE_LONG")]
		public const string TypeLong = (string) "type_long";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/field[@name='TYPE_STRING']"
		[Register ("TYPE_STRING")]
		public const string TypeString = (string) "type_string";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder.Builder']"
		[global::Android.Runtime.Register ("com/huawei/hms/common/data/DataHolder$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/DataHolder$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_build_I;
#pragma warning disable 0169
			static Delegate GetBuild_IHandler ()
			{
				if (cb_build_I == null)
					cb_build_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Build_I);
				return cb_build_I;
			}

			static IntPtr n_Build_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataHolder.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder.Builder']/method[@name='build' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("build", "(I)Lcom/huawei/hms/common/data/DataHolder;", "GetBuild_IHandler")]
			public virtual unsafe global::Huawei.Hms.Common.Data.DataHolder Build (int p0)
			{
				const string __id = "build.(I)Lcom/huawei/hms/common/data/DataHolder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_build_ILandroid_os_Bundle_;
#pragma warning disable 0169
			static Delegate GetBuild_ILandroid_os_Bundle_Handler ()
			{
				if (cb_build_ILandroid_os_Bundle_ == null)
					cb_build_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_Build_ILandroid_os_Bundle_);
				return cb_build_ILandroid_os_Bundle_;
			}

			static IntPtr n_Build_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataHolder.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Build (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder.Builder']/method[@name='build' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.os.Bundle']]"
			[Register ("build", "(ILandroid/os/Bundle;)Lcom/huawei/hms/common/data/DataHolder;", "GetBuild_ILandroid_os_Bundle_Handler")]
			public virtual unsafe global::Huawei.Hms.Common.Data.DataHolder Build (int p0, global::Android.OS.Bundle p1)
			{
				const string __id = "build.(ILandroid/os/Bundle;)Lcom/huawei/hms/common/data/DataHolder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p1);
				}
			}

			static Delegate cb_setDataForContentValuesHashMap_Ljava_util_HashMap_;
#pragma warning disable 0169
			static Delegate GetSetDataForContentValuesHashMap_Ljava_util_HashMap_Handler ()
			{
				if (cb_setDataForContentValuesHashMap_Ljava_util_HashMap_ == null)
					cb_setDataForContentValuesHashMap_Ljava_util_HashMap_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDataForContentValuesHashMap_Ljava_util_HashMap_);
				return cb_setDataForContentValuesHashMap_Ljava_util_HashMap_;
			}

			static IntPtr n_SetDataForContentValuesHashMap_Ljava_util_HashMap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataHolder.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDataForContentValuesHashMap (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder.Builder']/method[@name='setDataForContentValuesHashMap' and count(parameter)=1 and parameter[1][@type='java.util.HashMap&lt;java.lang.String, java.lang.Object&gt;']]"
			[Register ("setDataForContentValuesHashMap", "(Ljava/util/HashMap;)Lcom/huawei/hms/common/data/DataHolder$Builder;", "GetSetDataForContentValuesHashMap_Ljava_util_HashMap_Handler")]
			public virtual unsafe global::Huawei.Hms.Common.Data.DataHolder.Builder SetDataForContentValuesHashMap (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
			{
				const string __id = "setDataForContentValuesHashMap.(Ljava/util/HashMap;)Lcom/huawei/hms/common/data/DataHolder$Builder;";
				IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataHolder.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					global::System.GC.KeepAlive (p0);
				}
			}

			static Delegate cb_withRow_Landroid_content_ContentValues_;
#pragma warning disable 0169
			static Delegate GetWithRow_Landroid_content_ContentValues_Handler ()
			{
				if (cb_withRow_Landroid_content_ContentValues_ == null)
					cb_withRow_Landroid_content_ContentValues_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_WithRow_Landroid_content_ContentValues_);
				return cb_withRow_Landroid_content_ContentValues_;
			}

			static IntPtr n_WithRow_Landroid_content_ContentValues_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataHolder.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ContentValues> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithRow (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder.Builder']/method[@name='withRow' and count(parameter)=1 and parameter[1][@type='android.content.ContentValues']]"
			[Register ("withRow", "(Landroid/content/ContentValues;)Lcom/huawei/hms/common/data/DataHolder$Builder;", "GetWithRow_Landroid_content_ContentValues_Handler")]
			public virtual unsafe global::Huawei.Hms.Common.Data.DataHolder.Builder WithRow (global::Android.Content.ContentValues p0)
			{
				const string __id = "withRow.(Landroid/content/ContentValues;)Lcom/huawei/hms/common/data/DataHolder$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataHolder.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder.DataHolderException']"
		[global::Android.Runtime.Register ("com/huawei/hms/common/data/DataHolder$DataHolderException", DoNotGenerateAcw=true)]
		public partial class DataHolderException : global::Java.Lang.RuntimeException {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/DataHolder$DataHolderException", typeof (DataHolderException));
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

			protected DataHolderException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder.DataHolderException']/constructor[@name='DataHolder.DataHolderException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register (".ctor", "(Ljava/lang/String;)V", "")]
			public unsafe DataHolderException (string p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/lang/String;)V";

				if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/DataHolder", typeof (DataHolder));
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

		internal DataHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/constructor[@name='DataHolder' and count(parameter)=3 and parameter[1][@type='android.database.Cursor'] and parameter[2][@type='int'] and parameter[3][@type='android.os.Bundle']]"
		[Register (".ctor", "(Landroid/database/Cursor;ILandroid/os/Bundle;)V", "")]
		public unsafe DataHolder (global::Android.Database.ICursor p0, int p1, global::Android.OS.Bundle p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/database/Cursor;ILandroid/os/Bundle;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/constructor[@name='DataHolder' and count(parameter)=4 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='android.database.CursorWindow[]'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register (".ctor", "([Ljava/lang/String;[Landroid/database/CursorWindow;ILandroid/os/Bundle;)V", "")]
		public unsafe DataHolder (string[] p0, global::Android.Database.CursorWindow[] p1, int p2, global::Android.OS.Bundle p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;[Landroid/database/CursorWindow;ILandroid/os/Bundle;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p3);
			}
		}

		public unsafe int Count {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='getCount' and count(parameter)=0]"
			[Register ("getCount", "()I", "")]
			get {
				const string __id = "getCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsClosed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='isClosed' and count(parameter)=0]"
			[Register ("isClosed", "()Z", "")]
			get {
				const string __id = "isClosed.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Android.OS.Bundle Metadata {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='getMetadata' and count(parameter)=0]"
			[Register ("getMetadata", "()Landroid/os/Bundle;", "")]
			get {
				const string __id = "getMetadata.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int StatusCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='getStatusCode' and count(parameter)=0]"
			[Register ("getStatusCode", "()I", "")]
			get {
				const string __id = "getStatusCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='builder' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("builder", "([Ljava/lang/String;)Lcom/huawei/hms/common/data/DataHolder$Builder;", "")]
		public static unsafe global::Huawei.Hms.Common.Data.DataHolder.Builder InvokeBuilder (string[] p0)
		{
			const string __id = "builder.([Ljava/lang/String;)Lcom/huawei/hms/common/data/DataHolder$Builder;";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataHolder.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='collectColumsAndCount' and count(parameter)=0]"
		[Register ("collectColumsAndCount", "()V", "")]
		public unsafe void CollectColumsAndCount ()
		{
			const string __id = "collectColumsAndCount.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='copyToBuffer' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.database.CharArrayBuffer']]"
		[Register ("copyToBuffer", "(Ljava/lang/String;IILandroid/database/CharArrayBuffer;)V", "")]
		public unsafe void CopyToBuffer (string p0, int p1, int p2, global::Android.Database.CharArrayBuffer p3)
		{
			const string __id = "copyToBuffer.(Ljava/lang/String;IILandroid/database/CharArrayBuffer;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='empty' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("empty", "(I)Lcom/huawei/hms/common/data/DataHolder;", "")]
		public static unsafe global::Huawei.Hms.Common.Data.DataHolder Empty (int p0)
		{
			const string __id = "empty.(I)Lcom/huawei/hms/common/data/DataHolder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='getValue' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("getValue", "(Ljava/lang/String;IILjava/lang/String;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object GetValue (string p0, int p1, int p2, string p3)
		{
			const string __id = "getValue.(Ljava/lang/String;IILjava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='getWindowIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getWindowIndex", "(I)I", "")]
		public unsafe int GetWindowIndex (int p0)
		{
			const string __id = "getWindowIndex.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='hasColumn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasColumn", "(Ljava/lang/String;)Z", "")]
		public unsafe bool HasColumn (string p0)
		{
			const string __id = "hasColumn.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='hasNull' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("hasNull", "(Ljava/lang/String;II)Z", "")]
		public unsafe bool HasNull (string p0, int p1, int p2)
		{
			const string __id = "hasNull.(Ljava/lang/String;II)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataHolder']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public override sealed unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((int) p1);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
