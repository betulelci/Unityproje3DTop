using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour
{
   [SerializeField]GameObject FallowObj;
   [SerializeField]Vector3 Offset;
    void Start()
    {
        
    }

    void Update()
    {
        transform.position=FallowObj.transform.position+Offset;
    }
}
