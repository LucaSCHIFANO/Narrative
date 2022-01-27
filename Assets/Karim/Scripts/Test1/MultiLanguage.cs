using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleLocalization;
using UnityEngine.UI;
public class MultiLanguage : MonoBehaviour
{
  

    
    private void Awake()
    {
        
        LocalizationManager.Read();
        if (PlayerPrefs.GetString("language") == null)
        {
            
            LocalizationManager.Language = "English";
            Debug.Log("null");
        }
        else
        {
            
            LocalizationManager.Language = PlayerPrefs.GetString("language");
            Debug.Log(LocalizationManager.Language);
        }

       
        switch (LocalizationManager.Language)
        {
            case "English" :
                LocalizationManager.Language = "English";
                PlayerPrefs.SetString("language", "English");
                PlayerPrefs.Save();
                break;
            case "French":
                LocalizationManager.Language = "French";
                PlayerPrefs.SetString("language", "French");
                PlayerPrefs.Save();
                break;

        }
    }
   
    public void Language(string language)
    {
        LocalizationManager.Language = language;
        PlayerPrefs.SetString("language", language);
        
    }
}
