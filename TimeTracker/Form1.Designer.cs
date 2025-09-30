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
            dgvEmployeeList = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnPosition = new DataGridViewTextBoxColumn();
            ColumnCheckIn = new DataGridViewTextBoxColumn();
            ColumnCheckOut = new DataGridViewTextBoxColumn();
            btnEditEmployee = new Button();
            btnDeleteEmployee = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).BeginInit();
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
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnClockIn
            // 
            btnClockIn.Location = new Point(54, 127);
            btnClockIn.Name = "btnClockIn";
            btnClockIn.Size = new Size(135, 23);
            btnClockIn.TabIndex = 5;
            btnClockIn.Text = "Отметить приход";
            btnClockIn.UseVisualStyleBackColor = true;
            btnClockIn.Click += btnClockIn_Click;
            // 
            // btnClockOut
            // 
            btnClockOut.Location = new Point(54, 156);
            btnClockOut.Name = "btnClockOut";
            btnClockOut.Size = new Size(135, 23);
            btnClockOut.TabIndex = 6;
            btnClockOut.Text = "Отметить уход";
            btnClockOut.UseVisualStyleBackColor = true;
            btnClockOut.Click += btnClockOut_Click;
            // 
            // dgvEmployeeList
            // 
            dgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeList.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnName, ColumnPosition, ColumnCheckIn, ColumnCheckOut });
            dgvEmployeeList.Dock = DockStyle.Bottom;
            dgvEmployeeList.Location = new Point(0, 300);
            dgvEmployeeList.Name = "dgvEmployeeList";
            dgvEmployeeList.Size = new Size(800, 150);
            dgvEmployeeList.TabIndex = 7;
            dgvEmployeeList.CellContentClick += dgvEmployeeList_CellContentClick;
            // 
            // ColumnId
            // 
            ColumnId.HeaderText = "ID";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            ColumnId.Visible = false;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "ФИО";
            ColumnName.Name = "ColumnName";
            // 
            // ColumnPosition
            // 
            ColumnPosition.HeaderText = "Должность";
            ColumnPosition.Name = "ColumnPosition";
            // 
            // ColumnCheckIn
            // 
            ColumnCheckIn.HeaderText = "Приход";
            ColumnCheckIn.Name = "ColumnCheckIn";
            // 
            // ColumnCheckOut
            // 
            ColumnCheckOut.HeaderText = "Уход";
            ColumnCheckOut.Name = "ColumnCheckOut";
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Location = new Point(195, 98);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(162, 23);
            btnEditEmployee.TabIndex = 8;
            btnEditEmployee.Text = "Редактировать сотрудника";
            btnEditEmployee.UseVisualStyleBackColor = true;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(363, 98);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(127, 23);
            btnDeleteEmployee.TabIndex = 9;
            btnDeleteEmployee.Text = "Удалить сотрудника";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(dgvEmployeeList);
            Controls.Add(btnClockOut);
            Controls.Add(btnClockIn);
            Controls.Add(btnAddEmployee);
            Controls.Add(txtEmployeePosition);
            Controls.Add(lblEmployeePosition);
            Controls.Add(txtEmployeeName);
            Controls.Add(lblEmployeeName);
            Name = "Form1";
            Text = "TimeTracker";
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).EndInit();
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
        private DataGridView dgvEmployeeList;

        private void dgvEmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnPosition;
        private DataGridViewTextBoxColumn ColumnCheckIn;
        private DataGridViewTextBoxColumn ColumnCheckOut;
        private Button btnEditEmployee;
        private Button btnDeleteEmployee;
    }
}
