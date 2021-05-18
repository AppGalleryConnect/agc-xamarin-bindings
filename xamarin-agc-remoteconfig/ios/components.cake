var AGC_IOS_VERSION = "1.3.0.300";

var SLN_PATH = "./source/RemoteConfig.sln"; 
 
Artifact REMOTECONFIG_ARTIFACT      = new Artifact ("Remoteconfig", AGC_IOS_VERSION ,"10.0"); 

var IOS_ARTIFACTS = new Dictionary<string, Artifact> { 
	{ "Remoteconfig", REMOTECONFIG_ARTIFACT }
};

void SetArtifactsDependencies ()
{
	REMOTECONFIG_ARTIFACT.Dependencies = null; 
}

void SetArtifactsPodSpecs ()
{
	REMOTECONFIG_ARTIFACT.PodSpecs = new [] {
		PodSpec.Create ("AGConnectRemoteConfig",   AGC_IOS_VERSION),
		PodSpec.Create ("AGConnectABTest",   AGC_IOS_VERSION)
	};
}