using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SellButtonClick : MonoBehaviour {

	public GameObject textBox;
	public GameObject statusBox;
	public AudioSource cashOne;
	public AudioSource cashTwo;
	public int generateTone;
	public AudioSource noFishes;


	public void ClickTheButton(){

		generateTone = Random.Range(1, 3);
			
		if(GlobalCats.CatCount == 0){
			noFishes.Play();
			statusBox.GetComponent<Text>().text = "Not Ennough fishes to use";
			statusBox.GetComponent<Animation>().Play("StatusAnim");
		}
		else{
			if(generateTone == 1){
				cashOne.Play();
			}
			if(generateTone == 2){
				cashTwo.Play();
			}
			GlobalCats.CatCount -= 1;
			GlobalFishes.FishesCount += 1;
		}

	}
}
