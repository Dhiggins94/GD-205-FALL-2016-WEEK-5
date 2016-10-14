using UnityEngine;
using System.Collections;

public class foodPrefab : MonoBehaviour {
    public GameObject foodprefab;
    GameObject foodPrefabClone;

    // Use this for initialization
    void Update() {

        if (Input.GetKeyDown("e")){
            foodPrefabClone = Instantiate(foodprefab, transform.position, Quaternion.identity) as GameObject;
            Destroy(foodPrefabClone,3);
        }
    }

}

  