namespace _1510tyTextApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            その他ToolStripMenuItem = new ToolStripMenuItem();
            このアプリについてToolStripMenuItem = new ToolStripMenuItem();
            利用させていただいたものToolStripMenuItem = new ToolStripMenuItem();
            標準のメモ帳でよくねToolStripMenuItem = new ToolStripMenuItem();
            追加予定機能ToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem, その他ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開くToolStripMenuItem, 保存ToolStripMenuItem, 終了ToolStripMenuItem });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(65, 24);
            ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(224, 26);
            開くToolStripMenuItem.Text = "開く";
            開くToolStripMenuItem.Click += 開くToolStripMenuItem_Click;
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(224, 26);
            保存ToolStripMenuItem.Text = "保存";
            保存ToolStripMenuItem.Click += 保存ToolStripMenuItem_Click;
            // 
            // その他ToolStripMenuItem
            // 
            その他ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { このアプリについてToolStripMenuItem, 利用させていただいたものToolStripMenuItem, 標準のメモ帳でよくねToolStripMenuItem, 追加予定機能ToolStripMenuItem });
            その他ToolStripMenuItem.Name = "その他ToolStripMenuItem";
            その他ToolStripMenuItem.Size = new Size(61, 24);
            その他ToolStripMenuItem.Text = "その他";
            // 
            // このアプリについてToolStripMenuItem
            // 
            このアプリについてToolStripMenuItem.Name = "このアプリについてToolStripMenuItem";
            このアプリについてToolStripMenuItem.Size = new Size(239, 26);
            このアプリについてToolStripMenuItem.Text = "このアプリについて";
            このアプリについてToolStripMenuItem.Click += このアプリについてToolStripMenuItem_Click;
            // 
            // 利用させていただいたものToolStripMenuItem
            // 
            利用させていただいたものToolStripMenuItem.Name = "利用させていただいたものToolStripMenuItem";
            利用させていただいたものToolStripMenuItem.Size = new Size(239, 26);
            利用させていただいたものToolStripMenuItem.Text = "利用させていただいたもの";
            利用させていただいたものToolStripMenuItem.Click += 利用させていただいたものToolStripMenuItem_Click;
            // 
            // 標準のメモ帳でよくねToolStripMenuItem
            // 
            標準のメモ帳でよくねToolStripMenuItem.Name = "標準のメモ帳でよくねToolStripMenuItem";
            標準のメモ帳でよくねToolStripMenuItem.Size = new Size(239, 26);
            標準のメモ帳でよくねToolStripMenuItem.Text = "標準の「メモ帳」でよくね?";
            標準のメモ帳でよくねToolStripMenuItem.Click += 標準のメモ帳でよくねToolStripMenuItem_Click;
            // 
            // 追加予定機能ToolStripMenuItem
            // 
            追加予定機能ToolStripMenuItem.Name = "追加予定機能ToolStripMenuItem";
            追加予定機能ToolStripMenuItem.Size = new Size(239, 26);
            追加予定機能ToolStripMenuItem.Text = "追加予定機能!";
            追加予定機能ToolStripMenuItem.Click += 追加予定機能ToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(0, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(800, 422);
            textBox1.TabIndex = 1;
            textBox1.WordWrap = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Size = new Size(224, 26);
            終了ToolStripMenuItem.Text = "終了";
            終了ToolStripMenuItem.Click += 終了ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "1510tyTextApp";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private TextBox textBox1;
        private ToolStripMenuItem その他ToolStripMenuItem;
        private ToolStripMenuItem このアプリについてToolStripMenuItem;
        private ToolStripMenuItem 利用させていただいたものToolStripMenuItem;
        private ToolStripMenuItem 標準のメモ帳でよくねToolStripMenuItem;
        private ToolStripMenuItem 追加予定機能ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
    }
}
