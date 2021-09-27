var AGC_IOS_VERSION = "1.2.1.302";

var SLN_PATH = "./source/Apms"; 
 
Artifact APM_ARTIFACT      = new Artifact ("Apms", AGC_IOS_VERSION ,"10.0"); 

var IOS_ARTIFACTS = new Dictionary<string, Artifact> { 
	{ "Apms", APM_ARTIFACT }
};

void SetArtifactsDependencies ()
{
	APM_ARTIFACT.Dependencies = null; 
}

void SetArtifactsPodSpecs ()
{
	APM_ARTIFACT.PodSpecs = new [] {
		PodSpec.Create ("AGConnectAPM",   "1.2.1.302")
	};
}