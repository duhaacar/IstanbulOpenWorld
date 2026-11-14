# Android APK build status

The GitHub Actions workflow is `.github/workflows/android-apk.yml`.

It uses Unity 6000.0.85f2 (from `ProjectSettings/ProjectVersion.txt`) and GameCI `unity-builder@v4`. The workflow requires a valid Unity Personal license file saved in the repository Actions secret named `UNITY_LICENSE`; do not commit license files or account passwords.

The CI entry point `CIAndroidBuilder.Build` creates the runtime scene through `SahneKur.KurBatch()` and then builds `Build/Android/IstanbulOpenWorld.apk`.

Important: the original uploaded ZIP contains source scripts but is not a complete Unity project. Its `Assets/` source tree still needs to be committed. No APK has been produced or verified yet. The workflow can only succeed after all project source files are present and Unity licensing is configured.
