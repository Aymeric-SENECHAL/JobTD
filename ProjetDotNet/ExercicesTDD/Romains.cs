using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesTDD
{
    public class Romains
    {
        String nbRomain;
        //int[] chiffresArabes = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
        //String[] chiffresRomains = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };
        //Ne fonctionne pas car il faut parcourir le tableau dans l'autre sens pour prendre le plus grand en premier

        int[] chiffresArabes = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        String[] chiffresRomains = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        public String convertir(int nbArabe)
        {
            if (nbArabe < 0)
            {
                return "Vous devez obligatoirement entrer un nombre suppérieur à 0 différent de null !";
            }
            else if (nbArabe == 0)
            {
                return "0";
            }
            else
            {

                for (int i = 0; i < chiffresArabes.Length; i++)
                {
                    while (nbArabe >= chiffresArabes[i])
                    {
                        nbRomain += chiffresRomains[i];
                        nbArabe -= chiffresArabes[i];
                    }
                }

                return nbRomain;

            }

        }
    }
}
