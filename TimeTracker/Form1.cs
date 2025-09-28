namespace TimeTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        { //это отвечает за кнопку добавления сотрудника
            string name = txtEmployeeName.Text;
            string position = txtEmployeePosition.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(position))
            {
                MessageBox.Show("Введите ФИО и должность сотрудника.");
                return;
            }
            dgvEmployeeList.Rows.Add(name, position, "", "");
            txtEmployeeName.Clear();
            txtEmployeePosition.Clear();
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        { //это отвечаает за кнопку отметить приход
            if (dgvEmployeeList.SelectedRows.Count > 0)
            {
                var row = dgvEmployeeList.SelectedRows[0];
                row.Cells["ColumnClockIn"].Value = DateTime.Now.ToString("HH:mm");
            }
            else
            {
                MessageBox.Show("Выберите сотрудника из списка.");
            }
        }
        private void btnClockOut_Click(object sender, EventArgs e)
        { // это отвесает за кнопку отметить уход
            if (dgvEmployeeList.SelectedRows.Count > 0)
            {
                var row = dgvEmployeeList.SelectedRows[0];
                row.Cells["ColumnClockOut"].Value = DateTime.Now.ToString("HH:mm");
            }
            else
            {
                MessageBox.Show("Выберите сотрудника.");
            }
        }
    }
}
