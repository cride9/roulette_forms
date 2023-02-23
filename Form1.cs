using System.Runtime.CompilerServices;

namespace Roulette {
    public partial class Roulette : Form {

        static Random rnd = new();
        static (char, int)[,] dataTuple = new (char, int)[12, 3];
        static int betAmount = 100;

        public Roulette() {

            InitializeComponent();
        }

        private void Initialization(object sender, EventArgs e) {

            // read the file
            try {
                using (var sr = new StreamReader(@"../../../src/french_layout.txt")) {

                    // remove the first line
                    _ = sr.ReadLine();
                    for (int i = 0; i < dataTuple.GetLength(0); i++) {

                        // separated by semicolons
                        string[] currentLine = sr.ReadLine().Split(';');

                        // first element is the color (e.g., Red : Blue)
                        // other elements are the number (e.g., 01)
                        for (int j = 0; j < dataTuple.GetLength(1); j++)
                            dataTuple[i, j] = (currentLine[j].First(), int.Parse(currentLine[j].Remove(0, 1)));
                    }
                }
            }
            catch (FileNotFoundException) { // kellett debugger hogy fixen jo-e szerinte mert kaszinos a pali ezért ide raktam ezt
                MessageBox.Show("Generating backup..", "File is missing!");
            }
            catch (DirectoryNotFoundException) { // kellett debugger hogy fixen jo-e szerinte mert kaszinos a pali ezért ide raktam ezt
                MessageBox.Show("Generating backup..", "Directory is missing!");
            }
            finally {

                string backupInformation = "G00\r\nR01;B02;R03\r\nB04;R05;B06\r\nR07;B08;R09\r\nB10;B11;R12\r\nB13;R14;B15\r\nR16;B17;R18\r\nR19;B20;R21\r\nB22;R23;B24\r\nR25;B26;R27\r\nB28;B29;R30\r\nB31;R32;B33\r\nR34;B35;R36\r\n";

                using (StreamWriter sw = new(@"map.txt", false)) {
                    sw.Write(backupInformation);
                }

                using (var sr = new StreamReader(@"map.txt")) {

                    // remove the first line
                    _ = sr.ReadLine();
                    for (int i = 0; i < dataTuple.GetLength(0); i++) {

                        // separated by semicolons
                        string[] currentLine = sr.ReadLine().Split(';');

                        // first element is the color (e.g., Red : Blue)
                        // other elements are the number (e.g., 01)
                        for (int j = 0; j < dataTuple.GetLength(1); j++)
                            dataTuple[i, j] = (currentLine[j].First(), int.Parse(currentLine[j].Remove(0, 1)));
                    }
                }
            }
            
            // build the area with the values
            BuildPlayArea();
        }

        void BuildPlayArea() {

            // make every button the same size
            Size buttonSize = new Size(50, 40);

            // get the form middle -> start from the left -> middle -> right
            Point startPosition = new Point((this.Size.Width / 2) - (buttonSize.Width / 2) - buttonSize.Width, 5);

            // 0 button that we discarded (easier to render it alone)
            AddButton(
                buttonSize, 
                new Point(startPosition.X + buttonSize.Width, startPosition.Y), 
                "0", 
                Color.FromArgb(58, 145, 71),
                PlaceBet
                );

            for (int i = 0; i < dataTuple.GetLength(0); i++) {
                for (int j = 0; j < dataTuple.GetLength(1); j++) {

                    // side button for the big bets (1-12, 13-24, 25-36)
                    // simple math and some hardcoded values (not compatible with resizing the window)
                    switch (i) {
                        case 0:
                            AddButton(
                                new Size(buttonSize.Width, (buttonSize.Height + 7) * 4 + 2), 
                                new Point(startPosition.X - buttonSize.Width - 5, startPosition.Y + (i + 1) * buttonSize.Width), 
                                "1-12", 
                                Color.FromArgb(58, 113, 145),
                                PlaceBet
                                );
                            AddButton(
                                new Size(buttonSize.Width, (buttonSize.Height + 7) * 6 + 8),
                                new Point(startPosition.X + buttonSize.Width * 3 + 5, startPosition.Y + (i + 1) * buttonSize.Width),
                                "blue",
                                Color.FromArgb(58, 113, 145),
                                PlaceBet
                                );
                            break;
                        case 4:
                            AddButton(
                                new Size(buttonSize.Width, (buttonSize.Height + 7) * 4 + 2),
                                new Point(startPosition.X - buttonSize.Width - 5, startPosition.Y + (i + 1) * buttonSize.Width),
                                "13-24",
                                Color.FromArgb(58, 113, 145),
                                PlaceBet
                                );
                            AddButton(
                                new Size(buttonSize.Width, (buttonSize.Height + 7) * 6 + 8),
                                new Point(startPosition.X + buttonSize.Width * 3 + 5, startPosition.Y + (i + 1) * buttonSize.Width + buttonSize.Width * 2),
                                "red",
                                Color.FromArgb(145, 58, 58),
                                PlaceBet
                                );
                            break;
                        case 8:
                            AddButton(
                                new Size(buttonSize.Width, (buttonSize.Height + 7) * 4 + 2),
                                new Point(startPosition.X - buttonSize.Width - 5, startPosition.Y + (i + 1) * buttonSize.Width),
                                "25-36",
                                Color.FromArgb(58, 113, 145),
                                PlaceBet
                                );
                            break;
                    }

                    // main buttons where we can place out bets
                    AddButton(
                        buttonSize, 
                        new Point(startPosition.X + (j * buttonSize.Width), startPosition.Y + (i + 1) * buttonSize.Width),
                        dataTuple[i, j].Item2.ToString(),
                        dataTuple[i, j].Item1 == 'R' ? Color.FromArgb(145, 58, 58) : Color.FromArgb(58, 65, 145),
                        PlaceBet
                        );
                }
            }
        }

