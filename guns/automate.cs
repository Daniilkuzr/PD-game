using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automate : MonoBehaviour
{
    public GameObject bullet;
    public Transform shotPoint;

    private float timeBtwShots;
    public float StartTimeBtwShots;
    public float StartTimeOcheredShots;
    private float Ochered;
    private float pul;

    public bool strike;


    
    void Start()
    {
        
    }

    
    void Update()
    {

        if (timeBtwShots <= 0 && strike == true)
        {
            Instantiate(bullet, shotPoint.position, transform.rotation);
            timeBtwShots = StartTimeBtwShots;
            oboima--;

        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

        if (oboima <= 0) strike = false;
        if (strike == false && Ochered >= 0)
        {
            Ochered -= Time.deltaTime;
        }
        else
        {
            Ochered = StartTimeOcheredShots;
            strike = true;
            oboima = pul;
        }
        BtwShots -= Time.deltaTime;
        //}
    }

    void Burst()
    {

    }
}
