using Microsoft.EntityFrameworkCore;
using PrPrZzz.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PrPrZzz
{
    public partial class RepairAVZ : Form
    {
        public RepairAVZ()
        {
            InitializeComponent();
        }
        private void UnlockTabs()
        {
            for (int i = 1; i < tabControl1.TabPages.Count; i++)
            {
                tabControl1.TabPages[i].Enabled = true;
            }
        }
        private void InitializeTabControl()
        {
            for (int i = 1; i < tabControl1.TabPages.Count; i++)
            {
                tabControl1.TabPages[i].Enabled = false;
            }
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string enteredLogin = textBox7.Text;
            string enteredPassword = textBox8.Text;

            if (enteredLogin == "Admin" && enteredPassword == "12345")
            {
                MessageBox.Show("Вход выполнен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UnlockTabs();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //private void LoadRequests()
        //{
        //    try
        //    {
        //        // Загрузка списка заявок на ремонт
        //        var requests = _context.RepairRequests
        //                               .Select(r => new
        //                               {
        //                                   r.Id,
        //                                   r.DeviceName,
        //                                   r.WorkType,
        //                                   r.CompletionTime
        //                               })
        //                               .ToList();

        //        // Привязка данных к DataGridView
        //        dataGridView4.DataSource = requests;

        //        // Обновление элементов ComboBox, если необходимо
        //        comboBoxR.Items.Clear();
        //        foreach (var item in requests)
        //        {
        //            comboBoxR.Items.Add($"{item.Id} - {item.DeviceName} ({item.WorkType})");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Ошибка при загрузке заявок на ремонт: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void AddButtonZ_Click(object sender, EventArgs e)
        //{
        //    string deviceName = textBoxDeviceName.Text;
        //    string workType = textBoxWorkType.Text;
        //    DateTime completionTime;

        //    // Проверяем, что все поля заполнены
        //    if (!string.IsNullOrWhiteSpace(deviceName) && !string.IsNullOrWhiteSpace(workType) && DateTime.TryParse(textBoxCompletionTime.Text, out completionTime))
        //    {
        //        try
        //        {
        //            // Создание нового объекта RepairRequest
        //            var newRequest = new RepairRequest
        //            {
        //                DeviceName = deviceName,
        //                WorkType = workType,
        //                CompletionTime = completionTime
        //            };

        //            // Добавление заявки в базу данных
        //            _context.RepairRequests.Add(newRequest);
        //            _context.SaveChanges();

        //            // Обновление списка заявок
        //            LoadRequests();

        //            // Очистка текстовых полей
        //            textBoxDeviceName.Clear();
        //            textBoxWorkType.Clear();
        //            textBoxCompletionTime.Clear();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Ошибка при добавлении заявки на ремонт: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ошибка: Все поля должны быть заполнены корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
        //private void DltButtonZ_Click(object sender, EventArgs e)
        //{
        //    private void DltBtnR_Click(object sender, EventArgs e)
        //    {
        //        if (dataGridView4.SelectedRows.Count > 0)
        //        {
        //            try
        //            {
        //                // Получение ID заявки из выбранной строки
        //                long requestId = (long)dataGridView4.SelectedRows[0].Cells[0].Value;

        //                // Поиск заявки по ID
        //                var requestToRemove = _context.RepairRequests.Find(requestId);

        //                if (requestToRemove != null)
        //                {
        //                    // Удаление заявки из базы данных
        //                    _context.RepairRequests.Remove(requestToRemove);
        //                    _context.SaveChanges();

        //                    // Обновление списка заявок
        //                    LoadRequests();
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"Ошибка при удалении заявки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Пожалуйста, выберите заявку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }

        //}
        //private void WtchBtnZ_Click(object sender, EventArgs e)
        //{
        //    LoadRequests();
        //}



        private void WtchBtn_Click(object sender, EventArgs e)
        {

        }
        private void SendBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
