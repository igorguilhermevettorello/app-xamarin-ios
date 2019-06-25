using ConectaCampoBom.Droid.Util;
using ConectaCampoBom.Util;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TransparentWebView), typeof(TransparentWebViewRenderer))]
namespace ConectaCampoBom.Droid.Util
{
    public class TransparentWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);

            // Setting the background as transparent
            this.Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}