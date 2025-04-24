namespace AppTitlesAnime
{
    partial class FormAddGenre
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
            components = new System.ComponentModel.Container();
            panelTop = new Panel();
            textBoxGenreName = new TextBox();
            labelGenreName = new Label();
            flowLayoutPanelFill = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            errorProvider = new ErrorProvider(components);
            panelTop.SuspendLayout();
            flowLayoutPanelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(textBoxGenreName);
            panelTop.Controls.Add(labelGenreName);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(394, 141);
            panelTop.TabIndex = 0;
            // 
            // textBoxGenreName
            // 
            textBoxGenreName.Location = new Point(12, 39);
            textBoxGenreName.Margin = new Padding(3, 15, 3, 3);
            textBoxGenreName.Name = "textBoxGenreName";
            textBoxGenreName.Size = new Size(370, 33);
            textBoxGenreName.TabIndex = 2;
            textBoxGenreName.TextChanged += TextBoxGenreName_TextChanged_1;
            textBoxGenreName.Validating += TextBoxGenreName_Validating;
            textBoxGenreName.Validated += TextBoxGenreName_Validated;
            // 
            // labelGenreName
            // 
            labelGenreName.AutoSize = true;
            labelGenreName.Location = new Point(12, 9);
            labelGenreName.Name = "labelGenreName";
            labelGenreName.Size = new Size(120, 25);
            labelGenreName.TabIndex = 0;
            labelGenreName.Text = "Жанр аниме";
            // 
            // flowLayoutPanelFill
            // 
            flowLayoutPanelFill.Controls.Add(btnSaveChanges);
            flowLayoutPanelFill.Controls.Add(btnCancel);
            flowLayoutPanelFill.Dock = DockStyle.Bottom;
            flowLayoutPanelFill.Location = new Point(0, 80);
            flowLayoutPanelFill.Margin = new Padding(5);
            flowLayoutPanelFill.Name = "flowLayoutPanelFill";
            flowLayoutPanelFill.Padding = new Padding(10);
            flowLayoutPanelFill.Size = new Size(394, 61);
            flowLayoutPanelFill.TabIndex = 1;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(13, 13);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(115, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += BtnSaveChanges_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(134, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAddGenre
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(394, 141);
            Controls.Add(flowLayoutPanelFill);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddGenre";
            Text = "FormAddGenre";
            Load += FormAddGenre_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            flowLayoutPanelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private FlowLayoutPanel flowLayoutPanelFill;
        private Button btnSaveChanges;
        private Button btnCancel;
        private Label labelGenreName;
        private ErrorProvider errorProvider;
        protected internal TextBox textBoxGenreName;
    }
}