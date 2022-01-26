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
    //[TextArea]
    //[SerializeField] private List<string> listePhrases;
    //[TextArea]
    //[SerializeField] private List<string> listeBasicPhrases;

    [SerializeField] private List<S_ScriptTestStruct> actuallyStruct;
    [SerializeField] private List<S_ScriptTestStruct> basicStruct;

    [TextArea]
    public List<string> answers = new List<string>();

    //refs
    public ItemSentence refItem;


    private string newSentence;
    private string removeSent;
    private int histoire;
    private bool waitSentences;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();

        //First sentences
        BasicSentences();
        
        CreatePrefabChoice();

    }

    public void AddNewSentence(string txt, int pathId, int friend, int stepId)
    {
        BasicSentences();

        actuallyStruct.Add(new S_ScriptTestStruct(txt, pathId, friend, stepId));
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
            int value = PlayerPrefs.GetInt("pathValue");
            int valueStep  = PlayerPrefs.GetInt("stepValue");

            Debug.Log(valueStep + " " + value);

            if (PlayerPrefs.HasKey("pathValue"))
            {
                for (int i = value; i < value + valueStep; i++)
                {

                    actuallyStruct.Add(basicStruct[i]);
                }

            }
            else
            {
                for (int i = 0; i < 3; i++)
                {

                    actuallyStruct.Add(basicStruct[i]);

                }
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
            refParent.transform.GetChild(1).GetComponent<Assets.SimpleLocalization.LocalizedText>().Localize2(actuallyStruct[i].phrase);
            
            // = actuallyStruct[i].phrase; //LocalisationManager.Localize(actuallyStruct[i]
            

            refParent.GetComponent<ItemSentence>().SetScore(actuallyStruct[i].path, actuallyStruct[i].scoreFriend, actuallyStruct[i].step);

            refParent.transform.localScale = new Vector3(1, 1, 1); // :) wtf
            refParent.name = "Item (" + i + ")";
            ScrollSize.Instance.scrollObject.Add(refParent);
        }
        
        ScrollSize.Instance.resizeScrolling();
    }

    public void RemoveBasic()
    {
        //listePhrases.Clear();
        actuallyStruct.Clear();

        waitSentences = false;
        //histoire += 1;
        
        ScrollSize.Instance.destroyList();

    }

}
