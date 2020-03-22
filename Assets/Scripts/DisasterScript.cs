using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterScript : MonoBehaviour {

	public GameObject statusBox;
	public float fishCheck;
	public int genChance;
	public bool disasterActive = false; 
	public int fishesLoss;

	void Update () {
		
		fishCheck = GlobalFishes.FishesCount / 10;	

		if(disasterActive == false){
			StartCoroutine(StartDisaster());
		}
	}
	/*
	 	This function will discount fishes when you sell them. 
	 */
	IEnumerator StartDisaster(){
		disasterActive = true; 
		genChance = Random.Range(1, 20);

		if(fishCheck >= genChance){
			fishesLoss = Mathf.RoundToInt(GlobalFishes.FishesCount * 0.25f);
			statusBox.GetComponent<Text>().text = "You lost " + fishesLoss + " Fishes for an oil spill.";
			GlobalFishes.FishesCount -= fishesLoss;
			yield return new WaitForSeconds(3);
			statusBox.GetComponent<Animation>().Play("StatusAnim");
			yield return new WaitForSeconds(1);
			statusBox.SetActive(false);
			statusBox.SetActive(true);

		}
		yield return new WaitForSeconds(10);
		disasterActive = false;

	}
}
