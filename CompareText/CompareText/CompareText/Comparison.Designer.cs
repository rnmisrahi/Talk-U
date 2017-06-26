namespace CompareText
{
  partial class Comparison
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dgv = new System.Windows.Forms.DataGridView();
      this.colWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colDiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.btnClose = new System.Windows.Forms.Button();
      this.btnDifferences = new System.Windows.Forms.Button();
      this.btnAll = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.lblResults = new System.Windows.Forms.Label();
      this.lblLD = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgv
      // 
      this.dgv.AllowUserToAddRows = false;
      this.dgv.AllowUserToDeleteRows = false;
      this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colWord,
            this.colLeft,
            this.colRight,
            this.colDiff});
      this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgv.Location = new System.Drawing.Point(0, 81);
      this.dgv.Name = "dgv";
      this.dgv.ReadOnly = true;
      this.dgv.RowTemplate.Height = 24;
      this.dgv.Size = new System.Drawing.Size(670, 380);
      this.dgv.TabIndex = 3;
      // 
      // colWord
      // 
      this.colWord.HeaderText = "Word";
      this.colWord.Name = "colWord";
      this.colWord.ReadOnly = true;
      this.colWord.Width = 200;
      // 
      // colLeft
      // 
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.colLeft.DefaultCellStyle = dataGridViewCellStyle1;
      this.colLeft.HeaderText = "Left";
      this.colLeft.Name = "colLeft";
      this.colLeft.ReadOnly = true;
      this.colLeft.Width = 50;
      // 
      // colRight
      // 
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      this.colRight.DefaultCellStyle = dataGridViewCellStyle2;
      this.colRight.HeaderText = "Right";
      this.colRight.Name = "colRight";
      this.colRight.ReadOnly = true;
      this.colRight.Width = 50;
      // 
      // colDiff
      // 
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.colDiff.DefaultCellStyle = dataGridViewCellStyle3;
      this.colDiff.HeaderText = "Diff";
      this.colDiff.Name = "colDiff";
      this.colDiff.ReadOnly = true;
      this.colDiff.Width = 50;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnClose);
      this.panel1.Controls.Add(this.btnDifferences);
      this.panel1.Controls.Add(this.btnAll);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 461);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(670, 49);
      this.panel1.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "label1";
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnClose.Location = new System.Drawing.Point(583, 13);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 31);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnDifferences
      // 
      this.btnDifferences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnDifferences.Location = new System.Drawing.Point(279, 13);
      this.btnDifferences.Name = "btnDifferences";
      this.btnDifferences.Size = new System.Drawing.Size(138, 31);
      this.btnDifferences.TabIndex = 0;
      this.btnDifferences.Text = "Show Differences";
      this.btnDifferences.UseVisualStyleBackColor = true;
      this.btnDifferences.Click += new System.EventHandler(this.btnDifferences_Click);
      // 
      // btnAll
      // 
      this.btnAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAll.Location = new System.Drawing.Point(432, 13);
      this.btnAll.Name = "btnAll";
      this.btnAll.Size = new System.Drawing.Size(138, 31);
      this.btnAll.TabIndex = 0;
      this.btnAll.Text = "Show All";
      this.btnAll.UseVisualStyleBackColor = true;
      this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.lblLD);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Controls.Add(this.lblResults);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(670, 81);
      this.panel2.TabIndex = 5;
      // 
      // lblResults
      // 
      this.lblResults.AutoSize = true;
      this.lblResults.Location = new System.Drawing.Point(12, 9);
      this.lblResults.Name = "lblResults";
      this.lblResults.Size = new System.Drawing.Size(69, 17);
      this.lblResults.TabIndex = 0;
      this.lblResults.Text = "lblResults";
      // 
      // lblLD
      // 
      this.lblLD.AutoSize = true;
      this.lblLD.Location = new System.Drawing.Point(12, 33);
      this.lblLD.Name = "lblLD";
      this.lblLD.Size = new System.Drawing.Size(40, 17);
      this.lblLD.TabIndex = 3;
      this.lblLD.Text = "lblLD";
      // 
      // Comparison
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(670, 510);
      this.Controls.Add(this.dgv);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "Comparison";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Comparison";
      this.Load += new System.EventHandler(this.Comparison_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DataGridView dgv;
    private System.Windows.Forms.DataGridViewTextBoxColumn colWord;
    private System.Windows.Forms.DataGridViewTextBoxColumn colLeft;
    private System.Windows.Forms.DataGridViewTextBoxColumn colRight;
    private System.Windows.Forms.DataGridViewTextBoxColumn colDiff;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnDifferences;
    private System.Windows.Forms.Button btnAll;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Label lblResults;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblLD;
  }
}