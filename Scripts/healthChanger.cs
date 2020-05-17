using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthChanger : MonoBehaviour
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
       // Debug.Log(vp.ded++);
    }
    void OnTriggerEnter(Collider col) 
    {
            int prob=Random.Range(0,500);
		
          //   int k;
         //   Debug.Log(col.gameObject.name[7]);
         if(col.gameObject.tag=="S" && prob<350)
         {
               if(ch==1 && vp.hlth>=0)
             {  
                  if(vp.hlth>0)
                 vp.hlth--;
              ch++;
             int rand=Random.Range(0,2);
             Debug.Log("crashed with sick");
             if(rand==0)
             vp.sck++;
             else
             vp.msck++;
            
              Instantiate(sickprefabs[rand], transform.position, Quaternion.identity);
              
             }
              Destroy(this.gameObject);
         }
         if(col.gameObject.tag=="SM" && prob<100)
         {
                 if(ch==1 && vp.hlth>=0)
             {   if(vp.hlth>0)
                 vp.hlth--;
              ch++;
             int rand=Random.Range(0,2);
             Debug.Log("crashed with sick");
             if(rand==0)
             vp.sck++;
             else
             vp.msck++;
             
              Instantiate(sickprefabs[rand], transform.position, Quaternion.identity);
        
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
