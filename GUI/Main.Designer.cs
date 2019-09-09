﻿namespace GUI
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_compile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_compile_analyze = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_compile_compile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_help = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.dgTokens = new System.Windows.Forms.DataGridView();
            this.Line = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTokens = new System.Windows.Forms.BindingSource(this.components);
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tokenLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.sourceCode = new EasyScintilla.SimpleEditor();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTokens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTokens)).BeginInit();
            this.mainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_file,
            this.menuItem_compile,
            this.menuItem_help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(908, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "mainMenu";
            // 
            // menuItem_file
            // 
            this.menuItem_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_file_new,
            this.menuItem_file_open,
            this.menuItem_file_save});
            this.menuItem_file.Name = "menuItem_file";
            this.menuItem_file.Size = new System.Drawing.Size(61, 20);
            this.menuItem_file.Text = "Arquivo";
            // 
            // menuItem_file_new
            // 
            this.menuItem_file_new.Name = "menuItem_file_new";
            this.menuItem_file_new.Size = new System.Drawing.Size(105, 22);
            this.menuItem_file_new.Text = "Novo";
            this.menuItem_file_new.Click += new System.EventHandler(this.NewFileAction);
            // 
            // menuItem_file_open
            // 
            this.menuItem_file_open.Name = "menuItem_file_open";
            this.menuItem_file_open.Size = new System.Drawing.Size(105, 22);
            this.menuItem_file_open.Text = "Abrir";
            this.menuItem_file_open.Click += new System.EventHandler(this.OpenFileAction);
            // 
            // menuItem_file_save
            // 
            this.menuItem_file_save.Name = "menuItem_file_save";
            this.menuItem_file_save.Size = new System.Drawing.Size(105, 22);
            this.menuItem_file_save.Text = "Salvar";
            this.menuItem_file_save.Click += new System.EventHandler(this.SaveFileAction);
            // 
            // menuItem_compile
            // 
            this.menuItem_compile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_compile_analyze,
            this.menuItem_compile_compile});
            this.menuItem_compile.Name = "menuItem_compile";
            this.menuItem_compile.Size = new System.Drawing.Size(68, 20);
            this.menuItem_compile.Text = "Compilar";
            // 
            // menuItem_compile_analyze
            // 
            this.menuItem_compile_analyze.Name = "menuItem_compile_analyze";
            this.menuItem_compile_analyze.Size = new System.Drawing.Size(198, 22);
            this.menuItem_compile_analyze.Text = "Analizar Código Fonte";
            this.menuItem_compile_analyze.Click += new System.EventHandler(this.AnalyzeCodeAction);
            // 
            // menuItem_compile_compile
            // 
            this.menuItem_compile_compile.Name = "menuItem_compile_compile";
            this.menuItem_compile_compile.Size = new System.Drawing.Size(198, 22);
            this.menuItem_compile_compile.Text = "Compilar Código Fonte";
            this.menuItem_compile_compile.Click += new System.EventHandler(this.CompileCodeAction);
            // 
            // menuItem_help
            // 
            this.menuItem_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_help_about});
            this.menuItem_help.Name = "menuItem_help";
            this.menuItem_help.Size = new System.Drawing.Size(50, 20);
            this.menuItem_help.Text = "Ajuda";
            // 
            // menuItem_help_about
            // 
            this.menuItem_help_about.Name = "menuItem_help_about";
            this.menuItem_help_about.Size = new System.Drawing.Size(183, 22);
            this.menuItem_help_about.Text = "Sobre Compiler 2019";
            this.menuItem_help_about.Click += new System.EventHandler(this.AboutAction);
            // 
            // dgTokens
            // 
            this.dgTokens.AllowUserToAddRows = false;
            this.dgTokens.AllowUserToDeleteRows = false;
            this.dgTokens.AllowUserToResizeRows = false;
            this.dgTokens.AutoGenerateColumns = false;
            this.dgTokens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTokens.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgTokens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgTokens.CausesValidation = false;
            this.dgTokens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Line,
            this.codeDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dgTokens.DataSource = this.bsTokens;
            this.dgTokens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTokens.Location = new System.Drawing.Point(678, 31);
            this.dgTokens.Margin = new System.Windows.Forms.Padding(0);
            this.dgTokens.MultiSelect = false;
            this.dgTokens.Name = "dgTokens";
            this.dgTokens.ReadOnly = true;
            this.dgTokens.RowHeadersVisible = false;
            this.dgTokens.RowTemplate.ReadOnly = true;
            this.dgTokens.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTokens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTokens.Size = new System.Drawing.Size(226, 570);
            this.dgTokens.TabIndex = 2;
            this.dgTokens.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRowFocusEvent);
            this.dgTokens.Leave += new System.EventHandler(this.dataGridFocusLeaveEvent);
            // 
            // Line
            // 
            this.Line.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Line.DataPropertyName = "Line";
            this.Line.FillWeight = 47F;
            this.Line.HeaderText = "Linha";
            this.Line.MaxInputLength = 5;
            this.Line.Name = "Line";
            this.Line.ReadOnly = true;
            this.Line.Width = 47;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.FillWeight = 47F;
            this.codeDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Width = 47;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.FillWeight = 110.2238F;
            this.valueDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsTokens
            // 
            this.bsTokens.DataSource = typeof(GUI.DataGrid.DataGridLineItem);
            // 
            // mainTableLayout
            // 
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.88987F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.11013F));
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayout.Controls.Add(this.tokenLabel, 1, 0);
            this.mainTableLayout.Controls.Add(this.dgTokens, 1, 1);
            this.mainTableLayout.Controls.Add(this.fileNameLabel, 0, 0);
            this.mainTableLayout.Controls.Add(this.sourceCode, 0, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.15807F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.84193F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.mainTableLayout.Size = new System.Drawing.Size(908, 605);
            this.mainTableLayout.TabIndex = 5;
            // 
            // tokenLabel
            // 
            this.tokenLabel.AutoSize = true;
            this.tokenLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tokenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokenLabel.Location = new System.Drawing.Point(678, 12);
            this.tokenLabel.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.tokenLabel.Name = "tokenLabel";
            this.tokenLabel.Size = new System.Drawing.Size(226, 19);
            this.tokenLabel.TabIndex = 5;
            this.tokenLabel.Text = "Tokens";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AccessibleDescription = "";
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(4, 12);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(94, 13);
            this.fileNameLabel.TabIndex = 4;
            this.fileNameLabel.Text = "dinamic_file_name";
            this.fileNameLabel.MouseHover += new System.EventHandler(this.fileNameLabelMouseOverAction);
            // 
            // sourceCode
            // 
            this.sourceCode.AutoCAutoHide = false;
            this.sourceCode.AutoCCancelAtStart = false;
            this.sourceCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceCode.IndentationGuides = ScintillaNET.IndentView.LookBoth;
            this.sourceCode.Location = new System.Drawing.Point(7, 34);
            this.sourceCode.Name = "sourceCode";
            this.sourceCode.ScrollWidth = 100;
            this.sourceCode.Size = new System.Drawing.Size(668, 564);
            this.sourceCode.Styler = null;
            this.sourceCode.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(908, 629);
            this.Controls.Add(this.mainTableLayout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Compiler 2019";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTokens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTokens)).EndInit();
            this.mainTableLayout.ResumeLayout(false);
            this.mainTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsTokens;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_file;
        private System.Windows.Forms.ToolStripMenuItem menuItem_file_new;
        private System.Windows.Forms.ToolStripMenuItem menuItem_file_open;
        private System.Windows.Forms.ToolStripMenuItem menuItem_compile;
        private System.Windows.Forms.ToolStripMenuItem menuItem_file_save;
        private System.Windows.Forms.ToolStripMenuItem menuItem_compile_analyze;
        private System.Windows.Forms.ToolStripMenuItem menuItem_compile_compile;
        private System.Windows.Forms.ToolStripMenuItem menuItem_help;
        private System.Windows.Forms.ToolStripMenuItem menuItem_help_about;
        private System.Windows.Forms.DataGridView dgTokens;
        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label tokenLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private EasyScintilla.SimpleEditor sourceCode;
    }
}

