namespace DataBaseProject
{
    partial class FQ12
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
            this.gardenPerfect = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQ2 = new System.Windows.Forms.Button();
            this.btnQ1 = new System.Windows.Forms.Button();
            this.btnQ1B = new System.Windows.Forms.Button();
            this.btnQ1A = new System.Windows.Forms.Button();
            this.dgQA = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgQB = new System.Windows.Forms.DataGridView();
            this.btnEnd = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.btnQAB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQA)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQB)).BeginInit();
            this.SuspendLayout();
            // 
            // gardenPerfect
            // 
            this.gardenPerfect.AutoSize = true;
            this.gardenPerfect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gardenPerfect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gardenPerfect.Location = new System.Drawing.Point(371, 29);
            this.gardenPerfect.Name = "gardenPerfect";
            this.gardenPerfect.Size = new System.Drawing.Size(242, 29);
            this.gardenPerfect.TabIndex = 2;
            this.gardenPerfect.Text = "הרצת חלקים שאילתות";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQ2);
            this.groupBox1.Controls.Add(this.btnQ1);
            this.groupBox1.Location = new System.Drawing.Point(541, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 109);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "בחר שאילתה";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnQ2
            // 
            this.btnQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ2.Location = new System.Drawing.Point(41, 37);
            this.btnQ2.Name = "btnQ2";
            this.btnQ2.Size = new System.Drawing.Size(110, 54);
            this.btnQ2.TabIndex = 4;
            this.btnQ2.Text = "שאילתה 2";
            this.btnQ2.UseVisualStyleBackColor = true;
            this.btnQ2.Click += new System.EventHandler(this.btnQ2_Click);
            // 
            // btnQ1
            // 
            this.btnQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1.Location = new System.Drawing.Point(179, 37);
            this.btnQ1.Name = "btnQ1";
            this.btnQ1.Size = new System.Drawing.Size(108, 54);
            this.btnQ1.TabIndex = 3;
            this.btnQ1.Text = "שאילתה 1 ";
            this.btnQ1.UseVisualStyleBackColor = true;
            this.btnQ1.Click += new System.EventHandler(this.btnQ1_Click);
            // 
            // btnQ1B
            // 
            this.btnQ1B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1B.Location = new System.Drawing.Point(25, 37);
            this.btnQ1B.Name = "btnQ1B";
            this.btnQ1B.Size = new System.Drawing.Size(108, 54);
            this.btnQ1B.TabIndex = 21;
            this.btnQ1B.Text = "חלק ב";
            this.btnQ1B.UseVisualStyleBackColor = true;
            // 
            // btnQ1A
            // 
            this.btnQ1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQ1A.Location = new System.Drawing.Point(167, 37);
            this.btnQ1A.Name = "btnQ1A";
            this.btnQ1A.Size = new System.Drawing.Size(108, 54);
            this.btnQ1A.TabIndex = 20;
            this.btnQ1A.Text = "חלק א";
            this.btnQ1A.UseVisualStyleBackColor = true;
            this.btnQ1A.Click += new System.EventHandler(this.btnQ1A_Click);
            // 
            // dgQA
            // 
            this.dgQA.AllowUserToAddRows = false;
            this.dgQA.AllowUserToDeleteRows = false;
            this.dgQA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgQA.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgQA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgQA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQA.Location = new System.Drawing.Point(558, 254);
            this.dgQA.MultiSelect = false;
            this.dgQA.Name = "dgQA";
            this.dgQA.ReadOnly = true;
            this.dgQA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgQA.Size = new System.Drawing.Size(370, 230);
            this.dgQA.TabIndex = 21;
            this.dgQA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgQA_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQ1A);
            this.groupBox2.Controls.Add(this.btnQ1B);
            this.groupBox2.Location = new System.Drawing.Point(95, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 109);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "בחר חלק ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgQB
            // 
            this.dgQB.AllowUserToAddRows = false;
            this.dgQB.AllowUserToDeleteRows = false;
            this.dgQB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgQB.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgQB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgQB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQB.Location = new System.Drawing.Point(21, 254);
            this.dgQB.MultiSelect = false;
            this.dgQB.Name = "dgQB";
            this.dgQB.ReadOnly = true;
            this.dgQB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgQB.Size = new System.Drawing.Size(397, 230);
            this.dgQB.TabIndex = 23;
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(424, 439);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(128, 45);
            this.btnEnd.TabIndex = 24;
            this.btnEnd.Text = "סיים  ";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(855, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(91, 45);
            this.back.TabIndex = 25;
            this.back.Text = "חזרה לתפריט";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // btnQAB
            // 
            this.btnQAB.Location = new System.Drawing.Point(424, 200);
            this.btnQAB.Name = "btnQAB";
            this.btnQAB.Size = new System.Drawing.Size(128, 65);
            this.btnQAB.TabIndex = 26;
            this.btnQAB.Text = "הרצת חלקים משאילתה";
            this.btnQAB.UseVisualStyleBackColor = true;
            // 
            // FQAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 516);
            this.Controls.Add(this.btnQAB);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.dgQB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgQA);
            this.Controls.Add(this.gardenPerfect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FQAB";
            this.Text = "הרצת חלקים משיאלתה";
            this.Load += new System.EventHandler(this.FQAB_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgQA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgQB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gardenPerfect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQ1B;
        private System.Windows.Forms.Button btnQ1A;
        private System.Windows.Forms.Button btnQ2;
        private System.Windows.Forms.Button btnQ1;
        private System.Windows.Forms.DataGridView dgQA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgQB;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button btnQAB;
    }
}