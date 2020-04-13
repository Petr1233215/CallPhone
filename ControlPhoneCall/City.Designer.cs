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
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.labelIDCity = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.errorCity = new System.Windows.Forms.Label();
			this.errorRDay = new System.Windows.Forms.Label();
			this.errorRNight = new System.Windows.Forms.Label();
			this.errorDiscount = new System.Windows.Forms.Label();
			this.labelDiscount = new System.Windows.Forms.Label();
			this.numericDiscount = new System.Windows.Forms.NumericUpDown();
			this.numericRateDay = new System.Windows.Forms.NumericUpDown();
			this.numericRateNight = new System.Windows.Forms.NumericUpDown();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.phoneCallDataSet19 = new ControlPhoneCall.PhoneCallDataSet19();
			this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cityTableAdapter = new ControlPhoneCall.PhoneCallDataSet19TableAdapters.CityTableAdapter();
			this.idCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rateDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rateNigthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRateDay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRateNight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet19)).BeginInit();
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
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(768, 558);
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
			// labelIDCity
			// 
			this.labelIDCity.AutoSize = true;
			this.labelIDCity.Location = new System.Drawing.Point(764, 107);
			this.labelIDCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelIDCity.Name = "labelIDCity";
			this.labelIDCity.Size = new System.Drawing.Size(83, 20);
			this.labelIDCity.TabIndex = 9;
			this.labelIDCity.Text = "Название";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(768, 376);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(127, 64);
			this.button2.TabIndex = 12;
			this.button2.Text = "Удалить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// errorCity
			// 
			this.errorCity.AutoSize = true;
			this.errorCity.ForeColor = System.Drawing.Color.Coral;
			this.errorCity.Location = new System.Drawing.Point(434, 110);
			this.errorCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorCity.Name = "errorCity";
			this.errorCity.Size = new System.Drawing.Size(83, 20);
			this.errorCity.TabIndex = 13;
			this.errorCity.Text = "Название";
			this.errorCity.Visible = false;
			// 
			// errorRDay
			// 
			this.errorRDay.AutoSize = true;
			this.errorRDay.ForeColor = System.Drawing.Color.Coral;
			this.errorRDay.Location = new System.Drawing.Point(434, 161);
			this.errorRDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorRDay.Name = "errorRDay";
			this.errorRDay.Size = new System.Drawing.Size(130, 20);
			this.errorRDay.TabIndex = 14;
			this.errorRDay.Text = "Тариф Дневной";
			this.errorRDay.Visible = false;
			// 
			// errorRNight
			// 
			this.errorRNight.AutoSize = true;
			this.errorRNight.ForeColor = System.Drawing.Color.Coral;
			this.errorRNight.Location = new System.Drawing.Point(434, 218);
			this.errorRNight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorRNight.Name = "errorRNight";
			this.errorRNight.Size = new System.Drawing.Size(121, 20);
			this.errorRNight.TabIndex = 15;
			this.errorRNight.Text = "Тариф Ночной";
			this.errorRNight.Visible = false;
			// 
			// errorDiscount
			// 
			this.errorDiscount.AutoSize = true;
			this.errorDiscount.ForeColor = System.Drawing.Color.Coral;
			this.errorDiscount.Location = new System.Drawing.Point(433, 277);
			this.errorDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorDiscount.Name = "errorDiscount";
			this.errorDiscount.Size = new System.Drawing.Size(65, 20);
			this.errorDiscount.TabIndex = 18;
			this.errorDiscount.Text = "Скидка";
			this.errorDiscount.Visible = false;
			// 
			// labelDiscount
			// 
			this.labelDiscount.AutoSize = true;
			this.labelDiscount.Location = new System.Drawing.Point(94, 277);
			this.labelDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelDiscount.Name = "labelDiscount";
			this.labelDiscount.Size = new System.Drawing.Size(65, 20);
			this.labelDiscount.TabIndex = 16;
			this.labelDiscount.Text = "Скидка";
			// 
			// numericDiscount
			// 
			this.numericDiscount.Location = new System.Drawing.Point(280, 271);
			this.numericDiscount.Name = "numericDiscount";
			this.numericDiscount.Size = new System.Drawing.Size(100, 26);
			this.numericDiscount.TabIndex = 19;
			// 
			// numericRateDay
			// 
			this.numericRateDay.DecimalPlaces = 2;
			this.numericRateDay.Location = new System.Drawing.Point(280, 161);
			this.numericRateDay.Name = "numericRateDay";
			this.numericRateDay.Size = new System.Drawing.Size(100, 26);
			this.numericRateDay.TabIndex = 20;
			// 
			// numericRateNight
			// 
			this.numericRateNight.DecimalPlaces = 2;
			this.numericRateNight.Location = new System.Drawing.Point(280, 218);
			this.numericRateNight.Name = "numericRateNight";
			this.numericRateNight.Size = new System.Drawing.Size(100, 26);
			this.numericRateNight.TabIndex = 21;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCityDataGridViewTextBoxColumn,
            this.nameCityDataGridViewTextBoxColumn,
            this.rateDayDataGridViewTextBoxColumn,
            this.rateNigthDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.cityBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(98, 376);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(545, 246);
			this.dataGridView1.TabIndex = 22;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
			// 
			// phoneCallDataSet19
			// 
			this.phoneCallDataSet19.DataSetName = "PhoneCallDataSet19";
			this.phoneCallDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cityBindingSource
			// 
			this.cityBindingSource.DataMember = "City";
			this.cityBindingSource.DataSource = this.phoneCallDataSet19;
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
			// discountDataGridViewTextBoxColumn
			// 
			this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
			this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
			this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
			// 
			// City
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(968, 746);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.numericRateNight);
			this.Controls.Add(this.numericRateDay);
			this.Controls.Add(this.numericDiscount);
			this.Controls.Add(this.errorDiscount);
			this.Controls.Add(this.labelDiscount);
			this.Controls.Add(this.errorRNight);
			this.Controls.Add(this.errorRDay);
			this.Controls.Add(this.errorCity);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.labelIDCity);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "City";
			this.Text = "Скидка";
			this.Load += new System.EventHandler(this.City_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRateDay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericRateNight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet19)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labelIDCity;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label errorCity;
		private System.Windows.Forms.Label errorRDay;
		private System.Windows.Forms.Label errorRNight;
		private System.Windows.Forms.Label errorDiscount;
		private System.Windows.Forms.Label labelDiscount;
		private System.Windows.Forms.NumericUpDown numericDiscount;
		private System.Windows.Forms.NumericUpDown numericRateDay;
		private System.Windows.Forms.NumericUpDown numericRateNight;
		private System.Windows.Forms.DataGridView dataGridView1;
		private PhoneCallDataSet19 phoneCallDataSet19;
		private System.Windows.Forms.BindingSource cityBindingSource;
		private PhoneCallDataSet19TableAdapters.CityTableAdapter cityTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idCityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameCityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rateDayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn rateNigthDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
	}
}