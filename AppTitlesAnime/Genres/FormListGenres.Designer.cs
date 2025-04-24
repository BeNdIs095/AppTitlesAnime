namespace AppTitlesAnime
{
    partial class FormListGenres
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            btnAddGenre = new Button();
            btnUpdateGenre = new Button();
            btnDeleteGenre = new Button();
            panelFill = new Panel();
            dataGridViewGenres = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.Controls.Add(btnAddGenre);
            flowLayoutPanelTop.Controls.Add(btnUpdateGenre);
            flowLayoutPanelTop.Controls.Add(btnDeleteGenre);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Margin = new Padding(5);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(934, 61);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // btnAddGenre
            // 
            btnAddGenre.AutoSize = true;
            btnAddGenre.Location = new Point(13, 13);
            btnAddGenre.Name = "btnAddGenre";
            btnAddGenre.Size = new Size(111, 35);
            btnAddGenre.TabIndex = 2;
            btnAddGenre.Text = "Добавить";
            btnAddGenre.UseVisualStyleBackColor = true;
            btnAddGenre.Click += BtnAddGenre_Click;
            // 
            // btnUpdateGenre
            // 
            btnUpdateGenre.AutoSize = true;
            btnUpdateGenre.Location = new Point(130, 13);
            btnUpdateGenre.Name = "btnUpdateGenre";
            btnUpdateGenre.Size = new Size(151, 35);
            btnUpdateGenre.TabIndex = 2;
            btnUpdateGenre.Text = "Редактировать";
            btnUpdateGenre.UseVisualStyleBackColor = true;
            btnUpdateGenre.Click += BtnUpdateGenre_Click;
            // 
            // btnDeleteGenre
            // 
            btnDeleteGenre.AutoSize = true;
            btnDeleteGenre.Location = new Point(287, 13);
            btnDeleteGenre.Name = "btnDeleteGenre";
            btnDeleteGenre.Size = new Size(92, 35);
            btnDeleteGenre.TabIndex = 2;
            btnDeleteGenre.Text = "Удалить";
            btnDeleteGenre.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewGenres);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Margin = new Padding(5);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(934, 450);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewGenres
            // 
            dataGridViewGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewGenres.BackgroundColor = Color.White;
            dataGridViewGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGenres.Dock = DockStyle.Fill;
            dataGridViewGenres.Location = new Point(10, 10);
            dataGridViewGenres.MultiSelect = false;
            dataGridViewGenres.Name = "dataGridViewGenres";
            dataGridViewGenres.ReadOnly = true;
            dataGridViewGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGenres.Size = new Size(914, 430);
            dataGridViewGenres.TabIndex = 1;
            dataGridViewGenres.CellContentClick += dataGridViewGenres_CellContentClick;
            // 
            // FormListGenres
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 511);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListGenres";
            Text = "Список жанров аниме";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGenres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Panel panelFill;
        private Button btnAddGenre;
        private Button btnUpdateGenre;
        private Button btnDeleteGenre;
        private DataGridView dataGridViewGenres;
    }
}