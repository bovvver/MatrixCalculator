namespace MatrixCalculator
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            sddsToolStripMenuItem = new ToolStripMenuItem();
            sddsToolStripMenuItem1 = new ToolStripMenuItem();
            dsToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip3 = new ContextMenuStrip(components);
            sdsToolStripMenuItem = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            dataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            runButton = new Button();
            clearButton = new Button();
            readB_Button = new Button();
            readA_Button = new Button();
            scalarBox = new TextBox();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { sddsToolStripMenuItem, sddsToolStripMenuItem1, dsToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(99, 70);
            // 
            // sddsToolStripMenuItem
            // 
            sddsToolStripMenuItem.Name = "sddsToolStripMenuItem";
            sddsToolStripMenuItem.Size = new Size(98, 22);
            sddsToolStripMenuItem.Text = "sdds";
            // 
            // sddsToolStripMenuItem1
            // 
            sddsToolStripMenuItem1.Name = "sddsToolStripMenuItem1";
            sddsToolStripMenuItem1.Size = new Size(98, 22);
            sddsToolStripMenuItem1.Text = "sdds";
            // 
            // dsToolStripMenuItem
            // 
            dsToolStripMenuItem.Name = "dsToolStripMenuItem";
            dsToolStripMenuItem.Size = new Size(98, 22);
            dsToolStripMenuItem.Text = "ds";
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(20, 20);
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { sdsToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(92, 26);
            // 
            // sdsToolStripMenuItem
            // 
            sdsToolStripMenuItem.Name = "sdsToolStripMenuItem";
            sdsToolStripMenuItem.Size = new Size(91, 22);
            sdsToolStripMenuItem.Text = "sds";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A + B", "A - B", "A * B", "A * N" });
            comboBox1.Location = new Point(10, 9);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "A + B";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column11, Column12, Column13, Column14, Column8, Column9, Column10 });
            dataGridView.Location = new Point(10, 34);
            dataGridView.Margin = new Padding(3, 2, 3, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(679, 294);
            dataGridView.TabIndex = 6;
            dataGridView.Rows.Add(12);
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.HeaderText = "";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 50;
            // 
            // Column5
            // 
            Column5.HeaderText = "";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 50;
            // 
            // Column6
            // 
            Column6.HeaderText = "";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 50;
            // 
            // Column7
            // 
            Column7.HeaderText = "";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 50;
            // 
            // Column11
            // 
            Column11.HeaderText = "";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 50;
            // 
            // Column12
            // 
            Column12.HeaderText = "";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 50;
            // 
            // Column13
            // 
            Column13.HeaderText = "";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.Width = 50;
            // 
            // Column14
            // 
            Column14.HeaderText = "";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.Width = 50;
            // 
            // Column8
            // 
            Column8.HeaderText = "";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 50;
            // 
            // Column9
            // 
            Column9.HeaderText = "";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 50;
            // 
            // Column10
            // 
            Column10.HeaderText = "";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 50;
            // 
            // runButton
            // 
            runButton.Location = new Point(273, 9);
            runButton.Margin = new Padding(3, 2, 3, 2);
            runButton.Name = "runButton";
            runButton.Size = new Size(82, 22);
            runButton.TabIndex = 7;
            runButton.Text = "RUN";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(607, 9);
            clearButton.Margin = new Padding(3, 2, 3, 2);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(82, 22);
            clearButton.TabIndex = 8;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // readB_Button
            // 
            readB_Button.Location = new Point(520, 9);
            readB_Button.Margin = new Padding(3, 2, 3, 2);
            readB_Button.Name = "readB_Button";
            readB_Button.Size = new Size(82, 22);
            readB_Button.TabIndex = 9;
            readB_Button.Text = "READ B";
            readB_Button.UseVisualStyleBackColor = true;
            readB_Button.Click += readB_Button_Click;
            // 
            // readA_Button
            // 
            readA_Button.Location = new Point(432, 9);
            readA_Button.Margin = new Padding(3, 2, 3, 2);
            readA_Button.Name = "readA_Button";
            readA_Button.Size = new Size(82, 22);
            readA_Button.TabIndex = 10;
            readA_Button.Text = "READ A";
            readA_Button.UseVisualStyleBackColor = true;
            readA_Button.Click += readA_Button_Click;
            // 
            // scalarBox
            // 
            scalarBox.Enabled = false;
            scalarBox.Location = new Point(149, 9);
            scalarBox.Name = "scalarBox";
            scalarBox.PlaceholderText = "Scalar";
            scalarBox.Size = new Size(119, 23);
            scalarBox.TabIndex = 11;
            scalarBox.KeyPress += scalarBox_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(scalarBox);
            Controls.Add(readA_Button);
            Controls.Add(readB_Button);
            Controls.Add(clearButton);
            Controls.Add(runButton);
            Controls.Add(dataGridView);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem sddsToolStripMenuItem;
        private ToolStripMenuItem sddsToolStripMenuItem1;
        private ToolStripMenuItem dsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem sdsToolStripMenuItem;
        private ComboBox comboBox1;
        private DataGridView dataGridView;
        private Button runButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private Button clearButton;
        private Button readB_Button;
        private Button readA_Button;
        private TextBox scalarBox;
    }
}
