using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIManager : MonoBehaviour {

    private StateController m_StateController;
    public List<Transform> m_WayPointList;
    public Transform target;
    [HideInInspector]
    //public GameObject m_Instance;

    public void SetupAI()
    {
        m_StateController = GetComponent<StateController>();
        m_StateController.SetupAI(true, m_WayPointList,target);
    }
        void Start () {
        SetupAI();
		
	}
	// Update is called once per frame
	void Update () {
		
	}
}
