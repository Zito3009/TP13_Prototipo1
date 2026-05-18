using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveArea : MonoBehaviour
{
    UIManager uiManagerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        uiManagerScript = GameObject.FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Interactable interactableScript = other.GetComponent<Interactable>();
        if (interactableScript != null)
        {
            other.gameObject.SetActive(false);
            uiManagerScript.ShowCartelPresione();
        }
    }
}
