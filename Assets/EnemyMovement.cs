using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyMovement : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    public Rigidbody rb;
    float timer = 0f;
    int hp = 4;
    public GameObject[] object_flash = new GameObject[5];
    int flash = 0;
    public GameObject spawn;
    public int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= 5f)
        {
            if (spawn.GetComponent<EnemySpawnCode>().index == index)
            {
                if (player.GetComponent<PlayerMovement>().played > 0)
                {
                    if (timer <= 0f)
                    {
                        if (player.GetComponent<PlayerMovement>().block == true)
                        {
                            hp--;

                            flash = 10;
                        }
                        else
                        {
                            player.GetComponent<PlayerMovement>().hp -= 300;
                        }

                        anim.Play("EnemyAttack");

                        timer = 0.1f;
                    }
                }
                else
                {
                    if (timer <= 0f)
                    {
                        anim.Play("EnemyWait");
                    }
                }
            }
            else
            {
                anim.Play("EnemyIdle");
            }

            rb.velocity += (new Vector3(0f, 0f, 0f) - rb.velocity) * 0.25f;
        }
        else
        {
            anim.Play("EnemyRun");

            rb.velocity += (((player.transform.position - transform.position).normalized * 5500f * Time.deltaTime) - rb.velocity) * 0.25f;
        }

        if(flash > 0)
        {
            object_flash[0].SetActive(true);
            object_flash[1].SetActive(true);
            object_flash[2].SetActive(true);
            object_flash[3].SetActive(true);
            object_flash[4].SetActive(true);
        }
        else
        {
            object_flash[0].SetActive(false);
            object_flash[1].SetActive(false);
            object_flash[2].SetActive(false);
            object_flash[3].SetActive(false);
            object_flash[4].SetActive(false);
        }

        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y - 1000f * Time.deltaTime, rb.velocity.z);

        transform.forward += ((player.transform.position - transform.position).normalized - transform.forward) * 0.035f;

        timer -= Time.deltaTime;
        flash--;

        if (hp <= 0)
        {
            spawn.GetComponent<EnemySpawnCode>().index++;

            Destroy(gameObject);
        }
    }
}
