using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class S_ScrollingBG : MonoBehaviour
{
    [SerializeField] private List<GameObject> initialGameObject = new List<GameObject>();
    public List<Vector3> initialPosition;
    [SerializeField] private Transform pointBase;
    [SerializeField] private float speed;
    [SerializeField] private float time;


    public GameObject phase2;
    public GameObject phase3;
    [SerializeField] private GameObject receivePhase;
    [SerializeField] private MailBox mail;
    
    
    [SerializeField] private List<GameObject> listLetter;
    private int doOnce = 0;
    [SerializeField] private GameObject refListAnswers;

    [SerializeField] private S_ListTexts checkList;
    public Avion avion;
    
    public GameObject bg;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void OnEnable()
    {
        for (int i = 0; i < initialGameObject.Count; i++)
        {
            initialPosition.Add(Vector3.zero);
            initialPosition[i] = initialGameObject[i].GetComponent<RectTransform>().transform.position;
        }


        time = Vector2.Distance(transform.position, pointBase.position) / speed;
        transform.DOMove(pointBase.position, time);
        avion.flyLittlePlane(time);
        StartCoroutine(Waitfond());
    }

    IEnumerator Waitfond ()
    {
        yield return new WaitForSeconds(time);
        
        //phase2.SetActive(false);
        phase3.SetActive(true);
        receivePhase.SetActive(true);
        mail.scroll = this;
        backToOrigin();
        resetAllDataMail();
    }


    void resetAllDataMail()
    {
        listLetter[0].SetActive(false);
        listLetter[1].SetActive(false);
        listLetter[2].SetActive(false);
        
        mail.resetAllData();
    }


    public void showLetter()
    {
        doOnce += 1;

        if (Letter.Instance.numberOfLetterSend >= 9)
        {
            Instantiate(bg, phase3.transform.position, phase3.transform.rotation, phase3.transform);
            StartCoroutine(waitToOpen());
        }
        else
        {
            
            phase2.SetActive(false);
            

            if (doOnce == 1)
            {
                listLetter[0].SetActive(true);
            }
            else if (doOnce == 3)
            {
                listLetter[1].SetActive(true);
            }
            else
            {
                listLetter[2].SetActive(true);



                int value = PlayerPrefs.GetInt("pathValue");
                Debug.Log(value + " blablabblabalablablalb");

                //listLetter[2].transform.GetChild(2).gameObject.GetComponent<TextMeshProUGUI>().text = checkList.answers[value];

                listLetter[2].transform.GetChild(2).GetComponent<Assets.SimpleLocalization.LocalizedText>()
                    .Localize2(checkList.answers[value]);

            }
        }
    }
    
    
    
    IEnumerator waitToOpen()
    {
        yield return new WaitForSeconds(1.2f); 
        SceneManager.LoadScene(2);
    }
    
    

    public void backToOrigin()
    {
        for (int i = 0; i < initialGameObject.Count; i++)
        {
            initialGameObject[i].transform.position = initialPosition[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
