using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] Transform target;

    Ray lastRay;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        }

        Debug.DrawRay(lastRay.origin, lastRay.direction * 100);

        GetComponent<NavMeshAgent>().destination = target.position;

       
    }
}
