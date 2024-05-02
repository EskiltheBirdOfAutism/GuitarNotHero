using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class EnemySpawnCode : MonoBehaviour
{
    public GameObject player;
    public int index = 0;
    public GameObject enemy;
    int wave = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("EnemyObject(Clone)") == null)
        {
            wave++;
            if (wave == 1)
            {
                GameObject _instance = Instantiate(enemy, transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)), Quaternion.identity);
                _instance.GetComponent<EnemyMovement>().player = player;
                _instance.GetComponent<EnemyMovement>().index = 0;
                _instance.GetComponent<EnemyMovement>().spawn = gameObject;

            }

            if (wave == 2)
            {
                GameObject _instance = Instantiate(enemy, transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)), Quaternion.identity);
                _instance.GetComponent<EnemyMovement>().player = player;
                _instance.GetComponent<EnemyMovement>().index = 1;
                _instance.GetComponent<EnemyMovement>().spawn = gameObject;
                _instance = Instantiate(enemy, transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)), Quaternion.identity);
                _instance.GetComponent<EnemyMovement>().player = player;
                _instance.GetComponent<EnemyMovement>().index = 2;
                _instance.GetComponent<EnemyMovement>().spawn = gameObject;
            }

            if (wave == 3)
            {
                GameObject _instance = Instantiate(enemy, transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)), Quaternion.identity);
                _instance.GetComponent<EnemyMovement>().player = player;
                _instance.GetComponent<EnemyMovement>().index = 3;
                _instance.GetComponent<EnemyMovement>().spawn = gameObject;
                _instance = Instantiate(enemy, transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)), Quaternion.identity);
                _instance.GetComponent<EnemyMovement>().player = player;
                _instance.GetComponent<EnemyMovement>().index = 4;
                _instance.GetComponent<EnemyMovement>().spawn = gameObject;
            }

            if (wave == 4)
            {
                GameObject _instance = Instantiate(enemy, transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)), Quaternion.identity);
                _instance.GetComponent<EnemyMovement>().player = player;
                _instance.GetComponent<EnemyMovement>().index = 5;
                _instance.GetComponent<EnemyMovement>().spawn = gameObject;
                _instance = Instantiate(enemy, transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)), Quaternion.identity);
                _instance.GetComponent<EnemyMovement>().player = player;
                _instance.GetComponent<EnemyMovement>().index = 6;
                _instance.GetComponent<EnemyMovement>().spawn = gameObject;
                _instance = Instantiate(enemy, transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)), Quaternion.identity);
                _instance.GetComponent<EnemyMovement>().player = player;
                _instance.GetComponent<EnemyMovement>().index = 7;
                _instance.GetComponent<EnemyMovement>().spawn = gameObject;
            }

            if (wave == 5)
            {
                GameObject _instance = Instantiate(enemy, transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)), Quaternion.identity);
                _instance.GetComponent<EnemyMovement>().player = player;
                _instance.GetComponent<EnemyMovement>().index = 8;
                _instance.GetComponent<EnemyMovement>().spawn = gameObject;
                _instance = Instantiate(enemy, transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)), Quaternion.identity);
                _instance.GetComponent<EnemyMovement>().player = player;
                _instance.GetComponent<EnemyMovement>().index = 9;
                _instance.GetComponent<EnemyMovement>().spawn = gameObject;
                _instance = Instantiate(enemy, transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)), Quaternion.identity);
                _instance.GetComponent<EnemyMovement>().player = player;
                _instance.GetComponent<EnemyMovement>().index = 10;
                _instance.GetComponent<EnemyMovement>().spawn = gameObject;
                _instance = Instantiate(enemy, transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)), Quaternion.identity);
                _instance.GetComponent<EnemyMovement>().player = player;
                _instance.GetComponent<EnemyMovement>().index = 11;
                _instance.GetComponent<EnemyMovement>().spawn = gameObject;
                _instance = Instantiate(enemy, transform.position + new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2)), Quaternion.identity);
                _instance.GetComponent<EnemyMovement>().player = player;
                _instance.GetComponent<EnemyMovement>().index = 12;
                _instance.GetComponent<EnemyMovement>().spawn = gameObject;
            }
        }
    }
}
