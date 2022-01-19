using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_ListTexts : MonoBehaviour
{

    [SerializeField] private GameObject refText = null;
    [SerializeField] private Transform emptyTextTransf;

    [SerializeField] private List<string> listePhrases;

    [TextArea]
    [SerializeField] private List<string> listeBasicPhrases;

    private string newSentence;
    private string removeSent;
    private int several;
    private int histoire;
    private bool waitSentences;


    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();

        //First sentences
        BasicSentences();
        
        CreatePrefabChoice();

    }

    public void AddSentence()
    {
        BasicSentences();

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
        if(waitSentences == false)
        {
            switch (histoire)
            {
                case 0:
                    for (int i = 0; i < 3; i++)
                    {
                        listePhrases.Add(listeBasicPhrases[i]);
                    }
                    break;
                case 1:
                    for (int i = 3; i < 6; i++)
                    {
                        listePhrases.Add(listeBasicPhrases[i]);
                    }
                    break;
                case 2:
                    for (int i = 6; i < 9; i++)
                    {
                        listePhrases.Add(listeBasicPhrases[i]);
                    }
                    break;
                case 3:
                    for (int i = 9; i < 12; i++)
                    {
                        listePhrases.Add(listeBasicPhrases[i]);
                    }
                    break;
            }
        }

        waitSentences = true;
    }

    public void CreatePrefabChoice()
    {
        for (int i = 0; i < listePhrases.Count; i++)
        {
            string test = listePhrases[i];
            GameObject refParent = Instantiate(refText, emptyTextTransf.position, Quaternion.identity);
            refParent.transform.SetParent(emptyTextTransf);
            refParent.transform.GetChild(1).GetComponent<Text>().text = test;

            refParent.transform.localScale = new Vector3(1, 1, 1); // :)
        }
    }

    public void RemoveBasic()
    {
        listePhrases.Clear();

        waitSentences = false;
        histoire += 1;

    }

}
