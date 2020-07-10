using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin1p2 : MonoBehaviour
{
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag.Equals ("player2")){
			print("coin diambil");
			Destroy (gameObject);
			DolarScore1.hitungDolar += 1;
			
		}
	}

}
