// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 01/07/2016.                                                                              *
// ******************************************************************************************


using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using System.Drawing;
using ObjetoRemoto;
using System.Data;
using System.Linq;
using System.Text;
using System;

namespace Cliente
{
    public partial class Cliente : Form
    {
        //referencia a la libreria de clases y al objeto remoto
        ObjetoRemoto.ObjetoRemoto objetoremotoUsario = new ObjetoRemoto.ObjetoRemoto();
        //Lista que me permitiran recibir los datos
        List<Piezas> recibir = new List<Piezas>();

        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            //Carga el ID autonomerado, funcion de inicio de formulario y limpiar los campos de ser necesario
            CargarIdentificador();
            iniciarFormulario();
            limpiarCampos();
        }

        public void iniciarFormulario()
        {
            //Bloquenado cierto elementos del formulario
            txtDescripcion.Enabled = true;
            txtNombre.Enabled = true;
            txtCosto.Enabled = true;
            txtBuscar.Enabled = true;
            boton_Agregar.Enabled = true;
            boton_Mostrar.Enabled = true;
            boton_Buscar.Enabled = true;
            boton_Modificar.Enabled = false;
            boton_Eliminar.Enabled = false;
        }

        public void CargarIdentificador()
        {
            //Llamando al objeto remoto que hara la consulta para crear un ide auto numerado
            objetoremotoUsario.obtenerrID(0);
            txtID.Text = Convert.ToString(objetoremotoUsario.idenfificadorUsuario + 1);
        }

        public void cargarDatos()
        {
            //Recibiendo un lista con todos los datos de la tabla y presentarlos en el datagrudview
            objetoremotoUsario.mostarTodos(recibir);
            foreach (Piezas item in recibir)
            {
                dataGridView_Datos.DataSource = objetoremotoUsario.mostarUsuarios.Select(x => x).Select(y => new
                {
                    ID = y.Id,
                    NOMBRE = y.Nombre_Pieza,
                    DESCRIPCION = y.Descripcion,
                    COSTO = y.Costo
                }).ToList();
            }
            dataGridView_Datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            recibir.Clear();
        }

