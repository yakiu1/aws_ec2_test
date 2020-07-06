namespace AWS_EC2_Test
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lisResult = new System.Windows.Forms.ListBox();
            this.btnStopInstance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(102, 380);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(248, 29);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "點我啟動EC2 Instance";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(102, 33);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(99, 19);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "結果顯示於此";
            // 
            // lisResult
            // 
            this.lisResult.FormattingEnabled = true;
            this.lisResult.ItemHeight = 19;
            this.lisResult.Location = new System.Drawing.Point(102, 55);
            this.lisResult.Name = "lisResult";
            this.lisResult.Size = new System.Drawing.Size(582, 270);
            this.lisResult.TabIndex = 3;
            // 
            // btnStopInstance
            // 
            this.btnStopInstance.Location = new System.Drawing.Point(436, 380);
            this.btnStopInstance.Name = "btnStopInstance";
            this.btnStopInstance.Size = new System.Drawing.Size(248, 29);
            this.btnStopInstance.TabIndex = 0;
            this.btnStopInstance.Text = "點我停止EC2 Instance";
            this.btnStopInstance.UseVisualStyleBackColor = true;
            this.btnStopInstance.Click += new System.EventHandler(this.btnStopInstance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStopInstance);
            this.Controls.Add(this.lisResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSubmit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ListBox lisResult;
        private System.Windows.Forms.Button btnStopInstance;
    }
}