        void AddButton(Size size, Point location, string text, Color color, EventHandler objectClick = null) {

            // simple button creation method
            // prevent code repetition
            Button newButton = new();
            newButton.Size = size;
            newButton.Location = location;
            newButton.Name = $"{text}Button";
            newButton.Text = text;
            newButton.BackColor = color;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.Click += objectClick;
            // label has a static background color -> this fixes button flashing when clicked or hovered
            // therefore the label will be "transparent" (background wise)
            newButton.FlatAppearance.MouseOverBackColor = color;
            newButton.FlatAppearance.MouseDownBackColor = color;
            Controls.Add(newButton);
        }

        void PlaceBet(object sender, EventArgs args) {

            // user exploit defense (or user dumbness)
            if (betAmount <= 0 || betAmount > int.Parse(userMoney.Text.Split(' ')[1])) {
                MessageBox.Show("Please use a valid bet amount", "Invalid bet");
                return;
            }

            // label can be clicked, if user clicked it still add the value
            if (sender is Label)
                AddBetAmount(sender as Label);

            if (sender is not Button)
                return;

            // check for existing label, to not create duplicated labels
            Label existingLabel = Controls.Find($"{(sender as Button).Text}label", true).FirstOrDefault() as Label;
            if (existingLabel is not null)
                AddBetAmount(existingLabel);
            else
                ButtonClickEvent(sender as Button);

        }

        private void AddBetAmount(Label sender) {

            userMoney.Text = $"Money: {int.Parse(userMoney.Text.Split(' ')[1]) - betAmount}";
            sender.Text = (int.Parse(sender.Text) + betAmount).ToString();
        }

        private void ButtonClickEvent(Button sender) {

            // this method only called once when generating a bet label
            Label currentBet = new Label();
            currentBet.Tag = sender.Name;
            currentBet.Parent = sender;

            // properly set label size & location to not cover the button itself
            currentBet.Size = new(sender.Width - 20, 12);
            currentBet.Location = new Point(sender.Location.X + 10, sender.Location.Y + sender.Height - 15);

            currentBet.Text = $"{betAmount}";
            currentBet.Visible = true;
            currentBet.Name = $"{sender.Text}label";
            currentBet.TextAlign = ContentAlignment.BottomCenter;
            currentBet.Click += PlaceBet;
            currentBet.BackColor = sender.BackColor; // transparent nem mukodik mert winfos gg microsoft

            Controls.Add(currentBet);
            currentBet.BringToFront();
            userMoney.Text = $"Money: {int.Parse(userMoney.Text.Split(' ')[1]) - betAmount}";
        }

        // used by the tokens
        private void ChangeBetAmount(object sender, EventArgs e) {

            if (sender is TextBox) {
                int.TryParse(betAmountManual.Text, out betAmount);
                selectedToken.Text = $"Selected: {betAmount}";
            }

            if (sender is not Button)
                return;

            Button currentButton = sender as Button;

            // user check to not use invalid amounts
            if (currentButton.Text == "Manual") {
                if (!int.TryParse(betAmountManual.Text, out betAmount) || betAmount <= 0)
                    MessageBox.Show("Invalid bet amount", "Invalid data");
            }
            else
                betAmount = int.Parse(currentButton.Text);

            // change to the selected value
            selectedToken.Text = $"Selected: {betAmount}";
        }

        private void RollRandom(object sender, EventArgs e) {

            int randomGeneration = rnd.Next(0, 37);
            bool betPlaced = false;

            // igyis ismetlodo kod szoval idc
            betPlaced = CheckRange(1, 12, randomGeneration);
            betPlaced = CheckRange(13, 24, randomGeneration);
            betPlaced = CheckRange(25, 36, randomGeneration);

            // amugy lehet mindkettore rakni?? xdd
            betPlaced = CheckColor("red");
            betPlaced = CheckColor("blue");

            for (int i = 0; i <= 36; i++) {

                using (Label output = Controls.Find($"{i}label", true).FirstOrDefault() as Label) {

                    if (output is null)
                        continue;

                    betPlaced = true;
                    int betOnButton = int.Parse(output.Text);

                    if (i == randomGeneration) {

                        userMoney.Text = $"Money: {int.Parse(userMoney.Text.Split(' ')[1]) + betOnButton * 10}";
                    }
                    Controls.Remove(output);
                }
            }
            if (!betPlaced)
                MessageBox.Show($"Please bet for a number!", "Forgot to bet");
            else
                MessageBox.Show($"Winner number: {randomGeneration}", "Number");
        }

        private bool CheckRange(int from, int to, int randomGeneration) {

            using (Label output = Controls.Find($"{from}-{to}label", true).FirstOrDefault() as Label) {

                if (output is null) 
                    return false;

                if (randomGeneration >= from && randomGeneration <= to && int.Parse(output.Text) > 0) 
                    userMoney.Text = $"Money: {int.Parse(userMoney.Text.Split(' ')[1]) + int.Parse((Controls.Find($"{from}-{to}label", true).FirstOrDefault() as Label).Text) * 2}";

                return true;
            }
        }

        private bool CheckColor(string color) {

            using (Label output = Controls.Find($"{color}label", true).FirstOrDefault() as Label) {

                if (output is null)
                    return false;

                if (int.Parse(output.Text) > 0)
                    userMoney.Text = $"Money: {int.Parse(userMoney.Text.Split(' ')[1]) + int.Parse((Controls.Find($"{color}label", true).FirstOrDefault() as Label).Text) * 2}";

                return true;
            }
        }
    }
}