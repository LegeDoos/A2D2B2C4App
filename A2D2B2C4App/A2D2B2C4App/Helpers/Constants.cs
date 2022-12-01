using System;
using System.Collections.Generic;
using System.Text;

namespace A2D2B2C4App.Helpers
{
    public class Constants
    {
        public const string COCKTAIL_BY_NAME = "https://www.thecocktaildb.com/api/json/v1/1/search.php?s={0}";
        public const string COCKTAIL_BY_LETTER = "https://www.thecocktaildb.com/api/json/v1/1/search.php?f={0}";
        public const string INGREDIENT_BY_NAME = "https://www.thecocktaildb.com/api/json/v1/1/search.php?i={0}";
        public const string INGREDIENT_BY_ID = "https://www.thecocktaildb.com/api/json/v1/1/lookup.php?iid={0}";
        public const string COCKTAIL_AT_RANDOM = "https://www.thecocktaildb.com/api/json/v1/1/random.php";
        public const string COCKTAIL_DETAILS_BY_ID = "https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i={0}";




        /*
        Search cocktail by name
        www.thecocktaildb.com/api/json/v1/1/search.php?s=margarita

        List all cocktails by first letter
        www.thecocktaildb.com/api/json/v1/1/search.php?f=a

        Search ingredient by name
        www.thecocktaildb.com/api/json/v1/1/search.php?i=vodka

        Lookup full cocktail details by id
        www.thecocktaildb.com/api/json/v1/1/lookup.php?i=11007

        Lookup ingredient by ID
        www.thecocktaildb.com/api/json/v1/1/lookup.php?iid=552

        Lookup a random cocktail
        www.thecocktaildb.com/api/json/v1/1/random.php



         */


    }
}
