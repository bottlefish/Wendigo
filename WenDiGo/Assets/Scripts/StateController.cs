using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour {

    public State currentState;
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
    public Transform m_target;
    [HideInInspector]
    public int nextWayPoint;
    [HideInInspector]
    public float stateTimeElapsed;
    private bool aiActive;
    public bool isWalk = false;
    IEnumerator wait(float time,int i)
    {
        yield return new WaitForSeconds(time);
    }
    private void TestInput()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            isWalk = !isWalk;
        }
    }
    // Use this for initialization
    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
        void Start () {
		
	}
    public void SetupAI(bool aiActivationFromAIManager, List<Transform> wayPointsFromAIManager,Transform target)
    {
        m_target = target;
        wayPointList = wayPointsFromAIManager;
        aiActive = aiActivationFromAIManager;

    }
    void Update()
    {
        TestInput();
        if (!aiActive)
            return;
        currentState.UpdateState(this);
    }
    public void TransitionToState(State nextState)
    {
        
        
            currentState = nextState;
            OnExitState();
        
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
    public void TransToWalk()
    {
        isWalk = true;
    }

}
