using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']"
	[global::Android.Runtime.Register ("com/huawei/hms/api/HuaweiApiClient", DoNotGenerateAcw=true)]
	public abstract partial class HuaweiApiClient : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']"
		[global::Android.Runtime.Register ("com/huawei/hms/api/HuaweiApiClient$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/HuaweiApiClient$Builder", typeof (Builder));
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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/constructor[@name='HuaweiApiClient.Builder' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe Builder (global::Android.Content.Context p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/content/Context;)V";

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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='addApi' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.Api&lt;? extends com.huawei.hms.api.Api.ApiOptions.NotRequiredOptions&gt;']]"
			[Register ("addApi", "(Lcom/huawei/hms/api/Api;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder AddApi (global::Huawei.Hms.Api.Api p0)
			{
				const string __id = "addApi.(Lcom/huawei/hms/api/Api;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='addApi' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.api.Api&lt;O&gt;'] and parameter[2][@type='O']]"
			[Register ("addApi", "(Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions$HasOptions;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			[global::Java.Interop.JavaTypeParameters (new string [] {"O extends com.huawei.hms.api.Api.ApiOptions.HasOptions"})]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder AddApi (global::Huawei.Hms.Api.Api p0, global::Java.Lang.Object p1)
			{
				const string __id = "addApi.(Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions$HasOptions;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='addApiWithScope' and count(parameter)=2 and parameter[1][@type='com.huawei.hms.api.Api&lt;? extends com.huawei.hms.api.Api.ApiOptions.NotRequiredOptions&gt;'] and parameter[2][@type='com.huawei.hms.support.api.entity.auth.Scope...']]"
			[Register ("addApiWithScope", "(Lcom/huawei/hms/api/Api;[Lcom/huawei/hms/support/api/entity/auth/Scope;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder AddApiWithScope (global::Huawei.Hms.Api.Api p0, params global::Huawei.Hms.Support.Api.Entity.Auth.Scope[] p1)
			{
				const string __id = "addApiWithScope.(Lcom/huawei/hms/api/Api;[Lcom/huawei/hms/support/api/entity/auth/Scope;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='addApiWithScope' and count(parameter)=3 and parameter[1][@type='com.huawei.hms.api.Api&lt;O&gt;'] and parameter[2][@type='O'] and parameter[3][@type='com.huawei.hms.support.api.entity.auth.Scope...']]"
			[Register ("addApiWithScope", "(Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions$HasOptions;[Lcom/huawei/hms/support/api/entity/auth/Scope;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			[global::Java.Interop.JavaTypeParameters (new string [] {"O extends com.huawei.hms.api.Api.ApiOptions.HasOptions"})]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder AddApiWithScope (global::Huawei.Hms.Api.Api p0, global::Java.Lang.Object p1, params global::Huawei.Hms.Support.Api.Entity.Auth.Scope[] p2)
			{
				const string __id = "addApiWithScope.(Lcom/huawei/hms/api/Api;Lcom/huawei/hms/api/Api$ApiOptions$HasOptions;[Lcom/huawei/hms/support/api/entity/auth/Scope;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (native_p1);
					__args [2] = new JniArgumentValue (native_p2);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='addConnectionCallbacks' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.ConnectionCallbacks']]"
			[Register ("addConnectionCallbacks", "(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder AddConnectionCallbacks (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks p0)
			{
				const string __id = "addConnectionCallbacks.(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='addOnConnectionFailedListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener']]"
			[Register ("addOnConnectionFailedListener", "(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder AddOnConnectionFailedListener (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener p0)
			{
				const string __id = "addOnConnectionFailedListener.(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='addScope' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.entity.auth.Scope']]"
			[Register ("addScope", "(Lcom/huawei/hms/support/api/entity/auth/Scope;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder AddScope (global::Huawei.Hms.Support.Api.Entity.Auth.Scope p0)
			{
				const string __id = "addScope.(Lcom/huawei/hms/support/api/entity/auth/Scope;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='allowLifeCycleManagement' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener']]"
			[Register ("allowLifeCycleManagement", "(Landroid/app/Activity;Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder AllowLifeCycleManagement (global::Android.App.Activity p0, global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener p1)
			{
				const string __id = "allowLifeCycleManagement.(Landroid/app/Activity;Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p1);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='allowLifeCycleManagement' and count(parameter)=3 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int'] and parameter[3][@type='com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener']]"
			[Register ("allowLifeCycleManagement", "(Landroid/app/Activity;ILcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder AllowLifeCycleManagement (global::Android.App.Activity p0, int p1, global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener p2)
			{
				const string __id = "allowLifeCycleManagement.(Landroid/app/Activity;ILcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
					global::System.GC.KeepAlive (p2);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='applyDefaultAccount' and count(parameter)=0]"
			[Register ("applyDefaultAccount", "()Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder ApplyDefaultAccount ()
			{
				const string __id = "applyDefaultAccount.()Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/huawei/hms/api/HuaweiApiClient;", "")]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient Build ()
			{
				const string __id = "build.()Lcom/huawei/hms/api/HuaweiApiClient;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='setAccountName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAccountName", "(Ljava/lang/String;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder SetAccountName (string p0)
			{
				const string __id = "setAccountName.(Ljava/lang/String;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='setHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
			[Register ("setHandler", "(Landroid/os/Handler;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder SetHandler (global::Android.OS.Handler p0)
			{
				const string __id = "setHandler.(Landroid/os/Handler;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='setPopupsGravity' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPopupsGravity", "(I)Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder SetPopupsGravity (int p0)
			{
				const string __id = "setPopupsGravity.(I)Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient.Builder']/method[@name='setViewForPopups' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setViewForPopups", "(Landroid/view/View;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;", "")]
			public unsafe global::Huawei.Hms.Api.HuaweiApiClient.Builder SetViewForPopups (global::Android.Views.View p0)
			{
				const string __id = "setViewForPopups.(Landroid/view/View;)Lcom/huawei/hms/api/HuaweiApiClient$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (p0);
				}
			}

		}

		[Register ("com/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks", DoNotGenerateAcw=true)]
		public abstract class ConnectionCallbacks : Java.Lang.Object {

			internal ConnectionCallbacks ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='HuaweiApiClient.ConnectionCallbacks']/field[@name='CAUSE_API_CLIENT_EXPIRED']"
			[Register ("CAUSE_API_CLIENT_EXPIRED")]
			public const int CauseApiClientExpired = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='HuaweiApiClient.ConnectionCallbacks']/field[@name='CAUSE_NETWORK_LOST']"
			[Register ("CAUSE_NETWORK_LOST")]
			public const int CauseNetworkLost = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='HuaweiApiClient.ConnectionCallbacks']/field[@name='CAUSE_SERVICE_DISCONNECTED']"
			[Register ("CAUSE_SERVICE_DISCONNECTED")]
			public const int CauseServiceDisconnected = (int) 1;
		}

		[Register ("com/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks", DoNotGenerateAcw=true)]
		[global::System.Obsolete ("Use the 'ConnectionCallbacks' type. This type will be removed in a future release.", error: true)]
		public abstract class ConnectionCallbacksConsts : ConnectionCallbacks {

			private ConnectionCallbacksConsts ()
			{
			}
		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='HuaweiApiClient.ConnectionCallbacks']"
		[Register ("com/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks", "", "Huawei.Hms.Api.HuaweiApiClient/IConnectionCallbacksInvoker")]
		public partial interface IConnectionCallbacks : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='HuaweiApiClient.ConnectionCallbacks']/method[@name='onConnected' and count(parameter)=0]"
			[Register ("onConnected", "()V", "GetOnConnectedHandler:Huawei.Hms.Api.HuaweiApiClient/IConnectionCallbacksInvoker, Huawei.Hms.Base")]
			void OnConnected ();

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='HuaweiApiClient.ConnectionCallbacks']/method[@name='onConnectionSuspended' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("onConnectionSuspended", "(I)V", "GetOnConnectionSuspended_IHandler:Huawei.Hms.Api.HuaweiApiClient/IConnectionCallbacksInvoker, Huawei.Hms.Base")]
			void OnConnectionSuspended (int p0);

		}

		[global::Android.Runtime.Register ("com/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks", DoNotGenerateAcw=true)]
		internal partial class IConnectionCallbacksInvoker : global::Java.Lang.Object, IConnectionCallbacks {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks", typeof (IConnectionCallbacksInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IConnectionCallbacks GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IConnectionCallbacks> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.api.HuaweiApiClient.ConnectionCallbacks"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IConnectionCallbacksInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onConnected;
#pragma warning disable 0169
			static Delegate GetOnConnectedHandler ()
			{
				if (cb_onConnected == null)
					cb_onConnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnConnected);
				return cb_onConnected;
			}

			static void n_OnConnected (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnConnected ();
			}
#pragma warning restore 0169

			IntPtr id_onConnected;
			public unsafe void OnConnected ()
			{
				if (id_onConnected == IntPtr.Zero)
					id_onConnected = JNIEnv.GetMethodID (class_ref, "onConnected", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnected);
			}

			static Delegate cb_onConnectionSuspended_I;
#pragma warning disable 0169
			static Delegate GetOnConnectionSuspended_IHandler ()
			{
				if (cb_onConnectionSuspended_I == null)
					cb_onConnectionSuspended_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnConnectionSuspended_I);
				return cb_onConnectionSuspended_I;
			}

			static void n_OnConnectionSuspended_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionSuspended (p0);
			}
#pragma warning restore 0169

			IntPtr id_onConnectionSuspended_I;
			public unsafe void OnConnectionSuspended (int p0)
			{
				if (id_onConnectionSuspended_I == IntPtr.Zero)
					id_onConnectionSuspended_I = JNIEnv.GetMethodID (class_ref, "onConnectionSuspended", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionSuspended_I, __args);
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='HuaweiApiClient.OnConnectionFailedListener']"
		[Register ("com/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener", "", "Huawei.Hms.Api.HuaweiApiClient/IOnConnectionFailedListenerInvoker")]
		public partial interface IOnConnectionFailedListener : IJavaObject, IJavaPeerable {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/interface[@name='HuaweiApiClient.OnConnectionFailedListener']/method[@name='onConnectionFailed' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.ConnectionResult']]"
			[Register ("onConnectionFailed", "(Lcom/huawei/hms/api/ConnectionResult;)V", "GetOnConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_Handler:Huawei.Hms.Api.HuaweiApiClient/IOnConnectionFailedListenerInvoker, Huawei.Hms.Base")]
			void OnConnectionFailed (global::Huawei.Hms.Api.ConnectionResult p0);

		}

		[global::Android.Runtime.Register ("com/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener", DoNotGenerateAcw=true)]
		internal partial class IOnConnectionFailedListenerInvoker : global::Java.Lang.Object, IOnConnectionFailedListener {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener", typeof (IOnConnectionFailedListenerInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IOnConnectionFailedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnConnectionFailedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnConnectionFailedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_;
#pragma warning disable 0169
			static Delegate GetOnConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_Handler ()
			{
				if (cb_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_ == null)
					cb_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_);
				return cb_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_;
			}

			static void n_OnConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ConnectionResult> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnConnectionFailed (p0);
			}
#pragma warning restore 0169

			IntPtr id_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_;
			public unsafe void OnConnectionFailed (global::Huawei.Hms.Api.ConnectionResult p0)
			{
				if (id_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_ == IntPtr.Zero)
					id_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_ = JNIEnv.GetMethodID (class_ref, "onConnectionFailed", "(Lcom/huawei/hms/api/ConnectionResult;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConnectionFailed_Lcom_huawei_hms_api_ConnectionResult_, __args);
			}

		}

		// event args for com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener.onConnectionFailed
		public partial class ConnectionFailedEventArgs : global::System.EventArgs {

			public ConnectionFailedEventArgs (global::Huawei.Hms.Api.ConnectionResult p0)
			{
				this.p0 = p0;
			}

			global::Huawei.Hms.Api.ConnectionResult p0;
			public global::Huawei.Hms.Api.ConnectionResult P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/huawei/hms/api/HuaweiApiClient_OnConnectionFailedListenerImplementor")]
		internal sealed partial class IOnConnectionFailedListenerImplementor : global::Java.Lang.Object, IOnConnectionFailedListener {

			object sender;

			public IOnConnectionFailedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/huawei/hms/api/HuaweiApiClient_OnConnectionFailedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ConnectionFailedEventArgs> Handler;
#pragma warning restore 0649

			public void OnConnectionFailed (global::Huawei.Hms.Api.ConnectionResult p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ConnectionFailedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnConnectionFailedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/HuaweiApiClient", typeof (HuaweiApiClient));
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

		protected HuaweiApiClient (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/constructor[@name='HuaweiApiClient' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HuaweiApiClient ()
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

		static Delegate cb_getApiMap;
#pragma warning disable 0169
		static Delegate GetGetApiMapHandler ()
		{
			if (cb_getApiMap == null)
				cb_getApiMap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetApiMap);
			return cb_getApiMap;
		}

		static IntPtr n_GetApiMap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<global::Huawei.Hms.Api.Api, global::Huawei.Hms.Api.Api.IApiOptions>.ToLocalJniHandle (__this.ApiMap);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IDictionary<global::Huawei.Hms.Api.Api, global::Huawei.Hms.Api.Api.IApiOptions> ApiMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='getApiMap' and count(parameter)=0]"
			[Register ("getApiMap", "()Ljava/util/Map;", "GetGetApiMapHandler")] get;
		}

		static Delegate cb_isConnected;
#pragma warning disable 0169
		static Delegate GetIsConnectedHandler ()
		{
			if (cb_isConnected == null)
				cb_isConnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConnected);
			return cb_isConnected;
		}

		static bool n_IsConnected (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnected;
		}
#pragma warning restore 0169

		public abstract bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")] get;
		}

		static Delegate cb_isConnecting;
#pragma warning disable 0169
		static Delegate GetIsConnectingHandler ()
		{
			if (cb_isConnecting == null)
				cb_isConnecting = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsConnecting);
			return cb_isConnecting;
		}

		static bool n_IsConnecting (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsConnecting;
		}
#pragma warning restore 0169

		public abstract bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler")] get;
		}

		static Delegate cb_getPermissionInfos;
#pragma warning disable 0169
		static Delegate GetGetPermissionInfosHandler ()
		{
			if (cb_getPermissionInfos == null)
				cb_getPermissionInfos = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPermissionInfos);
			return cb_getPermissionInfos;
		}

		static IntPtr n_GetPermissionInfos (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo>.ToLocalJniHandle (__this.PermissionInfos);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo> PermissionInfos {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='getPermissionInfos' and count(parameter)=0]"
			[Register ("getPermissionInfos", "()Ljava/util/List;", "GetGetPermissionInfosHandler")] get;
		}

		static Delegate cb_getScopes;
#pragma warning disable 0169
		static Delegate GetGetScopesHandler ()
		{
			if (cb_getScopes == null)
				cb_getScopes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScopes);
			return cb_getScopes;
		}

		static IntPtr n_GetScopes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.ToLocalJniHandle (__this.Scopes);
		}
#pragma warning restore 0169

		public abstract global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope> Scopes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='getScopes' and count(parameter)=0]"
			[Register ("getScopes", "()Ljava/util/List;", "GetGetScopesHandler")] get;
		}

		static Delegate cb_getTopActivity;
#pragma warning disable 0169
		static Delegate GetGetTopActivityHandler ()
		{
			if (cb_getTopActivity == null)
				cb_getTopActivity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTopActivity);
			return cb_getTopActivity;
		}

		static IntPtr n_GetTopActivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TopActivity);
		}
#pragma warning restore 0169

		public abstract global::Android.App.Activity TopActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='getTopActivity' and count(parameter)=0]"
			[Register ("getTopActivity", "()Landroid/app/Activity;", "GetGetTopActivityHandler")] get;
		}

		static Delegate cb_checkUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_;
#pragma warning disable 0169
		static Delegate GetCheckUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_Handler ()
		{
			if (cb_checkUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_ == null)
				cb_checkUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CheckUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_);
			return cb_checkUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_;
		}

		static void n_CheckUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Huawei.Hms.Api.ICheckUpdatelistener)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ICheckUpdatelistener> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.CheckUpdate (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='checkUpdate' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hms.api.CheckUpdatelistener']]"
		[Register ("checkUpdate", "(Landroid/app/Activity;Lcom/huawei/hms/api/CheckUpdatelistener;)V", "GetCheckUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_Handler")]
		public abstract void CheckUpdate (global::Android.App.Activity p0, global::Huawei.Hms.Api.ICheckUpdatelistener p1);

		static Delegate cb_connect_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetConnect_Landroid_app_Activity_Handler ()
		{
			if (cb_connect_Landroid_app_Activity_ == null)
				cb_connect_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Connect_Landroid_app_Activity_);
			return cb_connect_Landroid_app_Activity_;
		}

		static void n_Connect_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("connect", "(Landroid/app/Activity;)V", "GetConnect_Landroid_app_Activity_Handler")]
		public abstract void Connect (global::Android.App.Activity p0);

		static Delegate cb_connect_I;
#pragma warning disable 0169
		static Delegate GetConnect_IHandler ()
		{
			if (cb_connect_I == null)
				cb_connect_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Connect_I);
			return cb_connect_I;
		}

		static void n_Connect_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Connect (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("connect", "(I)V", "GetConnect_IHandler")]
		public virtual unsafe void Connect (int p0)
		{
			const string __id = "connect.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_connectForeground;
#pragma warning disable 0169
		static Delegate GetConnectForegroundHandler ()
		{
			if (cb_connectForeground == null)
				cb_connectForeground = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ConnectForeground);
			return cb_connectForeground;
		}

		static void n_ConnectForeground (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ConnectForeground ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='connectForeground' and count(parameter)=0]"
		[Register ("connectForeground", "()V", "GetConnectForegroundHandler")]
		public abstract void ConnectForeground ();

		static Delegate cb_disableLifeCycleManagement_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetDisableLifeCycleManagement_Landroid_app_Activity_Handler ()
		{
			if (cb_disableLifeCycleManagement_Landroid_app_Activity_ == null)
				cb_disableLifeCycleManagement_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DisableLifeCycleManagement_Landroid_app_Activity_);
			return cb_disableLifeCycleManagement_Landroid_app_Activity_;
		}

		static void n_DisableLifeCycleManagement_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DisableLifeCycleManagement (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='disableLifeCycleManagement' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("disableLifeCycleManagement", "(Landroid/app/Activity;)V", "GetDisableLifeCycleManagement_Landroid_app_Activity_Handler")]
		public abstract void DisableLifeCycleManagement (global::Android.App.Activity p0);

		static Delegate cb_discardAndReconnect;
#pragma warning disable 0169
		static Delegate GetDiscardAndReconnectHandler ()
		{
			if (cb_discardAndReconnect == null)
				cb_discardAndReconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_DiscardAndReconnect);
			return cb_discardAndReconnect;
		}

		static IntPtr n_DiscardAndReconnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DiscardAndReconnect ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='discardAndReconnect' and count(parameter)=0]"
		[Register ("discardAndReconnect", "()Lcom/huawei/hms/support/api/client/PendingResult;", "GetDiscardAndReconnectHandler")]
		public abstract global::Huawei.Hms.Support.Api.Client.PendingResult DiscardAndReconnect ();

		static Delegate cb_disconnect;
#pragma warning disable 0169
		static Delegate GetDisconnectHandler ()
		{
			if (cb_disconnect == null)
				cb_disconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Disconnect);
			return cb_disconnect;
		}

		static void n_Disconnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public abstract void Disconnect ();

		static Delegate cb_getConnectionResult_Lcom_huawei_hms_api_Api_;
#pragma warning disable 0169
		static Delegate GetGetConnectionResult_Lcom_huawei_hms_api_Api_Handler ()
		{
			if (cb_getConnectionResult_Lcom_huawei_hms_api_Api_ == null)
				cb_getConnectionResult_Lcom_huawei_hms_api_Api_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetConnectionResult_Lcom_huawei_hms_api_Api_);
			return cb_getConnectionResult_Lcom_huawei_hms_api_Api_;
		}

		static IntPtr n_GetConnectionResult_Lcom_huawei_hms_api_Api_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.Api> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetConnectionResult (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='getConnectionResult' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.Api&lt;?&gt;']]"
		[Register ("getConnectionResult", "(Lcom/huawei/hms/api/Api;)Lcom/huawei/hms/api/ConnectionResult;", "GetGetConnectionResult_Lcom_huawei_hms_api_Api_Handler")]
		public abstract global::Huawei.Hms.Api.ConnectionResult GetConnectionResult (global::Huawei.Hms.Api.Api p0);

		static Delegate cb_hasConnectedApi_Lcom_huawei_hms_api_Api_;
#pragma warning disable 0169
		static Delegate GetHasConnectedApi_Lcom_huawei_hms_api_Api_Handler ()
		{
			if (cb_hasConnectedApi_Lcom_huawei_hms_api_Api_ == null)
				cb_hasConnectedApi_Lcom_huawei_hms_api_Api_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasConnectedApi_Lcom_huawei_hms_api_Api_);
			return cb_hasConnectedApi_Lcom_huawei_hms_api_Api_;
		}

		static bool n_HasConnectedApi_Lcom_huawei_hms_api_Api_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.Api> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasConnectedApi (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='hasConnectedApi' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.Api&lt;?&gt;']]"
		[Register ("hasConnectedApi", "(Lcom/huawei/hms/api/Api;)Z", "GetHasConnectedApi_Lcom_huawei_hms_api_Api_Handler")]
		public abstract bool HasConnectedApi (global::Huawei.Hms.Api.Api p0);

		static Delegate cb_hasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_;
#pragma warning disable 0169
		static Delegate GetHasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler ()
		{
			if (cb_hasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ == null)
				cb_hasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_);
			return cb_hasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_;
		}

		static bool n_HasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasConnectionFailureListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='hasConnectionFailureListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener']]"
		[Register ("hasConnectionFailureListener", "(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)Z", "GetHasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler")]
		public abstract bool HasConnectionFailureListener (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener p0);

		static Delegate cb_hasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_;
