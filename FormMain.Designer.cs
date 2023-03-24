using BrightIdeasSoftware;

namespace Timestamper
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            olv = new ObjectListView();
            colName = new OLVColumn();
            colType = new OLVColumn();
            colSize = new OLVColumn();
            colModTime = new OLVColumn();
            colCreateTime = new OLVColumn();
            colNewName = new OLVColumn();
            buttonRename = new Button();
            textBoxPath = new TextBox();
            comboBoxFormat = new ComboBox();
            radioButtonModificationTime = new RadioButton();
            radioButtonCreationTime = new RadioButton();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)olv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // olv
            // 
            olv.CellEditUseWholeCell = false;
            olv.Columns.AddRange(new ColumnHeader[] { colName, colType, colSize, colModTime, colCreateTime, colNewName });
            olv.Location = new Point(12, 41);
            olv.Name = "olv";
            olv.ShowGroups = false;
            olv.Size = new Size(583, 248);
            olv.TabIndex = 0;
            olv.View = View.Details;
            // 
            // colName
            // 
            colName.AspectName = "Name";
            colName.MaximumWidth = 750;
            colName.MinimumWidth = 200;
            colName.Text = "Name";
            colName.Width = 275;
            // 
            // colType
            // 
            colType.AspectName = "Type";
            colType.Text = "Type";
            colType.Width = 50;
            // 
            // colSize
            // 
            colSize.AspectName = "Size";
            colSize.Text = "Size";
            colSize.Width = 75;
            // 
            // colModTime
            // 
            colModTime.AspectName = "DateModified";
            colModTime.Text = "Last Modified";
            colModTime.Width = 140;
            // 
            // colCreateTime
            // 
            colCreateTime.AspectName = "DateCreated";
            colCreateTime.Text = "Created";
            colCreateTime.Width = 140;
            // 
            // colNewName
            // 
            colNewName.AspectName = "NewName";
            colNewName.FillsFreeSpace = true;
            colNewName.MinimumWidth = 200;
            colNewName.Text = "New name";
            colNewName.Width = 500;
            // 
            // buttonRename
            // 
            buttonRename.Location = new Point(12, 12);
            buttonRename.Name = "buttonRename";
            buttonRename.Size = new Size(75, 23);
            buttonRename.TabIndex = 0;
            buttonRename.Text = "Rename";
            buttonRename.UseVisualStyleBackColor = true;
            buttonRename.Click += buttonRename_Click;
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(93, 12);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(320, 23);
            textBoxPath.TabIndex = 1;
            textBoxPath.Text = "C:\\Users\\";
            textBoxPath.TextChanged += textBoxPath_TextChanged;
            textBoxPath.KeyUp += textBoxPath_KeyUp;
            // 
            // comboBoxFormat
            // 
            comboBoxFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFormat.FormattingEnabled = true;
            comboBoxFormat.Items.AddRange(new object[] { "yyyy-MM-dd_HH-mm-ss", "yyyy-MM-dd HH-mm-ss", "HH-mm-ss" });
            comboBoxFormat.Location = new Point(448, 12);
            comboBoxFormat.Name = "comboBoxFormat";
            comboBoxFormat.Size = new Size(176, 23);
            comboBoxFormat.TabIndex = 2;
            comboBoxFormat.SelectedIndexChanged += comboBoxFormat_SelectedIndexChanged;
            // 
            // radioButtonModificationTime
            // 
            radioButtonModificationTime.AutoSize = true;
            radioButtonModificationTime.Checked = true;
            radioButtonModificationTime.Location = new Point(630, 14);
            radioButtonModificationTime.Name = "radioButtonModificationTime";
            radioButtonModificationTime.Size = new Size(120, 19);
            radioButtonModificationTime.TabIndex = 3;
            radioButtonModificationTime.TabStop = true;
            radioButtonModificationTime.Text = "Modification time";
            radioButtonModificationTime.UseVisualStyleBackColor = true;
            radioButtonModificationTime.CheckedChanged += radioButtonModificationTime_CheckedChanged;
            // 
            // radioButtonCreationTime
            // 
            radioButtonCreationTime.AutoSize = true;
            radioButtonCreationTime.Location = new Point(756, 13);
            radioButtonCreationTime.Name = "radioButtonCreationTime";
            radioButtonCreationTime.Size = new Size(97, 19);
            radioButtonCreationTime.TabIndex = 4;
            radioButtonCreationTime.Text = "Creation time";
            radioButtonCreationTime.UseVisualStyleBackColor = true;
            radioButtonCreationTime.CheckedChanged += radioButtonCreationTime_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(419, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 402);
            Controls.Add(pictureBox1);
            Controls.Add(radioButtonCreationTime);
            Controls.Add(radioButtonModificationTime);
            Controls.Add(olv);
            Controls.Add(comboBoxFormat);
            Controls.Add(textBoxPath);
            Controls.Add(buttonRename);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "Timestamper";
            Load += FormMain_Load;
            Resize += FormMain_Resize;
            ((System.ComponentModel.ISupportInitialize)olv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ObjectListView olv;
        private OLVColumn colName, colType, colSize, colModTime, colCreateTime, colNewName;
        private Button buttonRename;
        private TextBox textBoxPath;
        private ComboBox comboBoxFormat;
        private RadioButton radioButtonModificationTime;
        private RadioButton radioButtonCreationTime;
        private PictureBox pictureBox1;
    }
}