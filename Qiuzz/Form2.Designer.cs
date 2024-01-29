
namespace Qiuzz
{
    partial class SettingsForm
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
            this.cmb_Dif = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SaveSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exit2
            // 
            this.btn_Exit2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Exit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Exit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit2.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_Exit2.FlatAppearance.BorderSize = 2;
            this.btn_Exit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit2.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Exit2.Location = new System.Drawing.Point(218, 339);
            this.btn_Exit2.Name = "btn_Exit2";
            this.btn_Exit2.Size = new System.Drawing.Size(190, 38);
            this.btn_Exit2.TabIndex = 3;
            this.btn_Exit2.Text = "Выход";
            this.btn_Exit2.UseVisualStyleBackColor = false;
            this.btn_Exit2.Click += new System.EventHandler(this.btn_Exit2_Click);
            // 
            // cmb_Dif
            // 
            this.cmb_Dif.AutoCompleteCustomSource.AddRange(new string[] {
            "Легко"});
            this.cmb_Dif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_Dif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Dif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Dif.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Dif.Items.AddRange(new object[] {
            "Легко",
            "Средне",
            "Сложно"});
            this.cmb_Dif.Location = new System.Drawing.Point(362, 24);
            this.cmb_Dif.Name = "cmb_Dif";
            this.cmb_Dif.Size = new System.Drawing.Size(151, 32);
            this.cmb_Dif.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите сложность:";
            // 
            // btn_SaveSettings
            // 
            this.btn_SaveSettings.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_SaveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_SaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveSettings.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btn_SaveSettings.FlatAppearance.BorderSize = 2;
            this.btn_SaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveSettings.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_SaveSettings.Location = new System.Drawing.Point(218, 295);
            this.btn_SaveSettings.Name = "btn_SaveSettings";
            this.btn_SaveSettings.Size = new System.Drawing.Size(190, 38);
            this.btn_SaveSettings.TabIndex = 6;
            this.btn_SaveSettings.Text = "Применить";
            this.btn_SaveSettings.UseVisualStyleBackColor = false;
            this.btn_SaveSettings.Click += new System.EventHandler(this.btn_SaveSettings_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(636, 400);
            this.Controls.Add(this.btn_SaveSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Dif);
            this.Controls.Add(this.btn_Exit2);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit2;
        private System.Windows.Forms.ComboBox cmb_Dif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SaveSettings;
    }
}