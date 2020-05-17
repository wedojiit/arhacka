using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class statsHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Spawned;
    public Text Dead;
    public Text Healthy;
    public Text mHealthy;
    public Text Sick;
    public Text mSick;

    public int spa;
    public int ded;
    public int hlth;
    public int mhlth;
    public int sck;
    public int msck;

    void Start()
    {
        spa=0;
        ded=0;
        hlth=0;
        mhlth=0;
        sck=0;
        msck=0;
    }

    // Update is called once per frame
    void Update()
    {
        Spawned.text=spa.ToString();
         Dead.text=ded.ToString();
          Healthy.text=hlth.ToString();
           mHealthy.text=mhlth.ToString();
            Sick.text=sck.ToString();
             mSick.text=msck.ToString();
    }
}
