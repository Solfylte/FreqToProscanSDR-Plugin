namespace SDRSharp.FreqToProscan
{
    partial class ControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxFreq = new System.Windows.Forms.TextBox();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            label1 = new System.Windows.Forms.Label();
            buttonShowFreqTable = new System.Windows.Forms.Button();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            buttonUpdate = new System.Windows.Forms.Button();
            buttonCopy = new System.Windows.Forms.Button();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            splitContainer4 = new System.Windows.Forms.SplitContainer();
            label2 = new System.Windows.Forms.Label();
            comboBoxScanerType = new System.Windows.Forms.ComboBox();
            comboBoxGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxFreq
            // 
            textBoxFreq.Location = new System.Drawing.Point(5, 5);
            textBoxFreq.Margin = new System.Windows.Forms.Padding(10);
            textBoxFreq.Multiline = true;
            textBoxFreq.Name = "textBoxFreq";
            textBoxFreq.Size = new System.Drawing.Size(468, 624);
            textBoxFreq.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new System.Drawing.Point(5, 60);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label1);
            splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(comboBoxGroup);
            splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(10);
            splitContainer2.Size = new System.Drawing.Size(478, 64);
            splitContainer2.SplitterDistance = 110;
            splitContainer2.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 32);
            label1.TabIndex = 7;
            label1.Text = "Group";
            // 
            // buttonShowFreqTable
            // 
            buttonShowFreqTable.Location = new System.Drawing.Point(5, 5);
            buttonShowFreqTable.Name = "buttonShowFreqTable";
            buttonShowFreqTable.Padding = new System.Windows.Forms.Padding(5);
            buttonShowFreqTable.Size = new System.Drawing.Size(468, 59);
            buttonShowFreqTable.TabIndex = 3;
            buttonShowFreqTable.Text = "Show table";
            buttonShowFreqTable.UseVisualStyleBackColor = true;
            buttonShowFreqTable.Click += buttonShowFreqTable_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new System.Drawing.Point(5, 5);
            splitContainer1.Margin = new System.Windows.Forms.Padding(10);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonUpdate);
            splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonCopy);
            splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            splitContainer1.Size = new System.Drawing.Size(478, 55);
            splitContainer1.SplitterDistance = 223;
            splitContainer1.SplitterIncrement = 5;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 4;
            // 
            // buttonUpdate
            // 
            buttonUpdate.AutoSize = true;
            buttonUpdate.Location = new System.Drawing.Point(5, 5);
            buttonUpdate.Margin = new System.Windows.Forms.Padding(5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(213, 45);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonCopy
            // 
            buttonCopy.AutoSize = true;
            buttonCopy.Location = new System.Drawing.Point(5, 5);
            buttonCopy.Margin = new System.Windows.Forms.Padding(5);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new System.Drawing.Size(235, 45);
            buttonCopy.TabIndex = 2;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // splitContainer3
            // 
            splitContainer3.Location = new System.Drawing.Point(5, 223);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(textBoxFreq);
            splitContainer3.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(buttonShowFreqTable);
            splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(5);
            splitContainer3.Size = new System.Drawing.Size(478, 608);
            splitContainer3.SplitterDistance = 545;
            splitContainer3.TabIndex = 10;
            // 
            // splitContainer4
            // 
            splitContainer4.Location = new System.Drawing.Point(5, 130);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(label2);
            splitContainer4.Panel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(comboBoxScanerType);
            splitContainer4.Panel2.Padding = new System.Windows.Forms.Padding(10);
            splitContainer4.Size = new System.Drawing.Size(478, 64);
            splitContainer4.SplitterDistance = 110;
            splitContainer4.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 32);
            label2.TabIndex = 7;
            label2.Text = "Scaner:";
            // 
            // comboBoxScanerType
            // 
            comboBoxScanerType.FormattingEnabled = true;
            comboBoxScanerType.Location = new System.Drawing.Point(10, 10);
            comboBoxScanerType.Name = "comboBoxScanerType";
            comboBoxScanerType.Size = new System.Drawing.Size(344, 40);
            comboBoxScanerType.TabIndex = 8;
            comboBoxScanerType.SelectedIndexChanged += comboBoxScanerType_SelectedIndexChanged;
            // 
            // comboBoxGroup
            // 
            comboBoxGroup.FormattingEnabled = true;
            comboBoxGroup.Location = new System.Drawing.Point(10, 12);
            comboBoxGroup.Name = "comboBoxGroup";
            comboBoxGroup.Size = new System.Drawing.Size(344, 40);
            comboBoxGroup.TabIndex = 9;
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer4);
            Controls.Add(splitContainer3);
            Controls.Add(splitContainer2);
            Controls.Add(splitContainer1);
            Margin = new System.Windows.Forms.Padding(10);
            Name = "ControlPanel";
            Padding = new System.Windows.Forms.Padding(5);
            Size = new System.Drawing.Size(488, 836);
            Enter += ControlPanel_Enter;
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowFreqTable;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxScanerType;
        private System.Windows.Forms.ComboBox comboBoxGroup;
    }
}
