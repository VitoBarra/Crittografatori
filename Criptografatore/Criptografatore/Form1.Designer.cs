namespace Criptografatore
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CriTextBox = new System.Windows.Forms.TextBox();
            this.Crittog_Tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.CritButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.DecriButton = new System.Windows.Forms.Button();
            this.DecriTextBox = new System.Windows.Forms.TextBox();
            this.Crittog_Tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CriTextBox
            // 
            this.CriTextBox.Location = new System.Drawing.Point(19, 24);
            this.CriTextBox.Name = "CriTextBox";
            this.CriTextBox.Size = new System.Drawing.Size(166, 20);
            this.CriTextBox.TabIndex = 0;
            this.CriTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.CriTextBox_Validating);
            // 
            // Crittog_Tab
            // 
            this.Crittog_Tab.Controls.Add(this.tabPage1);
            this.Crittog_Tab.Controls.Add(this.tabPage2);
            this.Crittog_Tab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Crittog_Tab.Location = new System.Drawing.Point(12, 12);
            this.Crittog_Tab.Name = "Crittog_Tab";
            this.Crittog_Tab.SelectedIndex = 0;
            this.Crittog_Tab.Size = new System.Drawing.Size(209, 113);
            this.Crittog_Tab.TabIndex = 1;
            this.Crittog_Tab.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CritButton);
            this.tabPage1.Controls.Add(this.CriTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(201, 87);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chiave:";
            // 
            // CritButton
            // 
            this.CritButton.Location = new System.Drawing.Point(19, 50);
            this.CritButton.Name = "CritButton";
            this.CritButton.Size = new System.Drawing.Size(166, 23);
            this.CritButton.TabIndex = 1;
            this.CritButton.Text = "Crittogra File";
            this.CritButton.UseVisualStyleBackColor = true;
            this.CritButton.Click += new System.EventHandler(this.CritButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.DecriButton);
            this.tabPage2.Controls.Add(this.DecriTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(201, 87);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chiave:";
            // 
            // DecriButton
            // 
            this.DecriButton.Location = new System.Drawing.Point(19, 50);
            this.DecriButton.Name = "DecriButton";
            this.DecriButton.Size = new System.Drawing.Size(166, 23);
            this.DecriButton.TabIndex = 5;
            this.DecriButton.Text = "Decrittofa File";
            this.DecriButton.UseVisualStyleBackColor = true;
            this.DecriButton.Click += new System.EventHandler(this.DecriButton_Click);
            // 
            // DecriTextBox
            // 
            this.DecriTextBox.Location = new System.Drawing.Point(19, 24);
            this.DecriTextBox.Name = "DecriTextBox";
            this.DecriTextBox.Size = new System.Drawing.Size(166, 20);
            this.DecriTextBox.TabIndex = 4;
            this.DecriTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DecriTextBox_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 134);
            this.Controls.Add(this.Crittog_Tab);
            this.Name = "Form1";
            this.Text = "Critto/Decritto";
            this.Crittog_Tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox CriTextBox;
        private System.Windows.Forms.TabControl Crittog_Tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button CritButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DecriButton;
        private System.Windows.Forms.TextBox DecriTextBox;
    }
}

