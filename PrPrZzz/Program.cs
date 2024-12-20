using Microsoft.EntityFrameworkCore;
using PrPrZzz;
using PrPrZzz.Data;

namespace PrPrZzz
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {// ��������� ���� ������
            using (var context = new ApplicationDbContext(new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseNpgsql("Host=aws-0-eu-central-1.pooler.supabase.com;Port=5432;Database=postgres;Username=postgres.azfpxmllywzanltckntr;Password=2005Danil_2005;")
                .Options))
            {
                try
                {
                    context.Database.Migrate();
                    MessageBox.Show("���� ������ ������� ����������������.", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"������ ��� ������������� ���� ������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }
    }
}