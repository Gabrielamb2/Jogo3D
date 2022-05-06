using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sokoban : MonoBehaviour
{
    [SerializeField]
    private float forceMagnitude;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("pushable")){
            Rigidbody rigidbody = hit.collider.attachedRigidbody;
            if (rigidbody != null){
                Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
                forceDirection.y=0;
                forceDirection.Normalize();

                rigidbody.AddForceAtPosition(forceDirection*forceMagnitude, transform.position, ForceMode.Impulse);
            }
        }
    }
}

// https://www.youtube.com/watch?v=3BOn2gs7z04