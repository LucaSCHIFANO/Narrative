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
        LocalizationManager.Language = "French";
        switch (Application.systemLanguage)
        {
            case SystemLanguage.English :
                LocalizationManager.Language = "English";
                break;
            case SystemLanguage.French:
                LocalizationManager.Language = "French";
                break;

        }
    }
   public void Language(string language)
    {
        LocalizationManager.Language = language;
    }
}
