using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    //defining objects and events
    public GameObject button;
    public UnityEvent onPress;
    public UnityEvent onRelease;
    GameObject presser;
    AudioSource sound;
    bool isPressed;
    public Rigidbody rawMeat;
    public Transform rawMeatSpawn;
    
    //raw meat
    //public GameObject respawnPrefab;
    


    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
        isPressed = false;

        // if (respawn == null) {
        //     respawn = GameObject.FindWithTag("rawSteak");
        // }

        // Instantiate(respawnPrefab, respawn.transform.position, respawn.transform.rotation);
    }

    private void OnTriggerEnter(Collider other) {
        if (!isPressed) {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onPress.Invoke();
            sound.Play();
            isPressed = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject == presser) {
            button.transform.localPosition = new Vector3(0, 0.015f, 0);
            onRelease.Invoke();
            isPressed = false;
        }
    }

    public void SpawnSphere() {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        sphere.transform.localPosition = new Vector3(0, 1, 2);
        sphere.AddComponent<Rigidbody>();
    }

    public void SpawnRawMeat() {
        Rigidbody rawMeatInstance;
        rawMeatInstance = Instantiate(rawMeat, rawMeatSpawn.position, Quaternion.identity) as Rigidbody;

        // GameObject respawn = GameObject.FindWithTag("rawSteak");
        // respawn.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        // respawn.transform.localPosition = new Vector3(0, 1, 2);
        //respawn.AddComponent<Rigidbody>();

        //Instantiate(respawn, new Vector3(0.5f, 0.5f, 0.5f), Quaternion.identity);


        // GameObject rawMeat = GameObject.FindWithTag()
        // sphere.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        // sphere.transform.localPosition = new Vector3(0, 1, 2);
        // sphere.AddComponent<Rigidbody>();
    }
}
