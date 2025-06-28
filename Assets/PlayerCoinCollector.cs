using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCoinCollector : MonoBehaviour
{
    private int coinCount = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            coinCount++;



            Destroy(collision.gameObject);
            Debug.Log("Coins collected:" + coinCount);

        }if (collision.CompareTag("fireball"))
        {
            GetComponent<PlayerSettings>().health--;



            Destroy(collision.gameObject);
            if(GetComponent<PlayerSettings>().health <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
            }

        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
