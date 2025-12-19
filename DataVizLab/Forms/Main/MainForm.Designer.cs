using ScottPlot;

namespace DataVizLab.Forms.Main
{
    partial class MainForm
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
            panelRoot = new TableLayoutPanel();
            panelButtons = new TableLayoutPanel();
            btnInput = new Button();
            btnNew = new Button();
            btnEdit = new Button();
            btnReset = new Button();
            chart = new FormsPlot();
            panelRoot.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panelRoot
            // 
            panelRoot.ColumnCount = 1;
            panelRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelRoot.Controls.Add(panelButtons, 0, 1);
            panelRoot.Controls.Add(chart, 0, 0);
            panelRoot.Dock = DockStyle.Fill;
            panelRoot.Location = new Point(0, 0);
            panelRoot.Name = "panelRoot";
            panelRoot.Padding = new Padding(10);
            panelRoot.RowCount = 2;
            panelRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 87.5F));
            panelRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            panelRoot.Size = new Size(668, 439);
            panelRoot.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.ColumnCount = 4;
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            panelButtons.Controls.Add(btnInput, 0, 0);
            panelButtons.Controls.Add(btnNew, 1, 0);
            panelButtons.Controls.Add(btnEdit, 2, 0);
            panelButtons.Controls.Add(btnReset, 3, 0);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(13, 379);
            panelButtons.Name = "panelButtons";
            panelButtons.RowCount = 1;
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panelButtons.Size = new Size(642, 47);
            panelButtons.TabIndex = 1;
            // 
            // btnInput
            // 
            btnInput.Dock = DockStyle.Fill;
            btnInput.Location = new Point(3, 3);
            btnInput.Name = "btnInput";
            btnInput.Size = new Size(154, 41);
            btnInput.TabIndex = 0;
            btnInput.Text = "导入";
            btnInput.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Fill;
            btnNew.Location = new Point(163, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(154, 41);
            btnNew.TabIndex = 1;
            btnNew.Text = "新建";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Location = new Point(323, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(154, 41);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "编辑";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Dock = DockStyle.Fill;
            btnReset.Location = new Point(483, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(156, 41);
            btnReset.TabIndex = 3;
            btnReset.Text = "重置";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chart.Dock = DockStyle.Fill;
            chart.Location = new Point(14, 13);
            chart.Margin = new Padding(4, 3, 4, 3);
            chart.Name = "chart";
            chart.Size = new Size(640, 360);
            chart.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 439);
            Controls.Add(panelRoot);
            Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Winform";
            panelRoot.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel panelRoot;
        private TableLayoutPanel panelButtons;
        private Button btnInput;
        private Button btnNew;
        private Button btnEdit;
        private Button btnReset;
        private FormsPlot chart;
    }
}
