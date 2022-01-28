using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject bg;
    public GameObject canvas;
    
    public bool sound;
    public Image image;
    public AudioMixer masterMixer;

    public List<Sprite> soundSprite = new List<Sprite>();
   public void PlayGame()
   {
       Instantiate(bg, canvas.transform.position, canvas.transform.rotation, canvas.transform);
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


    public void setSound()
    {
        sound = !sound;
        if (sound)
        {
            image.sprite = soundSprite[0];
            masterMixer.SetFloat("General", 0);
        }
        else
        {
            image.sprite = soundSprite[1];
            masterMixer.SetFloat("General", -80);
        }
    }
}
