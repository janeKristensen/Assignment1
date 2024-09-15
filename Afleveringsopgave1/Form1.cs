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
        private SortedDictionary<string, string> _namesDict;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize array and dictionary objects and sort in alphabetical order.
            _namesArr = new string[4] {"Labrador", "Poodle", "Beagle", "Golden Retriever"};
            _arrIndex = _namesArr.Length;
            Array.Sort(_namesArr);

            _namesDict = new SortedDictionary<string, string>() { 
                { "Labrador", "Great family dog" },
                { "Poodle", "Fluffy, curly fur" },
                { "Beagle" , "Good breed for hunters"},
                { "Golden Retriever", "Loves food very much" }, 
            };

            // Initialize ListView objects
            listViewArray.View = View.Details;
            listViewArray.Columns.Add("Position", 50);
            listViewArray.Columns.Add("Name", 150);
            listViewArray.FullRowSelect = true;

            listViewDict.View = View.Details;
            listViewDict.Columns.Add("Name", 125);
            listViewDict.Columns.Add("Information", -2);
            listViewDict.FullRowSelect = true;

            LoadArrayItems();
            LoadDictItems();
            
        }

        // Add and remove items from list.
        #region Item logic

        private void LoadArrayItems()
        {
            listViewArray.Items.Clear();

            for (int i = 0; i < _namesArr.Length; i++)
            {
                ListViewItem item = new ListViewItem($"Pos:{i + 1}");
                item.SubItems.Add(_namesArr[i]);

                listViewArray.Items.Add(item);
            }
        }

        private void LoadDictItems()
        {
            listViewDict.Items.Clear();

            int iter = 1;
            foreach (var kvp in _namesDict)
            {
                ListViewItem item = new ListViewItem(kvp.Key);
                item.SubItems.Add(kvp.Value);

                listViewDict.Items.Add(item);
                iter++;
            }
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            // Increase array size if index reaches the end.
            if (_arrIndex == _namesArr.Length)
                Array.Resize(ref _namesArr, _namesArr.Length + 1);

            // Add item to array at current index
            _namesArr[_arrIndex] = txtBoxNameInput.Text;
            Array.Sort(_namesArr);
            _arrIndex += 1;
            LoadArrayItems();

            _namesDict.Add(txtBoxNameInput.Text, "Default desciption");
            LoadDictItems();

            txtBoxNameInput.Clear();
        }

        private void btnDeletePos_Click(object sender, EventArgs e)
        {
            // Convert input position to 0-index
            int index = Convert.ToInt32(txtBoxPositionInput.Text) - 1; 
            DeleteFromArray(index);

            txtBoxPositionInput.Clear();    
        }

        private void btnDeleteFromArray_Click(object sender, EventArgs e)
        {
            if(listViewArray.SelectedIndices.Count > 0)
                DeleteFromArray(listViewArray.SelectedIndices[0]);
        }

        private void btnDeleteFromDict_Click(object sender, EventArgs e)
        {
            if (listViewDict.SelectedIndices.Count > 0)
            {
                _namesDict.Remove(listViewDict.SelectedItems[0].Text);
                LoadDictItems();
            }      
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
            LoadArrayItems();
        }

        private void btnSortOption_Click(object sender, EventArgs e)
        {

            Array.Reverse(_namesArr);
            LoadArrayItems() ;

            if (btnSortOption.Text == "Sort ascending")
            {
                listViewDict.Sorting = SortOrder.Ascending;
                btnSortOption.Text = "Sort descending";
            }
            else
            {
                listViewDict.Sorting = SortOrder.Descending;
                btnSortOption.Text = "Sort ascending";
            }
        }

        #endregion

        
        // Input validation on textboxes.
        #region Input validation
        private void txtBoxNameInput_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.Font = new Font(txtBox.Font, FontStyle.Regular);

            if ((txtBox.Text != ""))
            {
                if (Regex.IsMatch(txtBox.Text, "^[ÆØÅæøåa-zA-Z]+( [ÆØÅæøåa-zA-Z]+)*$"))
                {
                    btnAddName.Enabled = true;
                    lblErrorNameInput.Visible = false;
                }
                else
                {
                    btnAddName.Enabled = false;
                    lblErrorNameInput.Visible = true;
                }
            }
            else
            {
                btnAddName.Enabled = false;
                lblErrorNameInput.Visible = false;
            }
        }

        private void txtBoxPositionInput_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            txtBox.Font = new Font(txtBox.Font, FontStyle.Regular);

            if (txtBox.Text != "")
            {
                btnDeletePos.Enabled = false;
                lblErrorPosInput.Visible = true;

                if (Regex.IsMatch(txtBox.Text, "^[1-9]+([0-9])*$"))
                {
                    int input = Convert.ToInt32(txtBox.Text);

                    if ((0 < input) && (input <= _arrIndex))
                    {
                        btnDeletePos.Enabled = true;
                        lblErrorPosInput.Visible = false;
                    }
                }
            }
            else
            {
                btnDeletePos.Enabled = false;
                lblErrorPosInput.Visible = false;
            }
        }

        #endregion

       
        // Adding a tooltip text label to text input boxes
        #region Tooltip logic
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

        #endregion
    }
}
