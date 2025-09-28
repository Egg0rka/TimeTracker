namespace TimeTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEmployeeName = new Label();
            txtEmployeeName = new TextBox();
            lblEmployeePosition = new Label();
            txtEmployeePosition = new TextBox();
            btnAddEmployee = new Button();
            btnClockIn = new Button();
            btnClockOut = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(54, 33);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(100, 15);
            lblEmployeeName.TabIndex = 0;
            lblEmployeeName.Text = "ФИО сотрудника";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(54, 51);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(135, 23);
            txtEmployeeName.TabIndex = 1;
            // 
            // lblEmployeePosition
            // 
            lblEmployeePosition.AutoSize = true;
            lblEmployeePosition.Location = new Point(195, 33);
            lblEmployeePosition.Name = "lblEmployeePosition";
            lblEmployeePosition.Size = new Size(69, 15);
            lblEmployeePosition.TabIndex = 2;
            lblEmployeePosition.Text = "Должность";
            // 
            // txtEmployeePosition
            // 
            txtEmployeePosition.Location = new Point(195, 51);
            txtEmployeePosition.Name = "txtEmployeePosition";
            txtEmployeePosition.Size = new Size(135, 23);
            txtEmployeePosition.TabIndex = 3;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(54, 98);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(135, 23);
            btnAddEmployee.TabIndex = 4;
            btnAddEmployee.Text = "Добавить сотрудника";
            btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // btnClockIn
            // 
            btnClockIn.Location = new Point(54, 127);
            btnClockIn.Name = "btnClockIn";
            btnClockIn.Size = new Size(135, 23);
            btnClockIn.TabIndex = 5;
            btnClockIn.Text = "Отметить приход";
            btnClockIn.UseVisualStyleBackColor = true;
            // 
            // btnClockOut
            // 
            btnClockOut.Location = new Point(54, 156);
            btnClockOut.Name = "btnClockOut";
            btnClockOut.Size = new Size(135, 23);
            btnClockOut.TabIndex = 6;
            btnClockOut.Text = "Отметить уход";
            btnClockOut.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 300);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 150);
            dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnClockOut);
            Controls.Add(btnClockIn);
            Controls.Add(btnAddEmployee);
            Controls.Add(txtEmployeePosition);
            Controls.Add(lblEmployeePosition);
            Controls.Add(txtEmployeeName);
            Controls.Add(lblEmployeeName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmployeeName;
        private TextBox txtEmployeeName;
        private Label lblEmployeePosition;
        private TextBox txtEmployeePosition;
        private Button btnAddEmployee;
        private Button btnClockIn;
        private Button btnClockOut;
        private DataGridView dataGridView1;
    }
}
