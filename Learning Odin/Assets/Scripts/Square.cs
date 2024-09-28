using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class Square : MonoBehaviour
{
    [Range(0, 5)]
    [InfoBox("This is some number, tune it to change something.")]
    public int myNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
