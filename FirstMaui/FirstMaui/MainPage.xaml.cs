namespace FirstMaui;

public partial class MainPage : ContentPage
{
	long count = 0;
 
	public MainPage()
	{
		InitializeComponent();
		CheckTotal();
        //Preferences.Default.Set("count", count);
    }

    // Checks to see what the total count is so that the person can be awared a crab fact
    // https://www.originaloysterhouse.com/crab-fact/
    private void CheckTotal()
	{
		if (count >= 1000)
			//("There are over 6,700 species of crab");
		else if (count >= 5000)
			Console.WriteLine("The Japanese spider crab is the world’s largest crab, measuring 12 to 13 feet across");
		else if (count >= 10000)
			Console.WriteLine("Among the world’s smallest crabs are pea crabs which grow to be .4 to .6 inches in diameter");
		else if (count >= 15000)
			Console.WriteLine("A group of crabs is called a cast");
		else if (count >= 100000)
			Console.WriteLine("Crab nutrition fact: Crab meat is high in vitamin B12, and 2-3 ounces of crab meat is enough to meet adult daily B12 requirements");
		else if (count >= 100000000)
			Console.WriteLine("Hermit crabs, king Crabs, and horseshoe crabs are false crabs");
		else if (count >= 11000000000)
			Console.WriteLine("Crabs can walk in all directions, but mostly walk and run sideways");

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

