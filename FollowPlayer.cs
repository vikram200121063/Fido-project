
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform fidoTransform;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = transform.position;
        cameraPos.z= fidoTransform.position.z + offset;
        transform.position = cameraPos;
        
    }
}

