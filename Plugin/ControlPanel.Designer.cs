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
            buttonUpdate = new System.Windows.Forms.Button();
            buttonCopy = new System.Windows.Forms.Button();
            textBoxFreq = new System.Windows.Forms.TextBox();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            buttonShowFreqTable = new System.Windows.Forms.Button();
            comboBoxGroup = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.AutoSize = true;
            buttonUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonUpdate.Location = new System.Drawing.Point(5, 5);
            buttonUpdate.Margin = new System.Windows.Forms.Padding(5);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(268, 40);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonCopy
            // 
            buttonCopy.AutoSize = true;
            buttonCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonCopy.Location = new System.Drawing.Point(5, 5);
            buttonCopy.Margin = new System.Windows.Forms.Padding(5);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new System.Drawing.Size(296, 40);
            buttonCopy.TabIndex = 2;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            // 
            // textBoxFreq
            // 
            textBoxFreq.Dock = System.Windows.Forms.DockStyle.Fill;
            textBoxFreq.Location = new System.Drawing.Point(5, 10);
            textBoxFreq.Margin = new System.Windows.Forms.Padding(10);
            textBoxFreq.Multiline = true;
            textBoxFreq.Name = "textBoxFreq";
            textBoxFreq.Size = new System.Drawing.Size(584, 599);
            textBoxFreq.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
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
            splitContainer1.Size = new System.Drawing.Size(594, 50);
            splitContainer1.SplitterDistance = 278;
            splitContainer1.SplitterIncrement = 5;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.Location = new System.Drawing.Point(5, 55);
            splitContainer2.Margin = new System.Windows.Forms.Padding(10);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(textBoxFreq);
            splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Panel2MinSize = 50;
            splitContainer2.Size = new System.Drawing.Size(594, 686);
            splitContainer2.SplitterDistance = 614;
            splitContainer2.TabIndex = 5;
            // 
            // buttonShowFreqTable
            // 
            buttonShowFreqTable.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonShowFreqTable.Location = new System.Drawing.Point(0, 0);
            buttonShowFreqTable.Name = "buttonShowFreqTable";
            buttonShowFreqTable.Padding = new System.Windows.Forms.Padding(5);
            buttonShowFreqTable.Size = new System.Drawing.Size(219, 68);
            buttonShowFreqTable.TabIndex = 3;
            buttonShowFreqTable.Text = "Show table";
            buttonShowFreqTable.UseVisualStyleBackColor = true;
            buttonShowFreqTable.Click += buttonShowFreqTable_Click;
            // 
            // comboBoxGroup
            // 
            comboBoxGroup.FormattingEnabled = true;
            comboBoxGroup.Location = new System.Drawing.Point(121, 15);
            comboBoxGroup.Name = "comboBoxGroup";
            comboBoxGroup.Size = new System.Drawing.Size(242, 40);
            comboBoxGroup.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(23, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 32);
            label1.TabIndex = 7;
            label1.Text = "Group";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.Location = new System.Drawing.Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(buttonShowFreqTable);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(comboBoxGroup);
            splitContainer3.Panel2.Controls.Add(label1);
            splitContainer3.Panel2.Padding = new System.Windows.Forms.Padding(5);
            splitContainer3.Size = new System.Drawing.Size(594, 68);
            splitContainer3.SplitterDistance = 219;
            splitContainer3.TabIndex = 0;
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer2);
            Controls.Add(splitContainer1);
            Margin = new System.Windows.Forms.Padding(10);
            Name = "ControlPanel";
            Padding = new System.Windows.Forms.Padding(5);
            Size = new System.Drawing.Size(604, 746);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonShowFreqTable;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label label1;
    }
}
