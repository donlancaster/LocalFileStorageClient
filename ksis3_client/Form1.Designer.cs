
namespace ksis3_client
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
            this.okButton = new System.Windows.Forms.Button();
            this.getButton = new System.Windows.Forms.RadioButton();
            this.putButton = new System.Windows.Forms.RadioButton();
            this.deleteButton = new System.Windows.Forms.RadioButton();
            this.postButton = new System.Windows.Forms.RadioButton();
            this.moveButton = new System.Windows.Forms.RadioButton();
            this.copyButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(155, 107);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // getButton
            // 
            this.getButton.AutoSize = true;
            this.getButton.Checked = true;
            this.getButton.Location = new System.Drawing.Point(32, 48);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(45, 19);
            this.getButton.TabIndex = 1;
            this.getButton.TabStop = true;
            this.getButton.Text = "GET";
            this.getButton.UseVisualStyleBackColor = true;
            // 
            // putButton
            // 
            this.putButton.AutoSize = true;
            this.putButton.Location = new System.Drawing.Point(32, 73);
            this.putButton.Name = "putButton";
            this.putButton.Size = new System.Drawing.Size(46, 19);
            this.putButton.TabIndex = 2;
            this.putButton.Text = "PUT";
            this.putButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.Location = new System.Drawing.Point(32, 123);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(63, 19);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // postButton
            // 
            this.postButton.AutoSize = true;
            this.postButton.Location = new System.Drawing.Point(32, 98);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(53, 19);
            this.postButton.TabIndex = 3;
            this.postButton.Text = "POST";
            this.postButton.UseVisualStyleBackColor = true;
            // 
            // moveButton
            // 
            this.moveButton.AutoSize = true;
            this.moveButton.Location = new System.Drawing.Point(32, 173);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(58, 19);
            this.moveButton.TabIndex = 6;
            this.moveButton.Text = "MOVE";
            this.moveButton.UseVisualStyleBackColor = true;
            // 
            // copyButton
            // 
            this.copyButton.AutoSize = true;
            this.copyButton.Location = new System.Drawing.Point(32, 148);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(56, 19);
            this.copyButton.TabIndex = 5;
            this.copyButton.Text = "COPY";
            this.copyButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 244);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.putButton);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.okButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.RadioButton getButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton deleteButton;
        private System.Windows.Forms.RadioButton postButton;
        private System.Windows.Forms.RadioButton moveButton;
        private System.Windows.Forms.RadioButton copyButton;
        private System.Windows.Forms.RadioButton putButton;
    }
}

