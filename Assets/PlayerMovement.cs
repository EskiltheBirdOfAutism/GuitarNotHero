using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject orientation;
    public Animator player_animation;
    public Animator hand_animation;
    public GameObject particle;
    public GameObject camera_object;
    public GameObject text_object;
    public int chord = 0;
    public bool play = false;
    public int strum = -1;
    public AudioSource audio_component;
    public AudioClip[] sound;
    public int played = 0;
    public bool block = false;
    public float hp = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _h_input = Input.GetAxisRaw("Horizontal");
        float _v_input = Input.GetAxisRaw("Vertical");

        Vector3 _move_direction = orientation.transform.forward * _v_input + orientation.transform.right * _h_input;

        if (_h_input != 0f || _v_input != 0f)
        {
            rb.velocity += ((_move_direction.normalized * 7000f * Time.deltaTime) - rb.velocity) * 0.25f;
            player_animation.Play("PlayerRun");
        }
        else
        {
            rb.velocity += (new Vector3(0f, 0f, 0f) - rb.velocity) * 0.25f;
            player_animation.Play("PlayerIdle");
        }

        if (Input.GetKeyDown("0"))
        {
            chord = 0;
            text_object.GetComponent<ChordTextCode>().chord_text = "Em";
            text_object.GetComponent<ChordTextCode>().chord_index = chord;
        }
        if (Input.GetKeyDown("1"))
        {
            chord = 1;
            text_object.GetComponent<ChordTextCode>().chord_text = "A";
            text_object.GetComponent<ChordTextCode>().chord_index = chord;
        }
        if (Input.GetKeyDown("2"))
        {
            chord = 2;
            text_object.GetComponent<ChordTextCode>().chord_text = "B";
            text_object.GetComponent<ChordTextCode>().chord_index = chord;
        }
        if (Input.GetKeyDown("3"))
        {
            chord = 3;
            text_object.GetComponent<ChordTextCode>().chord_text = "C";
            text_object.GetComponent<ChordTextCode>().chord_index = chord;
        }
        if (Input.GetKeyDown("4"))
        {
            chord = 4;
            text_object.GetComponent<ChordTextCode>().chord_text = "D";
            text_object.GetComponent<ChordTextCode>().chord_index = chord;
        }
        if (Input.GetKeyDown("5"))
        {
            chord = 5;
            text_object.GetComponent<ChordTextCode>().chord_text = "E";
            text_object.GetComponent<ChordTextCode>().chord_index = chord;
        }
        if (Input.GetKeyDown("6"))
        {
            chord = 6;
            text_object.GetComponent<ChordTextCode>().chord_text = "F";
            text_object.GetComponent<ChordTextCode>().chord_index = chord;
        }
        if (Input.GetKeyDown("7"))
        {
            chord = 7;
            text_object.GetComponent<ChordTextCode>().chord_text = "G";
            text_object.GetComponent<ChordTextCode>().chord_index = chord;
        }
        if (Input.GetKeyDown("8"))
        {
            chord = 8;
            text_object.GetComponent<ChordTextCode>().chord_text = "B7";
            text_object.GetComponent<ChordTextCode>().chord_index = chord;
        }
        if (Input.GetKeyDown("9"))
        {
            chord = 9;
            text_object.GetComponent<ChordTextCode>().chord_text = "Cm";
            text_object.GetComponent<ChordTextCode>().chord_index = chord;
        }

        play = false;
        played--;

        strum = -1;

        if (Input.GetMouseButtonDown(0))
        {
            strum = 0;
            play = true;
            if (chord == 0)
            {
                audio_component.clip = sound[6];
            }
            if (chord == 1)
            {
                audio_component.clip = sound[0];
            }
            if (chord == 2)
            {
                audio_component.clip = sound[2];
            }
            if (chord == 3)
            {
                audio_component.clip = sound[4];
            }
            if (chord == 4)
            {
                audio_component.clip = sound[8];
            }
            if (chord == 5)
            {
                audio_component.clip = sound[10];
            }
            if (chord == 6)
            {
                audio_component.clip = sound[12];
            }
            if (chord == 7)
            {
                audio_component.clip = sound[14];
            }
            if (chord == 8)
            {
                audio_component.clip = sound[16];
            }
            if (chord == 9)
            {
                audio_component.clip = sound[18];
            }

            hand_animation.Play("PlayerHandChordA", -1, normalizedTime: 0f);

            audio_component.Play();
            camera_object.GetComponent<CameraMovement>().shake = 0.75f;
            Instantiate(particle, transform.position, Quaternion.identity * Quaternion.Euler(90f, 0f, 0f));
        }

        if (Input.GetMouseButtonDown(1))
        {
            strum = 1;
            play = true;
            if (chord == 0)
            {
                audio_component.clip = sound[7];
            }
            if (chord == 1)
            {
                audio_component.clip = sound[1];
            }
            if (chord == 2)
            {
                audio_component.clip = sound[3];
            }
            if (chord == 3)
            {
                audio_component.clip = sound[5];
            }
            if (chord == 4)
            {
                audio_component.clip = sound[9];
            }
            if (chord == 5)
            {
                audio_component.clip = sound[11];
            }
            if (chord == 6)
            {
                audio_component.clip = sound[13];
            }
            if (chord == 7)
            {
                audio_component.clip = sound[15];
            }
            if (chord == 8)
            {
                audio_component.clip = sound[17];
            }
            if (chord == 9)
            {
                audio_component.clip = sound[19];
            }

            hand_animation.Play("PlayerHandChordAU", -1, normalizedTime: 0f);

            audio_component.Play();
            camera_object.GetComponent<CameraMovement>().shake = 0.75f;
            Instantiate(particle, transform.position, Quaternion.identity * Quaternion.Euler(90f, 0f, 0f));
        }

        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y - 1000f * Time.deltaTime, rb.velocity.z);

        transform.forward += (_move_direction.normalized - transform.forward) * 0.035f;

        hp = Mathf.Clamp(hp, 0, 1000);

        if(hp <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
