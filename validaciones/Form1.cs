using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace validaciones
{
    public partial class Form1 : Form
    {

        ValidarCajas validacion = new ValidarCajas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidacion_Click(object sender, EventArgs e)
        {
            //------------------------------- codigo de validacion 
            if (!validacion.Vacio(nombreIn, errorM, "El nombre no puede ser vacio"))
                if(validacion.TipoTexto(nombreIn,errorM,"Debe digitar texto"))
                    if (!validacion.Vacio(codigoIn, errorM, "El codigo  no puede ser vacio"))
                       if(validacion.TipoNumero(codigoIn, errorM, "Debe digitar numeros"))
                            if (!validacion.Vacio(correoIn, errorM, "El correo  no puede ser vacio"))
                                if (validacion.TipoCorreo(correoIn, errorM, "El correo no  cumple con el formato"))
                                    { 
                                        salida.Text = "todos los valores esta llenos";
                                        limpiarCajas();
                                       }
                       



            //----------------------------------------------------
        }

        // funcion para limpiar las cajas de texto 
        private void limpiarCajas()
        {
            nombreIn.Clear();
            codigoIn.Clear();
            correoIn.Clear();
        }

        private void btnValPass_Click(object sender, EventArgs e)
        {
            if (!validacion.Vacio(passwordIn, errorM, "el password no puede ser vacio"))
                // aplicarle un regla de password ----- expresion regular 
                salida.Text = " password digitado";
        }
    }
}
