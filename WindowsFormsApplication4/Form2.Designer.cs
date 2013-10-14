namespace WindowsFormsApplication4
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
            this.work = new System.Windows.Forms.TextBox();
            this.AddButt = new System.Windows.Forms.Button();
            this.fuck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // work
            // 
            this.work.Location = new System.Drawing.Point(13, 13);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(339, 20);
            this.work.TabIndex = 0;
            this.work.TextChanged += new System.EventHandler(this.work_TextChanged);
            // 
            // AddButt
            // 
            this.AddButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButt.Location = new System.Drawing.Point(12, 43);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(165, 23);
            this.AddButt.TabIndex = 1;
            this.AddButt.Text = "ADD";
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.Click += new System.EventHandler(this.AddButt_Click);
            // 
            // fuck
            // 
            this.fuck.Location = new System.Drawing.Point(183, 43);
            this.fuck.Name = "fuck";
            this.fuck.Size = new System.Drawing.Size(169, 23);
            this.fuck.TabIndex = 3;
            this.fuck.Text = "Cancel";
            this.fuck.UseVisualStyleBackColor = true;
            this.fuck.Click += new System.EventHandler(this.fuck_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 78);
            this.Controls.Add(this.fuck);
            this.Controls.Add(this.AddButt);
            this.Controls.Add(this.work);
            this.Name = "Form2";
            this.Text = "Add Work";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox work;
        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.Button fuck;

    }
}