using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_UI_Scale : MonoBehaviour
{
    Vector3 scale = new Vector3(0.1f, 0.1f, 0.1f);
    Vector3 resetScale;
    private bool startIsGo = false;
    // Start is called before the first frame update
    void Start()
    {
        startIsGo = true;
       resetScale = gameObject.transform.GetComponent<RectTransform>().localScale;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnEnable()
    {
        if (startIsGo == true)
        {
            gameObject.transform.GetComponent<RectTransform>().localScale = resetScale;
        }


    }

    void OnDisable()
    {

    }

    public void OnClick()
    {
        EnterPointer();
        SoundManager.Instance.Play("Papier2");
        StartCoroutine(Wait());
    }
    public void EnterPointer()
    {
        gameObject.transform.GetComponent<RectTransform>().localScale += scale;
        SoundManager.Instance.Play("Papier1");
    }

    public void ExitEnter()
    {
        gameObject.transform.GetComponent<RectTransform>().localScale -= scale;

    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        ExitEnter();
    }

}
