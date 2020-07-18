using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class CombineScript : MonoBehaviour
{

    public Animation anim;
    public Highlights highlights;
    private int collection = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.collection == 5)
        {
            UnityEngine.Debug.Log("test");
            //play aniomation
        }
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
                this.collection += 1;
                //anim = hit.GetComponent<Animation>();
                //anim.Play();
                //Debug.Log(anim.name);
                this.highlights.Tire.SetActive(false);
                break;
            case "Shoe_1": transform.Find("OnCake_Shoe").gameObject.SetActive(true);
                this.collection += 1;
                this.highlights.Shoe.SetActive(false);

                break;
            case "Shark": transform.Find("OnCake_Shark").gameObject.SetActive(true);
                this.collection += 1;
                this.highlights.Shark.SetActive(false);

                break;
            case "Hamburger": transform.Find("OnCake_Hamburger").gameObject.SetActive(true);
                this.collection += 1;
                this.highlights.Hamburger.SetActive(false);

                break;
            case "Eye": transform.Find("OnCake_Eye").gameObject.SetActive(true);
                this.collection += 1;
                this.highlights.EyeBall.SetActive(false);

                break;
        }
        hit.gameObject.SetActive(false);
    }
    

    
}
