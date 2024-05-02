using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarCode : MonoBehaviour
{
    public Slider slider;
    public GameObject player;
    float value = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        value += ((player.GetComponent<PlayerMovement>().hp / 1000) - value) * 0.1f;
        slider.value = value;
    }
}
