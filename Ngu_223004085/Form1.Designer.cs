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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.booksP = new System.Windows.Forms.TabPage();
            this.BOrder = new System.Windows.Forms.TabPage();
            this.groupBookList = new System.Windows.Forms.GroupBox();
            this.dataSet11 = new Ngu_223004085.DataSet1();
            this.tabControl1.SuspendLayout();
            this.booksP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
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
            // groupBookList
            // 
            this.groupBookList.Location = new System.Drawing.Point(26, 28);
            this.groupBookList.Name = "groupBookList";
            this.groupBookList.Size = new System.Drawing.Size(433, 339);
            this.groupBookList.TabIndex = 0;
            this.groupBookList.TabStop = false;
            this.groupBookList.Text = "BookList";
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.booksP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage booksP;
        private System.Windows.Forms.TabPage BOrder;
        private System.Windows.Forms.GroupBox groupBookList;
        private DataSet1 dataSet11;
    }
}

