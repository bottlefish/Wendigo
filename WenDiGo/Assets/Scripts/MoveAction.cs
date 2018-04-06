using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Move")]
public class MoveAction: Action
{
    public override void Act(StateController controller)
    {
        Move(controller);
    }

    private void Move(StateController controller)   
    {
        Debug.Log("Move");
        controller.navMeshAgent.enabled = true;
        controller.navMeshAgent.destination = controller.m_target.position;
        //controller.navMeshAgent.isStopped = false;
    }
}