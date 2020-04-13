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
			this.subscribersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.phoneCallDataSet15 = new ControlPhoneCall.PhoneCallDataSet15();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.errorNumber = new System.Windows.Forms.Label();
			this.errorINN = new System.Windows.Forms.Label();
			this.errorAddress = new System.Windows.Forms.Label();
			this.textBoxNumber = new System.Windows.Forms.MaskedTextBox();
			this.textBoxInn = new System.Windows.Forms.MaskedTextBox();
			this.subscribersTableAdapter2 = new ControlPhoneCall.PhoneCallDataSet15TableAdapters.SubscribersTableAdapter();
			this.idSubscriber = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet15)).BeginInit();
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
			this.button1.Location = new System.Drawing.Point(668, 580);
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
			this.dataGridView1.DataSource = this.subscribersBindingSource2;
			this.dataGridView1.Location = new System.Drawing.Point(107, 385);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(449, 259);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
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
			// subscribersBindingSource2
			// 
			this.subscribersBindingSource2.DataMember = "Subscribers";
			this.subscribersBindingSource2.DataSource = this.phoneCallDataSet15;
			// 
			// phoneCallDataSet15
			// 
			this.phoneCallDataSet15.DataSetName = "PhoneCallDataSet15";
			this.phoneCallDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(252, 227);
			this.textBoxAddress.Multiline = true;
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(304, 134);
			this.textBoxAddress.TabIndex = 14;
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
			// errorNumber
			// 
			this.errorNumber.AutoSize = true;
			this.errorNumber.ForeColor = System.Drawing.Color.Red;
			this.errorNumber.Location = new System.Drawing.Point(414, 115);
			this.errorNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorNumber.Name = "errorNumber";
			this.errorNumber.Size = new System.Drawing.Size(142, 20);
			this.errorNumber.TabIndex = 18;
			this.errorNumber.Text = "Номер телефона";
			this.errorNumber.Visible = false;
			// 
			// errorINN
			// 
			this.errorINN.AutoSize = true;
			this.errorINN.ForeColor = System.Drawing.Color.Coral;
			this.errorINN.Location = new System.Drawing.Point(414, 173);
			this.errorINN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorINN.Name = "errorINN";
			this.errorINN.Size = new System.Drawing.Size(36, 20);
			this.errorINN.TabIndex = 19;
			this.errorINN.Text = "INN";
			this.errorINN.Visible = false;
			// 
			// errorAddress
			// 
			this.errorAddress.AutoSize = true;
			this.errorAddress.ForeColor = System.Drawing.Color.Coral;
			this.errorAddress.Location = new System.Drawing.Point(580, 227);
			this.errorAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorAddress.Name = "errorAddress";
			this.errorAddress.Size = new System.Drawing.Size(57, 20);
			this.errorAddress.TabIndex = 20;
			this.errorAddress.Text = "Адрес";
			this.errorAddress.Visible = false;
			// 
			// textBoxNumber
			// 
			this.textBoxNumber.Location = new System.Drawing.Point(252, 115);
			this.textBoxNumber.Mask = "+7(999) 000-00-00";
			this.textBoxNumber.Name = "textBoxNumber";
			this.textBoxNumber.Size = new System.Drawing.Size(143, 26);
			this.textBoxNumber.TabIndex = 21;
			// 
			// textBoxInn
			// 
			this.textBoxInn.Location = new System.Drawing.Point(252, 170);
			this.textBoxInn.Mask = "000-000-000-000";
			this.textBoxInn.Name = "textBoxInn";
			this.textBoxInn.Size = new System.Drawing.Size(143, 26);
			this.textBoxInn.TabIndex = 23;
			// 
			// subscribersTableAdapter2
			// 
			this.subscribersTableAdapter2.ClearBeforeFill = true;
			// 
			// idSubscriber
			// 
			this.idSubscriber.AutoSize = true;
			this.idSubscriber.Location = new System.Drawing.Point(786, 115);
			this.idSubscriber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.idSubscriber.Name = "idSubscriber";
			this.idSubscriber.Size = new System.Drawing.Size(36, 20);
			this.idSubscriber.TabIndex = 24;
			this.idSubscriber.Text = "INN";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(668, 385);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(127, 64);
			this.button2.TabIndex = 25;
			this.button2.Text = "Удалить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Subscribe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1002, 693);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.idSubscriber);
			this.Controls.Add(this.textBoxInn);
			this.Controls.Add(this.textBoxNumber);
			this.Controls.Add(this.errorAddress);
			this.Controls.Add(this.errorINN);
			this.Controls.Add(this.errorNumber);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Subscribe";
			this.Text = "Subscribe";
			this.Load += new System.EventHandler(this.Subscribe_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet15)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label errorNumber;
		private System.Windows.Forms.Label errorINN;
		private System.Windows.Forms.Label errorAddress;
		private System.Windows.Forms.MaskedTextBox textBoxNumber;
		private System.Windows.Forms.MaskedTextBox textBoxInn;
		private PhoneCallDataSet15 phoneCallDataSet15;
		private System.Windows.Forms.BindingSource subscribersBindingSource2;
		private PhoneCallDataSet15TableAdapters.SubscribersTableAdapter subscribersTableAdapter2;
		private System.Windows.Forms.Label idSubscriber;
		private System.Windows.Forms.DataGridViewTextBoxColumn idSubscriberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberPhoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button2;
	}
}