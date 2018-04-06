using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Door")]
public class DoorAction : Action {

    public override void Act(StateController controller)
    {
        OpenDoor(controller);
    }
    public void OpenDoor(StateController controller)
    {

        bool isFinished = false;
        if (controller.other != null)
            isFinished = controller.other.gameObject.GetComponent<Door>().Open();
        if(isFinished)
        {
            Debug.Log("AAAAA");
        }
    }

}
