namespace DataBaseProject
{
    partial class ALLClient
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
            this.components = new System.ComponentModel.Container();
            this.dgClients = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfMem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DataBaseProject.DataSet1();
            this.labAllclients = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.dgMem = new System.Windows.Forms.DataGridView();
            this.tblActualMembershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new DataBaseProject.DataSet2();
            this.tblCustomerTableAdapter = new DataBaseProject.DataSet1TableAdapters.tblCustomerTableAdapter();
            this.tblActualMembershipTableAdapter = new DataBaseProject.DataSet2TableAdapters.tblActualMembershipTableAdapter();
            this.aLLClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aLLClientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActualMembershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLClientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClients
            // 
            this.dgClients.AllowUserToAddRows = false;
            this.dgClients.AllowUserToOrderColumns = true;
            this.dgClients.AutoGenerateColumns = false;
            this.dgClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClients.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNumDataGridViewTextBoxColumn,
            this.cellPhoneDataGridViewTextBoxColumn,
            this.NumOfMem});
            this.dgClients.DataSource = this.tblCustomerBindingSource;
            this.dgClients.Location = new System.Drawing.Point(83, 62);
            this.dgClients.MultiSelect = false;
            this.dgClients.Name = "dgClients";
            this.dgClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClients.Size = new System.Drawing.Size(601, 179);
            this.dgClients.TabIndex = 1;
            this.dgClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClients_CellContentClick);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            this.surNameDataGridViewTextBoxColumn.HeaderText = "SurName";
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneNumDataGridViewTextBoxColumn
            // 
            this.phoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.HeaderText = "PhoneNum";
            this.phoneNumDataGridViewTextBoxColumn.Name = "phoneNumDataGridViewTextBoxColumn";
            // 
            // cellPhoneDataGridViewTextBoxColumn
            // 
            this.cellPhoneDataGridViewTextBoxColumn.DataPropertyName = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.HeaderText = "CellPhone";
            this.cellPhoneDataGridViewTextBoxColumn.Name = "cellPhoneDataGridViewTextBoxColumn";
            // 
            // NumOfMem
            // 
            this.NumOfMem.HeaderText = "NumOfMem";
            this.NumOfMem.Name = "NumOfMem";
            this.NumOfMem.Text = "ViewMemership";
            this.NumOfMem.UseColumnTextForButtonValue = true;
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labAllclients
            // 
            this.labAllclients.AutoSize = true;
            this.labAllclients.BackColor = System.Drawing.SystemColors.Control;
            this.labAllclients.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAllclients.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labAllclients.Location = new System.Drawing.Point(264, 16);
            this.labAllclients.Name = "labAllclients";
            this.labAllclients.Size = new System.Drawing.Size(202, 29);
            this.labAllclients.TabIndex = 2;
            this.labAllclients.Text = "הצגת כל הלקוחות ";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(742, 16);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(112, 45);
            this.back.TabIndex = 7;
            this.back.Text = "חזרה לתפריט";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dgMem
            // 
            this.dgMem.AllowUserToAddRows = false;
            this.dgMem.AllowUserToOrderColumns = true;
            this.dgMem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMem.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgMem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMem.Location = new System.Drawing.Point(83, 247);
            this.dgMem.MultiSelect = false;
            this.dgMem.Name = "dgMem";
            this.dgMem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMem.Size = new System.Drawing.Size(579, 150);
            this.dgMem.TabIndex = 8;
            this.dgMem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMem_CellContentClick);
            // 
            // tblActualMembershipBindingSource
            // 
            this.tblActualMembershipBindingSource.DataMember = "tblActualMembership";
            this.tblActualMembershipBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustomerTableAdapter
            // 
            this.tblCustomerTableAdapter.ClearBeforeFill = true;
            // 
            // tblActualMembershipTableAdapter
            // 
            this.tblActualMembershipTableAdapter.ClearBeforeFill = true;
            // 
            // aLLClientBindingSource
            // 
            this.aLLClientBindingSource.DataSource = typeof(DataBaseProject.ALLClient);
            // 
            // aLLClientBindingSource1
            // 
            this.aLLClientBindingSource1.DataSource = typeof(DataBaseProject.ALLClient);
            // 
            // ALLClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 456);
            this.Controls.Add(this.dgMem);
            this.Controls.Add(this.back);
            this.Controls.Add(this.labAllclients);
            this.Controls.Add(this.dgClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ALLClient";
            this.Text = "ALL Clients";
            this.Load += new System.EventHandler(this.ALLClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblActualMembershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLLClientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClients;
        private System.Windows.Forms.Label labAllclients;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dgMem;
        private System.Windows.Forms.BindingSource aLLClientBindingSource;
        private System.Windows.Forms.BindingSource aLLClientBindingSource1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private DataSet1TableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn NumOfMem;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource tblActualMembershipBindingSource;
        private DataSet2TableAdapters.tblActualMembershipTableAdapter tblActualMembershipTableAdapter;
    }
}