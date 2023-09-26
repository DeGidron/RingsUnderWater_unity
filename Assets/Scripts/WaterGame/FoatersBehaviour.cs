using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoatersBehaviour : MonoBehaviour
{
    public List<GameObject> floaters;

    void Start()
    {
        foreach (GameObject floater in floaters)
        {
            FloatersPos(floater);
        }
    }

    
    void Update()
    {
        
    }

    public void FloatersPos(GameObject floater)
    {
        Vector2 pos = new(Random.Range(-5, 2), Random.Range(0.2f, 0.9f));
        if((pos.x < 0.29f && pos.x > -0.35f)
            || (pos.x < -3.1f && pos.x > -3.8f))
        {
            FloatersPos(floater);
        }
        else
        {
            floater.transform.localPosition = pos;
        }
    }
}
