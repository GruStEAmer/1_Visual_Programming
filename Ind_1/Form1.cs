using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Ind_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Начало основной задачи
        private void do_it_Click(object sender, EventArgs e)
        {
            //a - 97, z - 122
            int key = 0;
            if (key_box.Text != "")
            {
                key = (Convert.ToInt32(key_box.Text)) % 26;
            }
            String txt = key_box_text.Text;

            String ans = "";

            if (combo_action.Text == "Crypt")
            {
                while (text_box.Items.IndexOf("Выберите: декодировать или закодировать") != -1)
                {
                    text_box.Items.Remove("Выберите: декодировать или закодировать");
                }
                foreach (char i in txt)
                {
                    if ((i + key) <= 122)
                    {
                        ans += Convert.ToChar((i + key));
                    }
                    else
                    {
                        ans += Convert.ToChar(((i + key) % 122)+96);
                    }
                }
                text_box.Items.Add(ans);
            }
            else if (combo_action.Text == "Decrypt")
            {
                while (text_box.Items.IndexOf("Выберите: декодировать или закодировать") != -1)
                {
                    text_box.Items.Remove("Выберите: декодировать или закодировать");
                }
                foreach (char i in txt)
                {
                    if (i - key >= 97)
                    {
                        ans += Convert.ToChar((i - key));
                    }
                    else
                    {
                        ans += Convert.ToChar((i - key) + 26);
                    }
                }
                text_box.Items.Add(ans);
            }
            else
            {
                text_box.Items.Add("Выберите: декодировать или закодировать");
            }


        }
        //Конец основной задачи

        private void text_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_action_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Начало элементов меню
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //Начало панели File

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*txt|*.txt";
            dialog.Title = "Open how txt file";
            dialog.ShowDialog();

            

            if(text_box.Items.Count != 0)
            {
                text_box.Items.Clear();
            }
            string fileText = System.IO.File.ReadAllText(dialog.FileName);
            foreach (string line in fileText.Split('\n')){
                text_box.Items.Add(line);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "*txt|*.txt";
            saveFileDialog.Title = "Save how txt file";
            saveFileDialog.ShowDialog();

            if(saveFileDialog.FileName != "")
            {
                string sv = "";
                foreach(string i in text_box.Items)
                {
                    sv += i + '\n';
                }
                System.IO.File.WriteAllText(saveFileDialog.FileName, sv);
                MessageBox.Show("Файл сохранен");
            }
            else
            {
                return;
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Конец панели File

        //Начало панели Options
        //Курсор
        private void cursorColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void crossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void handToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        //Фон
        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void seaShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.AntiqueWhite;
        }

        

        //Конец панели Options
        //Конец элементов меню
    }
}
