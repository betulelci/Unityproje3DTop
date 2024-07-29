using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawnsistemi : MonoBehaviour
{
private void Start()
    {
        if( DataBase.SpawmPosition==Vector3.zero)
        {
            DataBase.SpawmPosition=transform.position;
        }
        transform.position=DataBase.SpawmPosition;
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.R)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Restart"){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);}
    }
}
