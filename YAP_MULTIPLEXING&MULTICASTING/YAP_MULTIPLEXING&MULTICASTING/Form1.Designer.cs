namespace YAP_MULTIPLEXING_MULTICASTING
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblYourMessage = new System.Windows.Forms.Label();
            this.lblShowMessage = new System.Windows.Forms.Label();
            this.lblMessageUpdate = new System.Windows.Forms.Label();
            this.lblUpdateMessage = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbChoice = new System.Windows.Forms.ComboBox();
            this.txtYourMessage = new System.Windows.Forms.TextBox();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(0, 25);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(99, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "YOUR MESSAGE: ";
            // 
            // lblYourMessage
            // 
            this.lblYourMessage.AutoSize = true;
            this.lblYourMessage.Location = new System.Drawing.Point(5, 219);
            this.lblYourMessage.Name = "lblYourMessage";
            this.lblYourMessage.Size = new System.Drawing.Size(117, 13);
            this.lblYourMessage.TabIndex = 1;
            this.lblYourMessage.Text = "YOUR MESSAGE TO: ";
            // 
            // lblShowMessage
            // 
            this.lblShowMessage.AutoSize = true;
            this.lblShowMessage.Location = new System.Drawing.Point(128, 219);
            this.lblShowMessage.Name = "lblShowMessage";
            this.lblShowMessage.Size = new System.Drawing.Size(50, 13);
            this.lblShowMessage.TabIndex = 2;
            this.lblShowMessage.Text = "Reciever";
            // 
            // lblMessageUpdate
            // 
            this.lblMessageUpdate.AutoSize = true;
            this.lblMessageUpdate.Location = new System.Drawing.Point(5, 248);
            this.lblMessageUpdate.Name = "lblMessageUpdate";
            this.lblMessageUpdate.Size = new System.Drawing.Size(112, 13);
            this.lblMessageUpdate.TabIndex = 3;
            this.lblMessageUpdate.Text = "MESSAGE UPDATE: ";
            // 
            // lblUpdateMessage
            // 
            this.lblUpdateMessage.AutoSize = true;
            this.lblUpdateMessage.Location = new System.Drawing.Point(128, 248);
            this.lblUpdateMessage.Name = "lblUpdateMessage";
            this.lblUpdateMessage.Size = new System.Drawing.Size(40, 13);
            this.lblUpdateMessage.TabIndex = 4;
            this.lblUpdateMessage.Text = "update";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(313, 325);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 31);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cmbChoice
            // 
            this.cmbChoice.FormattingEnabled = true;
            this.cmbChoice.Location = new System.Drawing.Point(105, 48);
            this.cmbChoice.Name = "cmbChoice";
            this.cmbChoice.Size = new System.Drawing.Size(121, 21);
            this.cmbChoice.TabIndex = 6;
            // 
            // txtYourMessage
            // 
            this.txtYourMessage.Location = new System.Drawing.Point(105, 22);
            this.txtYourMessage.Name = "txtYourMessage";
            this.txtYourMessage.Size = new System.Drawing.Size(121, 20);
            this.txtYourMessage.TabIndex = 7;
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(431, 38);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(303, 173);
            this.lstResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.txtYourMessage);
            this.Controls.Add(this.cmbChoice);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblUpdateMessage);
            this.Controls.Add(this.lblMessageUpdate);
            this.Controls.Add(this.lblShowMessage);
            this.Controls.Add(this.lblYourMessage);
            this.Controls.Add(this.lblMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblYourMessage;
        private System.Windows.Forms.Label lblShowMessage;
        private System.Windows.Forms.Label lblMessageUpdate;
        private System.Windows.Forms.Label lblUpdateMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cmbChoice;
        private System.Windows.Forms.TextBox txtYourMessage;
        private System.Windows.Forms.ListBox lstResult;
    }
}

