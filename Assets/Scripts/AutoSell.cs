using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour {

	//this script is for the automatic increase of fishes.
	public bool SellingFish = false;
	public static int CashIncrease = 1; //because fish = Cash
	public int InternalIncrease;



	void Update () {
		CashIncrease = GlobalShop.shopPerSec;
		InternalIncrease =  CashIncrease;
		if(SellingFish == false){
			SellingFish = true;
			StartCoroutine(SellTheFish());
		}		
	}

	IEnumerator SellTheFish(){
		GlobalFishes.FishesCount += InternalIncrease;
		yield return new WaitForSeconds(1);
		SellingFish = false;
	}
}
