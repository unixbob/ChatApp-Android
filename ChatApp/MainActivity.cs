using System;
using Android.App;
using Android.OS;
using Android.Webkit;


namespace ChatApp
{
    [Activity(Label = "ChatApp", MainLauncher = true)]
    
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            SetContentView(Resource.Layout.Main);
            WebView localWebView = FindViewById<WebView>(Resource.Id.webView1);
            localWebView.Settings.JavaScriptEnabled = true;
            localWebView.LoadUrl("http://chatapp.pressedontech.com/");

        }

  
    }


}

