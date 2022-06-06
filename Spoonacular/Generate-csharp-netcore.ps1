openapi-generator-cli generate `
	-i .\spoonacular-prune.json `
	-g csharp-netcore `
	-o .\csharp-netcore\ `
	--additional-properties=library=httpclient,targetFramework=net6.0,apiName=Spoonacular,packageName=Spoonacular `
#	--enable-post-process-file

#https://openapi-generator.tech/docs/usage
#https://openapi-generator.tech/docs/generators/csharp-netcore/
