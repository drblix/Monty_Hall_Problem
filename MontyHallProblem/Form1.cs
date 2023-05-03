
namespace MontyHallProblem
{
    public partial class MontyWindow : Form
    {
        private enum Selection
        {
            Yes,
            No,
            Random
        }

        private Selection selection = Selection.Yes;

        public MontyWindow()
        {
            InitializeComponent();
            IterationInput.KeyPress += IterationInput_KeyPress;
            RunButton.MouseClick += RunSimulation;
        }

        private void IterationInput_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Prevents non-digit characters from being entered, but allows backspace
            e.Handled = !char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('\b');
        }

        private void SwitchOption_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                selection = radioButton.Name switch
                {
                    "AllYesToggle" => Selection.Yes,
                    "AllNoToggle" => Selection.No,
                    _ => Selection.Random,
                };
            }
        }

        private void RunSimulation(object? sender, MouseEventArgs e)
        {
            // Parsing run amount to integer
            int runAmount;
            if (int.TryParse(IterationInput.Text, out int result))
                runAmount = result;
            else
                return;

            // Initializing

            Random random = new((int)DateTime.Now.Ticks);
            int games = 0;
            int wonGames = 0;

            for (int i = 0; i < runAmount; i++)
            {
                // Creating doors list so host choice can be removed
                List<int> doors = new() { 1, 2, 3 };

                // Getting random choices for each
                int prize = random.Next(0, doors.Count);
                int playerChoice = random.Next(0, doors.Count);
                int hostChoice = random.Next(0, doors.Count);

                // Host's choice must NOT be the player's or prize
                while (hostChoice == playerChoice || hostChoice == prize)
                    hostChoice = random.Next(0, doors.Count);

                // Removing host's choice from list
                doors.Remove(doors[hostChoice]);

                // Decrementing either variables if they were larger than the host's choice
                // Accommodates the resizing of the list due to host's choice removal
                if (playerChoice > hostChoice)
                    playerChoice--;
                if (prize > hostChoice)
                    prize--;

                // Will swap player's index if yes or if random and rolled good number
                if (selection == Selection.Yes || (selection == Selection.Random && random.Next(0, 2) == 0))
                    playerChoice ^= 1;

                // Player wins if their choice is the prize door
                if (playerChoice == prize)
                    wonGames++;

                // Increasing games played
                games++;
            }

            // Formatting output
            DetailedGames.Text = $"Out of {games} games, the player won {wonGames}";
            double percent = wonGames / (double)games * 100;
            PlayerPercent.Text = $"The player won {Math.Round(percent, 3)}% of all games";
        }
    }
}