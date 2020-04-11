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
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.phoneCallDataSet12 = new ControlPhoneCall.PhoneCallDataSet12();
			this.conversationBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.conversationTableAdapter = new ControlPhoneCall.PhoneCallDataSet12TableAdapters.ConversationTableAdapter();
			this.idConversationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idSubScriberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.timesOfDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneCallDataSet1 = new ControlPhoneCall.PhoneCallDataSet();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.conversationBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
			this.button1.Location = new System.Drawing.Point(848, 280);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 64);
			this.button1.TabIndex = 25;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBoxAddress
			// 
			this.textBoxAddress.Location = new System.Drawing.Point(374, 221);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(100, 26);
			this.textBoxAddress.TabIndex = 23;
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new System.Drawing.Point(374, 112);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(100, 26);
			this.textBoxCity.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(274, 227);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 20);
			this.label3.TabIndex = 20;
			this.label3.Text = "Адрес";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(222, 170);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 20);
			this.label2.TabIndex = 19;
			this.label2.Text = "Выбор города";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(189, 112);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 20);
			this.label1.TabIndex = 18;
			this.label1.Text = "Количество минут";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(374, 167);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 28);
			this.comboBox1.TabIndex = 27;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConversationDataGridViewTextBoxColumn,
            this.idSubScriberDataGridViewTextBoxColumn,
            this.idCityDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.countMinutesDataGridViewTextBoxColumn,
            this.timesOfDayDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.conversationBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(93, 280);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(642, 150);
			this.dataGridView1.TabIndex = 28;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_2);
			// 
			// phoneCallDataSet12
			// 
			this.phoneCallDataSet12.DataSetName = "PhoneCallDataSet12";
			this.phoneCallDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// conversationBindingSource
			// 
			this.conversationBindingSource.DataMember = "Conversation";
			this.conversationBindingSource.DataSource = this.phoneCallDataSet12;
			// 
			// conversationTableAdapter
			// 
			this.conversationTableAdapter.ClearBeforeFill = true;
			// 
			// idConversationDataGridViewTextBoxColumn
			// 
			this.idConversationDataGridViewTextBoxColumn.DataPropertyName = "IdConversation";
			this.idConversationDataGridViewTextBoxColumn.HeaderText = "IdConversation";
			this.idConversationDataGridViewTextBoxColumn.Name = "idConversationDataGridViewTextBoxColumn";
			this.idConversationDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// idSubScriberDataGridViewTextBoxColumn
			// 
			this.idSubScriberDataGridViewTextBoxColumn.DataPropertyName = "IdSubScriber";
			this.idSubScriberDataGridViewTextBoxColumn.HeaderText = "IdSubScriber";
			this.idSubScriberDataGridViewTextBoxColumn.Name = "idSubScriberDataGridViewTextBoxColumn";
			// 
			// idCityDataGridViewTextBoxColumn
			// 
			this.idCityDataGridViewTextBoxColumn.DataPropertyName = "IdCity";
			this.idCityDataGridViewTextBoxColumn.HeaderText = "IdCity";
			this.idCityDataGridViewTextBoxColumn.Name = "idCityDataGridViewTextBoxColumn";
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			// 
			// countMinutesDataGridViewTextBoxColumn
			// 
			this.countMinutesDataGridViewTextBoxColumn.DataPropertyName = "CountMinutes";
			this.countMinutesDataGridViewTextBoxColumn.HeaderText = "CountMinutes";
			this.countMinutesDataGridViewTextBoxColumn.Name = "countMinutesDataGridViewTextBoxColumn";
			// 
			// timesOfDayDataGridViewTextBoxColumn
			// 
			this.timesOfDayDataGridViewTextBoxColumn.DataPropertyName = "TimesOfDay";
			this.timesOfDayDataGridViewTextBoxColumn.HeaderText = "TimesOfDay";
			this.timesOfDayDataGridViewTextBoxColumn.Name = "timesOfDayDataGridViewTextBoxColumn";
			// 
			// phoneCallDataSet1
			// 
			this.phoneCallDataSet1.DataSetName = "PhoneCallDataSet";
			this.phoneCallDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(93, 500);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(240, 150);
			this.dataGridView2.TabIndex = 29;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(728, 112);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 20);
			this.label5.TabIndex = 30;
			this.label5.Text = "Выбор города";
			// 
			// dataGridView3
			// 
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Location = new System.Drawing.Point(495, 500);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.Size = new System.Drawing.Size(240, 150);
			this.dataGridView3.TabIndex = 31;
			// 
			// Conversation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Conversation";
			this.Text = "Conversation";
			this.Load += new System.EventHandler(this.Conversation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.conversationBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phoneCallDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private PhoneCallDataSet12 phoneCallDataSet12;
		private System.Windows.Forms.BindingSource conversationBindingSource;
		private PhoneCallDataSet12TableAdapters.ConversationTableAdapter conversationTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idConversationDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idSubScriberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idCityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countMinutesDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn timesOfDayDataGridViewTextBoxColumn;
		private PhoneCallDataSet phoneCallDataSet1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView3;
	}
}