using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class LanguageDropdown : MonoBehaviour
{
    static public Action<int> ChangeLanguage;
    public Dropdown dropdown;
    public Text label;

    public void LanguageChanged()
    {
        if (ChangeLanguage != null)
            ChangeLanguage(dropdown.value);
        dropdown.captionText.text = CVSParser.GetAvailableLanguages()[dropdown.value];
        label.text = dropdown.captionText.text;
    }
    void Start()
    {
        PopulateDropDown();
    }
    void PopulateDropDown()
    {
        dropdown.ClearOptions();
        dropdown.AddOptions(CVSParser.GetAvailableLanguages());
        LanguageChanged();

    }
}
