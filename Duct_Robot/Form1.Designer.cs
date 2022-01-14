namespace Duct_Robot
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
            this.Video_Screen = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.Start_Button = new System.Windows.Forms.Button();
            this.End_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Forward_Bar = new System.Windows.Forms.TrackBar();
            this.Back_Bar = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Emergency = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Video_Screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Forward_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // Video_Screen
            // 
            this.Video_Screen.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Video_Screen.Location = new System.Drawing.Point(48, 52);
            this.Video_Screen.Name = "Video_Screen";
            this.Video_Screen.Size = new System.Drawing.Size(319, 245);
            this.Video_Screen.TabIndex = 0;
            this.Video_Screen.TabStop = false;
            // 
            // Start_Button
            // 
            this.Start_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Button.Location = new System.Drawing.Point(397, 83);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(173, 63);
            this.Start_Button.TabIndex = 1;
            this.Start_Button.Text = "START";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // End_Button
            // 
            this.End_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.End_Button.Location = new System.Drawing.Point(584, 83);
            this.End_Button.Name = "End_Button";
            this.End_Button.Size = new System.Drawing.Size(173, 63);
            this.End_Button.TabIndex = 2;
            this.End_Button.Text = "END";
            this.End_Button.UseVisualStyleBackColor = true;
            this.End_Button.Click += new System.EventHandler(this.End_Button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("문체부 제목 돋음체", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(434, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "덕트청소해줘잉";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("문체부 제목 돋음체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(462, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "안녕하세요?";
            // 
            // Forward_Bar
            // 
            this.Forward_Bar.Location = new System.Drawing.Point(466, 169);
            this.Forward_Bar.Maximum = 120;
            this.Forward_Bar.Name = "Forward_Bar";
            this.Forward_Bar.Size = new System.Drawing.Size(291, 45);
            this.Forward_Bar.TabIndex = 7;
            this.Forward_Bar.Scroll += new System.EventHandler(this.Forward_Bar_Scroll);
            // 
            // Back_Bar
            // 
            this.Back_Bar.Location = new System.Drawing.Point(466, 230);
            this.Back_Bar.Maximum = 120;
            this.Back_Bar.Name = "Back_Bar";
            this.Back_Bar.Size = new System.Drawing.Size(291, 45);
            this.Back_Bar.TabIndex = 8;
            this.Back_Bar.Scroll += new System.EventHandler(this.Back_Bar_Scroll);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(314, 342);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 20);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("문체부 제목 돋음체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(56, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 48);
            this.label3.TabIndex = 10;
            this.label3.Text = "청소 속도:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("문체부 제목 돋음체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(462, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "청소 동작 상태 라벨";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("문체부 제목 돋음체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(373, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "FORWARD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("문체부 제목 돋음체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(393, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "BACK:";
            // 
            // Emergency
            // 
            this.Emergency.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Emergency.Location = new System.Drawing.Point(584, 354);
            this.Emergency.Name = "Emergency";
            this.Emergency.Size = new System.Drawing.Size(173, 63);
            this.Emergency.TabIndex = 14;
            this.Emergency.Text = "비상버튼";
            this.Emergency.UseVisualStyleBackColor = true;
            this.Emergency.Click += new System.EventHandler(this.Emergency_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 429);
            this.Controls.Add(this.Emergency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Back_Bar);
            this.Controls.Add(this.Forward_Bar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.End_Button);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.Video_Screen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Video_Screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Forward_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl Video_Screen;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button End_Button;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Forward_Bar;
        private System.Windows.Forms.TrackBar Back_Bar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Emergency;
    }
}

