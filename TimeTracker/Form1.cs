namespace TimeTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {//���������� ����������
            string name = txtEmployeeName.Text;
            string position = txtEmployeePosition.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(position))
            {
                MessageBox.Show("������� ��� � ��������� ����������.");
                return;
            }
            dgvEmployeeList.Rows.Add(name, position, "", "");
            txtEmployeeName.Clear();
            txtEmployeePosition.Clear();
        }
        private void btnClockIn_Click(object sender, EventArgs e)
        {//������� �������
            if (dgvEmployeeList.SelectedRows.Count > 0)
            {
                var row = dgvEmployeeList.SelectedRows[0];
                row.Cells[2].Value = DateTime.Now.ToString("HH:mm");
            }
            else
            {
                MessageBox.Show("������� �������� ���������� (�������� �� ������).");
            }
        }
        private void btnClockOut_Click(object sender, EventArgs e)
        {//������� �����
            if (dgvEmployeeList.SelectedRows.Count > 0)
            {
                var row = dgvEmployeeList.SelectedRows[0];
                row.Cells[3].Value = DateTime.Now.ToString("HH:mm");
            }
            else
            {
                MessageBox.Show("������� �������� ���������� (�������� �� ������).");
            }
        }
    }
}
