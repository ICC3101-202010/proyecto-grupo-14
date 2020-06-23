namespace Proyecto_grupo_14form
{
    partial class YouTube
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YouTube));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Youtube_YoutubeButton = new System.Windows.Forms.Button();
            this.YouTube_TextBox = new System.Windows.Forms.TextBox();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.Youtube_YoutubeButton);
            this.panel1.Controls.Add(this.YouTube_TextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 75);
            this.panel1.TabIndex = 0;
            // 
            // Youtube_YoutubeButton
            // 
            this.Youtube_YoutubeButton.Location = new System.Drawing.Point(565, 27);
            this.Youtube_YoutubeButton.Name = "Youtube_YoutubeButton";
            this.Youtube_YoutubeButton.Size = new System.Drawing.Size(75, 20);
            this.Youtube_YoutubeButton.TabIndex = 1;
            this.Youtube_YoutubeButton.Text = "button1";
            this.Youtube_YoutubeButton.UseVisualStyleBackColor = true;
            this.Youtube_YoutubeButton.Click += new System.EventHandler(this.Youtube_YoutubeButton_Click);
            // 
            // YouTube_TextBox
            // 
            this.YouTube_TextBox.Location = new System.Drawing.Point(12, 27);
            this.YouTube_TextBox.Name = "YouTube_TextBox";
            this.YouTube_TextBox.Size = new System.Drawing.Size(527, 20);
            this.YouTube_TextBox.TabIndex = 0;
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(0, 75);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(668, 328);
            this.axShockwaveFlash1.TabIndex = 1;
            this.axShockwaveFlash1.Enter += new System.EventHandler(this.axShockwaveFlash1_Enter_1);
            // 
            // YouTube
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(668, 403);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Controls.Add(this.panel1);
            this.Name = "YouTube";
            this.Text = "YouTube";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Youtube_YoutubeButton;
        private System.Windows.Forms.TextBox YouTube_TextBox;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
    }
}