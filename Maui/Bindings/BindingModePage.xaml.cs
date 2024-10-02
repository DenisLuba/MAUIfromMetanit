namespace MetanitLessons.Maui.Bindings;

/**
 * Режим привязки определяет в какую сторону будет работать привязка. 
 * Все возможные режимы задаются с помощью значений из перечисления BindingMode:

Default: значение по умолчанию. Для разных элементов и свойств может отличаться

OneWay: при изменении в источнике изменяется цель (от источника к цели)

OneTime: привязка установливается только однократно и больше не действует. 
	То есть цель привязки получает начальное значение из источника привязки. 
	Но при дальнейшем изменении в источнике привязка больше не действует

OneWayToSource: при изменении в объекте-цели привязки изменяется объект-источник 
	(то есть обратная привязка от цели к источнику)

TwoWay: изменения в источнике воздействуют на цель привязки, 
	а изменении в цели воздействуют на источник (то есть двусторонняя привязка)


 * По умолчанию стандартным значением для всех элементов и их свойств является значение OneWay, 
 * то есть односторонняя привязка от источника к цели. 
 * Однако ряд элементов и их свойств по умолчанию используют двустороннюю привязку:

Свойство Date элемента DatePicker

Свойство Text элементов Editor, Entry, SearchBar, и EntryCell

Свойство IsRefreshing элемента ListView

Свойство SelectedItem элемента MultiPage

Свойства SelectedIndex и SelectedItem элемента Picker

Свойство Value элементов Slider и Stepper

Свойство IsToggled элементов Switch

Свойство On элемента SwitchCell

Свойство Time элемента TimePicker


 * Режим привязки по умолчанию в каждом свойстве BindingProperty 
 * хранится в свойстве DefaultBindingMode
 */

public partial class BindingModePage : ContentPage
{
	public BindingModePage()
	{

/********************* Через BindingContext *********************/

		Entry entry1 = new Entry { Margin = 10 };
		Entry entry2 = new Entry { Margin = 10 };

		// entry1 - цель, entry2 - источник
		entry1.BindingContext = entry2;
		// устанавливаем двухстороннюю привязку
		// (хотя она и так для Entry установлена по-умолчанию)
		entry1.SetBinding(Entry.TextProperty, nameof(entry2.Text), BindingMode.TwoWay);

/*********************     Через Binding     *********************/

		Entry entry3 = new Entry { Margin = 10 };
		Entry entry4 = new Entry { Margin = 10 };

		Binding binding = new Binding 
		{ 
			Source = entry3,			// источник привязки
			Path = nameof(entry3.Text),	// свойство привязки - Text
			Mode = BindingMode.TwoWay   // двухсторонняя привязка
		};
		// цель привязки - entry4
		entry4.SetBinding(Entry.TextProperty, binding);

		Content = new StackLayout
		{
			Children = { entry1, entry2, entry3, entry4 },
			Padding = 10
		};

		InitializeComponent();
	}
}