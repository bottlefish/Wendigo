using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayMaker;

public class CommandManager : MonoBehaviour {

    public PlayMakerFSM fsm;
    public Command[] commandList;
    public float[] commandTime;

    IEnumerator DoCommand()
    {
        for (int i = 0; i < commandList.Length; i++)
        {
            yield return new WaitForSeconds(commandTime[i]);
            commandList[i].Execute(fsm);
            Debug.Log("sentEvent");
            //yield return new WaitForSeconds(commandTime[i]);
        }                    
    }
    
	void Start () {
        StartCoroutine(DoCommand());
	}

	void Update () {
		//if(Input.GetKeyDown(KeyCode.Q))
  //      {
  //          fsm.SendEvent("Walk");
  //      }
	}
}
