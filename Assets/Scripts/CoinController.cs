using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class CoinController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    public int coin;    
    
    // Start is called before the first frame update


    // Update is called once per frame
    private void Start()
    {
        coin = 0;
        text.text = $"coin : {coin}";
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            coin++;
            text.text = $"coin : {coin}";
        
            Destroy(other.gameObject);
        }
    }
}
