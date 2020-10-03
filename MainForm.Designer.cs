namespace PortDiscrd
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripTab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuCloseTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCloseOtherTabs = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TabPages = new FarsiLibrary.Win.FATabStrip();
            this.tabStrip1 = new FarsiLibrary.Win.FATabStripItem();
            this.tabStripAdd = new FarsiLibrary.Win.FATabStripItem();
            this.ApplicationMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.BtnNextSearch = new System.Windows.Forms.Button();
            this.BtnPrevSearch = new System.Windows.Forms.Button();
            this.BtnCloseSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStripTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPages)).BeginInit();
            this.TabPages.SuspendLayout();
            this.ApplicationMenu.SuspendLayout();
            this.PanelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripTab
            // 
            this.menuStripTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCloseTab,
            this.menuCloseOtherTabs});
            this.menuStripTab.Name = "menuStripTab";
            this.menuStripTab.Size = new System.Drawing.Size(170, 48);
            // 
            // menuCloseTab
            // 
            this.menuCloseTab.Name = "menuCloseTab";
            this.menuCloseTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.menuCloseTab.Size = new System.Drawing.Size(169, 22);
            this.menuCloseTab.Text = "Close tab";
            this.menuCloseTab.Click += new System.EventHandler(this.menuCloseTab_Click);
            // 
            // menuCloseOtherTabs
            // 
            this.menuCloseOtherTabs.Name = "menuCloseOtherTabs";
            this.menuCloseOtherTabs.Size = new System.Drawing.Size(169, 22);
            this.menuCloseOtherTabs.Text = "Close other tabs";
            this.menuCloseOtherTabs.Click += new System.EventHandler(this.menuCloseOtherTabs_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TabPages
            // 
            this.TabPages.ContextMenuStrip = this.menuStripTab;
            this.TabPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPages.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabPages.Items.AddRange(new FarsiLibrary.Win.FATabStripItem[] {
            this.tabStrip1,
            this.tabStripAdd});
            this.TabPages.Location = new System.Drawing.Point(0, 0);
            this.TabPages.Name = "TabPages";
            this.TabPages.SelectedItem = this.tabStrip1;
            this.TabPages.Size = new System.Drawing.Size(784, 561);
            this.TabPages.TabIndex = 4;
            this.TabPages.Text = "faTabStrip1";
            this.TabPages.TabStripItemSelectionChanged += new FarsiLibrary.Win.TabStripItemChangedHandler(this.OnTabsChanged);
            this.TabPages.TabStripItemClosed += new System.EventHandler(this.OnTabClosed);
            this.TabPages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabPages_MouseClick);
            // 
            // tabStrip1
            // 
            this.tabStrip1.IsDrawn = true;
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.Selected = true;
            this.tabStrip1.Size = new System.Drawing.Size(782, 531);
            this.tabStrip1.TabIndex = 0;
            this.tabStrip1.Title = "Loading...";
            this.tabStrip1.Changed += new System.EventHandler(this.tabStrip1_Changed);
            // 
            // tabStripAdd
            // 
            this.tabStripAdd.CanClose = false;
            this.tabStripAdd.IsDrawn = true;
            this.tabStripAdd.Name = "tabStripAdd";
            this.tabStripAdd.Size = new System.Drawing.Size(932, 621);
            this.tabStripAdd.TabIndex = 1;
            this.tabStripAdd.Title = "+";
            // 
            // ApplicationMenu
            // 
            this.ApplicationMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ApplicationMenu.AutoSize = true;
            this.ApplicationMenu.BackColor = System.Drawing.Color.Black;
            this.ApplicationMenu.Controls.Add(this.button4);
            this.ApplicationMenu.Controls.Add(this.button3);
            this.ApplicationMenu.Controls.Add(this.button2);
            this.ApplicationMenu.Controls.Add(this.button1);
            this.ApplicationMenu.Controls.Add(this.label1);
            this.ApplicationMenu.Location = new System.Drawing.Point(0, 30);
            this.ApplicationMenu.Name = "ApplicationMenu";
            this.ApplicationMenu.Size = new System.Drawing.Size(249, 537);
            this.ApplicationMenu.TabIndex = 10;
            this.ApplicationMenu.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "PortDiscrd - Menu";
            // 
            // PanelSearch
            // 
            this.PanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSearch.BackColor = System.Drawing.Color.Black;
            this.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSearch.Controls.Add(this.BtnNextSearch);
            this.PanelSearch.Controls.Add(this.BtnPrevSearch);
            this.PanelSearch.Controls.Add(this.BtnCloseSearch);
            this.PanelSearch.Controls.Add(this.TxtSearch);
            this.PanelSearch.Location = new System.Drawing.Point(504, 520);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(279, 39);
            this.PanelSearch.TabIndex = 9;
            this.PanelSearch.Visible = false;
            // 
            // BtnNextSearch
            // 
            this.BtnNextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNextSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextSearch.ForeColor = System.Drawing.Color.Black;
            this.BtnNextSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnNextSearch.Image")));
            this.BtnNextSearch.Location = new System.Drawing.Point(211, 4);
            this.BtnNextSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNextSearch.Name = "BtnNextSearch";
            this.BtnNextSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnNextSearch.TabIndex = 9;
            this.BtnNextSearch.Tag = "Find next (Enter)";
            this.BtnNextSearch.UseVisualStyleBackColor = true;
            this.BtnNextSearch.Click += new System.EventHandler(this.BtnNextSearch_Click);
            // 
            // BtnPrevSearch
            // 
            this.BtnPrevSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrevSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevSearch.ForeColor = System.Drawing.Color.Black;
            this.BtnPrevSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrevSearch.Image")));
            this.BtnPrevSearch.Location = new System.Drawing.Point(178, 4);
            this.BtnPrevSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPrevSearch.Name = "BtnPrevSearch";
            this.BtnPrevSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnPrevSearch.TabIndex = 8;
            this.BtnPrevSearch.Tag = "Find previous (Shift+Enter)";
            this.BtnPrevSearch.UseVisualStyleBackColor = true;
            this.BtnPrevSearch.Click += new System.EventHandler(this.BtnPrevSearch_Click);
            // 
            // BtnCloseSearch
            // 
            this.BtnCloseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseSearch.ForeColor = System.Drawing.Color.Black;
            this.BtnCloseSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseSearch.Image")));
            this.BtnCloseSearch.Location = new System.Drawing.Point(244, 4);
            this.BtnCloseSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCloseSearch.Name = "BtnCloseSearch";
            this.BtnCloseSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnCloseSearch.TabIndex = 7;
            this.BtnCloseSearch.Tag = "Close (Esc)";
            this.BtnCloseSearch.UseVisualStyleBackColor = true;
            this.BtnCloseSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.BackColor = System.Drawing.Color.Black;
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.ForeColor = System.Drawing.Color.White;
            this.TxtSearch.Location = new System.Drawing.Point(3, 3);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(168, 32);
            this.TxtSearch.TabIndex = 6;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("RomanS_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("RomanS_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(7, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("RomanS_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(7, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("RomanS_IV25", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(7, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 26);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PanelSearch);
            this.Controls.Add(this.ApplicationMenu);
            this.Controls.Add(this.TabPages);
            this.Font = new System.Drawing.Font("RomanS_IV25", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStripTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabPages)).EndInit();
            this.TabPages.ResumeLayout(false);
            this.ApplicationMenu.ResumeLayout(false);
            this.ApplicationMenu.PerformLayout();
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private FarsiLibrary.Win.FATabStrip TabPages;
        private FarsiLibrary.Win.FATabStripItem tabStrip1;
        private FarsiLibrary.Win.FATabStripItem tabStripAdd;
		private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip menuStripTab;
        private System.Windows.Forms.ToolStripMenuItem menuCloseTab;
        private System.Windows.Forms.ToolStripMenuItem menuCloseOtherTabs;
		private System.Windows.Forms.Panel PanelSearch;
		private System.Windows.Forms.TextBox TxtSearch;
		private System.Windows.Forms.Button BtnCloseSearch;
		private System.Windows.Forms.Button BtnPrevSearch;
		private System.Windows.Forms.Button BtnNextSearch;
        private System.Windows.Forms.Panel ApplicationMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

