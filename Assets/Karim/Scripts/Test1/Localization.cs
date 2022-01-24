using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class Localization : MonoBehaviour
{
    public string key;

    private void Start()
    {
        ChangeLanguage(0);
    }

    private void ChangeLanguage(int index)
    {
        gameObject.GetComponent<Text>().text = CVSParser.GetTextFromId(key, index);
    }

    private void OnEnable()
    {
        LanguageDropdown.ChangeLanguage += ChangeLanguage;
    }

    private void OnDisable()
    {
        LanguageDropdown.ChangeLanguage -= ChangeLanguage;
    }

}


