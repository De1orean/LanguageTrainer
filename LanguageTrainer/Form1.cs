using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace LanguageTrainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [Serializable]
        private struct WordList
        {
            public string ListName;
            public List<string> FirstLanguageList;
            public List<string> SecondLanguageList;
        }

        [Serializable]
        private class ProgramData
        {
            public List<WordList> wordLists;
        }

        private ProgramData programData = new ProgramData();

        private void updateListBox()
        {
            int listsBoxSelectedIndex = listsBox.SelectedIndex;

            listsBox.Items.Clear();

            foreach (WordList elem in programData.wordLists)
            {
                listsBox.Items.Add(elem.ListName);
            }

            listsBox.SelectedIndex = listsBoxSelectedIndex;
        }

        class QuestData
        {
            public Stack<string> FirstLanguageList;
            public Stack<string> SecondLanguageList;
            public int[] AccuracyCounter;
            public int progressCounter;
        }

        private QuestData questData = new QuestData();

        private static QuestData fillQuestData(ProgramData programData,int selectedIndex)
        {
            QuestData questData = new QuestData();

            List<string> FirstLanguage = programData.wordLists[selectedIndex].FirstLanguageList;
            FirstLanguage.Reverse();

            List<string> SecondLanguage = programData.wordLists[selectedIndex].SecondLanguageList;
            SecondLanguage.Reverse();

            questData.FirstLanguageList = new Stack<string>(FirstLanguage);

            questData.SecondLanguageList = new Stack<string>(SecondLanguage);

            int[] AccuracyCounter = new int[FirstLanguage.Count];
            
            for(int i = 0;i<AccuracyCounter.Length;i++)
            {
                AccuracyCounter[i] = -1;
            }

            questData.AccuracyCounter = AccuracyCounter;

            questData.progressCounter = 0;

            return questData;
        }

        private static void checkIsWordIsCorrect(ref QuestData questData,ref TextBox translateOfQuestWordTextBox,ref Label questWordLabel, ref TabControl tabControl, ref Label countOfWordLeftLabel, ref Label accuracyLabel)
        {
            if (questData.AccuracyCounter[questData.progressCounter] == -1)
                if (questData.SecondLanguageList.Peek().ToUpper() == translateOfQuestWordTextBox.Text.ToUpper())
                {
                    questData.SecondLanguageList.Pop();

                    questData.FirstLanguageList.Pop();

                    questData.AccuracyCounter[questData.progressCounter++] = 1;

                    if (questData.FirstLanguageList.Count != 0)
                    {
                        questWordLabel.Text = questData.FirstLanguageList.Peek();

                        questWordLabel.Location = new Point(661 / 2 - questWordLabel.Size.Width / 2, 128);

                        countOfWordLeftLabel.Text = questData.AccuracyCounter.Length - questData.FirstLanguageList.Count+1 + " / " + questData.AccuracyCounter.Length;
                    }
                    else
                    {
                        int correctWordCounter = 0;

                        foreach (int elem in questData.AccuracyCounter)
                            if (elem == 1)
                                correctWordCounter++;

                        if (correctWordCounter % questData.AccuracyCounter.Length == 0)
                            accuracyLabel.Text = "100%";
                        else
                            accuracyLabel.Text = correctWordCounter % questData.AccuracyCounter.Length * 10 + "%";

                        tabControl.SelectedIndex = 4;
                    }
                }
                else
                {
                    questData.AccuracyCounter[questData.progressCounter] = 0;
                }
            else if (questData.AccuracyCounter[questData.progressCounter] == 0)
            {
                if (questData.SecondLanguageList.Peek().ToUpper() == translateOfQuestWordTextBox.Text.ToUpper())
                {
                    questData.SecondLanguageList.Pop();

                    questData.FirstLanguageList.Pop();

                    if (questData.FirstLanguageList.Count != 0)
                    {
                        questWordLabel.Text = questData.FirstLanguageList.Peek();

                        questWordLabel.Location = new Point(661 / 2 - questWordLabel.Size.Width / 2, 128);

                        countOfWordLeftLabel.Text = questData.AccuracyCounter.Length - questData.FirstLanguageList.Count+1 + " / " + questData.AccuracyCounter.Length;
                    }
                    else
                    {
                        int correctWordCounter = 0;

                        foreach (int elem in questData.AccuracyCounter)
                            if (elem == 1)
                                correctWordCounter++;
                        if (correctWordCounter % questData.AccuracyCounter.Length == 0)
                            accuracyLabel.Text = "100%";
                        else
                        accuracyLabel.Text = correctWordCounter % questData.AccuracyCounter.Length * 10 + "%";

                        tabControl.SelectedIndex = 4;
                    }
                }
            }
        }

        private void updateAnyListBox(ListBox listBox, List<string> listOfWords)
        {
            listBox.Items.Clear();

            foreach (string elem in listOfWords)
                listBox.Items.Add(elem);
        }

        private struct ControlColection
        {
            public ListBox firstListBox;
            public ListBox secondListBox;
            public TextBox firstTextBox;
            public TextBox secondTextBox;
            public TextBox nameOfListTextBox;
        }

        private void clearControls(ControlColection controls)
        {
            controls.firstListBox.Items.Clear();

            controls.secondListBox.Items.Clear();

            controls.firstTextBox.Clear();

            controls.secondTextBox.Clear();

            controls.nameOfListTextBox.Clear();
        }

        private void updateWordsOfSelectedListBox()
        {
            wordsOfSelectedListBox.SelectedIndex = -1;

            if (listsBox.SelectedIndex != -1)
            {
                wordsOfSelectedListBox.DataSource = null;

                wordsOfSelectedListBox.Items.Clear();

                wordsOfSelectedListBox.DataSource = programData.wordLists[listsBox.SelectedIndex].FirstLanguageList;
            }
            else
            {
                wordsOfSelectedListBox.DataSource = null;

                wordsOfSelectedListBox.Items.Clear();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (listsBox.SelectedIndex != -1)
            {
                questWordLabel.Text = programData.wordLists[listsBox.SelectedIndex].FirstLanguageList[0];

                questWordLabel.Location = new Point(661 / 2 - questWordLabel.Size.Width / 2, 128);

                countOfWordLeftLabel.Text = "1 / " + programData.wordLists[listsBox.SelectedIndex].FirstLanguageList.Count;

                questData = fillQuestData(programData, listsBox.SelectedIndex);

                tabControl.SelectedIndex = 3;
            }
        }

        private void CreateListButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void ChangeListButton_Click(object sender, EventArgs e)
        {
            if(listsBox.SelectedIndex!=-1)
            {
                tabControl.SelectedIndex = 2;

                changeListNameTextBox.Text = programData.wordLists[listsBox.SelectedIndex].ListName;

                foreach (string elem in programData.wordLists[listsBox.SelectedIndex].FirstLanguageList)
                    FirstLanguageChangeListBox.Items.Add(elem);

                foreach (string elem in programData.wordLists[listsBox.SelectedIndex].SecondLanguageList)
                    SecondLanguageChangeListBox.Items.Add(elem);
            }
        }

        private void CancelNewListButton_Click(object sender, EventArgs e)
        {
            clearControls(new ControlColection
            {
                firstListBox = FirstLanguageNewListBox,
                secondListBox = SecondLanguageNewListBox,
                firstTextBox = firstLanguageNewListWordTextBox,
                secondTextBox = secondLanguageNewListWordTextBox,
                nameOfListTextBox = newListNameTextBox
            }
            );

            tabControl.SelectedIndex = 0;
        }

        private void CancelChangeListButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void GoBackToMenuButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void ExitProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveNewListButton_Click(object sender, EventArgs e)
        {
            if (newListNameTextBox.Text != "" && FirstLanguageNewListBox.Items.Count != 0 && SecondLanguageNewListBox.Items.Count != 0)
            {
                WordList wordList = new WordList();

                wordList.ListName = newListNameTextBox.Text;
                wordList.FirstLanguageList = FirstLanguageNewListBox.Items.Cast<String>().ToList();
                wordList.SecondLanguageList = SecondLanguageNewListBox.Items.Cast<String>().ToList();

                try
                {
                    programData.wordLists.Add(wordList);
                }
                catch (NullReferenceException)
                {
                    programData.wordLists = new List<WordList>() { wordList };
                }

                clearControls(new ControlColection
                {
                    firstListBox = FirstLanguageNewListBox,
                    secondListBox = SecondLanguageNewListBox,
                    firstTextBox = firstLanguageNewListWordTextBox,
                    secondTextBox = secondLanguageNewListWordTextBox,
                    nameOfListTextBox = newListNameTextBox
                }
                );

                updateListBox();

                updateWordsOfSelectedListBox();

                tabControl.SelectedIndex = 0;
            }
        }

        private void AddWordInNewListButton_Click(object sender, EventArgs e)
        {
            if(firstLanguageNewListWordTextBox.Text != "" && secondLanguageNewListWordTextBox.Text != "")
            {
                FirstLanguageNewListBox.Items.Add(firstLanguageNewListWordTextBox.Text);
                SecondLanguageNewListBox.Items.Add(secondLanguageNewListWordTextBox.Text);
            }
        }

        private void DeleteWordInNewListButton_Click(object sender, EventArgs e)
        { 
            int selectedIndex = FirstLanguageNewListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                FirstLanguageNewListBox.Items.RemoveAt(selectedIndex);
                SecondLanguageNewListBox.Items.RemoveAt(selectedIndex);
            }

        }

        private void FirstLanguageNewListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecondLanguageNewListBox.SelectedIndex = FirstLanguageNewListBox.SelectedIndex;
        }

        private void SecondLanguageNewListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirstLanguageNewListBox.SelectedIndex = SecondLanguageNewListBox.SelectedIndex;
        }

        private void ListsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateWordsOfSelectedListBox();
        }

        private void DeleteListButton_Click(object sender, EventArgs e)
        {
            if(listsBox.SelectedIndex!=-1)
            {
                programData.wordLists.RemoveAt(listsBox.SelectedIndex);

                listsBox.Items.RemoveAt(listsBox.SelectedIndex);

                updateListBox();
            }

            // todo удаление элементов 
            // из выбранного списка из главного меню
            //if(wordsOfSelectedListBox.SelectedIndex!=-1)
            //{
            //    programData.wordLists[listsBox.SelectedIndex].FirstLanguageList.RemoveAt(listsBox.SelectedIndex);

            //    programData.wordLists[listsBox.SelectedIndex].SecondLanguageList.RemoveAt(listsBox.SelectedIndex);

            //    updateAnyListBox(wordsOfSelectedListBox, programData.wordLists[listsBox.SelectedIndex].FirstLanguageList);
            //}
        }

        private void WordsOfSelectedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AddWordInChangedListButton_Click(object sender, EventArgs e)
        {
            if (firstLanguageChangeListWordTextBox.Text != "" && secondLanguageChangeListWordTextBox.Text != "")
            {
                FirstLanguageChangeListBox.Items.Add(firstLanguageChangeListWordTextBox.Text);

                SecondLanguageChangeListBox.Items.Add(secondLanguageChangeListWordTextBox.Text);
            }
        }

        private void DeleteWordInChangedListButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = FirstLanguageChangeListBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                FirstLanguageChangeListBox.Items.RemoveAt(selectedIndex);

                SecondLanguageChangeListBox.Items.RemoveAt(selectedIndex);
            }
        }

        private void SaveChangedListButton_Click(object sender, EventArgs e)
        {
            if (changeListNameTextBox.Text != "" && FirstLanguageChangeListBox.Items.Count != 0 && SecondLanguageChangeListBox.Items.Count != 0)
            {
                WordList wordList = new WordList();

                wordList.ListName = changeListNameTextBox.Text;
                wordList.FirstLanguageList = FirstLanguageChangeListBox.Items.Cast<String>().ToList();
                wordList.SecondLanguageList = SecondLanguageChangeListBox.Items.Cast<String>().ToList();

                clearControls(new ControlColection
                {
                    firstListBox = FirstLanguageChangeListBox,
                    secondListBox = SecondLanguageChangeListBox,
                    firstTextBox = firstLanguageChangeListWordTextBox,
                    secondTextBox = secondLanguageChangeListWordTextBox,
                    nameOfListTextBox = changeListNameTextBox
                }
                );

                programData.wordLists[listsBox.SelectedIndex] = wordList;
                
                updateListBox();

                tabControl.SelectedIndex = 0;
            }
        }

        private void FirstLanguageChangeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecondLanguageChangeListBox.SelectedIndex = FirstLanguageChangeListBox.SelectedIndex;
        }

        private void SecondLanguageChangeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirstLanguageChangeListBox.SelectedIndex = SecondLanguageChangeListBox.SelectedIndex; 
        }

        private void JumpOnNextWordButton_Click(object sender, EventArgs e)
        {
                checkIsWordIsCorrect(ref questData,ref translateOfQuestWordTextBox, ref questWordLabel,ref tabControl,ref countOfWordLeftLabel,ref accuracyLabel);

            translateOfQuestWordTextBox.Clear();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            questWordLabel.Text = programData.wordLists[listsBox.SelectedIndex].FirstLanguageList[0];

            countOfWordLeftLabel.Text = "1 / " + programData.wordLists[listsBox.SelectedIndex].FirstLanguageList.Count;

            questData = fillQuestData(programData, listsBox.SelectedIndex);

            tabControl.SelectedIndex = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("programdata.dat"))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                using (FileStream fileStream = new FileStream("programdata.dat", FileMode.OpenOrCreate))
                {
                    programData = (ProgramData)binaryFormatter.Deserialize(fileStream);
                }
                try
                {
                    updateListBox();
                }
                catch(NullReferenceException)
                {

                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("programdata.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, programData);
            }
        }
    }
}
