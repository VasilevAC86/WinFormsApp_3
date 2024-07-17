namespace WinFormsApp_3
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
            lstSourse = new ListBox();
            lstDest = new ListBox();
            btnAddDest = new Button();
            btnAddDestAll = new Button();
            btnClearDest = new Button();
            chbDelSourse = new CheckBox();
            btnAddSource = new Button();
            btnAddSourseAll = new Button();
            pbSourse = new ProgressBar();
            pbDest = new ProgressBar();
            btnForm2 = new Button();
            SuspendLayout();
            // 
            // lstSourse
            // 
            lstSourse.FormattingEnabled = true;
            lstSourse.ItemHeight = 15;
            lstSourse.Items.AddRange(new object[] { "Физика", "Химия", "Математика", "Черчение", "Музыка" });
            lstSourse.Location = new Point(61, 28);
            lstSourse.Name = "lstSourse";
            lstSourse.SelectionMode = SelectionMode.MultiSimple;
            lstSourse.Size = new Size(150, 259);
            lstSourse.TabIndex = 0;
            // 
            // lstDest
            // 
            lstDest.FormattingEnabled = true;
            lstDest.ItemHeight = 15;
            lstDest.Location = new Point(322, 28);
            lstDest.Name = "lstDest";
            lstDest.Size = new Size(150, 259);
            lstDest.TabIndex = 1;
            // 
            // btnAddDest
            // 
            btnAddDest.Location = new Point(237, 28);
            btnAddDest.Name = "btnAddDest";
            btnAddDest.Size = new Size(65, 23);
            btnAddDest.TabIndex = 2;
            btnAddDest.Text = "->";
            btnAddDest.UseVisualStyleBackColor = true;
            btnAddDest.Click += btnAddDest_Click;
            // 
            // btnAddDestAll
            // 
            btnAddDestAll.Location = new Point(237, 73);
            btnAddDestAll.Name = "btnAddDestAll";
            btnAddDestAll.Size = new Size(65, 23);
            btnAddDestAll.TabIndex = 3;
            btnAddDestAll.Text = "->>";
            btnAddDestAll.UseVisualStyleBackColor = true;
            btnAddDestAll.Click += btnAddDestAll_Click;
            // 
            // btnClearDest
            // 
            btnClearDest.Enabled = false;
            btnClearDest.Location = new Point(237, 253);
            btnClearDest.Name = "btnClearDest";
            btnClearDest.Size = new Size(65, 23);
            btnClearDest.TabIndex = 4;
            btnClearDest.Text = "C";
            btnClearDest.UseVisualStyleBackColor = true;
            btnClearDest.Click += btnClearDest_Click;
            // 
            // chbDelSourse
            // 
            chbDelSourse.AutoSize = true;
            chbDelSourse.Location = new Point(502, 30);
            chbDelSourse.Name = "chbDelSourse";
            chbDelSourse.Size = new Size(146, 19);
            chbDelSourse.TabIndex = 5;
            chbDelSourse.Text = "Удалить из источника";
            chbDelSourse.UseVisualStyleBackColor = true;
            // 
            // btnAddSource
            // 
            btnAddSource.Enabled = false;
            btnAddSource.Location = new Point(237, 114);
            btnAddSource.Name = "btnAddSource";
            btnAddSource.Size = new Size(65, 23);
            btnAddSource.TabIndex = 6;
            btnAddSource.Text = "<-";
            btnAddSource.UseVisualStyleBackColor = true;
            btnAddSource.Click += btnAddSource_Click;
            // 
            // btnAddSourseAll
            // 
            btnAddSourseAll.Enabled = false;
            btnAddSourseAll.Location = new Point(237, 160);
            btnAddSourseAll.Name = "btnAddSourseAll";
            btnAddSourseAll.Size = new Size(65, 23);
            btnAddSourseAll.TabIndex = 7;
            btnAddSourseAll.Text = "<<-";
            btnAddSourseAll.UseVisualStyleBackColor = true;
            btnAddSourseAll.Click += btnAddSourseAll_Click;
            // 
            // pbSourse
            // 
            pbSourse.Location = new Point(64, 314);
            pbSourse.Name = "pbSourse";
            pbSourse.Size = new Size(147, 23);
            pbSourse.Step = 20;
            pbSourse.TabIndex = 8;
            // 
            // pbDest
            // 
            pbDest.Location = new Point(323, 313);
            pbDest.Name = "pbDest";
            pbDest.Size = new Size(149, 23);
            pbDest.TabIndex = 9;
            // 
            // btnForm2
            // 
            btnForm2.Location = new Point(520, 82);
            btnForm2.Name = "btnForm2";
            btnForm2.Size = new Size(117, 23);
            btnForm2.TabIndex = 10;
            btnForm2.TabStop = false;
            btnForm2.Text = "Открыть форму 2";
            btnForm2.UseVisualStyleBackColor = true;
            btnForm2.Click += btnForm2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnForm2);
            Controls.Add(pbDest);
            Controls.Add(pbSourse);
            Controls.Add(btnAddSourseAll);
            Controls.Add(btnAddSource);
            Controls.Add(chbDelSourse);
            Controls.Add(btnClearDest);
            Controls.Add(btnAddDestAll);
            Controls.Add(btnAddDest);
            Controls.Add(lstDest);
            Controls.Add(lstSourse);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSourse;
        private ListBox lstDest;
        private Button btnAddDest;
        private Button btnAddDestAll;
        private Button btnClearDest;
        private CheckBox chbDelSourse;
        private Button btnAddSource;
        private Button btnAddSourseAll;
        private ProgressBar pbSourse;
        private ProgressBar pbDest;
        private Button btnForm2;
    }
}
