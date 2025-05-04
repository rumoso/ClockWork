using ClockWork.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ClockWork
{
    public partial class Form1 : Form
    {
        private DateTime horaInicio;
        private DateTime horaFin;
        private DateTime horaInicioPause;
        private bool estaPausado = false;
        private List<IntervaloTiempo> intervalos = new List<IntervaloTiempo>(); // Lista para almacenar los intervalos
        private TimeSpan tiempoPausado = TimeSpan.Zero;
        private bool bTimerGo = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerReloj.Start();
        }

        private void timerReloj_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!bTimerGo)
            {
                horaInicio = DateTime.Now;
                lblStartHour.Text = "Hora de Inicio: " + horaInicio.ToString("HH:mm:ss");
                lblEndHour.Text = "";
                lblDuration.Text = "";
                bTimerGo = true;
                estaPausado = false;
                btnPause.Text = "Pausa";
                tiempoPausado = TimeSpan.Zero;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if (!estaPausado && bTimerGo)
            {
                horaFin = DateTime.Now;
                lblEndHour.Text = "Hora de Fin: " + horaFin.ToString("HH:mm:ss");

                TimeSpan duracion = horaFin - horaInicio - tiempoPausado; // Restamos el tiempo pausado
                lblDuration.Text = "Duración: " + duracion.ToString();

                intervalos.Add(new IntervaloTiempo { sActividad = tbxActividad.Text, Inicio = horaInicio, Fin = horaFin, tiempoPausado = tiempoPausado, Duracion = duracion });
                ActualizarDataGridView();
                tiempoPausado = TimeSpan.Zero;
                bTimerGo = false;
                SumarDataGridView();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (!estaPausado)
            {
                estaPausado = true;
                
                btnPause.Text = "Reanudar";
                horaInicioPause = DateTime.Now;
            }
            else
            {
                estaPausado = false;
                timerReloj.Start();
                btnPause.Text = "Pausa";
                tiempoPausado += DateTime.Now - horaInicioPause; // Acumulamos el tiempo pausado
            }
        }

        private void ActualizarDataGridView()
        {
            // Limpiar el DataGridView y agregar los intervalos
            dataGridViewIntervalos.Rows.Clear();
            foreach (var intervalo in intervalos)
            {
                string stiempoPausado = string.Format("{0:D2}:{1:D2}:{2:D2}", intervalo.tiempoPausado.Hours, intervalo.tiempoPausado.Minutes, intervalo.tiempoPausado.Seconds);
                string sDuracion = string.Format("{0:D2}:{1:D2}:{2:D2}", intervalo.Duracion.Hours, intervalo.Duracion.Minutes, intervalo.Duracion.Seconds);
                dataGridViewIntervalos.Rows.Add(intervalo.sActividad, intervalo.Inicio.ToString("HH:mm:ss"), intervalo.Fin.ToString("HH:mm:ss"), stiempoPausado, sDuracion);
            }
        }

        private void SumarDataGridView()
        {
            lblTotalSUM.Text = "El Total acumulado es: " + intervalos.Sum(x => x.Duracion.TotalSeconds).ToString() + " segundos";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal; // Restaurar el formulario
                this.Activate();
            }
            else
            {
                this.WindowState = FormWindowState.Minimized; // Minimizar el formulario
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            AbrirConsultaExcel(dataGridViewIntervalos, "REPORTE - AVANCE DE ACTIVIDADES", "I");
        }

        public void AbrirConsultaExcel(DataGridView dgvConsulta, string sTitulo, string sLetraFinalTitulo)
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;
            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;
                //Get a new workbook.
                oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                oSheet.Cells[1, 2] = sTitulo;
                oSheet.get_Range("A1", sLetraFinalTitulo + "1").Merge(true);
                oSheet.get_Range("A1", sLetraFinalTitulo + "1").Font.Bold = true;
                oSheet.get_Range("A1", Type.Missing).VerticalAlignment =
                    Excel.XlVAlign.xlVAlignCenter;
                oSheet.get_Range("A1", Type.Missing).HorizontalAlignment =
                    Excel.XlVAlign.xlVAlignCenter;
                oSheet.get_Range("A1", "D1").Font.Size = 16;

                for (int i = 0; i < dgvConsulta.ColumnCount; i++)
                {
                    oSheet.Cells[2, i + 1] = dgvConsulta.Columns[i].HeaderText;
                }

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A2", "I2").Font.Bold = true;
                oSheet.get_Range("A2", "I2").VerticalAlignment =
                    Excel.XlVAlign.xlVAlignCenter;
                oSheet.get_Range("A2", "I2").HorizontalAlignment =
                    Excel.XlVAlign.xlVAlignJustify;
                // Create an array to multiple values at once.
                int fila = dgvConsulta.Rows.Count;
                int colum = dgvConsulta.Columns.Count;
                string[,] saNames = new string[fila, colum];

                for (int i = 0; i < fila; i++)
                {
                    for (int j = 0; j < colum; j++)
                    {
                        oSheet.Cells[i + 3, j + 1] = dgvConsulta[j, i].Value.ToString();
                    }
                }

                oRng = oSheet.get_Range("D:D");
                //oRng.NumberFormat = "_-$* #,##0.00_-;-$* #,##0.00_-;_-$* \" - \"??_-;_-@_-";
                oRng = oSheet.get_Range("A1", "I1");
                oRng.EntireColumn.AutoFit();
                oXL.Visible = true;
                oXL.UserControl = true;
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);
                // MessageBox.Show(errorMessage, "Error");
            }
        }
    }
}
