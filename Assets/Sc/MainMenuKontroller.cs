using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuKontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataBase.LoadData();
    }

    public void ClickPlayButton()
    {
     SceneManager.LoadScene("Level01");
    SceneManager.LoadScene("Level02");
    SceneManager.LoadScene("Level03");
     
    }
    
}
    
