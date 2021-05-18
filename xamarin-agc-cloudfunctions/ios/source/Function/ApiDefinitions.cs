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
using Foundation;
using Huawei.Agconnect.AgconnectCore;
using ObjCRuntime;

namespace Huawei.Agconnect.Function
{
	// @interface AGCFunction : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCFunction
	{
		// +(instancetype _Nonnull)getInstance;
		[Static]
		[Export("getInstance")]
		AGCFunction GetInstance();

		// -(AGCFunctionCallable * _Nonnull)wrap:(NSString * _Nonnull)httpTriggerUri;
		[Export("wrap:")]
		AGCFunctionCallable Wrap(string httpTriggerUri);
	}

	// @interface AGCFunctionResult : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCFunctionResult
	{
		// -(NSString * _Nullable)value;
		[NullAllowed, Export("value")] 
		string Value { get; }

		// -(id _Nullable)valueWithClass:(Class _Nonnull)valueClass;
		[Export("valueWithClass:")]
		[return: NullAllowed]
		NSObject ValueWithClass(Class valueClass);
	}

	// @interface AGCFunctionCallable : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCFunctionCallable
	{
		// @property (nonatomic) NSTimeInterval timeoutInterval;
		[Export("timeoutInterval")]
		double TimeoutInterval { get; set; }

		// -(id)call;
		[Export("call")]
		HMFTask<NSObject> Call();

		// -(id)callWithObject:(id _Nullable)object;
		[Export("callWithObject:")]
		HMFTask<NSObject> CallWithObject([NullAllowed] NSObject @object);
	}

	// @interface AGCFunctionError : NSError
	[BaseType(typeof(NSError))]
	interface AGCFunctionError
	{
	}
}
