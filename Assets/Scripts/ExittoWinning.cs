using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExittoWinning : MonoBehaviour
{
    private CoinController pc;
    // Start is called before the first frame update
    void Start()
    {
        pc = FindObjectOfType<CoinController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Player"))
        {
            if (pc.coin == 10)
            {
                SceneManager.LoadScene("Winning");
            }
            Debug.Log(pc.coin);
        }
    }
}
