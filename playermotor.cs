using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermotor : MonoBehaviour
{
    public float Speed;
    public float AngularSpeed;
    protected Rigidbody r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

  private void FixedUpdate() {
      Speed = r.velocity.magnitude;
      AngularSpeed = r.angularVelocity.magnitude;
      if(Input.GetKey(KeyCode.UpArrow))
      {
        r.AddTorque(Vector3.right);
      }
      if(Input.GetKey(KeyCode.DownArrow))
      {
        r.AddTorque(Vector3.left);
      }
      if(Input.GetKey(KeyCode.RightArrow))
      {
        r.AddTorque(Vector3.back);
      }
      if(Input.GetKey(KeyCode.LeftArrow))
      {
        r.AddTorque(Vector3.forward);
      }
     
      
  }
}
