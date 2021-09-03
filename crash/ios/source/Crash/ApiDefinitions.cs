/*
        Copyright 2021. Huawei Technologies Co., Ltd. All rights reserved.

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
using ObjCRuntime;

namespace Huawei.Agconnect.Crash
{
	// @interface AGCExceptionModel : NSObject
	[BaseType (typeof(NSObject))]
	interface AGCExceptionModel
	{
		// @property (readonly, nonatomic) NSString * _Nonnull name;
		[Export ("name")]
		string Name { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull reason;
		[Export ("reason")]
		string Reason { get; }

		// @property (readonly, nonatomic) NSString * _Nonnull stackTrace;
		[Export ("stackTrace")]
		string StackTrace { get; }

		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name reason:(NSString * _Nonnull)reason stackTrace:(NSString * _Nonnull)stacktrace;
		[Export ("initWithName:reason:stackTrace:")]
		IntPtr Constructor (string name, string reason, string stacktrace);
	}

	// @interface AGCCrash : NSObject
	[BaseType (typeof(NSObject))]
	interface AGCCrash
	{
		// +(instancetype _Nonnull)sharedInstance;
		[Static]
		[Export ("sharedInstance")]
		AGCCrash GetSharedInstance ();

		// -(void)testIt;
		[Export ("testIt")]
		void TestIt ();

		// -(void)enableCrashCollection:(BOOL)enable __attribute__((swift_name("enableCrashCollection(enable:)")));
		[Export ("enableCrashCollection:")]
		void EnableCrashCollection (bool enable);

		// -(void)setUserId:(NSString * _Nonnull)userId;
		[Export ("setUserId:")]
		void SetUserId (string userId);

		// -(void)setCustomValue:(id _Nonnull)value forKey:(NSString * _Nonnull)key __attribute__((swift_name("setCustomValue(value:key:)")));
		[Export ("setCustomValue:forKey:")]
		void SetCustomValue (NSObject value, string key);

		// -(void)logWithLevel:(AGCCrashLogLevel)level message:(NSString * _Nonnull)message __attribute__((swift_name("log(level:message:)")));
		[Export ("logWithLevel:message:")]
		void LogWithLevel (AGCCrashLogLevel level, string message);

		// -(void)log:(NSString * _Nonnull)message __attribute__((swift_name("log(message:)")));
		[Export ("log:")]
		void Log (string message);

		// -(void)recordError:(NSError * _Nonnull)error;
		[Export ("recordError:")]
		void RecordError (NSError error);

		// -(void)recordExceptionModel:(AGCExceptionModel * _Nonnull)exception;
		[Export ("recordExceptionModel:")]
		void RecordExceptionModel (AGCExceptionModel exception);
	}
}
