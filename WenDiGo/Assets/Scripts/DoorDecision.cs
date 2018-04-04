using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/Door")]
public class DoorDecision : Decision
{
    //private bool isOpened;
    public override bool Decide(StateController controller)
    {
        bool targetVisible = CheckDoor(controller);
        return targetVisible;
    }
    private bool CheckDoor(StateController controller)
    {        
        Debug.DrawRay(controller.eyes.position, controller.eyes.forward.normalized * controller.aiInfo.lookRange, Color.green);

        if (controller.other!= null&&controller.other.tag == "Door")
        {
            return true;
        }
        else
        {
            return false;
        } 
    }
}
