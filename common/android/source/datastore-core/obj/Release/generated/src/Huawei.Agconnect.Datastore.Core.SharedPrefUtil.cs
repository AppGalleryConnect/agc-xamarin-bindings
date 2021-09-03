using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Agconnect.Datastore.Core {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.agconnect.datastore.core']/class[@name='SharedPrefUtil']"
	[global::Android.Runtime.Register ("com/huawei/agconnect/datastore/core/SharedPrefUtil", DoNotGenerateAcw=true)]
	public partial class SharedPrefUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/agconnect/datastore/core/SharedPrefUtil", typeof (SharedPrefUtil));
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

		protected SharedPrefUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Huawei.Agconnect.Datastore.Core.SharedPrefUtil Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.core']/class[@name='SharedPrefUtil']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/huawei/agconnect/datastore/core/SharedPrefUtil;", "")]
			get {
				const string __id = "getInstance.()Lcom/huawei/agconnect/datastore/core/SharedPrefUtil;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Datastore.Core.SharedPrefUtil> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_get_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_Handler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_ == null)
				cb_get_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_L) n_Get_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_);
			return cb_get_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_;
		}

		static IntPtr n_Get_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Datastore.Core.SharedPrefUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.core']/class[@name='SharedPrefUtil']/method[@name='get' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("get", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (string p0, string p1, global::Java.Lang.Class p2, global::Java.Lang.Object p3, global::Java.Lang.Class p4)
		{
			const string __id = "get.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Class;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p4);
			}
		}

		static Delegate cb_getAll_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetAll_Ljava_lang_String_Handler ()
		{
			if (cb_getAll_Ljava_lang_String_ == null)
				cb_getAll_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAll_Ljava_lang_String_);
			return cb_getAll_Ljava_lang_String_;
		}

		static IntPtr n_GetAll_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Datastore.Core.SharedPrefUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaDictionary<string, object>.ToLocalJniHandle (__this.GetAll (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.core']/class[@name='SharedPrefUtil']/method[@name='getAll' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAll", "(Ljava/lang/String;)Ljava/util/Map;", "GetGetAll_Ljava_lang_String_Handler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, object> GetAll (string p0)
		{
			const string __id = "getAll.(Ljava/lang/String;)Ljava/util/Map;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaDictionary<string, object>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.core']/class[@name='SharedPrefUtil']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context p0)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_put_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetPut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_Handler ()
		{
			if (cb_put_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_ == null)
				cb_put_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLLL_V) n_Put_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_);
			return cb_put_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_;
		}

		static void n_Put_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Datastore.Core.SharedPrefUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.Put (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.core']/class[@name='SharedPrefUtil']/method[@name='put' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Class&lt;?&gt;'] and parameter[4][@type='java.lang.Object'] and parameter[5][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("put", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Class;)V", "GetPut_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Class_Ljava_lang_Object_Ljava_lang_Class_Handler")]
		public virtual unsafe void Put (string p0, string p1, global::Java.Lang.Class p2, global::Java.Lang.Object p3, global::Java.Lang.Class p4)
		{
			const string __id = "put.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/Object;Ljava/lang/Class;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
				global::System.GC.KeepAlive (p4);
			}
		}

		static Delegate cb_remove_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_remove_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_remove_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Remove_Ljava_lang_String_Ljava_lang_String_);
			return cb_remove_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Remove_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Agconnect.Datastore.Core.SharedPrefUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.datastore.core']/class[@name='SharedPrefUtil']/method[@name='remove' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;Ljava/lang/String;)V", "GetRemove_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Remove (string p0, string p1)
		{
			const string __id = "remove.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
