
namespace DatingProgram.Forms
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.newProfileButton = new System.Windows.Forms.Button();
            this.editProfileButton = new System.Windows.Forms.Button();
            this.archiveButton = new System.Windows.Forms.Button();
            this.createMailButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.emptyTableLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.checkBoxAge = new System.Windows.Forms.CheckBox();
            this.numericAgeFirst = new System.Windows.Forms.NumericUpDown();
            this.ageLabelPart1 = new System.Windows.Forms.Label();
            this.ageLabelPart2 = new System.Windows.Forms.Label();
            this.numericAgeSecond = new System.Windows.Forms.NumericUpDown();
            this.checkBoxInterval = new System.Windows.Forms.CheckBox();
            this.checkBoxCity = new System.Windows.Forms.CheckBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.cityButton = new System.Windows.Forms.Button();
            this.seeArchiveButton = new System.Windows.Forms.Button();
            this.lookForMailsButton = new System.Windows.Forms.Button();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.currentUserTitleLabel = new System.Windows.Forms.Label();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.Color.Black;
            this.dataGridView.Location = new System.Drawing.Point(20, 172);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(844, 329);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // newProfileButton
            // 
            this.newProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(36)))), ((int)(((byte)(116)))));
            this.newProfileButton.FlatAppearance.BorderSize = 10;
            this.newProfileButton.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newProfileButton.ForeColor = System.Drawing.Color.Black;
            this.newProfileButton.Location = new System.Drawing.Point(313, 136);
            this.newProfileButton.Margin = new System.Windows.Forms.Padding(2);
            this.newProfileButton.Name = "newProfileButton";
            this.newProfileButton.Size = new System.Drawing.Size(241, 31);
            this.newProfileButton.TabIndex = 1;
            this.newProfileButton.Text = "Создать профиль";
            this.newProfileButton.UseVisualStyleBackColor = true;
            this.newProfileButton.Click += new System.EventHandler(this.newProfileButton_Click);
            // 
            // editProfileButton
            // 
            this.editProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(36)))), ((int)(((byte)(116)))));
            this.editProfileButton.FlatAppearance.BorderSize = 10;
            this.editProfileButton.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editProfileButton.ForeColor = System.Drawing.Color.Black;
            this.editProfileButton.Location = new System.Drawing.Point(651, 10);
            this.editProfileButton.Margin = new System.Windows.Forms.Padding(2);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(214, 31);
            this.editProfileButton.TabIndex = 2;
            this.editProfileButton.Text = "Редактировать профиль";
            this.editProfileButton.UseVisualStyleBackColor = true;
            this.editProfileButton.Click += new System.EventHandler(this.editProfileButton_Click);
            // 
            // archiveButton
            // 
            this.archiveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(36)))), ((int)(((byte)(116)))));
            this.archiveButton.FlatAppearance.BorderSize = 10;
            this.archiveButton.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.archiveButton.ForeColor = System.Drawing.Color.Black;
            this.archiveButton.Location = new System.Drawing.Point(558, 136);
            this.archiveButton.Margin = new System.Windows.Forms.Padding(2);
            this.archiveButton.Name = "archiveButton";
            this.archiveButton.Size = new System.Drawing.Size(307, 31);
            this.archiveButton.TabIndex = 3;
            this.archiveButton.Text = "Удалить текущий профиль (в архив)";
            this.archiveButton.UseVisualStyleBackColor = true;
            this.archiveButton.Click += new System.EventHandler(this.archiveButton_Click);
            // 
            // createMailButton
            // 
            this.createMailButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(36)))), ((int)(((byte)(116)))));
            this.createMailButton.FlatAppearance.BorderSize = 10;
            this.createMailButton.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createMailButton.ForeColor = System.Drawing.Color.Black;
            this.createMailButton.Location = new System.Drawing.Point(167, 10);
            this.createMailButton.Margin = new System.Windows.Forms.Padding(2);
            this.createMailButton.Name = "createMailButton";
            this.createMailButton.Size = new System.Drawing.Size(184, 31);
            this.createMailButton.TabIndex = 4;
            this.createMailButton.Text = "Отправить письмо";
            this.createMailButton.UseVisualStyleBackColor = true;
            this.createMailButton.Click += new System.EventHandler(this.createMailButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(21)))), ((int)(((byte)(145)))));
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 73);
            this.label2.TabIndex = 7;
            this.label2.Text = "❤";
            // 
            // emptyTableLabel
            // 
            this.emptyTableLabel.AutoSize = true;
            this.emptyTableLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.emptyTableLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emptyTableLabel.Location = new System.Drawing.Point(26, 210);
            this.emptyTableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emptyTableLabel.Name = "emptyTableLabel";
            this.emptyTableLabel.Size = new System.Drawing.Size(204, 29);
            this.emptyTableLabel.TabIndex = 8;
            this.emptyTableLabel.Text = "Записи не найдены";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel.ForeColor = System.Drawing.Color.Purple;
            this.infoLabel.Location = new System.Drawing.Point(96, 97);
            this.infoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(324, 23);
            this.infoLabel.TabIndex = 9;
            this.infoLabel.Text = "Добро пожаловать в Бюро знакомств!";
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxMale.Location = new System.Drawing.Point(20, 511);
            this.checkBoxMale.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(104, 27);
            this.checkBoxMale.TabIndex = 10;
            this.checkBoxMale.Text = "Мужчины";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.checkBoxMale_CheckedChanged);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxFemale.Location = new System.Drawing.Point(20, 539);
            this.checkBoxFemale.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(109, 27);
            this.checkBoxFemale.TabIndex = 11;
            this.checkBoxFemale.Text = "Женщины";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.checkBoxFemale_CheckedChanged);
            // 
            // checkBoxAge
            // 
            this.checkBoxAge.AutoSize = true;
            this.checkBoxAge.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxAge.Location = new System.Drawing.Point(157, 511);
            this.checkBoxAge.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAge.Name = "checkBoxAge";
            this.checkBoxAge.Size = new System.Drawing.Size(251, 27);
            this.checkBoxAge.TabIndex = 12;
            this.checkBoxAge.Text = "Фильтровать по возрасту";
            this.checkBoxAge.UseVisualStyleBackColor = true;
            this.checkBoxAge.CheckedChanged += new System.EventHandler(this.checkBoxAge_CheckedChanged);
            // 
            // numericAgeFirst
            // 
            this.numericAgeFirst.Enabled = false;
            this.numericAgeFirst.Location = new System.Drawing.Point(263, 568);
            this.numericAgeFirst.Margin = new System.Windows.Forms.Padding(2);
            this.numericAgeFirst.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numericAgeFirst.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericAgeFirst.Name = "numericAgeFirst";
            this.numericAgeFirst.Size = new System.Drawing.Size(40, 20);
            this.numericAgeFirst.TabIndex = 13;
            this.numericAgeFirst.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericAgeFirst.ValueChanged += new System.EventHandler(this.numericAgeFirst_ValueChanged);
            // 
            // ageLabelPart1
            // 
            this.ageLabelPart1.AutoSize = true;
            this.ageLabelPart1.Enabled = false;
            this.ageLabelPart1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabelPart1.Location = new System.Drawing.Point(153, 566);
            this.ageLabelPart1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLabelPart1.Name = "ageLabelPart1";
            this.ageLabelPart1.Size = new System.Drawing.Size(109, 23);
            this.ageLabelPart1.TabIndex = 14;
            this.ageLabelPart1.Text = "Возраст от";
            // 
            // ageLabelPart2
            // 
            this.ageLabelPart2.AutoSize = true;
            this.ageLabelPart2.Enabled = false;
            this.ageLabelPart2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLabelPart2.Location = new System.Drawing.Point(310, 566);
            this.ageLabelPart2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLabelPart2.Name = "ageLabelPart2";
            this.ageLabelPart2.Size = new System.Drawing.Size(30, 23);
            this.ageLabelPart2.TabIndex = 15;
            this.ageLabelPart2.Text = "до";
            // 
            // numericAgeSecond
            // 
            this.numericAgeSecond.Enabled = false;
            this.numericAgeSecond.Location = new System.Drawing.Point(344, 566);
            this.numericAgeSecond.Margin = new System.Windows.Forms.Padding(2);
            this.numericAgeSecond.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericAgeSecond.Minimum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericAgeSecond.Name = "numericAgeSecond";
            this.numericAgeSecond.Size = new System.Drawing.Size(39, 20);
            this.numericAgeSecond.TabIndex = 16;
            this.numericAgeSecond.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericAgeSecond.ValueChanged += new System.EventHandler(this.numericAgeSecond_ValueChanged);
            // 
            // checkBoxInterval
            // 
            this.checkBoxInterval.AutoSize = true;
            this.checkBoxInterval.Enabled = false;
            this.checkBoxInterval.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxInterval.Location = new System.Drawing.Point(157, 539);
            this.checkBoxInterval.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxInterval.Name = "checkBoxInterval";
            this.checkBoxInterval.Size = new System.Drawing.Size(261, 27);
            this.checkBoxInterval.TabIndex = 17;
            this.checkBoxInterval.Text = "Возраст в виде промежутка";
            this.checkBoxInterval.UseVisualStyleBackColor = true;
            this.checkBoxInterval.CheckedChanged += new System.EventHandler(this.checkBoxInterval_CheckedChanged);
            // 
            // checkBoxCity
            // 
            this.checkBoxCity.AutoSize = true;
            this.checkBoxCity.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxCity.Location = new System.Drawing.Point(438, 511);
            this.checkBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCity.Name = "checkBoxCity";
            this.checkBoxCity.Size = new System.Drawing.Size(230, 27);
            this.checkBoxCity.TabIndex = 18;
            this.checkBoxCity.Text = "Фильтровать по городу";
            this.checkBoxCity.UseVisualStyleBackColor = true;
            this.checkBoxCity.CheckedChanged += new System.EventHandler(this.checkBoxCity_CheckedChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Enabled = false;
            this.cityLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.Location = new System.Drawing.Point(434, 542);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(65, 23);
            this.cityLabel.TabIndex = 19;
            this.cityLabel.Text = "Город:";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Enabled = false;
            this.textBoxCity.Font = new System.Drawing.Font("Arial Narrow", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCity.Location = new System.Drawing.Point(497, 537);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(237, 29);
            this.textBoxCity.TabIndex = 20;
            this.textBoxCity.TextChanged += new System.EventHandler(this.textBoxCity_TextChanged);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(20, 136);
            this.updateButton.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(32, 31);
            this.updateButton.TabIndex = 21;
            this.updateButton.Text = "↻";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // cityButton
            // 
            this.cityButton.Enabled = false;
            this.cityButton.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityButton.Location = new System.Drawing.Point(738, 537);
            this.cityButton.Margin = new System.Windows.Forms.Padding(2);
            this.cityButton.Name = "cityButton";
            this.cityButton.Size = new System.Drawing.Size(127, 28);
            this.cityButton.TabIndex = 22;
            this.cityButton.Text = "Выбрать город";
            this.cityButton.UseVisualStyleBackColor = true;
            this.cityButton.Click += new System.EventHandler(this.cityButton_Click);
            // 
            // seeArchiveButton
            // 
            this.seeArchiveButton.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seeArchiveButton.Location = new System.Drawing.Point(56, 136);
            this.seeArchiveButton.Margin = new System.Windows.Forms.Padding(2);
            this.seeArchiveButton.Name = "seeArchiveButton";
            this.seeArchiveButton.Size = new System.Drawing.Size(252, 31);
            this.seeArchiveButton.TabIndex = 23;
            this.seeArchiveButton.Text = "Посмотреть архив";
            this.seeArchiveButton.UseVisualStyleBackColor = true;
            this.seeArchiveButton.Click += new System.EventHandler(this.seeArchiveButton_Click);
            // 
            // lookForMailsButton
            // 
            this.lookForMailsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(36)))), ((int)(((byte)(116)))));
            this.lookForMailsButton.FlatAppearance.BorderSize = 10;
            this.lookForMailsButton.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lookForMailsButton.ForeColor = System.Drawing.Color.Black;
            this.lookForMailsButton.Location = new System.Drawing.Point(20, 10);
            this.lookForMailsButton.Margin = new System.Windows.Forms.Padding(2);
            this.lookForMailsButton.Name = "lookForMailsButton";
            this.lookForMailsButton.Size = new System.Drawing.Size(142, 31);
            this.lookForMailsButton.TabIndex = 24;
            this.lookForMailsButton.Text = "Мои письма";
            this.lookForMailsButton.UseVisualStyleBackColor = true;
            this.lookForMailsButton.Click += new System.EventHandler(this.lookForMailsButton_Click);
            // 
            // changeUserButton
            // 
            this.changeUserButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(36)))), ((int)(((byte)(116)))));
            this.changeUserButton.FlatAppearance.BorderSize = 10;
            this.changeUserButton.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeUserButton.ForeColor = System.Drawing.Color.Black;
            this.changeUserButton.Location = new System.Drawing.Point(356, 10);
            this.changeUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(290, 31);
            this.changeUserButton.TabIndex = 25;
            this.changeUserButton.Text = "Выбрать как текущий профиль";
            this.changeUserButton.UseVisualStyleBackColor = true;
            this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
            // 
            // currentUserTitleLabel
            // 
            this.currentUserTitleLabel.AutoSize = true;
            this.currentUserTitleLabel.Font = new System.Drawing.Font("Arial Narrow", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserTitleLabel.ForeColor = System.Drawing.Color.Purple;
            this.currentUserTitleLabel.Location = new System.Drawing.Point(648, 46);
            this.currentUserTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUserTitleLabel.Name = "currentUserTitleLabel";
            this.currentUserTitleLabel.Size = new System.Drawing.Size(168, 20);
            this.currentUserTitleLabel.TabIndex = 26;
            this.currentUserTitleLabel.Text = "Текущий пользователь: ";
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.Font = new System.Drawing.Font("Arial Narrow", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserLabel.Location = new System.Drawing.Point(648, 64);
            this.currentUserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.Size = new System.Drawing.Size(171, 20);
            this.currentUserLabel.TabIndex = 27;
            this.currentUserLabel.Text = "Пользователь не выбран";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(497, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 85);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(886, 665);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.currentUserTitleLabel);
            this.Controls.Add(this.changeUserButton);
            this.Controls.Add(this.lookForMailsButton);
            this.Controls.Add(this.seeArchiveButton);
            this.Controls.Add(this.cityButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.checkBoxCity);
            this.Controls.Add(this.checkBoxInterval);
            this.Controls.Add(this.numericAgeSecond);
            this.Controls.Add(this.ageLabelPart2);
            this.Controls.Add(this.ageLabelPart1);
            this.Controls.Add(this.numericAgeFirst);
            this.Controls.Add(this.checkBoxAge);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.emptyTableLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createMailButton);
            this.Controls.Add(this.archiveButton);
            this.Controls.Add(this.editProfileButton);
            this.Controls.Add(this.newProfileButton);
            this.Controls.Add(this.dataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = " Бюро знакомств";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAgeSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button newProfileButton;
        private System.Windows.Forms.Button editProfileButton;
        private System.Windows.Forms.Button archiveButton;
        private System.Windows.Forms.Button createMailButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emptyTableLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.CheckBox checkBoxAge;
        private System.Windows.Forms.NumericUpDown numericAgeFirst;
        private System.Windows.Forms.Label ageLabelPart1;
        private System.Windows.Forms.Label ageLabelPart2;
        private System.Windows.Forms.NumericUpDown numericAgeSecond;
        private System.Windows.Forms.CheckBox checkBoxInterval;
        private System.Windows.Forms.CheckBox checkBoxCity;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button cityButton;
        private System.Windows.Forms.Button seeArchiveButton;
        private System.Windows.Forms.Button lookForMailsButton;
        private System.Windows.Forms.Button changeUserButton;
        private System.Windows.Forms.Label currentUserTitleLabel;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

