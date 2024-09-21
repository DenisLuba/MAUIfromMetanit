namespace MetanitLessons.Maui.Controls;

/** WebView
 * ��������:

Cookies: ������������ ��� CookieContainer � ��������� ��������� ������.

CanGoBack: ������������ ��� bool � ���������, ����� �� ������� � ���������� ��������. 
	������ �������� �������� ������ ��� ������.

CanGoForward: ������������ ��� bool � ���������, ����� �� ������� � ��������� ��������. 
	������ �������� �������� ������ ��� ������.

Source: ������������ ��� WebViewSource - ����� ������� html-��������, ������� ������������ � WebView. 
	� ���������� ������ �������� ����� ������������ ���� �� ����������� ������ WebViewSource: 
	���� ��� UrlWebViewSource (���� html-�������� ��������� �� ���������), 
	���� ��� HtmlWebViewSource (���� �������� ��������� html-����)
 
 * ���� ������ WebView ���������� � ���������� HorizontalStackLayout, StackLayout ��� VerticalStackLayout, 
 * �� ��� WebView ���������� ���������� �������� HeightRequest � WidthRequest. 
 * ����� WebView �� ����� ������������.
 

 * ������� � ������ iOS 9, ������� ��������� ����������������� ������ � SSL. 
 * ������� ���������� ������ ������ � ���� Platforms/iOS/info.plist (��� ����� �������, ��������, � VS Code)

 * ��� ������������ ��������� ����� WebView ���������� ��� �������:

	Navigating: ���������, ����� ���������� ������� �� ��������. � �������� ��������� ��������� 
		�������� ���� WebNavigatingEvent, ������� ���������� �������� Cancel. ���� ��� �������� ����� 
		true, �� ������� �� �������� �������.

	Navigated: ���������, ����� ������� �� �������� ��������. � �������� ��������� ��������� 
		������ ������ WebNavigatedEventArgs. ���� ����� ���������� �������� Result, ������� 
		������������ ��� WebNavigationResult � ������ ��������� �������� � ���� ����� �� �������� 
		WebNavigationResult:

			Success: ������� ������� ����������

			Cancel: ������� �������

			Timeout: ������� � �������� ��������

			Failure: ������� ���������� ��������
 */

public partial class WebViewPage : ContentPage
{
	Label statusLabel = new Label { Padding = 8, FontSize = 20 };

	WebView webView;

	public WebViewPage()
	{
		// �������� HTML-�����
		//webView = new WebView();
		//var htmlSource = new HtmlWebViewSource();
		//htmlSource.Html = @"
		//				<h1>Hello METANIT.COM</h1>
		//				<p>Hello .NET MAUI!</p>
		//				";
		//webView.Source = htmlSource;
		//Content = webView;

		// �������� ��������� HTML-������
		webView = new WebView();
		webView.Source = "index.html";
		Content = webView;

		/*
		// �������� WEB-��������
		webView = new WebView
		{
			Source = "https://metanit.com/"
			// ��� ���
			//Source = new UrlWebViewSource { Url = "https://metanit.com/" }
		};

		webView.Navigated += WebViewNavigated; // ���������� ���������� �������

		// ���� ����� ������� �����, ��������� �����
		if (webView.CanGoBack)
		{
			webView.GoBack();
		}

		// ���� ����� ������� ������, ��������� ������
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
			statusLabel.Text = "������ ���������� �������";
		else
			statusLabel.Text = "� �������� ������� �������� ��������";
	}

	// ������ �����
	protected override bool OnBackButtonPressed()
	{
		if (webView is null) return false;

		// ���� ����� ������� �����, ��������� �����
		if (webView.CanGoBack)
		{
			webView.GoBack();
			return true;
		}
		else return false;
	}

	// ���� ����� ��� IOS
	protected override void OnHandlerChanged()
	{
		base.OnHandlerChanged();
#if IOS
        var web = webView?.Handler?.PlatformView as Webkit.WKWebView;
        web.AllowsBackForwardNavigationGestures = true;
#endif
	}
}