        public void buscarID()
        {
            //Recibiendo los datos de la consulta
            objetoremotoUsario.buscarID(recibir);
            //Recorriendo la lista para presentarla en el dfatgridview
            foreach (Piezas item in recibir)
            {
                dataGridView_Datos.DataSource = objetoremotoUsario.mostarUsuarios.Select(x => x).Select(y => new
                {
                    ID = y.Id,
                    NOMBRE = y.Nombre_Pieza,
                    DESCRIPCION = y.Descripcion,
                    COSTO = y.Costo
                }).ToList();
            }

            //Funcionalidad para verificar si existen datos en la consulta
            if (recibir.Count() > 0)
            {
                dataGridView_Datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
                recibir.Clear();
                dataGridView_Datos.ClearSelection();
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("No hubo resultados en la busqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                limpiarCampos();
            }
        }

        public void eliminarDatos()
        {
            //Recieviendo la nueva lista sin el usario eliminado
            objetoremotoUsario.eliminarCliente(recibir);
            foreach (Piezas item in recibir)
            {
                //Recorriendo la lista recibida y presentandola en el data grid view
                dataGridView_Datos.DataSource = objetoremotoUsario.mostarUsuarios.Select(x => x).Select(y => new
                {
                    ID = y.Id,
                    NOMBRE = y.Nombre_Pieza,
                    DESCRIPCION = y.Descripcion,
                    COSTO = y.Costo
                }).ToList();
            }
            dataGridView_Datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            recibir.Clear();
        }

        public void modificarDatos()
        {
            //reciviwndo la lista para la modificacion de los elemntos
            objetoremotoUsario.modificarCliente(recibir);
            foreach (Piezas item in recibir)
            {
                //recorriendo la lista para agregar los datos al datagridview
                dataGridView_Datos.DataSource = objetoremotoUsario.mostarUsuarios.Select(x => x).Select(y => new
                {
                    ID = y.Id,
                    NOMBRE = y.Nombre_Pieza,
                    DESCRIPCION = y.Descripcion,
                    COSTO = y.Costo
                }).ToList();
            }
            dataGridView_Datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            recibir.Clear();
        }

        public void agregarDatos()
        {
            //recieviendo la lista con los nuevos usuarios
            objetoremotoUsario.agregarCliente(recibir);
            foreach (Piezas item in recibir)
            {
                //Recorriendo la lista para agregar los datos al data gridview
                dataGridView_Datos.DataSource = objetoremotoUsario.mostarUsuarios.Select(x => x).Select(y => new
                {
                    ID = y.Id,
                    NOMBRE = y.Nombre_Pieza,
                    DESCRIPCION = y.Descripcion,
                    COSTO = y.Costo
                }).ToList();
            }
            dataGridView_Datos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            recibir.Clear();
        }

        public void limpiarCampos()
        {
            //Me permitira limpiar los textbox y cargando el ID
            txtDescripcion.Clear();
            txtNombre.Clear();
            txtBuscar.Clear();
            txtNombre.Focus();
            txtCosto.Clear();
            CargarIdentificador();
        }

        private void boton_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text == "" || txtNombre.Text == "" || txtCosto.Text == "")
                {
                    //Control de los textbox no esten vacios
                    MessageBox.Show("Debe ingresar todos los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //Se agregara un nuevo cliente en la base de datos usando el objeto remoto
                    //Se enviaran los parametros al objeto remoto para la agregacion del nuevo usuarip
                    objetoremotoUsario.idenfificadorUsuario = Convert.ToInt32(txtID.Text);
                    objetoremotoUsario.nombre = txtNombre.Text;
                    objetoremotoUsario.descripcion = txtDescripcion.Text;
                    objetoremotoUsario.costo = Convert.ToInt32(txtCosto.Text);
                    agregarDatos();
                    dataGridView_Datos.ClearSelection();
                    //limpiando los diferentes campos
                    limpiarCampos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar los datos debido a un error.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void boton_Modificar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Seguro desea modificar el elemnto?", "Confirmacion", MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.Yes)
            {
                //Modificacion de un cliente existente
                //Se enviaran los datos al objeto remoto con los nuevos datos a actualizar
                objetoremotoUsario.identificadorModidifcar = Convert.ToInt32(txtID.Text);
                objetoremotoUsario.nombre = txtNombre.Text;
                objetoremotoUsario.descripcion = txtDescripcion.Text;
                objetoremotoUsario.costo = Convert.ToInt32(txtCosto.Text);
                //Codigo que me permite la modificacion de los parametros del elemento seleccionado
                modificarDatos();
                //Mostrando los datos en el datagridview
                cargarDatos();
                limpiarCampos();
                iniciarFormulario();
                dataGridView_Datos.ClearSelection();
            }
            else
            {
                return;
            }
        }

        private void boton_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Seguro desea eliminar el elemnto?", "Confirmacion", MessageBoxButtons.YesNo);
            if (pregunta == DialogResult.Yes)
            {
                //Si la respuesta es si se eliminara el cliente de la base de datos
                //Se  llama a la liberia de clases y al objeto remoto para hacer la eliminacion del cliente
                //Limpiar los campo y cargar la nueva informacion
                objetoremotoUsario.idenfificadorUsuario = Convert.ToInt32(txtID.Text);
                eliminarDatos();
                cargarDatos();
                limpiarCampos();
                CargarIdentificador();
                iniciarFormulario();
                dataGridView_Datos.ClearSelection();
            }
            else
            {
                return;
            }
        }

        private void boton_Mostrar_Click(object sender, EventArgs e)
        {
            //Me permite mostrar todos los elemntos dentro de la tabla Piezas en la la base de datos, mostrarlos en
            //el datagridview y limpiar los campos
            CargarIdentificador();
            cargarDatos();
            limpiarCampos();
        }

        private void boton_Buscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                //mensaje de advertencia si el cuadro esta vacio
                MessageBox.Show("Debe ingresar el ID para la busqueda", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    //Lamando a la libreria de clases y al objeto remoto para poder hacer la consulta de un id especifico
                    objetoremotoUsario.identificadorBusqueda = Convert.ToInt32(txtBuscar.Text);
                    //Lamando al metodo para cargar el identificador en el formulario
                    CargarIdentificador();
                    buscarID();
                    limpiarCampos();
                }
                catch (Exception)
                {
                    //Mensaje de excepcion
                    MessageBox.Show("No se pudo buscar los datos debido a un error.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Metodo para limpiar los campos
                    limpiarCampos();
                }
            }
        }

        private void dataGridView_Datos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Pasando los datos a los textbox despues de seleccionar en el datagridview
            txtID.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescripcion.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCosto.Text = dataGridView_Datos.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Codigo que solo permite el ingreso de caracteres
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Codigo que solo permite el ingreso de caracteres
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Codigo que permite solo ingreso de numeros en el textbox
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Codigo que permite solo ingreso de numeros en el textbox
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void dataGridView_Datos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Verificando que haya elemntos seleccionados
            if (dataGridView_Datos.SelectedCells.Count > 0)
            {
                boton_Modificar.Enabled = true;
                boton_Eliminar.Enabled = true;
                boton_Agregar.Enabled = false;
                boton_Mostrar.Enabled = false;
                boton_Buscar.Enabled = false;
            }
            else
            {
                //mensaje de advertencia si no hay elementos seleccionados
                MessageBox.Show("Debe seleccionar un elemento para modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void groupBox_ingresoDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}