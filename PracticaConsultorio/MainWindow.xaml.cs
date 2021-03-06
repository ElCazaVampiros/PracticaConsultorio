﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaConsultorio {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnNuevoPaciente_Click(object sender, RoutedEventArgs e) {
            Paciente nuevoPaciente = new Paciente();
            nuevoPaciente.Nombre = txtNombre.Text;
            nuevoPaciente.Direccion = txtDireccion.Text;
            nuevoPaciente.Telefono = txtDireccion.Text;
            nuevoPaciente.Edad = int.Parse(txtEdad.Text);
            nuevoPaciente.Altura = float.Parse(txtAltura.Text);
            nuevoPaciente.Peso = float.Parse(txtPeso.Text);
            nuevoPaciente.EnfermedadesCronicas = txtEnfermedadesCronicas.Text;

            Datos.pacientes.Add(nuevoPaciente);
            actualizarListaPacientes();

            gridNuevoPaciente.Visibility = Visibility.Collapsed;
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEdad.Text = "";
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtEnfermedadesCronicas.Text = "";
        }

        private void actualizarListaPacientes() {
            lstPacientes.Items.Clear();
            foreach (Paciente paciente in Datos.pacientes) {
                lstPacientes.Items.Add(new ListBoxItem() {
                    Content = paciente.Nombre
                });
            }
        }

        private void btnCrearNuevoPaciente_Click(object sender, RoutedEventArgs e) {
            gridNuevoPaciente.Visibility = Visibility.Visible;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
