namespace MetanitLessons.Maui.Bindings;

public partial class BindingPage : ContentPage
{
	public BindingPage()
	{
/********************************************************************************************/
		// Первый способ привязки - свойство BindingContext:

		Label label1 = new Label();
		Entry entry1 = new Entry();

		// Устанавливаем привязку
		// Источник привязки - Entry, цель привязки - Label
		label1.BindingContext = entry1;
		// Связываем свойства цели Label (BindableProperty - TextProperty) и источника Entry (Text)
		label1.SetBinding(Label.TextProperty, "Text");

		/********************************************************************************************/

		// Другой способ привязки - объект Binding

		Label label2 = new Label();
		Entry entry2 = new Entry();

		// определяем объект привязки: Source - источник, Path - его свойство
		Binding binding = new Binding { Source = entry2, Path = "Text" };
		// Установка привязки для свойства TextProperty
		label2.SetBinding(Label.TextProperty, binding);

/********************************************************************************************/
		StackLayout stackLayout = new StackLayout
		{
			Children = { label1, entry1, label2, entry2 },
			Padding = 20
		};
		Content = stackLayout;

		InitializeComponent();
	}
}