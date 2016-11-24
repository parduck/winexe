namespace WinExe
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_run = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(414, 436);
            this.listBox1.TabIndex = 0;
            this.listBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listboxKeyUp);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mouseDoubleClick);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(12, 457);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(69, 23);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(87, 457);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(78, 23);
            this.btn_run.TabIndex = 2;
            this.btn_run.Text = "run(enter)";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 484);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "WinExe by chan 1.0";
            this.Load += new System.EventHandler(this.btn_refresh_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_run;
    }
}

