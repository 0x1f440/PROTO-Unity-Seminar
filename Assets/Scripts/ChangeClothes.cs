using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeClothes : MonoBehaviour {

	public void ChangeSprite(){
		GameObject.FindGameObjectWithTag("Player").GetComponent<Image>().sprite = GetComponent<Image>().sprite;
		GetComponent<AudioSource>().Play();
	}
}
