using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class S_ScrollingBG : MonoBehaviour
{
    [SerializeField] private List<GameObject> initialGameObject = new List<GameObject>();
    public List<Vector3> initialPosition;
    [SerializeField] private Transform pointBase;
    [SerializeField] private float speed;
    [SerializeField] private float time;
    
    public GameObject phase2;
    public GameObject phase3;

    public Avion avion;

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
        phase3.SetActive(true);
        phase2.SetActive(false);
        backToOrigin();
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
