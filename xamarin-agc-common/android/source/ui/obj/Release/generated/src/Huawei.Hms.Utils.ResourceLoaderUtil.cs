using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']"
	[global::Android.Runtime.Register ("com/huawei/hms/utils/ResourceLoaderUtil", DoNotGenerateAcw=true)]
	public abstract partial class ResourceLoaderUtil : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/field[@name='a']"
		[Register ("a")]
		public static global::Android.Content.Context A {
			get {
				const string __id = "a.Landroid/content/Context;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "a.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/field[@name='b']"
		[Register ("b")]
		public static string B {
			get {
				const string __id = "b.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "b.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/ResourceLoaderUtil", typeof (ResourceLoaderUtil));
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

		protected ResourceLoaderUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/constructor[@name='ResourceLoaderUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResourceLoaderUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/method[@name='getAnimId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAnimId", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetAnimId (string p0)
		{
			const string __id = "getAnimId.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/method[@name='getColorId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getColorId", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetColorId (string p0)
		{
			const string __id = "getColorId.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetDrawable (string p0)
		{
			const string __id = "getDrawable.(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/method[@name='getDrawableId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDrawableId", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetDrawableId (string p0)
		{
			const string __id = "getDrawableId.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/method[@name='getIdId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getIdId", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetIdId (string p0)
		{
			const string __id = "getIdId.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/method[@name='getLayoutId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getLayoutId", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetLayoutId (string p0)
		{
			const string __id = "getLayoutId.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetString (string p0)
		{
			const string __id = "getString.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("getString", "(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;", "")]
		public static unsafe string GetString (string p0, params global::Java.Lang.Object[] p1)
		{
			const string __id = "getString.(Ljava/lang/String;[Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/method[@name='getStringId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStringId", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetStringId (string p0)
		{
			const string __id = "getStringId.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/method[@name='getStyleId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getStyleId", "(Ljava/lang/String;)I", "")]
		public static unsafe int GetStyleId (string p0)
		{
			const string __id = "getStyleId.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/method[@name='getmContext' and count(parameter)=0]"
		[Register ("getmContext", "()Landroid/content/Context;", "")]
		public static unsafe global::Android.Content.Context GetmContext ()
		{
			const string __id = "getmContext.()Landroid/content/Context;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.utils']/class[@name='ResourceLoaderUtil']/method[@name='setmContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setmContext", "(Landroid/content/Context;)V", "")]
		public static unsafe void SetmContext (global::Android.Content.Context p0)
		{
			const string __id = "setmContext.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

	[global::Android.Runtime.Register ("com/huawei/hms/utils/ResourceLoaderUtil", DoNotGenerateAcw=true)]
	internal partial class ResourceLoaderUtilInvoker : ResourceLoaderUtil {

		public ResourceLoaderUtilInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/utils/ResourceLoaderUtil", typeof (ResourceLoaderUtilInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
