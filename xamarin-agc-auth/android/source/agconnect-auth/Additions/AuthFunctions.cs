using Android.App;
using Android.Runtime;
using Huawei.Hmf.Extensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiTask = Huawei.Hmf.Tasks.Task;
using OnComplete = Huawei.Hmf.Tasks.IOnCompleteListener;

namespace Huawei.Agconnect.Auth
{
	public partial class AGConnectAuth
	{
		public async Task<ISignInResult> SignInAsync(IAGConnectAuthCredential credential)
			=> await SignIn(credential).AsAsync<ISignInResult>();
		public async Task<ISignInResult> SignInAnonymouslyAsync()
			=> await SignInAnonymously().AsAsync<ISignInResult>();
		public async Task<ISignInResult> CreateUserAsync(PhoneUser phoneUser)
			=> await CreateUser(phoneUser).AsAsync<ISignInResult>();
		public async Task<ISignInResult> CreateUserAsync(EmailUser emailUser)
			=> await CreateUser(emailUser).AsAsync<ISignInResult>();
		public async Task DeleteUserAsync()
			=> await DeleteUser().CastTask();
		public async Task ResetPasswordAsync(string email,string newPassword,string verifyCode)
			=> await ResetPassword(email,newPassword,verifyCode).CastTask();
		public async Task ResetPasswordAsync(string countryCode,string phoneNumber, string newPassword, string verifyCode)
			=> await ResetPassword(countryCode,phoneNumber, newPassword, verifyCode).CastTask();
		public async Task<VerifyCodeResult> RequestVerifyCodeAsync(string email, VerifyCodeSettings settings)
			=> await RequestVerifyCode(email, settings).CastTask<VerifyCodeResult>();
		public async Task<VerifyCodeResult> RequestVerifyCodeAsync(string countryCode,string phoneNumber, VerifyCodeSettings settings)
			=> await RequestVerifyCode(countryCode,phoneNumber, settings).CastTask<VerifyCodeResult>();
	}

	public partial class AGConnectUser
    {
		public async Task<ITokenResult> GetTokenAsync(bool forceRefresh)
			=> await GetToken(forceRefresh).AsAsync<ITokenResult>();
		public async Task<ISignInResult> UnlinkAsync(int provider)
			=> await Unlink(provider).AsAsync<ISignInResult>();
		public async Task<ISignInResult> LinkAsync(IAGConnectAuthCredential credential)
			=> await Link(credential).AsAsync<ISignInResult>();
		public async Task UpdateProfileAsync(ProfileRequest profileRequest)
			=> await UpdateProfile(profileRequest).CastTask();
		public async Task UpdateEmailAsync(string newEmail, string newVerifyCode)
			=> await UpdateEmail(newEmail,newVerifyCode).CastTask();
		public async Task UpdateEmailAsync(string newEmail, string newVerifyCode,Java.Util.Locale locale)
			=> await UpdateEmail(newEmail, newVerifyCode,locale).CastTask();
		public async Task UpdatePasswordAsync(string newPassword, string verifyCode, int provider)
			=> await UpdatePassword(newPassword, verifyCode, provider).CastTask();
		public async Task UpdatePhoneAsync(string countryCode, string phoneNumber, string newVerifyCode)
			=> await UpdatePhone(countryCode, phoneNumber, newVerifyCode).CastTask();
		public async Task UpdatePhoneAsync(string countryCode, string phoneNumber, string newVerifyCode,Java.Util.Locale locale)
			=> await UpdatePhone(countryCode, phoneNumber, newVerifyCode,locale).CastTask();
		public async Task<IAGConnectUserExtra> GetUserExtraAsync()
			=> await UserExtra.AsAsync<IAGConnectUserExtra>();
	}
	public partial class EmailAuthProvider
    {
		public async Task<VerifyCodeResult> RequestVerifyCodeAsync(string email,VerifyCodeSettings settings)
			=> await RequestVerifyCode(email,settings).CastTask<VerifyCodeResult>();
	}
	public partial class PhoneAuthProvider
	{
		public async Task<VerifyCodeResult> RequestVerifyCodeAsync(string countryCode,string phoneNumber, VerifyCodeSettings settings)
			=> await RequestVerifyCode(countryCode,phoneNumber, settings).CastTask<VerifyCodeResult>();
	}

	internal static class HuaweiTaskExtensions
	{
		public static Task CastTask(this HuaweiTask HuaweiTask)
		{
			var tcs = new TaskCompletionSource<bool>();

			HuaweiTask.AddOnCompleteListener(new MyCompleteListener(
				t =>
				{
					if (t.Exception == null)
						tcs.TrySetResult(false);
					else
						tcs.TrySetException(t.Exception);
				}
			));

			return tcs.Task;
		}

		public static Task<TResult> CastTask<TResult>(this HuaweiTask HuaweiTask)
			where TResult : Java.Lang.Object
		{
			var tcs = new TaskCompletionSource<TResult>();

			HuaweiTask.AddOnCompleteListener(new MyCompleteListener(
				t =>
				{
					if (t.Exception == null)
						tcs.TrySetResult(t.Result.JavaCast<TResult>());
					else
						tcs.TrySetException(t.Exception);
				}));

			return tcs.Task;
		}

		class MyCompleteListener : Java.Lang.Object, OnComplete
		{
			public MyCompleteListener(Action<HuaweiTask> onComplete)
				=> OnCompleteHandler = onComplete;

			public Action<HuaweiTask> OnCompleteHandler { get; }

			public void OnComplete(HuaweiTask task)
				=> OnCompleteHandler?.Invoke(task);
		}

	}
}