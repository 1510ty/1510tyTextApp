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
                    MessageBox.Show("404 File Not Found", "�J��", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveTextBoxContent()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "�e�L�X�g�t�@�C�� (*.txt)|*.txt|���ׂẴt�@�C�� (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                TextBox textBox = this.textBox1;
                File.WriteAllText(filePath, textBox.Text);
            }
        }

        private void �ۑ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTextBoxContent();
        }

        private void �J��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileAndLoadContent();
        }
        private void OpenFileAndLoadContent()
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                DialogResult result = MessageBox.Show("�e�L�X�g�{�b�N�X���ɁA����������܂��B���̂܂܃t�@�C�����J���܂����H", "�J��", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "�e�L�X�g�t�@�C�� (*.txt)|*.txt|���ׂẴt�@�C�� (*.*)|*.*";

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
                openFileDialog.Filter = "�e�L�X�g�t�@�C�� (*.txt)|*.txt|���ׂẴt�@�C�� (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    textBox1.Text = File.ReadAllText(filePath);
                }
            }
        }

        private void ���̃A�v���ɂ���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1510tyTextApp 1.5.0\n1510ty�ɂ���āA����A�񋟂���Ă��܂��B", "���̃A�v���ɂ���", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ���p�����Ă�������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visual Studio 2022 ��", "���p�����Ă�������������(�����E�B���h�E)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void �W���̃������ł悭��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����͌���Ȃ����񑩁B", "�����Ă͂����Ȃ��B", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void �ǉ��\��@�\ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�E�t�@�C����ۑ�����ہA���������_�C�A���O���J���̂ł͂Ȃ��A\n�u�ۑ��v�ƁA�u�ʂ̖��O�ŕۑ��v��p�ӂ���B\n�ECtrl+S�ŕۑ��ł���悤�ɂ���\n...���炢", "�ǉ��\��@�\!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void �I��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("�I�����܂���?","1510tyTextApp", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
