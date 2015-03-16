namespace FP.Spartakiade2015.UiManipulation.WinApp
{
    partial class DocumentControl
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
            this.labDocument = new System.Windows.Forms.Label();
            this.labObjectId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labDocument
            // 
            this.labDocument.AutoSize = true;
            this.labDocument.Location = new System.Drawing.Point(121, 103);
            this.labDocument.Name = "labDocument";
            this.labDocument.Size = new System.Drawing.Size(62, 13);
            this.labDocument.TabIndex = 0;
            this.labDocument.Text = "Dokumente";
            // 
            // labObjectId
            // 
            this.labObjectId.AutoSize = true;
            this.labObjectId.Location = new System.Drawing.Point(121, 133);
            this.labObjectId.Name = "labObjectId";
            this.labObjectId.Size = new System.Drawing.Size(0, 13);
            this.labObjectId.TabIndex = 0;
            // 
            // AdditionalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labObjectId);
            this.Controls.Add(this.labDocument);
            this.Name = "AdditionalControl";
            this.Size = new System.Drawing.Size(373, 268);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDocument;
        private System.Windows.Forms.Label labObjectId;
    }
}
