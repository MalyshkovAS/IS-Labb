
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stepWizardControl1 = new AeroWizard.StepWizardControl();
            this.ScreenPage = new AeroWizard.WizardPage();
            this.rbScreen3 = new System.Windows.Forms.RadioButton();
            this.rbScreen2 = new System.Windows.Forms.RadioButton();
            this.rbScreen1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.MemoryPage = new AeroWizard.WizardPage();
            this.rbMemory3 = new System.Windows.Forms.RadioButton();
            this.rbMemory2 = new System.Windows.Forms.RadioButton();
            this.rbMemory1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CameraPage = new AeroWizard.WizardPage();
            this.rbCamera3 = new System.Windows.Forms.RadioButton();
            this.rbCamera2 = new System.Windows.Forms.RadioButton();
            this.rbCamera1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.NfcPage = new AeroWizard.WizardPage();
            this.rbNfc3 = new System.Windows.Forms.RadioButton();
            this.rbNfc2 = new System.Windows.Forms.RadioButton();
            this.rbNfc1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.BatteryPage = new AeroWizard.WizardPage();
            this.rbBattery3 = new System.Windows.Forms.RadioButton();
            this.rbBattery2 = new System.Windows.Forms.RadioButton();
            this.rbBattery1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalMoneyPage = new AeroWizard.WizardPage();
            this.rbIsMaxPrice = new System.Windows.Forms.RadioButton();
            this.rbIsMinPrice = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ResultPage = new AeroWizard.WizardPage();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCamera = new System.Windows.Forms.Label();
            this.lblBattery = new System.Windows.Forms.Label();
            this.lblNFC = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblScreenSize = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stepWizardControl1)).BeginInit();
            this.ScreenPage.SuspendLayout();
            this.MemoryPage.SuspendLayout();
            this.CameraPage.SuspendLayout();
            this.NfcPage.SuspendLayout();
            this.BatteryPage.SuspendLayout();
            this.TotalMoneyPage.SuspendLayout();
            this.ResultPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // stepWizardControl1
            // 
            this.stepWizardControl1.BackColor = System.Drawing.Color.White;
            this.stepWizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stepWizardControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepWizardControl1.Location = new System.Drawing.Point(0, 0);
            this.stepWizardControl1.Name = "stepWizardControl1";
            this.stepWizardControl1.Pages.Add(this.ScreenPage);
            this.stepWizardControl1.Pages.Add(this.MemoryPage);
            this.stepWizardControl1.Pages.Add(this.CameraPage);
            this.stepWizardControl1.Pages.Add(this.NfcPage);
            this.stepWizardControl1.Pages.Add(this.BatteryPage);
            this.stepWizardControl1.Pages.Add(this.TotalMoneyPage);
            this.stepWizardControl1.Pages.Add(this.ResultPage);
            this.stepWizardControl1.Size = new System.Drawing.Size(800, 450);
            this.stepWizardControl1.StepListFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.stepWizardControl1.TabIndex = 0;
            this.stepWizardControl1.Text = "Wizard Title";
            this.stepWizardControl1.Title = "ЭС по выбору телефона";
            // 
            // ScreenPage
            // 
            this.ScreenPage.Controls.Add(this.rbScreen3);
            this.ScreenPage.Controls.Add(this.rbScreen2);
            this.ScreenPage.Controls.Add(this.rbScreen1);
            this.ScreenPage.Controls.Add(this.label1);
            this.ScreenPage.Name = "ScreenPage";
            this.ScreenPage.Size = new System.Drawing.Size(602, 296);
            this.stepWizardControl1.SetStepText(this.ScreenPage, "1.Диагональ экрана");
            this.ScreenPage.TabIndex = 2;
            this.ScreenPage.Text = "1.Диагональ экрана";
            this.ScreenPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.ScreenPage_Commit);
            // 
            // rbScreen3
            // 
            this.rbScreen3.AutoSize = true;
            this.rbScreen3.Location = new System.Drawing.Point(7, 75);
            this.rbScreen3.Name = "rbScreen3";
            this.rbScreen3.Size = new System.Drawing.Size(85, 19);
            this.rbScreen3.TabIndex = 3;
            this.rbScreen3.TabStop = true;
            this.rbScreen3.Text = "Побольше";
            this.rbScreen3.UseVisualStyleBackColor = true;
            // 
            // rbScreen2
            // 
            this.rbScreen2.AutoSize = true;
            this.rbScreen2.Location = new System.Drawing.Point(7, 48);
            this.rbScreen2.Name = "rbScreen2";
            this.rbScreen2.Size = new System.Drawing.Size(128, 19);
            this.rbScreen2.TabIndex = 2;
            this.rbScreen2.TabStop = true;
            this.rbScreen2.Text = "Средних размеров";
            this.rbScreen2.UseVisualStyleBackColor = true;
            // 
            // rbScreen1
            // 
            this.rbScreen1.AutoSize = true;
            this.rbScreen1.Location = new System.Drawing.Point(7, 23);
            this.rbScreen1.Name = "rbScreen1";
            this.rbScreen1.Size = new System.Drawing.Size(147, 19);
            this.rbScreen1.TabIndex = 1;
            this.rbScreen1.TabStop = true;
            this.rbScreen1.Text = "Небольших размеров";
            this.rbScreen1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Какого размера экран вы бы хотели?";
            // 
            // MemoryPage
            // 
            this.MemoryPage.Controls.Add(this.rbMemory3);
            this.MemoryPage.Controls.Add(this.rbMemory2);
            this.MemoryPage.Controls.Add(this.rbMemory1);
            this.MemoryPage.Controls.Add(this.label2);
            this.MemoryPage.Name = "MemoryPage";
            this.MemoryPage.Size = new System.Drawing.Size(602, 296);
            this.stepWizardControl1.SetStepText(this.MemoryPage, "2.Объем памяти");
            this.MemoryPage.TabIndex = 3;
            this.MemoryPage.Text = "2.Объем памяти";
            this.MemoryPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.MemoryPage_Commit);
            // 
            // rbMemory3
            // 
            this.rbMemory3.AutoSize = true;
            this.rbMemory3.Location = new System.Drawing.Point(4, 75);
            this.rbMemory3.Name = "rbMemory3";
            this.rbMemory3.Size = new System.Drawing.Size(302, 19);
            this.rbMemory3.TabIndex = 3;
            this.rbMemory3.TabStop = true;
            this.rbMemory3.Text = "Побольше, не хочу удалять старые данные(128гб)";
            this.rbMemory3.UseVisualStyleBackColor = true;
            // 
            // rbMemory2
            // 
            this.rbMemory2.AutoSize = true;
            this.rbMemory2.Location = new System.Drawing.Point(4, 49);
            this.rbMemory2.Name = "rbMemory2";
            this.rbMemory2.Size = new System.Drawing.Size(141, 19);
            this.rbMemory2.TabIndex = 2;
            this.rbMemory2.TabStop = true;
            this.rbMemory2.Text = "Что-то среднее(64гб)";
            this.rbMemory2.UseVisualStyleBackColor = true;
            // 
            // rbMemory1
            // 
            this.rbMemory1.AutoSize = true;
            this.rbMemory1.Location = new System.Drawing.Point(4, 23);
            this.rbMemory1.Name = "rbMemory1";
            this.rbMemory1.Size = new System.Drawing.Size(206, 19);
            this.rbMemory1.TabIndex = 1;
            this.rbMemory1.TabStop = true;
            this.rbMemory1.Text = "Мне хватит минимального(32гб)";
            this.rbMemory1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Какой объем памяти вы бы хотели?";
            // 
            // CameraPage
            // 
            this.CameraPage.Controls.Add(this.rbCamera3);
            this.CameraPage.Controls.Add(this.rbCamera2);
            this.CameraPage.Controls.Add(this.rbCamera1);
            this.CameraPage.Controls.Add(this.label3);
            this.CameraPage.Name = "CameraPage";
            this.CameraPage.Size = new System.Drawing.Size(602, 296);
            this.stepWizardControl1.SetStepText(this.CameraPage, "3.Камера");
            this.CameraPage.TabIndex = 4;
            this.CameraPage.Text = "3.Камера";
            this.CameraPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.CameraPage_Commit);
            // 
            // rbCamera3
            // 
            this.rbCamera3.AutoSize = true;
            this.rbCamera3.Location = new System.Drawing.Point(7, 75);
            this.rbCamera3.Name = "rbCamera3";
            this.rbCamera3.Size = new System.Drawing.Size(188, 19);
            this.rbCamera3.TabIndex = 3;
            this.rbCamera3.TabStop = true;
            this.rbCamera3.Text = "Да, люблю фотографировать";
            this.rbCamera3.UseVisualStyleBackColor = true;
            // 
            // rbCamera2
            // 
            this.rbCamera2.AutoSize = true;
            this.rbCamera2.Location = new System.Drawing.Point(7, 49);
            this.rbCamera2.Name = "rbCamera2";
            this.rbCamera2.Size = new System.Drawing.Size(245, 19);
            this.rbCamera2.TabIndex = 2;
            this.rbCamera2.TabStop = true;
            this.rbCamera2.Text = "Что то среднее, не гонюсь за качеством";
            this.rbCamera2.UseVisualStyleBackColor = true;
            // 
            // rbCamera1
            // 
            this.rbCamera1.AutoSize = true;
            this.rbCamera1.Location = new System.Drawing.Point(7, 23);
            this.rbCamera1.Name = "rbCamera1";
            this.rbCamera1.Size = new System.Drawing.Size(104, 19);
            this.rbCamera1.TabIndex = 1;
            this.rbCamera1.TabStop = true;
            this.rbCamera1.Text = "Не интересует";
            this.rbCamera1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Требуется ли вам хорошая камера?";
            // 
            // NfcPage
            // 
            this.NfcPage.Controls.Add(this.rbNfc3);
            this.NfcPage.Controls.Add(this.rbNfc2);
            this.NfcPage.Controls.Add(this.rbNfc1);
            this.NfcPage.Controls.Add(this.label4);
            this.NfcPage.Name = "NfcPage";
            this.NfcPage.Size = new System.Drawing.Size(602, 296);
            this.stepWizardControl1.SetStepText(this.NfcPage, "4.Модуль оплаты");
            this.NfcPage.TabIndex = 5;
            this.NfcPage.Text = "4.Модуль оплаты";
            this.NfcPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.NfcPage_Commit);
            // 
            // rbNfc3
            // 
            this.rbNfc3.AutoSize = true;
            this.rbNfc3.Location = new System.Drawing.Point(7, 73);
            this.rbNfc3.Name = "rbNfc3";
            this.rbNfc3.Size = new System.Drawing.Size(114, 19);
            this.rbNfc3.TabIndex = 3;
            this.rbNfc3.TabStop = true;
            this.rbNfc3.Text = "Да, обязательно";
            this.rbNfc3.UseVisualStyleBackColor = true;
            // 
            // rbNfc2
            // 
            this.rbNfc2.AutoSize = true;
            this.rbNfc2.Location = new System.Drawing.Point(7, 48);
            this.rbNfc2.Name = "rbNfc2";
            this.rbNfc2.Size = new System.Drawing.Size(103, 19);
            this.rbNfc2.TabIndex = 2;
            this.rbNfc2.TabStop = true;
            this.rbNfc2.Text = "Мне не важно";
            this.rbNfc2.UseVisualStyleBackColor = true;
            // 
            // rbNfc1
            // 
            this.rbNfc1.AutoSize = true;
            this.rbNfc1.Location = new System.Drawing.Point(7, 23);
            this.rbNfc1.Name = "rbNfc1";
            this.rbNfc1.Size = new System.Drawing.Size(144, 19);
            this.rbNfc1.TabIndex = 1;
            this.rbNfc1.TabStop = true;
            this.rbNfc1.Text = "Нет, мне он не нужен";
            this.rbNfc1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Требуется ли вам модуль бесконтактной оплаты?";
            // 
            // BatteryPage
            // 
            this.BatteryPage.Controls.Add(this.rbBattery3);
            this.BatteryPage.Controls.Add(this.rbBattery2);
            this.BatteryPage.Controls.Add(this.rbBattery1);
            this.BatteryPage.Controls.Add(this.label5);
            this.BatteryPage.Name = "BatteryPage";
            this.BatteryPage.Size = new System.Drawing.Size(602, 296);
            this.stepWizardControl1.SetStepText(this.BatteryPage, "4.Емкость аккумулятора");
            this.BatteryPage.TabIndex = 6;
            this.BatteryPage.Text = "4.Емкость аккумулятора";
            this.BatteryPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.BatteryPage_Commit);
            // 
            // rbBattery3
            // 
            this.rbBattery3.AutoSize = true;
            this.rbBattery3.Location = new System.Drawing.Point(4, 75);
            this.rbBattery3.Name = "rbBattery3";
            this.rbBattery3.Size = new System.Drawing.Size(98, 19);
            this.rbBattery3.TabIndex = 3;
            this.rbBattery3.TabStop = true;
            this.rbBattery3.Text = "На пару дней";
            this.rbBattery3.UseVisualStyleBackColor = true;
            // 
            // rbBattery2
            // 
            this.rbBattery2.AutoSize = true;
            this.rbBattery2.Location = new System.Drawing.Point(7, 49);
            this.rbBattery2.Name = "rbBattery2";
            this.rbBattery2.Size = new System.Drawing.Size(154, 19);
            this.rbBattery2.TabIndex = 2;
            this.rbBattery2.TabStop = true;
            this.rbBattery2.Text = "Что бы на день хватало";
            this.rbBattery2.UseVisualStyleBackColor = true;
            // 
            // rbBattery1
            // 
            this.rbBattery1.AutoSize = true;
            this.rbBattery1.Location = new System.Drawing.Point(7, 23);
            this.rbBattery1.Name = "rbBattery1";
            this.rbBattery1.Size = new System.Drawing.Size(73, 19);
            this.rbBattery1.TabIndex = 1;
            this.rbBattery1.TabStop = true;
            this.rbBattery1.Text = "Часов 12";
            this.rbBattery1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "На сколько часов автономной работы вы расчитываете?";
            // 
            // TotalMoneyPage
            // 
            this.TotalMoneyPage.Controls.Add(this.rbIsMaxPrice);
            this.TotalMoneyPage.Controls.Add(this.rbIsMinPrice);
            this.TotalMoneyPage.Controls.Add(this.label12);
            this.TotalMoneyPage.Controls.Add(this.textBox1);
            this.TotalMoneyPage.Controls.Add(this.label6);
            this.TotalMoneyPage.Name = "TotalMoneyPage";
            this.TotalMoneyPage.Size = new System.Drawing.Size(602, 296);
            this.stepWizardControl1.SetStepText(this.TotalMoneyPage, "6.Бюджет");
            this.TotalMoneyPage.TabIndex = 7;
            this.TotalMoneyPage.Text = "6.Бюджет";
            this.TotalMoneyPage.Commit += new System.EventHandler<AeroWizard.WizardPageConfirmEventArgs>(this.TotalMoneyPage_Commit);
            // 
            // rbIsMaxPrice
            // 
            this.rbIsMaxPrice.AutoSize = true;
            this.rbIsMaxPrice.Location = new System.Drawing.Point(9, 93);
            this.rbIsMaxPrice.Name = "rbIsMaxPrice";
            this.rbIsMaxPrice.Size = new System.Drawing.Size(196, 19);
            this.rbIsMaxPrice.TabIndex = 4;
            this.rbIsMaxPrice.TabStop = true;
            this.rbIsMaxPrice.Text = "Самый дорогой из возможных";
            this.rbIsMaxPrice.UseVisualStyleBackColor = true;
            // 
            // rbIsMinPrice
            // 
            this.rbIsMinPrice.AutoSize = true;
            this.rbIsMinPrice.Location = new System.Drawing.Point(9, 67);
            this.rbIsMinPrice.Name = "rbIsMinPrice";
            this.rbIsMinPrice.Size = new System.Drawing.Size(229, 19);
            this.rbIsMinPrice.TabIndex = 3;
            this.rbIsMinPrice.TabStop = true;
            this.rbIsMinPrice.Text = "Хочу самый дешевый из возможных";
            this.rbIsMinPrice.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ожидаемый результат:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ваш бюджет:";
            // 
            // ResultPage
            // 
            this.ResultPage.Controls.Add(this.lblPrice);
            this.ResultPage.Controls.Add(this.lblCamera);
            this.ResultPage.Controls.Add(this.lblBattery);
            this.ResultPage.Controls.Add(this.lblNFC);
            this.ResultPage.Controls.Add(this.lblMemory);
            this.ResultPage.Controls.Add(this.label13);
            this.ResultPage.Controls.Add(this.label14);
            this.ResultPage.Controls.Add(this.label11);
            this.ResultPage.Controls.Add(this.label10);
            this.ResultPage.Controls.Add(this.label9);
            this.ResultPage.Controls.Add(this.label8);
            this.ResultPage.Controls.Add(this.lblScreenSize);
            this.ResultPage.Controls.Add(this.lblResult);
            this.ResultPage.Controls.Add(this.label7);
            this.ResultPage.IsFinishPage = true;
            this.ResultPage.Name = "ResultPage";
            this.ResultPage.Size = new System.Drawing.Size(602, 296);
            this.stepWizardControl1.SetStepText(this.ResultPage, "Результат");
            this.ResultPage.TabIndex = 8;
            this.ResultPage.Text = "Результат";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(133, 139);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 15);
            this.lblPrice.TabIndex = 14;
            // 
            // lblCamera
            // 
            this.lblCamera.AutoSize = true;
            this.lblCamera.Location = new System.Drawing.Point(133, 123);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(0, 15);
            this.lblCamera.TabIndex = 13;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Location = new System.Drawing.Point(133, 107);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(0, 15);
            this.lblBattery.TabIndex = 12;
            // 
            // lblNFC
            // 
            this.lblNFC.AutoSize = true;
            this.lblNFC.Location = new System.Drawing.Point(133, 92);
            this.lblNFC.Name = "lblNFC";
            this.lblNFC.Size = new System.Drawing.Size(0, 15);
            this.lblNFC.TabIndex = 11;
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(133, 76);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(0, 15);
            this.lblMemory.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Цена:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 123);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Камера:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Объем батареи:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "NFC:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Объем памяти:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Диагональ экрана:";
            // 
            // lblScreenSize
            // 
            this.lblScreenSize.AutoSize = true;
            this.lblScreenSize.Location = new System.Drawing.Point(133, 58);
            this.lblScreenSize.Name = "lblScreenSize";
            this.lblScreenSize.Size = new System.Drawing.Size(0, 15);
            this.lblScreenSize.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(14, 34);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(60, 15);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Результат";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Для вас мы рекомендуем к покупке:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stepWizardControl1);
            this.Name = "Form1";
            this.Text = "Подбор телефона";
            ((System.ComponentModel.ISupportInitialize)(this.stepWizardControl1)).EndInit();
            this.ScreenPage.ResumeLayout(false);
            this.ScreenPage.PerformLayout();
            this.MemoryPage.ResumeLayout(false);
            this.MemoryPage.PerformLayout();
            this.CameraPage.ResumeLayout(false);
            this.CameraPage.PerformLayout();
            this.NfcPage.ResumeLayout(false);
            this.NfcPage.PerformLayout();
            this.BatteryPage.ResumeLayout(false);
            this.BatteryPage.PerformLayout();
            this.TotalMoneyPage.ResumeLayout(false);
            this.TotalMoneyPage.PerformLayout();
            this.ResultPage.ResumeLayout(false);
            this.ResultPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.StepWizardControl stepWizardControl1;
        private AeroWizard.WizardPage ScreenPage;
        private AeroWizard.WizardPage MemoryPage;
        private AeroWizard.WizardPage CameraPage;
        private AeroWizard.WizardPage NfcPage;
        private AeroWizard.WizardPage BatteryPage;
        private AeroWizard.WizardPage TotalMoneyPage;
        private System.Windows.Forms.RadioButton rbScreen3;
        private System.Windows.Forms.RadioButton rbScreen2;
        private System.Windows.Forms.RadioButton rbScreen1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMemory3;
        private System.Windows.Forms.RadioButton rbMemory2;
        private System.Windows.Forms.RadioButton rbMemory1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbCamera3;
        private System.Windows.Forms.RadioButton rbCamera2;
        private System.Windows.Forms.RadioButton rbCamera1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbNfc3;
        private System.Windows.Forms.RadioButton rbNfc2;
        private System.Windows.Forms.RadioButton rbNfc1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbBattery3;
        private System.Windows.Forms.RadioButton rbBattery2;
        private System.Windows.Forms.RadioButton rbBattery1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private AeroWizard.WizardPage ResultPage;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCamera;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.Label lblNFC;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblScreenSize;
        private System.Windows.Forms.RadioButton rbIsMaxPrice;
        private System.Windows.Forms.RadioButton rbIsMinPrice;
        private System.Windows.Forms.Label label12;
    }
}

