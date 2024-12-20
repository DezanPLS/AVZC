using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PrPrZzz.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrPrZzz
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext _context;

        public Form1()
        {
            InitializeComponent();
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseNpgsql("User Id=postgres.azfpxmllywzanltckntr;Password=2005Danil_2005;Server=aws-0-eu-central-1.pooler.supabase.com;Port=5432;Database=postgres;");
            _context = new ApplicationDbContext(optionsBuilder.Options);
            _context.InitializeDatabase();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeTabControl();
            LoadMaterials();
            LoadEmployees();
            LoadProducts();
            LoadProcesses();
        }
        private void InitializeTabControl()
        {
            for (int i = 1; i < tabControl1.TabPages.Count; i++)
            {
                tabControl1.TabPages[i].Enabled = true;
            }
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string enteredLogin = textBox7.Text;
            string enteredPassword = textBox8.Text;

            if (enteredLogin == "Admin" && enteredPassword == "12345")
            {
                MessageBox.Show("Вход выполнен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeTabControl();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }     
        private void ShowErrorMessage(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void LoadMaterials()
        {
            try
            {
                var materials = _context.Materials.ToList();
                dataGridView1.DataSource = materials;

                comboBoxM.Items.Clear();
                foreach (var item in materials)
                {
                    comboBoxM.Items.Add($"{item.Id}-{item.Name}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке материалов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DltBtnM_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                long materialId = (long)dataGridView1.SelectedRows[0].Cells[0].Value;
                var materialToRemove = _context.Materials.Find(materialId);
                if (materialToRemove != null)
                {
                    _context.Materials.Remove(materialToRemove);
                    _context.SaveChanges();
                    LoadMaterials(); // Обновляем список материалов после удаления
                }
            }
        }
        private void AddBtnM_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(name))
            {
                try
                {
                    var newMaterial = new Material { Name = name };
                    _context.Materials.Add(newMaterial);
                    _context.SaveChanges();
                    LoadMaterials();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении материала: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Название материала не может быть пустым.");
            }
        }
        private void WatchBtnM_Click(object sender, EventArgs e)
        {
            LoadMaterials();
        }


        
            private void LoadEmployees()
            {
                try
                {
                    var employees = _context.Employees.Select(e => new { e.Id, e.FirstName, e.LastName }).ToList();
                    dataGridView2.DataSource = employees;

                    comboBoxE.Items.Clear();
                    foreach (var emp in employees)
                    {
                        comboBoxE.Items.Add($"{emp.Id} - {emp.FirstName} {emp.LastName}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке сотрудников: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        private void AddBtnE_Click(object sender, EventArgs e)
        {
            string firstName = textBox2.Text;
            string lastName = textBox3.Text;
            if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
            {
                try
                {
                    var newEmployee = new Employee {FirstName = firstName,LastName = lastName};
                    _context.Employees.Add(newEmployee);
                    _context.SaveChanges();
                    LoadEmployees();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Имя и фамилия сотрудника не могут быть пустыми.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DltBtnE_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                try
                {
                    // Получение ID сотрудника из выбранной строки
                    long employeeId = (long)dataGridView2.SelectedRows[0].Cells[0].Value;

                    // Поиск сотрудника по ID
                    var employeeToRemove = _context.Employees.Find(employeeId);

                    if (employeeToRemove != null)
                    {
                        // Удаление сотрудника из базы данных
                        _context.Employees.Remove(employeeToRemove);
                        _context.SaveChanges();

                        // Обновление списка сотрудников
                        LoadEmployees();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении сотрудника: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void WatchBtnE_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }


        private void LoadProducts()
        {
            try
            {
                var products = _context.Products.ToList();
                dataGridView3.DataSource = products;

                comboBoxD.Items.Clear();
                foreach (var item in products)
                {
                    comboBoxD.Items.Add($"{item.Id}-{item.Name}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке продуктов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddBtnD_Click(object sender, EventArgs e)
        {
            string productName = textBox4.Text;
            if (!string.IsNullOrWhiteSpace(productName))
            {
                try
                {
                    var newProduct = new Product { Name = productName };
                    _context.Products.Add(newProduct);
                    _context.SaveChanges();
                    LoadProducts();
                    textBox4.Clear();

                    MessageBox.Show("Продукт добавлен успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении продукта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Название продукта не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DltBtnD_Click(object sender, EventArgs e)
        {

            if (dataGridView3.SelectedRows.Count > 0)
            {
                // Используем long вместо int
                long productId = (long)dataGridView3.SelectedRows[0].Cells[0].Value;

                try
                {
                    var productToRemove = _context.Products.Find(productId);
                    if (productToRemove != null)
                    {
                        _context.Products.Remove(productToRemove);
                        _context.SaveChanges();
                        LoadProducts();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении продукта: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void WatchBtnD_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }


        private void LoadProcesses()
        {
            try
            {
                var processes = _context.Processes
                    .Include(p => p.Material)
                    .Include(p => p.Employee)
                    .Include(p => p.Product)
                    .Select(p => new
                    {
                        p.Id,
                        p.Name,
                        MaterialName = p.Material.Name,
                        EmployeeName = p.Employee.FirstName + " " + p.Employee.LastName,
                        ProductName = p.Product.Name,
                        p.Time
                    })
                    .ToList();

                dataGridView4.DataSource = processes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке процессов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DltBtnP_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                // Преобразование в long, так как Id, скорее всего, является long
                long processId = Convert.ToInt64(dataGridView4.SelectedRows[0].Cells[0].Value);

                try
                {
                    var processToRemove = _context.Processes.Find(processId);
                    if (processToRemove != null)
                    {
                        _context.Processes.Remove(processToRemove);
                        _context.SaveChanges();
                        LoadProcesses();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении процесса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void WatchBtnP_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }
        private void CrtBtnP_Click(object sender, EventArgs e)
        {
            try
            {
                string processName = textBox5.Text;
                if (comboBoxM.SelectedItem == null || comboBoxE.SelectedItem == null||comboBoxD.SelectedItem == null)
                {
                    MessageBox.Show("Ошибка: Убедитесь, что все поля выбраны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string materialId = comboBoxM.SelectedItem.ToString().Split('-')[0];
                string employeeId = comboBoxE.SelectedItem.ToString().Split('-')[0];
                string productId = comboBoxD.SelectedItem.ToString().Split('-')[0];
                string time = textBoxTime.Text;

                var process = new Process
                {
                    Name = processName,
                    MaterialId = int.Parse(materialId),
                    EmployeeId = int.Parse(employeeId),
                    ProductId = int.Parse(productId),
                    Time = time
                };

                _context.Processes.Add(process);
                _context.SaveChanges();
                LoadProcesses();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Ошибка: Возможно, некоторые поля не были заполнены или выбраны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании процесса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

