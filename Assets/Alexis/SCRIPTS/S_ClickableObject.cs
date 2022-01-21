using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_ClickableObject : MonoBehaviour
{

    [TextArea]
    [SerializeField] private string textBase;
    private int severalObjects;

    [SerializeField] private bool imDone;
    [SerializeField] private GameObject canInteract;
    [SerializeField] private Button refButton;

    [SerializeField] private int friendS;
    [SerializeField] private int loveS;

    private S_ListTexts callFunction;

    // Start is called before the first frame update
    void Start()
    {
        callFunction = FindObjectOfType<S_ListTexts>();
    }

    private void IchooseThisObject()
    {
        //Check save if it exists
        if (PlayerPrefs.HasKey("severalValue"))
        {
            severalObjects = PlayerPrefs.GetInt("severalValue");
        }

        //Update values
        severalObjects += 1;
        imDone = true;

        //Feedback button inactif
        canInteract.SetActive(false);
        refButton.gameObject.GetComponent<Button>().enabled = false;

        //Save and send it
        SaveValues();
        callFunction.AddNewSentence(textBase, loveS, friendS);


        //Destroy(this.gameObject);
    }

    private void SaveValues()
    {
        //PlayerPrefs.SetString("textValue", textBase);
        PlayerPrefs.SetInt("severalValue", severalObjects);
        //PlayerPrefs.SetInt("FriendsValue", friendS);
        //PlayerPrefs.SetInt("LoveValue", loveS);
        PlayerPrefs.Save();
    }

}
