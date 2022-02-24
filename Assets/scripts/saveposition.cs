using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveposition : MonoBehaviour
{
    private float PlayerX;
    private float PlayerY;
    private float PlayerZ;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(PlayerPrefs.GetFloat("PlayerX"), PlayerPrefs.GetFloat("PlayerY"), PlayerPrefs.GetFloat("PlayerZ"));
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("PlayerX", transform.position.x); 
        PlayerPrefs.SetFloat("PlayerY", transform.position.y); 
        PlayerPrefs.SetFloat("PlayerZ", transform.position.z);
    }
}
