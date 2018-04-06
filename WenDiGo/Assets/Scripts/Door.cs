using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Door : MonoBehaviour {

   
    private bool flag=false;
    private bool isFinished = false;
    public Vector3 roation;

	public bool Open()
    {          
            Debug.Log("get");
            Vector3 end = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 90, transform.rotation.eulerAngles.z);
            Tweener a = transform.DORotate(roation,1);
        a.OnComplete(Complete);
        return isFinished;
      
        
        
    }
    public void Complete()
    {
        isFinished = true;
    }


}
