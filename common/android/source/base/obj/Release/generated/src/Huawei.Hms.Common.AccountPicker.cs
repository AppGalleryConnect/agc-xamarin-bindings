using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Huawei.Hms.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']"
	[global::Android.Runtime.Register ("com/huawei/hms/common/AccountPicker", DoNotGenerateAcw=true)]
	public sealed partial class AccountPicker : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='CHOOSE_ACCOUNT']"
		[Register ("CHOOSE_ACCOUNT")]
		public const string ChooseAccount = (string) "com.huawei.hms.common.account.CHOOSE_ACCOUNT";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='CUSTOM_THEME_ACCOUNT_CHIPS']"
		[Register ("CUSTOM_THEME_ACCOUNT_CHIPS")]
		public const int CustomThemeAccountChips = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='CUSTOM_THEME_GAMES']"
		[Register ("CUSTOM_THEME_GAMES")]
		public const int CustomThemeGames = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='CUSTOM_THEME_NONE']"
		[Register ("CUSTOM_THEME_NONE")]
		public const int CustomThemeNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_ADD_ACCOUNT_AUTH_TOKEN_TYPE_STRING']"
		[Register ("EXTRA_ADD_ACCOUNT_AUTH_TOKEN_TYPE_STRING")]
		public const string ExtraAddAccountAuthTokenTypeString = (string) "authTokenType";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_ADD_ACCOUNT_OPTIONS_BUNDLE']"
		[Register ("EXTRA_ADD_ACCOUNT_OPTIONS_BUNDLE")]
		public const string ExtraAddAccountOptionsBundle = (string) "addAccountOptions";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_ADD_ACCOUNT_REQUIRED_FEATURES_STRING_ARRAY']"
		[Register ("EXTRA_ADD_ACCOUNT_REQUIRED_FEATURES_STRING_ARRAY")]
		public const string ExtraAddAccountRequiredFeaturesStringArray = (string) "addAccountRequiredFeatures";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_ALLOWABLE_ACCOUNTS_ARRAYLIST']"
		[Register ("EXTRA_ALLOWABLE_ACCOUNTS_ARRAYLIST")]
		public const string ExtraAllowableAccountsArraylist = (string) "allowableAccounts";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_ALLOWABLE_ACCOUNT_TYPES_STRING_ARRAY']"
		[Register ("EXTRA_ALLOWABLE_ACCOUNT_TYPES_STRING_ARRAY")]
		public const string ExtraAllowableAccountTypesStringArray = (string) "allowableAccountTypes";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_ALWAYS_PROMPT_FOR_ACCOUNT']"
		[Register ("EXTRA_ALWAYS_PROMPT_FOR_ACCOUNT")]
		public const string ExtraAlwaysPromptForAccount = (string) "alwaysPromptForAccount";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_DESCRIPTION_TEXT_OVERRIDE']"
		[Register ("EXTRA_DESCRIPTION_TEXT_OVERRIDE")]
		public const string ExtraDescriptionTextOverride = (string) "descriptionTextOverride";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_HOSTED_DOMAIN_FILTER']"
		[Register ("EXTRA_HOSTED_DOMAIN_FILTER")]
		public const string ExtraHostedDomainFilter = (string) "hostedDomainFilter";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_IS_ACCOUNT_CHIPS_ACCOUNT_PICKER']"
		[Register ("EXTRA_IS_ACCOUNT_CHIPS_ACCOUNT_PICKER")]
		public const string ExtraIsAccountChipsAccountPicker = (string) "pickedFromAccountChips";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_OVERRIDE_CUSTOM_THEME']"
		[Register ("EXTRA_OVERRIDE_CUSTOM_THEME")]
		public const string ExtraOverrideCustomTheme = (string) "overrideCustomTheme";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_OVERRIDE_THEME']"
		[Register ("EXTRA_OVERRIDE_THEME")]
		public const string ExtraOverrideTheme = (string) "overrideTheme";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_REAL_CLIENT_PACKAGE']"
		[Register ("EXTRA_REAL_CLIENT_PACKAGE")]
		public const string ExtraRealClientPackage = (string) "realClientPackage";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_SELECTED_ACCOUNT']"
		[Register ("EXTRA_SELECTED_ACCOUNT")]
		public const string ExtraSelectedAccount = (string) "selectedAccount";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='EXTRA_SET_HMS_CORE_ACCOUNT']"
		[Register ("EXTRA_SET_HMS_CORE_ACCOUNT")]
		public const string ExtraSetHmsCoreAccount = (string) "setHmsCoreAccount";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='THEME_DEFAULT']"
		[Register ("THEME_DEFAULT")]
		public const int ThemeDefault = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/field[@name='THEME_LIGHT']"
		[Register ("THEME_LIGHT")]
		public const int ThemeLight = (int) 1;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/huawei/hms/common/AccountPicker", typeof (AccountPicker));
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

		internal AccountPicker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.common']/class[@name='AccountPicker']/method[@name='newChooseAccountIntent' and count(parameter)=8 and parameter[1][@type='android.accounts.Account'] and parameter[2][@type='java.util.ArrayList&lt;android.accounts.Account&gt;'] and parameter[3][@type='java.lang.String[]'] and parameter[4][@type='boolean'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String[]'] and parameter[8][@type='android.os.Bundle']]"
		[Register ("newChooseAccountIntent", "(Landroid/accounts/Account;Ljava/util/ArrayList;[Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/Intent;", "")]
		public static unsafe global::Android.Content.Intent NewChooseAccountIntent (global::Android.Accounts.Account p0, global::System.Collections.Generic.IList<global::Android.Accounts.Account> p1, string[] p2, bool p3, string p4, string p5, string[] p6, global::Android.OS.Bundle p7)
		{
			const string __id = "newChooseAccountIntent.(Landroid/accounts/Account;Ljava/util/ArrayList;[Ljava/lang/String;ZLjava/lang/String;Ljava/lang/String;[Ljava/lang/String;Landroid/os/Bundle;)Landroid/content/Intent;";
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Android.Accounts.Account>.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue ((p7 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p7).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
				global::System.GC.KeepAlive (p6);
				global::System.GC.KeepAlive (p7);
			}
		}

	}
}
