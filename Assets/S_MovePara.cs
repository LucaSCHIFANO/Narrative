using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_MovePara : MonoBehaviour
{
    public enum FondValue
    {
        NONE,
        FOREGROUND,
        MIDGROUND,
        BACKGROUND,
    }

    [SerializeField] private FondValue value;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.left * speed);
    }

    public void OnBecameVisible()
    {
        Debug.Log("sdsdfsfsqfqsfqssfqdseqfd");
        switch (value) //Flèche de droite + enum = mets tout direct
        {
            case FondValue.FOREGROUND:
                speed = 0.05f;
                break;
            case FondValue.MIDGROUND:
                speed = 0.005f;
                break;
            case FondValue.BACKGROUND:
                speed = 0.0005f;
                break;
            case FondValue.NONE:
                speed = 0f;
                break;
            default:
                break;
        }
    }
}
