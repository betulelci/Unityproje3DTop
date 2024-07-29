using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tranbolinsc : MonoBehaviour
{
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision ){
        Vector3 Yenihiz;
        Yenihiz.x=collision.gameObject.GetComponent<Rigidbody>().velocity.x;
        Yenihiz.y=10f;
        Yenihiz.z=collision.gameObject.GetComponent<Rigidbody>().velocity.z;
        Debug.Log(Yenihiz);
        collision.gameObject.GetComponent<Rigidbody>().velocity=Yenihiz;

}
}
