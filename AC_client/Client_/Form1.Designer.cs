namespace Client_
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
            this.components = new System.ComponentModel.Container();
            this.textBoxNickName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.btnSendText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back_image = new System.Windows.Forms.Button();
            this.font_button = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1_save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNickName
            // 
            this.textBoxNickName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNickName.Location = new System.Drawing.Point(503, 42);
            this.textBoxNickName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNickName.Name = "textBoxNickName";
            this.textBoxNickName.Size = new System.Drawing.Size(212, 28);
            this.textBoxNickName.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.White;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.Location = new System.Drawing.Point(719, 42);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(126, 32);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "연결";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel.SetColumnSpan(this.richTextBox1, 2);
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(2, 78);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.panel.SetRowSpan(this.richTextBox1, 3);
            this.richTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(713, 251);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_copy,
            this.ToolStripMenuItem_paste});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 64);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // ToolStripMenuItem_copy
            // 
            this.ToolStripMenuItem_copy.Name = "ToolStripMenuItem_copy";
            this.ToolStripMenuItem_copy.Size = new System.Drawing.Size(156, 30);
            this.ToolStripMenuItem_copy.Text = "복사";
            this.ToolStripMenuItem_copy.Click += new System.EventHandler(this.ToolStripMenuItem_copy_Click);
            // 
            // ToolStripMenuItem_paste
            // 
            this.ToolStripMenuItem_paste.Name = "ToolStripMenuItem_paste";
            this.ToolStripMenuItem_paste.Size = new System.Drawing.Size(156, 30);
            this.ToolStripMenuItem_paste.Text = "붙여넣기";
            this.ToolStripMenuItem_paste.Click += new System.EventHandler(this.ToolStripMenuItem_paste_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.Color.White;
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel.SetColumnSpan(this.textBoxMessage, 2);
            this.textBoxMessage.ContextMenuStrip = this.contextMenuStrip1;
            this.textBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMessage.Location = new System.Drawing.Point(2, 442);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMessage.Size = new System.Drawing.Size(713, 21);
            this.textBoxMessage.TabIndex = 3;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            this.textBoxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMessage_KeyDown);
            // 
            // btnSendText
            // 
            this.btnSendText.BackColor = System.Drawing.Color.White;
            this.btnSendText.Location = new System.Drawing.Point(719, 442);
            this.btnSendText.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendText.Name = "btnSendText";
            this.btnSendText.Size = new System.Drawing.Size(126, 27);
            this.btnSendText.TabIndex = 4;
            this.btnSendText.Text = "보내기";
            this.btnSendText.UseVisualStyleBackColor = false;
            this.btnSendText.Click += new System.EventHandler(this.btnSendText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("한컴 소망 B", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "닉네임";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // back_image
            // 
            this.back_image.BackColor = System.Drawing.Color.White;
            this.back_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_image.Location = new System.Drawing.Point(721, 80);
            this.back_image.Margin = new System.Windows.Forms.Padding(4);
            this.back_image.Name = "back_image";
            this.back_image.Size = new System.Drawing.Size(122, 79);
            this.back_image.TabIndex = 7;
            this.back_image.Text = "배경";
            this.back_image.UseVisualStyleBackColor = false;
            this.back_image.Click += new System.EventHandler(this.back_image_Click);
            // 
            // font_button
            // 
            this.font_button.BackColor = System.Drawing.Color.White;
            this.font_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.font_button.Location = new System.Drawing.Point(721, 167);
            this.font_button.Margin = new System.Windows.Forms.Padding(4);
            this.font_button.Name = "font_button";
            this.font_button.Size = new System.Drawing.Size(122, 75);
            this.font_button.TabIndex = 8;
            this.font_button.Text = "폰트";
            this.font_button.UseVisualStyleBackColor = false;
            this.font_button.Click += new System.EventHandler(this.font_button_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.White;
            this.button_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_clear.Location = new System.Drawing.Point(720, 249);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(124, 79);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "채팅창초기화";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // panel
            // 
            this.panel.ColumnCount = 3;
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 501F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.panel.Controls.Add(this.richTextBox1, 0, 2);
            this.panel.Controls.Add(this.label1, 0, 1);
            this.panel.Controls.Add(this.textBoxNickName, 1, 1);
            this.panel.Controls.Add(this.btnSendText, 2, 6);
            this.panel.Controls.Add(this.btnConnect, 2, 1);
            this.panel.Controls.Add(this.button_clear, 2, 4);
            this.panel.Controls.Add(this.back_image, 2, 2);
            this.panel.Controls.Add(this.font_button, 2, 3);
            this.panel.Controls.Add(this.textBoxMessage, 0, 6);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.RowCount = 7;
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.panel.Size = new System.Drawing.Size(847, 471);
            this.panel.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.저장ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1_save,
            this.ToolStripMenuItem_exit});
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F";
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.저장ToolStripMenuItem.Text = "파일(&F)";
            // 
            // ToolStripMenuItem1_save
            // 
            this.ToolStripMenuItem1_save.Name = "ToolStripMenuItem1_save";
            this.ToolStripMenuItem1_save.ShortcutKeyDisplayString = "Ctrl+S";
            this.ToolStripMenuItem1_save.Size = new System.Drawing.Size(252, 30);
            this.ToolStripMenuItem1_save.Text = "저장(S)";
            this.ToolStripMenuItem1_save.Click += new System.EventHandler(this.ToolStripMenuItem1_save_Click);
            // 
            // ToolStripMenuItem_exit
            // 
            this.ToolStripMenuItem_exit.Name = "ToolStripMenuItem_exit";
            this.ToolStripMenuItem_exit.Size = new System.Drawing.Size(252, 30);
            this.ToolStripMenuItem_exit.Text = "끝내기(X)";
            this.ToolStripMenuItem_exit.Click += new System.EventHandler(this.ToolStripMenuItem_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 471);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNickName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button btnSendText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_image;
        private System.Windows.Forms.Button font_button;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_copy;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_paste;
        private System.Windows.Forms.TableLayoutPanel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1_save;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_exit;
    }
}

