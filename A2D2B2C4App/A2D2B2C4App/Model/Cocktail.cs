using A2D2B2C4App.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace A2D2B2C4App.Model
{


    public class Cocktail
    {
        public static string GenerateURLName(string name)
        {
            return string.Format(Constants.COCKTAIL_BY_NAME, name);
        }

        public static string GenerateURLLetter(string letter)
        {
            return string.Format(Constants.COCKTAIL_BY_LETTER, letter);
        }

        public static string GenerateURLRandom()
        {
            return Constants.COCKTAIL_AT_RANDOM;
        }

        public static string GenerateURLById(string name)
        {
            return string.Format(Constants.COCKTAIL_BY_NAME, name);
        }
    }
}
