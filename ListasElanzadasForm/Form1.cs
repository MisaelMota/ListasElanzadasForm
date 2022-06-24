using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasElanzadasForm
{
    public partial class Form1 : Form
    {

        public LinkedList<Form1> Lalumnos = new LinkedList<Form1>();
        public string Nombre { get; set; }


        public Form1()
        {
            InitializeComponent();
            btnAddFirst.Click += BtnAddFirst_Click;
            btnAddLast.Click += BtnAddLast_Click;
            btnMostrar.Click += BtnMostrar_Click;
            btnMoverFinal.Click += BtnMoverFinal_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnBuscar.Click += BtnBuscar_Click;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SiExisteAlumno();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EliminarAlumno();
        }

        private void BtnMoverFinal_Click(object sender, EventArgs e)
        {
            MoverAlumnosFinal();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            MostrarAlumnos();
        }

        private void BtnAddLast_Click(object sender, EventArgs e)
        {
            AgregarAlumnosLast();
        }

        private void BtnAddFirst_Click(object sender, EventArgs e)
        {
            AgregarAlumnosFirst();
        }

        public void AgregarAlumnosFirst()
        {
           
               Form1 alumno = new Form1();               
                           
               alumno.Nombre = txtName.Text;
               Lalumnos.AddFirst(alumno);
            dataGridView1.Rows.Clear();
            foreach (var item in Lalumnos)
            {
                dataGridView1.Rows.Add(
                  item.Nombre
                  );

            }


        }

        public void AgregarAlumnosLast()
        {
            Form1 alumno = new Form1();
            alumno.Nombre = txtName.Text;
            Lalumnos.AddLast(alumno);
            dataGridView1.Rows.Clear();
            foreach (var item in Lalumnos)
            {
                dataGridView1.Rows.Add(
                  item.Nombre
                  );

            }
        }


        public void MostrarAlumnos()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in Lalumnos)
            {
                dataGridView1.Rows.Add(
                  item.Nombre
                  );
            }



        }

        public void MoverAlumnosFinal()
        {
            Form1 alumno = new Form1();
            alumno.Nombre = txtName.Text;

            var cambiarAlumno = Lalumnos.FirstOrDefault(a => a.Nombre.Equals(alumno.Nombre));
            Lalumnos.Remove(cambiarAlumno);
            Lalumnos.AddLast(alumno);

            MostrarAlumnos();


        }

        public void EliminarAlumno()
        {
            Form1 alumno = new Form1();
            alumno.Nombre = txtName.Text;

            var cambiarAlumno = Lalumnos.FirstOrDefault(a => a.Nombre.Equals(alumno.Nombre));
            Lalumnos.Remove(cambiarAlumno);
            MostrarAlumnos();
        }


        public void SiExisteAlumno()
        {
            Form1 alumno = new Form1();
            string Nombre =txtName.Text;

         
            foreach (var item in Lalumnos)
            {
                if (Nombre==item.Nombre)
                {
                    dataGridView1.Rows.Clear();
                 dataGridView1.Rows.Add(
                 item.Nombre
                 );
                    break;

                }
                
            }

        }





    }
}
