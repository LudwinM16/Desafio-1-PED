using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PED_Desafio1
{
    public partial class Pacientes : Form
    {

        private ArbolClasificador arbolClasificador;
        private int contadorPacientes = 1;
        private const int radioNodo = 20;
        private const int distanciaHorizontal = 50;
        private const int distanciaVertical = 50;

        private Dictionary<Nodo<string>, Point> posicionesNodos;

        public Pacientes()
        {
            InitializeComponent();
            InicializarArbol();

            //no se utiliza
            posicionesNodos = new Dictionary<Nodo<string>, Point>();
            arbolClasificador = new ArbolClasificador();


            // Agregar nodos principales al árbol
            arbolClasificador.InsertarCategoria("Sangre");
            arbolClasificador.InsertarCategoria("Género");
            arbolClasificador.InsertarCategoria("Presión");
        }

        // Funcion para que se llame dibujar, no se usa

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DibujarArbol(e.Graphics);
        }



        //dibujae el arbol usando Graphics, no se usa 

        private void DibujarArbol(Graphics g)
        {
            if (arbolClasificador.Raiz != null)
            {
                DibujarNodo(g, arbolClasificador.Raiz, ClientSize.Width / 2, 50, 300);
            }
        }

      
        //Funcion no utilizada

       
        private void DibujarNodo(Graphics g, Nodo<string> nodo, int x, int y, int espacioHorizontal)
        {
            // Dibuja el nodo actual
            g.FillEllipse(Brushes.LightBlue, x - radioNodo, y - radioNodo, radioNodo * 2, radioNodo * 2);
            g.DrawEllipse(Pens.Black, x - radioNodo, y - radioNodo, radioNodo * 2, radioNodo * 2);
            g.DrawString(nodo.Valor, Font, Brushes.Black, x - radioNodo / 2, y - radioNodo / 2);

            // Dibuja los nodos hijos recursivamente
            foreach (var hijo in nodo.Hijos)
            {
                int xHijo = x + espacioHorizontal;
                int yHijo = y + distanciaVertical;
                g.DrawLine(Pens.Black, x, y + radioNodo, xHijo, yHijo - radioNodo);
                DibujarNodo(g, hijo, xHijo, yHijo, espacioHorizontal / 2);
            }
        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pacientes_Load(object sender, EventArgs e)
        {

        }



        private void InicializarArbol()
        {
            // Agregar el nodo raíz "Pacientes"
            treeView1.Nodes.Add("Pacientes");

            // Agregar las categorías como nodos hijos de la raíz
            TreeNode sangreNode = new TreeNode("Sangre");
            treeView1.Nodes[0].Nodes.Add(sangreNode);

            sangreNode.Nodes.Add("AB");
            sangreNode.Nodes.Add("A");
            sangreNode.Nodes.Add("B");
            sangreNode.Nodes.Add("O");

            TreeNode generoNode = new TreeNode("Genero");
            treeView1.Nodes[0].Nodes.Add(generoNode);

            generoNode.Nodes.Add("Femenino");
            generoNode.Nodes.Add("Masculino");

            TreeNode presionNode = new TreeNode("Presion");
            treeView1.Nodes[0].Nodes.Add(presionNode);

            presionNode.Nodes.Add("Alta");
            presionNode.Nodes.Add("Media");
            presionNode.Nodes.Add("Baja");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si se han seleccionado valores en los ComboBox
            if (comboBoxSangre.SelectedItem != null && comboBoxGenero.SelectedItem != null && comboBoxPresion.SelectedItem != null)
            {
                // Obtener los valores de las características desde los ComboBox
                string sangre = comboBoxSangre.SelectedItem.ToString();
                string genero = comboBoxGenero.SelectedItem.ToString();
                string presion = comboBoxPresion.SelectedItem.ToString();

                // Crear el nombre del paciente con el contador actual
                string nombrePaciente = "Paciente" + contadorPacientes;

                contadorPacientes++;

                // Buscar o crear nodo
                TreeNode sangreNode = BuscarOCrearNodo(treeView1.Nodes[0].Nodes[0], sangre);
                TreeNode generoNode = BuscarOCrearNodo(treeView1.Nodes[0].Nodes[1], genero);
                TreeNode presionNode = BuscarOCrearNodo(treeView1.Nodes[0].Nodes[2], presion);

                // Crear un nuevo nodo para el paciente
                TreeNode pacienteNode = new TreeNode(nombrePaciente);

                // Agregar el paciente como hijo del nodo de sangre, género y presión
                sangreNode.Nodes.Add((TreeNode)pacienteNode.Clone());
                generoNode.Nodes.Add((TreeNode)pacienteNode.Clone());
                presionNode.Nodes.Add((TreeNode)pacienteNode.Clone());

                // Agregar el paciente al ListBox
                listBoxPacientes.Items.Add(nombrePaciente);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un valor en cada uno de los ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private TreeNode BuscarOCrearNodo(TreeNode parentNode, string value)
        {
            foreach (TreeNode node in parentNode.Nodes)
            {
                if (node.Text == value)
                {
                    // Si el nodo ya existe, retornarlo
                    return node;
                }
            }

            // Si el nodo no existe, crear uno nuevo y retornarlo
            TreeNode newNode = new TreeNode(value);
            parentNode.Nodes.Add(newNode);
            return newNode;
        }


        // Crear nodos mediante Graphics, no se usa

       
        public class Nodo<T>
        {
            public T Valor { get; set; }
            public List<Nodo<T>> Hijos { get; set; }

            public Nodo(T valor)
            {
                Valor = valor;
                Hijos = new List<Nodo<T>>();
            }
        }
       

        // Clase paciente
        public class Paciente
        {
            public string Sangre { get; set; }
            public string Genero { get; set; }
            public string Presion { get; set; }
            public string Nombre { get; set; }

            public Paciente(string sangre, string genero, string presion, string nombre)
            {
                Sangre = sangre;
                Genero = genero;
                Presion = presion;
                Nombre = nombre;
            }
        }

        // No se Utiliza

      
        public class ArbolClasificador
        {
            public Nodo<string> Raiz { get; set; }

            public ArbolClasificador()
            {
                Raiz = new Nodo<string>("Pacientes");
                Raiz.Hijos.Add(new Nodo<string>("Genero"));
                Raiz.Hijos.Add(new Nodo<string>("Sangre"));
                Raiz.Hijos.Add(new Nodo<string>("Presion"));
            }

            public void InsertarPaciente(Paciente paciente)
            {
                // Insertar paciente bajo la categoría correspondiente
                // Insertar paciente bajo la categoría correspondiente
                Insertar(paciente.Genero, "Genero", paciente.Nombre);
                Insertar(paciente.Sangre, "Sangre", paciente.Nombre);
                Insertar(paciente.Presion, "Presion", paciente.Nombre);
            }

            private void Insertar(string valor, string categoria, string nombrePaciente)
            {
                // Buscar la categoría en los nodos hermanos de la raíz
                foreach (var hermano in Raiz.Hijos)
                {
                    if (hermano.Valor == categoria)
                    {
                        // Agregar el paciente como un nuevo hijo del nodo de la categoría
                        hermano.Hijos.Add(new Nodo<string>(valor) { Hijos = { new Nodo<string>(nombrePaciente) } });
                        return;
                    }
                }

                // Si la categoría no se encuentra, agregarla como un nuevo nodo hermano de la raíz
                Raiz.Hijos.Add(new Nodo<string>(categoria) { Hijos = { new Nodo<string>(valor) { Hijos = { new Nodo<string>(nombrePaciente) } } } });
            }
            public void InsertarCategoria(string categoria)
            {
                Raiz = InsertarRecursivo(Raiz, categoria, categoria, "");
            }

           

            private Nodo<string> InsertarRecursivo(Nodo<string> nodo, string valor, string categoria, string nombrePaciente)
            {
                if (nodo == null)
                {
                    nodo = new Nodo<string>(categoria); // Creamos un nuevo nodo para la categoría
                    nodo.Hijos.Add(new Nodo<string>(valor) { Hijos = { new Nodo<string>(nombrePaciente) } }); // Insertamos el paciente como hijo de la categoría
                }
                else if (nodo.Valor == categoria)
                {
                    nodo.Hijos.Add(new Nodo<string>(valor) { Hijos = { new Nodo<string>(nombrePaciente) } }); // Insertamos el paciente como hijo de la categoría
                }
                else
                {
                    // Buscamos en los hijos del nodo la categoría adecuada para insertar el paciente
                    foreach (var hijo in nodo.Hijos)
                    {
                        if (hijo.Valor == categoria)
                        {
                            hijo.Hijos.Add(new Nodo<string>(valor) { Hijos = { new Nodo<string>(nombrePaciente) } }); // Insertamos el paciente como hijo de la categoría
                            break;
                        }
                    }
                }

                return nodo;
            }
        }

      

        //Eliminar Paciente
        private void button2_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un nodo de paciente en el TreeView
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.Parent != null)
            {
                // Obtener el nombre del paciente seleccionado
                string nombrePaciente = treeView1.SelectedNode.Text;

                // Eliminar el nodo de paciente seleccionado del árbol
                treeView1.SelectedNode.Remove();

                // Eliminar el paciente del ListBox
                listBoxPacientes.Items.Remove(nombrePaciente);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un paciente para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
