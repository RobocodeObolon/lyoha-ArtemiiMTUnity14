using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFireball : MonoBehaviour
{
    public GameObject fireball;
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Spawn), 1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        GameObject temp = Instantiate(fireball, transform.position, Quaternion.identity);
        temp.transform.right = GameObject.Find("Player").transform.position - temp.transform.position;
        temp.GetComponent<Rigidbody2D>().AddForce(temp.transform.right * 15, ForceMode2D.Impulse);
    }
}
