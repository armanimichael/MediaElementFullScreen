using Android.App;
using Android.Content.PM;
using Android.OS;

namespace MediaElementFullScreen;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode |
                           ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density,
    LaunchMode = LaunchMode.SingleTask,
    ScreenOrientation = ScreenOrientation.Portrait
    )]
public class MainActivity : MauiAppCompatActivity
{
}