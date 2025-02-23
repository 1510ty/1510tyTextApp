using Microsoft.VisualBasic.ApplicationServices;
using System.Diagnostics.Eventing.Reader;

namespace _1510tyTextApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                string filePath = args[1];
                if (File.Exists(filePath))
                {
                    textBox1.Text = File.ReadAllText(filePath);
                }
                else
                {
                    MessageBox.Show("404 File Not Found", "開く", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveTextBoxContent()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "テキストファイル (*.txt)|*.txt|すべてのファイル (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                TextBox textBox = this.textBox1;
                File.WriteAllText(filePath, textBox.Text);
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTextBoxContent();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileAndLoadContent();
        }
        private void OpenFileAndLoadContent()
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                DialogResult result = MessageBox.Show("テキストボックス内に、文字があります。このままファイルを開きますか？", "開く", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "テキストファイル (*.txt)|*.txt|すべてのファイル (*.*)|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;
                        textBox1.Text = File.ReadAllText(filePath);
                    }
                }
                else
                {

                }
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "テキストファイル (*.txt)|*.txt|すべてのファイル (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    textBox1.Text = File.ReadAllText(filePath);
                }
            }
        }

        private void このアプリについてToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1510tyTextApp 1.5.0\n1510tyによって、作られ、提供されています。", "このアプリについて", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 利用させていただいたものToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visual Studio 2022 等", "利用させていただいたもの(※仮ウィンドウ)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 標準のメモ帳でよくねToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("それは言わないお約束。", "言ってはいけない。", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void 追加予定機能ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("・ファイルを保存する際、いちいちダイアログを開くのではなく、\n「保存」と、「別の名前で保存」を用意する。\n・Ctrl+Sで保存できるようにする\n...くらい", "追加予定機能!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("終了しますか?","1510tyTextApp", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

            }





        }   

    }
}
