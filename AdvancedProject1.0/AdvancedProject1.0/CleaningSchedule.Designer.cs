﻿namespace AdvancedProject1._0
{
    partial class CleaningSchedule
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
            this.btnBack = new System.Windows.Forms.Button();
            this.label42 = new System.Windows.Forms.Label();
            this.CalendarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.pbEventImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(61, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label42.Location = new System.Drawing.Point(520, 13);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(197, 51);
            this.label42.TabIndex = 3;
            this.label42.Text = "Calendar";
            // 
            // CalendarPanel
            // 
            this.CalendarPanel.AutoScroll = true;
            this.CalendarPanel.Location = new System.Drawing.Point(17, 70);
            this.CalendarPanel.Name = "CalendarPanel";
            this.CalendarPanel.Size = new System.Drawing.Size(1042, 576);
            this.CalendarPanel.TabIndex = 4;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(1092, 224);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(258, 240);
            this.rtbDescription.TabIndex = 5;
            this.rtbDescription.Text = "";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(1120, 488);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(201, 40);
            this.btnAddEvent.TabIndex = 6;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // pbEventImage
            // 
            this.pbEventImage.Location = new System.Drawing.Point(1139, 70);
            this.pbEventImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbEventImage.Name = "pbEventImage";
            this.pbEventImage.Size = new System.Drawing.Size(155, 119);
            this.pbEventImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEventImage.TabIndex = 8;
            this.pbEventImage.TabStop = false;
            // 
            // CleaningSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 658);
            this.Controls.Add(this.pbEventImage);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.CalendarPanel);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CleaningSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CleaningSchedule";
            ((System.ComponentModel.ISupportInitialize)(this.pbEventImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.FlowLayoutPanel CalendarPanel;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.PictureBox pbEventImage;
    }
}