using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class ChordTextCode : MonoBehaviour
{
    public string chord_text = "Em";
    public TextMeshProUGUI text_component;
    public int chord_index = 0;
    public int order_index = 0;
    public int[] order = new int[99];
    public int[] strum = new int[99];
    public int[] time = new int[99];
    //public int[] order = new int[] {1, 1, 1, 1, 1, 1, 4, 4, 4, 4, 4, 4, 1, 1, 1, 1, 1, 1, 0};
    //public int[] strum = new int[] {0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0};
    //public int[] time = new int[] {0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0};
    float timer = 1f;
    float bpm = 60f;
    public GameObject chord;
    public GameObject player;
    int next_chord = 0;
    public GameObject canvas_object;
    int max_chord = 17;

    // Start is called before the first frame update
    void Start()
    {
        

        //Random Song
        
        order[0] = 0;
        order[1] = 0;
        order[2] = 3;
        order[3] = 2;
        order[4] = 0;
        order[5] = 0;
        order[6] = 1;
        order[7] = 2;
        order[8] = 0;
        order[9] = 0;

        strum[0] = 0;
        strum[1] = 1;
        strum[2] = 0;
        strum[3] = 1;
        strum[4] = 0;
        strum[5] = 1;
        strum[6] = 0;
        strum[7] = 1;
        strum[8] = 0;
        strum[9] = 0;

        time[0] = 0;
        time[1] = 0;
        time[2] = 0;
        time[3] = 0;
        time[4] = 0;
        time[5] = 0;
        time[6] = 0;
        time[7] = 0;
        time[8] = 0;
        time[9] = 0;
        time[10] = 0;
        bpm = 60f;
        max_chord = 10;
    }

    // Update is called once per frame
    void Update()
    {
        //  Debug.Log(strum[next_chord]);

        if(timer <= 0f && next_chord < max_chord)
        {
            GameObject chord_object = Instantiate(chord, new Vector3(1600, 120, 0), Quaternion.identity);
            chord_object.GetComponent<ChordTextPlay>().chord_object = gameObject;
            chord_object.GetComponent<ChordTextPlay>().player = player;
            chord_object.GetComponent<ChordTextPlay>().chord_index = order[next_chord];
            chord_object.transform.SetParent(canvas_object.transform);
            chord_object.GetComponent<ChordTextPlay>().strum = strum[next_chord];
            chord_object.GetComponent<ChordTextPlay>().order_index = next_chord;
            if (order[next_chord] == 0)
            {
                chord_object.GetComponent<ChordTextPlay>().chord_text = "Em";
                if (strum[next_chord] == 0) chord_object.GetComponent<ChordTextPlay>().chord_text = "Em-D";
                if (strum[next_chord] == 1) chord_object.GetComponent<ChordTextPlay>().chord_text = "Em-U";
            }
            if (order[next_chord] == 1)
            {
                chord_object.GetComponent<ChordTextPlay>().chord_text = "A";
                if (strum[next_chord] == 0) chord_object.GetComponent<ChordTextPlay>().chord_text = "A-D";
                if (strum[next_chord] == 1) chord_object.GetComponent<ChordTextPlay>().chord_text = "A-U";
            }
            if (order[next_chord] == 2)
            {
                chord_object.GetComponent<ChordTextPlay>().chord_text = "B";
                if (strum[next_chord] == 0) chord_object.GetComponent<ChordTextPlay>().chord_text = "B-D";
                if (strum[next_chord] == 1) chord_object.GetComponent<ChordTextPlay>().chord_text = "B-U";
            }
            if (order[next_chord] == 3)
            {
                chord_object.GetComponent<ChordTextPlay>().chord_text = "C";
                if (strum[next_chord] == 0) chord_object.GetComponent<ChordTextPlay>().chord_text = "C-D";
                if (strum[next_chord] == 1) chord_object.GetComponent<ChordTextPlay>().chord_text = "C-U";
            }
            if (order[next_chord] == 4)
            {
                chord_object.GetComponent<ChordTextPlay>().chord_text = "D";
                if (strum[next_chord] == 0) chord_object.GetComponent<ChordTextPlay>().chord_text = "D-D";
                if (strum[next_chord] == 1) chord_object.GetComponent<ChordTextPlay>().chord_text = "D-U";
            }
            if (order[next_chord] == 5)
            {
                chord_object.GetComponent<ChordTextPlay>().chord_text = "E";
                if (strum[next_chord] == 0) chord_object.GetComponent<ChordTextPlay>().chord_text = "E-D";
                if (strum[next_chord] == 1) chord_object.GetComponent<ChordTextPlay>().chord_text = "E-U";
            }
            if (order[next_chord] == 6)
            {
                chord_object.GetComponent<ChordTextPlay>().chord_text = "F";
                if (strum[next_chord] == 0) chord_object.GetComponent<ChordTextPlay>().chord_text = "F-D";
                if (strum[next_chord] == 1) chord_object.GetComponent<ChordTextPlay>().chord_text = "F-U";
            }
            if (order[next_chord] == 7)
            {
                chord_object.GetComponent<ChordTextPlay>().chord_text = "G";
                if (strum[next_chord] == 0) chord_object.GetComponent<ChordTextPlay>().chord_text = "G-D";
                if (strum[next_chord] == 1) chord_object.GetComponent<ChordTextPlay>().chord_text = "G-U";
            }
            if (order[next_chord] == 8)
            {
                chord_object.GetComponent<ChordTextPlay>().chord_text = "B7";
                if (strum[next_chord] == 0) chord_object.GetComponent<ChordTextPlay>().chord_text = "B7-D";
                if (strum[next_chord] == 1) chord_object.GetComponent<ChordTextPlay>().chord_text = "B7-U";
            }
            if (order[next_chord] == 9)
            {
                chord_object.GetComponent<ChordTextPlay>().chord_text = "Cm";
                if (strum[next_chord] == 0) chord_object.GetComponent<ChordTextPlay>().chord_text = "Cm-D";
                if (strum[next_chord] == 1) chord_object.GetComponent<ChordTextPlay>().chord_text = "Cm-U";
            }
            next_chord++;

            timer = 60f/bpm;
            if (time[next_chord] == 1) timer = (60f / bpm) * 0.5f;
        }
        timer -= Time.deltaTime;

        if (next_chord == max_chord)
        {
            next_chord = 0;
        }

        if (chord_index == max_chord)
        {
            chord_index = 0;
        }

        if (order_index == max_chord)
        {
            order_index = 0;
        }

        text_component.text = chord_text;
    }
}
