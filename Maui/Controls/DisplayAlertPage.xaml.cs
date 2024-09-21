namespace MetanitLessons.Maui.Controls;

/**
 * Для создания всплывающих окон в .NET MAUI используются специальные методы, 
 * которые определены у объекта Page, а поэтому есть у любой страницы:

Task DisplayAlert (string title, string message, string cancel) 

Task<bool> DisplayAlert (string title, string message, string accept, string cancel) 

Task<bool> DisplayAlert (string title, string message, string accept, string cancel, FlowDirection flowDirection) 

Task<string> DisplayActionSheet (string title, string cancel, 
                            string destruction, params string[] buttons)

Task<string> DisplayPromptAsync(string title, string message, string accept = "OK", 
                            string cancel = "Cancel", string placeholder = null, int maxLength = -1, 
                            Keyboard keyboard = null, string initialValue = "");
 */

public partial class DisplayAlertPage : ContentPage
{
	public DisplayAlertPage()
	{
		InitializeComponent();
	}
}