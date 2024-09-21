namespace MetanitLessons.Maui.Controls;

/** TableView
 * Свойства:

Intent: определяет назначение таблицы на iOS (применяется только к iOS). 
Представляет одну из констант перечисления TableIntent:

	Data: предназначен для простого отображения данных

	Form: представляет форму ввода данных, как в примере выше

	Menu: используется для вывода меню

	Settings: используется для отображения набора настроек

HasUnevenRows: представляет тип bool и указывает, будут ли строки в таблицы иметь различную высоту. 
Значение по умолчаниюfalse.

Root: определяет содерижимое таблицы в виде объекта TableRoot.

RowHeight: определяет высоту строк в виде значения int, если свойство HasUnevenRows равно false.

 * Чтобы определить содержимое TableView, надо его свойству Root присвоить некоторый объект TableRoot. 
 * TableRoot хранит секции таблицы в виде объектов TableSection. 
 * Каждая же секция в свою очередь содержит набор отдельных ячеек или элементов Cell.
 * 
 * Типы ячеек:

EntryCell: представляет метку с текстовым полем для ввода данных. Генерирует событие Completed

	Свойства EntryCell:

		Keyboard: тип клавиатуры, которая отображается для ввода текста

		Label: текстовая метка, которая отображается слева от поля ввода

		LabelColor: цвет текста метки

		Placeholder: текст, отображаемый до ввода текста

		Text: сам введенный текст

		HorizontalTextAlignment: горизонтальное выравнивание текста

SwitchCell: представляет метку с переключателем. Генерирует событие OnChanged

	Свойства SwitchCell:
		
		Text: представляет текст ячейки

		On: указывает, находится в отмеченном или нет состоянии

TextCell: две метки для вывода текста

ImageCell: аналогична TextCell со включением изображения

ViewCell: содержимое и формат отображения данных ячейки определяется разработчиком

 */

public partial class TableViewPage : ContentPage
{
	public TableViewPage()
	{
		TableView tableView = new TableView
		{
			Margin = 10,
			Intent = TableIntent.Data, // для iOS
			Root = new TableRoot("Разработка ПО")
			{
				new TableSection("Языки программирования")
				{
					new TextCell { Text = "Java", Detail = "Был создан в 1995 году в компании Sun Microsystems" },
					new TextCell { Text = "C#", Detail = "Был создан в 2000 году в компании Microsoft" }
				},

				new TableSection("Базы данных")
				{
					new TextCell { Text = "MySQL", Detail = "Была создана в 1995 году в компании MySQL AB" },
					new TextCell { Text = "MS SQL Server", Detail = "Была создана в 1989 году в компании Microsoft" }
				}
			}
		};

		Content = tableView;

		InitializeComponent();
	}

	void OnTextCompleted(object? sender, EventArgs e)
	{
		loginLabel.Text = loginEntry.Text;
	}

	void OnStatusChanged(object? sender, ToggledEventArgs e)
	{
		saveLabel.Text = saveSwitch.On ? "Saved" : "Not Saved";
	}
}