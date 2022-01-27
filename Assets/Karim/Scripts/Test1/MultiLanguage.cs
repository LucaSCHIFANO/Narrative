using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleLocalization;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MultiLanguage : MonoBehaviour
{
    public Image image;
    public List<Sprite> flags = new List<Sprite>();
    private bool menu;
    
    private void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            menu = true;
        }

        
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
                image.sprite = flags[0];
                PlayerPrefs.Save();
                break;
            case "French":
                LocalizationManager.Language = "French";
                PlayerPrefs.SetString("language", "French");
                PlayerPrefs.Save();
                image.sprite = flags[1];
                break;

        }
    }
    public void Language(string language)
    {
        LocalizationManager.Language = language;
        PlayerPrefs.SetString("language", language);
        
        switch (LocalizationManager.Language)
        {
            case "English" :
                image.sprite = flags[0];
                break;
            case "French":
                image.sprite = flags[1];
                break;

        }
        
    }
}
