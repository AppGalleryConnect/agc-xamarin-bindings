/*
 * Copyright 2021. Huawei Technologies Co., Ltd. All rights reserved.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

     http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using System;
using Foundation;
using Huawei.Agconnect.AgconnectCore;
using ObjCRuntime;

namespace Huawei.Agconnect.Auth
{
	// @interface AGCAuthCredential : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCAuthCredential
	{
		// @property (readonly, nonatomic) AGCAuthProviderType provider;
		[Export("provider")]
		AGCAuthProviderType Provider { get; }
	}

	// @interface AGCAppleIDAuthProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCAppleIDAuthProvider
	{
		// +(AGCAuthCredential * _Nonnull)credentialWithIdentityToken:(NSData * _Nonnull)identityToken nonce:(NSString * _Nonnull)nonce;
		[Static]
		[Export("credentialWithIdentityToken:nonce:")]
		AGCAuthCredential CredentialWithIdentityToken(NSData identityToken, string nonce);

		// +(AGCAuthCredential * _Nonnull)credentialWithIdentityToken:(NSData * _Nonnull)identityToken nonce:(NSString * _Nonnull)nonce autoCreateUser:(BOOL)autoCreateUser;
		[Static]
		[Export("credentialWithIdentityToken:nonce:autoCreateUser:")]
		AGCAuthCredential CredentialWithIdentityToken(NSData identityToken, string nonce, bool autoCreateUser);
	}
	public interface IAGCSignInResult { }
	// @interface AGCSignInResult : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface AGCSignInResult
	{
		// @property (readonly, nonatomic) AGCUser * _Nonnull user;
		[Export("user")]
		AGCUser User { get; }

		// -(instancetype _Nonnull)initWithUser:(AGCUser * _Nonnull)user __attribute__((objc_designated_initializer));
		[Export("initWithUser:")]
		[DesignatedInitializer]
		IntPtr Constructor(AGCUser user);
	}

	// @interface AGCTokenSnapshot : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface AGCTokenSnapshot
	{
		// @property (readonly, nonatomic) AGCTokenState state;
		[Export("state")]
		AGCTokenState State { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable token;
		[NullAllowed, Export("token")]
		string Token { get; }

		// -(instancetype _Nonnull)initWithToken:(AGCTokenState)state;
		[Export("initWithToken:")]
		IntPtr Constructor(AGCTokenState state);

		// -(instancetype _Nonnull)initWithState:(AGCTokenState)state token:(NSString * _Nullable)token;
		[Export("initWithState:token:")]
		IntPtr Constructor(AGCTokenState state, [NullAllowed] string token);
	}

	// @interface AGCProfileRequest : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCProfileRequest
	{
		// @property (nonatomic) NSString * _Nonnull displayName;
		[Export("displayName")]
		string DisplayName { get; set; }

		// @property (nonatomic) NSString * _Nonnull photoUrl;
		[Export("photoUrl")]
		string PhotoUrl { get; set; }
	}

	// @interface AGCUserExtra : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface AGCUserExtra
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull createTime;
		[Export("createTime")]
		string CreateTime { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull lastSignInTime;
		[Export("lastSignInTime")]
		string LastSignInTime { get; }

		// -(instancetype _Nonnull)initWithCreateTime:(NSString * _Nonnull)createTime lastSignInTime:(NSString * _Nonnull)signInTime __attribute__((objc_designated_initializer));
		[Export("initWithCreateTime:lastSignInTime:")]
		[DesignatedInitializer]
		IntPtr Constructor(string createTime, string signInTime);
	}

	// @interface AGCTokenResult : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface AGCTokenResult
	{
		// @property (readonly, copy, nonatomic) NSString * _Nonnull token;
		[Export("token")]
		string Token { get; }

		// @property (readonly, nonatomic) long expirePeriod;
		[Export("expirePeriod")]
		nint ExpirePeriod { get; }

		// -(instancetype _Nonnull)initWithToken:(NSString * _Nonnull)token expirePeriod:(long)expirePeriod __attribute__((objc_designated_initializer));
		[Export("initWithToken:expirePeriod:")]
		[DesignatedInitializer]
		IntPtr Constructor(string token, nint expirePeriod);
	}

	// @interface AGCUser : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCUser
	{
		// @property (readonly, nonatomic) BOOL isAnonymous;
		[Export("isAnonymous")]
		bool IsAnonymous { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull uid;
		[Export("uid")]
		string Uid { get; }

		// @property (readonly, nonatomic) NSString * _Nullable email;
		[NullAllowed, Export("email")]
		string Email { get; }

		// @property (readonly, nonatomic) NSString * _Nullable phone;
		[NullAllowed, Export("phone")]
		string Phone { get; }

		// @property (readonly, nonatomic) NSString * _Nullable displayName;
		[NullAllowed, Export("displayName")]
		string DisplayName { get; }

		// @property (readonly, nonatomic) NSString * _Nullable photoUrl;
		[NullAllowed, Export("photoUrl")]
		string PhotoUrl { get; }

		// @property (readonly, nonatomic) AGCAuthProviderType providerId;
		[Export("providerId")]
		AGCAuthProviderType ProviderId { get; }

		// @property (readonly, nonatomic) NSArray<NSDictionary<NSString *,id> *> * _Nullable providerInfo;
		[NullAllowed, Export("providerInfo")]
		NSDictionary<NSString, NSObject>[] ProviderInfo { get; }

		// @property (readonly, nonatomic) NSInteger emailVerified;
		[Export("emailVerified")]
		nint EmailVerified { get; }

		// @property (readonly, nonatomic) NSInteger passwordSetted;
		[Export("passwordSetted")]
		nint PasswordSetted { get; }

		// -(id)link:(AGCAuthCredential * _Nonnull)credential;
		[Export("link:")]
		HMFTask<NSObject> Link(AGCAuthCredential credential);

		// -(id)unlink:(AGCAuthProviderType)provider;
		[Export("unlink:")]
		HMFTask<NSObject> Unlink(AGCAuthProviderType provider);

		// -(id)updateProfile:(AGCProfileRequest * _Nonnull)userProfile;
		[Export("updateProfile:")]
		HMFTask<NSObject> UpdateProfile(AGCProfileRequest userProfile);

		// -(id)updateEmail:(NSString * _Nonnull)newEmail verifyCode:(NSString * _Nonnull)newVerifyCode;
		[Export("updateEmail:verifyCode:")]
		HMFTask<NSObject> UpdateEmail(string newEmail, string newVerifyCode);

		// -(id)updateEmail:(NSString * _Nonnull)newEmail verifyCode:(NSString * _Nonnull)newVerifyCode locale:(NSLocale * _Nullable)locale;
		[Export("updateEmail:verifyCode:locale:")]
		HMFTask<NSObject> UpdateEmail(string newEmail, string newVerifyCode, [NullAllowed] NSLocale locale);

		// -(id)updatePhoneWithCountryCode:(NSString * _Nonnull)countryCode phoneNumber:(NSString * _Nonnull)phoneNumber verifyCode:(NSString * _Nonnull)newVerifyCode;
		[Export("updatePhoneWithCountryCode:phoneNumber:verifyCode:")]
		HMFTask<NSObject> UpdatePhoneWithCountryCode(string countryCode, string phoneNumber, string newVerifyCode);

		// -(id)updatePhoneWithCountryCode:(NSString * _Nonnull)countryCode phoneNumber:(NSString * _Nonnull)phoneNumber verifyCode:(NSString * _Nonnull)newVerifyCode locale:(NSLocale * _Nullable)locale;
		[Export("updatePhoneWithCountryCode:phoneNumber:verifyCode:locale:")]
		HMFTask<NSObject> UpdatePhoneWithCountryCode(string countryCode, string phoneNumber, string newVerifyCode, [NullAllowed] NSLocale locale);

		// -(id)updatePassword:(NSString * _Nonnull)newPassword verifyCode:(NSString * _Nonnull)verifyCode provider:(NSInteger)provider;
		[Export("updatePassword:verifyCode:provider:")]
		HMFTask<NSObject> UpdatePassword(string newPassword, string verifyCode, nint provider);

		// -(id)getUserExtra;
		[Export("getUserExtra")]
		HMFTask<NSObject> UserExtra { get; }

		// -(id)getToken:(BOOL)isForceRefresh;
		[Export("getToken:")]
		HMFTask<NSObject> GetToken(bool isForceRefresh);
	}

	//public interface IAGCAuth {}
	// @interface AGCAuth : NSObject
	[DisableDefaultCtor]
	[BaseType(typeof(NSObject))]
	interface AGCAuth
	{
		// @property (readonly, nonatomic, strong) AGCUser * _Nullable currentUser;
		[NullAllowed, Export("currentUser", ArgumentSemantic.Strong)]
		AGCUser CurrentUser { get; }

		// +(instancetype _Nonnull)getInstance __attribute__((swift_name("instance()")));
		[Static]
		[Export("getInstance")]
		AGCAuth GetInstance();

		// -(id)signIn:(AGCAuthCredential * _Nonnull)credential __attribute__((swift_name("signIn(credential:)")));
		[Export("signIn:")]
		HMFTask<NSObject> SignIn(AGCAuthCredential credential);

		// -(id)signInAnonymously;
		//[Internal]
		[Export("signInAnonymously")]
		HMFTask<NSObject> SignInAnonymously();

		// -(id)deleteUser;
		[Export("deleteUser")]
		HMFTask<NSObject> DeleteUser();

		// -(void)signOut;
		[Export("signOut")]
		void SignOut();

		// -(void)addTokenListener:(void (^ _Nonnull)(AGCTokenSnapshot * _Nonnull))listener;
		[Export("addTokenListener:")]
		void AddTokenListener(Action<AGCTokenSnapshot> listener);

		// -(void)removeTokenListener:(void (^ _Nonnull)(AGCTokenSnapshot * _Nonnull))listener;
		[Export("removeTokenListener:")]
		void RemoveTokenListener(Action<AGCTokenSnapshot> listener);

		// -(id)createUserWithEmail:(NSString * _Nonnull)email password:(NSString * _Nullable)password verifyCode:(NSString * _Nonnull)verifyCode;
		[Export("createUserWithEmail:password:verifyCode:")]
		HMFTask<NSObject> CreateUserWithEmail(string email, [NullAllowed] string password, string verifyCode);

		// -(id)createUserWithCountryCode:(NSString * _Nonnull)countryCode phoneNumber:(NSString * _Nonnull)phoneNumber password:(NSString * _Nullable)password verifyCode:(NSString * _Nonnull)verifyCode;
		[Export("createUserWithCountryCode:phoneNumber:password:verifyCode:")]
		HMFTask<NSObject> CreateUserWithCountryCode(string countryCode, string phoneNumber, [NullAllowed] string password, string verifyCode);

		// -(id)resetPasswordWithEmail:(NSString * _Nonnull)email newPassword:(NSString * _Nonnull)password verifyCode:(NSString * _Nonnull)verifyCode;
		[Export("resetPasswordWithEmail:newPassword:verifyCode:")]
		HMFTask<NSObject> ResetPasswordWithEmail(string email, string password, string verifyCode);

		// -(id)resetPasswordWithCountryCode:(NSString * _Nonnull)countryCode phoneNumber:(NSString * _Nonnull)phoneNumber newPassword:(NSString * _Nonnull)password verifyCode:(NSString * _Nonnull)verifyCode;
		[Export("resetPasswordWithCountryCode:phoneNumber:newPassword:verifyCode:")]
		HMFTask<NSObject> ResetPasswordWithCountryCode(string countryCode, string phoneNumber, string password, string verifyCode);
	}

	// @interface AGCAuthError : NSError
	[BaseType(typeof(NSError))]
	interface AGCAuthError
	{
	}

	// @interface AGCVerifyCodeResult : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface AGCVerifyCodeResult
	{
		// @property (readonly, nonatomic) NSString * _Nonnull shortestInterval;
		[Export("shortestInterval")]
		string ShortestInterval { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull validityPeriod;
		[Export("validityPeriod")]
		string ValidityPeriod { get; }

		// -(instancetype _Nonnull)initWithShortestInterval:(NSString * _Nonnull)interval validityPeriod:(NSString * _Nonnull)period __attribute__((objc_designated_initializer));
		[Export("initWithShortestInterval:validityPeriod:")]
		[DesignatedInitializer]
		IntPtr Constructor(string interval, string period);
	}

	// @interface AGCVerifyCodeSettings : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface AGCVerifyCodeSettings
	{
		// @property (readonly, nonatomic) AGCVerifyCodeAction action;
		[Export("action")]
		AGCVerifyCodeAction Action { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull lang;
		[Export("lang")]
		string Lang { get; }

		// @property (readonly, nonatomic) NSInteger sendInterval;
		[Export("sendInterval")]
		nint SendInterval { get; }

		// -(instancetype _Nonnull)initWithAction:(AGCVerifyCodeAction)action locale:(NSLocale * _Nullable)locale sendInterval:(NSInteger)interval __attribute__((objc_designated_initializer));
		[Export("initWithAction:locale:sendInterval:")]
		[DesignatedInitializer]
		IntPtr Constructor(AGCVerifyCodeAction action, [NullAllowed] NSLocale locale, nint interval);

		// -(instancetype _Nonnull)initWithAction:(AGCVerifyCodeAction)action locale:(NSLocale * _Nullable)locale __attribute__((objc_designated_initializer));
		[Export("initWithAction:locale:")]
		[DesignatedInitializer]
		IntPtr Constructor(AGCVerifyCodeAction action, [NullAllowed] NSLocale locale);
	}

	// @interface AGCEmailAuthProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCEmailAuthProvider
	{
		// +(AGCAuthCredential * _Nonnull)credentialWithEmail:(NSString * _Nonnull)email password:(NSString * _Nonnull)password;
		[Static]
		[Export("credentialWithEmail:password:")]
		AGCAuthCredential CredentialWithEmail(string email, string password);

		// +(AGCAuthCredential * _Nonnull)credentialWithEmail:(NSString * _Nonnull)email password:(NSString * _Nullable)password verifyCode:(NSString * _Nonnull)verifyCode;
		[Static]
		[Export("credentialWithEmail:password:verifyCode:")]
		AGCAuthCredential CredentialWithEmail(string email, [NullAllowed] string password, string verifyCode);

		// +(id)requestVerifyCodeWithEmail:(NSString * _Nonnull)email settings:(AGCVerifyCodeSettings * _Nonnull)settings;
		[Static]
		[Export("requestVerifyCodeWithEmail:settings:")]
		HMFTask<NSObject> RequestVerifyCodeWithEmail(string email, AGCVerifyCodeSettings settings);
	}

	// @interface AGCFacebookAuthProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCFacebookAuthProvider
	{
		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token;
		[Static]
		[Export("credentialWithToken:")]
		AGCAuthCredential CredentialWithToken(string token);

		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token autoCreateUser:(BOOL)autoCreateUser;
		[Static]
		[Export("credentialWithToken:autoCreateUser:")]
		AGCAuthCredential CredentialWithToken(string token, bool autoCreateUser);
	}

	// @interface AGCGoogleAuthProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCGoogleAuthProvider
	{
		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token;
		[Static]
		[Export("credentialWithToken:")]
		AGCAuthCredential CredentialWithToken(string token);

		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token autoCreateUser:(BOOL)autoCreateUser;
		[Static]
		[Export("credentialWithToken:autoCreateUser:")]
		AGCAuthCredential CredentialWithToken(string token, bool autoCreateUser);
	}

	// @interface AGCPhoneAuthProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCPhoneAuthProvider
	{
		// +(AGCAuthCredential * _Nonnull)credentialWithCountryCode:(NSString * _Nonnull)countryCode phoneNumber:(NSString * _Nonnull)phoneNumber password:(NSString * _Nonnull)password;
		[Static]
		[Export("credentialWithCountryCode:phoneNumber:password:")]
		AGCAuthCredential CredentialWithCountryCode(string countryCode, string phoneNumber, string password);

		// +(AGCAuthCredential * _Nonnull)credentialWithCountryCode:(NSString * _Nonnull)countryCode phoneNumber:(NSString * _Nonnull)phoneNumber password:(NSString * _Nullable)password verifyCode:(NSString * _Nonnull)verifyCode;
		[Static]
		[Export("credentialWithCountryCode:phoneNumber:password:verifyCode:")]
		AGCAuthCredential CredentialWithCountryCode(string countryCode, string phoneNumber, [NullAllowed] string password, string verifyCode);

		// +(id)requestVerifyCodeWithCountryCode:(NSString * _Nonnull)countryCode phoneNumber:(NSString * _Nonnull)phoneNumber settings:(AGCVerifyCodeSettings * _Nonnull)settings;
		[Static]
		[Export("requestVerifyCodeWithCountryCode:phoneNumber:settings:")]
		HMFTask<NSObject> RequestVerifyCodeWithCountryCode(string countryCode, string phoneNumber, AGCVerifyCodeSettings settings);
	}

	// @interface AGCQQAuthProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCQQAuthProvider
	{
		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token openId:(NSString * _Nonnull)openId;
		[Static]
		[Export("credentialWithToken:openId:")]
		AGCAuthCredential CredentialWithToken(string token, string openId);

		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token openId:(NSString * _Nonnull)openId autoCreateUser:(BOOL)autoCreateUser;
		[Static]
		[Export("credentialWithToken:openId:autoCreateUser:")]
		AGCAuthCredential CredentialWithToken(string token, string openId, bool autoCreateUser);
	}

	// @interface AGCSelfBuildAuthProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCSelfBuildAuthProvider
	{
		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token;
		[Static]
		[Export("credentialWithToken:")]
		AGCAuthCredential CredentialWithToken(string token);

		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token autoCreateUser:(BOOL)autoCreateUser;
		[Static]
		[Export("credentialWithToken:autoCreateUser:")]
		AGCAuthCredential CredentialWithToken(string token, bool autoCreateUser);
	}

	// @interface AGCTwitterAuthProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCTwitterAuthProvider
	{
		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token secret:(NSString * _Nonnull)secret;
		[Static]
		[Export("credentialWithToken:secret:")]
		AGCAuthCredential CredentialWithToken(string token, string secret);

		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token secret:(NSString * _Nonnull)secret autoCreateUser:(BOOL)autoCreateUser;
		[Static]
		[Export("credentialWithToken:secret:autoCreateUser:")]
		AGCAuthCredential CredentialWithToken(string token, string secret, bool autoCreateUser);
	}

	// @interface AGCWeiXinAuthProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCWeiXinAuthProvider
	{
		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token openId:(NSString * _Nonnull)openId;
		[Static]
		[Export("credentialWithToken:openId:")]
		AGCAuthCredential CredentialWithToken(string token, string openId);

		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token openId:(NSString * _Nonnull)openId autoCreateUser:(BOOL)autoCreateUser;
		[Static]
		[Export("credentialWithToken:openId:autoCreateUser:")]
		AGCAuthCredential CredentialWithToken(string token, string openId, bool autoCreateUser);
	}

	// @interface AGCWeiboAuthProvider : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCWeiboAuthProvider
	{
		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token uid:(NSString * _Nonnull)uid;
		[Static]
		[Export("credentialWithToken:uid:")]
		AGCAuthCredential CredentialWithToken(string token, string uid);

		// +(AGCAuthCredential * _Nonnull)credentialWithToken:(NSString * _Nonnull)token uid:(NSString * _Nonnull)uid autoCreateUser:(BOOL)autoCreateUser;
		[Static]
		[Export("credentialWithToken:uid:autoCreateUser:")]
		AGCAuthCredential CredentialWithToken(string token, string uid, bool autoCreateUser);
	}
}
