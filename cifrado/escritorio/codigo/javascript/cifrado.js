   function buscarCaracterEnAlfabeto(c, alfabeto) {
            for (i = 0; i < alfabeto.length; i++) {
                if (alfabeto[i] == c)
                    return i;
            }
            return 0;
        }

 function cifrarLetra(c,alfabeto,desplazamiento) {
            var pos = buscarCaracterEnAlfabeto(c, alfabeto)+desplazamiento;
            if (pos >= alfabeto.length) 
                pos = pos - alfabeto.length;
                return alfabeto[pos];
        }

        function cifrarPalabra(result,palabra, alfabeto, desplazamiento) {
            for ( q = 0; q < palabra.length; q++) {
                result += cifrarLetra(palabra[q], alfabeto, desplazamiento);
            }
            return result;
        }

        function cifrarInverso(result,palabra){
             for(v=palabra.length-1;v>=0;v--){
                  result+=palabra[v];
             }
 			return result;
		}

		function concatenar2Cadenas(palabra1,palabra2){
			return palabra1+""+palabra2;
		}


		function cifrarGrupal(grupo,indice,resultado,palabra){
 			if(indice<palabra.length){

 			return cifrarGrupal(grupo,indice+grupo,cifrarInverso(resultado,palabra.substring(indice,indice+grupo)),palabra);
 			}

              return concatenar2Cadenas(resultado,palabra.substring(indice,palabra.length));

		}
