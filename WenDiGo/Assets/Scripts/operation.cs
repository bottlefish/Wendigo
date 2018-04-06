using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "PluggableAI/Operation")]
public abstract class operation : ScriptableObject {

    public abstract void Operation(StateController controller);
}
