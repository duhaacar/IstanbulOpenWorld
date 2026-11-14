using System.IO;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public static class CIAndroidBuilder
{
    public static void Build()
    {
        SahneKur.KurBatch();
        PlayerSettings.companyName = "Duhaacar";
        PlayerSettings.productName = "Maymun Simitci Istanbul";
        PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, "com.duhaacar.istanbulopenworld");
        PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel26;
        PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64;
        EditorUserBuildSettings.buildAppBundle = false;

        const string output = "Build/Android/IstanbulOpenWorld.apk";
        Directory.CreateDirectory(Path.GetDirectoryName(output));
        var options = new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scenes/Istanbul.unity" },
            locationPathName = output,
            target = BuildTarget.Android,
            options = BuildOptions.None
        };
        BuildReport report = BuildPipeline.BuildPlayer(options);
        Debug.Log("Android build result: " + report.summary.result + "; errors=" + report.summary.totalErrors);
        EditorApplication.Exit(report.summary.result == BuildResult.Succeeded ? 0 : 1);
    }
}
