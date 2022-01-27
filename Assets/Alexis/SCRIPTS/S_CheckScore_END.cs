using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S_CheckScore_END : MonoBehaviour
{
    [SerializeField] private GameObject fin1;
    [SerializeField] private GameObject fin2;
    [SerializeField] private GameObject fin3;
    [SerializeField] private GameObject fin4;

    [SerializeField] private int value;
    
    public GameObject bg;
    private void Awake()
    {
        value = PlayerPrefs.GetInt("friendValue");
        //value = 2;
    }
    // Start is called before the first frame update
    void Start()
    {
        if(value > 50)
        {
            fin2.SetActive(true);
        }
        else if (value > 10)
        {
            fin1.SetActive(true);
        }
        else if (value > 4  && value <= 10)
        {
            fin3.SetActive(true);
        }
        else if (value <= 4)
        {
            fin4.SetActive(true);
        }


        StartCoroutine(waite());
    }

    IEnumerator waite()
    {
        yield return new WaitForSeconds(3f);
        Instantiate(bg, transform.position, transform.rotation, transform);
        yield return new WaitForSeconds(1.2f);
        SceneManager.LoadScene(0);
        
    }
}
