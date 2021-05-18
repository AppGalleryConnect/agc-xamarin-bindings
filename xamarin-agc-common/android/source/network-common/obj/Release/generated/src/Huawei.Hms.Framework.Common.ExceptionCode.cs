using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Framework.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']"
	[global::Android.Runtime.Register ("com/huawei/hms/framework/common/ExceptionCode", DoNotGenerateAcw=true)]
	public partial class ExceptionCode : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='CANCEL']"
		[Register ("CANCEL")]
		public const int Cancel = (int) 1104;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='CONNECTION_ABORT']"
		[Register ("CONNECTION_ABORT")]
		public const int ConnectionAbort = (int) 110205;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='CONNECTION_REFUSED']"
		[Register ("CONNECTION_REFUSED")]
		public const int ConnectionRefused = (int) 110209;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='CONNECTION_RESET']"
		[Register ("CONNECTION_RESET")]
		public const int ConnectionReset = (int) 110204;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='CONNECT_FAILED']"
		[Register ("CONNECT_FAILED")]
		public const int ConnectFailed = (int) 110206;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='CRASH_EXCEPTION']"
		[Register ("CRASH_EXCEPTION")]
		public const int CrashException = (int) 1103;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='INTERRUPT_CONNECT_CLOSE']"
		[Register ("INTERRUPT_CONNECT_CLOSE")]
		public const int InterruptConnectClose = (int) 110214;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='INTERRUPT_EXCEPTION']"
		[Register ("INTERRUPT_EXCEPTION")]
		public const int InterruptException = (int) 110213;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='NETWORK_CHANGED']"
		[Register ("NETWORK_CHANGED")]
		public const int NetworkChanged = (int) 110216;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='NETWORK_IO_EXCEPTION']"
		[Register ("NETWORK_IO_EXCEPTION")]
		public const int NetworkIoException = (int) 1102;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='NETWORK_UNREACHABLE']"
		[Register ("NETWORK_UNREACHABLE")]
		public const int NetworkUnreachable = (int) 110208;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='PROTOCOL_ERROR']"
		[Register ("PROTOCOL_ERROR")]
		public const int ProtocolError = (int) 110217;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='READ_ERROR']"
		[Register ("READ_ERROR")]
		public const int ReadError = (int) 110203;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='ROUTE_FAILED']"
		[Register ("ROUTE_FAILED")]
		public const int RouteFailed = (int) 110207;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='SHUTDOWN_EXCEPTION']"
		[Register ("SHUTDOWN_EXCEPTION")]
		public const int ShutdownException = (int) 110218;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='SOCKET_CLOSE']"
		[Register ("SOCKET_CLOSE")]
		public const int SocketClose = (int) 110215;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='SOCKET_CONNECT_TIMEOUT']"
		[Register ("SOCKET_CONNECT_TIMEOUT")]
		public const int SocketConnectTimeout = (int) 110221;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='SOCKET_READ_TIMEOUT']"
		[Register ("SOCKET_READ_TIMEOUT")]
		public const int SocketReadTimeout = (int) 110223;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='SOCKET_TIMEOUT']"
		[Register ("SOCKET_TIMEOUT")]
		public const int SocketTimeout = (int) 110200;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='SOCKET_WRITE_TIMEOUT']"
		[Register ("SOCKET_WRITE_TIMEOUT")]
		public const int SocketWriteTimeout = (int) 110225;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='SSL_HANDSHAKE_EXCEPTION']"
		[Register ("SSL_HANDSHAKE_EXCEPTION")]
		public const int SslHandshakeException = (int) 110211;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='SSL_PEERUNVERIFIED_EXCEPTION']"
		[Register ("SSL_PEERUNVERIFIED_EXCEPTION")]
		public const int SslPeerunverifiedException = (int) 110212;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='SSL_PROTOCOL_EXCEPTION']"
		[Register ("SSL_PROTOCOL_EXCEPTION")]
		public const int SslProtocolException = (int) 110210;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='UNABLE_TO_RESOLVE_HOST']"
		[Register ("UNABLE_TO_RESOLVE_HOST")]
		public const int UnableToResolveHost = (int) 110202;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/field[@name='UNEXPECTED_EOF']"
		[Register ("UNEXPECTED_EOF")]
		public const int UnexpectedEof = (int) 110201;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/framework/common/ExceptionCode", typeof (ExceptionCode));
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

		protected ExceptionCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/constructor[@name='ExceptionCode' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ExceptionCode ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.framework.common']/class[@name='ExceptionCode']/method[@name='getErrorCodeFromException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("getErrorCodeFromException", "(Ljava/lang/Exception;)I", "")]
		public static unsafe int GetErrorCodeFromException (global::Java.Lang.Exception p0)
		{
			const string __id = "getErrorCodeFromException.(Ljava/lang/Exception;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
