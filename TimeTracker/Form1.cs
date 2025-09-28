namespace TimeTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {//Добавление сотрудника
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
        {//Отметка прихода
            if (dgvEmployeeList.SelectedRows.Count > 0)
            {
                var row = dgvEmployeeList.SelectedRows[0];
                row.Cells[2].Value = DateTime.Now.ToString("HH:mm");
            }
            else
            {
                MessageBox.Show("Сначала выберите сотрудника (кликните по строке).");
            }
        }
        private void btnClockOut_Click(object sender, EventArgs e)
        {//Отметка ухода
            if (dgvEmployeeList.SelectedRows.Count > 0)
            {
                var row = dgvEmployeeList.SelectedRows[0];
                row.Cells[3].Value = DateTime.Now.ToString("HH:mm");
            }
            else
            {
                MessageBox.Show("Сначала выберите сотрудника (кликните по строке).");
            }
        }
    }
}