#pragma warning disable 0169
		static Delegate GetHasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler ()
		{
			if (cb_hasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ == null)
				cb_hasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_HasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_);
			return cb_hasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_;
		}

		static bool n_HasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.HasConnectionSuccessListener (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='hasConnectionSuccessListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.ConnectionCallbacks']]"
		[Register ("hasConnectionSuccessListener", "(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)Z", "GetHasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler")]
		public abstract bool HasConnectionSuccessListener (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks p0);

		static Delegate cb_holdUpConnect;
#pragma warning disable 0169
		static Delegate GetHoldUpConnectHandler ()
		{
			if (cb_holdUpConnect == null)
				cb_holdUpConnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_HoldUpConnect);
			return cb_holdUpConnect;
		}

		static IntPtr n_HoldUpConnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HoldUpConnect ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='holdUpConnect' and count(parameter)=0]"
		[Register ("holdUpConnect", "()Lcom/huawei/hms/api/ConnectionResult;", "GetHoldUpConnectHandler")]
		public abstract global::Huawei.Hms.Api.ConnectionResult HoldUpConnect ();

		static Delegate cb_holdUpConnect_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetHoldUpConnect_JLjava_util_concurrent_TimeUnit_Handler ()
		{
			if (cb_holdUpConnect_JLjava_util_concurrent_TimeUnit_ == null)
				cb_holdUpConnect_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJL_L) n_HoldUpConnect_JLjava_util_concurrent_TimeUnit_);
			return cb_holdUpConnect_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_HoldUpConnect_JLjava_util_concurrent_TimeUnit_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HoldUpConnect (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='holdUpConnect' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("holdUpConnect", "(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/api/ConnectionResult;", "GetHoldUpConnect_JLjava_util_concurrent_TimeUnit_Handler")]
		public abstract global::Huawei.Hms.Api.ConnectionResult HoldUpConnect (long p0, global::Java.Util.Concurrent.TimeUnit p1);

		static Delegate cb_onPause_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnPause_Landroid_app_Activity_Handler ()
		{
			if (cb_onPause_Landroid_app_Activity_ == null)
				cb_onPause_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnPause_Landroid_app_Activity_);
			return cb_onPause_Landroid_app_Activity_;
		}

		static void n_OnPause_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnPause (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onPause", "(Landroid/app/Activity;)V", "GetOnPause_Landroid_app_Activity_Handler")]
		public abstract void OnPause (global::Android.App.Activity p0);

		static Delegate cb_onResume_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetOnResume_Landroid_app_Activity_Handler ()
		{
			if (cb_onResume_Landroid_app_Activity_ == null)
				cb_onResume_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnResume_Landroid_app_Activity_);
			return cb_onResume_Landroid_app_Activity_;
		}

		static void n_OnResume_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnResume (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onResume", "(Landroid/app/Activity;)V", "GetOnResume_Landroid_app_Activity_Handler")]
		public abstract void OnResume (global::Android.App.Activity p0);

		static Delegate cb_print_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrint_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler ()
		{
			if (cb_print_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ == null)
				cb_print_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLL_V) n_Print_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_);
			return cb_print_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_;
		}

		static void n_Print_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.IO.FileDescriptor> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.IO.PrintWriter> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = (string[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.Print (p0, p1, p2, p3);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='print' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.FileDescriptor'] and parameter[3][@type='java.io.PrintWriter'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("print", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "GetPrint_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler")]
		public abstract void Print (string p0, global::Java.IO.FileDescriptor p1, global::Java.IO.PrintWriter p2, string[] p3);

		static Delegate cb_reconnect;
#pragma warning disable 0169
		static Delegate GetReconnectHandler ()
		{
			if (cb_reconnect == null)
				cb_reconnect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Reconnect);
			return cb_reconnect;
		}

		static void n_Reconnect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reconnect ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='reconnect' and count(parameter)=0]"
		[Register ("reconnect", "()V", "GetReconnectHandler")]
		public abstract void Reconnect ();

		static Delegate cb_removeConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_;
