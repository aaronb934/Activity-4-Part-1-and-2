namespace CST_150_Activity_3
{
    partial class FrmMain
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
            button1 = new Button();
            lblSelectedFile = new Label();
            lblResults = new Label();
            selectFileDialog = new OpenFileDialog();
            lblSelectRow = new Label();
            cmbSelectRow = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkOliveGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(96, 53);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(120, 36);
            button1.TabIndex = 0;
            button1.Text = "Read File";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnReadFileClickEvent;
            // 
            // lblSelectedFile
            // 
            lblSelectedFile.Dock = DockStyle.Bottom;
            lblSelectedFile.Font = new Font("Segoe UI", 12F);
            lblSelectedFile.ForeColor = Color.Firebrick;
            lblSelectedFile.Location = new Point(0, 387);
            lblSelectedFile.Name = "lblSelectedFile";
            lblSelectedFile.Size = new Size(734, 19);
            lblSelectedFile.TabIndex = 1;
            lblSelectedFile.Text = "label1";
            lblSelectedFile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResults.Location = new Point(96, 152);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(67, 16);
            lblResults.TabIndex = 2;
            lblResults.Text = "label1";
            // 
            // selectFileDialog
            // 
            selectFileDialog.DefaultExt = "txt";
            selectFileDialog.FileName = "selectFileDialog";
            selectFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            selectFileDialog.InitialDirectory = "Application.StartupPath + @\"Data\"";
            selectFileDialog.Title = "Browse Txt Files";
            // 
            // lblSelectRow
            // 
            lblSelectRow.AutoSize = true;
            lblSelectRow.Location = new Point(421, 53);
            lblSelectRow.Name = "lblSelectRow";
            lblSelectRow.Size = new Size(64, 15);
            lblSelectRow.TabIndex = 3;
            lblSelectRow.Text = "Select Row";
            // 
            // cmbSelectRow
            // 
            cmbSelectRow.FormattingEnabled = true;
            cmbSelectRow.Location = new Point(421, 73);
            cmbSelectRow.Name = "cmbSelectRow";
            cmbSelectRow.Size = new Size(121, 23);
            cmbSelectRow.TabIndex = 4;
            cmbSelectRow.DropDownClosed += SelectRowToInc;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 406);
            Controls.Add(cmbSelectRow);
            Controls.Add(lblSelectRow);
            Controls.Add(lblResults);
            Controls.Add(lblSelectedFile);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMain";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblSelectedFile;
        private Label lblResults;
        private OpenFileDialog selectFileDialog;
        private Label lblSelectRow;
        private ComboBox cmbSelectRow;
    }
}
