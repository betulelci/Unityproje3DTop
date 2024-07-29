using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esneksilindir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
     private void OnCollisionEnter(Collision collision ){
        Vector3 topkonum= collision.transform.position;
        Vector3 esnekkonum=transform.position;
        collision.gameObject.GetComponent<Rigidbody>().velocity =(topkonum-esnekkonum)*10 ;
       
}
    }
