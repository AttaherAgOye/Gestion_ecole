namespace Modern_Sliding_Sidebar___C_Sharp_Winform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Elipse_Form = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SideBar = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel7 = new Guna.UI.WinForms.GunaPanel();
            this.Help_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel6 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel5 = new Guna.UI.WinForms.GunaPanel();
            this.About_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel8 = new Guna.UI.WinForms.GunaPanel();
            this.Customers_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.Orders_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.Home_Button = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel9 = new Guna.UI.WinForms.GunaPanel();
            this.Menu_Button = new Guna.UI.WinForms.GunaButton();
            this.DragControl_Form = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.Timer_Sidebar_Menu = new System.Windows.Forms.Timer(this.components);
            this.Close_Button = new Guna.UI.WinForms.GunaImageButton();
            this.Link_Github = new Guna.UI.WinForms.GunaLinkLabel();
            this.listeEtudiants = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAjouter = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModiffier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabEtudiant = new System.Windows.Forms.Panel();
            this.tabEnseignant = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMatriculeE = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtNomE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.txtMatiereE = new System.Windows.Forms.TextBox();
            this.listeEnseignants = new System.Windows.Forms.ListView();
            this.Matricule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrenomE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MatiereE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.btnAjouterE = new System.Windows.Forms.Button();
            this.txtPrenomE = new System.Windows.Forms.TextBox();
            this.tabCours = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtNomC = new System.Windows.Forms.TextBox();
            this.gunaLinkLabel2 = new Guna.UI.WinForms.GunaLinkLabel();
            this.listeCours = new System.Windows.Forms.ListView();
            this.NomC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Enseignant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.txtEnseignant = new System.Windows.Forms.TextBox();
            this.SideBar.SuspendLayout();
            this.gunaPanel7.SuspendLayout();
            this.gunaPanel5.SuspendLayout();
            this.gunaPanel8.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel9.SuspendLayout();
            this.tabEtudiant.SuspendLayout();
            this.tabEnseignant.SuspendLayout();
            this.tabCours.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse_Form
            // 
            this.Elipse_Form.Radius = 9;
            this.Elipse_Form.TargetControl = this;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.SideBar.Controls.Add(this.gunaPanel7);
            this.SideBar.Controls.Add(this.gunaPanel6);
            this.SideBar.Controls.Add(this.gunaPanel5);
            this.SideBar.Controls.Add(this.gunaPanel8);
            this.SideBar.Controls.Add(this.gunaPanel4);
            this.SideBar.Controls.Add(this.gunaPanel3);
            this.SideBar.Controls.Add(this.gunaPanel2);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.MaximumSize = new System.Drawing.Size(217, 494);
            this.SideBar.MinimumSize = new System.Drawing.Size(55, 494);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(217, 494);
            this.SideBar.TabIndex = 0;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // gunaPanel7
            // 
            this.gunaPanel7.Controls.Add(this.Help_Button);
            this.gunaPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel7.Location = new System.Drawing.Point(0, 361);
            this.gunaPanel7.Name = "gunaPanel7";
            this.gunaPanel7.Size = new System.Drawing.Size(217, 55);
            this.gunaPanel7.TabIndex = 6;
            // 
            // Help_Button
            // 
            this.Help_Button.AnimationHoverSpeed = 0.07F;
            this.Help_Button.AnimationSpeed = 0.03F;
            this.Help_Button.BaseColor = System.Drawing.Color.Transparent;
            this.Help_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Help_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Help_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Help_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Help_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Help_Button.ForeColor = System.Drawing.Color.White;
            this.Help_Button.Image = ((System.Drawing.Image)(resources.GetObject("Help_Button.Image")));
            this.Help_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Help_Button.Location = new System.Drawing.Point(7, 8);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Help_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Help_Button.OnHoverForeColor = System.Drawing.Color.Silver;
            this.Help_Button.OnHoverImage = null;
            this.Help_Button.OnPressedColor = System.Drawing.Color.White;
            this.Help_Button.Size = new System.Drawing.Size(203, 40);
            this.Help_Button.TabIndex = 1;
            this.Help_Button.Text = "Quiter";
            this.Help_Button.TextOffsetX = 15;
            this.Help_Button.Click += new System.EventHandler(this.Help_Button_Click);
            // 
            // gunaPanel6
            // 
            this.gunaPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel6.Location = new System.Drawing.Point(0, 306);
            this.gunaPanel6.Name = "gunaPanel6";
            this.gunaPanel6.Size = new System.Drawing.Size(217, 55);
            this.gunaPanel6.TabIndex = 4;
            // 
            // gunaPanel5
            // 
            this.gunaPanel5.Controls.Add(this.About_Button);
            this.gunaPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel5.Location = new System.Drawing.Point(0, 251);
            this.gunaPanel5.Name = "gunaPanel5";
            this.gunaPanel5.Size = new System.Drawing.Size(217, 55);
            this.gunaPanel5.TabIndex = 3;
            // 
            // About_Button
            // 
            this.About_Button.AnimationHoverSpeed = 0.07F;
            this.About_Button.AnimationSpeed = 0.03F;
            this.About_Button.BaseColor = System.Drawing.Color.Transparent;
            this.About_Button.BorderColor = System.Drawing.Color.Transparent;
            this.About_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.About_Button.FocusedColor = System.Drawing.Color.Empty;
            this.About_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.About_Button.ForeColor = System.Drawing.Color.White;
            this.About_Button.Image = ((System.Drawing.Image)(resources.GetObject("About_Button.Image")));
            this.About_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.About_Button.Location = new System.Drawing.Point(7, 7);
            this.About_Button.Name = "About_Button";
            this.About_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.About_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.About_Button.OnHoverForeColor = System.Drawing.Color.Silver;
            this.About_Button.OnHoverImage = null;
            this.About_Button.OnPressedColor = System.Drawing.Color.White;
            this.About_Button.Size = new System.Drawing.Size(203, 40);
            this.About_Button.TabIndex = 1;
            this.About_Button.Text = "About";
            this.About_Button.TextOffsetX = 15;
            // 
            // gunaPanel8
            // 
            this.gunaPanel8.Controls.Add(this.Customers_Button);
            this.gunaPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel8.Location = new System.Drawing.Point(0, 196);
            this.gunaPanel8.Name = "gunaPanel8";
            this.gunaPanel8.Size = new System.Drawing.Size(217, 55);
            this.gunaPanel8.TabIndex = 5;
            // 
            // Customers_Button
            // 
            this.Customers_Button.AnimationHoverSpeed = 0.07F;
            this.Customers_Button.AnimationSpeed = 0.03F;
            this.Customers_Button.BaseColor = System.Drawing.Color.Transparent;
            this.Customers_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Customers_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customers_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Customers_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Customers_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Customers_Button.ForeColor = System.Drawing.Color.White;
            this.Customers_Button.Image = ((System.Drawing.Image)(resources.GetObject("Customers_Button.Image")));
            this.Customers_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Customers_Button.Location = new System.Drawing.Point(7, 8);
            this.Customers_Button.Name = "Customers_Button";
            this.Customers_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Customers_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Customers_Button.OnHoverForeColor = System.Drawing.Color.Silver;
            this.Customers_Button.OnHoverImage = null;
            this.Customers_Button.OnPressedColor = System.Drawing.Color.White;
            this.Customers_Button.Size = new System.Drawing.Size(203, 40);
            this.Customers_Button.TabIndex = 1;
            this.Customers_Button.Text = "Gestion des cours";
            this.Customers_Button.TextOffsetX = 15;
            this.Customers_Button.Click += new System.EventHandler(this.Customers_Button_Click);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Controls.Add(this.Orders_Button);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel4.Location = new System.Drawing.Point(0, 141);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(217, 55);
            this.gunaPanel4.TabIndex = 2;
            // 
            // Orders_Button
            // 
            this.Orders_Button.AnimationHoverSpeed = 0.07F;
            this.Orders_Button.AnimationSpeed = 0.03F;
            this.Orders_Button.BaseColor = System.Drawing.Color.Transparent;
            this.Orders_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Orders_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Orders_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Orders_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Orders_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Orders_Button.ForeColor = System.Drawing.Color.White;
            this.Orders_Button.Image = ((System.Drawing.Image)(resources.GetObject("Orders_Button.Image")));
            this.Orders_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Orders_Button.Location = new System.Drawing.Point(7, 7);
            this.Orders_Button.Name = "Orders_Button";
            this.Orders_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Orders_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Orders_Button.OnHoverForeColor = System.Drawing.Color.Silver;
            this.Orders_Button.OnHoverImage = null;
            this.Orders_Button.OnPressedColor = System.Drawing.Color.White;
            this.Orders_Button.Size = new System.Drawing.Size(203, 40);
            this.Orders_Button.TabIndex = 1;
            this.Orders_Button.Text = "Gestion des enseignants";
            this.Orders_Button.TextOffsetX = 15;
            this.Orders_Button.Click += new System.EventHandler(this.Orders_Button_Click);
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.Home_Button);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 86);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(217, 55);
            this.gunaPanel3.TabIndex = 1;
            // 
            // Home_Button
            // 
            this.Home_Button.AnimationHoverSpeed = 0.07F;
            this.Home_Button.AnimationSpeed = 0.03F;
            this.Home_Button.BaseColor = System.Drawing.Color.Transparent;
            this.Home_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Home_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Home_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Home_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Home_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Home_Button.ForeColor = System.Drawing.Color.White;
            this.Home_Button.Image = ((System.Drawing.Image)(resources.GetObject("Home_Button.Image")));
            this.Home_Button.ImageSize = new System.Drawing.Size(30, 30);
            this.Home_Button.Location = new System.Drawing.Point(7, 7);
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Home_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Home_Button.OnHoverForeColor = System.Drawing.Color.Silver;
            this.Home_Button.OnHoverImage = null;
            this.Home_Button.OnPressedColor = System.Drawing.Color.White;
            this.Home_Button.Size = new System.Drawing.Size(203, 40);
            this.Home_Button.TabIndex = 1;
            this.Home_Button.Text = "Gestion des étudiants";
            this.Home_Button.TextOffsetX = 15;
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.gunaPanel9);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(217, 86);
            this.gunaPanel2.TabIndex = 0;
            // 
            // gunaPanel9
            // 
            this.gunaPanel9.Controls.Add(this.Menu_Button);
            this.gunaPanel9.Location = new System.Drawing.Point(0, 12);
            this.gunaPanel9.Name = "gunaPanel9";
            this.gunaPanel9.Size = new System.Drawing.Size(213, 68);
            this.gunaPanel9.TabIndex = 2;
            // 
            // Menu_Button
            // 
            this.Menu_Button.AnimationHoverSpeed = 0.07F;
            this.Menu_Button.AnimationSpeed = 0.03F;
            this.Menu_Button.BaseColor = System.Drawing.Color.Transparent;
            this.Menu_Button.BorderColor = System.Drawing.Color.Transparent;
            this.Menu_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Menu_Button.FocusedColor = System.Drawing.Color.Empty;
            this.Menu_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Menu_Button.ForeColor = System.Drawing.Color.White;
            this.Menu_Button.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Button.Image")));
            this.Menu_Button.ImageSize = new System.Drawing.Size(20, 20);
            this.Menu_Button.Location = new System.Drawing.Point(7, 14);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.Menu_Button.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.Menu_Button.OnHoverForeColor = System.Drawing.Color.Silver;
            this.Menu_Button.OnHoverImage = null;
            this.Menu_Button.OnPressedColor = System.Drawing.Color.White;
            this.Menu_Button.Size = new System.Drawing.Size(203, 40);
            this.Menu_Button.TabIndex = 1;
            this.Menu_Button.Text = "Menu";
            this.Menu_Button.TextOffsetX = 15;
            this.Menu_Button.Click += new System.EventHandler(this.Menu_Button_Click);
            // 
            // DragControl_Form
            // 
            this.DragControl_Form.TargetControl = this;
            // 
            // Timer_Sidebar_Menu
            // 
            this.Timer_Sidebar_Menu.Interval = 10;
            this.Timer_Sidebar_Menu.Tick += new System.EventHandler(this.Timer_Sidebar_Menu_Tick);
            // 
            // Close_Button
            // 
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Close_Button.Image = global::Modern_Sliding_Sidebar___C_Sharp_Winform.Properties.Resources.multiply_48px__;
            this.Close_Button.ImageSize = new System.Drawing.Size(28, 28);
            this.Close_Button.Location = new System.Drawing.Point(960, 9);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.OnHoverImage = global::Modern_Sliding_Sidebar___C_Sharp_Winform.Properties.Resources.multiply_48px_____;
            this.Close_Button.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.Close_Button.Size = new System.Drawing.Size(35, 35);
            this.Close_Button.TabIndex = 1;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Link_Github
            // 
            this.Link_Github.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Link_Github.AutoSize = true;
            this.Link_Github.Font = new System.Drawing.Font("Bodoni MT Condensed", 35F);
            this.Link_Github.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.Link_Github.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.Link_Github.Location = new System.Drawing.Point(207, 1);
            this.Link_Github.Name = "Link_Github";
            this.Link_Github.Size = new System.Drawing.Size(303, 55);
            this.Link_Github.TabIndex = 5;
            this.Link_Github.TabStop = true;
            this.Link_Github.Text = "Gestion des étudiants";
            this.Link_Github.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Link_Github.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Link_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Link_Github_LinkClicked);
            // 
            // listeEtudiants
            // 
            this.listeEtudiants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Prenom,
            this.Numero});
            this.listeEtudiants.HideSelection = false;
            this.listeEtudiants.LabelEdit = true;
            this.listeEtudiants.LabelWrap = false;
            this.listeEtudiants.Location = new System.Drawing.Point(28, 59);
            this.listeEtudiants.Name = "listeEtudiants";
            this.listeEtudiants.Size = new System.Drawing.Size(617, 250);
            this.listeEtudiants.TabIndex = 6;
            this.listeEtudiants.UseCompatibleStateImageBehavior = false;
            this.listeEtudiants.View = System.Windows.Forms.View.Details;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 186;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prenom";
            this.Prenom.Width = 222;
            // 
            // Numero
            // 
            this.Numero.Text = "Numero";
            this.Numero.Width = 207;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(385, 348);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(173, 30);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(123, 358);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(204, 20);
            this.txtNom.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(122, 401);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(204, 20);
            this.txtPrenom.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Numero";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(122, 443);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(204, 20);
            this.txtNumero.TabIndex = 13;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(385, 389);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(173, 30);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModiffier
            // 
            this.btnModiffier.Location = new System.Drawing.Point(385, 433);
            this.btnModiffier.Name = "btnModiffier";
            this.btnModiffier.Size = new System.Drawing.Size(173, 30);
            this.btnModiffier.TabIndex = 16;
            this.btnModiffier.Text = "Modiffier";
            this.btnModiffier.UseVisualStyleBackColor = true;
            this.btnModiffier.Click += new System.EventHandler(this.btnModiffier_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabEtudiant
            // 
            this.tabEtudiant.Controls.Add(this.button1);
            this.tabEtudiant.Controls.Add(this.label1);
            this.tabEtudiant.Controls.Add(this.btnModiffier);
            this.tabEtudiant.Controls.Add(this.btnSupprimer);
            this.tabEtudiant.Controls.Add(this.txtNom);
            this.tabEtudiant.Controls.Add(this.label3);
            this.tabEtudiant.Controls.Add(this.Link_Github);
            this.tabEtudiant.Controls.Add(this.txtNumero);
            this.tabEtudiant.Controls.Add(this.listeEtudiants);
            this.tabEtudiant.Controls.Add(this.label2);
            this.tabEtudiant.Controls.Add(this.btnAjouter);
            this.tabEtudiant.Controls.Add(this.txtPrenom);
            this.tabEtudiant.Location = new System.Drawing.Point(247, 8);
            this.tabEtudiant.Name = "tabEtudiant";
            this.tabEtudiant.Size = new System.Drawing.Size(700, 513);
            this.tabEtudiant.TabIndex = 18;
            // 
            // tabEnseignant
            // 
            this.tabEnseignant.Controls.Add(this.label7);
            this.tabEnseignant.Controls.Add(this.txtMatriculeE);
            this.tabEnseignant.Controls.Add(this.button2);
            this.tabEnseignant.Controls.Add(this.label4);
            this.tabEnseignant.Controls.Add(this.button3);
            this.tabEnseignant.Controls.Add(this.button4);
            this.tabEnseignant.Controls.Add(this.txtNomE);
            this.tabEnseignant.Controls.Add(this.label5);
            this.tabEnseignant.Controls.Add(this.gunaLinkLabel1);
            this.tabEnseignant.Controls.Add(this.txtMatiereE);
            this.tabEnseignant.Controls.Add(this.listeEnseignants);
            this.tabEnseignant.Controls.Add(this.label6);
            this.tabEnseignant.Controls.Add(this.btnAjouterE);
            this.tabEnseignant.Controls.Add(this.txtPrenomE);
            this.tabEnseignant.Location = new System.Drawing.Point(247, 8);
            this.tabEnseignant.Name = "tabEnseignant";
            this.tabEnseignant.Size = new System.Drawing.Size(724, 536);
            this.tabEnseignant.TabIndex = 19;
            this.tabEnseignant.Visible = false;
            this.tabEnseignant.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Matricule";
            // 
            // txtMatriculeE
            // 
            this.txtMatriculeE.Location = new System.Drawing.Point(124, 358);
            this.txtMatriculeE.Name = "txtMatriculeE";
            this.txtMatriculeE.Size = new System.Drawing.Size(204, 20);
            this.txtMatriculeE.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nom";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(385, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 30);
            this.button3.TabIndex = 16;
            this.button3.Text = "Modiffier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(385, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 30);
            this.button4.TabIndex = 15;
            this.button4.Text = "Supprimer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtNomE
            // 
            this.txtNomE.Location = new System.Drawing.Point(124, 396);
            this.txtNomE.Name = "txtNomE";
            this.txtNomE.Size = new System.Drawing.Size(204, 20);
            this.txtNomE.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Matière";
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Bodoni MT Condensed", 35F);
            this.gunaLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gunaLinkLabel1.Location = new System.Drawing.Point(195, 1);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(338, 55);
            this.gunaLinkLabel1.TabIndex = 5;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Gestion des Enseignants";
            this.gunaLinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // txtMatiereE
            // 
            this.txtMatiereE.Location = new System.Drawing.Point(124, 481);
            this.txtMatiereE.Name = "txtMatiereE";
            this.txtMatiereE.Size = new System.Drawing.Size(204, 20);
            this.txtMatiereE.TabIndex = 13;
            // 
            // listeEnseignants
            // 
            this.listeEnseignants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Matricule,
            this.NomE,
            this.PrenomE,
            this.MatiereE});
            this.listeEnseignants.HideSelection = false;
            this.listeEnseignants.LabelEdit = true;
            this.listeEnseignants.LabelWrap = false;
            this.listeEnseignants.Location = new System.Drawing.Point(28, 59);
            this.listeEnseignants.Name = "listeEnseignants";
            this.listeEnseignants.Size = new System.Drawing.Size(617, 250);
            this.listeEnseignants.TabIndex = 6;
            this.listeEnseignants.UseCompatibleStateImageBehavior = false;
            this.listeEnseignants.View = System.Windows.Forms.View.Details;
            // 
            // Matricule
            // 
            this.Matricule.Text = "Matricule";
            this.Matricule.Width = 148;
            // 
            // NomE
            // 
            this.NomE.Text = "Nom";
            this.NomE.Width = 155;
            // 
            // PrenomE
            // 
            this.PrenomE.Text = "Prenom";
            this.PrenomE.Width = 158;
            // 
            // MatiereE
            // 
            this.MatiereE.Text = "Matiere";
            this.MatiereE.Width = 152;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Prenom";
            // 
            // btnAjouterE
            // 
            this.btnAjouterE.Location = new System.Drawing.Point(385, 348);
            this.btnAjouterE.Name = "btnAjouterE";
            this.btnAjouterE.Size = new System.Drawing.Size(173, 30);
            this.btnAjouterE.TabIndex = 7;
            this.btnAjouterE.Text = "Ajouter";
            this.btnAjouterE.UseVisualStyleBackColor = true;
            this.btnAjouterE.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtPrenomE
            // 
            this.txtPrenomE.Location = new System.Drawing.Point(123, 439);
            this.txtPrenomE.Name = "txtPrenomE";
            this.txtPrenomE.Size = new System.Drawing.Size(204, 20);
            this.txtPrenomE.TabIndex = 11;
            // 
            // tabCours
            // 
            this.tabCours.Controls.Add(this.label9);
            this.tabCours.Controls.Add(this.button6);
            this.tabCours.Controls.Add(this.button7);
            this.tabCours.Controls.Add(this.txtNomC);
            this.tabCours.Controls.Add(this.gunaLinkLabel2);
            this.tabCours.Controls.Add(this.listeCours);
            this.tabCours.Controls.Add(this.label11);
            this.tabCours.Controls.Add(this.button8);
            this.tabCours.Controls.Add(this.txtEnseignant);
            this.tabCours.Location = new System.Drawing.Point(244, 9);
            this.tabCours.Name = "tabCours";
            this.tabCours.Size = new System.Drawing.Size(724, 536);
            this.tabCours.TabIndex = 20;
            this.tabCours.Visible = false;
            this.tabCours.Paint += new System.Windows.Forms.PaintEventHandler(this.tabCours_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Nom";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(360, 443);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 30);
            this.button6.TabIndex = 16;
            this.button6.Text = "Modiffier";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(360, 397);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(173, 30);
            this.button7.TabIndex = 15;
            this.button7.Text = "Supprimer";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtNomC
            // 
            this.txtNomC.Location = new System.Drawing.Point(124, 360);
            this.txtNomC.Name = "txtNomC";
            this.txtNomC.Size = new System.Drawing.Size(204, 20);
            this.txtNomC.TabIndex = 9;
            // 
            // gunaLinkLabel2
            // 
            this.gunaLinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.gunaLinkLabel2.AutoSize = true;
            this.gunaLinkLabel2.Font = new System.Drawing.Font("Bodoni MT Condensed", 35F);
            this.gunaLinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.gunaLinkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.gunaLinkLabel2.Location = new System.Drawing.Point(195, 1);
            this.gunaLinkLabel2.Name = "gunaLinkLabel2";
            this.gunaLinkLabel2.Size = new System.Drawing.Size(254, 55);
            this.gunaLinkLabel2.TabIndex = 5;
            this.gunaLinkLabel2.TabStop = true;
            this.gunaLinkLabel2.Text = "Gestion des Cours";
            this.gunaLinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // listeCours
            // 
            this.listeCours.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NomC,
            this.Enseignant});
            this.listeCours.HideSelection = false;
            this.listeCours.LabelEdit = true;
            this.listeCours.LabelWrap = false;
            this.listeCours.Location = new System.Drawing.Point(28, 59);
            this.listeCours.Name = "listeCours";
            this.listeCours.Size = new System.Drawing.Size(617, 250);
            this.listeCours.TabIndex = 6;
            this.listeCours.UseCompatibleStateImageBehavior = false;
            this.listeCours.View = System.Windows.Forms.View.Details;
            // 
            // NomC
            // 
            this.NomC.Text = "Nom";
            this.NomC.Width = 282;
            // 
            // Enseignant
            // 
            this.Enseignant.Text = "Enseignant";
            this.Enseignant.Width = 331;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Enseignant";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(360, 354);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(173, 30);
            this.button8.TabIndex = 7;
            this.button8.Text = "Ajouter";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtEnseignant
            // 
            this.txtEnseignant.Location = new System.Drawing.Point(124, 401);
            this.txtEnseignant.Name = "txtEnseignant";
            this.txtEnseignant.Size = new System.Drawing.Size(204, 20);
            this.txtEnseignant.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 593);
            this.Controls.Add(this.tabCours);
            this.Controls.Add(this.tabEnseignant);
            this.Controls.Add(this.tabEtudiant);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideBar.ResumeLayout(false);
            this.gunaPanel7.ResumeLayout(false);
            this.gunaPanel5.ResumeLayout(false);
            this.gunaPanel8.ResumeLayout(false);
            this.gunaPanel4.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel9.ResumeLayout(false);
            this.tabEtudiant.ResumeLayout(false);
            this.tabEtudiant.PerformLayout();
            this.tabEnseignant.ResumeLayout(false);
            this.tabEnseignant.PerformLayout();
            this.tabCours.ResumeLayout(false);
            this.tabCours.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse Elipse_Form;
        private Guna.UI.WinForms.GunaPanel SideBar;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaImageButton Close_Button;
        private Guna.UI.WinForms.GunaPanel gunaPanel7;
        private Guna.UI.WinForms.GunaButton Help_Button;
        private Guna.UI.WinForms.GunaPanel gunaPanel6;
        private Guna.UI.WinForms.GunaButton Customers_Button;
        private Guna.UI.WinForms.GunaPanel gunaPanel5;
        private Guna.UI.WinForms.GunaPanel gunaPanel8;
        private Guna.UI.WinForms.GunaButton About_Button;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaButton Orders_Button;
        private Guna.UI.WinForms.GunaButton Home_Button;
        private Guna.UI.WinForms.GunaPanel gunaPanel9;
        private Guna.UI.WinForms.GunaButton Menu_Button;
        private Guna.UI.WinForms.GunaDragControl DragControl_Form;
        private System.Windows.Forms.Timer Timer_Sidebar_Menu;
        private Guna.UI.WinForms.GunaLinkLabel Link_Github;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button btnModiffier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Numero;
        public System.Windows.Forms.ListView listeEtudiants;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel tabEtudiant;
        private System.Windows.Forms.Panel tabEnseignant;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtNomE;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private System.Windows.Forms.TextBox txtMatiereE;
        public System.Windows.Forms.ListView listeEnseignants;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAjouterE;
        private System.Windows.Forms.TextBox txtPrenomE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMatriculeE;
        private System.Windows.Forms.ColumnHeader Matricule;
        private System.Windows.Forms.ColumnHeader NomE;
        private System.Windows.Forms.ColumnHeader PrenomE;
        private System.Windows.Forms.ColumnHeader MatiereE;
        private System.Windows.Forms.Panel tabCours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtNomC;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel2;
        public System.Windows.Forms.ListView listeCours;
        private System.Windows.Forms.ColumnHeader NomC;
        private System.Windows.Forms.ColumnHeader Enseignant;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtEnseignant;
    }
}

