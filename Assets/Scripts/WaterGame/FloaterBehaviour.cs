using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloaterBehaviour : MonoBehaviour
{
    public bool isOnStick = false;
    public int counter;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (transform.eulerAngles.y == 0)
        {
            var dist = Vector3.Distance(transform.position, GameObject.FindGameObjectWithTag("LeftSpike").transform.position);
            if (dist < 10)
            {
                print("1");
            }
        }*/
    }

    private void OnTriggerStay(Collider collision)
    {
        if ((collision.gameObject.tag == "LeftSpike" || collision.gameObject.tag == "RightSpike")
            && !isOnStick)
        {
            if (transform.parent.rotation.y < 1)
            {
                print("plus");
                counter += 1;
                
            }
//            print(transform.parent.rotation.y);
            print(counter);
            isOnStick = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        isOnStick = false;
        counter -= 1;
        print(counter);

    }
}
