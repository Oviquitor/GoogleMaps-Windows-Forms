namespace MapasGoogle
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtlatitud = new System.Windows.Forms.TextBox();
            this.txtlongitud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRuta = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSat = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.btnRelieve = new System.Windows.Forms.Button();
            this.trackZoom = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 13);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(560, 416);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(578, 46);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(211, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtlatitud
            // 
            this.txtlatitud.Location = new System.Drawing.Point(578, 89);
            this.txtlatitud.Name = "txtlatitud";
            this.txtlatitud.Size = new System.Drawing.Size(211, 20);
            this.txtlatitud.TabIndex = 4;
            // 
            // txtlongitud
            // 
            this.txtlongitud.Location = new System.Drawing.Point(578, 134);
            this.txtlongitud.Name = "txtlongitud";
            this.txtlongitud.Size = new System.Drawing.Size(211, 20);
            this.txtlongitud.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(578, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Latitud";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Longitud";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(578, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(318, 212);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelecionarRegistro);
            // 
            // btnRuta
            // 
            this.btnRuta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRuta.ForeColor = System.Drawing.Color.White;
            this.btnRuta.Image = global::MapasGoogle.Properties.Resources._1477040969_rout;
            this.btnRuta.Location = new System.Drawing.Point(811, 45);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(95, 47);
            this.btnRuta.TabIndex = 11;
            this.btnRuta.Text = "Ruta";
            this.btnRuta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRuta.UseVisualStyleBackColor = false;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPolygon.ForeColor = System.Drawing.Color.White;
            this.btnPolygon.Image = global::MapasGoogle.Properties.Resources._1477040925_polygom;
            this.btnPolygon.Location = new System.Drawing.Point(811, 108);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(95, 47);
            this.btnPolygon.TabIndex = 10;
            this.btnPolygon.Text = "Polígono ";
            this.btnPolygon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::MapasGoogle.Properties.Resources._1475456409_map_delete;
            this.btnEliminar.Location = new System.Drawing.Point(692, 160);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 47);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = global::MapasGoogle.Properties.Resources._1475456163_map_add;
            this.btnAgregar.Location = new System.Drawing.Point(578, 160);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 47);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSat
            // 
            this.btnSat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSat.ForeColor = System.Drawing.Color.White;
            this.btnSat.Location = new System.Drawing.Point(13, 450);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(75, 23);
            this.btnSat.TabIndex = 13;
            this.btnSat.Text = "Satélite";
            this.btnSat.UseVisualStyleBackColor = false;
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // btnOriginal
            // 
            this.btnOriginal.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnOriginal.ForeColor = System.Drawing.Color.White;
            this.btnOriginal.Location = new System.Drawing.Point(104, 450);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(75, 23);
            this.btnOriginal.TabIndex = 14;
            this.btnOriginal.Text = "Normal";
            this.btnOriginal.UseVisualStyleBackColor = false;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // btnRelieve
            // 
            this.btnRelieve.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRelieve.ForeColor = System.Drawing.Color.White;
            this.btnRelieve.Location = new System.Drawing.Point(201, 450);
            this.btnRelieve.Name = "btnRelieve";
            this.btnRelieve.Size = new System.Drawing.Size(75, 23);
            this.btnRelieve.TabIndex = 15;
            this.btnRelieve.Text = "Relieve";
            this.btnRelieve.UseVisualStyleBackColor = false;
            this.btnRelieve.Click += new System.EventHandler(this.btnRelieve_Click);
            // 
            // trackZoom
            // 
            this.trackZoom.Location = new System.Drawing.Point(382, 435);
            this.trackZoom.Maximum = 25;
            this.trackZoom.Name = "trackZoom";
            this.trackZoom.Size = new System.Drawing.Size(235, 45);
            this.trackZoom.TabIndex = 16;
            this.trackZoom.ValueChanged += new System.EventHandler(this.trackZoom_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Zoom:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 488);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackZoom);
            this.Controls.Add(this.btnRelieve);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.btnSat);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnPolygon);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlongitud);
            this.Controls.Add(this.txtlatitud);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gMapControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GoogleMapa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackZoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtlatitud;
        private System.Windows.Forms.TextBox txtlongitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.Button btnRelieve;
        private System.Windows.Forms.TrackBar trackZoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
    }
}

