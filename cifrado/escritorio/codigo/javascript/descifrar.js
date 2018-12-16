function buscarCaracterEnAlfabeto( ca, alfabeto)
        {
            for (m = 0; m < alfabeto.length; m++)
            {
                if (alfabeto[m] == ca)
                    return m;
            }
            return 0;
        }


        //abcdefghijklmnñopqrstuvwxyz    27
        function descifrarLetra(caracter, alfabeto, desplazamiento)
        {
            var pos = buscarCaracterEnAlfabeto(caracter, alfabeto) - desplazamiento;
            if (pos < 0)
                pos = alfabeto.length+pos;
            return alfabeto[pos];
        }

        function descifrarPalabra(resulta, palabra, alfabeto, desplazamiento)
        {
            for (w = 0; w < palabra.length; w++)
            {
                resulta += descifrarLetra(palabra[w], alfabeto, desplazamiento);
            }
            return resulta;
        }