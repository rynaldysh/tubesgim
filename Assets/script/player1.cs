using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
	public float kecepatan, scaleX, lompat;
	
	
    // Start is called before the first frame update
    void Start(){
    	scaleX = transform.localScale.x;
    }
    	void jalan_kiri(){
    		if(GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("New State")){
    			GetComponent<Animator> ().SetTrigger ("jalan");
    		}
    		transform.localScale = new Vector3(-scaleX, transform.localScale.y,transform.localScale.z);
    		transform.Translate (Vector3.left*kecepatan*Time.fixedDeltaTime, Space.Self);
    	}
        void jalan_kanan(){
        	if(GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("New State")){
    			GetComponent<Animator> ().SetTrigger ("jalan");
    		}
        	transform.localScale = new Vector3(scaleX, transform.localScale.y,transform.localScale.z);
    		transform.Translate (Vector3.right*kecepatan*Time.fixedDeltaTime, Space.Self);
    }
    	void melompat(){
    		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, lompat);
    	
    	}
    	void berhenti(){
    		GetComponent<Animator> ().SetTrigger ("stop");
    	}

    // Update is called once per frame
    void Update()
    {
    	if(Input.GetKey(KeyCode.A)){
    		jalan_kiri();
    	}if (Input.GetKey(KeyCode.D)){
    		jalan_kanan();
    	}if (Input.GetKeyDown(KeyCode.W)){
    		melompat();
    	}if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp (KeyCode.D)) {
    		berhenti ();
    	
    	
    
    }		
	
	 }  
    
}
