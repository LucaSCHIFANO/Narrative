using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_UI_Scale : MonoBehaviour
{
    Vector3 scale = new Vector3(0.1f, 0.1f, 0.1f);


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
        this.transform.localScale += scale;
        SoundManager.Instance.Play("Papier1");
    }

    public void ExitEnter()
    {
        this.transform.localScale -= scale;

    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        ExitEnter();
    }

}
