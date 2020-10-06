using Xamarin.Forms;
using Xamarin.Forms.Markup;

namespace TabbedPageButton
{
    class LabelPage : BaseButtonPage
    {
        public LabelPage()
        {
            Title = "LabelPage";

            Content = new StackLayout
            {
                Children =
                {
                    new Label { Text = "Label Page" }.TextCenter().Center(),

                    Button
                }
            }.Center();
        }
    }
}
