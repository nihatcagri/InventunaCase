using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    MeshRenderer mesh;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        mesh = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
              agent.SetDestination(hit.point);
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        var x = other.gameObject.GetComponent<MeshRenderer>();

        if (other.gameObject.CompareTag("Enemy"))
        {
          x.enabled = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        var x = other.gameObject.GetComponent<MeshRenderer>();

        if (other.gameObject.CompareTag("Enemy"))
        {
            x.enabled = false;
        }

    }


}
