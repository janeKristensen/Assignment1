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
            this.lblListViewArray = new System.Windows.Forms.Label();
            this.btnDeleteFromArray = new System.Windows.Forms.Button();
            this.btnDeleteFromDict = new System.Windows.Forms.Button();
            this.btnSortOption = new System.Windows.Forms.Button();
            this.lblToolTip = new System.Windows.Forms.Label();
            this.lblListViewDict = new System.Windows.Forms.Label();
            this.listViewArray = new System.Windows.Forms.ListView();
            this.listViewDict = new System.Windows.Forms.ListView();
            this.lblErrorNameInput = new System.Windows.Forms.Label();
            this.lblErrorPosInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxNameInput
            // 
            this.txtBoxNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNameInput.Location = new System.Drawing.Point(15, 51);
            this.txtBoxNameInput.Name = "txtBoxNameInput";
            this.txtBoxNameInput.Size = new System.Drawing.Size(149, 20);
            this.txtBoxNameInput.TabIndex = 0;
            this.txtBoxNameInput.Text = "Enter name";
            this.txtBoxNameInput.TextChanged += new System.EventHandler(this.txtBoxNameInput_TextChanged);
            this.txtBoxNameInput.MouseLeave += new System.EventHandler(this.txtBoxNameInput_MouseLeave);
            this.txtBoxNameInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBoxNameInput_MouseMove);
            // 
            // lblNameInput
            // 
            this.lblNameInput.AutoSize = true;
            this.lblNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameInput.Location = new System.Drawing.Point(12, 32);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.Size = new System.Drawing.Size(68, 15);
            this.lblNameInput.TabIndex = 1;
            this.lblNameInput.Text = "Dog breed:";
            this.lblNameInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddName
            // 
            this.btnAddName.Enabled = false;
            this.btnAddName.Location = new System.Drawing.Point(15, 90);
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
            this.lblPositionInput.Location = new System.Drawing.Point(14, 138);
            this.lblPositionInput.Name = "lblPositionInput";
            this.lblPositionInput.Size = new System.Drawing.Size(104, 15);
            this.lblPositionInput.TabIndex = 3;
            this.lblPositionInput.Text = "Position to delete:";
            this.lblPositionInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxPositionInput
            // 
            this.txtBoxPositionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPositionInput.Location = new System.Drawing.Point(17, 156);
            this.txtBoxPositionInput.Name = "txtBoxPositionInput";
            this.txtBoxPositionInput.Size = new System.Drawing.Size(85, 20);
            this.txtBoxPositionInput.TabIndex = 4;
            this.txtBoxPositionInput.Text = "Enter number";
            this.txtBoxPositionInput.TextChanged += new System.EventHandler(this.txtBoxPositionInput_TextChanged);
            this.txtBoxPositionInput.MouseLeave += new System.EventHandler(this.txtBoxPositionInput_MouseLeave);
            this.txtBoxPositionInput.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtBoxPositionInput_MouseMove);
            // 
            // btnDeletePos
            // 
            this.btnDeletePos.Enabled = false;
            this.btnDeletePos.Location = new System.Drawing.Point(17, 194);
            this.btnDeletePos.Name = "btnDeletePos";
            this.btnDeletePos.Size = new System.Drawing.Size(85, 21);
            this.btnDeletePos.TabIndex = 5;
            this.btnDeletePos.Text = "Delete pos";
            this.btnDeletePos.UseVisualStyleBackColor = true;
            this.btnDeletePos.Click += new System.EventHandler(this.btnDeletePos_Click);
            // 
            // lblListViewArray
            // 
            this.lblListViewArray.AutoSize = true;
            this.lblListViewArray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListViewArray.Location = new System.Drawing.Point(241, 51);
            this.lblListViewArray.Name = "lblListViewArray";
            this.lblListViewArray.Size = new System.Drawing.Size(39, 16);
            this.lblListViewArray.TabIndex = 10;
            this.lblListViewArray.Text = "Array";
            // 
            // btnDeleteFromArray
            // 
            this.btnDeleteFromArray.Location = new System.Drawing.Point(244, 330);
            this.btnDeleteFromArray.Name = "btnDeleteFromArray";
            this.btnDeleteFromArray.Size = new System.Drawing.Size(109, 20);
            this.btnDeleteFromArray.TabIndex = 11;
            this.btnDeleteFromArray.Text = "Delete selected";
            this.btnDeleteFromArray.UseVisualStyleBackColor = true;
            this.btnDeleteFromArray.Click += new System.EventHandler(this.btnDeleteFromArray_Click);
            // 
            // btnDeleteFromDict
            // 
            this.btnDeleteFromDict.Location = new System.Drawing.Point(507, 330);
            this.btnDeleteFromDict.Name = "btnDeleteFromDict";
            this.btnDeleteFromDict.Size = new System.Drawing.Size(113, 20);
            this.btnDeleteFromDict.TabIndex = 13;
            this.btnDeleteFromDict.Text = "Delete selected";
            this.btnDeleteFromDict.UseVisualStyleBackColor = true;
            this.btnDeleteFromDict.Click += new System.EventHandler(this.btnDeleteFromDict_Click);
            // 
            // btnSortOption
            // 
            this.btnSortOption.Location = new System.Drawing.Point(17, 252);
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
            this.lblToolTip.Location = new System.Drawing.Point(38, 330);
            this.lblToolTip.Name = "lblToolTip";
            this.lblToolTip.Size = new System.Drawing.Size(64, 15);
            this.lblToolTip.TabIndex = 15;
            this.lblToolTip.Text = "Tool tip text";
            this.lblToolTip.Visible = false;
            // 
            // lblListViewDict
            // 
            this.lblListViewDict.AutoSize = true;
            this.lblListViewDict.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListViewDict.Location = new System.Drawing.Point(504, 51);
            this.lblListViewDict.Name = "lblListViewDict";
            this.lblListViewDict.Size = new System.Drawing.Size(67, 16);
            this.lblListViewDict.TabIndex = 16;
            this.lblListViewDict.Text = "Dictionary";
            // 
            // listViewArray
            // 
            this.listViewArray.HideSelection = false;
            this.listViewArray.Location = new System.Drawing.Point(244, 69);
            this.listViewArray.MultiSelect = false;
            this.listViewArray.Name = "listViewArray";
            this.listViewArray.Size = new System.Drawing.Size(203, 250);
            this.listViewArray.TabIndex = 17;
            this.listViewArray.UseCompatibleStateImageBehavior = false;
            // 
            // listViewDict
            // 
            this.listViewDict.HideSelection = false;
            this.listViewDict.Location = new System.Drawing.Point(507, 69);
            this.listViewDict.MultiSelect = false;
            this.listViewDict.Name = "listViewDict";
            this.listViewDict.Size = new System.Drawing.Size(255, 250);
            this.listViewDict.TabIndex = 18;
            this.listViewDict.UseCompatibleStateImageBehavior = false;
            // 
            // lblErrorNameInput
            // 
            this.lblErrorNameInput.AutoSize = true;
            this.lblErrorNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNameInput.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNameInput.Location = new System.Drawing.Point(14, 74);
            this.lblErrorNameInput.Margin = new System.Windows.Forms.Padding(0);
            this.lblErrorNameInput.Name = "lblErrorNameInput";
            this.lblErrorNameInput.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblErrorNameInput.Size = new System.Drawing.Size(63, 12);
            this.lblErrorNameInput.TabIndex = 19;
            this.lblErrorNameInput.Text = "Invalid input. ";
            this.lblErrorNameInput.Visible = false;
            // 
            // lblErrorPosInput
            // 
            this.lblErrorPosInput.AutoSize = true;
            this.lblErrorPosInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPosInput.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPosInput.Location = new System.Drawing.Point(17, 179);
            this.lblErrorPosInput.Margin = new System.Windows.Forms.Padding(0);
            this.lblErrorPosInput.Name = "lblErrorPosInput";
            this.lblErrorPosInput.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblErrorPosInput.Size = new System.Drawing.Size(196, 12);
            this.lblErrorPosInput.TabIndex = 20;
            this.lblErrorPosInput.Text = "Invalid input. Choose a number in range of list.";
            this.lblErrorPosInput.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.lblErrorPosInput);
            this.Controls.Add(this.lblErrorNameInput);
            this.Controls.Add(this.lblListViewDict);
            this.Controls.Add(this.lblToolTip);
            this.Controls.Add(this.btnSortOption);
            this.Controls.Add(this.btnDeleteFromDict);
            this.Controls.Add(this.btnDeleteFromArray);
            this.Controls.Add(this.lblListViewArray);
            this.Controls.Add(this.btnDeletePos);
            this.Controls.Add(this.txtBoxPositionInput);
            this.Controls.Add(this.lblPositionInput);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.lblNameInput);
            this.Controls.Add(this.txtBoxNameInput);
            this.Controls.Add(this.listViewArray);
            this.Controls.Add(this.listViewDict);
            this.Name = "Form1";
            this.Text = "Dog breed viewer";
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
        private System.Windows.Forms.Label lblListViewArray;
        private System.Windows.Forms.Button btnDeleteFromArray;
        private System.Windows.Forms.Button btnDeleteFromDict;
        private System.Windows.Forms.Button btnSortOption;
        private System.Windows.Forms.Label lblToolTip;
        private System.Windows.Forms.Label lblListViewDict;
        private System.Windows.Forms.ListView listViewArray;
        private System.Windows.Forms.ListView listViewDict;
        private System.Windows.Forms.Label lblErrorNameInput;
        private System.Windows.Forms.Label lblErrorPosInput;
    }
}

