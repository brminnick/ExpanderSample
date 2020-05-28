using Xamarin.Forms;

namespace ExpanderSample
{
    class ExpanderContentPage : ContentPage
    {
        public ExpanderContentPage()
        {
            const int previewTextLength = 50;

            var titleText = LoremIpsum.GenerateText(25).Trim();
            var bodyText = LoremIpsum.GenerateText(200).Trim();

            Content = new Expander
            {
                Header = new StackLayout
                {
                    Children =
                    {
                        new Label { Text = titleText, FontAttributes = FontAttributes.Bold },
                        new Label { Text = bodyText.Substring(0, previewTextLength) + "..." }
                    }
                },
                Content = new Label { Text = bodyText.Substring(previewTextLength, bodyText.Length - previewTextLength - 1) }
            };
        }
    }
}
