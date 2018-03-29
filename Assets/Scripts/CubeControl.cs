using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour {

    // Use this for initialization
    public Material active;
    public Material inActive;
    public bool activeMove;
    public GameObject player;
    void Start () {
        gameObject.GetComponent<Renderer>().material = inActive;
        activeMove = false;
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void OnMouseEnter () {
        gameObject.GetComponent<Renderer>().material = active;
        activeMove = true;
    }
    void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material = inActive;
        activeMove = false;
    }
    private void Update()
    {
        /*if(Input.GetMouseButtonDown(0)&& activeMove)
        {
            player.GetComponent<MoveCapsule>().StartCoroutine(player.GetComponent<MoveCapsule>().moveInit(transform.position));
        }*/
    }
}
