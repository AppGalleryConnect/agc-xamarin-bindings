var AGC_IOS_VERSION = "1.3.0.300";

var SLN_PATH = "./source/Function.sln"; 
 
Artifact CLOUDFUNCTIONS_ARTIFACT      = new Artifact ("Function", AGC_IOS_VERSION ,"10.0"); 

var IOS_ARTIFACTS = new Dictionary<string, Artifact> { 
	{ "Function", CLOUDFUNCTIONS_ARTIFACT }
};

void SetArtifactsDependencies ()
{
	CLOUDFUNCTIONS_ARTIFACT.Dependencies = null; 
}


void SetArtifactsPodSpecs ()
{
	CLOUDFUNCTIONS_ARTIFACT.PodSpecs = new [] {
		PodSpec.Create ("AGConnectFunction",   AGC_IOS_VERSION)
	};
}