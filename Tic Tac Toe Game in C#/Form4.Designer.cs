namespace TicTacToe
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TITLE = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 110);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play with Computer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 135);
            this.button2.TabIndex = 1;
            this.button2.Text = "Play with Friend";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TITLE
            // 
            this.TITLE.AutoSize = true;
            this.TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE.Location = new System.Drawing.Point(31, 22);
            this.TITLE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(773, 108);
            this.TITLE.TabIndex = 29;
            this.TITLE.Text = "TIC - TAC - TOE";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 94);
            this.button3.TabIndex = 30;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(838, 449);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label TITLE;
        private System.Windows.Forms.Button button3;
    }
}