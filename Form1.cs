using System.Net;

namespace homework_problems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Checks what radio button is clicked and generates the corresponding number of problems
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd_GetProblems_Click(object sender, EventArgs e)
        {
            // Variables that that are passed through the text fields and set up the totalNumber
            int startPoint = int.Parse(txt_StartingPoint.Text);
            int endPoint = int.Parse(txt_EndingPoint.Text);
            int totalNumber;

            // Checks to see if radio button Every is True
            if (rdb_Every.Checked)
            {
                // Sets up variables used
                totalNumber = endPoint;
                var problemArray = new int[totalNumber];
                int index = 0;

                // Stores every number into the problemArray
                for (int i = startPoint; i <= totalNumber; i++)
                {
                    problemArray[index] = i;
                    index++;
                }

                // Display a message box with the total number of problems and a list of each problem
                string toDisplay = string.Join(Environment.NewLine, problemArray);
                MessageBox.Show("The total of problems is: " + totalNumber + "\nThe list of problems are:\n " + toDisplay, "List of Problems", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            // Checks to see if the radio button EveryOddProb is True
            else if (rdb_EveryOddProb.Checked)
            {
                // Sets up variables used
                totalNumber = endPoint / 2;
                var problemArray = new int[totalNumber];
                int index = 0;

                // Gets the odd number problems and save it in the problemArray
                for (int i = startPoint; i <= endPoint; i++)
                {
                    if (i % 2 != 0)
                    {
                        problemArray[index] = i;
                        index++;
                    }
                }

                // Display a message box with the total number of problems and a list of each problem
                string toDisplay = string.Join(Environment.NewLine, problemArray);
                MessageBox.Show("The total of problems is: " + totalNumber + "\nThe list of problems are:\n " + toDisplay, "List of Problems", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            // Checks to see if the radio button EveryOtherProb is True
            else if (rdb_EveryOtherOdd.Checked)
            {
                // Sets up variables used
                totalNumber = endPoint / 3;
                var problemArray = new int[totalNumber];
                int index = 0;

                // Gets every other odd problem and saves it into problemArray
                for (int i = startPoint; i <= endPoint; i++)
                {
                    if (i % 3 == 0)
                    {
                        problemArray[index] = i;
                        index++;
                    }
                }

                // Display a message box with the total number of problems and a list of each problem
                string toDisplay = string.Join(Environment.NewLine, problemArray);
                MessageBox.Show("The total of problems is: " + totalNumber + "\nThe list of problems are:\n " + toDisplay, "List of Problems", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        /// <summary>
        /// Checks anytime something is entered into the field and see if its a number if not a message box pops up
        /// saying please enter a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_StartingPoint_TextChanged(object sender, EventArgs e)
        {
            string srtPnt = txt_StartingPoint.Text;
            int n;
            
            if (!int.TryParse(srtPnt, out n))
            {
                MessageBox.Show("Please enter a number");
            }
        }

        /// <summary>
        /// Checks anytime something is entered into the field and see if its a number if not a message box pops up
        /// saying please enter a number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_EndingPoint_TextChanged(object sender, EventArgs e)
        {
            string ndPnt = txt_EndingPoint.Text;
            int n;
            if (!int.TryParse(ndPnt, out n))
            {
                MessageBox.Show("Please enter a number");
            }

        }
    }
}