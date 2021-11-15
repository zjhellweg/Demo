
namespace HellwegActivity11
{
    partial class EmployeeForm
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
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.EmployeeNameBox = new System.Windows.Forms.TextBox();
            this.EmployeeNumberBox = new System.Windows.Forms.TextBox();
            this.ShiftBox = new System.Windows.Forms.ComboBox();
            this.EmployeePayBox = new System.Windows.Forms.TextBox();
            this.EmployeesBox = new System.Windows.Forms.ListBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EmpNumLabel = new System.Windows.Forms.Label();
            this.ShiftLabel = new System.Windows.Forms.Label();
            this.PayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 142);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add Employee";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(136, 142);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(113, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // EmployeeNameBox
            // 
            this.EmployeeNameBox.Location = new System.Drawing.Point(157, 12);
            this.EmployeeNameBox.Name = "EmployeeNameBox";
            this.EmployeeNameBox.Size = new System.Drawing.Size(92, 20);
            this.EmployeeNameBox.TabIndex = 3;
            // 
            // EmployeeNumberBox
            // 
            this.EmployeeNumberBox.Location = new System.Drawing.Point(157, 38);
            this.EmployeeNumberBox.Name = "EmployeeNumberBox";
            this.EmployeeNumberBox.Size = new System.Drawing.Size(92, 20);
            this.EmployeeNumberBox.TabIndex = 4;
            // 
            // ShiftBox
            // 
            this.ShiftBox.FormattingEnabled = true;
            this.ShiftBox.Items.AddRange(new object[] {
            "Day Shift",
            "Night Shift"});
            this.ShiftBox.Location = new System.Drawing.Point(157, 64);
            this.ShiftBox.Name = "ShiftBox";
            this.ShiftBox.Size = new System.Drawing.Size(92, 21);
            this.ShiftBox.TabIndex = 5;
            // 
            // EmployeePayBox
            // 
            this.EmployeePayBox.Location = new System.Drawing.Point(157, 91);
            this.EmployeePayBox.Name = "EmployeePayBox";
            this.EmployeePayBox.Size = new System.Drawing.Size(92, 20);
            this.EmployeePayBox.TabIndex = 6;
            this.EmployeePayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmployeePayBox_KeyPress);
            // 
            // EmployeesBox
            // 
            this.EmployeesBox.FormattingEnabled = true;
            this.EmployeesBox.Items.AddRange(new object[] {
            "All Added Employees"});
            this.EmployeesBox.Location = new System.Drawing.Point(255, 5);
            this.EmployeesBox.Name = "EmployeesBox";
            this.EmployeesBox.Size = new System.Drawing.Size(377, 160);
            this.EmployeesBox.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 15);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(84, 13);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Employee Name";
            // 
            // EmpNumLabel
            // 
            this.EmpNumLabel.AutoSize = true;
            this.EmpNumLabel.Location = new System.Drawing.Point(12, 41);
            this.EmpNumLabel.Name = "EmpNumLabel";
            this.EmpNumLabel.Size = new System.Drawing.Size(93, 13);
            this.EmpNumLabel.TabIndex = 9;
            this.EmpNumLabel.Text = "Employee Number";
            // 
            // ShiftLabel
            // 
            this.ShiftLabel.AutoSize = true;
            this.ShiftLabel.Location = new System.Drawing.Point(12, 67);
            this.ShiftLabel.Name = "ShiftLabel";
            this.ShiftLabel.Size = new System.Drawing.Size(77, 13);
            this.ShiftLabel.TabIndex = 10;
            this.ShiftLabel.Text = "Employee Shift";
            // 
            // PayLabel
            // 
            this.PayLabel.AutoSize = true;
            this.PayLabel.Location = new System.Drawing.Point(12, 94);
            this.PayLabel.Name = "PayLabel";
            this.PayLabel.Size = new System.Drawing.Size(74, 13);
            this.PayLabel.TabIndex = 11;
            this.PayLabel.Text = "Employee Pay";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 177);
            this.Controls.Add(this.PayLabel);
            this.Controls.Add(this.ShiftLabel);
            this.Controls.Add(this.EmpNumLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EmployeesBox);
            this.Controls.Add(this.EmployeePayBox);
            this.Controls.Add(this.ShiftBox);
            this.Controls.Add(this.EmployeeNumberBox);
            this.Controls.Add(this.EmployeeNameBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddButton);
            this.Name = "EmployeeForm";
            this.Text = "Employee Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox EmployeeNameBox;
        private System.Windows.Forms.TextBox EmployeeNumberBox;
        private System.Windows.Forms.ComboBox ShiftBox;
        private System.Windows.Forms.TextBox EmployeePayBox;
        private System.Windows.Forms.ListBox EmployeesBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label EmpNumLabel;
        private System.Windows.Forms.Label ShiftLabel;
        private System.Windows.Forms.Label PayLabel;
    }
}

