namespace 명언제조기
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사진추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.텍스트추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.텍스트추가도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "명언";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "명언 재료";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일추가ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(391, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 파일추가ToolStripMenuItem
            // 
            this.파일추가ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사진추가ToolStripMenuItem,
            this.텍스트추가ToolStripMenuItem});
            this.파일추가ToolStripMenuItem.Name = "파일추가ToolStripMenuItem";
            this.파일추가ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.파일추가ToolStripMenuItem.Text = "바로가기";
            // 
            // 사진추가ToolStripMenuItem
            // 
            this.사진추가ToolStripMenuItem.Name = "사진추가ToolStripMenuItem";
            this.사진추가ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.사진추가ToolStripMenuItem.Text = "사진 저장폴더";
            this.사진추가ToolStripMenuItem.Click += new System.EventHandler(this.사진추가ToolStripMenuItem_Click);
            // 
            // 텍스트추가ToolStripMenuItem
            // 
            this.텍스트추가ToolStripMenuItem.Name = "텍스트추가ToolStripMenuItem";
            this.텍스트추가ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.텍스트추가ToolStripMenuItem.Text = "텍스트 저장폴더";
            this.텍스트추가ToolStripMenuItem.Click += new System.EventHandler(this.텍스트추가ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.텍스트추가도움말ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 텍스트추가도움말ToolStripMenuItem
            // 
            this.텍스트추가도움말ToolStripMenuItem.Name = "텍스트추가도움말ToolStripMenuItem";
            this.텍스트추가도움말ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.텍스트추가도움말ToolStripMenuItem.Text = "사용 방법";
            this.텍스트추가도움말ToolStripMenuItem.Click += new System.EventHandler(this.텍스트추가도움말ToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::명언제조기.Properties.Resources.개사지;
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "명언생성기";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사진추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 텍스트추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 텍스트추가도움말ToolStripMenuItem;
    }
}

