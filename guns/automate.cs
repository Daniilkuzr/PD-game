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

        //if (timeBtwShots <= 0 && Ochered <=0)
        //{
        //    Instantiate(bullet, shotPoint.position, transform.rotation);
        //    Ochered = StartTimeOcheredShots;

        //}
        //else if


        //else
        //{
        //    timeBtwShots -= Time.deltaTime;
        //}
    }

    void Burst()
    {

    }
}
