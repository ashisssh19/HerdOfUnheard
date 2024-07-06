using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    public GameObject fadeout;
    public GameObject loadbutton;
    public int loadInt;

    void Start()
    {
        loadInt = PlayerPrefs.GetInt("AutoSave");
        if (loadInt > 0){
            loadbutton.SetActive(true);
        }
    }

    public void Button1(){
     StartCoroutine(NewGameStart());
   }

    IEnumerator NewGameStart(){
        fadeout.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);
    }

    public void Button2(){
        StartCoroutine(LoadGameStart());
    }

    IEnumerator LoadGameStart(){
        fadeout.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(loadInt);
    }

    public void ExitGame(){
        Application.Quit();
    }
}
