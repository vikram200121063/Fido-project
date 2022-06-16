using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class servo : MonoBehaviour
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
     
       if(Input.GetKey(KeyCode.A))
      {
        r.AddTorque(Vector3.up);
      }
      if(Input.GetKey(KeyCode.D))
      {
        r.AddTorque(Vector3.down);
      }
  }
}
