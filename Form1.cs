using System.Diagnostics.Eventing.Reader;
using System.Net;

namespace homework_problems
{
    public partial class Form1 : Form
    {
        #region Private Variables

        /// <summary>
        /// Used to store the starting number for the problems
        /// </summary>
        int _startPoint = 0;

        /// <summary>
        /// Used to store the ending number for the problems
        /// </summary>
        int _endPoint = 0;

        /// <summary>
        /// Used to store the total number of problems
        /// </summary>
        int _totalNumber = 0;

        #endregion

        #region Methods

        /// <summary>
        /// Checks see if the string passed in is number
        /// </summary>
        /// <param name="str">The string the user wants to check if its a number</param>
        /// <returns>The entered in number if it is one if not returns -1</returns>
        int isNumber(string str)
        {
            if (int.TryParse(str, out int num))
            {
                return num;
            }
            return -1;
        }

        /// <summary>
        /// Checks to see if startPoint less than endPoint
        /// </summary>
        /// <param name="startPoint">The number that user wants to check is less</param>
        /// <param name="endPoint">The number the user wants to check is greater</param>
        /// <returns>true of startPoint is less than endPoint if not false</returns>
        bool isSPLessThanEP(int startPoint, int endPoint)
        {
            if (startPoint < endPoint)
            {
                return true;
            }
            return false;
        }

        #endregion

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


            // Uses is number to check if the text from StartingPoint and EndingPoint is a number
            _startPoint = isNumber(txt_StartingPoint.Text);
            _endPoint = isNumber(txt_EndingPoint.Text);

            // Checks to see if numbers passed in are greater than 0 if not displays errors labels
            if (_startPoint <= 0 || _startPoint > 200)
            {
                lbl_errorProb1.Text = "Please enter a number between 1 and 200";
            }
            else
            {
                lbl_errorProb1.Text = "";
            }

            if (_endPoint <= 0 || _endPoint > 200)
            {
                lbl_errorProb2.Text = "Please enter anumber between 1 and 200";
            }
            else
            {
                lbl_errorProb2.Text = "";
            }

            // Makes sure both _startPoint and _endPoint is greater than 0
            if (_startPoint > 0 && _endPoint > 0 && _startPoint <= 200 && _endPoint <= 200)
            {
                // Calls isSPLessThanEp on _startPoint and _endpoint if false displays error labels
                if (isSPLessThanEP(_startPoint, _endPoint))
                {
                    lbl_errorProb1.Text = "";
                    lbl_errorProb2.Text = "";
                    rtb_problemOutput.Text = "";
                    _totalNumber = 0;

                    // Checks to see if radio button Every is True
                    if (rdb_Every.Checked)
                    {
                        // Updates error label that a radioButton been selected
                        lbl_errorRadioButton.Text = "";

                        // Loops through storing the results into rtb_problemOutPut
                        for (int i = _startPoint; i <= _endPoint; i++)
                        {
                            _totalNumber++;
                            // if its not the first problem it adds an , before the next number is printed
                            if (_totalNumber != 1)
                            {
                                rtb_problemOutput.Text += ", ";
                            }
                            rtb_problemOutput.Text += i.ToString();
                        }

                        // Prints out the _totalNumber
                        rtb_problemOutput.Text += "\nTotal number of Problems: " + _totalNumber;
                    }
                    // Checks to see if the radio button EveryOddProb is True
                    else if (rdb_EveryOddProb.Checked)
                    {
                        // Updates error label that a radioButton been selected
                        lbl_errorRadioButton.Text = "";

                        // Loops through storing the odd number results into rtb_problemOutPut
                        for (int i = _startPoint; i <= _endPoint; i += 2)
                        {
                            _totalNumber++;
                            // if its not the first problem it adds an , before the next number is printed
                            if (_totalNumber != 1)
                            {
                                rtb_problemOutput.Text += ", ";
                            }
                            rtb_problemOutput.Text += i.ToString();
                        }

                        // Prints out the _totalNumber
                        rtb_problemOutput.Text += "\nTotal number of Problems: " + _totalNumber;
                    }
                    // Checks to see if the radio button EveryOtherProb is True
                    else if (rdb_EveryOtherOdd.Checked)
                    {
                        // Updates error label that a radioButton been selected
                        lbl_errorRadioButton.Text = "";

                        // Gets every other odd problem and saves it into problemArray
                        for (int i = _startPoint; i <= _endPoint; i += 4)
                        {
                            _totalNumber++;
                            if (_totalNumber != 1)
                            {
                                rtb_problemOutput.Text += ", ";
                            }
                            rtb_problemOutput.Text += i.ToString();

                        }
                        // Prints out the _totalNumber
                        rtb_problemOutput.Text += "\nTotal number of Problems: " + _totalNumber;
                    }
                    else
                    {
                        // Error label is updated
                        lbl_errorRadioButton.Text = "Please select a radio button"; ;
                    }

                }
                else
                {
                    // Error label is updated
                    lbl_errorProb1.Text = "First problem must be less than Last Problem";
                }
            }

        }

    }
}