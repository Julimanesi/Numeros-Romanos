using System;
using System.Windows.Forms;

namespace Numeros_Romanos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int nro;
        private void ingreso(object sender, EventArgs e)
        {
            nro = (int)numero.Value;
            palabra_sal.Text = funcion2(nro);
        }

       

        private string funcion2(int nro)
        {
            int milena, nrores;
            string conc;
            string[] mil = { "M", "MM", "MMM"};
            conc = "";
            milena = nro / 1000;
            if (milena > 0) {  conc +=mil[milena-1] ; }
            nrores = nro - (milena * 1000);
            conc += funcion(nrores);
            return conc;
        }
        /// <summary>
        /// toma un número como parametro que es menor a 100
        /// y devuelve el nro en forma coloquial
        /// </summary>
        /// <param name="nro"></param>
        /// <returns></returns>
        private string funcion(int nro)
        {
            int unidad, decena, centena;
            string[] unidades = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] centenas = { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] decenas1 = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string conc;
            conc = "";
            centena = nro / 100;
            decena = (nro - (centena * 100)) / 10;//primero separo el nro en unidades, decenas y centenas
            unidad = nro - (centena * 100 + decena * 10);
            if (centena > 0) {conc += centenas[centena-1]; }
            switch (decena)
            {
                case 0: if (unidad == 0) { return conc; }
                    else
                    {
                        conc += unidades[unidad - 1]; return conc;
                    }
                    break; //  si no hay decenas muestro unidades solas
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    if (unidad == 0)
                    {
                        conc += decenas1[decena - 1];
                        return conc;
                    }// si las decenas no tienen unidad  tambien las muestro solas
                    else
                    {         // si no concateno 
                        conc += decenas1[decena - 1];
                        conc += unidades[unidad - 1];
                        return conc;
                    }
                default: return conc;
            }

        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }

        }
        /// <summary>
        /// Ingresa un numero romano en caracteres y devuelve el numero 
        /// en decimal
        /// </summary>
        private void IngresoRomano(object sender, EventArgs e)
        {
            string romano = NumRomano.Text;
            Num_sal.Text = funcRom(romano);
        }
        private string funcRom(string romano)
    {
        int i = romano.Length - 1, num = 0;
        string Error = "Error. La expresión ingresada es ilegal";
        if(IngresoErroneo(romano))
            return Error;
        if(romano.Length>0)
        num += Conv(romano[romano.Length-1]); 
       
        for (i = romano.Length-1; i>0; i--)
        {
            if (Conv(romano[i]) > Conv(romano[i-1]))
                num -= Conv(romano[i - 1]);
            else
                num += Conv(romano[i - 1]);
        }
        
        return num.ToString();
        
    }



        /// <summary>
        /// devuelve el numero correspondiente a la letra
        /// en romano
        /// </summary>
        /// <param name="letra"></param>
        /// <returns></returns>
        private int Conv(char letra)
        {
            
            switch (letra)
            {
                case 'I':
                case 'i': return 1;
                case 'V':
                case 'v': return 5;
                case 'X':
                case 'x': return 10;
                case 'L':
                case 'l': return 50;
                case 'C':
                case 'c': return 100;
                case 'D':
                case 'd': return 500;
                case 'M':
                case 'm': return 1000;
                default: return 0;
            }
        }

        private bool IngresoErroneo(string romano)
        {
            int i;
            romano.ToUpper();
            for (i = 0; i < romano.Length-3; i++)
            {
                if (romano.Length > 3)
                {
                    if (romano[i] == romano[i + 1] && romano[i + 2] == romano[i + 3] && romano[i + 1] == romano[i + 2])
                        return true;
                }
            }
            for (i = 0; i < romano.Length; i++)
            {
                if (romano[i] != 'I' && romano[i] != 'V' && romano[i] != 'X' && romano[i] != 'L' && romano[i] != 'D' && romano[i] != 'C' && romano[i] != 'M' && romano[i] != 'i' && romano[i] != 'v' && romano[i] != 'x' && romano[i] != 'l' && romano[i] != 'c' && romano[i] != 'd' && romano[i] != 'm')
                    return true;
            }
            for (i = 0; i < romano.Length - 1; i++)
            {
                
                if (romano.Length > 1)
                {
                    if ((romano[i] == 'V' || romano[i] == 'L' || romano[i] == 'D' || romano[i] == 'v' || romano[i] == 'l' || romano[i] == 'd') && romano[i] == romano[i + 1])
                        return true;
                    if ((romano[i] == 'I' || romano[i] == 'i') && (romano[i + 1] != 'I' && romano[i + 1] != 'X' && romano[i + 1] != 'V' && romano[i + 1] != 'x' && romano[i + 1] != 'i' && romano[i + 1] != 'v'))
                        return true;
                    if ((romano[i] == 'X' || romano[i] == 'x') && (romano[i + 1] == 'D' || romano[i + 1] == 'd' || romano[i + 1] == 'm' || romano[i + 1] == 'M'))
                        return true;
                }
                
            }
            return false;
        }

        private void ingreso(object sender, KeyPressEventArgs e)
        {
            nro = (int)numero.Value;
            palabra_sal.Text = funcion2(nro);
        }
    }
}
