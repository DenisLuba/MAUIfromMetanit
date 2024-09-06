namespace MetanitLessons
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            string xaml = """
                <Label Text=".NET MAUI" FontSize="24"/>
                """;

            header.LoadFromXaml(xaml);
        }
    }

}
