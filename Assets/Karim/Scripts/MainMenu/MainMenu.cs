using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject bg;
   public void PlayGame()
   {
       Instantiate(bg, transform.position, transform.rotation, transform);
       StartCoroutine(waitToOpen());
   }

    public void QuitGame()
    {
        Application.Quit();
    }


    IEnumerator waitToOpen()
    {
        yield return new WaitForSeconds(1.2f); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
