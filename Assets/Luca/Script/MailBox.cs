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
    [SerializeField] private Button envBox;
    private int float1;
    
    [SerializeField] private GameObject lettre;
    [SerializeField] private GameObject notif;


    [HideInInspector] public S_ScrollingBG scroll;
    

    private bool once;
    private bool once2;

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
            spawnLetter();
        }
    }

    void spawnLetter()
    {
        float1 = Random.Range(0, 3);

        while (float1 == 1)
        {
            float1 = Random.Range(0, 3);
        }

        var imE = enveloppe.GetComponent<Image>();

        imE.sprite = listEnv[float1];
        
        enveloppe.transform.DOScale(2, 2);
        imE.DOFade(1, 1.5f);

    }

    public void openletter()
    {
        if (!once2)
        {
            once2 = true;
            StartCoroutine(open1());
        }
    }

    IEnumerator open1()
    {
        enveloppe.GetComponent<Image>().sprite = listEnv[float1 + 1];
        yield return new WaitForSeconds(0.75f);
        lettre.SetActive(true);
        scroll.showLetter();
    }
    
    public void resetAllData()
    {
        once = false;
        once2 = false;
        image.sprite = close;
        enveloppe.transform.localScale = Vector3.one;
        enveloppe.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        notif.SetActive(true);
    }
}
