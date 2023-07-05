using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshPlayerController : MonoBehaviour
{
    [SerializeField] private Camera m_MainCamera;
    [SerializeField] NavMeshAgent m_Agent;
    [SerializeField] private Ray m_Ray;
    [SerializeField] private RaycastHit m_RayCastHit;
    //[SerializeField] private Vector3 m_Destination;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            m_Ray = m_MainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(m_Ray, out m_RayCastHit))
            {
                m_Agent.SetDestination(m_RayCastHit.point);  
            }
        }
    }
}
