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
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new System.Drawing.Point(20, 3);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(242, 46);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new System.Drawing.Point(276, 3);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new System.Drawing.Size(242, 46);
            buttonCopy.TabIndex = 2;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            // 
            // textBoxFreq
            // 
            textBoxFreq.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxFreq.Location = new System.Drawing.Point(20, 217);
            textBoxFreq.Multiline = true;
            textBoxFreq.Name = "textBoxFreq";
            textBoxFreq.Size = new System.Drawing.Size(498, 580);
            textBoxFreq.TabIndex = 0;
            // 
            // ControlPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(buttonCopy);
            Controls.Add(buttonUpdate);
            Controls.Add(textBoxFreq);
            Margin = new System.Windows.Forms.Padding(6);
            Name = "ControlPanel";
            Size = new System.Drawing.Size(529, 817);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox textBoxFreq;
    }
}
