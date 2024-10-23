using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace MetanitLessons.Maui.Bindings;

/*
Для создания относительной привязки применяется расширения разметки RelativeSource. 
(Например, TextColor="{Binding Source={RelativeSource Self}}, Path=Text" - 
- свойство TextColor зависит от свойства Text самого объекта)
Оно имеет следующие свойства:

Mode: представляет тип RelativeBindingSourceMode и устанавливает режим привязки.
Данное свойство может принимать следующие значения:

	TemplatedParent: применяется для установки привязки внутри шаблона элемента.

	Self: указывает на привязку к самому себе

	FindAncestor: указывает на контейнер в визуальном дереве элементов, 
	где надо искать объект-источник привязки.

	FindAncestorBindingContext: привзяка будет идти к свойству BindingContext контейнера.

AncestorLevel: представляет уровень элементов в визуальном дереве относительно контейнера, 
где будет идти поиск объекта-источника привязки (если свойство Mode имеет значение FindAncestor)

AncestorType: представляет тип Type и указывает на тип элементов, 
среди которых будет идти поиск объекта-источника привязки
(если свойство Mode имеет значение FindAncestor)


Если при установке привязки свойство Mode явным образом не задано, то есть два сценария:

	Свойство AncestorType в качестве значения получает объект, производный от Element. 
	В этом случае свойство Mode неявно получает значение FindAncestor

	Свойство AncestorType в качестве значения получает объект, НЕпроизводный от Element. 
	В этом случае свойство Mode неявно получает значение FindAncestorBindingContext
*/

public partial class RelativeSourcePage : ContentPage
{
	public RelativeSourcePage()
	{
		InitializeComponent();
	}
}

public class StringToColorsConverter : IValueConverter
{
	public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
		=> Color.TryParse(value?.ToString(), out var color) ? color : Colors.Black;

	public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
		=> (value as Color)?.ToHex();
}

public class User : INotifyPropertyChanged
{
	string name = "";
	int age;

	public event PropertyChangedEventHandler? PropertyChanged;

	public string Name
	{
		get => name;
		set
		{
			if (name != value)
			{
				name = value;
				OnPropertyChanged();
			}
		}
	}

	public int Age
	{
		get => age;
		set
		{
			if (age != value)
			{
				age = value;
				OnPropertyChanged();
			}
		}
	}

	public void OnPropertyChanged([CallerMemberName] string property = "")
	    => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
}