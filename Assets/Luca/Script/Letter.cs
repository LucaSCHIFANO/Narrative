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
    [SerializeField] private S_ListTexts refList;

    public GameObject phase1;
    public GameObject phase2;

    [SerializeField] private List<GameObject> periodList = new List<GameObject>();
    [SerializeField] private List<GameObject> lancerList = new List<GameObject>();

    private int friendS = 0, path = 0, step = 0;

    public string theName;
    public int numberOfLetterSend;
    
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
            friendS = go.friendS;
            path = go.path;
            step = go.step;
        }
        else
        {
            AvoidLastChoice();
        }


        if (theName == "") confirmButton.SetActive(false);
        
        else confirmButton.SetActive(true);
        
    }



    public void sendLetter()
    {
        periodList[0].SetActive(false);
        periodList[1].SetActive(false);
        periodList[2].SetActive(false);

        phase1.SetActive(false);   
        phase2.SetActive(true);
        EScoreManager.Instance.IncrementScore(path,friendS,step);

        if (numberOfLetterSend < 2)
        {
            periodList[0].SetActive(true);

            foreach (var child in lancerList)
            {
                if(lancerList.IndexOf(child) == numberOfLetterSend) child.SetActive(true);
                else child.SetActive(false);
            }

        }
        else if (numberOfLetterSend < 5)
        {
            periodList[1].SetActive(true);
            
            foreach (var child in lancerList)
            {
                if(lancerList.IndexOf(child) == numberOfLetterSend) child.SetActive(true);
                else child.SetActive(false);
            }
        }
        else
        {
            periodList[2].SetActive(true);
            
            foreach (var child in lancerList)
            {
                if(lancerList.IndexOf(child) == numberOfLetterSend) child.SetActive(true);
                else child.SetActive(false);
            }
        }

        numberOfLetterSend++;
        Debug.Log(numberOfLetterSend);

        SoundManager.Instance.Play("PaperPlane1");
        SoundManager.Instance.Play("PaperPlane2");


    }

    public void AvoidLastChoice()
    {
        object0.image.sprite = baseSprite;
        object0.text.text = "";
        theName = "";
        confirmButton.SetActive(false);
    }
}
