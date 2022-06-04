using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conexion;


namespace conexion.presentacion
{
    public partial class FrmTabla : Form
    {
        public int? Id;
        tb_jugadores otb_jugadores= null;
        public FrmTabla(int? id=null)
        {
            InitializeComponent();
            this. Id = Id;
     
        }
      



        private void button1_Click_1(object sender, EventArgs e)
        {
            using (futbolEntities db = new futbolEntities())
            {
               tb_jugadores otb_jugadores = new tb_jugadores();
                otb_jugadores.numero = textnumero.Text.Length;
                otb_jugadores.nombre = textnombre.Text;
                otb_jugadores.fecha = dtpFecha.Value;
                otb_jugadores.nacionalidad = textnacionalidad.Text;
                otb_jugadores.pie = textpie.Text;
                otb_jugadores.puesto = txtpuesto.Text;
                otb_jugadores.altura = textaltura.Text;
                otb_jugadores.valor = textvalor.Text;
                otb_jugadores.goles = textgoles.Text.Length;
                otb_jugadores.tarjetas = texttarjetas.Text.Length;


                tb_jugadores tb_jugadores = db.tb_jugadores.Add(otb_jugadores);
               
                   
                
                db.SaveChanges();
                MessageBox.Show("GUARDADO");
                this.Close();


            }
        }

       
    }
}
