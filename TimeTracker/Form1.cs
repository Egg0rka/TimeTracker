using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class Form1 : Form
    {
        // Путь к базе данных
        private string connectionString = @"Data Source=C:\SQLiteStudio\timetracker\timetracker.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
            LoadEmployees();   // Загружаем сотрудников при старте формы
            LoadAttendance();  // Загружаем отметки прихода/ухода
        }

        // Загрузка сотрудников в DataGridView
        private void LoadEmployees()
        {
            dgvEmployeeList.Rows.Clear();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Employees";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int employeeId = Convert.ToInt32(reader["id"]);
                        string name = reader["FullName"].ToString();
                        string position = reader["Position"].ToString();

                        int rowIndex = dgvEmployeeList.Rows.Add();
                        var row = dgvEmployeeList.Rows[rowIndex];
                        row.Cells["ColumnId"].Value = employeeId;
                        row.Cells["ColumnName"].Value = name;
                        row.Cells["ColumnPosition"].Value = position;
                        row.Cells["ColumnCheckIn"].Value = "";
                        row.Cells["ColumnCheckOut"].Value = "";
                    }
                }
            }
        }

        // Загрузка отметок прихода и ухода
        private void LoadAttendance()
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Attendance";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int employeeId = Convert.ToInt32(reader["EmployeeId"]);
                        foreach (DataGridViewRow row in dgvEmployeeList.Rows)
                        {
                            if (Convert.ToInt32(row.Cells["ColumnId"].Value) == employeeId)
                            {
                                if (reader["CheckIn"] != DBNull.Value)
                                    row.Cells["ColumnCheckIn"].Value = reader["CheckIn"];
                                if (reader["CheckOut"] != DBNull.Value)
                                    row.Cells["ColumnCheckOut"].Value = reader["CheckOut"];
                                break;
                            }
                        }
                    }
                }
            }
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

            int employeeId;

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Employees (FullName, Position) VALUES (@name, @position); SELECT last_insert_rowid();";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@position", position);
                    employeeId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            dgvEmployeeList.Rows.Add(employeeId, name, position, "", "");

            txtEmployeeName.Clear();
            txtEmployeePosition.Clear();
        }

        private void btnClockIn_Click(object sender, EventArgs e)
        {//Отметка прихода
            if (dgvEmployeeList.SelectedRows.Count > 0)
            {
                var row = dgvEmployeeList.SelectedRows[0];
                int employeeId = Convert.ToInt32(row.Cells["ColumnId"].Value);
                string time = DateTime.Now.ToString("HH:mm");

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "INSERT INTO Attendance (EmployeeId, CheckIn) VALUES (@id, @time)";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        cmd.Parameters.AddWithValue("@time", time);
                        cmd.ExecuteNonQuery();
                    }
                }

                row.Cells["ColumnCheckIn"].Value = time;
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
                int employeeId = Convert.ToInt32(row.Cells["ColumnId"].Value);
                string time = DateTime.Now.ToString("HH:mm");

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Attendance SET CheckOut = @time WHERE EmployeeId = @id AND CheckOut IS NULL";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@time", time);
                        cmd.Parameters.AddWithValue("@id", employeeId);
                        cmd.ExecuteNonQuery();
                    }
                }

                row.Cells["ColumnCheckOut"].Value = time;
            }
            else
            {
                MessageBox.Show("Сначала выберите сотрудника (кликните по строке).");
            }
        }
    }
}
