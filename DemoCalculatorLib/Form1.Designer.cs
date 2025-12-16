namespace DemoCalculatorLib
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
            this.vCenter_Label = new System.Windows.Forms.Label();
            this.vCenter_comboBox = new System.Windows.Forms.ComboBox();
            this.vCenter_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vCenter_Label
            // 
            this.vCenter_Label.AutoSize = true;
            this.vCenter_Label.Location = new System.Drawing.Point(54, 49);
            this.vCenter_Label.Name = "vCenter_Label";
            this.vCenter_Label.Size = new System.Drawing.Size(54, 15);
            this.vCenter_Label.TabIndex = 0;
            this.vCenter_Label.Text = "vCenter: ";
            // 
            // vCenter_comboBox
            // 
            this.vCenter_comboBox.FormattingEnabled = true;
            this.vCenter_comboBox.Location = new System.Drawing.Point(129, 46);
            this.vCenter_comboBox.Name = "vCenter_comboBox";
            this.vCenter_comboBox.Size = new System.Drawing.Size(185, 23);
            this.vCenter_comboBox.TabIndex = 1;
            // 
            // vCenter_Button
            // 
            this.vCenter_Button.Location = new System.Drawing.Point(320, 46);
            this.vCenter_Button.Name = "vCenter_Button";
            this.vCenter_Button.Size = new System.Drawing.Size(143, 23);
            this.vCenter_Button.TabIndex = 2;
            this.vCenter_Button.Text = "Connect to vCenter";
            this.vCenter_Button.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(295, 462);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 57);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(129, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBuildToolStripMenuItem,
            this.loadBuildToolStripMenuItem,
            this.saveBuildToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // newBuildToolStripMenuItem
            // 
            this.newBuildToolStripMenuItem.Name = "newBuildToolStripMenuItem";
            this.newBuildToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newBuildToolStripMenuItem.Text = "New Build";
            // 
            // loadBuildToolStripMenuItem
            // 
            this.loadBuildToolStripMenuItem.Name = "loadBuildToolStripMenuItem";
            this.loadBuildToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadBuildToolStripMenuItem.Text = "Load Build";
            // 
            // saveBuildToolStripMenuItem
            // 
            this.saveBuildToolStripMenuItem.Name = "saveBuildToolStripMenuItem";
            this.saveBuildToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveBuildToolStripMenuItem.Text = "Save Build";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.vCenter_Button);
            this.Controls.Add(this.vCenter_comboBox);
            this.Controls.Add(this.vCenter_Label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Schwab Build Worksheet";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label vCenter_Label;
        private ComboBox vCenter_comboBox;
        private Button vCenter_Button;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newBuildToolStripMenuItem;
        private ToolStripMenuItem loadBuildToolStripMenuItem;
        private ToolStripMenuItem saveBuildToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}