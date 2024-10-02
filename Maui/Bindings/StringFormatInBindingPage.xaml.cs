namespace MetanitLessons.Maui.Bindings;

public partial class StringFormatInBindingPage : ContentPage
{
	public StringFormatInBindingPage()
	{

/********************* ����� BindingContext *********************/

		Entry entry = new Entry();
		Label label = new Label();

		// label - ����, entry - ��������
		label.BindingContext = entry;
		// ������� stringFormat � �������� Label.TextProperty
		label.SetBinding(Label.TextProperty, nameof(entry.Text), stringFormat: "��������� {0}");

/*********************     ����� Binding     *********************/

		Entry entry2 = new Entry();
		Label label2 = new Label();

		Binding binding = new Binding
		{
			Source = entry2,                   // �������� ��������
			Path = nameof(entry2.Text),        // �������� �������� - Text
			StringFormat = "��������� 2: {0}"  // ������������� ��������
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