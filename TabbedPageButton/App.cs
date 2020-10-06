﻿using Xamarin.Forms;

namespace TabbedPageButton
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new[] { "Markup_Experimental" });

            MainPage = new TabbedPage
            {
                Children =
                {
                    new ButtonPage(),
                    new LabelPage()
                }
            };
        }
    }
}
