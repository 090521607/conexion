using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPEXAMEN.Models
{
    internal class datos
    {
        futbolEntities db;
         public void crear(object  numero)

        {
            try
            {



                using (db = new futbolEntities())
                {
                    object value = (numero);
                    db.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   
        public List<object >Read()
        {
            try
            {
                using (db = new futbolEntities())
                {
                    return (List<object>)db.numero;
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public List<object> buscar(int num)
        {
            try
            {
                using (db = new futbolEntities())
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return null;
            }
        }


    }
}
