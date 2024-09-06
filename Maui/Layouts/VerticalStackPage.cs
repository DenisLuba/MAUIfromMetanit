namespace MetanitLessons;

public class VerticalStackPage : ContentPage
{
    public VerticalStackPage()
    {
        Label label1 = new Label()
        {
            Text = "First label",
            TextColor = Colors.Red
        };

        Label label2 = new Label()
        {
            Text = "Second label",
            TextColor = Colors.Blue
        };

        Label label3 = new Label()
        {
            Text = "Third label",
            TextColor = Colors.Green
        };

        VerticalStackLayout stackLayout = new VerticalStackLayout()
        {
            Children = { label1, label2, label3 }
        };

        stackLayout.Spacing = 8;

        Content = stackLayout;
    }
}
