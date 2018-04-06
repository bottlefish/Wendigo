using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "PluggableAI/Decisions/IdleToWalk")]
public class IdleToWalkDecision : Decision
{
    public override bool Decide(StateController controller)
    {
        if(controller.isWalk)
        {
            return true;
        }        
        else
        {
            return false;
        }

    }
}