#pragma warning disable 0169
		static Delegate GetRemoveConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler ()
		{
			if (cb_removeConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ == null)
				cb_removeConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_);
			return cb_removeConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_;
		}

		static void n_RemoveConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveConnectionFailureListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='removeConnectionFailureListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener']]"
		[Register ("removeConnectionFailureListener", "(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)V", "GetRemoveConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler")]
		public abstract void RemoveConnectionFailureListener (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener p0);

		static Delegate cb_removeConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_;
#pragma warning disable 0169
		static Delegate GetRemoveConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler ()
		{
			if (cb_removeConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ == null)
				cb_removeConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_);
			return cb_removeConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_;
		}

		static void n_RemoveConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveConnectionSuccessListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='removeConnectionSuccessListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.ConnectionCallbacks']]"
		[Register ("removeConnectionSuccessListener", "(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)V", "GetRemoveConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler")]
		public abstract void RemoveConnectionSuccessListener (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks p0);

		static Delegate cb_setConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_;
#pragma warning disable 0169
		static Delegate GetSetConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler ()
		{
			if (cb_setConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ == null)
				cb_setConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_);
			return cb_setConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_;
		}

		static void n_SetConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectionCallbacks (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='setConnectionCallbacks' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.ConnectionCallbacks']]"
		[Register ("setConnectionCallbacks", "(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)V", "GetSetConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler")]
		public abstract void SetConnectionCallbacks (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks p0);

		static Delegate cb_setConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_;
#pragma warning disable 0169
		static Delegate GetSetConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler ()
		{
			if (cb_setConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ == null)
				cb_setConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_);
			return cb_setConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_;
		}

		static void n_SetConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener)global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetConnectionFailedListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='setConnectionFailedListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener']]"
		[Register ("setConnectionFailedListener", "(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)V", "GetSetConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler")]
		public abstract void SetConnectionFailedListener (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener p0);

		static Delegate cb_setSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_;
