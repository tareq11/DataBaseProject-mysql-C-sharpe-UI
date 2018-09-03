namespace DataBaseProject
{
    partial class EazyShape
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
            this.EazyShape1 = new System.Windows.Forms.Label();
            this.ALLClients = new System.Windows.Forms.Button();
            this.SearchClient = new System.Windows.Forms.Button();
            this.btnQ1Q2 = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EazyShape1
            // 
            this.EazyShape1.AutoSize = true;
            this.EazyShape1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.EazyShape1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EazyShape1.Location = new System.Drawing.Point(365, 34);
            this.EazyShape1.Name = "EazyShape1";
            this.EazyShape1.Size = new System.Drawing.Size(216, 29);
            this.EazyShape1.TabIndex = 0;
            this.EazyShape1.Text = "מועדון ספורט וכושר";
            this.EazyShape1.Click += new System.EventHandler(this.gardenPerfect_Click);
            // 
            // ALLClients
            // 
            this.ALLClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALLClients.Location = new System.Drawing.Point(210, 100);
            this.ALLClients.Name = "ALLClients";
            this.ALLClients.Size = new System.Drawing.Size(248, 56);
            this.ALLClients.TabIndex = 1;
            this.ALLClients.Text = "הצגת כל הלקוחות";
            this.ALLClients.UseVisualStyleBackColor = true;
            this.ALLClients.Click += new System.EventHandler(this.ALLClients_Click);
            // 
            // SearchClient
            // 
            this.SearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchClient.Location = new System.Drawing.Point(232, 172);
            this.SearchClient.Name = "SearchClient";
            this.SearchClient.Size = new System.Drawing.Size(202, 56);
            this.SearchClient.TabIndex = 2;
            this.SearchClient.Text = "חיפוש לקוח";
            this.SearchClient.UseVisualStyleBackColor = true;
            this.SearchClient.Click += new System.EventHandler(this.SearchClient_Click);
            // 
            // btnQ1Q2
            // 
            this.btnQ1Q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1Q2.Location = new System.Drawing.Point(219, 247);
            this.btnQ1Q2.Name = "btnQ1Q2";
            this.btnQ1Q2.Size = new System.Drawing.Size(226, 56);
            this.btnQ1Q2.TabIndex = 3;
            this.btnQ1Q2.Text = "הרצת שאילתות";
            this.btnQ1Q2.UseVisualStyleBackColor = true;
            this.btnQ1Q2.Click += new System.EventHandler(this.btnQ1Q2_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(12, 12);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(77, 51);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "יציאה";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // EazyShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 333);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnQ1Q2);
            this.Controls.Add(this.SearchClient);
            this.Controls.Add(this.ALLClients);
            this.Controls.Add(this.EazyShape1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "EazyShape";
            this.Text = "מועדון ספורט וכושר";
            this.Load += new System.EventHandler(this.PerfectGarden_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EazyShape1;
        private System.Windows.Forms.Button ALLClients;
        private System.Windows.Forms.Button SearchClient;
        private System.Windows.Forms.Button btnQ1Q2;
        private System.Windows.Forms.Button btnEnd;
    }
}

