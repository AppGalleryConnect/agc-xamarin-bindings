using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common.Sqlite {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common.sqlite']/class[@name='HMSCursorWrapper']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/sqlite/HMSCursorWrapper", DoNotGenerateAcw=true)]
	public partial class HMSCursorWrapper : global::Android.Database.CursorWrapper, global::Android.Database.ICrossProcessCursor {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/sqlite/HMSCursorWrapper", typeof (HMSCursorWrapper));
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

		protected HMSCursorWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.common.sqlite']/class[@name='HMSCursorWrapper']/constructor[@name='HMSCursorWrapper' and count(parameter)=1 and parameter[1][@type='android.database.Cursor']]"
		[Register (".ctor", "(Landroid/database/Cursor;)V", "")]
		public unsafe HMSCursorWrapper (global::Android.Database.ICursor p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/database/Cursor;)V";

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

		static Delegate cb_getWindow;
#pragma warning disable 0169
		static Delegate GetGetWindowHandler ()
		{
			if (cb_getWindow == null)
				cb_getWindow = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetWindow);
			return cb_getWindow;
		}

		static IntPtr n_GetWindow (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Sqlite.HMSCursorWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Window);
		}
#pragma warning restore 0169

		static Delegate cb_setWindow_Landroid_database_CursorWindow_;
#pragma warning disable 0169
		static Delegate GetSetWindow_Landroid_database_CursorWindow_Handler ()
		{
			if (cb_setWindow_Landroid_database_CursorWindow_ == null)
				cb_setWindow_Landroid_database_CursorWindow_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetWindow_Landroid_database_CursorWindow_);
			return cb_setWindow_Landroid_database_CursorWindow_;
		}

		static void n_SetWindow_Landroid_database_CursorWindow_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Sqlite.HMSCursorWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Database.CursorWindow> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Window = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Database.CursorWindow Window {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.sqlite']/class[@name='HMSCursorWrapper']/method[@name='getWindow' and count(parameter)=0]"
			[Register ("getWindow", "()Landroid/database/CursorWindow;", "GetGetWindowHandler")]
			get {
				const string __id = "getWindow.()Landroid/database/CursorWindow;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Database.CursorWindow> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.sqlite']/class[@name='HMSCursorWrapper']/method[@name='setWindow' and count(parameter)=1 and parameter[1][@type='android.database.CursorWindow']]"
			[Register ("setWindow", "(Landroid/database/CursorWindow;)V", "GetSetWindow_Landroid_database_CursorWindow_Handler")]
			set {
				const string __id = "setWindow.(Landroid/database/CursorWindow;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_fillWindow_ILandroid_database_CursorWindow_;
#pragma warning disable 0169
		static Delegate GetFillWindow_ILandroid_database_CursorWindow_Handler ()
		{
			if (cb_fillWindow_ILandroid_database_CursorWindow_ == null)
				cb_fillWindow_ILandroid_database_CursorWindow_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_FillWindow_ILandroid_database_CursorWindow_);
			return cb_fillWindow_ILandroid_database_CursorWindow_;
		}

		static void n_FillWindow_ILandroid_database_CursorWindow_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Sqlite.HMSCursorWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Android.Database.CursorWindow> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.FillWindow (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.sqlite']/class[@name='HMSCursorWrapper']/method[@name='fillWindow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.database.CursorWindow']]"
		[Register ("fillWindow", "(ILandroid/database/CursorWindow;)V", "GetFillWindow_ILandroid_database_CursorWindow_Handler")]
		public virtual unsafe void FillWindow (int p0, global::Android.Database.CursorWindow p1)
		{
			const string __id = "fillWindow.(ILandroid/database/CursorWindow;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		static Delegate cb_onMove_II;
#pragma warning disable 0169
		static Delegate GetOnMove_IIHandler ()
		{
			if (cb_onMove_II == null)
				cb_onMove_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_Z) n_OnMove_II);
			return cb_onMove_II;
		}

		static bool n_OnMove_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Common.Sqlite.HMSCursorWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnMove (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common.sqlite']/class[@name='HMSCursorWrapper']/method[@name='onMove' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onMove", "(II)Z", "GetOnMove_IIHandler")]
		public virtual unsafe bool OnMove (int p0, int p1)
		{
			const string __id = "onMove.(II)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
