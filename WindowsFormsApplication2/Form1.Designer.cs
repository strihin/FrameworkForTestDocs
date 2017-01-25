namespace WindowsFormsApplication2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblProjectName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.elementsOfProject = new System.Windows.Forms.TreeView();
            this.notePad = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cbAddNewTestDoc = new System.Windows.Forms.ComboBox();
            this.btnHelper = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withPatternTestDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emptyProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingProject = new System.Windows.Forms.OpenFileDialog();
            this.btnAddUnitDoc = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(12, 40);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(78, 13);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "Project name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(351, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CheckList";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(411, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // elementsOfProject
            // 
            this.elementsOfProject.Location = new System.Drawing.Point(12, 175);
            this.elementsOfProject.Name = "elementsOfProject";
            this.elementsOfProject.Size = new System.Drawing.Size(179, 259);
            this.elementsOfProject.TabIndex = 5;
            this.elementsOfProject.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.elementsOfProject_AfterSelect);
            // 
            // notePad
            // 
            this.notePad.Location = new System.Drawing.Point(207, 105);
            this.notePad.Name = "notePad";
            this.notePad.Size = new System.Drawing.Size(389, 297);
            this.notePad.TabIndex = 6;
            this.notePad.Text = "";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(544, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(484, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Test Suits";
            this.label3.Visible = false;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(280, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(208, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bug Reports";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Edit test file :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Test docs:";
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(12, 64);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(128, 24);
            this.btnAddName.TabIndex = 13;
            this.btnAddName.Text = "Add name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(146, 64);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(45, 24);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(207, 399);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(389, 35);
            this.btnSaveChanges.TabIndex = 15;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cbAddNewTestDoc
            // 
            this.cbAddNewTestDoc.FormattingEnabled = true;
            this.cbAddNewTestDoc.Items.AddRange(new object[] {
            "Add Check to Checklist",
            "Add Suite to SuiteList",
            "Add Case to Suite",
            "Add BugReport "});
            this.cbAddNewTestDoc.Location = new System.Drawing.Point(12, 105);
            this.cbAddNewTestDoc.Name = "cbAddNewTestDoc";
            this.cbAddNewTestDoc.Size = new System.Drawing.Size(128, 21);
            this.cbAddNewTestDoc.TabIndex = 16;
            this.cbAddNewTestDoc.Text = "Add new test element";
            // 
            // btnHelper
            // 
            this.btnHelper.Location = new System.Drawing.Point(548, 40);
            this.btnHelper.Name = "btnHelper";
            this.btnHelper.Size = new System.Drawing.Size(48, 43);
            this.btnHelper.TabIndex = 17;
            this.btnHelper.Text = "?";
            this.btnHelper.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createProjectToolStripMenuItem,
            this.openExistingProjectToolStripMenuItem,
            this.currentToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // createProjectToolStripMenuItem
            // 
            this.createProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withPatternTestDocToolStripMenuItem,
            this.emptyProjectToolStripMenuItem});
            this.createProjectToolStripMenuItem.Name = "createProjectToolStripMenuItem";
            this.createProjectToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.createProjectToolStripMenuItem.Text = "Create project";
            // 
            // withPatternTestDocToolStripMenuItem
            // 
            this.withPatternTestDocToolStripMenuItem.Name = "withPatternTestDocToolStripMenuItem";
            this.withPatternTestDocToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.withPatternTestDocToolStripMenuItem.Text = "With pattern test doc";
            this.withPatternTestDocToolStripMenuItem.Click += new System.EventHandler(this.withPatternTestDocToolStripMenuItem_Click);
            // 
            // emptyProjectToolStripMenuItem
            // 
            this.emptyProjectToolStripMenuItem.Name = "emptyProjectToolStripMenuItem";
            this.emptyProjectToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.emptyProjectToolStripMenuItem.Text = "Empty project";
            this.emptyProjectToolStripMenuItem.Click += new System.EventHandler(this.emptyProjectToolStripMenuItem_Click);
            // 
            // openExistingProjectToolStripMenuItem
            // 
            this.openExistingProjectToolStripMenuItem.Name = "openExistingProjectToolStripMenuItem";
            this.openExistingProjectToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.openExistingProjectToolStripMenuItem.Text = "Open existing project";
            this.openExistingProjectToolStripMenuItem.Click += new System.EventHandler(this.openExistingProjectToolStripMenuItem_Click);
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.currentToolStripMenuItem.Text = "Current project`s status";
            // 
            // openExistingProject
            // 
            this.openExistingProject.FileName = "openFileDialog1";
            // 
            // btnAddUnitDoc
            // 
            this.btnAddUnitDoc.Location = new System.Drawing.Point(146, 105);
            this.btnAddUnitDoc.Name = "btnAddUnitDoc";
            this.btnAddUnitDoc.Size = new System.Drawing.Size(45, 23);
            this.btnAddUnitDoc.TabIndex = 19;
            this.btnAddUnitDoc.Text = "Add";
            this.btnAddUnitDoc.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(447, 40);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 43);
            this.button4.TabIndex = 20;
            this.button4.Text = "serialization";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 448);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAddUnitDoc);
            this.Controls.Add(this.btnHelper);
            this.Controls.Add(this.cbAddNewTestDoc);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notePad);
            this.Controls.Add(this.elementsOfProject);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Framework for test doc";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView elementsOfProject;
        private System.Windows.Forms.RichTextBox notePad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ComboBox cbAddNewTestDoc;
        private System.Windows.Forms.Button btnHelper;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withPatternTestDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emptyProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExistingProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openExistingProject;
        private System.Windows.Forms.Button btnAddUnitDoc;
        private System.Windows.Forms.Button button4;
    }
}

