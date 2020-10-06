using Xamarin.Forms;
using Xamarin.Forms.Markup;
using static TabbedPageButton.MarkupExtensions;
using static Xamarin.Forms.Markup.GridRowsColumns;

namespace TabbedPageButton
{
    class ButtonPage : BaseButtonPage
    {
        public ButtonPage()
        {
            Title = "ButtonPage";

            Content = Button;
        }
    }
}
