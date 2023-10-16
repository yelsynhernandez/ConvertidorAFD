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

namespace LeerAutomata.Clases
{
    internal class Convertidor
    {
        private string[] estados { get; set; }
        private string[] alfabeto { get; set; }
        private string cadenaTransiciones = "";
        private string estadoInicial;
        List<List<string>> transiciones = new List<List<string>>();
        private List<List<string>> matrizResultante = new List<List<string>>();
        public Convertidor(string[] _estados, string[] _alfabeto, string _cadenaTransiciones, string estadoInicial)
        {
            this.estados = _estados;
            this.alfabeto = _alfabeto;
            this.cadenaTransiciones = _cadenaTransiciones;
            this.estadoInicial = estadoInicial;
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

                Configuraciones ct = new Configuraciones();
                DataTable dt = new DataTable();

                transiciones = ObtenerTransiciones(cadenaTransiciones);

                AgregarFilaMatriz(matrizResultante, "Estados", "Composición" ,true);

                cadenaEstados = string.Join(",", estados);
                AgregarFilaMatriz(matrizResultante, ((char)indiceAscii).ToString(), $"{estadoInicial},{EvaluarTransiciones(cadenaEstados, "e")}", false);
                //matrizResultante.Add(new List<string>() { ((char)indiceAscii).ToString(), null, null,  });
                estadosGenerados++;
                indiceAscii++;

                //matrizResultante.Add(new List<string>() { "Estados" });

                //foreach (string elemento in alfabeto)
                //{
                //    matrizResultante[0].Add(elemento);
                //}
                //matrizResultante[0].Add("Composición");

                columnaComposicion = matrizResultante[0].Count - 1;

                while (estadosRecorridos <= estadosGenerados)
                {
                    MessageBox.Show($"Evaluando el estado: {matrizResultante[estadosRecorridos][0]}");
                    for (int columna = 0; columna < alfabeto.Length; columna++) 
                    //foreach(string elemento in alfabeto)
                    {
                        elemento = alfabeto[columna];

                        estadosMueve = EvaluarTransiciones(matrizResultante[estadosRecorridos][columnaComposicion],elemento);
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
                            AgregarFilaMatriz(matrizResultante, estadoU, U, false);
                            estadosGenerados++;
                            indiceAscii++;
                            matrizResultante[estadosRecorridos][columna + 1] = estadoU;
                        }
                        else
                        {
                            matrizResultante[estadosRecorridos][columna + 1] = estadoU;
                        }
                    }
                    estadosRecorridos++;
                }

                //Configuración de tabla para cargar la data

                foreach (string nombreColumna in matrizResultante[0])
                {
                    dt.Columns.Add(nombreColumna);
                }

                for (int fila = 1; fila < matrizResultante.Count; fila++) 
                {
                    dt.Rows.Add(matrizResultante[fila].ToArray());
                }
                dgvResultado.DataSource = dt;
                ct.configurarTabla(dgvResultado);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            catch(Exception e)
            {
                MessageBox.Show("Error: " + e.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
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

            if (resultado.Length > 0) {
                resultado = resultado.Remove(resultado.Length - 1);
                //string[] array = resultado.Split(',');
                //Array.Sort(array);
                //resultado = String.Join(',',array);
            }
            return resultado;
        }

        private string UnirElementos(string transicionesElementos, string transicionesEpsilon)
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
           
            //arrayFinal = arrayFinal.OrderBy(x => x).ToArray();
            Array.Sort(arrayFinal);

            resultado = string.Join(",", arrayFinal);

            return resultado;
        }

        private void AgregarFilaMatriz(List<List<string>> lista, string estado, string composicion, bool titulo)
        {
            int fila = 0;
            lista.Add(new List<string>() { estado });
            fila = (lista.Count) - 1;

            foreach(string elemento in alfabeto)
            {
                lista[fila].Add((titulo ? elemento : null));
            }

            lista[fila].Add(composicion);
        }
        private string BuscarU(string composicion, int columnaComposicion)
        {
            string estado = "";

            for (int fila = 0; fila < matrizResultante.Count; fila++)
            {
                if (matrizResultante[fila][columnaComposicion] == composicion)
                {
                    estado = matrizResultante[fila][0];
                    break;
                }
            }

            return estado;
        }


    }
}