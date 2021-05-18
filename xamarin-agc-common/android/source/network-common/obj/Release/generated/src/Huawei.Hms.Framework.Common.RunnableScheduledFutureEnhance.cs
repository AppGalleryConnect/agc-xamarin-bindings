using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='RunnableScheduledFutureEnhance']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/RunnableScheduledFutureEnhance", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class RunnableScheduledFutureEnhance : global::Java.Lang.Object, global::Java.Util.Concurrent.IRunnableScheduledFuture {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/RunnableScheduledFutureEnhance", typeof (RunnableScheduledFutureEnhance));
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

		protected RunnableScheduledFutureEnhance (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='RunnableScheduledFutureEnhance']/constructor[@name='RunnableScheduledFutureEnhance' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.RunnableScheduledFuture&lt;T&gt;']]"
		[Register (".ctor", "(Ljava/util/concurrent/RunnableScheduledFuture;)V", "")]
		public unsafe RunnableScheduledFutureEnhance (global::Java.Util.Concurrent.IRunnableScheduledFuture p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/concurrent/RunnableScheduledFuture;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_isCancelled;
#pragma warning disable 0169
		static Delegate GetIsCancelledHandler ()
		{
			if (cb_isCancelled == null)
				cb_isCancelled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCancelled);
			return cb_isCancelled;
		}

		static bool n_IsCancelled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.RunnableScheduledFutureEnhance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCancelled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCancelled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='RunnableScheduledFutureEnhance']/method[@name='isCancelled' and count(parameter)=0]"
			[Register ("isCancelled", "()Z", "GetIsCancelledHandler")]
			get {
				const string __id = "isCancelled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDone;
#pragma warning disable 0169
		static Delegate GetIsDoneHandler ()
		{
			if (cb_isDone == null)
				cb_isDone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDone);
			return cb_isDone;
		}

		static bool n_IsDone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.RunnableScheduledFutureEnhance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDone;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDone {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='RunnableScheduledFutureEnhance']/method[@name='isDone' and count(parameter)=0]"
			[Register ("isDone", "()Z", "GetIsDoneHandler")]
			get {
				const string __id = "isDone.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPeriodic;
#pragma warning disable 0169
		static Delegate GetIsPeriodicHandler ()
		{
			if (cb_isPeriodic == null)
				cb_isPeriodic = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsPeriodic);
			return cb_isPeriodic;
		}

		static bool n_IsPeriodic (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.RunnableScheduledFutureEnhance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPeriodic;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPeriodic {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='RunnableScheduledFutureEnhance']/method[@name='isPeriodic' and count(parameter)=0]"
			[Register ("isPeriodic", "()Z", "GetIsPeriodicHandler")]
			get {
				const string __id = "isPeriodic.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getParentName;
#pragma warning disable 0169
		static Delegate GetGetParentNameHandler ()
		{
			if (cb_getParentName == null)
				cb_getParentName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetParentName);
			return cb_getParentName;
		}

		static IntPtr n_GetParentName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.RunnableScheduledFutureEnhance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ParentName);
		}
#pragma warning restore 0169

		public virtual unsafe string ParentName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='RunnableScheduledFutureEnhance']/method[@name='getParentName' and count(parameter)=0]"
			[Register ("getParentName", "()Ljava/lang/String;", "GetGetParentNameHandler")]
			get {
				const string __id = "getParentName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancel_Z;
#pragma warning disable 0169
		static Delegate GetCancel_ZHandler ()
		{
			if (cb_cancel_Z == null)
				cb_cancel_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_Z) n_Cancel_Z);
			return cb_cancel_Z;
		}

		static bool n_Cancel_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.RunnableScheduledFutureEnhance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Cancel (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='RunnableScheduledFutureEnhance']/method[@name='cancel' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("cancel", "(Z)Z", "GetCancel_ZHandler")]
		public virtual unsafe bool Cancel (bool p0)
		{
			const string __id = "cancel.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_compareTo_Ljava_util_concurrent_Delayed_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Ljava_util_concurrent_Delayed_Handler ()
		{
			if (cb_compareTo_Ljava_util_concurrent_Delayed_ == null)
				cb_compareTo_Ljava_util_concurrent_Delayed_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_CompareTo_Ljava_util_concurrent_Delayed_);
			return cb_compareTo_Ljava_util_concurrent_Delayed_;
		}

		static int n_CompareTo_Ljava_util_concurrent_Delayed_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.RunnableScheduledFutureEnhance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Java.Util.Concurrent.IDelayed)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IDelayed> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='RunnableScheduledFutureEnhance']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.Delayed']]"
		[Register ("compareTo", "(Ljava/util/concurrent/Delayed;)I", "GetCompareTo_Ljava_util_concurrent_Delayed_Handler")]
		public virtual unsafe int CompareTo (global::Java.Util.Concurrent.IDelayed p0)
		{
			const string __id = "compareTo.(Ljava/util/concurrent/Delayed;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.RunnableScheduledFutureEnhance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='RunnableScheduledFutureEnhance']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public virtual unsafe global::Java.Lang.Object Get ()
		{
			const string __id = "get.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetGet_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_get_JLjava_util_concurrent_TimeUnit_ == null)
				cb_get_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_L) n_Get_JLjava_util_concurrent_TimeUnit_);
			return cb_get_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_Get_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.RunnableScheduledFutureEnhance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='RunnableScheduledFutureEnhance']/method[@name='get' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", "GetGet_JLjava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe global::Java.Lang.Object Get (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			const string __id = "get.(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_getDelay_Ljava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetGetDelay_Ljava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_getDelay_Ljava_util_concurrent_TimeUnit_ == null)
				cb_getDelay_Ljava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_J) n_GetDelay_Ljava_util_concurrent_TimeUnit_);
			return cb_getDelay_Ljava_util_concurrent_TimeUnit_;
		}

		static long n_GetDelay_Ljava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.RunnableScheduledFutureEnhance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.GetDelay (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='RunnableScheduledFutureEnhance']/method[@name='getDelay' and count(parameter)=1 and parameter[1][@type='java.util.concurrent.TimeUnit']]"
		[Register ("getDelay", "(Ljava/util/concurrent/TimeUnit;)J", "GetGetDelay_Ljava_util_concurrent_TimeUnit_Handler")]
		public virtual unsafe long GetDelay (global::Java.Util.Concurrent.TimeUnit p0)
		{
			const string __id = "getDelay.(Ljava/util/concurrent/TimeUnit;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Framework.Common.RunnableScheduledFutureEnhance> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='RunnableScheduledFutureEnhance']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='RunnableScheduledFutureEnhance']/method[@name='CompareTo' and count(parameter)=1 and parameter[1][@type='Java.Lang.Object']]"
		[Register ("CompareTo", "(Ljava/lang/Object;)I", "")]
		public unsafe int CompareTo (global::Java.Lang.Object o)
		{
			const string __id = "CompareTo.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (o);
			}
		}

	}
}
