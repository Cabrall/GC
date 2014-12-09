using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteros.Negocio
{
    class Entero
    {
        int numeroentero;

        public Entero()
        {

        }

        public Entero(int numero)
        {

            numeroentero = numero;

        }


        public void set(int numero)
        {
            numeroentero = numero;
        }

        public int get()
        {
            return numeroentero;
        }

        //////////////////////////////////////////////...................


        public bool EsPar()
        {

            return numeroentero % 2 == 0;

        }

        public bool EsImpar()
        {

            return numeroentero % 2 != 0;

        }

        /// Yasmany \\\\\\\
       
        public bool esPrimo()
        { // many \\
            Int32 Count = 0;
            if (numeroentero == 1 || numeroentero == 0)
                return false;
            for (Int32 i = 1; i <= numeroentero; i++)
            {
                if (numeroentero % i == 0)
                {
                    Count++;
                    if (Count > 2)
                        return false;
                }

            }
            return true;
        }
        public Int32 mostrarPrimos()
        { // many \\
            Int32 mod = 0;
            Int32 result = 0;
            while (numeroentero > 0)
            {
                mod = numeroentero % 10;
                numeroentero = numeroentero / 10;
                if (esPrimo(mod))
                {
                    result = result * 10 + mod;
                }
            }
            return invertir(result);

        }
        public Int32 eliminarPrimos()
        { // many \\
            Int32 mod = 0;
            Int32 result = 0;
            while (numeroentero > 0)
            {
                mod = numeroentero % 10;
                numeroentero = numeroentero / 10;
                if (!esPrimo(mod))
                {
                    result = result * 10 + mod;
                }
            }
            return invertir(result);

        }
        public Int32 invertir()
        { // many \\
            Int32 mod = 0;
            Int32 result = 0;
            while (numeroentero > 0)
            {
                mod = numeroentero % 10;
                numeroentero = numeroentero / 10;
                result = result * 10 + mod;
            }
            return result;
        }
        public bool esCapicua()
        {
            Int32 capicua = numeroentero;
            if (capicua == invertir())
                return true;
            else
                return false;
        }
        public Int32 cantidadDigitos()
        { // many \\      
            Int32 result = 0;
            if (numeroentero != 0)
            {
                while (numeroentero > 0)
                {
                    numeroentero = numeroentero / 10;
                    result++;
                }
                return result;
            }
            else
                return 1;

        }
        public Int32 cantidadDigitosPrimo()
        {// many \\  
            Int32 cantidad = 0;
            Int32 mod = 0;
            while (numeroentero > 0)
            {
                mod = numeroentero % 10;
                numeroentero = numeroentero / 10;
                if (this.esPrimo(mod))
                    cantidad++;
            }
            return cantidad;

        }
        public String cantidadDigitosParImpar()
        {// many \\  
            Int32 par = 0;
            Int32 impar = 0;
            Int32 mod = 0;

            if (numeroentero == 0)
                par++;
            while (numeroentero > 0)
            {
                mod = numeroentero % 10;
                numeroentero = numeroentero / 10;
                if (mod % 2 == 0)
                    par++;
                else
                    impar++;

            }
            return "Par: " + par + "  Impar: " + impar;
        }
        public Int32 PromedioPar() {
            Int32 n = numeroentero;
            n = this.obtenerPares(n);
            set(n);
            return  this.sumarDigitos(n)/cantidadDigitos();    
        }
        public string enletras()
        {// many \\  
            Int64 num = numeroentero;
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
            }

            res = toText(Convert.ToDouble(entero)) + dec;
            return res;
        }

        ////////METODOS PRIVADOS \\\\\\\\\\\\\
        private bool esPrimo(Int32 n)
        { // many \\
            Int32 Count = 0;
            if (n == 1 || n == 0)
                return false;
            for (Int32 i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Count++;
                    if (Count > 2)
                        return false;
                }

            }
            return true;
        }
        private Int32 invertir(Int32 n)
        { // many \\
            Int32 mod = 0;
            Int32 result = 0;
            while (n > 0)
            {
                mod = n % 10;
                n = n / 10;
                result = result * 10 + mod;
            }
            return result;
        }
        private Int32 cantidadPar(Int32 n) {
            Int32 cantidad = 0;
            Int32 mod = 0;
            if (n == 0)
                cantidad++;
            while (n > 0)
            {
                mod = n% 10;
                n = n / 10;
                if (mod % 2 == 0)
                    cantidad++;
            }
            return cantidad;
        }
        private Int32 obtenerPares(Int32 n) {
            Int32 pares = 0;
            Int32 mod = 0;
            if (n == 0)
                pares++;
            while (n > 0)
            {
                mod = n % 10;
                n = n / 10;
                if (mod % 2 == 0)
                    pares =pares  * 10 + mod;
            }
            return this.invertir(pares);
        }
        private Int32 sumarDigitos(Int32 n) {
            Int32 suma = 0;
            Int32 mod = 0;
            if (n == 0)
                suma++;
            while (n > 0)
            {
                mod = n % 10;
                n = n / 10;
                suma=suma+mod;
            }
            return suma;
        
        }
        private string toText(double value)
        {// many \\  
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;

        }
    }
}

