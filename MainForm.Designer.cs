namespace FaceCensorApp.WinForms
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            tblMainLayout = new TableLayoutPanel();
            tblTopBar = new TableLayoutPanel();
            lblRootPathTop = new Label();
            txtRootPath = new TextBox();
            btnBrowseFolder = new Button();
            btnRefreshList = new Button();
            lblOnnxModel = new Label();
            txtModelPath = new TextBox();
            btnBrowseModel = new Button();
            lblTheme = new Label();
            cboTheme = new ComboBox();
            tblDetectionSettings = new TableLayoutPanel();
            lblMinConfidence = new Label();
            tblMainLayout.SuspendLayout();
            tblTopBar.SuspendLayout();
            tblDetectionSettings.SuspendLayout();
            SuspendLayout();
            // 
            // tblMainLayout
            // 
            tblMainLayout.ColumnCount = 1;
            tblMainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMainLayout.Controls.Add(tblTopBar, 0, 0);
            tblMainLayout.Controls.Add(tblDetectionSettings, 0, 1);
            tblMainLayout.Dock = DockStyle.Fill;
            tblMainLayout.Location = new Point(0, 0);
            tblMainLayout.Name = "tblMainLayout";
            tblMainLayout.RowCount = 5;
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 82F));
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 332F));
            tblMainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tblMainLayout.Size = new Size(1184, 762);
            tblMainLayout.TabIndex = 7;
            tblMainLayout.Paint += this.tblMainLayout_Paint;
            // 
            // tblTopBar
            // 
            tblTopBar.AutoSize = true;
            tblTopBar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblTopBar.ColumnCount = 9;
            tblTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tblTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tblTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tblTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tblTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tblTopBar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblTopBar.Controls.Add(lblRootPathTop, 0, 0);
            tblTopBar.Controls.Add(txtRootPath, 1, 0);
            tblTopBar.Controls.Add(btnBrowseFolder, 2, 0);
            tblTopBar.Controls.Add(btnRefreshList, 3, 0);
            tblTopBar.Controls.Add(lblOnnxModel, 4, 0);
            tblTopBar.Controls.Add(txtModelPath, 5, 0);
            tblTopBar.Controls.Add(btnBrowseModel, 6, 0);
            tblTopBar.Controls.Add(lblTheme, 7, 0);
            tblTopBar.Controls.Add(cboTheme, 8, 0);
            tblTopBar.Dock = DockStyle.Fill;
            tblTopBar.Location = new Point(3, 3);
            tblTopBar.Name = "tblTopBar";
            tblTopBar.RowCount = 1;
            tblTopBar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblTopBar.Size = new Size(1178, 30);
            tblTopBar.TabIndex = 0;
            // 
            // lblRootPathTop
            // 
            lblRootPathTop.Anchor = AnchorStyles.Left;
            lblRootPathTop.AutoSize = true;
            lblRootPathTop.Location = new Point(3, 7);
            lblRootPathTop.Name = "lblRootPathTop";
            lblRootPathTop.Size = new Size(56, 15);
            lblRootPathTop.TabIndex = 0;
            lblRootPathTop.Text = "Pasta raiz";
            lblRootPathTop.Click += this.label1_Click;
            // 
            // txtRootPath
            // 
            txtRootPath.Dock = DockStyle.Fill;
            txtRootPath.Location = new Point(83, 3);
            txtRootPath.Name = "txtRootPath";
            txtRootPath.Size = new Size(243, 23);
            txtRootPath.TabIndex = 1;
            // 
            // btnBrowseFolder
            // 
            btnBrowseFolder.AutoSize = true;
            btnBrowseFolder.Location = new Point(332, 3);
            btnBrowseFolder.Name = "btnBrowseFolder";
            btnBrowseFolder.Size = new Size(102, 24);
            btnBrowseFolder.TabIndex = 2;
            btnBrowseFolder.Text = "Selecionar pasta";
            btnBrowseFolder.UseVisualStyleBackColor = true;
            // 
            // btnRefreshList
            // 
            btnRefreshList.AutoSize = true;
            btnRefreshList.Location = new Point(442, 3);
            btnRefreshList.Name = "btnRefreshList";
            btnRefreshList.Size = new Size(87, 24);
            btnRefreshList.TabIndex = 3;
            btnRefreshList.Text = "Atualizar lista";
            btnRefreshList.UseVisualStyleBackColor = true;
            // 
            // lblOnnxModel
            // 
            lblOnnxModel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblOnnxModel.AutoSize = true;
            lblOnnxModel.Location = new Point(552, 0);
            lblOnnxModel.Name = "lblOnnxModel";
            lblOnnxModel.Size = new Size(84, 30);
            lblOnnxModel.TabIndex = 4;
            lblOnnxModel.Text = "Modelo ONNX";
            // 
            // txtModelPath
            // 
            txtModelPath.Dock = DockStyle.Fill;
            txtModelPath.Location = new Point(642, 3);
            txtModelPath.Name = "txtModelPath";
            txtModelPath.Size = new Size(243, 23);
            txtModelPath.TabIndex = 5;
            // 
            // btnBrowseModel
            // 
            btnBrowseModel.Location = new Point(891, 3);
            btnBrowseModel.Name = "btnBrowseModel";
            btnBrowseModel.Size = new Size(75, 23);
            btnBrowseModel.TabIndex = 6;
            btnBrowseModel.Text = "Selecionar modelo";
            btnBrowseModel.UseVisualStyleBackColor = true;
            // 
            // lblTheme
            // 
            lblTheme.Anchor = AnchorStyles.Left;
            lblTheme.AutoSize = true;
            lblTheme.Location = new Point(1011, 7);
            lblTheme.Name = "lblTheme";
            lblTheme.Size = new Size(36, 15);
            lblTheme.TabIndex = 7;
            lblTheme.Text = "Tema";
            // 
            // cboTheme
            // 
            cboTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTheme.FormattingEnabled = true;
            cboTheme.Location = new Point(1061, 3);
            cboTheme.Name = "cboTheme";
            cboTheme.Size = new Size(114, 23);
            cboTheme.TabIndex = 8;
            // 
            // tblDetectionSettings
            // 
            tblDetectionSettings.ColumnCount = 6;
            tblDetectionSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tblDetectionSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblDetectionSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            tblDetectionSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tblDetectionSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            tblDetectionSettings.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblDetectionSettings.Controls.Add(lblMinConfidence, 0, 0);
            tblDetectionSettings.Dock = DockStyle.Fill;
            tblDetectionSettings.Location = new Point(3, 39);
            tblDetectionSettings.Name = "tblDetectionSettings";
            tblDetectionSettings.RowCount = 2;
            tblDetectionSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            tblDetectionSettings.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tblDetectionSettings.Size = new Size(1178, 50);
            tblDetectionSettings.TabIndex = 1;
            tblDetectionSettings.Paint += this.tblDetectionSettings_Paint;
            // 
            // lblMinConfidence
            // 
            lblMinConfidence.Anchor = AnchorStyles.Left;
            lblMinConfidence.AutoSize = true;
            lblMinConfidence.Location = new Point(3, 6);
            lblMinConfidence.Name = "lblMinConfidence";
            lblMinConfidence.Size = new Size(105, 15);
            lblMinConfidence.TabIndex = 0;
            lblMinConfidence.Text = "Confiança mínima";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 762);
            Controls.Add(tblMainLayout);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(1200, 801);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Face Censor App";
            WindowState = FormWindowState.Maximized;
            Load += this.MainForm_Load;
            tblMainLayout.ResumeLayout(false);
            tblMainLayout.PerformLayout();
            tblTopBar.ResumeLayout(false);
            tblTopBar.PerformLayout();
            tblDetectionSettings.ResumeLayout(false);
            tblDetectionSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private TableLayoutPanel tblMainLayout;
        private TableLayoutPanel tblTopBar;
        private Label lblRootPathTop;
        private TextBox txtRootPath;
        private Button btnBrowseFolder;
        private Button btnRefreshList;
        private Label lblOnnxModel;
        private TextBox txtModelPath;
        private Button btnBrowseModel;
        private Label lblTheme;
        private ComboBox cboTheme;
        private TableLayoutPanel tblDetectionSettings;
        private Label lblMinConfidence;
    }
}