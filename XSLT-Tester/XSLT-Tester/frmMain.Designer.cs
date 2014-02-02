namespace XSLT_Tester
{
    partial class frmMain
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
            this.grpXMLInput = new System.Windows.Forms.GroupBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.grpXSLT = new System.Windows.Forms.GroupBox();
            this.tbXSLT = new System.Windows.Forms.TextBox();
            this.grpXMLOutput = new System.Windows.Forms.GroupBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadXSLTFromFile = new System.Windows.Forms.Button();
            this.btnClearXSLT = new System.Windows.Forms.Button();
            this.saveXSLTSheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPerformTransform = new System.Windows.Forms.Button();
            this.btnLoadXMLInput = new System.Windows.Forms.Button();
            this.btnLoadXMLOutput = new System.Windows.Forms.Button();
            this.grpXMLInput.SuspendLayout();
            this.grpXSLT.SuspendLayout();
            this.grpXMLOutput.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpXMLInput
            // 
            this.grpXMLInput.Controls.Add(this.btnLoadXMLInput);
            this.grpXMLInput.Controls.Add(this.btnClearInput);
            this.grpXMLInput.Controls.Add(this.tbInput);
            this.grpXMLInput.Location = new System.Drawing.Point(12, 27);
            this.grpXMLInput.Name = "grpXMLInput";
            this.grpXMLInput.Size = new System.Drawing.Size(358, 358);
            this.grpXMLInput.TabIndex = 7;
            this.grpXMLInput.TabStop = false;
            this.grpXMLInput.Text = "XML Input";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(8, 19);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInput.Size = new System.Drawing.Size(341, 304);
            this.tbInput.TabIndex = 1;
            this.tbInput.Text = "Input XML";
            // 
            // grpXSLT
            // 
            this.grpXSLT.Controls.Add(this.btnPerformTransform);
            this.grpXSLT.Controls.Add(this.btnClearXSLT);
            this.grpXSLT.Controls.Add(this.btnLoadXSLTFromFile);
            this.grpXSLT.Controls.Add(this.tbXSLT);
            this.grpXSLT.Location = new System.Drawing.Point(376, 27);
            this.grpXSLT.Name = "grpXSLT";
            this.grpXSLT.Size = new System.Drawing.Size(358, 358);
            this.grpXSLT.TabIndex = 8;
            this.grpXSLT.TabStop = false;
            this.grpXSLT.Text = "XSLT Style Sheet";
            // 
            // tbXSLT
            // 
            this.tbXSLT.Location = new System.Drawing.Point(8, 19);
            this.tbXSLT.Multiline = true;
            this.tbXSLT.Name = "tbXSLT";
            this.tbXSLT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbXSLT.Size = new System.Drawing.Size(341, 304);
            this.tbXSLT.TabIndex = 1;
            this.tbXSLT.Text = "XSLT Style Sheet";
            // 
            // grpXMLOutput
            // 
            this.grpXMLOutput.Controls.Add(this.btnLoadXMLOutput);
            this.grpXMLOutput.Controls.Add(this.btnClearOutput);
            this.grpXMLOutput.Controls.Add(this.tbOutput);
            this.grpXMLOutput.Location = new System.Drawing.Point(740, 27);
            this.grpXMLOutput.Name = "grpXMLOutput";
            this.grpXMLOutput.Size = new System.Drawing.Size(358, 358);
            this.grpXMLOutput.TabIndex = 9;
            this.grpXMLOutput.TabStop = false;
            this.grpXMLOutput.Text = "XML Output";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(8, 19);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutput.Size = new System.Drawing.Size(341, 304);
            this.tbOutput.TabIndex = 1;
            this.tbOutput.Text = "Output XML";
            // 
            // btnClearInput
            // 
            this.btnClearInput.Location = new System.Drawing.Point(119, 327);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(75, 23);
            this.btnClearInput.TabIndex = 11;
            this.btnClearInput.Text = "Clear";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Location = new System.Drawing.Point(119, 327);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(75, 23);
            this.btnClearOutput.TabIndex = 11;
            this.btnClearOutput.Text = "Clear";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClearOutput_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1113, 24);
            this.mainMenu.TabIndex = 10;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.lToolStripMenuItem,
            this.saveXSLTSheetToolStripMenuItem,
            this.saveOutputToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "Load Input";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.lToolStripMenuItem.Text = "Load XSLT Sheet";
            this.lToolStripMenuItem.Click += new System.EventHandler(this.lToolStripMenuItem_Click);
            // 
            // btnLoadXSLTFromFile
            // 
            this.btnLoadXSLTFromFile.Location = new System.Drawing.Point(72, 327);
            this.btnLoadXSLTFromFile.Name = "btnLoadXSLTFromFile";
            this.btnLoadXSLTFromFile.Size = new System.Drawing.Size(149, 23);
            this.btnLoadXSLTFromFile.TabIndex = 11;
            this.btnLoadXSLTFromFile.Text = "Load XSLT From File...";
            this.btnLoadXSLTFromFile.UseVisualStyleBackColor = true;
            this.btnLoadXSLTFromFile.Click += new System.EventHandler(this.btnLoadXSLTFromFile_Click);
            // 
            // btnClearXSLT
            // 
            this.btnClearXSLT.Location = new System.Drawing.Point(8, 327);
            this.btnClearXSLT.Name = "btnClearXSLT";
            this.btnClearXSLT.Size = new System.Drawing.Size(58, 23);
            this.btnClearXSLT.TabIndex = 12;
            this.btnClearXSLT.Text = "Clear";
            this.btnClearXSLT.UseVisualStyleBackColor = true;
            this.btnClearXSLT.Click += new System.EventHandler(this.btnClearXSLT_Click);
            // 
            // saveXSLTSheetToolStripMenuItem
            // 
            this.saveXSLTSheetToolStripMenuItem.Name = "saveXSLTSheetToolStripMenuItem";
            this.saveXSLTSheetToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.saveXSLTSheetToolStripMenuItem.Text = "Save XSLT Sheet";
            this.saveXSLTSheetToolStripMenuItem.Click += new System.EventHandler(this.saveXSLTSheetToolStripMenuItem_Click);
            // 
            // saveOutputToolStripMenuItem
            // 
            this.saveOutputToolStripMenuItem.Name = "saveOutputToolStripMenuItem";
            this.saveOutputToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.saveOutputToolStripMenuItem.Text = "Save Output";
            this.saveOutputToolStripMenuItem.Click += new System.EventHandler(this.saveOutputToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // btnPerformTransform
            // 
            this.btnPerformTransform.Location = new System.Drawing.Point(227, 327);
            this.btnPerformTransform.Name = "btnPerformTransform";
            this.btnPerformTransform.Size = new System.Drawing.Size(125, 23);
            this.btnPerformTransform.TabIndex = 13;
            this.btnPerformTransform.Text = "Execute Transform";
            this.btnPerformTransform.UseVisualStyleBackColor = true;
            this.btnPerformTransform.Click += new System.EventHandler(this.btnPerformTransform_Click);
            // 
            // btnLoadXMLInput
            // 
            this.btnLoadXMLInput.Location = new System.Drawing.Point(200, 327);
            this.btnLoadXMLInput.Name = "btnLoadXMLInput";
            this.btnLoadXMLInput.Size = new System.Drawing.Size(149, 23);
            this.btnLoadXMLInput.TabIndex = 12;
            this.btnLoadXMLInput.Text = "Load XML From File...";
            this.btnLoadXMLInput.UseVisualStyleBackColor = true;
            this.btnLoadXMLInput.Click += new System.EventHandler(this.btnLoadXMLInput_Click);
            // 
            // btnLoadXMLOutput
            // 
            this.btnLoadXMLOutput.Location = new System.Drawing.Point(200, 327);
            this.btnLoadXMLOutput.Name = "btnLoadXMLOutput";
            this.btnLoadXMLOutput.Size = new System.Drawing.Size(149, 23);
            this.btnLoadXMLOutput.TabIndex = 12;
            this.btnLoadXMLOutput.Text = "Load XML From File...";
            this.btnLoadXMLOutput.UseVisualStyleBackColor = true;
            this.btnLoadXMLOutput.Click += new System.EventHandler(this.btnLoadXMLOutput_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 392);
            this.Controls.Add(this.grpXMLOutput);
            this.Controls.Add(this.grpXSLT);
            this.Controls.Add(this.grpXMLInput);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "frmMain";
            this.Text = "XSLT Tester Tool - Calvin Hartwell";
            this.grpXMLInput.ResumeLayout(false);
            this.grpXMLInput.PerformLayout();
            this.grpXSLT.ResumeLayout(false);
            this.grpXSLT.PerformLayout();
            this.grpXMLOutput.ResumeLayout(false);
            this.grpXMLOutput.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpXMLInput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.GroupBox grpXSLT;
        private System.Windows.Forms.TextBox tbXSLT;
        private System.Windows.Forms.GroupBox grpXMLOutput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnClearXSLT;
        private System.Windows.Forms.Button btnLoadXSLTFromFile;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveXSLTSheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button btnPerformTransform;
        private System.Windows.Forms.Button btnLoadXMLInput;
        private System.Windows.Forms.Button btnLoadXMLOutput;
    }
}

