using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayMaker;
[CreateAssetMenu(menuName = "PluggableAI/Command/Walk")]
public class WalkCommand : Command {

    public override void Execute(PlayMakerFSM fsm)
    {
        fsm.SendEvent("Walk");
        Debug.Log("walk");
    }
}
