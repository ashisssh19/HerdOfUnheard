using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroSequencing : MonoBehaviour
{
    public GameObject textBox;
    public GameObject dateDisplay;
    public GameObject placeDisplay;
    public AudioSource thudSound;
    public GameObject allBlack;

    void Start()
    {
        StartCoroutine(SequenceBegin());
    }

    IEnumerator SequenceBegin(){
        yield return new WaitForSeconds(3);
        placeDisplay.SetActive(true);
        yield return new WaitForSeconds(1);
        dateDisplay.SetActive(true);
        yield return new WaitForSeconds(4);
        placeDisplay.SetActive(false);
        dateDisplay.SetActive(false);
        yield return new WaitForSeconds(17);
        textBox.GetComponent<Text>().text = "The Starry Night of May 24th, 2020 changed me forever.";
        yield return new WaitForSeconds(4.5f);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "I headed out to investigate the soul-stirring sounds in the woods.";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(7);
        textBox.GetComponent<Text>().text = "I stumbled upon a clearing with a cabin in the distance.";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "I could here those blares coming from there again...";
        yield return new WaitForSeconds(4);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(6);
        textBox.GetComponent<Text>().text = "Little did i know that this was the beginning of the Nightmare!";
        yield return new WaitForSeconds(5);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(34);
        allBlack.SetActive(true);
        thudSound.Play();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
}
