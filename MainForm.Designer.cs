namespace SharpBrowser
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
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.BtnNextSearch = new System.Windows.Forms.Button();
            this.BtnPrevSearch = new System.Windows.Forms.Button();
            this.BtnCloseSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.tabStripAdd = new FarsiLibrary.Win.FATabStripItem();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.menuStripTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabPages)).BeginInit();
            this.TabPages.SuspendLayout();
            this.tabStrip1.SuspendLayout();
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
            this.TabPages.Size = new System.Drawing.Size(934, 651);
            this.TabPages.TabIndex = 4;
            this.TabPages.Text = "faTabStrip1";
            this.TabPages.TabStripItemSelectionChanged += new FarsiLibrary.Win.TabStripItemChangedHandler(this.OnTabsChanged);
            this.TabPages.TabStripItemClosed += new System.EventHandler(this.OnTabClosed);
            this.TabPages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabPages_MouseClick);
            // 
            // tabStrip1
            // 
            this.tabStrip1.Controls.Add(this.PanelSearch);
            this.tabStrip1.IsDrawn = true;
            this.tabStrip1.Name = "tabStrip1";
            this.tabStrip1.Size = new System.Drawing.Size(932, 621);
            this.tabStrip1.TabIndex = 0;
            this.tabStrip1.Title = "Loading...";
            // 
            // PanelSearch
            // 
            this.PanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSearch.BackColor = System.Drawing.Color.White;
            this.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSearch.Controls.Add(this.BtnNextSearch);
            this.PanelSearch.Controls.Add(this.BtnPrevSearch);
            this.PanelSearch.Controls.Add(this.BtnCloseSearch);
            this.PanelSearch.Controls.Add(this.TxtSearch);
            this.PanelSearch.Location = new System.Drawing.Point(622, 578);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(307, 40);
            this.PanelSearch.TabIndex = 9;
            this.PanelSearch.Visible = false;
            // 
            // BtnNextSearch
            // 
            this.BtnNextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNextSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextSearch.ForeColor = System.Drawing.Color.White;
            this.BtnNextSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnNextSearch.Image")));
            this.BtnNextSearch.Location = new System.Drawing.Point(239, 4);
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
            this.BtnPrevSearch.ForeColor = System.Drawing.Color.White;
            this.BtnPrevSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrevSearch.Image")));
            this.BtnPrevSearch.Location = new System.Drawing.Point(206, 4);
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
            this.BtnCloseSearch.ForeColor = System.Drawing.Color.White;
            this.BtnCloseSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseSearch.Image")));
            this.BtnCloseSearch.Location = new System.Drawing.Point(272, 4);
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
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(3, 7);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(181, 25);
            this.TxtSearch.TabIndex = 6;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // tabStripAdd
            // 
            this.tabStripAdd.CanClose = false;
            this.tabStripAdd.IsDrawn = true;
            this.tabStripAdd.Name = "tabStripAdd";
            this.tabStripAdd.Selected = true;
            this.tabStripAdd.Size = new System.Drawing.Size(932, 621);
            this.tabStripAdd.TabIndex = 1;
            this.tabStripAdd.Title = "+";
            // 
            // PanelStatus
            // 
            this.PanelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelStatus.Location = new System.Drawing.Point(0, 651);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(934, 20);
            this.PanelStatus.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(934, 671);
            this.Controls.Add(this.TabPages);
            this.Controls.Add(this.PanelStatus);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabStrip1.ResumeLayout(false);
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel PanelStatus;
    }
}

