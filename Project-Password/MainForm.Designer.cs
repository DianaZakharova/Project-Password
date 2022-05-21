namespace Project_Password
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topLabel = new System.Windows.Forms.Label();
            this.whiteBar = new System.Windows.Forms.Panel();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.symbolsLabel = new System.Windows.Forms.Label();
            this.lowerCaseLabel = new System.Windows.Forms.Label();
            this.upperCaseLabel = new System.Windows.Forms.Label();
            this.symbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.lowerCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.upperCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.lengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.similarCheckBox = new System.Windows.Forms.CheckBox();
            this.similarLabel = new System.Windows.Forms.Label();
            this.ambiguousCheckBox = new System.Windows.Forms.CheckBox();
            this.ambiguousLabel = new System.Windows.Forms.Label();
            this.uniqueCheckBox = new System.Windows.Forms.CheckBox();
            this.uniqueLabel = new System.Windows.Forms.Label();
            this.generateBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.numbersCheckBox = new System.Windows.Forms.CheckBox();
            this.numbersLabel = new System.Windows.Forms.Label();
            this.generatedLabel = new System.Windows.Forms.Label();
            this.generatedTextBox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.loginTipLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // topLabel
            // 
            this.topLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.White;
            this.topLabel.Location = new System.Drawing.Point(0, 0);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(770, 75);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Password Generator";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // whiteBar
            // 
            this.whiteBar.BackColor = System.Drawing.Color.White;
            this.whiteBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.whiteBar.Location = new System.Drawing.Point(0, 75);
            this.whiteBar.Name = "whiteBar";
            this.whiteBar.Size = new System.Drawing.Size(770, 10);
            this.whiteBar.TabIndex = 1;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.lengthLabel.ForeColor = System.Drawing.Color.Black;
            this.lengthLabel.Location = new System.Drawing.Point(13, 103);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(102, 17);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "Длина пароля:";
            // 
            // symbolsLabel
            // 
            this.symbolsLabel.AutoSize = true;
            this.symbolsLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.symbolsLabel.ForeColor = System.Drawing.Color.Black;
            this.symbolsLabel.Location = new System.Drawing.Point(13, 130);
            this.symbolsLabel.Name = "symbolsLabel";
            this.symbolsLabel.Size = new System.Drawing.Size(135, 17);
            this.symbolsLabel.TabIndex = 3;
            this.symbolsLabel.Text = "Включить символы:";
            // 
            // lowerCaseLabel
            // 
            this.lowerCaseLabel.AutoSize = true;
            this.lowerCaseLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.lowerCaseLabel.ForeColor = System.Drawing.Color.Black;
            this.lowerCaseLabel.Location = new System.Drawing.Point(13, 182);
            this.lowerCaseLabel.Name = "lowerCaseLabel";
            this.lowerCaseLabel.Size = new System.Drawing.Size(201, 17);
            this.lowerCaseLabel.TabIndex = 4;
            this.lowerCaseLabel.Text = "Включить строчные символы:";
            // 
            // upperCaseLabel
            // 
            this.upperCaseLabel.AutoSize = true;
            this.upperCaseLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.upperCaseLabel.ForeColor = System.Drawing.Color.Black;
            this.upperCaseLabel.Location = new System.Drawing.Point(13, 208);
            this.upperCaseLabel.Name = "upperCaseLabel";
            this.upperCaseLabel.Size = new System.Drawing.Size(210, 17);
            this.upperCaseLabel.TabIndex = 5;
            this.upperCaseLabel.Text = "Включить прописные символы:";
            // 
            // symbolsCheckBox
            // 
            this.symbolsCheckBox.AutoSize = true;
            this.symbolsCheckBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.symbolsCheckBox.Location = new System.Drawing.Point(281, 129);
            this.symbolsCheckBox.Name = "symbolsCheckBox";
            this.symbolsCheckBox.Size = new System.Drawing.Size(145, 21);
            this.symbolsCheckBox.TabIndex = 7;
            this.symbolsCheckBox.Text = "(Например @#$%)";
            this.symbolsCheckBox.UseVisualStyleBackColor = true;
            this.symbolsCheckBox.CheckedChanged += new System.EventHandler(this.OnSymbolsChanged);
            // 
            // lowerCaseCheckBox
            // 
            this.lowerCaseCheckBox.AutoSize = true;
            this.lowerCaseCheckBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.lowerCaseCheckBox.Location = new System.Drawing.Point(281, 181);
            this.lowerCaseCheckBox.Name = "lowerCaseCheckBox";
            this.lowerCaseCheckBox.Size = new System.Drawing.Size(161, 21);
            this.lowerCaseCheckBox.TabIndex = 8;
            this.lowerCaseCheckBox.Text = "(Например abcdefgh)";
            this.lowerCaseCheckBox.UseVisualStyleBackColor = true;
            this.lowerCaseCheckBox.CheckedChanged += new System.EventHandler(this.OnLowerChanged);
            // 
            // upperCaseCheckBox
            // 
            this.upperCaseCheckBox.AutoSize = true;
            this.upperCaseCheckBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.upperCaseCheckBox.Location = new System.Drawing.Point(281, 207);
            this.upperCaseCheckBox.Name = "upperCaseCheckBox";
            this.upperCaseCheckBox.Size = new System.Drawing.Size(175, 21);
            this.upperCaseCheckBox.TabIndex = 9;
            this.upperCaseCheckBox.Text = "(Например ABCDEFGH)";
            this.upperCaseCheckBox.UseVisualStyleBackColor = true;
            this.upperCaseCheckBox.CheckedChanged += new System.EventHandler(this.OnUpperChanged);
            // 
            // lengthUpDown
            // 
            this.lengthUpDown.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.lengthUpDown.Location = new System.Drawing.Point(281, 101);
            this.lengthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthUpDown.Name = "lengthUpDown";
            this.lengthUpDown.Size = new System.Drawing.Size(135, 24);
            this.lengthUpDown.TabIndex = 10;
            this.lengthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lengthUpDown.ValueChanged += new System.EventHandler(this.OnLengthChanged);
            // 
            // similarCheckBox
            // 
            this.similarCheckBox.AutoSize = true;
            this.similarCheckBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.similarCheckBox.Location = new System.Drawing.Point(281, 233);
            this.similarCheckBox.Name = "similarCheckBox";
            this.similarCheckBox.Size = new System.Drawing.Size(189, 21);
            this.similarCheckBox.TabIndex = 12;
            this.similarCheckBox.Text = "(Например i, |, L, 1, o, 0, O)";
            this.similarCheckBox.UseVisualStyleBackColor = true;
            this.similarCheckBox.CheckedChanged += new System.EventHandler(this.OnSimilarChanged);
            // 
            // similarLabel
            // 
            this.similarLabel.AutoSize = true;
            this.similarLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.similarLabel.ForeColor = System.Drawing.Color.Black;
            this.similarLabel.Location = new System.Drawing.Point(13, 234);
            this.similarLabel.Name = "similarLabel";
            this.similarLabel.Size = new System.Drawing.Size(211, 17);
            this.similarLabel.TabIndex = 11;
            this.similarLabel.Text = "Исключить подобные символы:";
            // 
            // ambiguousCheckBox
            // 
            this.ambiguousCheckBox.AutoSize = true;
            this.ambiguousCheckBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.ambiguousCheckBox.Location = new System.Drawing.Point(281, 259);
            this.ambiguousCheckBox.Name = "ambiguousCheckBox";
            this.ambiguousCheckBox.Size = new System.Drawing.Size(228, 21);
            this.ambiguousCheckBox.TabIndex = 14;
            this.ambiguousCheckBox.Text = "(Например {} [] () /\\ <> \' \" ~  , ; :  .)";
            this.ambiguousCheckBox.UseVisualStyleBackColor = true;
            this.ambiguousCheckBox.CheckedChanged += new System.EventHandler(this.OnAmbiguousChanged);
            // 
            // ambiguousLabel
            // 
            this.ambiguousLabel.AutoSize = true;
            this.ambiguousLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.ambiguousLabel.ForeColor = System.Drawing.Color.Black;
            this.ambiguousLabel.Location = new System.Drawing.Point(13, 260);
            this.ambiguousLabel.Name = "ambiguousLabel";
            this.ambiguousLabel.Size = new System.Drawing.Size(251, 17);
            this.ambiguousLabel.TabIndex = 13;
            this.ambiguousLabel.Text = "Исключить неоднозначные символы:";
            // 
            // uniqueCheckBox
            // 
            this.uniqueCheckBox.AutoSize = true;
            this.uniqueCheckBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.uniqueCheckBox.Location = new System.Drawing.Point(281, 285);
            this.uniqueCheckBox.Name = "uniqueCheckBox";
            this.uniqueCheckBox.Size = new System.Drawing.Size(330, 21);
            this.uniqueCheckBox.TabIndex = 16;
            this.uniqueCheckBox.Text = "(Сравнивает с распространёнными паролями)";
            this.uniqueCheckBox.UseVisualStyleBackColor = true;
            this.uniqueCheckBox.CheckedChanged += new System.EventHandler(this.uniqueCheckBox_CheckedChanged);
            // 
            // uniqueLabel
            // 
            this.uniqueLabel.AutoSize = true;
            this.uniqueLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.uniqueLabel.ForeColor = System.Drawing.Color.Black;
            this.uniqueLabel.Location = new System.Drawing.Point(13, 286);
            this.uniqueLabel.Name = "uniqueLabel";
            this.uniqueLabel.Size = new System.Drawing.Size(218, 17);
            this.uniqueLabel.TabIndex = 15;
            this.uniqueLabel.Text = "Генерация уникального пароля:";
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.generateBtn.FlatAppearance.BorderSize = 0;
            this.generateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.generateBtn.Location = new System.Drawing.Point(281, 311);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(143, 27);
            this.generateBtn.TabIndex = 17;
            this.generateBtn.Text = "Сгенерировать";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.OnGenerateClick);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(96)))), ((int)(((byte)(208)))));
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.saveBtn.Location = new System.Drawing.Point(430, 311);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(143, 27);
            this.saveBtn.TabIndex = 18;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // numbersCheckBox
            // 
            this.numbersCheckBox.AutoSize = true;
            this.numbersCheckBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.numbersCheckBox.Location = new System.Drawing.Point(281, 155);
            this.numbersCheckBox.Name = "numbersCheckBox";
            this.numbersCheckBox.Size = new System.Drawing.Size(153, 21);
            this.numbersCheckBox.TabIndex = 20;
            this.numbersCheckBox.Text = "(Например 123456)";
            this.numbersCheckBox.UseVisualStyleBackColor = true;
            this.numbersCheckBox.CheckedChanged += new System.EventHandler(this.OnNumbersChanged);
            // 
            // numbersLabel
            // 
            this.numbersLabel.AutoSize = true;
            this.numbersLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.numbersLabel.ForeColor = System.Drawing.Color.Black;
            this.numbersLabel.Location = new System.Drawing.Point(13, 156);
            this.numbersLabel.Name = "numbersLabel";
            this.numbersLabel.Size = new System.Drawing.Size(122, 17);
            this.numbersLabel.TabIndex = 19;
            this.numbersLabel.Text = "Включить цифры:";
            // 
            // generatedLabel
            // 
            this.generatedLabel.AutoSize = true;
            this.generatedLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedLabel.ForeColor = System.Drawing.Color.Black;
            this.generatedLabel.Location = new System.Drawing.Point(8, 354);
            this.generatedLabel.Name = "generatedLabel";
            this.generatedLabel.Size = new System.Drawing.Size(267, 20);
            this.generatedLabel.TabIndex = 21;
            this.generatedLabel.Text = "Ваш сгенерированный пароль:";
            // 
            // generatedTextBox
            // 
            this.generatedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generatedTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.generatedTextBox.Location = new System.Drawing.Point(281, 354);
            this.generatedTextBox.MinimumSize = new System.Drawing.Size(292, 22);
            this.generatedTextBox.Name = "generatedTextBox";
            this.generatedTextBox.ReadOnly = true;
            this.generatedTextBox.Size = new System.Drawing.Size(292, 24);
            this.generatedTextBox.TabIndex = 22;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.loginLabel.Location = new System.Drawing.Point(538, 104);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(50, 17);
            this.loginLabel.TabIndex = 23;
            this.loginLabel.Text = "Логин:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F);
            this.loginTextBox.Location = new System.Drawing.Point(593, 100);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(165, 24);
            this.loginTextBox.TabIndex = 24;
            // 
            // loginTipLabel
            // 
            this.loginTipLabel.AutoSize = true;
            this.loginTipLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.loginTipLabel.Location = new System.Drawing.Point(590, 131);
            this.loginTipLabel.Name = "loginTipLabel";
            this.loginTipLabel.Size = new System.Drawing.Size(170, 30);
            this.loginTipLabel.TabIndex = 25;
            this.loginTipLabel.Text = "Введите логин, если хотите\r\nсохранить пароль";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(770, 532);
            this.Controls.Add(this.loginTipLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.generatedTextBox);
            this.Controls.Add(this.generatedLabel);
            this.Controls.Add(this.numbersCheckBox);
            this.Controls.Add(this.numbersLabel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.uniqueCheckBox);
            this.Controls.Add(this.uniqueLabel);
            this.Controls.Add(this.ambiguousCheckBox);
            this.Controls.Add(this.ambiguousLabel);
            this.Controls.Add(this.similarCheckBox);
            this.Controls.Add(this.similarLabel);
            this.Controls.Add(this.lengthUpDown);
            this.Controls.Add(this.upperCaseCheckBox);
            this.Controls.Add(this.lowerCaseCheckBox);
            this.Controls.Add(this.symbolsCheckBox);
            this.Controls.Add(this.upperCaseLabel);
            this.Controls.Add(this.lowerCaseLabel);
            this.Controls.Add(this.symbolsLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.whiteBar);
            this.Controls.Add(this.topLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(679, 474);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор паролей";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.lengthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel whiteBar;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label symbolsLabel;
        private System.Windows.Forms.Label lowerCaseLabel;
        private System.Windows.Forms.Label upperCaseLabel;
        private System.Windows.Forms.CheckBox symbolsCheckBox;
        private System.Windows.Forms.CheckBox lowerCaseCheckBox;
        private System.Windows.Forms.CheckBox upperCaseCheckBox;
        private System.Windows.Forms.NumericUpDown lengthUpDown;
        private System.Windows.Forms.CheckBox similarCheckBox;
        private System.Windows.Forms.Label similarLabel;
        private System.Windows.Forms.CheckBox ambiguousCheckBox;
        private System.Windows.Forms.Label ambiguousLabel;
        private System.Windows.Forms.CheckBox uniqueCheckBox;
        private System.Windows.Forms.Label uniqueLabel;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox numbersCheckBox;
        private System.Windows.Forms.Label numbersLabel;
        private System.Windows.Forms.Label generatedLabel;
        private System.Windows.Forms.TextBox generatedTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label loginTipLabel;
    }
}

