namespace MetanitLessons.Maui.Controls;

/** WebView
 * Свойства:

Cookies: представляет тип CookieContainer и позволяет управлять куками.

CanGoBack: представляет тип bool и указывает, можно ли перейти к предыдущей странице. 
	Данное свойство доступно только для чтения.

CanGoForward: представляет тип bool и указывает, можно ли перейти к следующей странице. 
	Данное свойство доступно только для чтения.

Source: представляет тип WebViewSource - адрес текущей html-страницы, которая отображается в WebView. 
	В реальности данное свойство будет представлять один из наследников класса WebViewSource: 
	либо тип UrlWebViewSource (если html-страница загружена из интернета), 
	либо тип HtmlWebViewSource (если загружен локальный html-файл)
 
 * Если объект WebView помещается в контейнеры HorizontalStackLayout, StackLayout или VerticalStackLayout, 
 * то для WebView необходимо установить свойства HeightRequest и WidthRequest. 
 * Иначе WebView не будет отображаться.
 

 * Начиная с версии iOS 9, система позволяет взаимодействовать только с SSL. 
 * Поэтому необходимо внести правки в файл Platforms/iOS/info.plist (его можно открыть, например, в VS Code)

 * Для отслеживания навигации класс WebView определяет два события:

	Navigating: возникает, когда начинается переход на страницу. В качестве параметра принимает 
		аргумент типа WebNavigatingEvent, который определяет свойство Cancel. Если это свойство равно 
		true, то переход на страницу отменен.

	Navigated: возникает, когда переход на страницу завершен. В качестве параметра принимает 
		объект класса WebNavigatedEventArgs. Этот класс определяет свойство Result, которое 
		представляет тип WebNavigationResult и хранит результат перехода в виде одной из констант 
		WebNavigationResult:

			Success: переход успешно завершился

			Cancel: переход отменен

			Timeout: таймаут в процессе перехода

			Failure: переход завершился неудачно
 */

public partial class WebViewPage : ContentPage
{
	Label statusLabel = new Label { Padding = 8, FontSize = 20 };

	WebView webView;

	public WebViewPage()
	{
		// ЗАГРУЗКА HTML-СТРОК
		//webView = new WebView();
		//var htmlSource = new HtmlWebViewSource();
		//htmlSource.Html = @"
		//				<h1>Hello METANIT.COM</h1>
		//				<p>Hello .NET MAUI!</p>
		//				";
		//webView.Source = htmlSource;
		//Content = webView;

		// ЗАГРУЗКА ЛОКАЛЬНЫХ HTML-ФАЙЛОВ
		webView = new WebView();
		webView.Source = "index.html";
		Content = webView;

		/*
		// ЗАГРУЗКА WEB-СТРАНИЦЫ
		webView = new WebView
		{
			Source = "https://metanit.com/"
			// или так
			//Source = new UrlWebViewSource { Url = "https://metanit.com/" }
		};

		webView.Navigated += WebViewNavigated; // подключаем обработчик события

		// если можно перейти назад, переходим назад
		if (webView.CanGoBack)
		{
			webView.GoBack();
		}

		// если можно перейти вперед, переходим вперед
		if (webView.CanGoForward)
		{
			webView.GoForward();
		}

		Grid grid = new Grid();
		grid.RowDefinitions.Add(new RowDefinition { Height = 60 });
		grid.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });

		grid.Add(statusLabel, 0, 0);
		grid.Add(webView, 0, 1);

		Content = grid;

		*/

		//InitializeComponent();
	}

	public void WebViewNavigated(object? sender, WebNavigatedEventArgs e)
	{
		if (e.Result == WebNavigationResult.Success)
			statusLabel.Text = "Запрос завершился успешно";
		else
			statusLabel.Text = "В процессе запроса возникли проблемы";
	}

	// кнопка назад
	protected override bool OnBackButtonPressed()
	{
		if (webView is null) return false;

		// если можно перейти назад, переходим назад
		if (webView.CanGoBack)
		{
			webView.GoBack();
			return true;
		}
		else return false;
	}

	// жест назад для IOS
	protected override void OnHandlerChanged()
	{
		base.OnHandlerChanged();
#if IOS
        var web = webView?.Handler?.PlatformView as Webkit.WKWebView;
        web.AllowsBackForwardNavigationGestures = true;
#endif
	}
}