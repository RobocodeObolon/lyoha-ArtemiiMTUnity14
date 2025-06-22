using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSettings : MonoBehaviour
{
    public int health = 3;
    public Sprite[] healthImage;
    public Image healthBar;
    // Start is called before the first frame update
    void Start()
    {
         healthBar.sprite = healthImage[health];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Damage(Vector3 enemyPosition)
    {
        health--;
        Vector3 impulse = transform.position - enemyPosition;
        transform.Translate(impulse * 3f);
        if(health <= 0)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        healthBar.sprite = healthImage[health];
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<fireball>() != null)
            Damage(collision.gameObject.transform.position);
    }
}
