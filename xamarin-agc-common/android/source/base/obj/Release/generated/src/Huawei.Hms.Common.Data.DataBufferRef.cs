using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/data/DataBufferRef", DoNotGenerateAcw=true)]
	public partial class DataBufferRef : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/field[@name='mDataHolder']"
		[Register ("mDataHolder")]
		protected global::Huawei.Hms.Common.Data.DataHolder MDataHolder {
			get {
				const string __id = "mDataHolder.Lcom/huawei/hms/common/data/DataHolder;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataHolder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDataHolder.Lcom/huawei/hms/common/data/DataHolder;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/field[@name='mDataRow']"
		[Register ("mDataRow")]
		protected int MDataRow {
			get {
				const string __id = "mDataRow.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mDataRow.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/data/DataBufferRef", typeof (DataBufferRef));
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

		protected DataBufferRef (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/constructor[@name='DataBufferRef' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.common.data.DataHolder'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Lcom/huawei/hms/common/data/DataHolder;I)V", "")]
		public unsafe DataBufferRef (global::Huawei.Hms.Common.Data.DataHolder p0, int p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/huawei/hms/common/data/DataHolder;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getDataRow;
#pragma warning disable 0169
		static Delegate GetGetDataRowHandler ()
		{
			if (cb_getDataRow == null)
				cb_getDataRow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDataRow);
			return cb_getDataRow;
		}

		static int n_GetDataRow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataBufferRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataRow;
		}
#pragma warning restore 0169

		protected virtual unsafe int DataRow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='getDataRow' and count(parameter)=0]"
			[Register ("getDataRow", "()I", "GetGetDataRowHandler")]
			get {
				const string __id = "getDataRow.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDataValid;
#pragma warning disable 0169
		static Delegate GetIsDataValidHandler ()
		{
			if (cb_isDataValid == null)
				cb_isDataValid = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDataValid);
			return cb_isDataValid;
		}

		static bool n_IsDataValid (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataBufferRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDataValid;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDataValid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='isDataValid' and count(parameter)=0]"
			[Register ("isDataValid", "()Z", "GetIsDataValidHandler")]
			get {
				const string __id = "isDataValid.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_copyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_;
#pragma warning disable 0169
		static Delegate GetCopyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_Handler ()
		{
			if (cb_copyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_ == null)
				cb_copyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CopyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_);
			return cb_copyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_;
		}

		static void n_CopyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataBufferRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Database.CharArrayBuffer> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CopyToBuffer (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='copyToBuffer' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.database.CharArrayBuffer']]"
		[Register ("copyToBuffer", "(Ljava/lang/String;Landroid/database/CharArrayBuffer;)V", "GetCopyToBuffer_Ljava_lang_String_Landroid_database_CharArrayBuffer_Handler")]
		protected virtual unsafe void CopyToBuffer (string p0, global::Android.Database.CharArrayBuffer p1)
		{
			const string __id = "copyToBuffer.(Ljava/lang/String;Landroid/database/CharArrayBuffer;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_getBoolean_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetBoolean_Ljava_lang_String_Handler ()
		{
			if (cb_getBoolean_Ljava_lang_String_ == null)
				cb_getBoolean_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_GetBoolean_Ljava_lang_String_);
			return cb_getBoolean_Ljava_lang_String_;
		}

		static bool n_GetBoolean_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataBufferRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.GetBoolean (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='getBoolean' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getBoolean", "(Ljava/lang/String;)Z", "GetGetBoolean_Ljava_lang_String_Handler")]
		protected virtual unsafe bool GetBoolean (string p0)
		{
			const string __id = "getBoolean.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getByteArray_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetByteArray_Ljava_lang_String_Handler ()
		{
			if (cb_getByteArray_Ljava_lang_String_ == null)
				cb_getByteArray_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetByteArray_Ljava_lang_String_);
			return cb_getByteArray_Ljava_lang_String_;
		}

		static IntPtr n_GetByteArray_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataBufferRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetByteArray (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='getByteArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getByteArray", "(Ljava/lang/String;)[B", "GetGetByteArray_Ljava_lang_String_Handler")]
		protected virtual unsafe byte[] GetByteArray (string p0)
		{
			const string __id = "getByteArray.(Ljava/lang/String;)[B";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getDouble_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDouble_Ljava_lang_String_Handler ()
		{
			if (cb_getDouble_Ljava_lang_String_ == null)
				cb_getDouble_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_D) n_GetDouble_Ljava_lang_String_);
			return cb_getDouble_Ljava_lang_String_;
		}

		static double n_GetDouble_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataBufferRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.GetDouble (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='getDouble' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDouble", "(Ljava/lang/String;)D", "GetGetDouble_Ljava_lang_String_Handler")]
		protected virtual unsafe double GetDouble (string p0)
		{
			const string __id = "getDouble.(Ljava/lang/String;)D";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getFloat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFloat_Ljava_lang_String_Handler ()
		{
			if (cb_getFloat_Ljava_lang_String_ == null)
				cb_getFloat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_F) n_GetFloat_Ljava_lang_String_);
			return cb_getFloat_Ljava_lang_String_;
		}

		static float n_GetFloat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataBufferRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetFloat (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='getFloat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFloat", "(Ljava/lang/String;)F", "GetGetFloat_Ljava_lang_String_Handler")]
		protected virtual unsafe float GetFloat (string p0)
		{
			const string __id = "getFloat.(Ljava/lang/String;)F";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getInteger_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetInteger_Ljava_lang_String_Handler ()
		{
			if (cb_getInteger_Ljava_lang_String_ == null)
				cb_getInteger_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetInteger_Ljava_lang_String_);
			return cb_getInteger_Ljava_lang_String_;
		}

		static int n_GetInteger_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataBufferRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetInteger (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='getInteger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getInteger", "(Ljava/lang/String;)I", "GetGetInteger_Ljava_lang_String_Handler")]
		protected virtual unsafe int GetInteger (string p0)
		{
			const string __id = "getInteger.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getLong_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetLong_Ljava_lang_String_Handler ()
		{
			if (cb_getLong_Ljava_lang_String_ == null)
				cb_getLong_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_GetLong_Ljava_lang_String_);
			return cb_getLong_Ljava_lang_String_;
		}

		static long n_GetLong_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataBufferRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetLong (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='getLong' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLong", "(Ljava/lang/String;)J", "GetGetLong_Ljava_lang_String_Handler")]
		protected virtual unsafe long GetLong (string p0)
		{
			const string __id = "getLong.(Ljava/lang/String;)J";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetString_Ljava_lang_String_Handler ()
		{
			if (cb_getString_Ljava_lang_String_ == null)
				cb_getString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetString_Ljava_lang_String_);
			return cb_getString_Ljava_lang_String_;
		}

		static IntPtr n_GetString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataBufferRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetString (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetString_Ljava_lang_String_Handler")]
		protected virtual unsafe string GetString (string p0)
		{
			const string __id = "getString.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='getWindowIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getWindowIndex", "(I)V", "")]
		protected unsafe void GetWindowIndex (int p0)
		{
			const string __id = "getWindowIndex.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_hasColumn_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasColumn_Ljava_lang_String_Handler ()
		{
			if (cb_hasColumn_Ljava_lang_String_ == null)
				cb_hasColumn_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasColumn_Ljava_lang_String_);
			return cb_hasColumn_Ljava_lang_String_;
		}

		static bool n_HasColumn_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataBufferRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasColumn (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='hasColumn' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasColumn", "(Ljava/lang/String;)Z", "GetHasColumn_Ljava_lang_String_Handler")]
		public virtual unsafe bool HasColumn (string p0)
		{
			const string __id = "hasColumn.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_hasNull_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetHasNull_Ljava_lang_String_Handler ()
		{
			if (cb_hasNull_Ljava_lang_String_ == null)
				cb_hasNull_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasNull_Ljava_lang_String_);
			return cb_hasNull_Ljava_lang_String_;
		}

		static bool n_HasNull_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataBufferRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasNull (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='hasNull' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("hasNull", "(Ljava/lang/String;)Z", "GetHasNull_Ljava_lang_String_Handler")]
		protected virtual unsafe bool HasNull (string p0)
		{
			const string __id = "hasNull.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_parseUri_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParseUri_Ljava_lang_String_Handler ()
		{
			if (cb_parseUri_Ljava_lang_String_ == null)
				cb_parseUri_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_ParseUri_Ljava_lang_String_);
			return cb_parseUri_Ljava_lang_String_;
		}

		static IntPtr n_ParseUri_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Data.DataBufferRef> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseUri (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.data']/class[@name='DataBufferRef']/method[@name='parseUri' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseUri", "(Ljava/lang/String;)Landroid/net/Uri;", "GetParseUri_Ljava_lang_String_Handler")]
		protected virtual unsafe global::Android.Net.Uri ParseUri (string p0)
		{
			const string __id = "parseUri.(Ljava/lang/String;)Landroid/net/Uri;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
