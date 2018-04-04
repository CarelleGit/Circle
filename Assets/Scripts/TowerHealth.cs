using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TowerHealth : MonoBehaviour
{
    public int health = 12;
    [SerializeField]
    int enemyDamage = 1;


    public Slider healthSlider;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            health -= enemyDamage;
        }
    }
    private void Update()
    {
        healthSlider.value = health;
        death();
    }
    void death()
    {
        if(health <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
