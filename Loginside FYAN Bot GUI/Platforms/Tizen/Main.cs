using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace Loginside_FYAN_Bot_GUI
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}