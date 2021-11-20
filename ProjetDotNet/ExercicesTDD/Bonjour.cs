using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicesTDD
{
    public class Bonjour
    {
        public String saluer(String name)
        {
            if (String.IsNullOrEmpty(name))
            {
                return "Bonjour, l'ami";
            }
            else if (name.ToUpper() == name)
            {
                return "BONJOUR, " + name;
            }
            else if (name.Contains(","))
            {
                String[] nouvelleChaineCoupee = name.Split(",");
                String lesItemsLower = "";
                String lesItemsUpper= "";

                for (int i = 0; i < nouvelleChaineCoupee.Length; i++)
                {
                    string mot = nouvelleChaineCoupee[i].Trim();
                    if (mot.ToUpper() == mot)
                    {
                        lesItemsUpper = lesItemsUpper + mot + ", ";
                    }
                    else
                    {
                        lesItemsLower = lesItemsLower + mot + ", ";
                    }
                }

                String lastItem = nouvelleChaineCoupee.Last().Trim();

                if (String.IsNullOrEmpty(lesItemsUpper))
                {
                    return "Bonjour, " + lesItemsLower.Remove(name.Length - lastItem.Length - 2) + " et " + lastItem;
                }
                else
                {
                    String[] tabNamesUpper = lesItemsUpper.Split(",");
                    String[] tabNamesLower = lesItemsLower.Split(",");

                    return "Bonjour, " + lesItemsLower.Remove(lesItemsLower.Length - lastItem.Length - 4) +
                            " et " + tabNamesLower[tabNamesLower.Length - 2].Trim() +
                            ". ET BONJOUR " + lesItemsUpper.Remove(lesItemsUpper.Length - 2);
                }

                // name.Length = la taille du string de base contenant les prénoms
                // lastItem.Length = la taille du dernier prénom
                // -2 pour supprimer la virgule et l'espace
                // on concatène le tout avec le "bonjour" et le "et" et tout fonctionne

            }
            else
            {
                return "Bonjour, " + name;
            }

            //return String.IsNullOrEmpty(name) ? "Bonjour, l'ami" : "Bonjour, " + name;
        }

    }
}
