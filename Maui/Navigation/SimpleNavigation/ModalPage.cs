namespace MetanitLessons.Maui.Navigation.SimpleNavigation;

public class ModalPage : ContentPage
{
	public ModalPage()
	{
		Title = "Modal";
		Button backButton = new Button { Text = "Back", HorizontalOptions = LayoutOptions.Start };

		Label label = new Label { Text = "Modal Message..." };
		// ������� � ��������� �������� �����
		backButton.Clicked += async (o, e) => await Navigation.PopModalAsync(animated: true);

		Content = new StackLayout { Children = { label, backButton } };
	}
}