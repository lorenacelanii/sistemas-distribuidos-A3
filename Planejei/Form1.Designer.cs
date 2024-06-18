namespace projcadastro
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
            ListViewItem listViewItem1 = new ListViewItem("Ok!");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            checkbox = new CheckedListBox();
            listaview = new ListView();
            status = new ColumnHeader();
            descricao = new ColumnHeader();
            panel1 = new Panel();
            btn_editar = new Button();
            textbox_username = new TextBox();
            btn_sair = new Button();
            navbar = new MenuStrip();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // checkbox
            // 
            checkbox.AccessibleRole = AccessibleRole.TitleBar;
            checkbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkbox.Font = new Font("Baby Doll", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkbox.FormattingEnabled = true;
            checkbox.Items.AddRange(new object[] { "adicionar tarefas", "marcar reuniao fornecedor ", "botzinho da rio center ", "correção de preços ", "tarefas diarias ", "carteira de pedidos" });
            checkbox.Location = new Point(12, 45);
            checkbox.Name = "checkbox";
            checkbox.Size = new Size(712, 314);
            checkbox.TabIndex = 2;
            checkbox.SelectedIndexChanged += checkbox_SelectedIndexChanged;
            // 
            // listaview
            // 
            listaview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listaview.Columns.AddRange(new ColumnHeader[] { status, descricao });
            listaview.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listaview.Location = new Point(12, 365);
            listaview.Name = "listaview";
            listaview.Size = new Size(712, 304);
            listaview.TabIndex = 3;
            listaview.UseCompatibleStateImageBehavior = false;
            listaview.View = View.Details;
            listaview.SelectedIndexChanged += listaview_SelectedIndexChanged;
            // 
            // status
            // 
            status.Text = "status";
            status.Width = 80;
            // 
            // descricao
            // 
            descricao.Text = "descrição";
            descricao.Width = 700;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(btn_editar);
            panel1.Controls.Add(textbox_username);
            panel1.Location = new Point(730, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 117);
            panel1.TabIndex = 5;
            // 
            // btn_editar
            // 
            btn_editar.BackColor = SystemColors.ButtonFace;
            btn_editar.FlatAppearance.BorderColor = Color.Red;
            btn_editar.FlatAppearance.MouseDownBackColor = Color.Red;
            btn_editar.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_editar.FlatStyle = FlatStyle.System;
            btn_editar.Font = new Font("Baby Doll", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_editar.Location = new Point(13, 77);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(79, 26);
            btn_editar.TabIndex = 6;
            btn_editar.Text = "editar\r\n";
            btn_editar.UseVisualStyleBackColor = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // textbox_username
            // 
            textbox_username.Location = new Point(13, 13);
            textbox_username.Name = "textbox_username";
            textbox_username.Size = new Size(389, 29);
            textbox_username.TabIndex = 5;
            textbox_username.Text = "nome";
            textbox_username.TextChanged += textbox_username_TextChanged;
            // 
            // btn_sair
            // 
            btn_sair.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_sair.BackColor = Color.PaleVioletRed;
            btn_sair.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 0);
            btn_sair.FlatAppearance.BorderSize = 5;
            btn_sair.FlatStyle = FlatStyle.System;
            btn_sair.ForeColor = Color.Transparent;
            btn_sair.Location = new Point(1147, 638);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(105, 31);
            btn_sair.TabIndex = 6;
            btn_sair.Text = "sair";
            btn_sair.UseVisualStyleBackColor = false;
            // 
            // navbar
            // 
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Padding = new Padding(10, 3, 0, 3);
            navbar.Size = new Size(1264, 24);
            navbar.TabIndex = 0;
            navbar.Text = "menuStrip1";
            // 
            // telainicial
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 681);
            Controls.Add(btn_sair);
            Controls.Add(panel1);
            Controls.Add(listaview);
            Controls.Add(checkbox);
            Controls.Add(navbar);
            DoubleBuffered = true;
            Font = new Font("Baby Doll", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = navbar;
            Margin = new Padding(5);
            Name = "telainicial";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Cadastrei";
            WindowState = FormWindowState.Maximized;
            Load += form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox checkbox;
        private ListView listaview;
        private ColumnHeader status;
        private ColumnHeader descricao;
        private Panel panel1;
        private Button btn_editar;
        private TextBox textbox_username;
        private Button btn_sair;
        private MenuStrip navbar;
    }
}
