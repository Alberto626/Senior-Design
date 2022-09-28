using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookFood : MonoBehaviour
{
    private string stillcooking = "y";
    public GameObject myPrefab;
    public GameObject newPrefab;
    


    private void OnCollisionEnter(Collision collision) 
    {
         if (collision.gameObject.tag == "pan" && gameObject.tag == "rawSteak")
         {
            StartCoroutine(cookTimer());
         }
    }

    IEnumerator cookTimer()
    {

        yield return new WaitForSeconds(5);
        SpawnCookedMeat();

        
    }
    public void SpawnSphere() {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sphere.transform.localPosition = new Vector3(0, 1, 2);
        sphere.AddComponent<Rigidbody>();
    }

    public void SpawnCookedMeat() {
        //GameObject prefab = this.GetComponent<Rigidbody>();
        //var selection = Selection.gameObjects;
        //GameObject clone = (GameObject)Instantiate(myPrefab);
        //var selection = Selection.gameObjects;
        //var prefabType = PrefabUtility.GetPrefabType(prefab);
        GameObject newObject = (GameObject)Instantiate(newPrefab);
        // newObject.transform.parent = clone.transform.parent;

        newObject.transform.parent = myPrefab.transform.parent;
        newObject.transform.localPosition = myPrefab.transform.localPosition;
        newObject.transform.localRotation = myPrefab.transform.localRotation;
        newObject.transform.localScale = myPrefab.transform.localScale;
        newObject.transform.SetSiblingIndex(myPrefab.transform.GetSiblingIndex());
        Destroy(myPrefab);
    }

}
