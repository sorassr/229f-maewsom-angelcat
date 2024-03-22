using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreditScene()
    {
        SceneManager.LoadScene("Credit");
    }
    
    public void GameScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void StartScene()
    {
        SceneManager.LoadScene("Start");
    }
    
}
