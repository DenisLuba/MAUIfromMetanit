namespace MetanitLessons.Maui.Bindings;

public partial class StringFormatInBindingPage : ContentPage
{
	public StringFormatInBindingPage()
	{

/********************* „ерез BindingContext *********************/

		Entry entry = new Entry();
		Label label = new Label();

		// label - цель, entry - источник
		label.BindingContext = entry;
		// добавим stringFormat к свойству Label.TextProperty
		label.SetBinding(Label.TextProperty, nameof(entry.Text), stringFormat: "—ообщение {0}");

/*********************     „ерез Binding     *********************/

		Entry entry2 = new Entry();
		Label label2 = new Label();

		Binding binding = new Binding
		{
			Source = entry2,                   // источник прив€зки
			Path = nameof(entry2.Text),        // свойство прив€зки - Text
			StringFormat = "—ообщение 2: {0}"  // двухсторонн€€ прив€зка
		};

		label2.SetBinding(Label.TextProperty, binding);

		Content = new StackLayout
		{
			Children = { entry, label, entry2, label2 },
			Padding = 20
		};

		InitializeComponent();
	}
}