using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GuardAgent : MonoBehaviour, IObserver {

    private NavMeshAgent agent;


    void Awake() {
        agent = GetComponent<NavMeshAgent>();
    }

    void IObserver.Update() {
        agent.SetDestination(Vector3.one);
    }

}
