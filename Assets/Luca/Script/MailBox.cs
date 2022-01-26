using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Random = UnityEngine.Random;

public class MailBox : MonoBehaviour
{
    [SerializeField] private Sprite open;
    [SerializeField] private Sprite close;
    
    [SerializeField] private List<Sprite> listEnv = new List<Sprite>();


    [SerializeField] private GameObject enveloppe;
    [SerializeField] private GameObject lettre;
    [SerializeField] private GameObject notif;


    public S_ScrollingBG scroll;
    

    private bool once;

    private Image image;
    
    void Start()
    {
        image = GetComponent<Image>();
    }

    void OnMouseDown(){

        if (!once)
        {
            once = true;
            image.sprite = open;
            notif.SetActive(false);
            StartCoroutine(spawnLetter());
        }
    }

    IEnumerator spawnLetter()
    {
        var float1 = Random.Range(0, 3);

        while (float1 == 1)
        {
            float1 = Random.Range(0, 3);
        }

        var imE = enveloppe.GetComponent<Image>();

        imE.sprite = listEnv[float1];
        
        enveloppe.transform.DOScale(2, 2);
        imE.DOFade(1, 1.5f);
        
        yield return new WaitForSeconds(1.5f);
        imE.sprite = listEnv[float1 + 1];
        
        yield return new WaitForSeconds(0.5f);
        lettre.SetActive(true);
        scroll.showLetter();
        
    }
}
