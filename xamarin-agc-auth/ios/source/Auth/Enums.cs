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
using ObjCRuntime;

namespace Huawei.Agconnect.Auth
{
	[Native]
	public enum AGCAuthProviderType : long
	{
		Anonymous = 0,
		Hms = 1,
		Facebook = 2,
		Twitter = 3,
		WeiXin = 4,
		HWGame = 5,
		Qq = 6,
		WeiBo = 7,
		Google = 8,
		GoogleGame = 9,
		SelfBuild = 10,
		Phone = 11,
		Email = 12,
		Apple = 13
	}

	[Native]
	public enum AGCTokenState : long
	{
		SignedIn = 0,
		TokenUpdated,
		TokenInvalid,
		SignedOut
	}

	[Native]
	public enum AGCAuthErrorCode : ulong
	{
		NullToken = 1,
		NotSignIn = 2,
		UserLinked = 3,
		UserUnlinked = 4,
		AlreadySignInUser = 5,
		EmailVerificationIsEmpty = 6,
		PhoneVerificationIsEmpty = 7,
		InvalidEmail = 203817223,
		InvalidPhone = 203817224,
		GetUidError = 203817728,
		UidProductIDNotMatch = 203817729,
		GetUserInfoError = 203817730,
		AuthMethodNotSupport = 203817732,
		ProductStatusError = 203817744,
		PasswordVerificationCodeOverLimit = 203817811,
		InvalidToken = 203817984,
		InvalidAccessToken = 203817985,
		InvalidRefreshToken = 203817986,
		TokenAndProductIdNotMatch = 203817987,
		AuthMethodIsDisabled = 203817988,
		FailToGetThirdUserInfo = 203817989,
		FailToGetThirdUserUnionId = 203817990,
		AccessTokenOverLimit = 203817991,
		FailToUserLink = 203817992,
		FailToUserUnlink = 203817993,
		AnonymousSigninOverLimit = 203818019,
		InvalidAppID = 203818020,
		InvalidAppSecret = 203818021,
		GetQQUserInfoError = 203818023,
		QQInfoResponseIsNull = 203818024,
		GetQQUidError = 203818025,
		PasswordVerifyCodeError = 203818032,
		GoogleResponseNotEqualAppID = 203818033,
		SignInUserStatusError = 203818036,
		SignInUserPasswordError = 203818037,
		ProviderUserHaveBeenLinked = 203818038,
		ProviderHaveLinkedOneUser = 203818039,
		FailGetProviderUser = 203818040,
		CannotUnlinkOneProviderUser = 203818041,
		VerifyCodeIntervalLimit = 203818048,
		VerifyCodeEmpty = 203818049,
		VerifyCodeLanguageEmpty = 203818050,
		VerifyCodeReceiverEmpty = 203818051,
		VerifyCodeActionError = 203818052,
		VerifyCodeTimeLimit = 203818053,
		AccountPasswordSame = 203818064,
		PasswordStrengthLow = 203818065,
		UpdatePasswordError = 203818066,
		PasswordSameAsBefore = 203818067,
		PasswordIsEmpty = 203818068,
		PasswordTooLong = 203818071,
		SensitiveOperationTimeout = 203818081,
		AccountHaveBeenRegistered = 203818082,
		UpdateAccountError = 203818084,
		UserNotRegistered = 203818087,
		VerifyCodeError = 203818129,
		UserHaveBeenRegistered = 203818130,
		RegisterAccountIsEmpty = 203818132,
		VerifyCodeFormatError = 203818134,
		VerifyCodeAndPasswordBothNull = 203818135,
		SendEmailFail = 203818240,
		SendMessageFail = 203818241,
		ConfigLockTimeError = 203818261
	}

	[Native]
	public enum AGCVerifyCodeAction : long
	{
		RegisterLogin = 1001,
		SetPassword = 1002
	}
}
