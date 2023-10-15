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

        public void convertirAFN(DataGridView dgvResultado)
        {
            try {
                int indiceAscii = 65;
                int estadosGenerados = 0;
                int estadosRecorridos = 1;
                int totalColumnas = 0;
                string cadenaEstados = "";
                bool nuevoEstado = false;
                string estadosMueve;
                string estadosEpsilon;
                string[] estadosResultantes;

                Configuraciones ct = new Configuraciones();
                
                DataTable dt = new DataTable();

                transiciones = obtenerTransiciones(cadenaTransiciones);

                matrizResultante.Add(new List<string>() { "Estados" });
                
                foreach (string elemento in alfabeto)
                {
                    matrizResultante[0].Add(elemento);
                }
                matrizResultante[0].Add("Composición");

                foreach (string nombreColumna in matrizResultante[0])
                {
                    dt.Columns.Add(nombreColumna);
                }

                cadenaEstados = string.Join(",", estados);
                totalColumnas = matrizResultante[0].Count;

                matrizResultante.Add(new List<string>() { ((char)indiceAscii).ToString(),null,null, $"{estadoInicial},{evaluarTransiciones(cadenaEstados,"e")}" });
                estadosGenerados++;
                indiceAscii++;

                while (estadosRecorridos <= estadosGenerados)
                {
                    foreach(string elemento in alfabeto)
                    {
                        estadosMueve = evaluarTransiciones(matrizResultante[estadosRecorridos][totalColumnas - 1 ],elemento);
                        estadosEpsilon = evaluarTransiciones(estadosMueve, "e");
                        Console.Write(":v");
                    }
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

        private List<List<string>> obtenerTransiciones(string cadena)
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

        private string evaluarTransiciones(string cadenaComposicion, string elemento)
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
            }
            return resultado;
        }

        //private string cerraduraEpsilon(string composicion)
        //{
        //    string resultado = "";
        //    foreach(string estado in _estados)
        //    {
        //        for(int fila = 0; fila < transiciones.Count; fila++)
        //        {
        //            if(transiciones[fila][0] == estado && transiciones[fila][1] == "e")
        //            {
        //                resultado += $"{transiciones[fila][2]},";
        //            }
        //        }
        //    }
        //    resultado = resultado.Remove(resultado.Length - 1);
        //    return resultado;
        //}

        //private string mueve(string T, string elemento)
        //{
        //    string resultado = "";
        //    string[] estados = T.Split(new String[] { "," },StringSplitOptions.None);

        //    foreach(string estado in estados)
        //    {
        //        for(int fila = 0; fila < transiciones.Count; fila++)
        //        {
        //            if (transiciones[fila][0] == estado && transiciones[fila][1] == elemento)
        //            {
        //                resultado += $"{transiciones[fila][2]},";
        //            }
        //        }
        //    }
        //    resultado = resultado.Remove(resultado.Length - 1);
        //    return resultado;
        //}


    }
}