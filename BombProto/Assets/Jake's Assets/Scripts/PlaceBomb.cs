using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class PlaceBomb : MonoBehaviour
{
    public bool bombPlaced = false;
    public bool bombArmed = false;
    public bool isInFuseLayingMode = false;

    public GameObject obj;
    public GameObject Fuse;

    public UnityEvent PlantBomb;

    private Character Hero;
    
    // Update is called once per frame
    void Update()
    {
        if (isInFuseLayingMode == true)
        {
            Debug.Log("FUSE LAYING MODE ACTIVE");
        }

        // Enter fuse-laying mode
        if (bombPlaced == false)
        {
            if (Input.GetKeyDown("e"))
            {
                bombPlaced = true;
                isInFuseLayingMode = true;
                PlantBomb.Invoke();
            }
        }
        // Exit fuse-laying mode
        else if (isInFuseLayingMode == true && bombPlaced == true)
        {
            if (Input.GetKeyDown("e"))
            {
                isInFuseLayingMode = false;
                bombPlaced = false;
            }
        }

        LayFuse();
    }

    public void GenerateFuse()
    {
        obj = GameObject.Find("Character");
        Instantiate(Fuse, obj.transform.position, Quaternion.identity);
    }

    public void LayFuse()
    {
        while (isInFuseLayingMode == true)
        {
            void OnTriggerExit(Collider bomb)
            { 
                GenerateFuse(); 
            }
            
        }
    }

 

}

