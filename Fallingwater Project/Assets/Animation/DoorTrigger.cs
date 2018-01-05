using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour {

	private Animator DoorAnim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		DoorAnim = GetComponent<Animator> ();
	}

	void OnTriggerEnter () {
		DoorAnim.SetBool ("RunAnimation", true);
	}

	void OnTriggerExit () {
		DoorAnim.SetBool ("RunAnimation", false);
	}
}
