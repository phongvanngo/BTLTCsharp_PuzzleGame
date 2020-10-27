namespace BTLTCsharp_PuzzleGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_SoBuocDi = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.pictureBox_Main = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Location = new System.Drawing.Point(33, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 1;
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.Location = new System.Drawing.Point(406, 454);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(142, 60);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Số bước đi:";
            // 
            // label_SoBuocDi
            // 
            this.label_SoBuocDi.AutoSize = true;
            this.label_SoBuocDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoBuocDi.Location = new System.Drawing.Point(161, 476);
            this.label_SoBuocDi.Name = "label_SoBuocDi";
            this.label_SoBuocDi.Size = new System.Drawing.Size(20, 24);
            this.label_SoBuocDi.TabIndex = 3;
            this.label_SoBuocDi.Text = "0";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Location = new System.Drawing.Point(0, 0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(130, 130);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "button2";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            this.btn1.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Red;
            this.btn2.ForeColor = System.Drawing.Color.Red;
            this.btn2.Location = new System.Drawing.Point(134, 0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(130, 130);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn2_KeyDown);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Red;
            this.btn3.Location = new System.Drawing.Point(267, 0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(130, 130);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "button2";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn3_KeyDown);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Blue;
            this.btn4.Location = new System.Drawing.Point(0, 134);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(130, 130);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "button2";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn4_KeyDown);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Blue;
            this.btn5.Location = new System.Drawing.Point(134, 134);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(130, 130);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "button2";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn5_KeyDown);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Blue;
            this.btn6.Location = new System.Drawing.Point(267, 134);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(130, 130);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "button2";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn6_KeyDown);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Green;
            this.btn7.Location = new System.Drawing.Point(0, 267);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(130, 130);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "button2";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn7_KeyDown);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Green;
            this.btn8.Location = new System.Drawing.Point(134, 267);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(130, 130);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "button2";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn8_KeyDown);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Green;
            this.btn9.Location = new System.Drawing.Point(267, 267);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(130, 130);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "button2";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn9_KeyDown);
            // 
            // pictureBox_Main
            // 
            this.pictureBox_Main.Location = new System.Drawing.Point(514, 34);
            this.pictureBox_Main.Name = "pictureBox_Main";
            this.pictureBox_Main.Size = new System.Drawing.Size(400, 400);
            this.pictureBox_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Main.TabIndex = 0;
            this.pictureBox_Main.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 538);
            this.Controls.Add(this.label_SoBuocDi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_Main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_SoBuocDi;
        private System.Windows.Forms.PictureBox pictureBox_Main;
    }
}

