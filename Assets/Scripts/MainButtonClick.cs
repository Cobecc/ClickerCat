using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour {

	public GameObject textBox;
	public AudioSource fishSound;


	public void ClickTheButton(){
		fishSound.Play();
		GlobalCats.CatCount += 1;
	}
}
