using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Rigidbody bumper;
    public float yImpact;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ball") && bumper != null)
        {
            Vector3 force = new Vector3(0f, yImpact, 0f);
            bumper.AddForce(force, ForceMode.Impulse);
            Debug.Log("Bumped");    
        }
    }
}
