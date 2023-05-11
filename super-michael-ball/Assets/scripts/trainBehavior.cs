using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trainBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        Vector3 direction = collision.transform.position - transform.position;
        direction = new Vector3(direction.x, direction.y + 10, direction.z);
        rb.AddForce(direction * 1000);
    }
}
