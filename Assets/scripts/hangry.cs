using UnityEngine;
using System.Collections;

public class hangry : MonoBehaviour
{
    public GameObject fishpellet;
    GameObject foodpelletclone;
    Vector3 destination;
    public float howHungry;
    bool hungry;

    // Use this for initialization
    void Start()
    {
        hungry = true;
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 direction = Vector3.Normalize(destination - transform.position);
        Debug.Log("fish velocity =   " + GetComponent<Rigidbody>().velocity);

        if (hungry)
        {
            destination = fishpellet.transform.position;

            GetComponent<Rigidbody>().AddForce(direction * howHungry);
        }
        else
        {

            GetComponent<Rigidbody>().velocity = Vector3.zero;
           
        }
    }


    
    void OnCollisionEnter(Collision co)
    {


        if (co.gameObject.tag == "fishpellet")
        {
            foodpelletclone = Instantiate(fishpellet, transform.position, Quaternion.identity) as GameObject;
            Destroy(co.gameObject);


            hungry = false;
            {

                
                }
            }
        }
    }
