namespace FreelanceHub
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            buttonRegistration = new Button();
            buttonAuthorization = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Tw Cen MT Condensed Extra Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(304, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(208, 44);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "FreelanceHub";
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = Color.WhiteSmoke;
            buttonRegistration.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            buttonRegistration.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonRegistration.ForeColor = SystemColors.ActiveCaptionText;
            buttonRegistration.Location = new Point(547, 95);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(241, 54);
            buttonRegistration.TabIndex = 1;
            buttonRegistration.Text = "Регистрация";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += buttonRegistration_Click;
            // 
            // buttonAuthorization
            // 
            buttonAuthorization.BackColor = Color.WhiteSmoke;
            buttonAuthorization.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            buttonAuthorization.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAuthorization.ForeColor = SystemColors.ActiveCaptionText;
            buttonAuthorization.Location = new Point(12, 95);
            buttonAuthorization.Name = "buttonAuthorization";
            buttonAuthorization.Size = new Size(247, 54);
            buttonAuthorization.TabIndex = 2;
            buttonAuthorization.Text = "Авторизация";
            buttonAuthorization.UseVisualStyleBackColor = false;
            buttonAuthorization.Click += buttonAuthorization_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(800, 182);
            Controls.Add(buttonAuthorization);
            Controls.Add(buttonRegistration);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonRegistration;
        private Button buttonAuthorization;
    }
}
