using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePerson : MonoBehaviour {

    // Use this for initialization
    Person Netula;
    void Start () {
        Netula = new Person("Teemu", "Valtteri", "Johannes", "Nietula");
        Debug.Log(Netula.getFullName());
        
        Debug.Log(Netula.getLastName());
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
