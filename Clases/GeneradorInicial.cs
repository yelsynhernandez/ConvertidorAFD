using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConvertidorAFD.Clases;

namespace ConvertidorAFD.Clases
{
    internal class GeneradorInicial
    {
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
                Configuraciones ct = new Configuraciones();
                DataGridViewTextBoxColumn columna;
                string estadoPreTransicion = "";
                string tituloColumna = "";

                this.cadenaTransiciones = cadenaTransiciones.Trim('{', '}');
                string expresionRegular = @"\(([^)]+)\)";

                MatchCollection coincidencias = Regex.Matches(cadenaTransiciones, expresionRegular);

                string[] transiciones = new string[coincidencias.Count];

                for (int i = 0; i < coincidencias.Count; i++)
                {
                    transiciones[i] = coincidencias[i].Groups[1].Value;
                }

                columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = "Estados";
                dgv.Columns.Add(columna);

                foreach (string cadena in alfabeto)
                {
                    columna = new DataGridViewTextBoxColumn();
                    columna.HeaderText = cadena;
                    dgv.Columns.Add(columna);
                }

                foreach (string estado in estados)
                {
                    dgv.Rows.Add(estado);
                }

                for (int fila = 0; fila < dgv.RowCount; fila++)
                {
                    estadoPreTransicion = dgv.Rows[fila].Cells[0].Value.ToString();
                    for (int col = 1; col < dgv.Columns.Count; col++)
                    {
                        tituloColumna = dgv.Columns[col].HeaderText;
                        dgv.Rows[fila].Cells[col].Value = EstablecerTransicion(estadoPreTransicion, tituloColumna, transiciones);
                    }
                    if (fila % 2 == 0)
                    {
                        dgv.Rows[fila].DefaultCellStyle.BackColor = Color.Silver;
                    }
                    else
                    {
                        dgv.Rows[fila].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
                ct.configurarTabla(dgv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string EstablecerTransicion(string _estado, string _alfabeto, string[] _transiciones)
        {
            string estado = "";
            try
            {
                string[] partesTransicion;

                foreach (string transicion in _transiciones)
                {
                    partesTransicion = transicion.Split(new char[] { ',' }, StringSplitOptions.TrimEntries);
                    if (partesTransicion[0] == _estado && partesTransicion[1] == _alfabeto)
                    {
                        estado = partesTransicion[2];
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

        public void iniciarConvertidor(DataGridView dgv)
        {
            Convertidor convertidor = new Convertidor(estados,alfabeto,cadenaTransiciones, estadoInicial);
            convertidor.ConvertirAFN(dgv);
        }
    }
}
