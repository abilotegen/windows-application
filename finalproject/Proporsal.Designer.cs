namespace finalproject
{
    partial class Proporsal
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
            this.label12 = new System.Windows.Forms.Label();
            this.textlog = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textnomber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textidea = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(338, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(373, 32);
            this.label12.TabIndex = 27;
            this.label12.Text = "Если у тебя есть хороший идея.";
            // 
            // textlog
            // 
            this.textlog.Location = new System.Drawing.Point(246, 243);
            this.textlog.Name = "textlog";
            this.textlog.Size = new System.Drawing.Size(121, 20);
            this.textlog.TabIndex = 26;
            // 
            // btnsend
            // 
            this.btnsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsend.Location = new System.Drawing.Point(446, 325);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(147, 36);
            this.btnsend.TabIndex = 25;
            this.btnsend.Text = "Отправить";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(272, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Логин";
            // 
            // textnomber
            // 
            this.textnomber.Location = new System.Drawing.Point(458, 243);
            this.textnomber.Name = "textnomber";
            this.textnomber.Size = new System.Drawing.Size(121, 20);
            this.textnomber.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(454, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Телефон номер";
            // 
            // textidea
            // 
            this.textidea.Location = new System.Drawing.Point(648, 243);
            this.textidea.Name = "textidea";
            this.textidea.Size = new System.Drawing.Size(142, 20);
            this.textidea.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(676, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Идея";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(181, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(685, 32);
            this.label3.TabIndex = 32;
            this.label3.Text = "Оставь заявку, если понравиться мы сами с вами связимься";
            // 
            // Proporsal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(984, 572);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textidea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textnomber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textlog);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Proporsal";
            this.Text = "Proporsal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textlog;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textnomber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textidea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}