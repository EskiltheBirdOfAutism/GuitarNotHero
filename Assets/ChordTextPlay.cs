using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChordTextPlay : MonoBehaviour
{
    public string chord_text = "Em";
    public TextMeshProUGUI text_component;
    public int chord_index = 0;
    bool played = false;
    public GameObject chord_object;
    public GameObject player;
    public int order_index = 0;
    public int strum = 0;
    public AudioSource fail;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text_component.text = chord_text;
        transform.position += new Vector3(-1f, 0f, 0f);
        if(transform.position.x <= 200f && transform.position.x >= 120f && played == false
        && chord_object.GetComponent<ChordTextCode>().chord_index == chord_index
        && player.GetComponent<PlayerMovement>().play == true
        && order_index == chord_object.GetComponent<ChordTextCode>().order_index
        && player.GetComponent<PlayerMovement>().strum == strum)
        {
            transform.localScale = new Vector3(2f, 2f, 1f);
            played = true;
            chord_object.GetComponent<ChordTextCode>().order_index++;
            player.GetComponent<PlayerMovement>().played = 5;
            player.GetComponent<PlayerMovement>().hp += 50;
            player.GetComponent<PlayerMovement>().block = true;
        }

        if (transform.position.x < 120f && played == false)
        {
            fail.Play();
            chord_object.GetComponent<ChordTextCode>().order_index++;
            text_component.color = new Color(1, 0, 0);
            played = true;
            player.GetComponent<PlayerMovement>().played = 5;
            player.GetComponent<PlayerMovement>().block = false;
        }

        transform.localScale += (new Vector3(1f, 1f, 1f) - transform.localScale) * 0.1f;

        if (transform.position.x <= -20) Destroy(gameObject);
    }
}
