
namespace MetanitLessons.Maui.Controls;

/** DisplayPromptAsync

Task<string> DisplayPromptAsync(
							string title, 
							string message, 
							string accept = "OK", 
							string cancel = "Cancel", 
							string placeholder = null, 
							int maxLength = -1, 
							Keyboard keyboard = null, 
							string initialValue = "");

	title: заголовок окна

	message: приглашение к вводу

	accept: текст для кнопки подтверждения ввода

	cancel: текст для кнопки отмены. Может быть равен null, если мы хотим скрыть эту кнопку

	placeholder: текст-заменитель в текстовом поле ввода

	maxLength: максимальная длина текстового поля ввода

	keyboard: объект KeyBoard, который устанавливает тип клавиатуры для ввода

	initialValue: начальное значение в поле ввода

 */

public partial class DisplayPromptAsyncPage : ContentPage
{
	Label nameLabel;

	public DisplayPromptAsyncPage()
	{
		Button alertButton = new Button { Text = "Alert", HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Start };
		alertButton.Clicked += AlertButtonClicked;
		nameLabel = new Label();
		Content = new StackLayout { Children = { alertButton, nameLabel } };
	}

	async void AlertButtonClicked(object? sender, EventArgs e)
	{
		string name = await DisplayPromptAsync("Login", "Enter a name:", "OK", "Cancel");
		nameLabel.Text = name;
	}
}