using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour {
    public GameObject hit;
    public Command[] commandList;
    public float[] commandTime;
	// Use this for initialization
	void Start () {
		
	}
	public void Check()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                //划出射线，只有在scene视图中才能看到
                Debug.DrawLine(ray.origin, hitInfo.point);
                GameObject gameObj = hitInfo.collider.gameObject;
                Debug.Log("click object name is " + gameObj.name);
                gameObj.GetComponent<CommandManager>();
                

            }
        }
    }

	// Update is called once per frame
	void Update () {
    }
}
