using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransToWalk :operation{

    public override void Operation(StateController controller)
    {
        controller.TransToWalk();

    }
}
