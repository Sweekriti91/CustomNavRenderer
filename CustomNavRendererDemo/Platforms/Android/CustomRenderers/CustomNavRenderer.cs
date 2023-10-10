using Android.Content;
using Microsoft.Maui.Controls.Compatibility.Platform.Android.AppCompat;

namespace CustomNavRendererDemo.Platforms.Android
{
    public class CustomNavRenderer : NavigationPageRenderer
    {
        public CustomNavRenderer(Context context) : base(context)
        {
            System.Diagnostics.Debug.WriteLine($"CustomNavRenderer ctor()");
        }
    }
}
