var AGC_IOS_VERSION = "1.3.0.300";

var SLN_PATH = "./source/Auth.sln"; 
 
Artifact AUTH_ARTIFACT      = new Artifact ("Auth", AGC_IOS_VERSION ,"10.0"); 

var IOS_ARTIFACTS = new Dictionary<string, Artifact> { 
	{ "Auth", AUTH_ARTIFACT }
};

void SetArtifactsDependencies ()
{
	AUTH_ARTIFACT.Dependencies = null; 
}

void SetArtifactsPodSpecs ()
{
	AUTH_ARTIFACT.PodSpecs = new [] {
		PodSpec.Create ("AGConnectAuth",   AGC_IOS_VERSION)
	};
}