namespace Language_Translator
{
    partial class languageTranslatorForm
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.spanishBtn = new System.Windows.Forms.Button();
            this.languagePictureBox = new System.Windows.Forms.PictureBox();
            this.germanBtn = new System.Windows.Forms.Button();
            this.italianbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.languagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.instructionLabel.Location = new System.Drawing.Point(61, 261);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(860, 103);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Select a language and I will say Good Morning.";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.translationLabel.Location = new System.Drawing.Point(61, 387);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(860, 74);
            this.translationLabel.TabIndex = 1;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spanishBtn
            // 
            this.spanishBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.spanishBtn.Location = new System.Drawing.Point(410, 510);
            this.spanishBtn.Name = "spanishBtn";
            this.spanishBtn.Size = new System.Drawing.Size(130, 50);
            this.spanishBtn.TabIndex = 4;
            this.spanishBtn.Text = "Spanish";
            this.spanishBtn.UseVisualStyleBackColor = true;
            this.spanishBtn.Click += new System.EventHandler(this.spanishBtn_Click);
            // 
            // languagePictureBox
            // 
            this.languagePictureBox.ImageLocation = "https://www.thestartupfounder.com/wp-content/uploads/2022/07/dil_1_OLHP_786x400.j" +
    "pg";
            this.languagePictureBox.Location = new System.Drawing.Point(61, 12);
            this.languagePictureBox.Name = "languagePictureBox";
            this.languagePictureBox.Size = new System.Drawing.Size(860, 236);
            this.languagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.languagePictureBox.TabIndex = 5;
            this.languagePictureBox.TabStop = false;
            this.languagePictureBox.Click += new System.EventHandler(this.languagePictureBox_Click);
            // 
            // germanBtn
            // 
            this.germanBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.germanBtn.Location = new System.Drawing.Point(791, 510);
            this.germanBtn.Name = "germanBtn";
            this.germanBtn.Size = new System.Drawing.Size(130, 50);
            this.germanBtn.TabIndex = 3;
            this.germanBtn.Text = "German";
            this.germanBtn.UseVisualStyleBackColor = true;
            this.germanBtn.Click += new System.EventHandler(this.germanBtn_Click);
            // 
            // italianbtn
            // 
            this.italianbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italianbtn.Image = global::Language_Translator.Properties.Resources.Flag_of_Italy_svg;
            this.italianbtn.Location = new System.Drawing.Point(61, 510);
            this.italianbtn.Name = "italianbtn";
            this.italianbtn.Size = new System.Drawing.Size(130, 50);
            this.italianbtn.TabIndex = 2;
            this.italianbtn.Text = "Italian";
            this.italianbtn.UseVisualStyleBackColor = true;
            this.italianbtn.Click += new System.EventHandler(this.italianbtn_Click);
            // 
            // languageTranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 600);
            this.Controls.Add(this.languagePictureBox);
            this.Controls.Add(this.spanishBtn);
            this.Controls.Add(this.germanBtn);
            this.Controls.Add(this.italianbtn);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.instructionLabel);
            this.Name = "languageTranslatorForm";
            this.Text = "Language Translator";
            ((System.ComponentModel.ISupportInitialize)(this.languagePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Button italianbtn;
        private System.Windows.Forms.Button germanBtn;
        private System.Windows.Forms.Button spanishBtn;
        private System.Windows.Forms.PictureBox languagePictureBox;
    }
}

