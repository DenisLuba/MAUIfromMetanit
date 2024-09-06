namespace MetanitLessons;

public class NewPage1 : ContentPage
{
    public NewPage1()
    {
        // создаем лэйбл - текстовый элемент
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

        StackLayout stackLayout = new StackLayout()
        {
            // добавляем в элементы стэклайаота лэйблы
            Children = { label1, label2, label3 }
        };

        // пространство между элементами лайаота
        stackLayout.Spacing = 8;
        // ориентация стека
        stackLayout.Orientation = StackOrientation.Horizontal;
        // добавляем в содержимое страницы получившийся стэклайаот
        Content = stackLayout;


        /*
        string pageXAML = """
                    <?xml version="1.0" encoding="utf-8"?>
                    <ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                    x:Class="MetanitLessons.StartPage">
                    <Label x:Name="header" Text="Hello Friends!" FontSize="22"/>
                    </ContentPage>
                    """;

        this.LoadFromXaml(pageXAML);

        Label header = this.FindByName<Label>("header");
        header.Text = ".NET MAUI on METANIT.COM";
        */


        //Content = new VerticalStackLayout
        //{
        //	Children = {
        //		new Label 
        //		{ 
        //			HorizontalOptions = LayoutOptions.Center, 
        //			VerticalOptions = LayoutOptions.Center, 
        //			Text = "Welcome to .NET MAUI!"
        //		}
        //	}
        //};
    }
}