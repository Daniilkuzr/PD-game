using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health;
    public Healthbar healthbar;
    public GameObject enemy;
    public float damage;
    public bool trig;
    public PlayerController player;

    private float timeBtwShots;
    public float StartTimeBtwShots = 2;

    private Animator anim;


    public void TakeDamage(float damage)
    {
        
        health -= damage ;
        healthbar.SetHealth(health);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       


        if(collision.gameObject.name=="Player")
        {
            if (timeBtwShots <= 0)
            {
                trig = true;
                player.TakeDamage(damage);
                timeBtwShots = StartTimeBtwShots;
            }
            else
            {
                timeBtwShots -= Time.deltaTime;
                trig = false;
            }
            //trig = true;
            //player.TakeDamage(damage);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            trig = false;

        }

    }



    // Start is called before the first frame update
    void Start()
    {
        healthbar.maxHealth= health;
        healthbar.SetHealth(health);
    }

    // Update is called once per frame
    void Update()
    {
        anim = GetComponent<Animator>();

        if (trig)
        {
            player.TakeDamage(damage);
        }


        if(health<=0)
        {
            Destroy(gameObject);
            Destroy(enemy);
        }
    }

    private States State
    {
        get { return (States)anim.GetInteger("state"); }
        set { anim.SetInteger("state", (int)value); }
    }


    public enum States
    {
        run,
        idle

    }
}
