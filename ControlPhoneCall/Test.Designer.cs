namespace ControlPhoneCall
{
	partial class Test
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.phoneCallDataSet13 = new ControlPhoneCall.PhoneCallDataSet13();
			this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cityTableAdapter = new ControlPhoneCall.PhoneCallDataSet13TableAdapters.CityTableAdapter();
			this.idCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rateDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rateNigthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet13)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCityDataGridViewTextBoxColumn,
            this.nameCityDataGridViewTextBoxColumn,
            this.rateDayDataGridViewTextBoxColumn,
            this.rateNigthDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.cityBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(50, 95);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(446, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// phoneCallDataSet13
			// 
			this.phoneCallDataSet13.DataSetName = "PhoneCallDataSet13";
			this.phoneCallDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cityBindingSource
			// 
			this.cityBindingSource.DataMember = "City";
			this.cityBindingSource.DataSource = this.phoneCallDataSet13;
			// 
			// cityTableAdapter
			// 
			this.cityTableAdapter.ClearBeforeFill = true;
			// 
			// idCityDataGridViewTextBoxColumn
			// 
			this.idCityDataGridViewTextBoxColumn.DataPropertyName = "IdCity";
			this.idCityDataGridViewTextBoxColumn.HeaderText = "IdCity";
			this.idCityDataGridViewTextBoxColumn.Name = "idCityDataGridViewTextBoxColumn";
			this.idCityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameCityDataGridViewTextBoxColumn
			// 
			this.nameCityDataGridViewTextBoxColumn.DataPropertyName = "NameCity";
			this.nameCityDataGridViewTextBoxColumn.HeaderText = "NameCity";
			this.nameCityDataGridViewTextBoxColumn.Name = "nameCityDataGridViewTextBoxColumn";
			// 
			// rateDayDataGridViewTextBoxColumn
			// 
			this.rateDayDataGridViewTextBoxColumn.DataPropertyName = "RateDay";
			this.rateDayDataGridViewTextBoxColumn.HeaderText = "RateDay";
			this.rateDayDataGridViewTextBoxColumn.Name = "rateDayDataGridViewTextBoxColumn";
			// 
			// rateNigthDataGridViewTextBoxColumn
			// 
			this.rateNigthDataGridViewTextBoxColumn.DataPropertyName = "RateNigth";
			this.rateNigthDataGridViewTextBoxColumn.HeaderText = "RateNigth";
			this.rateNigthDataGridViewTextBoxColumn.Name = "rateNigthDataGridViewTextBoxColumn";
			// 
			// Test
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Test";
			this.Text = "Test";
			this.Load += new System.EventHandler(this.Test_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet13)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private PhoneCallDataSet13 phoneCallDataSet13;
		private System.Windows.Forms.BindingSource cityBindingSource;
		private PhoneCallDataSet13TableAdapters.CityTableAdapter cityTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idCityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameCityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rateDayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rateNigthDataGridViewTextBoxColumn;
	}
}