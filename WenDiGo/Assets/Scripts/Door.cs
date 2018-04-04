using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Door : MonoBehaviour {

    private bool flag=false;

	public bool Open()
    {
        if (!flag)
        {
            Debug.Log("isopem");
            flag = true;
            return true;
        }
        return false;
    }

}
