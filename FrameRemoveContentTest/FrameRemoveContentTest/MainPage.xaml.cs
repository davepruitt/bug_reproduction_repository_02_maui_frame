namespace FrameRemoveContentTest;

public partial class MainPage : ContentPage
{	
	public MainPage()
	{
		InitializeComponent();
	}

    private void AddContentButton_Clicked(object sender, EventArgs e)
    {
        MyFrame.Content = new CustomContentView();
    }

    private void RemoveContentButton_Clicked(object sender, EventArgs e)
    {
        MyFrame.Content = new ContentView();
        //MyFrame.Content = null;
    }
}

