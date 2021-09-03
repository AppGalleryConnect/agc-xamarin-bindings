using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='LimitQueue']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/LimitQueue", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
	public partial class LimitQueue : global::Java.Util.Concurrent.ConcurrentLinkedQueue {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/LimitQueue", typeof (LimitQueue));
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

		protected LimitQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='LimitQueue']/constructor[@name='LimitQueue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe LimitQueue (int p0)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='LimitQueue']/constructor[@name='LimitQueue' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(IZ)V", "")]
		public unsafe LimitQueue (int p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IZ)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='LimitQueue']/constructor[@name='LimitQueue' and count(parameter)=2 and parameter[1][@type='java.util.Collection&lt;? extends E&gt;'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Ljava/util/Collection;Z)V", "")]
		public unsafe LimitQueue (global::System.Collections.ICollection p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Collection;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_getLimit;
#pragma warning disable 0169
		static Delegate GetGetLimitHandler ()
		{
			if (cb_getLimit == null)
				cb_getLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLimit);
			return cb_getLimit;
		}

		static int n_GetLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.LimitQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Limit;
		}
#pragma warning restore 0169

		public virtual unsafe int Limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='LimitQueue']/method[@name='getLimit' and count(parameter)=0]"
			[Register ("getLimit", "()I", "GetGetLimitHandler")]
			get {
				const string __id = "getLimit.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_add_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_Object_Handler ()
		{
			if (cb_add_Ljava_lang_Object_ == null)
				cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Add_Ljava_lang_Object_);
			return cb_add_Ljava_lang_Object_;
		}

		static bool n_Add_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.LimitQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Add (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='LimitQueue']/method[@name='add' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("add", "(Ljava/lang/Object;)Z", "GetAdd_Ljava_lang_Object_Handler")]
		public override unsafe bool Add (global::Java.Lang.Object p0)
		{
			const string __id = "add.(Ljava/lang/Object;)Z";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_addAll_Ljava_util_Collection_;
#pragma warning disable 0169
		static Delegate GetAddAll_Ljava_util_Collection_Handler ()
		{
			if (cb_addAll_Ljava_util_Collection_ == null)
				cb_addAll_Ljava_util_Collection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_AddAll_Ljava_util_Collection_);
			return cb_addAll_Ljava_util_Collection_;
		}

		static bool n_AddAll_Ljava_util_Collection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.LimitQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaCollection.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddAll (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='LimitQueue']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;? extends E&gt;']]"
		[Register ("addAll", "(Ljava/util/Collection;)Z", "GetAddAll_Ljava_util_Collection_Handler")]
		public virtual unsafe bool AddAll (global::System.Collections.ICollection p0)
		{
			const string __id = "addAll.(Ljava/util/Collection;)Z";
			IntPtr native_p0 = global::Android.Runtime.JavaCollection.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_get_I;
#pragma warning disable 0169
		static Delegate GetGet_IHandler ()
		{
			if (cb_get_I == null)
				cb_get_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Get_I);
			return cb_get_I;
		}

		static IntPtr n_Get_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.LimitQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='LimitQueue']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Ljava/lang/Object;", "GetGet_IHandler")]
		public virtual unsafe global::Java.Lang.Object Get (int p0)
		{
			const string __id = "get.(I)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_offer_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOffer_Ljava_lang_Object_Handler ()
		{
			if (cb_offer_Ljava_lang_Object_ == null)
				cb_offer_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Offer_Ljava_lang_Object_);
			return cb_offer_Ljava_lang_Object_;
		}

		static bool n_Offer_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.LimitQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Offer (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='LimitQueue']/method[@name='offer' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("offer", "(Ljava/lang/Object;)Z", "GetOffer_Ljava_lang_Object_Handler")]
		public override unsafe bool Offer (global::Java.Lang.Object p0)
		{
			const string __id = "offer.(Ljava/lang/Object;)Z";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_peekLast;
#pragma warning disable 0169
		static Delegate GetPeekLastHandler ()
		{
			if (cb_peekLast == null)
				cb_peekLast = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_PeekLast);
			return cb_peekLast;
		}

		static IntPtr n_PeekLast (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.LimitQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekLast ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='LimitQueue']/method[@name='peekLast' and count(parameter)=0]"
		[Register ("peekLast", "()Ljava/lang/Object;", "GetPeekLastHandler")]
		public virtual unsafe global::Java.Lang.Object PeekLast ()
		{
			const string __id = "peekLast.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
