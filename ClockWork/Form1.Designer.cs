namespace ClockWork
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblClock = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.timerReloj = new System.Windows.Forms.Timer(this.components);
            this.lblStartHour = new System.Windows.Forms.Label();
            this.lblEndHour = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.dataGridViewIntervalos = new System.Windows.Forms.DataGridView();
            this.lblTotalSUM = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbxActividad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPausado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntervalos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Location = new System.Drawing.Point(167, 13);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(152, 55);
            this.lblClock.TabIndex = 0;
            this.lblClock.Text = "label1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 112);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 32);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(314, 112);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(145, 32);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // timerReloj
            // 
            this.timerReloj.Tick += new System.EventHandler(this.timerReloj_Tick);
            // 
            // lblStartHour
            // 
            this.lblStartHour.AutoSize = true;
            this.lblStartHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartHour.Location = new System.Drawing.Point(9, 147);
            this.lblStartHour.Name = "lblStartHour";
            this.lblStartHour.Size = new System.Drawing.Size(50, 24);
            this.lblStartHour.TabIndex = 3;
            this.lblStartHour.Text = "........";
            // 
            // lblEndHour
            // 
            this.lblEndHour.AutoSize = true;
            this.lblEndHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndHour.Location = new System.Drawing.Point(9, 171);
            this.lblEndHour.Name = "lblEndHour";
            this.lblEndHour.Size = new System.Drawing.Size(50, 24);
            this.lblEndHour.TabIndex = 4;
            this.lblEndHour.Text = "........";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(8, 195);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(50, 24);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "........";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(163, 112);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(145, 32);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // dataGridViewIntervalos
            // 
            this.dataGridViewIntervalos.AllowUserToAddRows = false;
            this.dataGridViewIntervalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIntervalos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.cStart,
            this.cEnd,
            this.cPausado,
            this.cDuration});
            this.dataGridViewIntervalos.Location = new System.Drawing.Point(9, 322);
            this.dataGridViewIntervalos.Name = "dataGridViewIntervalos";
            this.dataGridViewIntervalos.Size = new System.Drawing.Size(957, 217);
            this.dataGridViewIntervalos.TabIndex = 7;
            // 
            // lblTotalSUM
            // 
            this.lblTotalSUM.AutoSize = true;
            this.lblTotalSUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSUM.Location = new System.Drawing.Point(9, 219);
            this.lblTotalSUM.Name = "lblTotalSUM";
            this.lblTotalSUM.Size = new System.Drawing.Size(50, 24);
            this.lblTotalSUM.TabIndex = 8;
            this.lblTotalSUM.Text = "........";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ClockWork";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // tbxActividad
            // 
            this.tbxActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActividad.Location = new System.Drawing.Point(13, 80);
            this.tbxActividad.Name = "tbxActividad";
            this.tbxActividad.Size = new System.Drawing.Size(446, 26);
            this.tbxActividad.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Actividad:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Actividad";
            this.Column1.Name = "Column1";
            this.Column1.Width = 500;
            // 
            // cStart
            // 
            this.cStart.HeaderText = "Start";
            this.cStart.Name = "cStart";
            // 
            // cEnd
            // 
            this.cEnd.HeaderText = "cEnd";
            this.cEnd.Name = "cEnd";
            // 
            // cPausado
            // 
            this.cPausado.HeaderText = "Pausado";
            this.cPausado.Name = "cPausado";
            // 
            // cDuration
            // 
            this.cDuration.HeaderText = "Duration";
            this.cDuration.Name = "cDuration";
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.Location = new System.Drawing.Point(926, 275);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 40);
            this.btnExcel.TabIndex = 115;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 558);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxActividad);
            this.Controls.Add(this.lblTotalSUM);
            this.Controls.Add(this.dataGridViewIntervalos);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblEndHour);
            this.Controls.Add(this.lblStartHour);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblClock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIntervalos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Timer timerReloj;
        private System.Windows.Forms.Label lblStartHour;
        private System.Windows.Forms.Label lblEndHour;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.DataGridView dataGridViewIntervalos;
        private System.Windows.Forms.Label lblTotalSUM;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPausado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDuration;
        private System.Windows.Forms.TextBox tbxActividad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcel;
    }
}

