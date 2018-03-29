using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MoveCapsule : MonoBehaviour {
    public bool move = false;
    public Camera cam;
    public NavMeshAgent agent;
    // Use this for initialization
    private void Start()
    {
        cam = Camera.main;
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
       
    }

    public IEnumerator moveInit(Vector3 moveTarget)
    {
        Vector3 movePos = new Vector3(moveTarget.x, moveTarget.y + 1, moveTarget.z);
        while (transform.position != movePos)
        {
            

            transform.position = Vector3.MoveTowards(transform.position, movePos, 0.5f);
            yield return null;
        }
        
            
        
        

    }
}
