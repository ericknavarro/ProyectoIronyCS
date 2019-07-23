using ProyectoIronyCS.sol.com.analizador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIronyCS
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            string text = System.IO.File.ReadAllText("entrada.txt");
            Sintactico sintac = new Sintactico();
            sintac.analizar(text);
        }
    }
}
