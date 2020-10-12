namespace InClassAssignment4
{
    partial class InClassAssignment4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InClassAssignment4));
            this.label1 = new System.Windows.Forms.Label();
            this.txtElaspedSeconds = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.bttnFindOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Location = new System.Drawing.Point(207, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of seconds elapsed:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtElaspedSeconds
            // 
            this.txtElaspedSeconds.Location = new System.Drawing.Point(272, 134);
            this.txtElaspedSeconds.Name = "txtElaspedSeconds";
            this.txtElaspedSeconds.Size = new System.Drawing.Size(228, 20);
            this.txtElaspedSeconds.TabIndex = 1;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblOutput.Location = new System.Drawing.Point(394, 261);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 23);
            this.lblOutput.TabIndex = 2;
            // 
            // bttnFindOut
            // 
            this.bttnFindOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bttnFindOut.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnFindOut.ForeColor = System.Drawing.Color.DimGray;
            this.bttnFindOut.Location = new System.Drawing.Point(309, 191);
            this.bttnFindOut.Name = "bttnFindOut";
            this.bttnFindOut.Size = new System.Drawing.Size(157, 52);
            this.bttnFindOut.TabIndex = 3;
            this.bttnFindOut.Text = "Find Out";
            this.bttnFindOut.UseVisualStyleBackColor = false;
            this.bttnFindOut.Click += new System.EventHandler(this.bttnFindOut_Click);
            // 
            // InClassAssignment4
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnFindOut);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtElaspedSeconds);
            this.Controls.Add(this.label1);
            this.Name = "InClassAssignment4";
            this.Text = "TimeConversion";
            this.Load += new System.EventHandler(this.InClassAssignment4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtElaspedSeconds;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button bttnFindOut;
    }
}

