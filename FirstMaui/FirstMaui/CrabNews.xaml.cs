namespace FirstMaui;

public partial class CrabNews : ContentPage
{
	public CrabNews()
	{
		InitializeComponent();
	}

    // Search bar function to find other crab news sites
    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;

        //searchResults.ItemsSource = DataService.GetSearchResults(searchBar.Text);
    }
    //private int getScale()
    //{
    //    Display display = ((WindowManager)getSystemService(Context.WINDOW_SERVICE)).getDefaultDisplay();
    //    int width = display.getWidth();
    //    Double val = new Double(width) / new Double(PIC_WIDTH);
    //    val = val * 100d;
    //    return val.intValue();
    //}
    //WebView web = new WebView(this);
    //web.setPadding(0, 0, 0, 0);
    //web.setInitialScale(getScale());
}