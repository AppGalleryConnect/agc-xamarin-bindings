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

namespace Huawei.Agconnect.Remoteconfig
{
    // @interface AGCConfigValues : NSObject
    [BaseType(typeof(NSObject))]
    interface AGCConfigValues
    {
        // -(BOOL)contain:(NSString * _Nonnull)key;
        [Export("contain:")]
        bool Contain(string key);

        // -(BOOL)valueAsBool:(NSString * _Nonnull)key __attribute__((swift_name("valueAsBool(key:)")));
        [Export("valueAsBool:")]
        bool ValueAsBool(string key);

        // -(NSNumber * _Nonnull)valueAsNumber:(NSString * _Nonnull)key __attribute__((swift_name("valueAsNumber(key:)")));
        [Export("valueAsNumber:")]
        NSNumber ValueAsNumber(string key);

        // -(NSString * _Nonnull)valueAsString:(NSString * _Nonnull)key __attribute__((swift_name("valueAsString(key:)")));
        [Export("valueAsString:")]
        string ValueAsString(string key);

        // -(NSData * _Nonnull)valueAsData:(NSString * _Nonnull)key __attribute__((swift_name("valueAsData(key:)")));
        [Export("valueAsData:")]
        NSData ValueAsData(string key);
    }

    // @interface AGCRemoteConfig : NSObject
    [BaseType(typeof(NSObject))]
    interface AGCRemoteConfig
    {
        // +(instancetype _Nonnull)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        AGCRemoteConfig GetSharedInstance();

        // -(void)applyDefaultsPlistFile:(NSString * _Nonnull)plistName;
        [Export("applyDefaultsPlistFile:")]
        void ApplyDefaultsPlistFile(string plistName);

        // -(void)applyDefaults:(NSDictionary<NSString *,id> * _Nonnull)defaults;
        [Export("applyDefaults:")]
        void ApplyDefaults(NSDictionary<NSString, NSObject> defaults);

        // -(void)apply:(AGCConfigValues * _Nonnull)values;
        [Export("apply:")]
        void Apply(AGCConfigValues values);

        // -(AGCConfigValues * _Nonnull)loadLastFetched;
        [Export("loadLastFetched")]
        AGCConfigValues LoadLastFetched();


        // -(id)fetch;
        [Export("fetch")]
        NSObject Fetch();

        // -(id)fetch:(NSTimeInterval)intervalSeconds;
        [Export("fetch:")]
        //NSObject Fetch (double intervalSeconds);
        NSObject Fetch(double intervalSeconds);

        // -(BOOL)valueAsBool:(NSString * _Nonnull)key __attribute__((swift_name("valueAsBool(key:)")));
        [Export("valueAsBool:")]
        bool ValueAsBool(string key);

        // -(NSNumber * _Nonnull)valueAsNumber:(NSString * _Nonnull)key __attribute__((swift_name("valueAsNumber(key:)")));
        [Export("valueAsNumber:")]
        NSNumber ValueAsNumber(string key);

        // -(NSString * _Nonnull)valueAsString:(NSString * _Nonnull)key __attribute__((swift_name("valueAsString(key:)")));
        [Export("valueAsString:")]
        string ValueAsString(string key);

        // -(NSData * _Nonnull)valueAsData:(NSString * _Nonnull)key __attribute__((swift_name("valueAsData(key:)")));
        [Export("valueAsData:")]
        NSData ValueAsData(string key);

        // -(AGCRemoteConfigSource)getSource:(NSString * _Nonnull)key;
        [Export("getSource:")]
        AGCRemoteConfigSource GetSource(string key);

        // -(NSDictionary<NSString *,id> * _Nonnull)getMergedAll;
        [Export("getMergedAll")]
        NSDictionary<NSString, NSObject> MergedAll { get; }

        // -(void)clearAll;
        [Export("clearAll")]
        void ClearAll();
    }
 
    // @interface AGCRemoteConfigError : NSError
    [BaseType(typeof(NSError))]
    interface AGCRemoteConfigError
    {
        // @property (readonly, nonatomic) NSTimeInterval throttleEndTime;
        [Export("throttleEndTime")]
        double ThrottleEndTime { get; }
    }
}
