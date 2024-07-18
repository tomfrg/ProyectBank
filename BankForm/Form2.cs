using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonRegisterUser_Click(object sender, EventArgs e)
        {
            //string user = textBoxUserRegister.Text;
            //string pass = textBoxPassRegister.Text;
            string name = "tomas";
            string pass = "123";

            Usuario usuario = new Usuario(name, pass);
            jsonClass.SerializeJSonFile(usuario);
            //this.Close();
            try
            {
                usuario = jsonClass.DeserializeJSonFile();
                listBoxUsuarios.Items.Clear(); // Limpiar el ListBox antes de agregar nuevos ítems
                listBoxUsuarios.Items.Add($"Name: {usuario.Name}");
                listBoxUsuarios.Items.Add($"Pass: {usuario.Pass}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deserializar el archivo JSON: " + ex.Message);
            }
        }
    }
}
