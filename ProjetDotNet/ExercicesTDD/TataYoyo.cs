using System;

namespace ExercicesTDD
{
    public class TataYoyo
    {
        public String afficherTataYoyo(int nbChoisi)
        {
            // Boucles if avant optimisation
            if (nbChoisi % 5 != 0 && nbChoisi % 3 != 0)
            {
                return nbChoisi.ToString();
            }
            if (nbChoisi % 5 == 0 && nbChoisi % 3 == 0)
            {
                return "Tata Yoyo";
            }
            if (nbChoisi % 3 == 0)
            {
                return "Tata";
            }
            if (nbChoisi % 5 == 0)
            {
                return "Yoyo";
            }
            return "";

            // Conditions ternaire après optimisation
            //return nbChoisi % 3 == 0 ? "Tata" : "";
        }
    }
}
