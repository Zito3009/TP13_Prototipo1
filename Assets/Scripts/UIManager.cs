using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject goCartelPresione;
    
    // Start is called before the first frame update
    void Start()
    {
        goCartelPresione = GameObject.FindGameObjectWithTag("CartelPresione");
        goCartelPresione.SetActive(false);
    }

    // Update is called once per frame
    public void ShowCartelPresione()
    {
        goCartelPresione.SetActive(true);
    }

    public void HideCartelPresione()
    {
        goCartelPresione.SetActive(false);
    }
}
