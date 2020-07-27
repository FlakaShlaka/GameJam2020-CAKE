using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

// [RequireComponent(typeof(MeshFilter))]
// [RequireComponent(typeof(MeshRenderer))]
public class CombineScript : MonoBehaviour
{
    public Highlights highlights;
    private int collection = 0;
    
    //For combining mesh

    // Start is called before the first frame update
    void Start()
    {
        /*MeshFilter[] meshFilters = GetComponentsInChildren<MeshFilter>();
        CombineInstance[] combine = new CombineInstance[meshFilters.Length];

        int i = 0;
        while (i < meshFilters.Length)
        {
            combine[i].mesh = meshFilters[i].sharedMesh;
            combine[i].transform = meshFilters[i].transform.localToWorldMatrix;
            meshFilters[i].gameObject.SetActive(false);

            i++;
        }
        transform.GetComponent<MeshFilter>().mesh = new Mesh();
        transform.GetComponent<MeshFilter>().mesh.CombineMeshes(combine);
        transform.gameObject.SetActive(true);*/
    }

    // Update is called once per frame
    void Update()
    {
        if (collection == 5)
        {
            //Play end animation sequence in next scene
            StartCoroutine(NextLevel());
        }
    }

    private void OnTriggerEnter(Collider hit)
    {
        /*Not by switch case
        Debug.Log(hit.gameObject.name);
         if (hit.gameObject.name == "Tire" )
         {
             Debug.Log("tire hit");
             //GetComponentInChildren<MeshRenderer>().enabled(false);
             transform.Find("OnCake_Tire").gameObject.SetActive(true);
             hit.gameObject.SetActive(false);
         }*/

        //Logic for picking up items by collider
        /*if (hit.gameObject.tag == "Pickup")
        {
            hit.transform.parent = transform;
        }
    }*/

    //Logic for faking picking up
        
        switch (hit.gameObject.name)
        {
            case "Tire": transform.Find("OnCake_Tire").gameObject.SetActive(true);
                collection += 1;
                //anim = hit.GetComponent<Animation>();
                //anim.Play();
                //Debug.Log(anim.name);
                highlights.Tire.SetActive(false);
                highlights.tireGreenHighlight.SetActive(true);
                
                break;
            case "Shoe_1": transform.Find("OnCake_Shoe").gameObject.SetActive(true);
                collection += 1;
                highlights.Shoe.SetActive(false);
                highlights.shoeGreenHighlight.SetActive(true);

                break;
            case "Shark": transform.Find("OnCake_Shark").gameObject.SetActive(true);
                collection += 1;
                highlights.Shark.SetActive(false);
                highlights.sharkGreenHighlight.SetActive(true);

                break;
            case "Hamburger": transform.Find("OnCake_Hamburger").gameObject.SetActive(true);
                collection += 1;
                highlights.Hamburger.SetActive(false);
                highlights.hamburgerGreenHighlight.SetActive(true);

                break;
            case "Eye": transform.Find("OnCake_Eye").gameObject.SetActive(true);
                collection += 1;
                highlights.EyeBall.SetActive(false);
                highlights.eyeBallGreenHighlight.SetActive(true);

                break;
        }
        hit.gameObject.SetActive(false);
    }

    private static IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
