namespace DataBaseProject
{
    partial class SearchClient
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
            this.labSearchClient = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labclientCV = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.btnWW = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgsearch = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // labSearchClient
            // 
            this.labSearchClient.AutoSize = true;
            this.labSearchClient.BackColor = System.Drawing.SystemColors.Control;
            this.labSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSearchClient.Location = new System.Drawing.Point(213, 12);
            this.labSearchClient.Name = "labSearchClient";
            this.labSearchClient.Size = new System.Drawing.Size(131, 29);
            this.labSearchClient.TabIndex = 0;
            this.labSearchClient.Text = "חיפוש לקוח";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(49, 55);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(229, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClient.Location = new System.Drawing.Point(284, 37);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(75, 38);
            this.btnSearchClient.TabIndex = 2;
            this.btnSearchClient.Text = "חפש";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            this.btnSearchClient.Click += new System.EventHandler(this.btnSearchClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 3;
            this.label1.Tag = "";
            this.label1.Text = "ID :";
            // 
            // labclientCV
            // 
            this.labclientCV.AutoSize = true;
            this.labclientCV.BackColor = System.Drawing.SystemColors.Control;
            this.labclientCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labclientCV.Location = new System.Drawing.Point(286, 212);
            this.labclientCV.Name = "labclientCV";
            this.labclientCV.Size = new System.Drawing.Size(133, 29);
            this.labclientCV.TabIndex = 5;
            this.labclientCV.Text = "פרטי הלקוח";
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(514, 365);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 39);
            this.btnEnd.TabIndex = 6;
            this.btnEnd.Text = "סיום";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(481, 28);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(91, 45);
            this.back.TabIndex = 8;
            this.back.Text = "חזרה לתפריט";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // btnWW
            // 
            this.btnWW.BackgroundImage = global::DataBaseProject.Properties.Resources.Kawsone_Teneo_Whats_On;
            this.btnWW.Location = new System.Drawing.Point(250, 81);
            this.btnWW.Name = "btnWW";
            this.btnWW.Size = new System.Drawing.Size(28, 26);
            this.btnWW.TabIndex = 9;
            this.btnWW.UseVisualStyleBackColor = true;
            this.btnWW.Click += new System.EventHandler(this.btnWW_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchClient);
            this.groupBox1.Controls.Add(this.btnWW);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(60, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 115);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "הכנסת תעודת זהות";
            // 
            // dgsearch
            // 
            this.dgsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsearch.Location = new System.Drawing.Point(25, 262);
            this.dgsearch.Name = "dgsearch";
            this.dgsearch.Size = new System.Drawing.Size(454, 163);
            this.dgsearch.TabIndex = 11;
            this.dgsearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 437);
            this.Controls.Add(this.dgsearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.labclientCV);
            this.Controls.Add(this.labSearchClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchClient";
            this.Load += new System.EventHandler(this.SearchClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labSearchClient;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSearchClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labclientCV;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btnWW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgsearch;
    }
}