namespace MqttClient
{
    partial class FeedForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTopic = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.panelFeed = new System.Windows.Forms.Panel();
            this.txtStream = new System.Windows.Forms.RichTextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.panelFeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Topic";
            // 
            // txtTopic
            // 
            this.txtTopic.Location = new System.Drawing.Point(92, 25);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(243, 27);
            this.txtTopic.TabIndex = 1;
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Location = new System.Drawing.Point(341, 24);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(100, 29);
            this.btnSubscribe.TabIndex = 2;
            this.btnSubscribe.Text = "Subscribe";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            // 
            // panelFeed
            // 
            this.panelFeed.Controls.Add(this.btnToggle);
            this.panelFeed.Controls.Add(this.btnPublish);
            this.panelFeed.Controls.Add(this.label2);
            this.panelFeed.Controls.Add(this.txtData);
            this.panelFeed.Controls.Add(this.txtStream);
            this.panelFeed.Location = new System.Drawing.Point(26, 75);
            this.panelFeed.Name = "panelFeed";
            this.panelFeed.Size = new System.Drawing.Size(571, 315);
            this.panelFeed.TabIndex = 3;
            // 
            // txtStream
            // 
            this.txtStream.BackColor = System.Drawing.Color.White;
            this.txtStream.Location = new System.Drawing.Point(19, 3);
            this.txtStream.Name = "txtStream";
            this.txtStream.ReadOnly = true;
            this.txtStream.Size = new System.Drawing.Size(417, 253);
            this.txtStream.TabIndex = 0;
            this.txtStream.Text = "";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(66, 274);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(255, 27);
            this.txtData.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data";
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(327, 273);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(93, 29);
            this.btnPublish.TabIndex = 3;
            this.btnPublish.Text = "Send";
            this.btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(472, 112);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(75, 33);
            this.btnToggle.TabIndex = 4;
            this.btnToggle.Text = "Toggle";
            this.btnToggle.UseVisualStyleBackColor = true;
            // 
            // FeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(620, 412);
            this.Controls.Add(this.panelFeed);
            this.Controls.Add(this.btnSubscribe);
            this.Controls.Add(this.txtTopic);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FeedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Feed";
            this.panelFeed.ResumeLayout(false);
            this.panelFeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTopic;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Panel panelFeed;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.RichTextBox txtStream;
        private System.Windows.Forms.Button btnToggle;
    }
}