#pragma warning disable 0169
		static Delegate GetSetSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_Handler ()
		{
			if (cb_setSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_ == null)
				cb_setSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_SetSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_);
			return cb_setSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_;
		}

		static bool n_SetSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.HuaweiApiClient> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.SubAppInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetSubAppInfo (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='setSubAppInfo' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.SubAppInfo']]"
		[Register ("setSubAppInfo", "(Lcom/huawei/hms/support/api/client/SubAppInfo;)Z", "GetSetSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_Handler")]
		public abstract bool SetSubAppInfo (global::Huawei.Hms.Support.Api.Client.SubAppInfo p0);

#region "Event implementation for Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener"
		public event EventHandler<global::Huawei.Hms.Api.HuaweiApiClient.ConnectionFailedEventArgs> ConnectionFailed {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener, global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListenerImplementor>(
						ref weak_implementor_SetConnectionFailedListener,
						__CreateIOnConnectionFailedListenerImplementor,
						SetConnectionFailedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener, global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListenerImplementor>(
						ref weak_implementor_SetConnectionFailedListener,
						global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListenerImplementor.__IsEmpty,
						__v => SetConnectionFailedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetConnectionFailedListener;

		global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListenerImplementor __CreateIOnConnectionFailedListenerImplementor ()
		{
			return new global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/huawei/hms/api/HuaweiApiClient", DoNotGenerateAcw=true)]
	internal partial class HuaweiApiClientInvoker : HuaweiApiClient {

		public HuaweiApiClientInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/api/HuaweiApiClient", typeof (HuaweiApiClientInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::System.Collections.Generic.IDictionary<global::Huawei.Hms.Api.Api, global::Huawei.Hms.Api.Api.IApiOptions> ApiMap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='getApiMap' and count(parameter)=0]"
			[Register ("getApiMap", "()Ljava/util/Map;", "GetGetApiMapHandler")]
			get {
				const string __id = "getApiMap.()Ljava/util/Map;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaDictionary<global::Huawei.Hms.Api.Api, global::Huawei.Hms.Api.Api.IApiOptions>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe bool IsConnected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='isConnected' and count(parameter)=0]"
			[Register ("isConnected", "()Z", "GetIsConnectedHandler")]
			get {
				const string __id = "isConnected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe bool IsConnecting {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='isConnecting' and count(parameter)=0]"
			[Register ("isConnecting", "()Z", "GetIsConnectingHandler")]
			get {
				const string __id = "isConnecting.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo> PermissionInfos {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='getPermissionInfos' and count(parameter)=0]"
			[Register ("getPermissionInfos", "()Ljava/util/List;", "GetGetPermissionInfosHandler")]
			get {
				const string __id = "getPermissionInfos.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.PermissionInfo>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::System.Collections.Generic.IList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope> Scopes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='getScopes' and count(parameter)=0]"
			[Register ("getScopes", "()Ljava/util/List;", "GetGetScopesHandler")]
			get {
				const string __id = "getScopes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Huawei.Hms.Support.Api.Entity.Auth.Scope>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.App.Activity TopActivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='getTopActivity' and count(parameter)=0]"
			[Register ("getTopActivity", "()Landroid/app/Activity;", "GetGetTopActivityHandler")]
			get {
				const string __id = "getTopActivity.()Landroid/app/Activity;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.App.Activity> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='checkUpdate' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='com.huawei.hms.api.CheckUpdatelistener']]"
		[Register ("checkUpdate", "(Landroid/app/Activity;Lcom/huawei/hms/api/CheckUpdatelistener;)V", "GetCheckUpdate_Landroid_app_Activity_Lcom_huawei_hms_api_CheckUpdatelistener_Handler")]
		public override unsafe void CheckUpdate (global::Android.App.Activity p0, global::Huawei.Hms.Api.ICheckUpdatelistener p1)
		{
			const string __id = "checkUpdate.(Landroid/app/Activity;Lcom/huawei/hms/api/CheckUpdatelistener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='connect' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("connect", "(Landroid/app/Activity;)V", "GetConnect_Landroid_app_Activity_Handler")]
		public override unsafe void Connect (global::Android.App.Activity p0)
		{
			const string __id = "connect.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='connectForeground' and count(parameter)=0]"
		[Register ("connectForeground", "()V", "GetConnectForegroundHandler")]
		public override unsafe void ConnectForeground ()
		{
			const string __id = "connectForeground.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='disableLifeCycleManagement' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("disableLifeCycleManagement", "(Landroid/app/Activity;)V", "GetDisableLifeCycleManagement_Landroid_app_Activity_Handler")]
		public override unsafe void DisableLifeCycleManagement (global::Android.App.Activity p0)
		{
			const string __id = "disableLifeCycleManagement.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='discardAndReconnect' and count(parameter)=0]"
		[Register ("discardAndReconnect", "()Lcom/huawei/hms/support/api/client/PendingResult;", "GetDiscardAndReconnectHandler")]
		public override unsafe global::Huawei.Hms.Support.Api.Client.PendingResult DiscardAndReconnect ()
		{
			const string __id = "discardAndReconnect.()Lcom/huawei/hms/support/api/client/PendingResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Support.Api.Client.PendingResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='disconnect' and count(parameter)=0]"
		[Register ("disconnect", "()V", "GetDisconnectHandler")]
		public override unsafe void Disconnect ()
		{
			const string __id = "disconnect.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='getConnectionResult' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.Api&lt;?&gt;']]"
		[Register ("getConnectionResult", "(Lcom/huawei/hms/api/Api;)Lcom/huawei/hms/api/ConnectionResult;", "GetGetConnectionResult_Lcom_huawei_hms_api_Api_Handler")]
		public override unsafe global::Huawei.Hms.Api.ConnectionResult GetConnectionResult (global::Huawei.Hms.Api.Api p0)
		{
			const string __id = "getConnectionResult.(Lcom/huawei/hms/api/Api;)Lcom/huawei/hms/api/ConnectionResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ConnectionResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='hasConnectedApi' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.Api&lt;?&gt;']]"
		[Register ("hasConnectedApi", "(Lcom/huawei/hms/api/Api;)Z", "GetHasConnectedApi_Lcom_huawei_hms_api_Api_Handler")]
		public override unsafe bool HasConnectedApi (global::Huawei.Hms.Api.Api p0)
		{
			const string __id = "hasConnectedApi.(Lcom/huawei/hms/api/Api;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='hasConnectionFailureListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener']]"
		[Register ("hasConnectionFailureListener", "(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)Z", "GetHasConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler")]
		public override unsafe bool HasConnectionFailureListener (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener p0)
		{
			const string __id = "hasConnectionFailureListener.(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='hasConnectionSuccessListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.ConnectionCallbacks']]"
		[Register ("hasConnectionSuccessListener", "(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)Z", "GetHasConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler")]
		public override unsafe bool HasConnectionSuccessListener (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks p0)
		{
			const string __id = "hasConnectionSuccessListener.(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='holdUpConnect' and count(parameter)=0]"
		[Register ("holdUpConnect", "()Lcom/huawei/hms/api/ConnectionResult;", "GetHoldUpConnectHandler")]
		public override unsafe global::Huawei.Hms.Api.ConnectionResult HoldUpConnect ()
		{
			const string __id = "holdUpConnect.()Lcom/huawei/hms/api/ConnectionResult;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ConnectionResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='holdUpConnect' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='java.util.concurrent.TimeUnit']]"
		[Register ("holdUpConnect", "(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/api/ConnectionResult;", "GetHoldUpConnect_JLjava_util_concurrent_TimeUnit_Handler")]
		public override unsafe global::Huawei.Hms.Api.ConnectionResult HoldUpConnect (long p0, global::Java.Util.Concurrent.TimeUnit p1)
		{
			const string __id = "holdUpConnect.(JLjava/util/concurrent/TimeUnit;)Lcom/huawei/hms/api/ConnectionResult;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Huawei.Hms.Api.ConnectionResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='onPause' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onPause", "(Landroid/app/Activity;)V", "GetOnPause_Landroid_app_Activity_Handler")]
		public override unsafe void OnPause (global::Android.App.Activity p0)
		{
			const string __id = "onPause.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='onResume' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("onResume", "(Landroid/app/Activity;)V", "GetOnResume_Landroid_app_Activity_Handler")]
		public override unsafe void OnResume (global::Android.App.Activity p0)
		{
			const string __id = "onResume.(Landroid/app/Activity;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='print' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.io.FileDescriptor'] and parameter[3][@type='java.io.PrintWriter'] and parameter[4][@type='java.lang.String[]']]"
		[Register ("print", "(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V", "GetPrint_Ljava_lang_String_Ljava_io_FileDescriptor_Ljava_io_PrintWriter_arrayLjava_lang_String_Handler")]
		public override unsafe void Print (string p0, global::Java.IO.FileDescriptor p1, global::Java.IO.PrintWriter p2, string[] p3)
		{
			const string __id = "print.(Ljava/lang/String;Ljava/io/FileDescriptor;Ljava/io/PrintWriter;[Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='reconnect' and count(parameter)=0]"
		[Register ("reconnect", "()V", "GetReconnectHandler")]
		public override unsafe void Reconnect ()
		{
			const string __id = "reconnect.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='removeConnectionFailureListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener']]"
		[Register ("removeConnectionFailureListener", "(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)V", "GetRemoveConnectionFailureListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler")]
		public override unsafe void RemoveConnectionFailureListener (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener p0)
		{
			const string __id = "removeConnectionFailureListener.(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='removeConnectionSuccessListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.ConnectionCallbacks']]"
		[Register ("removeConnectionSuccessListener", "(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)V", "GetRemoveConnectionSuccessListener_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler")]
		public override unsafe void RemoveConnectionSuccessListener (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks p0)
		{
			const string __id = "removeConnectionSuccessListener.(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='setConnectionCallbacks' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.ConnectionCallbacks']]"
		[Register ("setConnectionCallbacks", "(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)V", "GetSetConnectionCallbacks_Lcom_huawei_hms_api_HuaweiApiClient_ConnectionCallbacks_Handler")]
		public override unsafe void SetConnectionCallbacks (global::Huawei.Hms.Api.HuaweiApiClient.IConnectionCallbacks p0)
		{
			const string __id = "setConnectionCallbacks.(Lcom/huawei/hms/api/HuaweiApiClient$ConnectionCallbacks;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='setConnectionFailedListener' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.api.HuaweiApiClient.OnConnectionFailedListener']]"
		[Register ("setConnectionFailedListener", "(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)V", "GetSetConnectionFailedListener_Lcom_huawei_hms_api_HuaweiApiClient_OnConnectionFailedListener_Handler")]
		public override unsafe void SetConnectionFailedListener (global::Huawei.Hms.Api.HuaweiApiClient.IOnConnectionFailedListener p0)
		{
			const string __id = "setConnectionFailedListener.(Lcom/huawei/hms/api/HuaweiApiClient$OnConnectionFailedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.api']/class[@name='HuaweiApiClient']/method[@name='setSubAppInfo' and count(parameter)=1 and parameter[1][@type='com.huawei.hms.support.api.client.SubAppInfo']]"
		[Register ("setSubAppInfo", "(Lcom/huawei/hms/support/api/client/SubAppInfo;)Z", "GetSetSubAppInfo_Lcom_huawei_hms_support_api_client_SubAppInfo_Handler")]
		public override unsafe bool SetSubAppInfo (global::Huawei.Hms.Support.Api.Client.SubAppInfo p0)
		{
			const string __id = "setSubAppInfo.(Lcom/huawei/hms/support/api/client/SubAppInfo;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

}
