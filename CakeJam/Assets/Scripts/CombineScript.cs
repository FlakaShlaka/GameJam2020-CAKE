using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineScript : MonoBehaviour
{

    public Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider hit)
    {
        //Not by switch case
        //Debug.Log(hit.gameObject.name);
        // if (hit.gameObject.name == "Tire" )
        // {
        //     Debug.Log("tire hit");
        //     //GetComponentInChildren<MeshRenderer>().enabled(false);
        //     transform.Find("OnCake_Tire").gameObject.SetActive(true);
        //     hit.gameObject.SetActive(false);
        // }
        
        //Logic for picking up items by collider
        // if (hit.gameObject.tag == "Pickup")
        // {
        //     hit.transform.parent = transform;
        // }

        
        
        //Logic for faking picking up
        switch (hit.gameObject.name)
        {
            case "Tire": transform.Find("OnCake_Tire").gameObject.SetActive(true);
                //anim = hit.GetComponent<Animation>();
                //anim.Play();
                //Debug.Log(anim.name);
                break;
            case "Shoe_1": transform.Find("OnCake_Shoe").gameObject.SetActive(true); break;
            case "Shark": transform.Find("OnCake_Shark").gameObject.SetActive(true); break;
            case "Hamburger": transform.Find("OnCake_Hamburger").gameObject.SetActive(true); break;
            case "Eye": transform.Find("OnCake_Eye").gameObject.SetActive(true); break;
        }
        hit.gameObject.SetActive(false);
    }
    

    
}
