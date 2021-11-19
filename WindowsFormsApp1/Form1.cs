using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public class PhoneSearchResult
        {
            public double Diagonal { get; set; }
            public int Memory { get; set; }
            public int PhotoQuallity { get; set; }
            public int IsNeedNfc { get; set; }
            public int Battery { get; set; }
            public int MaxPrice { get; set; }
        }
        public class Phone
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public double ScreenSize { get; set; }
            public int MemorySize { get; set; }
            public bool Nfc { get; set; }
            public int BatterySize { get; set; }
            public int CameraMp { get; set; }
            public int Price { get; set; }
        }
        public class PhoneContext : DbContext //Вся необходимая логика наследуется из DbContext
        {
            public PhoneContext()
                : base("DBConnection") //При инстанцировании объекты этого класса будут получать connectionString с названием DBConnection из файла конфигурации
            { }

            public DbSet<Phone> Phones { get; set; } //Таблица Phones
        }
        PhoneSearchResult result = new PhoneSearchResult();
        List<Phone> phones = new List<Phone>();
        public Form1()
        {
            InitializeComponent();
            phones = GetPhones().ToList();
        }
        private void ScreenPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (rbScreen1.Checked)
            {
                result.Diagonal = 5;
                phones = phones.Where(phone => phone.ScreenSize <= result.Diagonal).ToList();

            }
            else if (rbScreen2.Checked)
            {
                result.Diagonal = 6.5;
                phones = phones.Where(phone => phone.ScreenSize > 5 && phone.ScreenSize < 6.5).ToList();
            }
            else if (rbScreen3.Checked)
            {
                result.Diagonal = 6.5;
                phones = phones.Where(phone => phone.ScreenSize > result.Diagonal).ToList();
            }
        }
        private void MemoryPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (rbMemory1.Checked)
            {
                result.Memory = 30;
                phones = phones.Where(phone => phone.MemorySize < result.Memory).ToList();
            }
            else if (rbMemory2.Checked)
            {
                result.Memory = 64;
                phones = phones.Where(phone => phone.MemorySize >= 30 && phone.MemorySize < 120).ToList();
            }
            else if (rbMemory3.Checked)
            {
                result.Memory = 120;
                phones = phones.Where(phone => phone.MemorySize >= result.Memory).ToList();
            }
        }
        private void CameraPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (rbCamera1.Checked)
            {
                result.PhotoQuallity = 10;
                phones = phones.Where(phone => phone.CameraMp <= result.PhotoQuallity).ToList();
            }
            else if (rbCamera2.Checked)
            {
                result.PhotoQuallity = 9;
                phones = phones.Where(phone => phone.CameraMp > 10 && phone.CameraMp < 30).ToList();
            }
            else if (rbCamera3.Checked)
            {
                result.PhotoQuallity = 30;
                phones = phones.Where(phone => phone.CameraMp > result.PhotoQuallity).ToList();
            }
        }
        private void NfcPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (rbNfc1.Checked)
            {
                result.IsNeedNfc = 0;
                phones = phones.Where(phone => !phone.Nfc).ToList();
            }
            else if (rbNfc2.Checked)
            {
                result.IsNeedNfc = 1;
            }
            else if (rbNfc3.Checked)
            {
                result.IsNeedNfc = 2;
                phones = phones.Where(phone => phone.Nfc).ToList();
            }
        }
        private void BatteryPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (rbBattery1.Checked)
            {
                result.Battery = 3000;
                phones = phones.Where(phone => phone.BatterySize <= result.Battery).ToList();
            }
            else if (rbBattery1.Checked)
            {
                result.Battery = 5000;
                phones = phones.Where(phone => phone.BatterySize > 3000 && phone.BatterySize < 6500).ToList();
            }
            else if (rbBattery1.Checked)
            {
                result.Battery = 6500;
                phones = phones.Where(phone => phone.BatterySize >= result.Battery).ToList();
            }
        }
        private void TotalMoneyPage_Commit(object sender, AeroWizard.WizardPageConfirmEventArgs e)
        {
            if (Int32.TryParse(textBox1.Text, out int maxPrice))
            {
                result.MaxPrice = maxPrice;
                phones = phones.Where(phone => phone.Price < maxPrice).ToList();
            }
            var resultPhone = new Phone();
            if (rbIsMaxPrice.Checked && phones.Count() != 0)
            {
                resultPhone = phones?.OrderBy(p => p.Price)?.Last();
            }
            else if (phones.Count() != 0)
            {
                resultPhone = phones?.OrderBy(p => p.Price)?.First();
            }

            if (resultPhone != null)
            {
                lblResult.Text = resultPhone.Title;
                lblBattery.Text = resultPhone.BatterySize.ToString() + " мА*ч";
                lblCamera.Text = resultPhone.CameraMp.ToString() + " MP";
                lblMemory.Text = resultPhone.MemorySize.ToString() + " ГБ";
                lblNFC.Text = resultPhone.Nfc ? "Да" : "Нет";
                lblScreenSize.Text = resultPhone.ScreenSize.ToString() + " дюймов";
                lblPrice.Text = resultPhone.Price.ToString() + " руб.";
            }
            else
            {
                lblResult.Text = "Не удалось подобрать телефон, попробуйте увеличить бюджет";
            }
        }
        private void AddPhone()
        {
            using (PhoneContext db = new PhoneContext()) //Создание подключения
            {
                Phone phone1 = new Phone()
                {
                    Title = "Xiaomi Redmi 9",
                    BatterySize = 5000,
                    ScreenSize = 6.53,
                    CameraMp = 13,
                    MemorySize = 32,
                    Nfc = true,
                    Price = 10810
                };
                db.Phones.Add(phone1);
                Phone phone2 = new Phone()
                {
                    Title = "Ltel A17",
                    BatterySize = 2000,
                    ScreenSize = 5,
                    CameraMp = 5,
                    MemorySize = 16,
                    Nfc = false,
                    Price = 4180
                };
                db.Phones.Add(phone2);
                Phone phone3 = new Phone()
                {
                    Title = "Vivo V21",
                    BatterySize = 4000,
                    ScreenSize = 6.43,
                    CameraMp = 64,
                    MemorySize = 128,
                    Nfc = true,
                    Price = 23490
                };
                db.Phones.Add(phone3);
                Phone phone4 = new Phone()
                {
                    Title = "Tecno Pova 2",
                    BatterySize = 7000,
                    ScreenSize = 7,
                    CameraMp = 48,
                    MemorySize = 128,
                    Nfc = true,
                    Price = 15999
                };
                db.Phones.Add(phone4);
                Phone phone5 = new Phone()
                {
                    Title = "Xiaomi Redmi 9",
                    BatterySize = 5000,
                    ScreenSize = 6.53,
                    CameraMp = 13,
                    MemorySize = 32,
                    Nfc = true,
                    Price = 10810
                };
                db.Phones.Add(phone5);
                Phone phone6 = new Phone()
                {
                    Title = "ZTE Blade L8",
                    BatterySize = 4490,
                    ScreenSize = 5,
                    CameraMp = 8,
                    MemorySize = 32,
                    Nfc = false,
                    Price = 4490
                };
                db.Phones.Add(phone6);

                db.SaveChanges(); //Чтобы добавленные объекты отправились в базу данных, нужно вызвать метод, сохраняющий изменения

            }
        }
        private IReadOnlyCollection<Phone> GetPhones()
        {
            using (PhoneContext db = new PhoneContext()) //Создание подключения
            {
                return db.Phones.ToList();
            }
        }
    }
}
