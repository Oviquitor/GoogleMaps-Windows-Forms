using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace MapasGoogle
{
    public partial class Form1 : Form
    {

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        //Ruta automatizada(dirección)
        bool trazarRuta = false;
        int ContadorIndicadoresRuta = 0;
        PointLatLng inicio;
        PointLatLng final;

        int filaSeleccionada = 0;
        double LatInicial = 20.9688132813906;
        double LngInicial = -89.6250915527344;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripción", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));

            //insertando datos al dt para mostrar en la lista
            dt.Rows.Add("Ubicación", LatInicial, LngInicial);
            dataGridView1.DataSource = dt;

            //desactivar las columnas de lat y long
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            //Creando las dimensiones del GMAPCONTROL(herramienta)
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //Marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(LatInicial, LngInicial), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker);//Agregamos al mapa

            //agregamos un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación:\n Latitud:{0}\n Longitud:{1}", LatInicial, LngInicial);

            //ahora agregamos el mapa y el marcador al control map

            gMapControl1.Overlays.Add(markerOverlay);


        }

        private void SelecionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            filaSeleccionada = e.RowIndex;//Fila Seleccionada
            //Recuperamos los datos del grid y los asignamos a los texbox
            txtDescripcion.Text = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
            txtlatitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[1].Value.ToString();
            txtlongitud.Text = dataGridView1.Rows[filaSeleccionada].Cells[2].Value.ToString();

            //se asignan los valores del grid al macador
            marker.Position = new PointLatLng(Convert.ToDouble(txtlatitud.Text), Convert.ToDouble(txtlongitud.Text));
            //se posiciona el foco del mapa en ese punto
            gMapControl1.Position = marker.Position;

        }

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //se obtiene los datos de lat y lng del mapa donde usuario presiono
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //se posicionan en el txt de la latitud y longitud
            txtlatitud.Text = lat.ToString();
            txtlongitud.Text = lng.ToString();

            //crearemos el marcador para moverlo al lugar indicado por el usuario
            marker.Position = new PointLatLng(lat, lng);
            //tambien se agregara el mensaje al marcador es decir el ToolTip
            marker.ToolTipText = string.Format("Ubicación:\n Latitud:{0}\n Longitud:{1}", lat, lng);

            CrearDireccionTrazarRuta(lat, lng);
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtDescripcion.Text, txtlatitud.Text, txtlongitud.Text);//agregar a la tabla
            //procedimiento para insertar a un base de datos sin SQL
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(filaSeleccionada);//remover de la tabla
            //procedimiento para eliminar datos de una base de datos sin SQL
        }

       

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            GMapOverlay Poligono = new GMapOverlay("POligono");
            List<PointLatLng> puntos = new List<PointLatLng>();
            //variables para almacenar los datos
            double lng, lat;
            //agregamos los datos del grid
            for(int filas=0;filas<dataGridView1.Rows.Count;filas++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }

            GMapPolygon poligonoPuntos = new GMapPolygon(puntos, "Polígono");
            Poligono.Polygons.Add(poligonoPuntos);
            gMapControl1.Overlays.Add(Poligono);
            //actulizara el mapa
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;

        }

        private void btnRuta_Click(object sender, EventArgs e)
        {

            GMapOverlay Ruta = new GMapOverlay("CapaRuta");

            List<PointLatLng> puntos = new List<PointLatLng>();
            //variables para almacenar los datos
            double lng, lat;
            //agregamos los datos del grid
            for (int filas = 0; filas < dataGridView1.Rows.Count; filas++) 
            {
                lat = Convert.ToDouble(dataGridView1.Rows[filas].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[filas].Cells[2].Value);
                puntos.Add(new PointLatLng(lat, lng));
            }

            GMapRoute PuntosRuta = new GMapRoute(puntos, "Ruta");
            Ruta.Routes.Add(PuntosRuta);
            gMapControl1.Overlays.Add(Ruta);

            //Actulizar el mapa
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;


        }

        public void CrearDireccionTrazarRuta(double lat, double lng)
        {
            if(trazarRuta)
            {
                switch(ContadorIndicadoresRuta)
                {
                    case 0://primer marcador de inico
                        ContadorIndicadoresRuta++;
                        inicio = new PointLatLng(lat, lng);
                        break;
                    case 1://Segundo marcador o final
                        ContadorIndicadoresRuta++;
                        final = new PointLatLng(lat, lng);
                        GDirections direccion;
                        var RutasDireccion = GMapProviders.GoogleMap.GetDirections(out direccion, inicio, final, false, false, false, false, false);
                        GMapRoute RutaObtenida = new GMapRoute(direccion.Route, "Ruta ubicación");
                        GMapOverlay CapaRutas = new GMapOverlay("Capa de la ruta");
                        CapaRutas.Routes.Add(RutaObtenida);
                        gMapControl1.Overlays.Add(CapaRutas);
                        gMapControl1.Zoom = gMapControl1.Zoom + 1;
                        gMapControl1.Zoom = gMapControl1.Zoom - 1;
                        ContadorIndicadoresRuta = 0;
                        trazarRuta = false;
                        break;
                }
            }
        }

        

        private void btnSat_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleChinaSatelliteMap;

        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void btnRelieve_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackZoom.Value = Convert.ToInt32(gMapControl1.Zoom);

        }

        private void trackZoom_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackZoom.Value;
        }
    }
}