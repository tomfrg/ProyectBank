using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForm
{
    public class jsonClass
    {
        private static string _path = "D:\\Proyectos Programacion SSD\\BankForm\\JsonBank.json";
        public static void SerializeJSonFile(Usuario usuario)
        {
            try
            {
                // Crear el directorio si no existe
                string directory = Path.GetDirectoryName(_path);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                string usuarioJson = JsonConvert.SerializeObject(usuario);
                File.WriteAllText(_path, usuarioJson); // Guardar el JSON en el archivo
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo JSON: " + ex.Message);
            }
        }
        public static Usuario DeserializeJSonFile()
        {
            try
            {
                string usuarioJson = File.ReadAllText(_path); // Leer el JSON del archivo
                Usuario usuario = JsonConvert.DeserializeObject<Usuario>(usuarioJson);
                return usuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo JSON: " + ex.Message);
                return null;
            }
        }
    }

}
