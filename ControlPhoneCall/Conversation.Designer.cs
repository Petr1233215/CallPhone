namespace ControlPhoneCall
{
	partial class Conversation
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
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxCity = new System.Windows.Forms.ComboBox();
			this.cityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.phoneCallDataSet23 = new ControlPhoneCall.PhoneCallDataSet23();
			this.idCity = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.comboBoxSubscriber = new System.Windows.Forms.ComboBox();
			this.subscribersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.phoneCallDataSet22 = new ControlPhoneCall.PhoneCallDataSet22();
			this.label3 = new System.Windows.Forms.Label();
			this.errorMinute = new System.Windows.Forms.Label();
			this.errorCity = new System.Windows.Forms.Label();
			this.errorSubscribe = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBoxIdCity = new System.Windows.Forms.ComboBox();
			this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.phoneCallDataSet21 = new ControlPhoneCall.PhoneCallDataSet21();
			this.comboBoxIdSubscriber = new System.Windows.Forms.ComboBox();
			this.subscribersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.phoneCallDataSet20 = new ControlPhoneCall.PhoneCallDataSet20();
			this.subscribersTableAdapter = new ControlPhoneCall.PhoneCallDataSet20TableAdapters.SubscribersTableAdapter();
			this.cityTableAdapter = new ControlPhoneCall.PhoneCallDataSet21TableAdapters.CityTableAdapter();
			this.subscribersTableAdapter1 = new ControlPhoneCall.PhoneCallDataSet22TableAdapters.SubscribersTableAdapter();
			this.cityTableAdapter1 = new ControlPhoneCall.PhoneCallDataSet23TableAdapters.CityTableAdapter();
			this.textBoxMinute = new System.Windows.Forms.NumericUpDown();
			this.comboBoxRNight = new System.Windows.Forms.ComboBox();
			this.cityBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.phoneCallDataSet24 = new ControlPhoneCall.PhoneCallDataSet24();
			this.comboBoxRDay = new System.Windows.Forms.ComboBox();
			this.cityTableAdapter2 = new ControlPhoneCall.PhoneCallDataSet24TableAdapters.CityTableAdapter();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet23)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet22)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet20)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxMinute)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet24)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(369, 31);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(424, 29);
			this.label4.TabIndex = 26;
			this.label4.Text = "Создание и просмотр переговоров";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(736, 443);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 64);
			this.button1.TabIndex = 25;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(153, 179);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 20);
			this.label2.TabIndex = 19;
			this.label2.Text = "Выбор города";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(120, 121);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 20);
			this.label1.TabIndex = 18;
			this.label1.Text = "Количество минут";
			// 
			// comboBoxCity
			// 
			this.comboBoxCity.DataSource = this.cityBindingSource1;
			this.comboBoxCity.DisplayMember = "NameCity";
			this.comboBoxCity.FormattingEnabled = true;
			this.comboBoxCity.Location = new System.Drawing.Point(305, 176);
			this.comboBoxCity.Name = "comboBoxCity";
			this.comboBoxCity.Size = new System.Drawing.Size(194, 28);
			this.comboBoxCity.TabIndex = 27;
			this.comboBoxCity.TextChanged += new System.EventHandler(this.ComboBoxCity_TextChanged);
			// 
			// cityBindingSource1
			// 
			this.cityBindingSource1.DataMember = "City";
			this.cityBindingSource1.DataSource = this.phoneCallDataSet23;
			// 
			// phoneCallDataSet23
			// 
			this.phoneCallDataSet23.DataSetName = "PhoneCallDataSet23";
			this.phoneCallDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// idCity
			// 
			this.idCity.AutoSize = true;
			this.idCity.Location = new System.Drawing.Point(924, 184);
			this.idCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.idCity.Name = "idCity";
			this.idCity.Size = new System.Drawing.Size(47, 20);
			this.idCity.TabIndex = 30;
			this.idCity.Text = "idCity";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(128, 357);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(500, 150);
			this.dataGridView1.TabIndex = 31;
			// 
			// comboBoxSubscriber
			// 
			this.comboBoxSubscriber.DataSource = this.subscribersBindingSource1;
			this.comboBoxSubscriber.DisplayMember = "INN";
			this.comboBoxSubscriber.FormattingEnabled = true;
			this.comboBoxSubscriber.Location = new System.Drawing.Point(305, 230);
			this.comboBoxSubscriber.Name = "comboBoxSubscriber";
			this.comboBoxSubscriber.Size = new System.Drawing.Size(194, 28);
			this.comboBoxSubscriber.TabIndex = 34;
			this.comboBoxSubscriber.TextChanged += new System.EventHandler(this.ComboBoxSubscriber_TextChanged);
			// 
			// subscribersBindingSource1
			// 
			this.subscribersBindingSource1.DataMember = "Subscribers";
			this.subscribersBindingSource1.DataSource = this.phoneCallDataSet22;
			// 
			// phoneCallDataSet22
			// 
			this.phoneCallDataSet22.DataSetName = "PhoneCallDataSet22";
			this.phoneCallDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(135, 233);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 20);
			this.label3.TabIndex = 33;
			this.label3.Text = "Выбор абонента";
			// 
			// errorMinute
			// 
			this.errorMinute.AutoSize = true;
			this.errorMinute.ForeColor = System.Drawing.Color.Coral;
			this.errorMinute.Location = new System.Drawing.Point(556, 127);
			this.errorMinute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorMinute.Name = "errorMinute";
			this.errorMinute.Size = new System.Drawing.Size(65, 20);
			this.errorMinute.TabIndex = 35;
			this.errorMinute.Text = "минуты";
			this.errorMinute.Visible = false;
			// 
			// errorCity
			// 
			this.errorCity.AutoSize = true;
			this.errorCity.ForeColor = System.Drawing.Color.Coral;
			this.errorCity.Location = new System.Drawing.Point(556, 184);
			this.errorCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorCity.Name = "errorCity";
			this.errorCity.Size = new System.Drawing.Size(54, 20);
			this.errorCity.TabIndex = 36;
			this.errorCity.Text = "город";
			this.errorCity.Visible = false;
			// 
			// errorSubscribe
			// 
			this.errorSubscribe.AutoSize = true;
			this.errorSubscribe.ForeColor = System.Drawing.Color.Coral;
			this.errorSubscribe.Location = new System.Drawing.Point(556, 238);
			this.errorSubscribe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.errorSubscribe.Name = "errorSubscribe";
			this.errorSubscribe.Size = new System.Drawing.Size(72, 20);
			this.errorSubscribe.TabIndex = 37;
			this.errorSubscribe.Text = "абонент";
			this.errorSubscribe.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(924, 241);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 20);
			this.label5.TabIndex = 38;
			this.label5.Text = "idSubscriber";
			// 
			// comboBoxIdCity
			// 
			this.comboBoxIdCity.DataSource = this.cityBindingSource;
			this.comboBoxIdCity.DisplayMember = "IdCity";
			this.comboBoxIdCity.FormattingEnabled = true;
			this.comboBoxIdCity.Location = new System.Drawing.Point(736, 179);
			this.comboBoxIdCity.Name = "comboBoxIdCity";
			this.comboBoxIdCity.Size = new System.Drawing.Size(121, 28);
			this.comboBoxIdCity.TabIndex = 39;
			// 
			// cityBindingSource
			// 
			this.cityBindingSource.DataMember = "City";
			this.cityBindingSource.DataSource = this.phoneCallDataSet21;
			// 
			// phoneCallDataSet21
			// 
			this.phoneCallDataSet21.DataSetName = "PhoneCallDataSet21";
			this.phoneCallDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// comboBoxIdSubscriber
			// 
			this.comboBoxIdSubscriber.DataSource = this.subscribersBindingSource;
			this.comboBoxIdSubscriber.DisplayMember = "IdSubscriber";
			this.comboBoxIdSubscriber.FormattingEnabled = true;
			this.comboBoxIdSubscriber.Location = new System.Drawing.Point(736, 230);
			this.comboBoxIdSubscriber.Name = "comboBoxIdSubscriber";
			this.comboBoxIdSubscriber.Size = new System.Drawing.Size(121, 28);
			this.comboBoxIdSubscriber.TabIndex = 40;
			// 
			// subscribersBindingSource
			// 
			this.subscribersBindingSource.DataMember = "Subscribers";
			this.subscribersBindingSource.DataSource = this.phoneCallDataSet20;
			// 
			// phoneCallDataSet20
			// 
			this.phoneCallDataSet20.DataSetName = "PhoneCallDataSet20";
			this.phoneCallDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// subscribersTableAdapter
			// 
			this.subscribersTableAdapter.ClearBeforeFill = true;
			// 
			// cityTableAdapter
			// 
			this.cityTableAdapter.ClearBeforeFill = true;
			// 
			// subscribersTableAdapter1
			// 
			this.subscribersTableAdapter1.ClearBeforeFill = true;
			// 
			// cityTableAdapter1
			// 
			this.cityTableAdapter1.ClearBeforeFill = true;
			// 
			// textBoxMinute
			// 
			this.textBoxMinute.Location = new System.Drawing.Point(305, 119);
			this.textBoxMinute.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.textBoxMinute.Name = "textBoxMinute";
			this.textBoxMinute.Size = new System.Drawing.Size(120, 26);
			this.textBoxMinute.TabIndex = 41;
			// 
			// comboBoxRNight
			// 
			this.comboBoxRNight.DataSource = this.cityBindingSource2;
			this.comboBoxRNight.DisplayMember = "RateNigth";
			this.comboBoxRNight.FormattingEnabled = true;
			this.comboBoxRNight.Location = new System.Drawing.Point(736, 129);
			this.comboBoxRNight.Name = "comboBoxRNight";
			this.comboBoxRNight.Size = new System.Drawing.Size(121, 28);
			this.comboBoxRNight.TabIndex = 43;
			// 
			// cityBindingSource2
			// 
			this.cityBindingSource2.DataMember = "City";
			this.cityBindingSource2.DataSource = this.phoneCallDataSet24;
			// 
			// phoneCallDataSet24
			// 
			this.phoneCallDataSet24.DataSetName = "PhoneCallDataSet24";
			this.phoneCallDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// comboBoxRDay
			// 
			this.comboBoxRDay.DataSource = this.cityBindingSource2;
			this.comboBoxRDay.DisplayMember = "RateDay";
			this.comboBoxRDay.FormattingEnabled = true;
			this.comboBoxRDay.Location = new System.Drawing.Point(736, 82);
			this.comboBoxRDay.Name = "comboBoxRDay";
			this.comboBoxRDay.Size = new System.Drawing.Size(121, 28);
			this.comboBoxRDay.TabIndex = 42;
			// 
			// cityTableAdapter2
			// 
			this.cityTableAdapter2.ClearBeforeFill = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(924, 139);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(58, 20);
			this.label9.TabIndex = 45;
			this.label9.Text = "RNight";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(924, 82);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(49, 20);
			this.label10.TabIndex = 44;
			this.label10.Text = "RDay";
			// 
			// Conversation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.comboBoxRNight);
			this.Controls.Add(this.comboBoxRDay);
			this.Controls.Add(this.textBoxMinute);
			this.Controls.Add(this.comboBoxIdSubscriber);
			this.Controls.Add(this.comboBoxIdCity);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.errorSubscribe);
			this.Controls.Add(this.errorCity);
			this.Controls.Add(this.errorMinute);
			this.Controls.Add(this.comboBoxSubscriber);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.idCity);
			this.Controls.Add(this.comboBoxCity);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Conversation";
			this.Text = "Conversation";
			this.Load += new System.EventHandler(this.Conversation_Load);
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet23)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet22)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.subscribersBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet20)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxMinute)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cityBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet24)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxCity;
		private System.Windows.Forms.Label idCity;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.ComboBox comboBoxSubscriber;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label errorMinute;
		private System.Windows.Forms.Label errorCity;
		private System.Windows.Forms.Label errorSubscribe;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBoxIdCity;
		private System.Windows.Forms.ComboBox comboBoxIdSubscriber;
		private PhoneCallDataSet20 phoneCallDataSet20;
		private System.Windows.Forms.BindingSource subscribersBindingSource;
		private PhoneCallDataSet20TableAdapters.SubscribersTableAdapter subscribersTableAdapter;
		private PhoneCallDataSet21 phoneCallDataSet21;
		private System.Windows.Forms.BindingSource cityBindingSource;
		private PhoneCallDataSet21TableAdapters.CityTableAdapter cityTableAdapter;
		private PhoneCallDataSet22 phoneCallDataSet22;
		private System.Windows.Forms.BindingSource subscribersBindingSource1;
		private PhoneCallDataSet22TableAdapters.SubscribersTableAdapter subscribersTableAdapter1;
		private PhoneCallDataSet23 phoneCallDataSet23;
		private System.Windows.Forms.BindingSource cityBindingSource1;
		private PhoneCallDataSet23TableAdapters.CityTableAdapter cityTableAdapter1;
		private System.Windows.Forms.NumericUpDown textBoxMinute;
		private System.Windows.Forms.ComboBox comboBoxRNight;
		private System.Windows.Forms.ComboBox comboBoxRDay;
		private PhoneCallDataSet24 phoneCallDataSet24;
		private System.Windows.Forms.BindingSource cityBindingSource2;
		private PhoneCallDataSet24TableAdapters.CityTableAdapter cityTableAdapter2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
	}
}