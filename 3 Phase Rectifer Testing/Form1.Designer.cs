namespace _3_Phase_Rectifer_Testing
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblhz = new System.Windows.Forms.Label();
            this.halfcycle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ttime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.frq = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblangle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Half Cycle Time (ms)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find Hz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblhz
            // 
            this.lblhz.AutoSize = true;
            this.lblhz.Location = new System.Drawing.Point(185, 75);
            this.lblhz.Name = "lblhz";
            this.lblhz.Size = new System.Drawing.Size(27, 13);
            this.lblhz.TabIndex = 3;
            this.lblhz.Text = "0 hz";
            // 
            // halfcycle
            // 
            this.halfcycle.Location = new System.Drawing.Point(79, 68);
            this.halfcycle.Name = "halfcycle";
            this.halfcycle.Size = new System.Drawing.Size(100, 20);
            this.halfcycle.TabIndex = 4;
            this.halfcycle.Text = "20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phase angle calculator";
            // 
            // ttime
            // 
            this.ttime.Location = new System.Drawing.Point(79, 199);
            this.ttime.Name = "ttime";
            this.ttime.Size = new System.Drawing.Size(100, 20);
            this.ttime.TabIndex = 6;
            this.ttime.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Time into cycle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hz";
            // 
            // frq
            // 
            this.frq.Location = new System.Drawing.Point(79, 238);
            this.frq.Name = "frq";
            this.frq.Size = new System.Drawing.Size(100, 20);
            this.frq.TabIndex = 8;
            this.frq.Text = "50";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Find Phase angle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblangle
            // 
            this.lblangle.AutoSize = true;
            this.lblangle.Location = new System.Drawing.Point(76, 302);
            this.lblangle.Name = "lblangle";
            this.lblangle.Size = new System.Drawing.Size(75, 13);
            this.lblangle.TabIndex = 11;
            this.lblangle.Text = "Phase angle : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hz finder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblangle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.frq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ttime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.halfcycle);
            this.Controls.Add(this.lblhz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblhz;
        private System.Windows.Forms.TextBox halfcycle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ttime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox frq;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblangle;
        private System.Windows.Forms.Label label5;
    }
}

