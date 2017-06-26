namespace CompareText
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnCompare = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel6 = new System.Windows.Forms.Panel();
      this.panel8 = new System.Windows.Forms.Panel();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.panel4 = new System.Windows.Forms.Panel();
      this.btnFile2 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.textFile2 = new System.Windows.Forms.TextBox();
      this.panel5 = new System.Windows.Forms.Panel();
      this.panel7 = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.panel3 = new System.Windows.Forms.Panel();
      this.btnFile1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.textFile1 = new System.Windows.Forms.TextBox();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
      this.panel9 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel8.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel7.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel9.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnClose);
      this.panel1.Controls.Add(this.btnCompare);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 415);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(914, 56);
      this.panel1.TabIndex = 2;
      // 
      // btnClose
      // 
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.Location = new System.Drawing.Point(823, 13);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(77, 35);
      this.btnClose.TabIndex = 25;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnCompare
      // 
      this.btnCompare.Location = new System.Drawing.Point(725, 13);
      this.btnCompare.Name = "btnCompare";
      this.btnCompare.Size = new System.Drawing.Size(77, 35);
      this.btnCompare.TabIndex = 20;
      this.btnCompare.Text = "Compare";
      this.btnCompare.UseVisualStyleBackColor = true;
      this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.panel6);
      this.panel2.Controls.Add(this.panel5);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 38);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(914, 377);
      this.panel2.TabIndex = 1;
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.panel8);
      this.panel6.Controls.Add(this.panel4);
      this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel6.Location = new System.Drawing.Point(455, 0);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(459, 377);
      this.panel6.TabIndex = 1;
      // 
      // panel8
      // 
      this.panel8.Controls.Add(this.textBox2);
      this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel8.Location = new System.Drawing.Point(0, 49);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(459, 328);
      this.panel8.TabIndex = 2;
      // 
      // textBox2
      // 
      this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox2.Location = new System.Drawing.Point(0, 0);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBox2.Size = new System.Drawing.Size(459, 328);
      this.textBox2.TabIndex = 35;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.btnFile2);
      this.panel4.Controls.Add(this.label2);
      this.panel4.Controls.Add(this.textFile2);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel4.Location = new System.Drawing.Point(0, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(459, 49);
      this.panel4.TabIndex = 1;
      // 
      // btnFile2
      // 
      this.btnFile2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFile2.Location = new System.Drawing.Point(412, 12);
      this.btnFile2.Name = "btnFile2";
      this.btnFile2.Size = new System.Drawing.Size(33, 23);
      this.btnFile2.TabIndex = 10;
      this.btnFile2.Text = "...";
      this.btnFile2.UseVisualStyleBackColor = true;
      this.btnFile2.Click += new System.EventHandler(this.btnFile2_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(7, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(47, 17);
      this.label2.TabIndex = 1;
      this.label2.Text = "File B:";
      // 
      // textFile2
      // 
      this.textFile2.Location = new System.Drawing.Point(57, 12);
      this.textFile2.Name = "textFile2";
      this.textFile2.Size = new System.Drawing.Size(343, 22);
      this.textFile2.TabIndex = 15;
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.panel7);
      this.panel5.Controls.Add(this.panel3);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel5.Location = new System.Drawing.Point(0, 0);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(455, 377);
      this.panel5.TabIndex = 0;
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.textBox1);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel7.Location = new System.Drawing.Point(0, 49);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(455, 328);
      this.panel7.TabIndex = 1;
      // 
      // textBox1
      // 
      this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBox1.Location = new System.Drawing.Point(0, 0);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBox1.Size = new System.Drawing.Size(455, 328);
      this.textBox1.TabIndex = 30;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.btnFile1);
      this.panel3.Controls.Add(this.label1);
      this.panel3.Controls.Add(this.textFile1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(455, 49);
      this.panel3.TabIndex = 0;
      // 
      // btnFile1
      // 
      this.btnFile1.Location = new System.Drawing.Point(416, 12);
      this.btnFile1.Name = "btnFile1";
      this.btnFile1.Size = new System.Drawing.Size(33, 23);
      this.btnFile1.TabIndex = 0;
      this.btnFile1.Text = "...";
      this.btnFile1.UseVisualStyleBackColor = true;
      this.btnFile1.Click += new System.EventHandler(this.btnFile1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "File A:";
      // 
      // textFile1
      // 
      this.textFile1.Location = new System.Drawing.Point(57, 12);
      this.textFile1.Name = "textFile1";
      this.textFile1.Size = new System.Drawing.Size(343, 22);
      this.textFile1.TabIndex = 5;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "Text|*.txt";
      // 
      // openFileDialog2
      // 
      this.openFileDialog2.FileName = "openFileDialog2";
      // 
      // panel9
      // 
      this.panel9.Controls.Add(this.label3);
      this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel9.Location = new System.Drawing.Point(0, 0);
      this.panel9.Name = "panel9";
      this.panel9.Size = new System.Drawing.Size(914, 38);
      this.panel9.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(14, 11);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(506, 17);
      this.label3.TabIndex = 0;
      this.label3.Text = "This App compares de frequency of words of text files Left and Right";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(914, 471);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panel9);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Word Comparison";
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel6.ResumeLayout(false);
      this.panel8.ResumeLayout(false);
      this.panel8.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel9.ResumeLayout(false);
      this.panel9.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Button btnFile1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textFile1;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Button btnFile2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textFile2;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.OpenFileDialog openFileDialog2;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Panel panel8;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button btnCompare;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Panel panel9;
    private System.Windows.Forms.Label label3;
  }
}

