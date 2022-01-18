using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_ListTexts : MonoBehaviour
{
    [SerializeField] private List<string> listePhrases;

    [TextArea]
    [SerializeField] private List<string> listeBasicPhrases;

    private string newSentence;
    private string removeSent;
    private int several;

    private int histoire;


    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();
        BasicSentences();
    }

    public void AddSentence()
    {
        newSentence = PlayerPrefs.GetString("textValue");
        listePhrases.Add(newSentence);
    }

    public void RemoveSentence()
    {
        removeSent = PlayerPrefs.GetString("RemoveSentence");
        listePhrases.Remove(removeSent);
    }

    public void BasicSentences()
    {
        switch (histoire)
        {
            case 0:
                listePhrases.Add(listeBasicPhrases[0]);
                listePhrases.Add(listeBasicPhrases[1]);
                break;

            case 1:
                listePhrases.Add(listeBasicPhrases[2]);
                listePhrases.Add(listeBasicPhrases[3]);
                break;

            case 2:
                listePhrases.Add(listeBasicPhrases[4]);
                listePhrases.Add(listeBasicPhrases[5]);
                break;
            case 3:
                listePhrases.Add(listeBasicPhrases[6]);
                listePhrases.Add(listeBasicPhrases[7]);
                break;
            case 4:
                listePhrases.Add(listeBasicPhrases[8]);
                listePhrases.Add(listeBasicPhrases[9]);
                break;
            case 5:
                listePhrases.Add(listeBasicPhrases[10]);
                break;
        }

    }
}
