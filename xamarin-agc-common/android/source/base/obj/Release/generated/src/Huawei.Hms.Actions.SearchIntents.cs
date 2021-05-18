using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Actions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.actions']/class[@name='SearchIntents']"
	[global::Android.Runtime.Register ("com/huawei/hms/actions/SearchIntents", DoNotGenerateAcw=true)]
	public partial class SearchIntents : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.actions']/class[@name='SearchIntents']/field[@name='ACTION_SEARCH']"
		[Register ("ACTION_SEARCH")]
		public const string ActionSearch = (string) "com.huawei.hms.actions.SEARCH_ACTION";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.actions']/class[@name='SearchIntents']/field[@name='EXTRA_QUERY']"
		[Register ("EXTRA_QUERY")]
		public const string ExtraQuery = (string) "query";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/actions/SearchIntents", typeof (SearchIntents));
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

		protected SearchIntents (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
