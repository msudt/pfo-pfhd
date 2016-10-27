namespace ClientPFHD
{
    partial class FormClientPFHD
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uriCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxXML = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pathFileTB = new System.Windows.Forms.TextBox();
            this.buttonOpenXML = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.methodCB = new System.Windows.Forms.ComboBox();
            this.filenameTB = new System.Windows.Forms.TextBox();
            this.tBresponse = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(100, 25);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(212, 20);
            this.loginTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(100, 51);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(212, 20);
            this.passwordTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // uriCB
            // 
            this.uriCB.FormattingEnabled = true;
            this.uriCB.Items.AddRange(new object[] {
            "IcomePlan",
            "LimitPlan",
            "ExpenditurePlan",
            "finActivityPlan",
            "finActivityPlan2017",
            "extraValue",
            "IncomePaymentDoc",
            "ExpensePaymentDoc"});
            this.uriCB.Location = new System.Drawing.Point(100, 77);
            this.uriCB.Name = "uriCB";
            this.uriCB.Size = new System.Drawing.Size(212, 21);
            this.uriCB.TabIndex = 5;
            this.uriCB.Text = "IncomePlan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "URI";
            // 
            // textBoxXML
            // 
            this.textBoxXML.Location = new System.Drawing.Point(52, 155);
            this.textBoxXML.Multiline = true;
            this.textBoxXML.Name = "textBoxXML";
            this.textBoxXML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxXML.Size = new System.Drawing.Size(577, 170);
            this.textBoxXML.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "XML:";
            // 
            // pathFileTB
            // 
            this.pathFileTB.Location = new System.Drawing.Point(139, 108);
            this.pathFileTB.Name = "pathFileTB";
            this.pathFileTB.Size = new System.Drawing.Size(331, 20);
            this.pathFileTB.TabIndex = 9;
            // 
            // buttonOpenXML
            // 
            this.buttonOpenXML.Location = new System.Drawing.Point(15, 106);
            this.buttonOpenXML.Name = "buttonOpenXML";
            this.buttonOpenXML.Size = new System.Drawing.Size(100, 23);
            this.buttonOpenXML.TabIndex = 10;
            this.buttonOpenXML.Text = "Выбрать XML";
            this.buttonOpenXML.UseVisualStyleBackColor = true;
            this.buttonOpenXML.Click += new System.EventHandler(this.buttonOpenXML_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(295, 369);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 11;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Метод отправки";
            // 
            // methodCB
            // 
            this.methodCB.FormattingEnabled = true;
            this.methodCB.Items.AddRange(new object[] {
            "/API/Docs/Edubpl/Put"});
            this.methodCB.Location = new System.Drawing.Point(139, 332);
            this.methodCB.Name = "methodCB";
            this.methodCB.Size = new System.Drawing.Size(490, 21);
            this.methodCB.TabIndex = 13;
            this.methodCB.Text = "/API/Docs/Edubpl/Put";
            // 
            // filenameTB
            // 
            this.filenameTB.Location = new System.Drawing.Point(493, 109);
            this.filenameTB.Name = "filenameTB";
            this.filenameTB.Size = new System.Drawing.Size(136, 20);
            this.filenameTB.TabIndex = 14;
            // 
            // tBresponse
            // 
            this.tBresponse.Location = new System.Drawing.Point(748, 40);
            this.tBresponse.Multiline = true;
            this.tBresponse.Name = "tBresponse";
            this.tBresponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBresponse.Size = new System.Drawing.Size(436, 359);
            this.tBresponse.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(745, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ответ";
            // 
            // FormClientPFHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 411);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tBresponse);
            this.Controls.Add(this.filenameTB);
            this.Controls.Add(this.methodCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonOpenXML);
            this.Controls.Add(this.pathFileTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxXML);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uriCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Name = "FormClientPFHD";
            this.Text = "Клиент интеграции ВС ВУЗа - МГУДТ с АСУ ПФХД";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox uriCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxXML;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pathFileTB;
        private System.Windows.Forms.Button buttonOpenXML;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ComboBox methodCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox filenameTB;
        private System.Windows.Forms.TextBox tBresponse;
        private System.Windows.Forms.Label label6;
    }
}

