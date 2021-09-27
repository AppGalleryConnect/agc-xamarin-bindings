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

namespace Huawei.Agconnect.Apms
{
	// @interface AGCAPM : NSObject
	[BaseType(typeof(NSObject))]
	interface AGCAPM
	{
		// +(instancetype _Nonnull)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		AGCAPM GetSharedInstance();

		// -(void)start;
		[Export("start")]
		void Start();

		// -(void)enableCollection:(BOOL)enable __attribute__((swift_name("enableCrashCollection(enable:)")));
		[Export("enableCollection:")]
		void EnableCollection(bool enable);
	}
}