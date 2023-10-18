using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics.Contracts;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConvertidorAFD.Clases
{
    internal class Convertidor
    {
        private string[] estados { get; set; }
        private string[] alfabeto { get; set; }
        private string estadoInicial;
        private readonly List<List<string>> transiciones = new List<List<string>>();
        private List<List<string>> matrizAFD = new List<List<string>>();
        public Convertidor(string[] _estados,
                           string[] _alfabeto,
                           string _estadoInicial,
                           List<List<string>> _transiciones)
        {
            this.estados = _estados;
            this.alfabeto = _alfabeto;
            this.estadoInicial = _estadoInicial;
            this.transiciones = _transiciones;
        }

        public void ConvertirAFN(DataGridView dgvResultado)
        {
            try {
                int indiceAscii = 65;
                int estadosGenerados = 0;
                int estadosRecorridos = 1;
                int columnaComposicion = 0;
                string cadenaEstados = "";
                string elemento = "";
                string estadoU = "";
                string estadosMueve;
                string estadosEpsilon;
                string U; 

                Configuraciones ct = new();
                DataTable dt = new();

                AgregarFilaMatriz(matrizAFD, "Estados", "Composición" ,true);

                cadenaEstados = string.Join(",", estados);
                AgregarFilaMatriz(matrizAFD, ((char)indiceAscii).ToString(), $"{estadoInicial},{EvaluarTransiciones(cadenaEstados, "e")}", false);
                estadosGenerados++;
                indiceAscii++;

                columnaComposicion = matrizAFD[0].Count - 1;

                while (estadosRecorridos <= estadosGenerados)
                {
                    for (int columna = 0; columna < alfabeto.Length; columna++) 

                    {
                        elemento = alfabeto[columna];

                        estadosMueve = EvaluarTransiciones(matrizAFD[estadosRecorridos][columnaComposicion],elemento);
                        if(!String.IsNullOrEmpty(estadosMueve))
                        {
                            estadosEpsilon = EvaluarTransiciones(estadosMueve, "e");
                            U = UnirElementos(estadosMueve, estadosEpsilon);
                        }
                        else
                        {
                            U = "N";
                        }

                        estadoU = BuscarU(U,columnaComposicion);

                        if (String.IsNullOrEmpty(estadoU))
                        {
                            estadoU = ((char)indiceAscii).ToString();
                            AgregarFilaMatriz(matrizAFD, estadoU, U, false);
                            estadosGenerados++;
                            indiceAscii++;
                            matrizAFD[estadosRecorridos][columna + 1] = estadoU;
                        }
                        else
                        {
                            matrizAFD[estadosRecorridos][columna + 1] = estadoU;
                        }
                    }
                    estadosRecorridos++;
                }

                //foreach (string nombreColumna in matrizAFD[0])
                //{
                //    dt.Columns.Add(nombreColumna);
                //}

                //for (int fila = 1; fila < matrizAFD.Count; fila++) 
                //{
                //    dt.Rows.Add(matrizAFD[fila].ToArray());
                //}
                dt = ct.DimensionarDataTable(matrizAFD);
                dgvResultado.DataSource = dt;
                ct.ConfigurarTabla(dgvResultado);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string EvaluarTransiciones(string cadenaComposicion, string elemento)
        {
            string resultado = "";
            string[] estados = cadenaComposicion.Split(new String[] { "," }, StringSplitOptions.None);

            foreach (string estado in estados)
            {
                for (int fila = 0; fila < transiciones.Count; fila++)
                {
                    if (transiciones[fila][0] == estado && transiciones[fila][1] == elemento)
                    {
                        resultado += $"{transiciones[fila][2]},";
                    }
                }
            }
            resultado = (resultado.Length > 0 ? resultado.Remove(resultado.Length - 1): "") ;
            return resultado;
        }

        private static string UnirElementos(string transicionesElementos, string transicionesEpsilon)
        {
            string resultado = "";
            string[] arrayElementos;
            string[] arrayEpsilon;
            string[] arrayFinal;

            arrayElementos = transicionesElementos.Split(',');

            if (!String.IsNullOrEmpty(transicionesEpsilon))
            {
                arrayEpsilon = transicionesEpsilon.Split(",");
                arrayFinal = arrayElementos.Union(arrayEpsilon).ToArray();
            }
            else
            {
                arrayFinal = arrayElementos;
            }
           
            Array.Sort(arrayFinal);

            resultado = string.Join(",", arrayFinal);

            return resultado;
        }

        private void AgregarFilaMatriz(List<List<string>> lista, string estado, string composicion, bool titulo)
        {
            int fila;
            lista.Add(new List<string>() { estado });

            fila = (lista.Count) - 1;

            foreach(string elemento in alfabeto)
            {
                lista[fila].Add(titulo ? elemento : null);
            }

            lista[fila].Add(composicion);
        }
        private string BuscarU(string composicion, int columnaComposicion)
        {
            string estado = "";

            for (int fila = 0; fila < matrizAFD.Count; fila++)
            {
                if (matrizAFD[fila][columnaComposicion] == composicion)
                {
                    estado = matrizAFD[fila][0];
                    break;
                }
            }

            return estado;
        }


    }
}