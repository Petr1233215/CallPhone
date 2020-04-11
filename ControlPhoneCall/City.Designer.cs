namespace ControlPhoneCall
{
	partial class City
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.textBoxRateDay = new System.Windows.Forms.TextBox();
			this.textBoxRateNight = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.phoneCallDataSet = new ControlPhoneCall.PhoneCallDataSet();
			this.phoneCallDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.phoneCallDataSet1 = new ControlPhoneCall.PhoneCallDataSet1();
			this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cityTableAdapter = new ControlPhoneCall.PhoneCallDataSet1TableAdapters.CityTableAdapter();
			this.idCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rateDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rateNigthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(95, 104);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(95, 158);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Тариф Дневной";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(95, 218);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Тариф Ночной";
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(280, 104);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(100, 26);
			this.textBoxCity.TabIndex = 3;
			// 
			// textBoxRateDay
			// 
			this.textBoxRateDay.Location = new System.Drawing.Point(280, 156);
			this.textBoxRateDay.Name = "textBoxRateDay";
			this.textBoxRateDay.Size = new System.Drawing.Size(100, 26);
			this.textBoxRateDay.TabIndex = 4;
			// 
			// textBoxRateNight
			// 
			this.textBoxRateNight.Location = new System.Drawing.Point(280, 213);
			this.textBoxRateNight.Name = "textBoxRateNight";
			this.textBoxRateNight.Size = new System.Drawing.Size(100, 26);
			this.textBoxRateNight.TabIndex = 5;
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
			this.dataGridView1.Location = new System.Drawing.Point(99, 287);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(443, 259);
			this.dataGridView1.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(580, 482);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 64);
			this.button1.TabIndex = 7;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(275, 23);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(450, 29);
			this.label4.TabIndex = 8;
			this.label4.Text = "Создание и редактирование Городов";
			// 
			// phoneCallDataSet
			// 
			this.phoneCallDataSet.DataSetName = "PhoneCallDataSet";
			this.phoneCallDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// phoneCallDataSetBindingSource
			// 
			this.phoneCallDataSetBindingSource.DataSource = this.phoneCallDataSet;
			this.phoneCallDataSetBindingSource.Position = 0;
			// 
			// phoneCallDataSet1
			// 
			this.phoneCallDataSet1.DataSetName = "PhoneCallDataSet1";
			this.phoneCallDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cityBindingSource
			// 
			this.cityBindingSource.DataMember = "City";
			this.cityBindingSource.DataSource = this.phoneCallDataSet1;
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
			// City
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(968, 598);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBoxRateNight);
			this.Controls.Add(this.textBoxRateDay);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "City";
			this.Text = "City";
			this.Load += new System.EventHandler(this.City_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.TextBox textBoxRateDay;
		private System.Windows.Forms.TextBox textBoxRateNight;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.BindingSource phoneCallDataSetBindingSource;
		private PhoneCallDataSet phoneCallDataSet;
		private PhoneCallDataSet1 phoneCallDataSet1;
		private System.Windows.Forms.BindingSource cityBindingSource;
		private PhoneCallDataSet1TableAdapters.CityTableAdapter cityTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idCityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameCityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rateDayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rateNigthDataGridViewTextBoxColumn;
	}
}