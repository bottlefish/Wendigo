using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour {

    public State currentState;
    public State remainState;
    [HideInInspector]
    public Collider other;
    public Transform eyes;
    public State[] Sequence;
    public float[] transTime;
    public AIInfo aiInfo;
    [HideInInspector]
    public NavMeshAgent navMeshAgent;
    [HideInInspector]
    public List<Transform> wayPointList;
    [HideInInspector]
    public int nextWayPoint;
    [HideInInspector]
    public float stateTimeElapsed;
    private bool aiActive;
    // Use this for initialization
    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
        void Start () {
		
	}
    public void SetupAI(bool aiActivationFromAIManager, List<Transform> wayPointsFromAIManager)
    {
        wayPointList = wayPointsFromAIManager;
        aiActive = aiActivationFromAIManager;
        if (aiActive)
        {
            navMeshAgent.enabled = true;
        }
        else
        {
            navMeshAgent.enabled = false;
        }
    }
    void Update()
    {
        if (!aiActive)
            return;
        currentState.UpdateState(this);
    }
    public void TransitionToState(State nextState)
    {
        if (nextState != remainState)
        {
            currentState = nextState;
            OnExitState();
        }
    }
    public bool CheckIfCountDownElapsed(float duration)
    {
        stateTimeElapsed += Time.deltaTime;
        return (stateTimeElapsed >= duration);
    }
    private void OnExitState()
    {
        stateTimeElapsed = 0;
    }
    private void OnTriggerEnter(Collider a)
    {
        other = a;
        Debug.Log(a.name);
    }

}
