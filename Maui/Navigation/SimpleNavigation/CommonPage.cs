namespace MetanitLessons.Maui.Navigation.SimpleNavigation;

public class CommonPage : ContentPage
{
	public CommonPage()
	{
		Title = "Common";

		Button backButton = new Button { Text = "Back", HorizontalOptions = LayoutOptions.Start };

		Label label = new Label { Text = "Lorem Ipsum is simply dummy text of the printing..." };
		// переход с обычной страницы назад
		backButton.Clicked += async (o, e) => await Navigation.PopAsync(animated: true);

		Content = new StackLayout { Children = { label, backButton } };
	}
}