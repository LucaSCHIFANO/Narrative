using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receive : MonoBehaviour
{
    public GameObject phase1;


    [SerializeField] private S_ListTexts refList;
    [SerializeField] private Letter refLetter;

    public void replyButton()
    {
        gameObject.SetActive(false);
        phase1.SetActive(true);

        refLetter.AvoidLastChoice();

        refList.BasicSentences();
        refList.CreatePrefabChoice();
    }
}
