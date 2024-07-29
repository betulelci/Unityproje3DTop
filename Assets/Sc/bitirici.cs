using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bitirici : MonoBehaviour
{
  public void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.tag == "Player") 
    {
      Debug.Log("Level Geçildiiiii...");
      DataBase.SaveData();
      SceneManager.LoadScene("MainMenu");
      
    }
  }

}
