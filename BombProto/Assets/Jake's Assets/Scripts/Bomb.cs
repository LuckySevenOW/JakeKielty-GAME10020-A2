using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Bomb : MonoBehaviour
{
    public UnityEvent Ignite;
    public bool bombArmed = false;

    public bool isLayingFuse;
    public bool isFuseLaid;
    public float FuseTime;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ignition()
    {

    }

    private void Fuse()
    {

    }
}
