namespace Textmining
{
    partial class Form2
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
            this.pre = new System.Windows.Forms.TextBox();
            this.key = new System.Windows.Forms.TextBox();
            this.post = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pre
            // 
            this.pre.BackColor = System.Drawing.SystemColors.Info;
            this.pre.Location = new System.Drawing.Point(26, 48);
            this.pre.Multiline = true;
            this.pre.Name = "pre";
            this.pre.ReadOnly = true;
            this.pre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pre.Size = new System.Drawing.Size(119, 298);
            this.pre.TabIndex = 0;
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.SystemColors.Info;
            this.key.Location = new System.Drawing.Point(165, 48);
            this.key.Multiline = true;
            this.key.Name = "key";
            this.key.ReadOnly = true;
            this.key.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.key.Size = new System.Drawing.Size(115, 298);
            this.key.TabIndex = 1;
            // 
            // post
            // 
            this.post.BackColor = System.Drawing.SystemColors.Info;
            this.post.Location = new System.Drawing.Point(298, 48);
            this.post.Multiline = true;
            this.post.Name = "post";
            this.post.ReadOnly = true;
            this.post.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.post.Size = new System.Drawing.Size(114, 298);
            this.post.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Prefix";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Keyword";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(315, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Postfix";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(490, 417);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.post);
            this.Controls.Add(this.key);
            this.Controls.Add(this.pre);
            this.Name = "Form2";
            this.Text = "Semantics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pre;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.TextBox post;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}