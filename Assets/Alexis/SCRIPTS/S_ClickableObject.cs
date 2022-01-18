using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_ClickableObject : MonoBehaviour
{

    [TextArea]
    [SerializeField] private string textBase;
    [SerializeField] private int severalObjects;

    [SerializeField] private bool imDone;

    private S_ListTexts callFunction;
    // Start is called before the first frame update
    void Start()
    {
        callFunction = FindObjectOfType<S_ListTexts>();
    }

    public void IchooseThisObject()
    {
        if (PlayerPrefs.HasKey("severalValue"))
        {
            severalObjects = PlayerPrefs.GetInt("severalValue");
        }

        severalObjects += 1;
        imDone = true;


        PlayerPrefs.SetString("textValue", textBase);
        PlayerPrefs.SetInt("severalValue", severalObjects);

        //PlayerPrefs.SetInt("imDoneValue", 1);
        PlayerPrefs.Save();

        callFunction.AddSentence();


        Destroy(this.gameObject);
    }

}
