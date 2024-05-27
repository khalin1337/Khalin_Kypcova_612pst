namespace Khalin_Kypcova_612pst.Forms
{
    partial class Orders
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
            this.DataGrid_orders = new System.Windows.Forms.DataGridView();
            this.Datetime_orders = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdersTime_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid_orders
            // 
            this.DataGrid_orders.AllowUserToAddRows = false;
            this.DataGrid_orders.AllowUserToDeleteRows = false;
            this.DataGrid_orders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_orders.Location = new System.Drawing.Point(12, 61);
            this.DataGrid_orders.Name = "DataGrid_orders";
            this.DataGrid_orders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid_orders.Size = new System.Drawing.Size(760, 388);
            this.DataGrid_orders.TabIndex = 0;
            this.DataGrid_orders.TabStop = false;
            // 
            // Datetime_orders
            // 
            this.Datetime_orders.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Datetime_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Datetime_orders.Location = new System.Drawing.Point(423, 15);
            this.Datetime_orders.Name = "Datetime_orders";
            this.Datetime_orders.Size = new System.Drawing.Size(349, 30);
            this.Datetime_orders.TabIndex = 1;
            this.Datetime_orders.TabStop = false;
            this.Datetime_orders.ValueChanged += new System.EventHandler(this.Datetime_orders_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(287, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Обрати дату";
            // 
            // OrdersTime_button
            // 
            this.OrdersTime_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersTime_button.Location = new System.Drawing.Point(12, 15);
            this.OrdersTime_button.Name = "OrdersTime_button";
            this.OrdersTime_button.Size = new System.Drawing.Size(153, 30);
            this.OrdersTime_button.TabIndex = 3;
            this.OrdersTime_button.TabStop = false;
            this.OrdersTime_button.Text = "Поточні";
            this.OrdersTime_button.UseVisualStyleBackColor = true;
            this.OrdersTime_button.Click += new System.EventHandler(this.OrdersTime_button_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.OrdersTime_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Datetime_orders);
            this.Controls.Add(this.DataGrid_orders);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_orders;
        private System.Windows.Forms.DateTimePicker Datetime_orders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OrdersTime_button;
    }
}