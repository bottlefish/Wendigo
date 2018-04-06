using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayMaker;
[CreateAssetMenu(menuName = "PluggableAI/Command/Idle")]
public class IdleCommand : Command
{

    public override void Execute(PlayMakerFSM fsm)
    {
        fsm.SendEvent("Idle");
        Debug.Log("idle");
    }
}
