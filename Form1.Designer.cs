namespace CSGOACCOUNTCFG
{
    partial class Form1
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
            this.ImportMafileBtn = new System.Windows.Forms.Button();
            this.SteamID64textbox = new System.Windows.Forms.TextBox();
            this.STEAMID3textbox = new System.Windows.Forms.TextBox();
            this.Browsec = new System.Windows.Forms.FolderBrowserDialog();
            this.Convert64to3btn = new System.Windows.Forms.Button();
            this.ImportMFOne_btn = new System.Windows.Forms.Button();
            this.Importer = new System.Windows.Forms.OpenFileDialog();
            this.ImportOneTxt_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnForceClose = new System.Windows.Forms.Button();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SourcePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectSourcePath = new System.Windows.Forms.Button();
            this.DefaultPathsBtn = new System.Windows.Forms.Button();
            this.SavePathSettings = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UserDataGetFolderName_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportMafileBtn
            // 
            this.ImportMafileBtn.AutoSize = true;
            this.ImportMafileBtn.Location = new System.Drawing.Point(12, 3);
            this.ImportMafileBtn.Name = "ImportMafileBtn";
            this.ImportMafileBtn.Size = new System.Drawing.Size(248, 23);
            this.ImportMafileBtn.TabIndex = 0;
            this.ImportMafileBtn.Text = "ИМПОРТ АККАУНТОВ ( ПАПКА МАФАЙЛЫ )";
            this.ImportMafileBtn.UseVisualStyleBackColor = true;
            this.ImportMafileBtn.Click += new System.EventHandler(this.ImportMafileBtn_Click);
            // 
            // SteamID64textbox
            // 
            this.SteamID64textbox.Location = new System.Drawing.Point(12, 131);
            this.SteamID64textbox.Name = "SteamID64textbox";
            this.SteamID64textbox.Size = new System.Drawing.Size(248, 20);
            this.SteamID64textbox.TabIndex = 1;
            this.SteamID64textbox.Text = "76561198141330061";
            // 
            // STEAMID3textbox
            // 
            this.STEAMID3textbox.Location = new System.Drawing.Point(12, 199);
            this.STEAMID3textbox.Name = "STEAMID3textbox";
            this.STEAMID3textbox.Size = new System.Drawing.Size(248, 20);
            this.STEAMID3textbox.TabIndex = 2;
            // 
            // Browsec
            // 
            this.Browsec.Description = "Выбор директории";
            // 
            // Convert64to3btn
            // 
            this.Convert64to3btn.Location = new System.Drawing.Point(12, 157);
            this.Convert64to3btn.Name = "Convert64to3btn";
            this.Convert64to3btn.Size = new System.Drawing.Size(248, 23);
            this.Convert64to3btn.TabIndex = 3;
            this.Convert64to3btn.Text = "CONVERT";
            this.Convert64to3btn.UseVisualStyleBackColor = true;
            this.Convert64to3btn.Click += new System.EventHandler(this.Convert64to3btn_Click);
            // 
            // ImportMFOne_btn
            // 
            this.ImportMFOne_btn.AutoSize = true;
            this.ImportMFOne_btn.Location = new System.Drawing.Point(12, 31);
            this.ImportMFOne_btn.Name = "ImportMFOne_btn";
            this.ImportMFOne_btn.Size = new System.Drawing.Size(248, 23);
            this.ImportMFOne_btn.TabIndex = 6;
            this.ImportMFOne_btn.Text = "ИМПОРТ АККАУНТОВ ( ОДИН МАФАЙЛ  )";
            this.ImportMFOne_btn.UseVisualStyleBackColor = true;
            this.ImportMFOne_btn.Click += new System.EventHandler(this.ImportMFOne_btn_Click);
            // 
            // Importer
            // 
            this.Importer.Title = "Импорт аккаунтов";
            // 
            // ImportOneTxt_btn
            // 
            this.ImportOneTxt_btn.Location = new System.Drawing.Point(12, 60);
            this.ImportOneTxt_btn.Name = "ImportOneTxt_btn";
            this.ImportOneTxt_btn.Size = new System.Drawing.Size(248, 23);
            this.ImportOneTxt_btn.TabIndex = 7;
            this.ImportOneTxt_btn.Text = "ИМПОРТ АККАУНТОВ ( ОДИН ТХТ )";
            this.ImportOneTxt_btn.UseVisualStyleBackColor = true;
            this.ImportOneTxt_btn.Click += new System.EventHandler(this.ImportOneTxt_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPath);
            this.groupBox2.Controls.Add(this.btnForceClose);
            this.groupBox2.Controls.Add(this.btnSelectPath);
            this.groupBox2.Location = new System.Drawing.Point(266, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 100);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UserData Path";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 22);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(234, 20);
            this.txtPath.TabIndex = 10;
            // 
            // btnForceClose
            // 
            this.btnForceClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnForceClose.Location = new System.Drawing.Point(273, 312);
            this.btnForceClose.Name = "btnForceClose";
            this.btnForceClose.Size = new System.Drawing.Size(126, 32);
            this.btnForceClose.TabIndex = 16;
            this.btnForceClose.Text = "Force Close Steam";
            this.btnForceClose.UseVisualStyleBackColor = true;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectPath.Location = new System.Drawing.Point(9, 62);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(231, 32);
            this.btnSelectPath.TabIndex = 9;
            this.btnSelectPath.Text = "Select";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SourcePath);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSelectSourcePath);
            this.groupBox1.Location = new System.Drawing.Point(266, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Path";
            // 
            // SourcePath
            // 
            this.SourcePath.Location = new System.Drawing.Point(6, 22);
            this.SourcePath.Name = "SourcePath";
            this.SourcePath.ReadOnly = true;
            this.SourcePath.Size = new System.Drawing.Size(234, 20);
            this.SourcePath.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(273, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Force Close Steam";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSelectSourcePath
            // 
            this.btnSelectSourcePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSelectSourcePath.Location = new System.Drawing.Point(9, 62);
            this.btnSelectSourcePath.Name = "btnSelectSourcePath";
            this.btnSelectSourcePath.Size = new System.Drawing.Size(231, 32);
            this.btnSelectSourcePath.TabIndex = 9;
            this.btnSelectSourcePath.Text = "Select";
            this.btnSelectSourcePath.UseVisualStyleBackColor = true;
            this.btnSelectSourcePath.Click += new System.EventHandler(this.btnSelectSourcePath_Click);
            // 
            // DefaultPathsBtn
            // 
            this.DefaultPathsBtn.Location = new System.Drawing.Point(12, 283);
            this.DefaultPathsBtn.Name = "DefaultPathsBtn";
            this.DefaultPathsBtn.Size = new System.Drawing.Size(248, 23);
            this.DefaultPathsBtn.TabIndex = 18;
            this.DefaultPathsBtn.Text = "Стандартные пути UserData + Source Path";
            this.DefaultPathsBtn.UseVisualStyleBackColor = true;
            this.DefaultPathsBtn.Click += new System.EventHandler(this.DefaultPathsBtn_Click);
            // 
            // SavePathSettings
            // 
            this.SavePathSettings.Location = new System.Drawing.Point(12, 254);
            this.SavePathSettings.Name = "SavePathSettings";
            this.SavePathSettings.Size = new System.Drawing.Size(248, 23);
            this.SavePathSettings.TabIndex = 19;
            this.SavePathSettings.Text = "Сохранить настройки UserData + Source Path";
            this.SavePathSettings.UseVisualStyleBackColor = true;
            this.SavePathSettings.Click += new System.EventHandler(this.SavePathSettings_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "СОЗДАНИЕ КФГ ЭТОМУ АККУ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UserDataGetFolderName_btn
            // 
            this.UserDataGetFolderName_btn.AutoSize = true;
            this.UserDataGetFolderName_btn.Location = new System.Drawing.Point(12, 89);
            this.UserDataGetFolderName_btn.Name = "UserDataGetFolderName_btn";
            this.UserDataGetFolderName_btn.Size = new System.Drawing.Size(248, 23);
            this.UserDataGetFolderName_btn.TabIndex = 21;
            this.UserDataGetFolderName_btn.Text = "ПолучитьИменаПапок в userdata";
            this.UserDataGetFolderName_btn.UseVisualStyleBackColor = true;
            this.UserDataGetFolderName_btn.Click += new System.EventHandler(this.UserDataGetFolderName_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Convert 64 to 32";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "CreateCFGForOne";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserDataGetFolderName_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SavePathSettings);
            this.Controls.Add(this.DefaultPathsBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ImportOneTxt_btn);
            this.Controls.Add(this.ImportMFOne_btn);
            this.Controls.Add(this.Convert64to3btn);
            this.Controls.Add(this.STEAMID3textbox);
            this.Controls.Add(this.SteamID64textbox);
            this.Controls.Add(this.ImportMafileBtn);
            this.Name = "Form1";
            this.Text = "CSGOACCOUNTCFG  v0.0.0.1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportMafileBtn;
        private System.Windows.Forms.TextBox SteamID64textbox;
        private System.Windows.Forms.TextBox STEAMID3textbox;
        private System.Windows.Forms.FolderBrowserDialog Browsec;
        private System.Windows.Forms.Button Convert64to3btn;
        private System.Windows.Forms.Button ImportMFOne_btn;
        private System.Windows.Forms.OpenFileDialog Importer;
        private System.Windows.Forms.Button ImportOneTxt_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnForceClose;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SourcePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelectSourcePath;
        private System.Windows.Forms.Button DefaultPathsBtn;
        private System.Windows.Forms.Button SavePathSettings;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UserDataGetFolderName_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

