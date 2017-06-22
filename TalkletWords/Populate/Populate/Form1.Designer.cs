namespace Populate
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnVocabulary = new System.Windows.Forms.Button();
            this.btnMLU = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnWordData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVocabulary
            // 
            this.btnVocabulary.Location = new System.Drawing.Point(378, 72);
            this.btnVocabulary.Name = "btnVocabulary";
            this.btnVocabulary.Size = new System.Drawing.Size(75, 23);
            this.btnVocabulary.TabIndex = 1;
            this.btnVocabulary.Text = "Vocab";
            this.btnVocabulary.UseVisualStyleBackColor = true;
            this.btnVocabulary.Click += new System.EventHandler(this.btnVocabulary_Click);
            // 
            // btnMLU
            // 
            this.btnMLU.Location = new System.Drawing.Point(379, 122);
            this.btnMLU.Name = "btnMLU";
            this.btnMLU.Size = new System.Drawing.Size(75, 23);
            this.btnMLU.TabIndex = 2;
            this.btnMLU.Text = "MLU";
            this.btnMLU.UseVisualStyleBackColor = true;
            this.btnMLU.Click += new System.EventHandler(this.btnMLU_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(382, 169);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(75, 23);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(270, 32);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(75, 23);
            this.btnData.TabIndex = 4;
            this.btnData.Text = "Words";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnWordData
            // 
            this.btnWordData.Location = new System.Drawing.Point(270, 86);
            this.btnWordData.Name = "btnWordData";
            this.btnWordData.Size = new System.Drawing.Size(75, 23);
            this.btnWordData.TabIndex = 5;
            this.btnWordData.Text = "Word Data";
            this.btnWordData.UseVisualStyleBackColor = true;
            this.btnWordData.Click += new System.EventHandler(this.btnWordData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 305);
            this.Controls.Add(this.btnWordData);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnCategory);
            this.Controls.Add(this.btnMLU);
            this.Controls.Add(this.btnVocabulary);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVocabulary;
        private System.Windows.Forms.Button btnMLU;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnWordData;
    }
}

