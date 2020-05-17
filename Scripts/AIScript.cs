using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public float rotSpeed = 100f;

    private bool isWandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;

    public int mul;
    ObjectSpawner objectSpawner;
     public GameObject spawMan;
    // Start is called before the first frame update
    void Start()
    {
        spawMan= GameObject.Find("ObjectSpawner");

        objectSpawner=spawMan.GetComponent<ObjectSpawner>();
        

    }

    // Update is called once per frame
    void Update()
    {
       mul= objectSpawner.mul;
        if(isWandering==false)
        {
            StartCoroutine(Wander());
        }

        if (isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed*mul);
        }
        if (isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotSpeed *mul);
        }
        if (isWalking==true)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime*mul;
        }
    }

    IEnumerator Wander()
    {
        int rotTime = Random.Range(1, 3);
        int roatateWait = Random.Range(1, 3);
        int rotateLorR = Random.Range(0, 3);
        int walkWait = Random.Range(1, 3);
        int walkTime = Random.Range(1, 5);

        isWandering = true;

        yield return new WaitForSeconds(walkWait);
        isWalking = true;
        yield return new WaitForSeconds(walkTime);
        isWalking = false;

        yield return new WaitForSeconds(roatateWait);

        if (rotateLorR == 1)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingRight = false;
        }
        if (rotateLorR == 2)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingLeft = false;
        }
        isWandering = false;
        
    }

  
}
