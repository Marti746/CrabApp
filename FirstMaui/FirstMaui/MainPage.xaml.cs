namespace FirstMaui;

public partial class MainPage : ContentPage
{
	long count = 0;

	public MainPage()
	{
		InitializeComponent();
		CheckTotal();
	}

	// Checks to see what the total count is so that the person can be awared a crab fact
	private void CheckTotal()
	{
		if (count >= 1000)
			Console.WriteLine();
		else if (count >= 10000)
			Console.WriteLine();
		else if (count >= 100000)
			Console.WriteLine();
		else if (count >= 1000000)
			Console.WriteLine();
		else if (count >= 10000000)
			Console.WriteLine();
		else if (count >= 100000000)
			Console.WriteLine();
		else if (count >= 11000000000)
			Console.WriteLine();

    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Crabs Saved {count}";
		else
			CounterBtn.Text = $"Crabs Saved {count}";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

