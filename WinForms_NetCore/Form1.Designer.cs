
namespace WinForms_NetCore
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1SongsDGV = new System.Windows.Forms.Label();
            this.testDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(14, 81);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(98, 32);
            this.labelTest.TabIndex = 1;
            this.labelTest.Text = "&Second:";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(121, 79);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(189, 39);
            this.textBoxText.TabIndex = 2;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(14, 171);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(107, 32);
            this.labelBirthday.TabIndex = 3;
            this.labelBirthday.Text = "&Birthday:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(379, 39);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1SongsDGV
            // 
            this.label1SongsDGV.AutoSize = true;
            this.label1SongsDGV.Location = new System.Drawing.Point(14, 254);
            this.label1SongsDGV.Name = "label1SongsDGV";
            this.label1SongsDGV.Size = new System.Drawing.Size(84, 32);
            this.label1SongsDGV.TabIndex = 5;
            this.label1SongsDGV.Text = "S&ongs:";
            // 
            // testDataGridView
            // 
            this.testDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testDataGridView.Location = new System.Drawing.Point(14, 303);
            this.testDataGridView.Name = "testDataGridView";
            this.testDataGridView.RowHeadersWidth = 82;
            this.testDataGridView.RowTemplate.Height = 41;
            this.testDataGridView.Size = new System.Drawing.Size(841, 167);
            this.testDataGridView.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 549);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1SongsDGV);
            this.Controls.Add(this.testDataGridView);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WinForms NetCore";
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1SongsDGV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView testDataGridView;
    }
}

