namespace MetanitLessons.Maui.Bindings;

public partial class CustomBindablePropertyPage : ContentPage
{
	public CustomBindablePropertyPage()
	{
		TagLabel tagLabel = new TagLabel();
		Entry entry = new Entry();
		// Устанавливаем привязку
		// источник привязки - entry, цель привязки - tagLabel
		tagLabel.BindingContext = entry;
		// Связываем свойства источника и цели
		// причем у цели (tagLabel) привяжем к свойству Text источника (entry)
		// и свойство Text (это от родительского Label) и новое свойство Tag
		tagLabel.SetBinding(TagLabel.TextProperty, nameof(entry.Text));
		tagLabel.SetBinding(TagLabel.TagProperty, nameof(entry.Text));

		Label label = new Label();
		// а теперь привяжем label к tagLabel
		// устанавливаем привязку к свойству Tag объекта tagLabel
		label.BindingContext = tagLabel;
		label.SetBinding(Label.TextProperty, nameof(tagLabel.Tag));

		Content = new StackLayout
		{
			Padding = 20,
			Children = { tagLabel, entry, label }
		};

		InitializeComponent();
	}
}

// Создаем свой класс, производный от Label. Он будет включать некоторое свойство Tag
public class TagLabel : Label
{
	public static readonly BindableProperty TagProperty = BindableProperty.Create(
			"Tag",				// название свойства
			typeof(string),		// возвращаемый тип
			typeof(TagLabel),	// тип, в котором объявляется свойство
			"0"					// значение по-умолчанию
		); 

	public string Tag
	{
		set
		{
			SetValue(TagProperty, value);
		}
		get
		{
			return (string)GetValue(TagProperty);
		}
	}
}