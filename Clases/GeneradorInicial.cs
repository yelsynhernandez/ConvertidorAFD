using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConvertidorAFD.Clases;

namespace ConvertidorAFD.Clases
{
    internal class GeneradorInicial
    {
        List<List<string>> transiciones = new();
        List<List<string>> matrizAFN = new();
        string cadenaTransiciones = "";
        string[] ?estados;
        string[] ?alfabeto;
        string ?estadoInicial;
        
        public void ProcesarLinea(Label lblEstadoInicial,
                                  TextBox txtContenidoArchivo,
                                  TextBox txtEstados,
                                  TextBox txtAlfabeto,
                                  TextBox txtEstadosDeAceptacion,
                                  DataGridView dgvMatrizTransicion1,
                                  string linea
                                  )
        {
            if (linea.Length > 0)
            {
                char quintupla;
                string[] partes;

                txtContenidoArchivo.AppendText($"{linea}\r\n");

                partes = linea.Split(new string[] { ":" }, StringSplitOptions.None);
                quintupla = partes[0].ToCharArray()[0];

                switch (quintupla)
                {
                    case 'Q':
                        DividirCadena(partes[1], txtEstados, quintupla);
                        break;
                    case 'T':
                        DividirCadena(partes[1], txtAlfabeto, quintupla);
                        break;
                    case 'i':
                        estadoInicial = partes[1].Trim(' ');
                        lblEstadoInicial.Text = "Estado inicial: " + estadoInicial;
                        lblEstadoInicial.Visible = true;
                        break;
                    case 'A':
                        DividirCadena(partes[1], txtEstadosDeAceptacion, quintupla);
                        break;
                    case 'w':
                        cadenaTransiciones = partes[1];
                        GenerarTabla(cadenaTransiciones, dgvMatrizTransicion1);
                        break;
                }
            }
        }
        private void DividirCadena(string cadena, TextBox tx, char valorQuintupla)
        {
            try
            {
                cadena = cadena.Trim('{', '}', ' ');
                string[] valores = cadena.Split(new char[] { ',' }, StringSplitOptions.TrimEntries);
                switch (valorQuintupla)
                {
                    case 'Q':
                        estados = valores;
                        break;
                    case 'T':
                        alfabeto = valores;
                        break;
                }

                foreach (string valor in valores)
                {
                    if (valorQuintupla == 'A')
                    {
                        if (estados.Contains(valor))
                        {
                            tx.AppendText($"{valor}\r\n");
                        }
                        else
                        {
                            tx.AppendText($"{valor} - (Estado no definido)\r\n");
                        }
                    }
                    else
                    {
                        tx.AppendText($"{valor}\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarTabla(string cadenaTransiciones, DataGridView dgv)
        {
            try
            {
                Configuraciones ct = new ();
                DataTable dt = new();
                string estadoPreTransicion = "";
                string elementoColumna = "";
                transiciones = ObtenerTransiciones(cadenaTransiciones);

                matrizAFN.Add(new List<string> { "Estados" });
                foreach(string elemento in alfabeto)
                {
                    matrizAFN[0].Add(elemento);
                }

                foreach (string estado in estados)
                {
                    matrizAFN.Add(new List<string> { estado });
                }

                for (int fila = 1; fila < (transiciones.Count) - 1; fila++)
                {
                    estadoPreTransicion = matrizAFN[fila][0];
                    for (int columna = 1; columna < matrizAFN[0].Count; columna++)
                    {
                        elementoColumna = matrizAFN[0][columna];
                        matrizAFN[fila].Add(EstablecerTransicion(estadoPreTransicion, elementoColumna, transiciones));
                    }
                }

                dt = ct.DimensionarDataTable(matrizAFN);
                dgv.DataSource = dt;
                ct.ConfigurarTabla(dgv);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string EstablecerTransicion(string _estado, string _elemento, List<List<string>> _transiciones)
        {
            string estado = "";
            try
            {
                for (int fila = 0; fila < _transiciones.Count; fila++)
                {
                    if (_transiciones[fila][0] == _estado && _transiciones[fila][1] == _elemento)
                    {
                        estado = _transiciones[fila][2];
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estado;
        }

        private List<List<string>> ObtenerTransiciones(string cadena)
        {
            List<List<string>> lista = new List<List<string>>();
            try
            {
                string expresionRegular = @"\(([^)]+)\)";
                string coincidencia = "";
                cadena = cadena.Trim('{', '}');

                MatchCollection coincidencias = Regex.Matches(cadenaTransiciones, expresionRegular);

                for (int i = 0; i < coincidencias.Count; i++)
                {
                    coincidencia = coincidencias[i].Groups[1].Value;
                    string[] transicion = coincidencia.Split(new string[] { "," }, StringSplitOptions.None);
                    lista.Add(new List<string>() { transicion[0], transicion[1], transicion[2] });
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }


        public void iniciarConvertidor(DataGridView dgv)
        {
            Convertidor convertidor = new (estados,alfabeto,estadoInicial, transiciones);
            convertidor.ConvertirAFN(dgv);
        }
    }
}
