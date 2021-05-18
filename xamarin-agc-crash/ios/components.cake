var AGC_IOS_VERSION = "1.3.0.300";

var SLN_PATH = "./source/Crash.sln"; 
 
Artifact CRASH_ARTIFACT      = new Artifact ("Crash", AGC_IOS_VERSION ,"10.0"); 

var IOS_ARTIFACTS = new Dictionary<string, Artifact> { 
	{ "Crash", CRASH_ARTIFACT }
};

void SetArtifactsDependencies ()
{
	CRASH_ARTIFACT.Dependencies = null; 
}

void SetArtifactsPodSpecs ()
{
	CRASH_ARTIFACT.PodSpecs = new [] {
		PodSpec.Create ("AGConnectCrash",   AGC_IOS_VERSION)
	};
}