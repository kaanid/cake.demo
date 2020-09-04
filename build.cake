/// args
var target = Argument("target","default");

Task("clean")
    .Does(() =>{
        CleanDirectories("./src/*/bin");
        CleanDirectories("./test/*/bin");
    });

Task("restore-nuget-packages")
    .Does(()=>{
        DotNetCoreRestore("./cake.demo.sln");
    });

/// build task
Task("build")
    .Description("构建")
    .IsDependentOn("restore-nuget-packages")
    .Does(()=>{
        DotNetCoreBuild("./cake.demo.sln",
                        new DotNetCoreBuildSettings { Configuration = "Release" });
    });


Task("unit-test")
    .IsDependentOn("build")
    .Does(()=>{
        XUnit2("./test/*/bin/*/*.Tests.dll");
    });


Task("default")
    .IsDependentOn("unit-test");


/// run task
RunTarget(target);