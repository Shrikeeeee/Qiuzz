
namespace Qiuzz
{
    partial class Game
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
            this.btn_Exit2 = new System.Windows.Forms.Button();
            this.lb_hod = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Exit2
            // 
            this.btn_Exit2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Exit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit2.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_Exit2.FlatAppearance.BorderSize = 2;
            this.btn_Exit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit2.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Exit2.Location = new System.Drawing.Point(691, 634);
            this.btn_Exit2.Name = "btn_Exit2";
            this.btn_Exit2.Size = new System.Drawing.Size(127, 49);
            this.btn_Exit2.TabIndex = 0;
            this.btn_Exit2.Text = "Выход";
            this.btn_Exit2.UseVisualStyleBackColor = false;
            this.btn_Exit2.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_hod
            // 
            this.lb_hod.AutoSize = true;
            this.lb_hod.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lb_hod.Location = new System.Drawing.Point(638, 12);
            this.lb_hod.Name = "lb_hod";
            this.lb_hod.Size = new System.Drawing.Size(130, 30);
            this.lb_hod.TabIndex = 1;
            this.lb_hod.Text = "вапвапвп";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(702, 608);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1498, 695);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_hod);
            this.Controls.Add(this.btn_Exit2);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit2;
        private System.Windows.Forms.Label lb_hod;
        private System.Windows.Forms.TextBox textBox1;
    }
}