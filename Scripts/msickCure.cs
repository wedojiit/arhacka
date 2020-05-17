using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class msickCure : MonoBehaviour
{
     float timeLeft=50f;
    GameObject parent;
    public GameObject stats;
    public GameObject[] healthprefabs; 
    int rand;
     int prob;
      GameObject statMan;
    statsHandler vp; 

    
  ObjectSpawner objectSpawner;
     public GameObject spawMan;
    // Start is called before the first frame update
 
    void Start()
    {
         spawMan= GameObject.Find("ObjectSpawner");

        objectSpawner=spawMan.GetComponent<ObjectSpawner>();
        
         statMan= GameObject.Find("Stats"); 
        vp=statMan.GetComponent<statsHandler>();
        stats=GameObject.Find("Stats"); 
        parent=this.gameObject;
        Debug.Log("1");
         rand=Random.Range(0,2);
         prob=Random.Range(0,500);
    }

    // Update is called once per frame
    void Update()
    {
    timeLeft -= Time.deltaTime*objectSpawner.mul;
    GameObject chil=parent.transform.GetChild(3).gameObject;
    chil.GetComponent<TextMesh>().text=timeLeft.ToString();
    Debug.Log(timeLeft);
     if ( timeLeft < 0 )
     {
         if(prob<30)
         {vp.ded++;vp.msck--; Destroy(this.gameObject); }
         else
       {    Destroy(this.gameObject);
            vp.msck--;
            if(rand==0)
             vp.hlth++;
             else
             vp.mhlth++;
           Instantiate(healthprefabs[rand], transform.position, Quaternion.identity);
       }
     }
     
    }
}