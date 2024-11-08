namespace MetanitLessons.Maui.ListViews;


/** Стратегии кэширования (свойство CachingStrategy):
	
	RetainElement 
				
		* Если каждая ячейка ListView имеет большое количество привязок (20-30 и более)
	
		* Если шаблон ячейки часто меняется
	
		* Если другая стратегия (RecycleElement) при тех же условиях показывает худшие результаты
	

	RecycleElement

		* Если каждая ячейка ListView имеет небольшое количество привязок
		
		* Если свойство BindingContext ячейки определяет все ее данные
		
		* Если ячейки во многом аналогичны, а их шаблон остается неизменным
 */

public partial class ListViewPage : ContentPage
{ 
	// источник данных должен быть публичным
	public List<string> Goods { get; set; }

	public ListViewPage()
	{
		Label header = new Label { Text = "Список пользователей" };
		// данные для ListView
		string[] people = new string[] { "Tom", "Bob", "Sam", "Alice" };

		//ListView listView = new ListView();
		// можно установить стратеги кэширования (по умолчанию стоит RetainElement)
		 ListView listView = new ListView(ListViewCachingStrategy.RecycleElement);
		// определяем источник данных
		listView.ItemsSource = people;
		
		Content = new StackLayout { Children = { header, listView }, Padding = 8 };



		InitializeComponent();
		Goods = new List<string> { "Mouse", "Keyboard", "Monitor", "Processor" };
		// устанавливаем контекст привязки страницы,
		// чтобы из XAML можно было обратиться ко всем публичным свойствам страницы
		BindingContext = this;
	}
}