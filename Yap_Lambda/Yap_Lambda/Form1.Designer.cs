namespace Yap_Lambda
{
    partial class Form1
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
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblQuantityOfItems = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(260, 147);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(100, 20);
            this.TxtQuantity.TabIndex = 0;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(285, 216);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 23);
            this.btnTotal.TabIndex = 1;
            this.btnTotal.Text = "TOTAL";
            this.btnTotal.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(431, 150);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "<RESULT>";
            // 
            // lblQuantityOfItems
            // 
            this.lblQuantityOfItems.AutoSize = true;
            this.lblQuantityOfItems.Location = new System.Drawing.Point(133, 150);
            this.lblQuantityOfItems.Name = "lblQuantityOfItems";
            this.lblQuantityOfItems.Size = new System.Drawing.Size(121, 13);
            this.lblQuantityOfItems.TabIndex = 3;
            this.lblQuantityOfItems.Text = "QUANTITY OF ITEMS: ";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(418, 216);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblQuantityOfItems);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.TxtQuantity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblQuantityOfItems;
        private System.Windows.Forms.Button btnClear;
    }
}

