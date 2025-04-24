namespace AppTitlesAnime
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
            btnShowTypes = new Button();
            labelTop = new Label();
            panelTop = new Panel();
            flowLayoutPanelFill = new FlowLayoutPanel();
            btnShowGenres = new Button();
            panelTop.SuspendLayout();
            flowLayoutPanelFill.SuspendLayout();
            SuspendLayout();
            // 
            // btnShowTypes
            // 
            btnShowTypes.AutoSize = true;
            btnShowTypes.Location = new Point(3, 3);
            btnShowTypes.Name = "btnShowTypes";
            btnShowTypes.Size = new Size(141, 43);
            btnShowTypes.TabIndex = 0;
            btnShowTypes.Text = "\"Типы аниме\"";
            btnShowTypes.UseVisualStyleBackColor = true;
            btnShowTypes.Click += BtnShowTypes_Click;
            // 
            // labelTop
            // 
            labelTop.AutoSize = true;
            labelTop.Location = new Point(13, 10);
            labelTop.Name = "labelTop";
            labelTop.Size = new Size(118, 25);
            labelTop.TabIndex = 0;
            labelTop.Text = "Отобразить:";
            labelTop.Click += label1_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTop);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(841, 39);
            panelTop.TabIndex = 3;
            // 
            // flowLayoutPanelFill
            // 
            flowLayoutPanelFill.Controls.Add(btnShowTypes);
            flowLayoutPanelFill.Controls.Add(btnShowGenres);
            flowLayoutPanelFill.Dock = DockStyle.Fill;
            flowLayoutPanelFill.Location = new Point(0, 39);
            flowLayoutPanelFill.Name = "flowLayoutPanelFill";
            flowLayoutPanelFill.Size = new Size(841, 587);
            flowLayoutPanelFill.TabIndex = 4;
            // 
            // btnShowGenres
            // 
            btnShowGenres.AutoSize = true;
            btnShowGenres.Location = new Point(150, 3);
            btnShowGenres.Name = "btnShowGenres";
            btnShowGenres.Size = new Size(157, 43);
            btnShowGenres.TabIndex = 2;
            btnShowGenres.Text = "\"Жанры аниме\"";
            btnShowGenres.UseVisualStyleBackColor = true;
            btnShowGenres.Click += BtnShowGenres_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(841, 626);
            Controls.Add(flowLayoutPanelFill);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Главная форма";
            Load += FormMain_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            flowLayoutPanelFill.ResumeLayout(false);
            flowLayoutPanelFill.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowTypes;
        private Label labelTop;
        private Panel panelTop;
        private FlowLayoutPanel flowLayoutPanelFill;

        private Button btnShowGenres;
    }
}
