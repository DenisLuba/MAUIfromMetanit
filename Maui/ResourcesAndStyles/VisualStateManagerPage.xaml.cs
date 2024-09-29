
using System.Text.RegularExpressions;

namespace MetanitLessons.Maui.ResourcesAndStyles;

/** VisualStateManager
 * 
 * По умолчанию Visual State Manager прикрепляет к элементам управления 
 * группу из трех состояний:

Disabled: элемент отключен для использования

Focused: элемент получил фокус и используется в текущий момент

Normal: стандартное состояние элемента

PointerOver: указатель мыши находится над элементом

 * Состояния Normal, Disabled, Focused и PointerOver поддерживается 
 * для объектов всех классов, которые унаследованы от VisualElement 
 * (в том числе классов View и Page). 
 * 
 * В .NET MAUI для ряда элементов есть дополнительные состояния:

VisualElement определяет общие для всех элементов состояния Normal, Disabled, Focused и PointerOver

Button определяет состояние Pressed (нажатие кнопки)

CarouselView определяет состояния DefaultItem, CurrentItem, PreviousItem и NextItem

CheckBox определяет состояние IsChecked (флажок отмечен)

CollectionView определяет состояние Selected (элемент выделен)

ImageButton определяет состояние Pressed (нажатие кнопки)

RadioButton определяет состояния Checked (элемент выбран) и Unchecked (элемент не выбран)

Switch определяет состояния On (включено) и Off(выключено)
 */

public partial class VisualStateManagerPage : ContentPage
{
	public VisualStateManagerPage()
	{
		InitializeComponent();

		SetState(false); // изначально невалидное состояние
	}

	void EntryTextChanged(object sender, TextChangedEventArgs e)
	{
		// проверяем введенное значение на соответствие регулярному выражению
		bool isValid = Regex.IsMatch(e.NewTextValue, @"^\+[1-9]-\d{3}-\d{3}-\d{4}$");
		SetState(isValid);
	}

	private void SetState(bool isValid)
	{
		string state = isValid ? "Valid" : "Invalid";
		// Элемент отслеживает изменения своих состояний и после этого вызывает метод 
		// VisualStateManager.GoToState(visualElement, "State"), 
		// где visualElement - элемент, тип которого унаследован от VisualElement (например, здесь Entry);
		// "State" - название состояния (например, в данном случае кастомное состояние "Valid" или "Invalid"
		VisualStateManager.GoToState(myEntry, state);
	}
}