using System;
using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace TabbedPageButton
{
    abstract class BaseButtonPage : ContentPage
    {
        protected static Button Button { get; } = new Button { Text = $"This button was created at {DateTimeOffset.UtcNow}" }.Invoke(button => button.Clicked += HandleButtonClicked);

        static async void HandleButtonClicked(object sender, EventArgs e) =>
            await Application.Current.MainPage.DisplayAlert("Button Clicked", "This is the same button on both pages", "OK");
    }
}
