using System;

namespace WindowsFormsApplication3
{
    internal class inversoGrupal
    {

       public string cifrarInverso(string result, string palabra)
        {
            for (int v = palabra.Length - 1; v >= 0; v--)
            {
                result += palabra[v];
            }
            return result;
        }

        string concatenar2Cadenas(string palabra1, string palabra2)
        {
            return palabra1 + "" + palabra2;
        }

      public  string  cifrarGrupal(int grupo, int indice,string resultado, string palabra)
        {
            if (indice < palabra.Length)
            {

                return cifrarGrupal(grupo, indice + grupo, cifrarInverso(resultado, palabra.Substring(indice, indice + grupo-1)), palabra);
            }

            int dif = indice - grupo;
            if(dif>0)
            return concatenar2Cadenas(resultado, palabra.Substring(dif, palabra.Length-1));
            else
                return concatenar2Cadenas(resultado, palabra.Substring(indice, palabra.Length - 1));
        }





        public string invertir_en_grupos(string mensaje, int elementos_en_elgrupo, string nuevo_mensaje)
        {
            int inicio_grupo = 0;

            if (elementos_en_elgrupo < 1)
                return mensaje;

            for (int i = 0; i < mensaje.Length; i++)
            {
                if ((i + 1) % elementos_en_elgrupo == 0)
                {
                    nuevo_mensaje = nuevo_mensaje.Substring(0, inicio_grupo);
                    nuevo_mensaje += mover(mensaje, inicio_grupo, i + 1, "");
                    inicio_grupo += elementos_en_elgrupo;
                }
                else
                {
                    nuevo_mensaje += mensaje[i];
                }
            }
            return nuevo_mensaje;
        }


        private string mover(string mensaje, int inicio, int fin, string mensajenuevo)
        {
            for (int i = inicio; i < fin; i++)
            {
                mensajenuevo += mensaje[i];
            }
            string msj = reverse(mensajenuevo);
            return msj;
        }

        private string reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }


    }
}