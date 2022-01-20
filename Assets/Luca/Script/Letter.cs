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
    public ItemSentence object0;
    private Sprite baseSprite;
    public GameObject confirmButton;

    public GameObject phase1;
    public GameObject phase2;

    public string theName;
    
    public void Awake()
    {
        _instance = this;
        baseSprite = object0.image.sprite;
        
        confirmButton.SetActive(false);
    }
    
    
    public void setNewImage(ItemSentence go, string _name)
    {
        if (_name != theName)
        {
            object0.image.sprite = go.image.sprite;
            object0.text.text = go.text.text;
            theName = _name;

        }
        else
        {
            object0.image.sprite = baseSprite;
            object0.text.text = "";
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



    public void sendLetter()
    {
        phase1.SetActive(false);   
        phase2.SetActive(true);   
    }
}
