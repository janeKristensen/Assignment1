using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Afleveringsopgave1
{
    public partial class Form1 : Form
    {
        private int _arrIndex;
        private string[] _namesArr;
        private List<string> _namesList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize array and list objects and sort in alphabetical order.
            _namesArr = new string[4] {"Labrador", "Poodle", "Beagle", "Golden Retriever"};
            _arrIndex = _namesArr.Length;
            Array.Sort(_namesArr);
            listBoxNamesArr.DataSource = _namesArr;

            _namesList = new List<string>() { "Labrador", "Poodle", "Beagle", "Golden Retriever" };
            _namesList.Sort();
            listBoxNamesList.DataSource = _namesList;
        }

        private void UpdateListBoxArr()
        {
            listBoxNamesArr.DataSource = null;
            listBoxNamesArr.DataSource = _namesArr;
        }

        private void UpdateListBoxList()
        {
            listBoxNamesList.DataSource = null;
            listBoxNamesList.DataSource = _namesList;
        }

 
        /*******************************************************************
         *  Input validation on textboxes.
         * ****************************************************************/
        private void txtBoxNameInput_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.Font = new Font(txtBox.Font, FontStyle.Regular);

            if((txtBox.Text != "") && Regex.IsMatch(txtBox.Text, "^[A-Za-z]*$"))
                btnAddName.Enabled = true;
            else btnAddName.Enabled = false;
        }

        private void txtBoxPositionInput_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.Font = new Font(txtBox.Font, FontStyle.Regular);

            if (Regex.IsMatch(txtBox.Text, "^[0-9]*$"))
                if (txtBox.Text != "")
                {
                    int input = Convert.ToInt32(txtBox.Text);

                    if((0 < input) && (input <= _arrIndex))
                        btnDeletePos.Enabled = true;
                }    
                else btnDeletePos.Enabled = false;
        }

        /******************************************************
         *  Add and remove items from list.
         * ***************************************************/
        private void btnAddName_Click(object sender, EventArgs e)
        {
            // Increase array size if index reaches the end.
            if (_arrIndex == _namesArr.Length)
                Array.Resize(ref _namesArr, _namesArr.Length + 1);

            _namesArr[_arrIndex] = txtBoxNameInput.Text;
            Array.Sort(_namesArr);
            _arrIndex += 1;
            UpdateListBoxArr();

            _namesList.Add(txtBoxNameInput.Text);
            _namesList.Sort();
            UpdateListBoxList();

            txtBoxNameInput.Clear();
        }

        private void btnDeletePos_Click(object sender, EventArgs e)
        {
            // Converts input position to 0-index
            int index = Convert.ToInt32(txtBoxPositionInput.Text) - 1;
            
            DeleteFromArray(index);

            _namesList.RemoveAt(index);
            UpdateListBoxList();

            txtBoxPositionInput.Clear();    
        }

        private void btnDeleteFromArray_Click(object sender, EventArgs e)
        {
            DeleteFromArray(listBoxNamesArr.SelectedIndex);
        }

        private void btnDeleteFromList_Click(object sender, EventArgs e)
        {
            _namesList.RemoveAt(listBoxNamesList.SelectedIndex);
            UpdateListBoxList();
        }

        // Shift items down the array starting at index of deleted item.
        // Resize array to fit new length.
        private void DeleteFromArray(int position)
        {
            string nextValue = "";
            int lastItem = _namesArr.Length - 1;

            for (int i = position; i < _namesArr.Length; i++)
            {
                if (i == lastItem)
                    break;

                nextValue = _namesArr[i + 1];
                _namesArr[i] = nextValue;
            }

            Array.Resize(ref _namesArr, lastItem);
            _arrIndex -= 1;
            UpdateListBoxArr();
        }


        /********************************************************
         *  Sort lists alphabetical in descending or ascending order.
         * *****************************************************/
        private void btnSortOption_Click(object sender, EventArgs e)
        {
            Array.Reverse(_namesArr);
            _namesList.Reverse();
            UpdateListBoxArr();
            UpdateListBoxList();

            // Switch the text on sort option button
            btnSortOption.Text = btnSortOption.Text == "Sort descending" ? "Sort ascending" : "Sort descending";
        }


        /***************************************************************************
         *  Adding a tooltip text label to controls
         * ************************************************************************/
        private void txtBoxNameInput_MouseLeave(object sender, EventArgs e)
        {
            lblToolTip.Visible = false;
        }

        private void txtBoxNameInput_MouseMove(object sender, MouseEventArgs e)
        {
            lblToolTip.Visible = true;
            lblToolTip.Text = "Enter the name of a dog breed to add it on the list";
            lblToolTip.Location = new Point(txtBoxNameInput.Left + e.X + 5, txtBoxNameInput.Top + e.Y + 5);
        }

        private void txtBoxPositionInput_MouseLeave(object sender, EventArgs e)
        {
            lblToolTip.Visible = false;
        }

        private void txtBoxPositionInput_MouseMove(object sender, MouseEventArgs e)
        {
            lblToolTip.Visible = true;
            lblToolTip.Text = "Enter a number corresponding to an item on the list";
            lblToolTip.Location = new Point(txtBoxPositionInput.Left + e.X + 5, txtBoxPositionInput.Top + e.Y + 5);
        }
    }
}
