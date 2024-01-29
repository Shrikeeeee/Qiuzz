
namespace Qiuzz
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Exit1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Play.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.Location = new System.Drawing.Point(831, 481);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(293, 101);
            this.btn_Play.TabIndex = 0;
            this.btn_Play.Text = "Начать";
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Settings.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_Settings.FlatAppearance.BorderSize = 2;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Settings.Location = new System.Drawing.Point(831, 588);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(293, 100);
            this.btn_Settings.TabIndex = 1;
            this.btn_Settings.Text = "Настройки";
            this.btn_Settings.UseVisualStyleBackColor = false;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // btn_Exit1
            // 
            this.btn_Exit1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Exit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_Exit1.FlatAppearance.BorderSize = 2;
            this.btn_Exit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Exit1.Location = new System.Drawing.Point(831, 694);
            this.btn_Exit1.Name = "btn_Exit1";
            this.btn_Exit1.Size = new System.Drawing.Size(293, 106);
            this.btn_Exit1.TabIndex = 2;
            this.btn_Exit1.Text = "Выход";
            this.btn_Exit1.UseVisualStyleBackColor = false;
            this.btn_Exit1.Click += new System.EventHandler(this.btn_Exit1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1853, 930);
            this.Controls.Add(this.btn_Exit1);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.btn_Play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Викторина ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Exit1;
    }
}

