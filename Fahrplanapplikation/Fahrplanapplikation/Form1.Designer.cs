using System;

namespace Fahrplanapplikation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up ressources which are currently being used.
        /// </summary>
        /// <param name="disposing">True, if managed ressources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Required method for designer support.
        /// Content of this method must not be modified with der code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.comboBoxDeparture = new System.Windows.Forms.ComboBox();
            this.comboBoxDestination = new System.Windows.Forms.ComboBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDisableDestination = new System.Windows.Forms.Label();
            this.rBtnYes = new System.Windows.Forms.RadioButton();
            this.rBtnNo = new System.Windows.Forms.RadioButton();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnSearchConncections = new System.Windows.Forms.Button();
            this.btnSearchMapDeparture = new System.Windows.Forms.Button();
            this.btnSearchMapDestination = new System.Windows.Forms.Button();
            this.dataGridViewConnection = new System.Windows.Forms.DataGridView();
            this.Depart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDeparture.Location = new System.Drawing.Point(-4, 23);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(114, 25);
            this.lblDeparture.TabIndex = 0;
            this.lblDeparture.Text = "Departure:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDestination.Location = new System.Drawing.Point(505, 23);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(127, 25);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Destination:";
            // 
            // comboBoxDeparture
            // 
            this.comboBoxDeparture.FormattingEnabled = true;
            this.comboBoxDeparture.Location = new System.Drawing.Point(1, 58);
            this.comboBoxDeparture.Name = "comboBoxDeparture";
            this.comboBoxDeparture.Size = new System.Drawing.Size(500, 24);
            this.comboBoxDeparture.TabIndex = 1;
            this.comboBoxDeparture.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxDeparture_KeyDown);
            // 
            // comboBoxDestination
            // 
            this.comboBoxDestination.FormattingEnabled = true;
            this.comboBoxDestination.Location = new System.Drawing.Point(507, 58);
            this.comboBoxDestination.Name = "comboBoxDestination";
            this.comboBoxDestination.Size = new System.Drawing.Size(500, 24);
            this.comboBoxDestination.TabIndex = 2;
            this.comboBoxDestination.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxDestination_KeyDown);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.Location = new System.Drawing.Point(-4, 102);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(131, 25);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "Date / Time:";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(1, 130);
            this.datePicker.Name = "datePicker";
            this.datePicker.ShowUpDown = true;
            this.datePicker.Size = new System.Drawing.Size(250, 22);
            this.datePicker.TabIndex = 3;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(257, 130);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(250, 22);
            this.timePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // lblDisableDestination
            // 
            this.lblDisableDestination.AutoSize = true;
            this.lblDisableDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDisableDestination.Location = new System.Drawing.Point(513, 105);
            this.lblDisableDestination.Name = "lblDisableDestination";
            this.lblDisableDestination.Size = new System.Drawing.Size(205, 25);
            this.lblDisableDestination.TabIndex = 7;
            this.lblDisableDestination.Text = "Disable Destination:";
            // 
            // rBtnYes
            // 
            this.rBtnYes.AutoSize = true;
            this.rBtnYes.Location = new System.Drawing.Point(518, 133);
            this.rBtnYes.Name = "rBtnYes";
            this.rBtnYes.Size = new System.Drawing.Size(51, 21);
            this.rBtnYes.TabIndex = 5;
            this.rBtnYes.TabStop = true;
            this.rBtnYes.Text = "yes";
            this.rBtnYes.UseVisualStyleBackColor = true;
            this.rBtnYes.CheckedChanged += new System.EventHandler(this.rBtnYes_CheckedChanged);
            // 
            // rBtnNo
            // 
            this.rBtnNo.AutoSize = true;
            this.rBtnNo.Location = new System.Drawing.Point(606, 133);
            this.rBtnNo.Name = "rBtnNo";
            this.rBtnNo.Size = new System.Drawing.Size(45, 21);
            this.rBtnNo.TabIndex = 6;
            this.rBtnNo.TabStop = true;
            this.rBtnNo.Text = "no";
            this.rBtnNo.UseVisualStyleBackColor = true;
            // 
            // btnSwap
            // 
            this.btnSwap.Location = new System.Drawing.Point(1, 158);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(250, 35);
            this.btnSwap.TabIndex = 7;
            this.btnSwap.Text = "Swap Departure/Destination";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnSearchConncections
            // 
            this.btnSearchConncections.Location = new System.Drawing.Point(257, 158);
            this.btnSearchConncections.Name = "btnSearchConncections";
            this.btnSearchConncections.Size = new System.Drawing.Size(250, 35);
            this.btnSearchConncections.TabIndex = 8;
            this.btnSearchConncections.Text = "Search Connections";
            this.btnSearchConncections.UseVisualStyleBackColor = true;
            this.btnSearchConncections.Click += new System.EventHandler(this.btnSearchConncections_Click);
            // 
            // btnSearchMapDeparture
            // 
            this.btnSearchMapDeparture.Location = new System.Drawing.Point(510, 158);
            this.btnSearchMapDeparture.Name = "btnSearchMapDeparture";
            this.btnSearchMapDeparture.Size = new System.Drawing.Size(250, 35);
            this.btnSearchMapDeparture.TabIndex = 9;
            this.btnSearchMapDeparture.Text = "Search Departure";
            this.btnSearchMapDeparture.UseVisualStyleBackColor = true;
            this.btnSearchMapDeparture.Click += new System.EventHandler(this.btnSearchMapDeparture_Click);
            // 
            // btnSearchMapDestination
            // 
            this.btnSearchMapDestination.Location = new System.Drawing.Point(766, 158);
            this.btnSearchMapDestination.Name = "btnSearchMapDestination";
            this.btnSearchMapDestination.Size = new System.Drawing.Size(250, 35);
            this.btnSearchMapDestination.TabIndex = 10;
            this.btnSearchMapDestination.Text = "Search Destination";
            this.btnSearchMapDestination.UseVisualStyleBackColor = true;
            this.btnSearchMapDestination.Click += new System.EventHandler(this.btnSearchMapDestination_Click);
            // 
            // dataGridViewConnection
            // 
            this.dataGridViewConnection.AllowUserToAddRows = false;
            this.dataGridViewConnection.AllowUserToDeleteRows = false;
            this.dataGridViewConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConnection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Depart,
            this.vehicleName,
            this.TrackDepart,
            this.Destination,
            this.TrackDestination,
            this.Start,
            this.Arrival,
            this.Duration});
            this.dataGridViewConnection.Location = new System.Drawing.Point(1, 192);
            this.dataGridViewConnection.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewConnection.Name = "dataGridViewConnection";
            this.dataGridViewConnection.ReadOnly = true;
            this.dataGridViewConnection.Size = new System.Drawing.Size(1059, 401);
            this.dataGridViewConnection.TabIndex = 0;
            this.dataGridViewConnection.TabStop = false;
            this.dataGridViewConnection.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConnection_CellContentClick);
            // 
            // Depart
            // 
            this.Depart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Depart.HeaderText = "Depart";
            this.Depart.MinimumWidth = 30;
            this.Depart.Name = "Depart";
            this.Depart.ReadOnly = true;
            // 
            // vehicleName
            // 
            this.vehicleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vehicleName.HeaderText = "Vehicle Name";
            this.vehicleName.Name = "vehicleName";
            this.vehicleName.ReadOnly = true;
            this.vehicleName.Width = 124;
            // 
            // TrackDepart
            // 
            this.TrackDepart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TrackDepart.HeaderText = "Track";
            this.TrackDepart.Name = "TrackDepart";
            this.TrackDepart.ReadOnly = true;
            this.TrackDepart.Width = 73;
            // 
            // Destination
            // 
            this.Destination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Destination.HeaderText = "Destination";
            this.Destination.MinimumWidth = 30;
            this.Destination.Name = "Destination";
            this.Destination.ReadOnly = true;
            // 
            // TrackDestination
            // 
            this.TrackDestination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TrackDestination.HeaderText = "Track";
            this.TrackDestination.Name = "TrackDestination";
            this.TrackDestination.ReadOnly = true;
            this.TrackDestination.Width = 73;
            // 
            // Start
            // 
            this.Start.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Start.HeaderText = "Start";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            this.Start.Width = 67;
            // 
            // Arrival
            // 
            this.Arrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            this.Arrival.Width = 77;
            // 
            // Duration
            // 
            this.Duration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 91;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 593);
            this.Controls.Add(this.dataGridViewConnection);
            this.Controls.Add(this.btnSearchMapDestination);
            this.Controls.Add(this.btnSearchMapDeparture);
            this.Controls.Add(this.btnSearchConncections);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.rBtnNo);
            this.Controls.Add(this.rBtnYes);
            this.Controls.Add(this.lblDisableDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.comboBoxDestination);
            this.Controls.Add(this.comboBoxDeparture);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblDeparture);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.ComboBox comboBoxDeparture;
        private System.Windows.Forms.ComboBox comboBoxDestination;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisableDestination;
        private System.Windows.Forms.RadioButton rBtnYes;
        private System.Windows.Forms.RadioButton rBtnNo;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.Button btnSearchConncections;
        private System.Windows.Forms.Button btnSearchMapDeparture;
        private System.Windows.Forms.Button btnSearchMapDestination;
        private System.Windows.Forms.DataGridView dataGridViewConnection;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depart;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackDepart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
    }
}

