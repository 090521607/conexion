using conexion.presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPEXAMEN.Models;



namespace WPEXAMEN
{
    public partial class Form1 : Form
    {
        private object ojugadores;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttondatos_Click(object sender, EventArgs e)
        {
            using (Models.futbolEntities db = new Models.futbolEntities())
            {
                dataGridViewdatos.DataSource = db.tb_jugadores.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refrescar();
        }
        #region
        private void refrescar()
        {
            using (futbolEntities db = new futbolEntities())
            {
                var lst = from d in db.tb_jugadores
                          select d;
                dataGridViewdatos.DataSource = lst.ToList();
            }
        }
        #endregion
        private int? GetId()
        {
            try
            {
               return int.Parse(dataGridViewdatos.Rows[dataGridViewdatos.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }
        private void buttonnuevo_Click(object sender, EventArgs e)
        {
            FrmTabla oFrmTabla = new FrmTabla();
            oFrmTabla.ShowDialog();

            refrescar();
        }

        private void buttoneditar_Click(object sender, EventArgs e)
        {
            int Id = (int)GetId();
            if(Id !=null)
            {
                FrmTabla oFrmTabla = new FrmTabla(Id);
                oFrmTabla.ShowDialog();

                refrescar();
            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            int Id = (int)GetId();
            if (Id != null)
            {
                using(futbolEntities db= new futbolEntities())
                {
                    tb_jugadores otb_jugadores = db.tb_jugadores.Find(Id);
                    db.tb_jugadores.Remove(otb_jugadores);
                    db.SaveChanges();
                }
            

                refrescar();
            }
        }
        public List<tb_jugadores> buscarnumero(int Id)
        {
            try
            {
                using(futbolEntities db =  new futbolEntities())
                {
                    return db.tb_jugadores.Where(p => p.idjugador == Id).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            if (textBoxbusc.Text != String.Empty)
            {
                var Lst = buscarnumero(Convert.ToInt32(textBoxbusc.Text));
                dataGridViewdatos.DataSource = Lst;
            }
        }
    }
}
