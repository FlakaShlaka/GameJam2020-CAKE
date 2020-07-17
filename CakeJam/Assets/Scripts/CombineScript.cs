using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnCollisionEnter(Collision hit)
    {
        Debug.Log(hit.gameObject.name);
        if (hit.gameObject.name == "Tire" )
        {
            Debug.Log("tire hit");
            //GetComponentInChildren<MeshRenderer>().enabled(false);
            //transform.Find("Tire").gameObject.SetActive(false);
            hit.gameObject.SetActive(false);
        }
        //hit.transform.parent = transform;
    }*/
    private void OnTriggerEnter(Collider hit)
    {
        //Debug.Log(hit.gameObject.name);
        // if (hit.gameObject.name == "Tire" )
        // {
        //     Debug.Log("tire hit");
        //     //GetComponentInChildren<MeshRenderer>().enabled(false);
        //     transform.Find("OnCake_Tire").gameObject.SetActive(true);
        //     hit.gameObject.SetActive(false);
        // }
        
        if (hit.gameObject.tag == "Pickup")
        {
            hit.transform.parent = transform;
        }

        //hit.gameObject.SetActive(false);
    }
    
        /*switch (hit.gameObject.name)
        {
            case "Tire": transform.Find("OnCake_Tire").gameObject.SetActive(true); break;
            case "Shoe_1": transform.Find("OnCake_Shoe").gameObject.SetActive(true); break;
            case "Shark": transform.Find("OnCake_Shark").gameObject.SetActive(true); break;
            case "Hamburger": transform.Find("OnCake_Hamburger").gameObject.SetActive(true); break;
            case "Eye": transform.Find("OnCake_Eye").gameObject.SetActive(true); break;
            //case 1: rend.material.color = Color.cyan; break;
        }
        hit.gameObject.SetActive(false);*/
    
}
