namespace SDRSharp.FreqToProscan
{
    partial class FreqGridWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridViewFreq = new System.Windows.Forms.DataGridView();
            comboBoxUnits = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            comboBoxGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFreq).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewFreq
            // 
            dataGridViewFreq.AllowUserToOrderColumns = true;
            dataGridViewFreq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewFreq.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewFreq.ColumnHeadersHeight = 46;
            dataGridViewFreq.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewFreq.Location = new System.Drawing.Point(5, 100);
            dataGridViewFreq.Name = "dataGridViewFreq";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "123";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewFreq.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewFreq.RowHeadersWidth = 82;
            dataGridViewFreq.RowTemplate.Height = 41;
            dataGridViewFreq.Size = new System.Drawing.Size(1361, 689);
            dataGridViewFreq.TabIndex = 0;
            // 
            // comboBoxUnits
            // 
            comboBoxUnits.FormattingEnabled = true;
            comboBoxUnits.Location = new System.Drawing.Point(265, 19);
            comboBoxUnits.Name = "comboBoxUnits";
            comboBoxUnits.Size = new System.Drawing.Size(242, 40);
            comboBoxUnits.TabIndex = 1;
            comboBoxUnits.SelectedIndexChanged += comboBoxUnits_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 22);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(251, 32);
            label2.TabIndex = 4;
            label2.Text = "Units of measurement";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(590, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 32);
            label1.TabIndex = 5;
            label1.Text = "Group";
            // 
            // comboBoxGroup
            // 
            comboBoxGroup.FormattingEnabled = true;
            comboBoxGroup.Location = new System.Drawing.Point(693, 22);
            comboBoxGroup.Name = "comboBoxGroup";
            comboBoxGroup.Size = new System.Drawing.Size(242, 40);
            comboBoxGroup.TabIndex = 6;
            comboBoxGroup.SelectedIndexChanged += comboBoxGroup_SelectedIndexChanged;
            // 
            // FreqGridWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1371, 794);
            Controls.Add(comboBoxGroup);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(comboBoxUnits);
            Controls.Add(dataGridViewFreq);
            Name = "FreqGridWindow";
            Padding = new System.Windows.Forms.Padding(5, 100, 5, 5);
            Text = "FreqGridWindow";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFreq).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFreq;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGroup;
    }
}