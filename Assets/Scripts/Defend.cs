using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend : MonoBehaviour
{
    public GameObject bulletPref;
    public Transform bulletSpawn;
    public Transform target;
    public float count = 0.5f;

    public float timer;

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
        if (target != null)
        {
            if (timer >= count)
            {
                transform.LookAt(target.position);
                Fire();
                timer = 0;
            }
        }
        else
        {
            target = GameObject.FindGameObjectWithTag("Enemy").transform;
        }
    }
    void Fire()
    {
            GameObject bullet = Instantiate(bulletPref, bulletSpawn.position, bulletSpawn.rotation);

            bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;
            Destroy(bullet, 2.0f);
    }
}
