namespace ControlPhoneCall
{
	partial class Subscribe
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
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idSubscriberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.subscribersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.phoneCallDataSet = new ControlPhoneCall.PhoneCallDataSet();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.textBoxRateDay = new System.Windows.Forms.TextBox();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.subscribersTableAdapter = new ControlPhoneCall.PhoneCallDataSetTableAdapters.SubscribersTableAdapter();
			this.phoneCallDataSet14 = new ControlPhoneCall.PhoneCallDataSet14();
			this.subscribersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.subscribersTableAdapter1 = new ControlPhoneCall.PhoneCallDataSet14TableAdapters.SubscribersTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet14)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(266, 34);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(479, 29);
			this.label4.TabIndex = 17;
			this.label4.Text = "Создание и редактирование Абонентов";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(604, 493);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 64);
			this.button1.TabIndex = 16;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSubscriberDataGridViewTextBoxColumn,
            this.numberPhoneDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.subscribersBindingSource1;
			this.dataGridView1.Location = new System.Drawing.Point(90, 298);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(449, 259);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGridView1_CellValidating);
			this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
			this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
			// 
			// idSubscriberDataGridViewTextBoxColumn
			// 
			this.idSubscriberDataGridViewTextBoxColumn.DataPropertyName = "IdSubscriber";
			this.idSubscriberDataGridViewTextBoxColumn.HeaderText = "IdSubscriber";
			this.idSubscriberDataGridViewTextBoxColumn.Name = "idSubscriberDataGridViewTextBoxColumn";
			this.idSubscriberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// numberPhoneDataGridViewTextBoxColumn
			// 
			this.numberPhoneDataGridViewTextBoxColumn.DataPropertyName = "NumberPhone";
			this.numberPhoneDataGridViewTextBoxColumn.HeaderText = "NumberPhone";
			this.numberPhoneDataGridViewTextBoxColumn.Name = "numberPhoneDataGridViewTextBoxColumn";
			// 
			// iNNDataGridViewTextBoxColumn
			// 
			this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
			this.iNNDataGridViewTextBoxColumn.HeaderText = "INN";
			this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			// 
			// subscribersBindingSource
			// 
			this.subscribersBindingSource.DataMember = "Subscribers";
			this.subscribersBindingSource.DataSource = this.phoneCallDataSet;
			// 
			// phoneCallDataSet
			// 
			this.phoneCallDataSet.DataSetName = "PhoneCallDataSet";
			this.phoneCallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(271, 224);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(100, 26);
			this.textBoxAddress.TabIndex = 14;
			// 
			// textBoxRateDay
			// 
			this.textBoxRateDay.Location = new System.Drawing.Point(271, 173);
			this.textBoxRateDay.Name = "textBoxRateDay";
			this.textBoxRateDay.Size = new System.Drawing.Size(100, 26);
			this.textBoxRateDay.TabIndex = 13;
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(271, 115);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(100, 26);
			this.textBoxCity.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(171, 230);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Адрес";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(192, 173);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "INN";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(86, 115);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Номер телефона";
			// 
			// subscribersTableAdapter
			// 
			this.subscribersTableAdapter.ClearBeforeFill = true;
			// 
			// phoneCallDataSet14
			// 
			this.phoneCallDataSet14.DataSetName = "PhoneCallDataSet14";
			this.phoneCallDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// subscribersBindingSource1
			// 
			this.subscribersBindingSource1.DataMember = "Subscribers";
			this.subscribersBindingSource1.DataSource = this.phoneCallDataSet14;
			// 
			// subscribersTableAdapter1
			// 
			this.subscribersTableAdapter1.ClearBeforeFill = true;
			// 
			// Subscribe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1002, 693);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.textBoxRateDay);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Subscribe";
			this.Text = "Subscribe";
			this.Load += new System.EventHandler(this.Subscribe_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet14)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.TextBox textBoxRateDay;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private PhoneCallDataSet phoneCallDataSet;
		private System.Windows.Forms.BindingSource subscribersBindingSource;
		private PhoneCallDataSetTableAdapters.SubscribersTableAdapter subscribersTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idSubscriberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberPhoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private PhoneCallDataSet14 phoneCallDataSet14;
		private System.Windows.Forms.BindingSource subscribersBindingSource1;
		private PhoneCallDataSet14TableAdapters.SubscribersTableAdapter subscribersTableAdapter1;
	}
}