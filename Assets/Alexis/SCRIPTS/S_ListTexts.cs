using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class S_ListTexts : MonoBehaviour
{

    [SerializeField] private GameObject refText = null;
    [SerializeField] private Transform emptyTextTransf;

    //Listes
    [TextArea]
    [SerializeField] private List<string> listePhrases;
    [TextArea]
    [SerializeField] private List<string> listeBasicPhrases;

    [SerializeField] private List<S_ScriptTestStruct> actuallyStruct;
    [SerializeField] private List<S_ScriptTestStruct> basicStruct;

    //refs
    public ItemSentence refItem;


    private string newSentence;
    private string removeSent;
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

    public void AddNewSentence(string txt, int love, int friend)
    {
        BasicSentences();

        actuallyStruct.Add(new S_ScriptTestStruct(txt, love, friend));
    }

    //public void RemoveSentence()
    //{
    //    removeSent = PlayerPrefs.GetString("RemoveSentence");
    //    listePhrases.Remove(removeSent);
    //}

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

                        actuallyStruct.Add(basicStruct[i]);

                    }
                    break;
                case 1:
                    for (int i = 3; i < 6; i++)
                    {
                        listePhrases.Add(listeBasicPhrases[i]);

                        actuallyStruct.Add(basicStruct[i]);
                    }
                    break;
                case 2:
                    for (int i = 6; i < 9; i++)
                    {
                        listePhrases.Add(listeBasicPhrases[i]);

                        actuallyStruct.Add(basicStruct[i]);
                    }
                    break;
                case 3:
                    for (int i = 9; i < 12; i++)
                    {
                        listePhrases.Add(listeBasicPhrases[i]);

                        actuallyStruct.Add(basicStruct[i]);
                    }
                    break;
            }
        }

        waitSentences = true;
    }

    public void CreatePrefabChoice()
    {
        for (int i = 0; i < actuallyStruct.Count; i++)
        {
            //string test = listePhrases[i];

            GameObject refParent = Instantiate(refText, emptyTextTransf.position, Quaternion.identity);
            refParent.transform.SetParent(emptyTextTransf);
            refParent.transform.GetChild(1).GetComponent<Text>().text = actuallyStruct[i].phrase; //test

            refParent.GetComponent<ItemSentence>().SetScore(actuallyStruct[i].scoreLove, actuallyStruct[i].scoreFriend);

            refParent.transform.localScale = new Vector3(1, 1, 1); // :) wtf
            refParent.name = "Item (" + i + ")";
            ScrollSize.Instance.scrollObject.Add(refParent);
        }
        
        ScrollSize.Instance.resizeScrolling();
    }

    public void RemoveBasic()
    {
        listePhrases.Clear();
        actuallyStruct.Clear();

        waitSentences = false;
        histoire += 1;
        
        ScrollSize.Instance.destroyList();

    }

}
