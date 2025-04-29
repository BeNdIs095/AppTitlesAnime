namespace AppTitlesAnime.Statuses
{
    partial class FormAddStatus
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
            flowLayoutPanelFill = new FlowLayoutPanel();
            btnSaveChanges = new Button();
            btnCancel = new Button();
            textBoxStatusName = new TextBox();
            labelStatusName = new Label();
            errorProvider = new ErrorProvider(components);
            panelTop.SuspendLayout();
            flowLayoutPanelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(flowLayoutPanelFill);
            panelTop.Controls.Add(textBoxStatusName);
            panelTop.Controls.Add(labelStatusName);
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(5);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(394, 141);
            panelTop.TabIndex = 1;
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
            flowLayoutPanelFill.TabIndex = 3;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.DialogResult = DialogResult.OK;
            btnSaveChanges.Location = new Point(13, 13);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(115, 35);
            btnSaveChanges.TabIndex = 0;
            btnSaveChanges.Text = "Сохранить";
            btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(134, 13);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBoxStatusName
            // 
            textBoxStatusName.Location = new Point(12, 39);
            textBoxStatusName.Margin = new Padding(3, 15, 3, 3);
            textBoxStatusName.Name = "textBoxStatusName";
            textBoxStatusName.Size = new Size(370, 33);
            textBoxStatusName.TabIndex = 2;
            textBoxStatusName.TextChanged += textBoxStatusName_TextChanged;
            textBoxStatusName.Validating += textBoxStatusName_Validating;
            // 
            // labelStatusName
            // 
            labelStatusName.AutoSize = true;
            labelStatusName.Location = new Point(12, 9);
            labelStatusName.Name = "labelStatusName";
            labelStatusName.Size = new Size(128, 25);
            labelStatusName.TabIndex = 0;
            labelStatusName.Text = "Статус аниме";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAddStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 141);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddStatus";
            Text = "FormAddStatus";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            flowLayoutPanelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        protected internal TextBox textBoxStatusName;
        private Label labelStatusName;
        private FlowLayoutPanel flowLayoutPanelFill;
        protected Button btnSaveChanges;
        private Button btnCancel;
        private ErrorProvider errorProvider;
    }
}