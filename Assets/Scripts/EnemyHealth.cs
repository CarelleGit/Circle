using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int bullet;
    public int health;
    public TowerHealth deathMoney;
    int payment = 5;

    public Slider healthSlider;
    // Use this for initialization
    void Start()
    {
        GameObject.FindGameObjectWithTag("Tower").GetComponent<TowerHealth>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullets")
        {
            health -= bullet;
        }
    }
    // Update is called once per frame
    void Update()
    {
        Death();
        healthSlider.value = health;
    }
    void Death()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
