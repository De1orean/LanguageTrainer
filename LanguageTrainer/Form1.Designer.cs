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
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(669, 480);
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
            this.exitProgramButton.Location = new System.Drawing.Point(298, 248);
            this.exitProgramButton.Name = "exitProgramButton";
            this.exitProgramButton.Size = new System.Drawing.Size(75, 23);
            this.exitProgramButton.TabIndex = 6;
            this.exitProgramButton.Text = "Выйти";
            this.exitProgramButton.UseVisualStyleBackColor = true;
            this.exitProgramButton.Click += new System.EventHandler(this.ExitProgramButton_Click);
            // 
            // changeListButton
            // 
            this.changeListButton.Location = new System.Drawing.Point(298, 190);
            this.changeListButton.Name = "changeListButton";
            this.changeListButton.Size = new System.Drawing.Size(75, 23);
            this.changeListButton.TabIndex = 5;
            this.changeListButton.Text = "Изменить";
            this.changeListButton.UseVisualStyleBackColor = true;
            this.changeListButton.Click += new System.EventHandler(this.ChangeListButton_Click);
            // 
            // deleteListButton
            // 
            this.deleteListButton.Location = new System.Drawing.Point(298, 219);
            this.deleteListButton.Name = "deleteListButton";
            this.deleteListButton.Size = new System.Drawing.Size(75, 23);
            this.deleteListButton.TabIndex = 4;
            this.deleteListButton.Text = "Удалить";
            this.deleteListButton.UseVisualStyleBackColor = true;
            this.deleteListButton.Click += new System.EventHandler(this.DeleteListButton_Click);
            // 
            // createListButton
            // 
            this.createListButton.Location = new System.Drawing.Point(298, 161);
            this.createListButton.Name = "createListButton";
            this.createListButton.Size = new System.Drawing.Size(75, 23);
            this.createListButton.TabIndex = 3;
            this.createListButton.Text = "Создать список";
            this.createListButton.UseVisualStyleBackColor = true;
            this.createListButton.Click += new System.EventHandler(this.CreateListButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(298, 132);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "На4ать";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // wordsOfSelectedListBox
            // 
            this.wordsOfSelectedListBox.FormattingEnabled = true;
            this.wordsOfSelectedListBox.Location = new System.Drawing.Point(485, 6);
            this.wordsOfSelectedListBox.Name = "wordsOfSelectedListBox";
            this.wordsOfSelectedListBox.Size = new System.Drawing.Size(170, 433);
            this.wordsOfSelectedListBox.TabIndex = 1;
            this.wordsOfSelectedListBox.SelectedIndexChanged += new System.EventHandler(this.WordsOfSelectedListBox_SelectedIndexChanged);
            // 
            // listsBox
            // 
            this.listsBox.FormattingEnabled = true;
            this.listsBox.Location = new System.Drawing.Point(8, 6);
            this.listsBox.Name = "listsBox";
            this.listsBox.Size = new System.Drawing.Size(170, 433);
            this.listsBox.TabIndex = 0;
            this.listsBox.SelectedIndexChanged += new System.EventHandler(this.ListsBox_SelectedIndexChanged);
            // 
            // createListTabPage
            // 
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
            this.cancelNewListButton.Location = new System.Drawing.Point(429, 390);
            this.cancelNewListButton.Name = "cancelNewListButton";
            this.cancelNewListButton.Size = new System.Drawing.Size(75, 23);
            this.cancelNewListButton.TabIndex = 8;
            this.cancelNewListButton.Text = "отмена";
            this.cancelNewListButton.UseVisualStyleBackColor = true;
            this.cancelNewListButton.Click += new System.EventHandler(this.CancelNewListButton_Click);
            // 
            // saveNewListButton
            // 
            this.saveNewListButton.Location = new System.Drawing.Point(396, 361);
            this.saveNewListButton.Name = "saveNewListButton";
            this.saveNewListButton.Size = new System.Drawing.Size(139, 23);
            this.saveNewListButton.TabIndex = 7;
            this.saveNewListButton.Text = "Сохранить и выйти";
            this.saveNewListButton.UseVisualStyleBackColor = true;
            this.saveNewListButton.Click += new System.EventHandler(this.SaveNewListButton_Click);
            // 
            // deleteWordInNewListButton
            // 
            this.deleteWordInNewListButton.Location = new System.Drawing.Point(429, 157);
            this.deleteWordInNewListButton.Name = "deleteWordInNewListButton";
            this.deleteWordInNewListButton.Size = new System.Drawing.Size(75, 23);
            this.deleteWordInNewListButton.TabIndex = 6;
            this.deleteWordInNewListButton.Text = "Удалить";
            this.deleteWordInNewListButton.UseVisualStyleBackColor = true;
            this.deleteWordInNewListButton.Click += new System.EventHandler(this.DeleteWordInNewListButton_Click);
            // 
            // addWordInNewListButton
            // 
            this.addWordInNewListButton.Location = new System.Drawing.Point(429, 128);
            this.addWordInNewListButton.Name = "addWordInNewListButton";
            this.addWordInNewListButton.Size = new System.Drawing.Size(75, 23);
            this.addWordInNewListButton.TabIndex = 5;
            this.addWordInNewListButton.Text = "Добавить";
            this.addWordInNewListButton.UseVisualStyleBackColor = true;
            this.addWordInNewListButton.Click += new System.EventHandler(this.AddWordInNewListButton_Click);
            // 
            // secondLanguageNewListWordTextBox
            // 
            this.secondLanguageNewListWordTextBox.Location = new System.Drawing.Point(475, 75);
            this.secondLanguageNewListWordTextBox.Name = "secondLanguageNewListWordTextBox";
            this.secondLanguageNewListWordTextBox.Size = new System.Drawing.Size(166, 20);
            this.secondLanguageNewListWordTextBox.TabIndex = 4;
            // 
            // firstLanguageNewListWordTextBox
            // 
            this.firstLanguageNewListWordTextBox.Location = new System.Drawing.Point(304, 75);
            this.firstLanguageNewListWordTextBox.Name = "firstLanguageNewListWordTextBox";
            this.firstLanguageNewListWordTextBox.Size = new System.Drawing.Size(145, 20);
            this.firstLanguageNewListWordTextBox.TabIndex = 3;
            // 
            // newListNameTextBox
            // 
            this.newListNameTextBox.Location = new System.Drawing.Point(396, 21);
            this.newListNameTextBox.Name = "newListNameTextBox";
            this.newListNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.newListNameTextBox.TabIndex = 2;
            // 
            // SecondLanguageNewListBox
            // 
            this.SecondLanguageNewListBox.FormattingEnabled = true;
            this.SecondLanguageNewListBox.Location = new System.Drawing.Point(134, 8);
            this.SecondLanguageNewListBox.Name = "SecondLanguageNewListBox";
            this.SecondLanguageNewListBox.Size = new System.Drawing.Size(120, 433);
            this.SecondLanguageNewListBox.TabIndex = 1;
            this.SecondLanguageNewListBox.SelectedIndexChanged += new System.EventHandler(this.SecondLanguageNewListBox_SelectedIndexChanged);
            // 
            // FirstLanguageNewListBox
            // 
            this.FirstLanguageNewListBox.FormattingEnabled = true;
            this.FirstLanguageNewListBox.Location = new System.Drawing.Point(8, 8);
            this.FirstLanguageNewListBox.Name = "FirstLanguageNewListBox";
            this.FirstLanguageNewListBox.Size = new System.Drawing.Size(120, 433);
            this.FirstLanguageNewListBox.TabIndex = 0;
            this.FirstLanguageNewListBox.SelectedIndexChanged += new System.EventHandler(this.FirstLanguageNewListBox_SelectedIndexChanged);
            // 
            // changeListTabPage
            // 
            this.changeListTabPage.Controls.Add(this.cancelChangeListButton);
            this.changeListTabPage.Controls.Add(this.saveChangedListButton);
            this.changeListTabPage.Controls.Add(this.deleteWordInChangedListButton);
            this.changeListTabPage.Controls.Add(this.addWordInChangedListButton);
            this.changeListTabPage.Controls.Add(this.secondLanguageChangeListWordTextBox);
            this.changeListTabPage.Controls.Add(this.firstLanguageChangeListWordTextBox);
            this.changeListTabPage.Controls.Add(this.changeListNameTextBox);
            this.changeListTabPage.Controls.Add(this.SecondLanguageChangeListBox);
            this.changeListTabPage.Controls.Add(this.FirstLanguageChangeListBox);
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
            this.cancelChangeListButton.Location = new System.Drawing.Point(429, 390);
            this.cancelChangeListButton.Name = "cancelChangeListButton";
            this.cancelChangeListButton.Size = new System.Drawing.Size(75, 23);
            this.cancelChangeListButton.TabIndex = 17;
            this.cancelChangeListButton.Text = "отмена";
            this.cancelChangeListButton.UseVisualStyleBackColor = true;
            this.cancelChangeListButton.Click += new System.EventHandler(this.CancelChangeListButton_Click);
            // 
            // saveChangedListButton
            // 
            this.saveChangedListButton.Location = new System.Drawing.Point(429, 361);
            this.saveChangedListButton.Name = "saveChangedListButton";
            this.saveChangedListButton.Size = new System.Drawing.Size(75, 23);
            this.saveChangedListButton.TabIndex = 16;
            this.saveChangedListButton.Text = "Сохранить";
            this.saveChangedListButton.UseVisualStyleBackColor = true;
            this.saveChangedListButton.Click += new System.EventHandler(this.SaveChangedListButton_Click);
            // 
            // deleteWordInChangedListButton
            // 
            this.deleteWordInChangedListButton.Location = new System.Drawing.Point(429, 157);
            this.deleteWordInChangedListButton.Name = "deleteWordInChangedListButton";
            this.deleteWordInChangedListButton.Size = new System.Drawing.Size(75, 23);
            this.deleteWordInChangedListButton.TabIndex = 15;
            this.deleteWordInChangedListButton.Text = "Удалить";
            this.deleteWordInChangedListButton.UseVisualStyleBackColor = true;
            this.deleteWordInChangedListButton.Click += new System.EventHandler(this.DeleteWordInChangedListButton_Click);
            // 
            // addWordInChangedListButton
            // 
            this.addWordInChangedListButton.Location = new System.Drawing.Point(429, 128);
            this.addWordInChangedListButton.Name = "addWordInChangedListButton";
            this.addWordInChangedListButton.Size = new System.Drawing.Size(75, 23);
            this.addWordInChangedListButton.TabIndex = 14;
            this.addWordInChangedListButton.Text = "Добавить";
            this.addWordInChangedListButton.UseVisualStyleBackColor = true;
            this.addWordInChangedListButton.Click += new System.EventHandler(this.AddWordInChangedListButton_Click);
            // 
            // secondLanguageChangeListWordTextBox
            // 
            this.secondLanguageChangeListWordTextBox.Location = new System.Drawing.Point(475, 75);
            this.secondLanguageChangeListWordTextBox.Name = "secondLanguageChangeListWordTextBox";
            this.secondLanguageChangeListWordTextBox.Size = new System.Drawing.Size(166, 20);
            this.secondLanguageChangeListWordTextBox.TabIndex = 13;
            // 
            // firstLanguageChangeListWordTextBox
            // 
            this.firstLanguageChangeListWordTextBox.Location = new System.Drawing.Point(304, 75);
            this.firstLanguageChangeListWordTextBox.Name = "firstLanguageChangeListWordTextBox";
            this.firstLanguageChangeListWordTextBox.Size = new System.Drawing.Size(145, 20);
            this.firstLanguageChangeListWordTextBox.TabIndex = 12;
            // 
            // changeListNameTextBox
            // 
            this.changeListNameTextBox.Location = new System.Drawing.Point(396, 21);
            this.changeListNameTextBox.Name = "changeListNameTextBox";
            this.changeListNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.changeListNameTextBox.TabIndex = 11;
            // 
            // SecondLanguageChangeListBox
            // 
            this.SecondLanguageChangeListBox.FormattingEnabled = true;
            this.SecondLanguageChangeListBox.Location = new System.Drawing.Point(134, 8);
            this.SecondLanguageChangeListBox.Name = "SecondLanguageChangeListBox";
            this.SecondLanguageChangeListBox.Size = new System.Drawing.Size(120, 433);
            this.SecondLanguageChangeListBox.TabIndex = 10;
            this.SecondLanguageChangeListBox.SelectedIndexChanged += new System.EventHandler(this.SecondLanguageChangeListBox_SelectedIndexChanged);
            // 
            // FirstLanguageChangeListBox
            // 
            this.FirstLanguageChangeListBox.FormattingEnabled = true;
            this.FirstLanguageChangeListBox.Location = new System.Drawing.Point(8, 8);
            this.FirstLanguageChangeListBox.Name = "FirstLanguageChangeListBox";
            this.FirstLanguageChangeListBox.Size = new System.Drawing.Size(120, 433);
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
            this.jumpOnNextWordButton.Location = new System.Drawing.Point(272, 222);
            this.jumpOnNextWordButton.Name = "jumpOnNextWordButton";
            this.jumpOnNextWordButton.Size = new System.Drawing.Size(75, 23);
            this.jumpOnNextWordButton.TabIndex = 4;
            this.jumpOnNextWordButton.Text = "button1";
            this.jumpOnNextWordButton.UseVisualStyleBackColor = true;
            this.jumpOnNextWordButton.Click += new System.EventHandler(this.JumpOnNextWordButton_Click);
            // 
            // translateOfQuestWordTextBox
            // 
            this.translateOfQuestWordTextBox.Location = new System.Drawing.Point(219, 196);
            this.translateOfQuestWordTextBox.Name = "translateOfQuestWordTextBox";
            this.translateOfQuestWordTextBox.Size = new System.Drawing.Size(181, 20);
            this.translateOfQuestWordTextBox.TabIndex = 3;
            // 
            // questWordLabel
            // 
            this.questWordLabel.AutoSize = true;
            this.questWordLabel.Location = new System.Drawing.Point(288, 180);
            this.questWordLabel.Name = "questWordLabel";
            this.questWordLabel.Size = new System.Drawing.Size(38, 13);
            this.questWordLabel.TabIndex = 2;
            this.questWordLabel.Text = "Слово";
            // 
            // countOfWordLeftLabel
            // 
            this.countOfWordLeftLabel.AutoSize = true;
            this.countOfWordLeftLabel.Location = new System.Drawing.Point(8, 18);
            this.countOfWordLeftLabel.Name = "countOfWordLeftLabel";
            this.countOfWordLeftLabel.Size = new System.Drawing.Size(143, 13);
            this.countOfWordLeftLabel.TabIndex = 1;
            this.countOfWordLeftLabel.Text = "Слов всего/слов осталось";
            // 
            // goBackToMenuButton
            // 
            this.goBackToMenuButton.Location = new System.Drawing.Point(8, 425);
            this.goBackToMenuButton.Name = "goBackToMenuButton";
            this.goBackToMenuButton.Size = new System.Drawing.Size(75, 23);
            this.goBackToMenuButton.TabIndex = 0;
            this.goBackToMenuButton.Text = "В меню";
            this.goBackToMenuButton.UseVisualStyleBackColor = true;
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
            this.collectionOfInformationTabPage.Size = new System.Drawing.Size(661, 454);
            this.collectionOfInformationTabPage.TabIndex = 4;
            this.collectionOfInformationTabPage.Text = "Collection of information";
            this.collectionOfInformationTabPage.UseVisualStyleBackColor = true;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(313, 303);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 23);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "с на4ала";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.Location = new System.Drawing.Point(313, 265);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(75, 23);
            this.backToMenuButton.TabIndex = 2;
            this.backToMenuButton.Text = "В меню";
            this.backToMenuButton.UseVisualStyleBackColor = true;
            this.backToMenuButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.AutoSize = true;
            this.accuracyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accuracyLabel.Location = new System.Drawing.Point(100, 173);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(480, 73);
            this.accuracyLabel.TabIndex = 1;
            this.accuracyLabel.Text = "В процентах %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(290, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "То4ность";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 482);
            this.Controls.Add(this.tabControl);
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
    }
}

