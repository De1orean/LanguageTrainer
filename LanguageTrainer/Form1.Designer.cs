namespace LanguageTrainer
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mainMenuTabPage = new System.Windows.Forms.TabPage();
            this.exitProgramButton = new System.Windows.Forms.Button();
            this.changeListButton = new System.Windows.Forms.Button();
            this.deleteListButton = new System.Windows.Forms.Button();
            this.createListButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.wordsOfSelectedListBox = new System.Windows.Forms.ListBox();
            this.listsBox = new System.Windows.Forms.ListBox();
            this.createListTabPage = new System.Windows.Forms.TabPage();
            this.cancelNewListButton = new System.Windows.Forms.Button();
            this.saveNewListButton = new System.Windows.Forms.Button();
            this.deleteWordInNewListButton = new System.Windows.Forms.Button();
            this.addWordInNewListButton = new System.Windows.Forms.Button();
            this.secondLanguageNewListWordTextBox = new System.Windows.Forms.TextBox();
            this.firstLanguageNewListWordTextBox = new System.Windows.Forms.TextBox();
            this.newListNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondLanguageNewListBox = new System.Windows.Forms.ListBox();
            this.FirstLanguageNewListBox = new System.Windows.Forms.ListBox();
            this.changeListTabPage = new System.Windows.Forms.TabPage();
            this.cancelChangeListButton = new System.Windows.Forms.Button();
            this.saveChangedListButton = new System.Windows.Forms.Button();
            this.deleteWordInChangedListButton = new System.Windows.Forms.Button();
            this.addWordInChangedListButton = new System.Windows.Forms.Button();
            this.secondLanguageChangeListWordTextBox = new System.Windows.Forms.TextBox();
            this.firstLanguageChangeListWordTextBox = new System.Windows.Forms.TextBox();
            this.changeListNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondLanguageChangeListBox = new System.Windows.Forms.ListBox();
            this.FirstLanguageChangeListBox = new System.Windows.Forms.ListBox();
            this.workingProcessTabPage = new System.Windows.Forms.TabPage();
            this.jumpOnNextWordButton = new System.Windows.Forms.Button();
            this.translateOfQuestWordTextBox = new System.Windows.Forms.TextBox();
            this.questWordLabel = new System.Windows.Forms.Label();
            this.countOfWordLeftLabel = new System.Windows.Forms.Label();
            this.goBackToMenuButton = new System.Windows.Forms.Button();
            this.collectionOfInformationTabPage = new System.Windows.Forms.TabPage();
            this.restartButton = new System.Windows.Forms.Button();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.accuracyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.mainMenuTabPage.SuspendLayout();
            this.createListTabPage.SuspendLayout();
            this.changeListTabPage.SuspendLayout();
            this.workingProcessTabPage.SuspendLayout();
            this.collectionOfInformationTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.mainMenuTabPage);
            this.tabControl.Controls.Add(this.createListTabPage);
            this.tabControl.Controls.Add(this.changeListTabPage);
            this.tabControl.Controls.Add(this.workingProcessTabPage);
            this.tabControl.Controls.Add(this.collectionOfInformationTabPage);
            this.tabControl.Location = new System.Drawing.Point(0, -25);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(669, 505);
            this.tabControl.TabIndex = 0;
            // 
            // mainMenuTabPage
            // 
            this.mainMenuTabPage.Controls.Add(this.exitProgramButton);
            this.mainMenuTabPage.Controls.Add(this.changeListButton);
            this.mainMenuTabPage.Controls.Add(this.deleteListButton);
            this.mainMenuTabPage.Controls.Add(this.createListButton);
            this.mainMenuTabPage.Controls.Add(this.startButton);
            this.mainMenuTabPage.Controls.Add(this.wordsOfSelectedListBox);
            this.mainMenuTabPage.Controls.Add(this.listsBox);
            this.mainMenuTabPage.Location = new System.Drawing.Point(4, 22);
            this.mainMenuTabPage.Name = "mainMenuTabPage";
            this.mainMenuTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainMenuTabPage.Size = new System.Drawing.Size(661, 454);
            this.mainMenuTabPage.TabIndex = 0;
            this.mainMenuTabPage.Text = "Main Menu";
            this.mainMenuTabPage.UseVisualStyleBackColor = true;
            // 
            // exitProgramButton
            // 
            this.exitProgramButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.exitProgramButton.FlatAppearance.BorderSize = 0;
            this.exitProgramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitProgramButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitProgramButton.Location = new System.Drawing.Point(272, 303);
            this.exitProgramButton.Name = "exitProgramButton";
            this.exitProgramButton.Size = new System.Drawing.Size(116, 35);
            this.exitProgramButton.TabIndex = 6;
            this.exitProgramButton.Text = "Выйти";
            this.exitProgramButton.UseVisualStyleBackColor = false;
            this.exitProgramButton.Click += new System.EventHandler(this.ExitProgramButton_Click);
            // 
            // changeListButton
            // 
            this.changeListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.changeListButton.FlatAppearance.BorderSize = 0;
            this.changeListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeListButton.Location = new System.Drawing.Point(272, 221);
            this.changeListButton.Name = "changeListButton";
            this.changeListButton.Size = new System.Drawing.Size(116, 35);
            this.changeListButton.TabIndex = 5;
            this.changeListButton.Text = "Изменить";
            this.changeListButton.UseVisualStyleBackColor = false;
            this.changeListButton.Click += new System.EventHandler(this.ChangeListButton_Click);
            // 
            // deleteListButton
            // 
            this.deleteListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.deleteListButton.FlatAppearance.BorderSize = 0;
            this.deleteListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteListButton.Location = new System.Drawing.Point(272, 262);
            this.deleteListButton.Name = "deleteListButton";
            this.deleteListButton.Size = new System.Drawing.Size(116, 35);
            this.deleteListButton.TabIndex = 4;
            this.deleteListButton.Text = "Удалить";
            this.deleteListButton.UseVisualStyleBackColor = false;
            this.deleteListButton.Click += new System.EventHandler(this.DeleteListButton_Click);
            // 
            // createListButton
            // 
            this.createListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.createListButton.FlatAppearance.BorderSize = 0;
            this.createListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createListButton.Location = new System.Drawing.Point(272, 180);
            this.createListButton.Name = "createListButton";
            this.createListButton.Size = new System.Drawing.Size(116, 35);
            this.createListButton.TabIndex = 3;
            this.createListButton.Text = "Создать";
            this.createListButton.UseVisualStyleBackColor = false;
            this.createListButton.Click += new System.EventHandler(this.CreateListButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(272, 139);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(116, 35);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Начать";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // wordsOfSelectedListBox
            // 
            this.wordsOfSelectedListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.wordsOfSelectedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordsOfSelectedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordsOfSelectedListBox.FormattingEnabled = true;
            this.wordsOfSelectedListBox.ItemHeight = 18;
            this.wordsOfSelectedListBox.Location = new System.Drawing.Point(485, 6);
            this.wordsOfSelectedListBox.Name = "wordsOfSelectedListBox";
            this.wordsOfSelectedListBox.Size = new System.Drawing.Size(170, 450);
            this.wordsOfSelectedListBox.TabIndex = 1;
            this.wordsOfSelectedListBox.SelectedIndexChanged += new System.EventHandler(this.WordsOfSelectedListBox_SelectedIndexChanged);
            // 
            // listsBox
            // 
            this.listsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.listsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listsBox.FormattingEnabled = true;
            this.listsBox.ItemHeight = 18;
            this.listsBox.Location = new System.Drawing.Point(8, 6);
            this.listsBox.Name = "listsBox";
            this.listsBox.Size = new System.Drawing.Size(170, 450);
            this.listsBox.TabIndex = 0;
            this.listsBox.SelectedIndexChanged += new System.EventHandler(this.ListsBox_SelectedIndexChanged);
            // 
            // createListTabPage
            // 
            this.createListTabPage.Controls.Add(this.label4);
            this.createListTabPage.Controls.Add(this.label3);
            this.createListTabPage.Controls.Add(this.label2);
            this.createListTabPage.Controls.Add(this.cancelNewListButton);
            this.createListTabPage.Controls.Add(this.saveNewListButton);
            this.createListTabPage.Controls.Add(this.deleteWordInNewListButton);
            this.createListTabPage.Controls.Add(this.addWordInNewListButton);
            this.createListTabPage.Controls.Add(this.secondLanguageNewListWordTextBox);
            this.createListTabPage.Controls.Add(this.firstLanguageNewListWordTextBox);
            this.createListTabPage.Controls.Add(this.newListNameTextBox);
            this.createListTabPage.Controls.Add(this.SecondLanguageNewListBox);
            this.createListTabPage.Controls.Add(this.FirstLanguageNewListBox);
            this.createListTabPage.Location = new System.Drawing.Point(4, 22);
            this.createListTabPage.Name = "createListTabPage";
            this.createListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.createListTabPage.Size = new System.Drawing.Size(661, 454);
            this.createListTabPage.TabIndex = 1;
            this.createListTabPage.Text = "Add List";
            this.createListTabPage.UseVisualStyleBackColor = true;
            // 
            // cancelNewListButton
            // 
            this.cancelNewListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cancelNewListButton.FlatAppearance.BorderSize = 0;
            this.cancelNewListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelNewListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelNewListButton.Location = new System.Drawing.Point(410, 416);
            this.cancelNewListButton.Name = "cancelNewListButton";
            this.cancelNewListButton.Size = new System.Drawing.Size(104, 32);
            this.cancelNewListButton.TabIndex = 8;
            this.cancelNewListButton.Text = "Отмена";
            this.cancelNewListButton.UseVisualStyleBackColor = false;
            this.cancelNewListButton.Click += new System.EventHandler(this.CancelNewListButton_Click);
            // 
            // saveNewListButton
            // 
            this.saveNewListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.saveNewListButton.FlatAppearance.BorderSize = 0;
            this.saveNewListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNewListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveNewListButton.Location = new System.Drawing.Point(370, 370);
            this.saveNewListButton.Name = "saveNewListButton";
            this.saveNewListButton.Size = new System.Drawing.Size(168, 32);
            this.saveNewListButton.TabIndex = 7;
            this.saveNewListButton.Text = "Сохранить и выйти";
            this.saveNewListButton.UseVisualStyleBackColor = false;
            this.saveNewListButton.Click += new System.EventHandler(this.SaveNewListButton_Click);
            // 
            // deleteWordInNewListButton
            // 
            this.deleteWordInNewListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.deleteWordInNewListButton.FlatAppearance.BorderSize = 0;
            this.deleteWordInNewListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteWordInNewListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteWordInNewListButton.Location = new System.Drawing.Point(407, 166);
            this.deleteWordInNewListButton.Name = "deleteWordInNewListButton";
            this.deleteWordInNewListButton.Size = new System.Drawing.Size(104, 32);
            this.deleteWordInNewListButton.TabIndex = 6;
            this.deleteWordInNewListButton.Text = "Удалить";
            this.deleteWordInNewListButton.UseVisualStyleBackColor = false;
            this.deleteWordInNewListButton.Click += new System.EventHandler(this.DeleteWordInNewListButton_Click);
            // 
            // addWordInNewListButton
            // 
            this.addWordInNewListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.addWordInNewListButton.FlatAppearance.BorderSize = 0;
            this.addWordInNewListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWordInNewListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWordInNewListButton.Location = new System.Drawing.Point(407, 128);
            this.addWordInNewListButton.Name = "addWordInNewListButton";
            this.addWordInNewListButton.Size = new System.Drawing.Size(104, 32);
            this.addWordInNewListButton.TabIndex = 5;
            this.addWordInNewListButton.Text = "Добавить";
            this.addWordInNewListButton.UseVisualStyleBackColor = false;
            this.addWordInNewListButton.Click += new System.EventHandler(this.AddWordInNewListButton_Click);
            // 
            // secondLanguageNewListWordTextBox
            // 
            this.secondLanguageNewListWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondLanguageNewListWordTextBox.Location = new System.Drawing.Point(482, 75);
            this.secondLanguageNewListWordTextBox.Name = "secondLanguageNewListWordTextBox";
            this.secondLanguageNewListWordTextBox.Size = new System.Drawing.Size(173, 21);
            this.secondLanguageNewListWordTextBox.TabIndex = 4;
            // 
            // firstLanguageNewListWordTextBox
            // 
            this.firstLanguageNewListWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstLanguageNewListWordTextBox.Location = new System.Drawing.Point(272, 75);
            this.firstLanguageNewListWordTextBox.Name = "firstLanguageNewListWordTextBox";
            this.firstLanguageNewListWordTextBox.Size = new System.Drawing.Size(177, 21);
            this.firstLanguageNewListWordTextBox.TabIndex = 3;
            // 
            // newListNameTextBox
            // 
            this.newListNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newListNameTextBox.Location = new System.Drawing.Point(370, 25);
            this.newListNameTextBox.Name = "newListNameTextBox";
            this.newListNameTextBox.Size = new System.Drawing.Size(168, 21);
            this.newListNameTextBox.TabIndex = 2;
            // 
            // SecondLanguageNewListBox
            // 
            this.SecondLanguageNewListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.SecondLanguageNewListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondLanguageNewListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondLanguageNewListBox.FormattingEnabled = true;
            this.SecondLanguageNewListBox.ItemHeight = 16;
            this.SecondLanguageNewListBox.Location = new System.Drawing.Point(134, 8);
            this.SecondLanguageNewListBox.Name = "SecondLanguageNewListBox";
            this.SecondLanguageNewListBox.Size = new System.Drawing.Size(120, 448);
            this.SecondLanguageNewListBox.TabIndex = 1;
            this.SecondLanguageNewListBox.SelectedIndexChanged += new System.EventHandler(this.SecondLanguageNewListBox_SelectedIndexChanged);
            // 
            // FirstLanguageNewListBox
            // 
            this.FirstLanguageNewListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.FirstLanguageNewListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstLanguageNewListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstLanguageNewListBox.FormattingEnabled = true;
            this.FirstLanguageNewListBox.ItemHeight = 16;
            this.FirstLanguageNewListBox.Location = new System.Drawing.Point(8, 8);
            this.FirstLanguageNewListBox.Name = "FirstLanguageNewListBox";
            this.FirstLanguageNewListBox.Size = new System.Drawing.Size(120, 448);
            this.FirstLanguageNewListBox.TabIndex = 0;
            this.FirstLanguageNewListBox.SelectedIndexChanged += new System.EventHandler(this.FirstLanguageNewListBox_SelectedIndexChanged);
            // 
            // changeListTabPage
            // 
            this.changeListTabPage.Controls.Add(this.label5);
            this.changeListTabPage.Controls.Add(this.label6);
            this.changeListTabPage.Controls.Add(this.label7);
            this.changeListTabPage.Controls.Add(this.cancelChangeListButton);
            this.changeListTabPage.Controls.Add(this.saveChangedListButton);
            this.changeListTabPage.Controls.Add(this.deleteWordInChangedListButton);
            this.changeListTabPage.Controls.Add(this.addWordInChangedListButton);
            this.changeListTabPage.Controls.Add(this.secondLanguageChangeListWordTextBox);
            this.changeListTabPage.Controls.Add(this.firstLanguageChangeListWordTextBox);
            this.changeListTabPage.Controls.Add(this.changeListNameTextBox);
            this.changeListTabPage.Controls.Add(this.SecondLanguageChangeListBox);
            this.changeListTabPage.Controls.Add(this.FirstLanguageChangeListBox);
            this.changeListTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeListTabPage.Location = new System.Drawing.Point(4, 22);
            this.changeListTabPage.Name = "changeListTabPage";
            this.changeListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.changeListTabPage.Size = new System.Drawing.Size(661, 454);
            this.changeListTabPage.TabIndex = 2;
            this.changeListTabPage.Text = "Change List";
            this.changeListTabPage.UseVisualStyleBackColor = true;
            // 
            // cancelChangeListButton
            // 
            this.cancelChangeListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cancelChangeListButton.FlatAppearance.BorderSize = 0;
            this.cancelChangeListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelChangeListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelChangeListButton.Location = new System.Drawing.Point(410, 416);
            this.cancelChangeListButton.Name = "cancelChangeListButton";
            this.cancelChangeListButton.Size = new System.Drawing.Size(104, 32);
            this.cancelChangeListButton.TabIndex = 17;
            this.cancelChangeListButton.Text = "Отмена";
            this.cancelChangeListButton.UseVisualStyleBackColor = false;
            this.cancelChangeListButton.Click += new System.EventHandler(this.CancelChangeListButton_Click);
            // 
            // saveChangedListButton
            // 
            this.saveChangedListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.saveChangedListButton.FlatAppearance.BorderSize = 0;
            this.saveChangedListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveChangedListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChangedListButton.Location = new System.Drawing.Point(370, 370);
            this.saveChangedListButton.Name = "saveChangedListButton";
            this.saveChangedListButton.Size = new System.Drawing.Size(168, 32);
            this.saveChangedListButton.TabIndex = 16;
            this.saveChangedListButton.Text = "Сохранить и выйти";
            this.saveChangedListButton.UseVisualStyleBackColor = false;
            this.saveChangedListButton.Click += new System.EventHandler(this.SaveChangedListButton_Click);
            // 
            // deleteWordInChangedListButton
            // 
            this.deleteWordInChangedListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.deleteWordInChangedListButton.FlatAppearance.BorderSize = 0;
            this.deleteWordInChangedListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteWordInChangedListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteWordInChangedListButton.Location = new System.Drawing.Point(407, 166);
            this.deleteWordInChangedListButton.Name = "deleteWordInChangedListButton";
            this.deleteWordInChangedListButton.Size = new System.Drawing.Size(104, 32);
            this.deleteWordInChangedListButton.TabIndex = 15;
            this.deleteWordInChangedListButton.Text = "Удалить";
            this.deleteWordInChangedListButton.UseVisualStyleBackColor = false;
            this.deleteWordInChangedListButton.Click += new System.EventHandler(this.DeleteWordInChangedListButton_Click);
            // 
            // addWordInChangedListButton
            // 
            this.addWordInChangedListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.addWordInChangedListButton.FlatAppearance.BorderSize = 0;
            this.addWordInChangedListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addWordInChangedListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWordInChangedListButton.Location = new System.Drawing.Point(407, 128);
            this.addWordInChangedListButton.Name = "addWordInChangedListButton";
            this.addWordInChangedListButton.Size = new System.Drawing.Size(104, 32);
            this.addWordInChangedListButton.TabIndex = 14;
            this.addWordInChangedListButton.Text = "Добавить";
            this.addWordInChangedListButton.UseVisualStyleBackColor = false;
            this.addWordInChangedListButton.Click += new System.EventHandler(this.AddWordInChangedListButton_Click);
            // 
            // secondLanguageChangeListWordTextBox
            // 
            this.secondLanguageChangeListWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondLanguageChangeListWordTextBox.Location = new System.Drawing.Point(482, 75);
            this.secondLanguageChangeListWordTextBox.Name = "secondLanguageChangeListWordTextBox";
            this.secondLanguageChangeListWordTextBox.Size = new System.Drawing.Size(173, 21);
            this.secondLanguageChangeListWordTextBox.TabIndex = 13;
            // 
            // firstLanguageChangeListWordTextBox
            // 
            this.firstLanguageChangeListWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstLanguageChangeListWordTextBox.Location = new System.Drawing.Point(272, 75);
            this.firstLanguageChangeListWordTextBox.Name = "firstLanguageChangeListWordTextBox";
            this.firstLanguageChangeListWordTextBox.Size = new System.Drawing.Size(177, 21);
            this.firstLanguageChangeListWordTextBox.TabIndex = 12;
            // 
            // changeListNameTextBox
            // 
            this.changeListNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeListNameTextBox.Location = new System.Drawing.Point(370, 25);
            this.changeListNameTextBox.Name = "changeListNameTextBox";
            this.changeListNameTextBox.Size = new System.Drawing.Size(168, 21);
            this.changeListNameTextBox.TabIndex = 11;
            // 
            // SecondLanguageChangeListBox
            // 
            this.SecondLanguageChangeListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.SecondLanguageChangeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondLanguageChangeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondLanguageChangeListBox.FormattingEnabled = true;
            this.SecondLanguageChangeListBox.ItemHeight = 16;
            this.SecondLanguageChangeListBox.Location = new System.Drawing.Point(134, 8);
            this.SecondLanguageChangeListBox.Name = "SecondLanguageChangeListBox";
            this.SecondLanguageChangeListBox.Size = new System.Drawing.Size(120, 448);
            this.SecondLanguageChangeListBox.TabIndex = 10;
            this.SecondLanguageChangeListBox.SelectedIndexChanged += new System.EventHandler(this.SecondLanguageChangeListBox_SelectedIndexChanged);
            // 
            // FirstLanguageChangeListBox
            // 
            this.FirstLanguageChangeListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.FirstLanguageChangeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstLanguageChangeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstLanguageChangeListBox.FormattingEnabled = true;
            this.FirstLanguageChangeListBox.ItemHeight = 16;
            this.FirstLanguageChangeListBox.Location = new System.Drawing.Point(8, 8);
            this.FirstLanguageChangeListBox.Name = "FirstLanguageChangeListBox";
            this.FirstLanguageChangeListBox.Size = new System.Drawing.Size(120, 448);
            this.FirstLanguageChangeListBox.TabIndex = 9;
            this.FirstLanguageChangeListBox.SelectedIndexChanged += new System.EventHandler(this.FirstLanguageChangeListBox_SelectedIndexChanged);
            // 
            // workingProcessTabPage
            // 
            this.workingProcessTabPage.Controls.Add(this.jumpOnNextWordButton);
            this.workingProcessTabPage.Controls.Add(this.translateOfQuestWordTextBox);
            this.workingProcessTabPage.Controls.Add(this.questWordLabel);
            this.workingProcessTabPage.Controls.Add(this.countOfWordLeftLabel);
            this.workingProcessTabPage.Controls.Add(this.goBackToMenuButton);
            this.workingProcessTabPage.Location = new System.Drawing.Point(4, 22);
            this.workingProcessTabPage.Name = "workingProcessTabPage";
            this.workingProcessTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.workingProcessTabPage.Size = new System.Drawing.Size(661, 454);
            this.workingProcessTabPage.TabIndex = 3;
            this.workingProcessTabPage.Text = "Working Process";
            this.workingProcessTabPage.UseVisualStyleBackColor = true;
            // 
            // jumpOnNextWordButton
            // 
            this.jumpOnNextWordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.jumpOnNextWordButton.FlatAppearance.BorderSize = 0;
            this.jumpOnNextWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jumpOnNextWordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jumpOnNextWordButton.Location = new System.Drawing.Point(278, 242);
            this.jumpOnNextWordButton.Name = "jumpOnNextWordButton";
            this.jumpOnNextWordButton.Size = new System.Drawing.Size(104, 32);
            this.jumpOnNextWordButton.TabIndex = 4;
            this.jumpOnNextWordButton.Text = "Проверить";
            this.jumpOnNextWordButton.UseVisualStyleBackColor = false;
            this.jumpOnNextWordButton.Click += new System.EventHandler(this.JumpOnNextWordButton_Click);
            // 
            // translateOfQuestWordTextBox
            // 
            this.translateOfQuestWordTextBox.Location = new System.Drawing.Point(240, 211);
            this.translateOfQuestWordTextBox.Name = "translateOfQuestWordTextBox";
            this.translateOfQuestWordTextBox.Size = new System.Drawing.Size(181, 20);
            this.translateOfQuestWordTextBox.TabIndex = 3;
            // 
            // questWordLabel
            // 
            this.questWordLabel.AutoSize = true;
            this.questWordLabel.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questWordLabel.Location = new System.Drawing.Point(239, 92);
            this.questWordLabel.Name = "questWordLabel";
            this.questWordLabel.Size = new System.Drawing.Size(234, 80);
            this.questWordLabel.TabIndex = 2;
            this.questWordLabel.Text = "Слово";
            // 
            // countOfWordLeftLabel
            // 
            this.countOfWordLeftLabel.AutoSize = true;
            this.countOfWordLeftLabel.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countOfWordLeftLabel.Location = new System.Drawing.Point(8, 18);
            this.countOfWordLeftLabel.Name = "countOfWordLeftLabel";
            this.countOfWordLeftLabel.Size = new System.Drawing.Size(485, 44);
            this.countOfWordLeftLabel.TabIndex = 1;
            this.countOfWordLeftLabel.Text = "Слов всего/слов осталось";
            // 
            // goBackToMenuButton
            // 
            this.goBackToMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.goBackToMenuButton.FlatAppearance.BorderSize = 0;
            this.goBackToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackToMenuButton.Location = new System.Drawing.Point(8, 425);
            this.goBackToMenuButton.Name = "goBackToMenuButton";
            this.goBackToMenuButton.Size = new System.Drawing.Size(75, 23);
            this.goBackToMenuButton.TabIndex = 0;
            this.goBackToMenuButton.Text = "В меню";
            this.goBackToMenuButton.UseVisualStyleBackColor = false;
            this.goBackToMenuButton.Click += new System.EventHandler(this.GoBackToMenuButton_Click);
            // 
            // collectionOfInformationTabPage
            // 
            this.collectionOfInformationTabPage.Controls.Add(this.restartButton);
            this.collectionOfInformationTabPage.Controls.Add(this.backToMenuButton);
            this.collectionOfInformationTabPage.Controls.Add(this.accuracyLabel);
            this.collectionOfInformationTabPage.Controls.Add(this.label1);
            this.collectionOfInformationTabPage.Location = new System.Drawing.Point(4, 22);
            this.collectionOfInformationTabPage.Name = "collectionOfInformationTabPage";
            this.collectionOfInformationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.collectionOfInformationTabPage.Size = new System.Drawing.Size(661, 479);
            this.collectionOfInformationTabPage.TabIndex = 4;
            this.collectionOfInformationTabPage.Text = "Collection of information";
            this.collectionOfInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.restartButton.FlatAppearance.BorderSize = 0;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.restartButton.Location = new System.Drawing.Point(278, 308);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(104, 32);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "C начала";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.backToMenuButton.FlatAppearance.BorderSize = 0;
            this.backToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.backToMenuButton.Location = new System.Drawing.Point(278, 270);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(104, 32);
            this.backToMenuButton.TabIndex = 2;
            this.backToMenuButton.Text = "В меню";
            this.backToMenuButton.UseVisualStyleBackColor = false;
            this.backToMenuButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.AutoSize = true;
            this.accuracyLabel.Font = new System.Drawing.Font("Arial Narrow", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracyLabel.Location = new System.Drawing.Point(233, 171);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(495, 94);
            this.accuracyLabel.TabIndex = 1;
            this.accuracyLabel.Text = "В процентах %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(217, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваша точность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(269, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Слово для первого списка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(479, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Слово для второго списка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(392, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Название списка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(392, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Название списка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(479, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Слово для второго списка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(269, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Слово для первого списка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 482);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.mainMenuTabPage.ResumeLayout(false);
            this.createListTabPage.ResumeLayout(false);
            this.createListTabPage.PerformLayout();
            this.changeListTabPage.ResumeLayout(false);
            this.changeListTabPage.PerformLayout();
            this.workingProcessTabPage.ResumeLayout(false);
            this.workingProcessTabPage.PerformLayout();
            this.collectionOfInformationTabPage.ResumeLayout(false);
            this.collectionOfInformationTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage mainMenuTabPage;
        private System.Windows.Forms.Button exitProgramButton;
        private System.Windows.Forms.Button changeListButton;
        private System.Windows.Forms.Button deleteListButton;
        private System.Windows.Forms.Button createListButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox wordsOfSelectedListBox;
        private System.Windows.Forms.ListBox listsBox;
        private System.Windows.Forms.TabPage createListTabPage;
        private System.Windows.Forms.ListBox SecondLanguageNewListBox;
        private System.Windows.Forms.ListBox FirstLanguageNewListBox;
        private System.Windows.Forms.Button cancelNewListButton;
        private System.Windows.Forms.Button saveNewListButton;
        private System.Windows.Forms.Button deleteWordInNewListButton;
        private System.Windows.Forms.Button addWordInNewListButton;
        private System.Windows.Forms.TextBox secondLanguageNewListWordTextBox;
        private System.Windows.Forms.TextBox firstLanguageNewListWordTextBox;
        private System.Windows.Forms.TextBox newListNameTextBox;
        private System.Windows.Forms.TabPage changeListTabPage;
        private System.Windows.Forms.Button cancelChangeListButton;
        private System.Windows.Forms.Button saveChangedListButton;
        private System.Windows.Forms.Button deleteWordInChangedListButton;
        private System.Windows.Forms.Button addWordInChangedListButton;
        private System.Windows.Forms.TextBox secondLanguageChangeListWordTextBox;
        private System.Windows.Forms.TextBox firstLanguageChangeListWordTextBox;
        private System.Windows.Forms.TextBox changeListNameTextBox;
        private System.Windows.Forms.ListBox SecondLanguageChangeListBox;
        private System.Windows.Forms.ListBox FirstLanguageChangeListBox;
        private System.Windows.Forms.TabPage workingProcessTabPage;
        private System.Windows.Forms.Button goBackToMenuButton;
        private System.Windows.Forms.Button jumpOnNextWordButton;
        private System.Windows.Forms.TextBox translateOfQuestWordTextBox;
        private System.Windows.Forms.Label questWordLabel;
        private System.Windows.Forms.Label countOfWordLeftLabel;
        private System.Windows.Forms.TabPage collectionOfInformationTabPage;
        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Label accuracyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

