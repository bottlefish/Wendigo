using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public AIManager[] m_AI;
    // Use this for initialization
    void Start () {
        SetupAI();
		
	}
	public void SetupAI()
    {
        for(int i=0;i<m_AI.Length;i++)
        {
            m_AI[i].SetupAI();
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
