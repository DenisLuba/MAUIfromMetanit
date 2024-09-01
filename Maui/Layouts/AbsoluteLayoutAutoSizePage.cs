namespace HelloApp;

public class AbsoluteLayoutAutoSizePage : ContentPage
{
	public AbsoluteLayoutAutoSizePage()
	{
		AbsoluteLayout absoluteLayout = new AbsoluteLayout();

		BoxView boxView = new BoxView { Color = Colors.LightBlue };
		Label label = new Label { Text = ".NET MAUI", FontSize = 20 };

		absoluteLayout.Add(boxView);
		absoluteLayout.Add(label);

		absoluteLayout.SetLayoutBounds(
			boxView,
			new Rect(30, 70, 340, 100)
			);

		absoluteLayout.SetLayoutBounds(
			label,
			// ширина и высота занимаемой области определяются исходя из ширины
			// и высоты элемента label
			new Rect(50, 100, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
			);

		Content = absoluteLayout;
	}
}