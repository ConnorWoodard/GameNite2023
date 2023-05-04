namespace GameNite
{
    partial class Cart
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
            components = new System.ComponentModel.Container();
            inventoryBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            btnPurchase = new Button();
            inventoryIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            onHandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            UnitPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // inventoryBindingSource
            // 
            inventoryBindingSource.DataSource = typeof(Inventory);
            inventoryBindingSource.CurrentChanged += inventoryBindingSource_CurrentChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { inventoryIdDataGridViewTextBoxColumn, itemNameDataGridViewTextBoxColumn, itemTypeDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, onHandDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, UnitPrice });
            dataGridView1.DataSource = inventoryBindingSource;
            dataGridView1.Location = new Point(12, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(677, 348);
            dataGridView1.TabIndex = 0;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(575, 395);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(94, 29);
            btnPurchase.TabIndex = 1;
            btnPurchase.Text = "Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // inventoryIdDataGridViewTextBoxColumn
            // 
            inventoryIdDataGridViewTextBoxColumn.DataPropertyName = "InventoryId";
            inventoryIdDataGridViewTextBoxColumn.HeaderText = "InventoryId";
            inventoryIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            inventoryIdDataGridViewTextBoxColumn.Name = "inventoryIdDataGridViewTextBoxColumn";
            inventoryIdDataGridViewTextBoxColumn.Visible = false;
            inventoryIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemTypeDataGridViewTextBoxColumn
            // 
            itemTypeDataGridViewTextBoxColumn.DataPropertyName = "ItemType";
            itemTypeDataGridViewTextBoxColumn.HeaderText = "ItemType";
            itemTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            itemTypeDataGridViewTextBoxColumn.Name = "itemTypeDataGridViewTextBoxColumn";
            itemTypeDataGridViewTextBoxColumn.Visible = false;
            itemTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // onHandDataGridViewTextBoxColumn
            // 
            onHandDataGridViewTextBoxColumn.DataPropertyName = "OnHand";
            onHandDataGridViewTextBoxColumn.HeaderText = "OnHand";
            onHandDataGridViewTextBoxColumn.MinimumWidth = 6;
            onHandDataGridViewTextBoxColumn.Name = "onHandDataGridViewTextBoxColumn";
            onHandDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // UnitPrice
            // 
            UnitPrice.HeaderText = "UnitPrice";
            UnitPrice.MinimumWidth = 6;
            UnitPrice.Name = "UnitPrice";
            UnitPrice.Width = 125;
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPurchase);
            Controls.Add(dataGridView1);
            Name = "Cart";
            Text = "Cart";
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)inventoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource inventoryBindingSource;
        private DataGridView dataGridView1;
        private Button btnPurchase;
        private DataGridViewTextBoxColumn inventoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn onHandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn UnitPrice;
    }
}