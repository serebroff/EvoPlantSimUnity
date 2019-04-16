

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SunBehaviour : MonoBehaviour
{
    Vector2 pos;
    Vector2 center;
    Vector2 dir;

    public float radius;
    float time = 0;

   // Beam[] ar_beams;


    public float scaledPixelHeight;
    public float screenheight;
    public int num_beams;

    GameObject sun;

    // Start is called before the first frame update
    void Start()
    {
        radius = 10;
        center.Set(0, -radius / 2);
        pos.Set(0, 0);
        time = 0;

        num_beams = 100;
      //  ar_beams = new Beam[num_beams];

        sun = GameObject.Find("sun");
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * 0.1f;

        dir.Set(Mathf.Cos(time), Mathf.Sin(time));

        pos = center + radius * dir;



        sun.transform.position = pos;
        sun.transform.Rotate(new Vector3(0, 0, Time.deltaTime * 10f));

        int i = 0;
    /*    foreach (Beam b in ar_beams)
        {
            i++;
            b.pos = pos + i * Vector2.Perpendicular(dir);
        }*/


        ///////////

        
        screenheight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0)).x;

    }



}
