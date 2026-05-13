namespace Ngu_223004085
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.booksP = new System.Windows.Forms.TabPage();
            this.groupBookList = new System.Windows.Forms.GroupBox();
            this.BOrder = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qOHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds1 = new Ngu_223004085.DataSet1();
            this.bookTableAdapter1 = new Ngu_223004085.DataSet1TableAdapters.BookTableAdapter();
            this.bTa2 = new Ngu_223004085.DataSet1TableAdapters.BookTableAdapter();
            this.tabControl1.SuspendLayout();
            this.booksP.SuspendLayout();
            this.groupBookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.booksP);
            this.tabControl1.Controls.Add(this.BOrder);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // booksP
            // 
            this.booksP.Controls.Add(this.groupBookList);
            this.booksP.Location = new System.Drawing.Point(4, 22);
            this.booksP.Name = "booksP";
            this.booksP.Padding = new System.Windows.Forms.Padding(3);
            this.booksP.Size = new System.Drawing.Size(792, 424);
            this.booksP.TabIndex = 0;
            this.booksP.Text = "Books";
            this.booksP.UseVisualStyleBackColor = true;
            this.booksP.Click += new System.EventHandler(this.booksP_Click);
            // 
            // groupBookList
            // 
            this.groupBookList.Controls.Add(this.dataGridView1);
            this.groupBookList.Location = new System.Drawing.Point(26, 28);
            this.groupBookList.Name = "groupBookList";
            this.groupBookList.Size = new System.Drawing.Size(433, 339);
            this.groupBookList.TabIndex = 0;
            this.groupBookList.TabStop = false;
            this.groupBookList.Text = "BookList";
            // 
            // BOrder
            // 
            this.BOrder.Location = new System.Drawing.Point(4, 22);
            this.BOrder.Name = "BOrder";
            this.BOrder.Padding = new System.Windows.Forms.Padding(3);
            this.BOrder.Size = new System.Drawing.Size(792, 424);
            this.BOrder.TabIndex = 1;
            this.BOrder.Text = "BookOrder";
            this.BOrder.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookTitleDataGridViewTextBoxColumn,
            this.bookCostDataGridViewTextBoxColumn,
            this.qOHDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(800, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            // 
            // bookCostDataGridViewTextBoxColumn
            // 
            this.bookCostDataGridViewTextBoxColumn.DataPropertyName = "BookCost";
            this.bookCostDataGridViewTextBoxColumn.HeaderText = "BookCost";
            this.bookCostDataGridViewTextBoxColumn.Name = "bookCostDataGridViewTextBoxColumn";
            // 
            // qOHDataGridViewTextBoxColumn
            // 
            this.qOHDataGridViewTextBoxColumn.DataPropertyName = "QOH";
            this.qOHDataGridViewTextBoxColumn.HeaderText = "QOH";
            this.qOHDataGridViewTextBoxColumn.Name = "qOHDataGridViewTextBoxColumn";
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.ds1;
            // 
            // ds1
            // 
            this.ds1.DataSetName = "DataSet1";
            this.ds1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter1
            // 
            this.bookTableAdapter1.ClearBeforeFill = true;
            // 
            // bTa2
            // 
            this.bTa2.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.booksP.ResumeLayout(false);
            this.groupBookList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage booksP;
        private System.Windows.Forms.TabPage BOrder;
        private System.Windows.Forms.GroupBox groupBookList;
        private DataSet1 ds1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qOHDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private DataSet1TableAdapters.BookTableAdapter bookTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private DataSet1TableAdapters.BookTableAdapter bTa2;
    }
}

