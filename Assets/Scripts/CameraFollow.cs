using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    private void Update()
    {
        if(target != null)
        {
            transform.position = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);
        }
        
    }
}
