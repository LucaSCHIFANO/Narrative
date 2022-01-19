using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letter : MonoBehaviour
{
    // Instance -------------------------------------
    private static Letter _instance = null;
    public static Letter Instance { get => _instance; }
    
    
    //Reference
    public Image image;
    private Sprite baseSprite;
    public GameObject confirmButton;

    public string theName;
    
    public void Awake()
    {
        _instance = this;
        baseSprite = image.sprite;
        
        confirmButton.SetActive(false);
    }
    
    
    public void setNewImage(Sprite _image, Color color, string _name)
    {
        if (_name != theName)
        {
            image.sprite = _image;
            image.color = color;
            theName = _name;
        }
        else
        {
            image.sprite = baseSprite;
            theName = "";
        }


        if (theName == "")
        {
            confirmButton.SetActive(false);
        }
        else
        {
            confirmButton.SetActive(true);
        }
    }
}
