using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCat : MonoBehaviour {

	//this script is for the automatic increase of fishes.
	public bool CreatingFish = false;
	public static int FishIncrease = 1;
	public int InternalIncrease;



	void Update () {
		FishIncrease = GlobalFishRod.frPerSec;
		InternalIncrease =  FishIncrease;
		if(CreatingFish == false){
			CreatingFish = true;
			StartCoroutine(CreateTheFish());
		}		
	}

	IEnumerator CreateTheFish(){
		GlobalFishes.FishesCount += InternalIncrease;
		yield return new WaitForSeconds(1);
		CreatingFish = false;
	}
}
