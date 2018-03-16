﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Presentacion.Programas
{
    public abstract class utilidades
    {
     
        public  class WinAPI
        {
            // Constantes para SetWindowsPos
            //   Valores de wFlags
            const int SWP_NOSIZE = 0x1;
            const int SWP_NOMOVE = 0x2;
            const int SWP_NOACTIVATE = 0x10;
            const int wFlags = SWP_NOMOVE | SWP_NOSIZE | SWP_NOACTIVATE;
            //   Valores de hwndInsertAfter
            const int HWND_TOPMOST = -1;
            const int HWND_NOTOPMOST = -2;
            //
            /// <summary>
            /// Para mantener la ventana siempre visible
            /// </summary>
            /// <remarks>No utilizamos el valor devuelto</remarks>
            [DllImport("user32.DLL")]
            private extern static void SetWindowPos(
                int hWnd, int hWndInsertAfter,
                int X, int Y,
                int cx, int cy,
                int wFlags);

            public static void SiempreEncima(int handle)
            {
                SetWindowPos(handle, HWND_TOPMOST, 0, 0, 0, 0, wFlags);
            }

            public static void NoSiempreEncima(int handle)
            {
                SetWindowPos(handle, HWND_NOTOPMOST, 0, 0, 0, 0, wFlags);
            }
        }
    
    public static bool esnumero(string comprueba)
        {

            double Numero; // Necesario pero nosotros no lo utilizamos
            if (comprueba == null) return false;// Comprobamos si es null

            return Double.TryParse(comprueba, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out Numero);

        }
        public static void ValidarNumero(ref TextBox textboxusado, EventArgs e)
        {
            if (!esnumero(textboxusado.Text))
            {
                textboxusado.Text = "0.00";
            }
            else
            {
                textboxusado.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(textboxusado.Text).ToString("N2"));
            }
        }
        public static void LogitudDeCampo(ref TextBox textboxusado, KeyPressEventArgs e, int cantidad)
        {
            if (textboxusado.Text.Length >= cantidad)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
        }
        public static void solonumeros(ref TextBox textboxusado, KeyPressEventArgs e)
        {


            char[] signodecimal = new char[] { (char)44, (char)46 };

            if (char.IsNumber(e.KeyChar) | e.KeyChar == (char)8) // Si es un numero o borrar

            {
                e.Handled = false; // No hacemos nada y dejamos que el sistema controle la pulsación de tecla

                return;
            }

            else if (e.KeyChar == (char)44 | e.KeyChar == (char)46) // Si es un . o una ,

            {

                // Si no hay caracteres

                // o

                // Si ya hay un punto o una coma

                // no dejamos poner la , o .

                if (textboxusado.Text.Length == 0 | textboxusado.Text.LastIndexOfAny(signodecimal) >= 0)

                {

                    e.Handled = true; // Interceptamos la pulsación para que no tenga lugar

                }

                else // Si hay caracteres continuamos las comprobaciones

                {

                    // Cambiamos la pulsación al separador decimal definido por el sistema

                    e.KeyChar = Convert.ToChar(System.Globalization.NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator);

                    // No es necesario pero como no cuesta mucho ponerlo e.Handled es false por defecto.

                    e.Handled = false; // No hacemos nada y dejamos que el sistema controle la pulsación de tecla

                }

                return;

            }

            else if (e.KeyChar == (char)13)
            {
                e.Handled = true;
//                textboxusado.Text = string.Format("{0:0,0.00}", Convert.ToDecimal(textboxusado.Text).ToString("N2"));
                SendKeys.Send("{TAB}");
            }
            else // Para el resto de las teclas
            {
                e.Handled = true; // Interceptamos la pulsación para que no tenga lugar
            }
        }
    }
}
