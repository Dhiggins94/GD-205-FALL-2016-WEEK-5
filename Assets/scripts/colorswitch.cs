using UnityEngine;
using System.Collections;


public class colorswitch : MonoBehaviour
    
{
    public GameObject fishpellet;
    public Material[] material;
    Renderer rend;



    void start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "fishpellet")
        {
            rend.sharedMaterial = material[1];
        }
        else
        {
            rend.sharedMaterial = material[2];
        }
    }
}
///script was made by creator rosscoe tuutorials on youtube https://www.youtube.com/watch?v=dJB07ZSiW7k