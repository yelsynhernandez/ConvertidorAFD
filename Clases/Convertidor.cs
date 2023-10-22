using System.Data;
using System.Security.Cryptography.Xml;

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
                string composicionInicial = String.Empty;
                string cadenaEstados = String.Empty;
                string elemento = String.Empty;
                string estadoU = String.Empty;
                string estadosMueve;
                string estadosEpsilon;
                string U; 

                Configuraciones ct = new();
                DataTable dt = new();

                AgregarFilaMatriz(matrizAFD, "Estados", "Composición" ,true);
                
                cadenaEstados = string.Join(",", estados);

                composicionInicial = ComposicionInicial(estadoInicial);

                AgregarFilaMatriz(matrizAFD, ((char)indiceAscii).ToString(), composicionInicial, false);
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
            return (resultado.Length > 0 ? resultado.Remove(resultado.Length - 1) : ""); ;
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
                if(elemento != "e")
                {
                    lista[fila].Add(titulo ? elemento : null);
                }
            }

            lista[fila].Add(composicion);
        }
        private string BuscarU(string composicion, int columnaComposicion)
        {
            string estado = String.Empty;

            for (int fila = 0; fila < matrizAFD.Count; fila++)
            {
                if (matrizAFD[fila][columnaComposicion] == composicion)
                {
                    estado = matrizAFD[fila][0];
                    break;
                }
            }

            return (estado.Length > 0 ? estado: "");
        }

        private string ComposicionInicial(string _estadoInicial)
        {
            string resultado = $"{_estadoInicial},";
            string estadoEncontrado = EvaluarTransiciones(_estadoInicial, "e");
            string siguienteEstado;
            bool continuar = true;

            if(estadoEncontrado.Length > 0)
            {
                resultado += $"{estadoEncontrado},";

                while (continuar)
                {
                    siguienteEstado = EvaluarTransiciones(estadoEncontrado, "e");
                    if(siguienteEstado.Length > 0)
                    {
                        estadoEncontrado = siguienteEstado;
                        resultado += $"{estadoEncontrado},";
                    }
                    else
                    {
                        continuar = false;
                    }
                }
            }

            return (resultado.Length > 0 ? resultado.Remove(resultado.Length - 1): "");
        }

    }
}