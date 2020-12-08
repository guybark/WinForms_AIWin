
namespace WinForms_NetFramework_AIWinFailures
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
            this.labelTest = new System.Windows.Forms.Label();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.testDataGridView = new System.Windows.Forms.DataGridView();
            this.labelSongsDGV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(730, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(20, 96);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(91, 25);
            this.labelTest.TabIndex = 1;
            this.labelTest.Text = "&Second:";
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(123, 94);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(109, 31);
            this.textBoxTest.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 180);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 31);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(20, 182);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(97, 25);
            this.labelBirthday.TabIndex = 4;
            this.labelBirthday.Text = "Birthday:";
            // 
            // testDataGridView
            // 
            this.testDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testDataGridView.Location = new System.Drawing.Point(25, 289);
            this.testDataGridView.Name = "testDataGridView";
            this.testDataGridView.RowHeadersWidth = 82;
            this.testDataGridView.RowTemplate.Height = 33;
            this.testDataGridView.Size = new System.Drawing.Size(836, 150);
            this.testDataGridView.TabIndex = 5;
            // 
            // labelSongsDGV
            // 
            this.labelSongsDGV.AutoSize = true;
            this.labelSongsDGV.Location = new System.Drawing.Point(20, 251);
            this.labelSongsDGV.Name = "labelSongsDGV";
            this.labelSongsDGV.Size = new System.Drawing.Size(79, 25);
            this.labelSongsDGV.TabIndex = 6;
            this.labelSongsDGV.Text = "S&ongs:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 539);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.textBoxTest);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelSongsDGV);
            this.Controls.Add(this.testDataGridView);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NETFramework AIWin Failures";
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.DataGridView testDataGridView;
        private System.Windows.Forms.Label labelSongsDGV;
    }
}

