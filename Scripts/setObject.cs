using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setObject : MonoBehaviour
{
    public ObjectSpawner s_obj;
    public GameObject pan;

    bool dbool=true;
    public void panController()
    {
        pan.SetActive(dbool);
        dbool=!dbool;
    }
   public void healthy()
    {
        s_obj.k=0;
    }
    public void healthyMask()
    {
        s_obj.k=1;
    }
     public void sicky()
    {
        s_obj.k=2;
    }
     public void sickyMask()
    {
        s_obj.k=3;
    }
}
