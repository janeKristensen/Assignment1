namespace Afleveringsopgave1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxNameInput = new System.Windows.Forms.TextBox();
            this.lblNameInput = new System.Windows.Forms.Label();
            this.btnAddName = new System.Windows.Forms.Button();
            this.lblPositionInput = new System.Windows.Forms.Label();
            this.txtBoxPositionInput = new System.Windows.Forms.TextBox();
            this.btnDeletePos = new System.Windows.Forms.Button();
            this.listBoxNamesArr = new System.Windows.Forms.ListBox();
            this.lblListBoxArray = new System.Windows.Forms.Label();
            this.btnDeleteFromArray = new System.Windows.Forms.Button();
            this.listBoxNamesList = new System.Windows.Forms.ListBox();
            this.btnDeleteFromList = new System.Windows.Forms.Button();
            this.btnSortOption = new System.Windows.Forms.Button();
            this.lblToolTip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxNameInput
            // 
            this.txtBoxNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNameInput.Location = new System.Drawing.Point(57, 50);
            this.txtBoxNameInput.Name = "txtBoxNameInput";
            this.txtBoxNameInput.Size = new System.Drawing.Size(176, 20);
            this.txtBoxNameInput.TabIndex = 0;
            this.txtBoxNameInput.Text = "Enter dog breed";
            this.txtBoxNameInput.TextChanged += new System.EventHandler(this.txtBoxNameInput_TextChanged);
            this.txtBoxNameInput.MouseLeave += new System.EventHandler(this.txtBoxNameInput_MouseLeave);
            this.txtBoxNameInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBoxNameInput_MouseMove);
            // 
            // lblNameInput
            // 
            this.lblNameInput.AutoSize = true;
            this.lblNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameInput.Location = new System.Drawing.Point(54, 32);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.Size = new System.Drawing.Size(44, 15);
            this.lblNameInput.TabIndex = 1;
            this.lblNameInput.Text = "Name:";
            this.lblNameInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddName
            // 
            this.btnAddName.Enabled = false;
            this.btnAddName.Location = new System.Drawing.Point(57, 76);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(87, 21);
            this.btnAddName.TabIndex = 2;
            this.btnAddName.Text = "Add name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // lblPositionInput
            // 
            this.lblPositionInput.AutoSize = true;
            this.lblPositionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionInput.Location = new System.Drawing.Point(54, 116);
            this.lblPositionInput.Name = "lblPositionInput";
            this.lblPositionInput.Size = new System.Drawing.Size(104, 15);
            this.lblPositionInput.TabIndex = 3;
            this.lblPositionInput.Text = "Position to delete:";
            this.lblPositionInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxPositionInput
            // 
            this.txtBoxPositionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPositionInput.Location = new System.Drawing.Point(57, 139);
            this.txtBoxPositionInput.Name = "txtBoxPositionInput";
            this.txtBoxPositionInput.Size = new System.Drawing.Size(175, 20);
            this.txtBoxPositionInput.TabIndex = 4;
            this.txtBoxPositionInput.Text = "Enter position number";
            this.txtBoxPositionInput.TextChanged += new System.EventHandler(this.txtBoxPositionInput_TextChanged);
            this.txtBoxPositionInput.MouseLeave += new System.EventHandler(this.txtBoxPositionInput_MouseLeave);
            this.txtBoxPositionInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBoxPositionInput_MouseMove);
            // 
            // btnDeletePos
            // 
            this.btnDeletePos.Enabled = false;
            this.btnDeletePos.Location = new System.Drawing.Point(57, 165);
            this.btnDeletePos.Name = "btnDeletePos";
            this.btnDeletePos.Size = new System.Drawing.Size(85, 21);
            this.btnDeletePos.TabIndex = 5;
            this.btnDeletePos.Text = "Delete pos";
            this.btnDeletePos.UseVisualStyleBackColor = true;
            this.btnDeletePos.Click += new System.EventHandler(this.btnDeletePos_Click);
            // 
            // listBoxNamesArr
            // 
            this.listBoxNamesArr.FormattingEnabled = true;
            this.listBoxNamesArr.Location = new System.Drawing.Point(300, 69);
            this.listBoxNamesArr.Name = "listBoxNamesArr";
            this.listBoxNamesArr.Size = new System.Drawing.Size(218, 251);
            this.listBoxNamesArr.TabIndex = 6;
            // 
            // lblListBoxArray
            // 
            this.lblListBoxArray.AutoSize = true;
            this.lblListBoxArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListBoxArray.Location = new System.Drawing.Point(297, 50);
            this.lblListBoxArray.Name = "lblListBoxArray";
            this.lblListBoxArray.Size = new System.Drawing.Size(58, 16);
            this.lblListBoxArray.TabIndex = 10;
            this.lblListBoxArray.Text = "Array list";
            // 
            // btnDeleteFromArray
            // 
            this.btnDeleteFromArray.Location = new System.Drawing.Point(303, 330);
            this.btnDeleteFromArray.Name = "btnDeleteFromArray";
            this.btnDeleteFromArray.Size = new System.Drawing.Size(109, 20);
            this.btnDeleteFromArray.TabIndex = 11;
            this.btnDeleteFromArray.Text = "Delete selected";
            this.btnDeleteFromArray.UseVisualStyleBackColor = true;
            this.btnDeleteFromArray.Click += new System.EventHandler(this.btnDeleteFromArray_Click);
            // 
            // listBoxNamesList
            // 
            this.listBoxNamesList.FormattingEnabled = true;
            this.listBoxNamesList.Location = new System.Drawing.Point(554, 68);
            this.listBoxNamesList.Name = "listBoxNamesList";
            this.listBoxNamesList.Size = new System.Drawing.Size(219, 251);
            this.listBoxNamesList.TabIndex = 12;
            // 
            // btnDeleteFromList
            // 
            this.btnDeleteFromList.Location = new System.Drawing.Point(554, 330);
            this.btnDeleteFromList.Name = "btnDeleteFromList";
            this.btnDeleteFromList.Size = new System.Drawing.Size(113, 20);
            this.btnDeleteFromList.TabIndex = 13;
            this.btnDeleteFromList.Text = "Delete selected";
            this.btnDeleteFromList.UseVisualStyleBackColor = true;
            this.btnDeleteFromList.Click += new System.EventHandler(this.btnDeleteFromList_Click);
            // 
            // btnSortOption
            // 
            this.btnSortOption.Location = new System.Drawing.Point(554, 356);
            this.btnSortOption.Name = "btnSortOption";
            this.btnSortOption.Size = new System.Drawing.Size(113, 22);
            this.btnSortOption.TabIndex = 14;
            this.btnSortOption.Text = "Sort descending";
            this.btnSortOption.UseVisualStyleBackColor = true;
            this.btnSortOption.Click += new System.EventHandler(this.btnSortOption_Click);
            // 
            // lblToolTip
            // 
            this.lblToolTip.AutoSize = true;
            this.lblToolTip.BackColor = System.Drawing.SystemColors.Info;
            this.lblToolTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToolTip.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblToolTip.Location = new System.Drawing.Point(94, 227);
            this.lblToolTip.Name = "lblToolTip";
            this.lblToolTip.Size = new System.Drawing.Size(48, 15);
            this.lblToolTip.TabIndex = 15;
            this.lblToolTip.Text = "Hint text";
            this.lblToolTip.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToolTip);
            this.Controls.Add(this.btnSortOption);
            this.Controls.Add(this.btnDeleteFromList);
            this.Controls.Add(this.listBoxNamesList);
            this.Controls.Add(this.btnDeleteFromArray);
            this.Controls.Add(this.lblListBoxArray);
            this.Controls.Add(this.listBoxNamesArr);
            this.Controls.Add(this.btnDeletePos);
            this.Controls.Add(this.txtBoxPositionInput);
            this.Controls.Add(this.lblPositionInput);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.lblNameInput);
            this.Controls.Add(this.txtBoxNameInput);
            this.Name = "Form1";
            this.Text = "Names List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxNameInput;
        private System.Windows.Forms.Label lblNameInput;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Label lblPositionInput;
        private System.Windows.Forms.TextBox txtBoxPositionInput;
        private System.Windows.Forms.Button btnDeletePos;
        private System.Windows.Forms.ListBox listBoxNamesArr;
        private System.Windows.Forms.Label lblListBoxArray;
        private System.Windows.Forms.Button btnDeleteFromArray;
        private System.Windows.Forms.ListBox listBoxNamesList;
        private System.Windows.Forms.Button btnDeleteFromList;
        private System.Windows.Forms.Button btnSortOption;
        private System.Windows.Forms.Label lblToolTip;
    }
}

