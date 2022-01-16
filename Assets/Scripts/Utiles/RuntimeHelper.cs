using UnityEngine;

namespace Snake.Utiles
{
    public class RuntimeHelper
    {
        public static void setLanguage(string language)
        {
            PlayerPrefs.SetString("Language", language);
        }
        public static string getLanguage()
        {
            return PlayerPrefs.GetString("Language", "") == "" ? Application.systemLanguage.ToString() : PlayerPrefs.GetString("Language", "");
        }

        public static string selectStringByLanguage(string tr, string ing)
        {
            if(getLanguage() == Constants.TURKISH)
            {
                return tr;
            }
            else if(getLanguage() == Constants.ENGLISH)
            {
                return ing;
            }
            return ing;
        }
    }
}
