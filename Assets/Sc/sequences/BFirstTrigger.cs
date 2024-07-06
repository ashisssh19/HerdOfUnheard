using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BFirstTrigger : MonoBehaviour
{
   public GameObject ThePlayer;
   public GameObject TextBox;
   public GameObject TheMarker;

   void OnTriggerEnter (){
      this.GetComponent<BoxCollider>().enabled = false;
	   ThePlayer.GetComponent<FirstPersonController>().enabled = false;
	   StartCoroutine (ScenePlayer ());
   }

   IEnumerator ScenePlayer() {
	   TextBox.GetComponent<Text>().text = "Looks like a weapon on the table";
	   yield return new WaitForSeconds (1.5f);
	    TextBox.GetComponent<Text>().text = " ";
		 ThePlayer.GetComponent<FirstPersonController>().enabled =true;
		 TheMarker.SetActive(true);
   }
}
