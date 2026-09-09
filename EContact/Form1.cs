using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EContact
{
    public partial class Form1 : Form
    {
        
        string connectionString = @"Data Source=DESKTOP-LH3UBGG;Initial Catalog=ContactDB;Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }

        
        private void LoadContacts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Contacts";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvContacts.DataSource = dt;

                    
                    if (dgvContacts.Columns.Count > 0)
                    {
                        dgvContacts.Columns["ContactID"].HeaderText = "ID";
                        dgvContacts.Columns["FirstName"].HeaderText = "Имя";
                        dgvContacts.Columns["LastName"].HeaderText = "Фамилия";
                        dgvContacts.Columns["ContactNo"].HeaderText = "Телефон";
                        dgvContacts.Columns["Address"].HeaderText = "Адрес";
                        dgvContacts.Columns["Gender"].HeaderText = "Пол";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля (Имя, Фамилия, Телефон).",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Contacts (FirstName, LastName, ContactNo, Address, Gender)
                                     VALUES (@FirstName, @LastName, @ContactNo, @Address, @Gender)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem?.ToString() ?? "");

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Контакт успешно добавлен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                    LoadContacts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при добавлении: " + ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContactID.Text))
            {
                MessageBox.Show("Выберите контакт для обновления из таблицы.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int contactId;
            if (!int.TryParse(txtContactID.Text, out contactId))
            {
                MessageBox.Show("Некорректный ID контакта.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE Contacts SET 
                                     FirstName = @FirstName,
                                     LastName = @LastName,
                                     ContactNo = @ContactNo,
                                     Address = @Address,
                                     Gender = @Gender
                                     WHERE ContactID = @ContactID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.SelectedItem?.ToString() ?? "");
                    cmd.Parameters.AddWithValue("@ContactID", contactId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Контакт успешно обновлён!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadContacts();
                    }
                    else
                    {
                        MessageBox.Show("Контакт не найден.", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обновлении: " + ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContactID.Text))
            {
                MessageBox.Show("Выберите контакт для удаления из таблицы.",
                    "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int contactId;
            if (!int.TryParse(txtContactID.Text, out contactId))
            {
                MessageBox.Show("Некорректный ID контакта.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Вы действительно хотите удалить этот контакт?",
                "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Contacts WHERE ContactID = @ContactID";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ContactID", contactId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Контакт успешно удалён!", "Успех",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            LoadContacts();
                        }
                        else
                        {
                            MessageBox.Show("Контакт не найден.", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при удалении: " + ex.Message, "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        
        private void ClearFields()
        {
            txtContactID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtContactNo.Clear();
            txtAddress.Clear();
            cmbGender.SelectedIndex = -1;
            txtSearch.Clear();
        }

        private void dgvContacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvContacts.Rows[e.RowIndex];
                txtContactID.Text = row.Cells["ContactID"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtContactNo.Text = row.Cells["ContactNo"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                cmbGender.SelectedItem = row.Cells["Gender"].Value.ToString();
            }
        }

        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadContacts();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT * FROM Contacts 
                                     WHERE FirstName LIKE @search 
                                     OR LastName LIKE @search 
                                     OR ContactNo LIKE @search 
                                     OR Address LIKE @search";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvContacts.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при поиске: " + ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}