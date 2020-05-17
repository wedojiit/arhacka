using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthyMaskChanger : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject[] sickprefabs; 
    GameObject statMan;
    statsHandler vp; 

    int ch=1;
    void Start()
    {
         statMan= GameObject.Find("Stats"); 
        vp=statMan.GetComponent<statsHandler>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider col) 
    {
            int prob=Random.Range(0,500);
		
          //   int k;
         //   Debug.Log(col.gameObject.name[7]);
         if(col.gameObject.tag=="S" && prob<200)
         {
              if(ch==1)
              {
                  int tot=vp.spa-vp.hlth-vp.msck-vp.sck;
            if(tot-vp.hlth-1==0)
           { vp.mhlth--;
              ch++;
             int rand=Random.Range(0,2);
             Debug.Log("crashed with sick");
             if(rand==0)
             vp.sck++;
             else
             vp.msck++;
             
              Instantiate(sickprefabs[rand], transform.position, Quaternion.identity);
           }
             }
              Destroy(this.gameObject);
         }

         if(col.gameObject.tag=="SM" && prob<50)
         {
             if(ch==1 )
              {
            int tot=vp.spa-vp.hlth-vp.msck-vp.sck;
            if(tot-vp.hlth-1==0)
           {
            vp.mhlth--;
              ch++;
             int rand=Random.Range(0,2);
             Debug.Log("crashed with sick");
             if(rand==0)
             vp.sck++;
             else
             vp.msck++;
             vp.mhlth--;
              Instantiate(sickprefabs[rand], transform.position, Quaternion.identity);
           }
            }
              Destroy(this.gameObject);
         }
    }

    void OnTriggerExit(Collider col)
    {
             if(col.gameObject.tag=="S" || col.gameObject.tag=="SM")
             ch=1;
         
    }
}
