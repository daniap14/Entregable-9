using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class posicion : MonoBehaviour
{
    public static posicion Instance;

    private float verticalInput;
    private float horizontalInput;
    private float playerSpeed = 10;
    public float counter;
    //public float counter_before;

    public TextMeshProUGUI counter_text;
    // public TextMeshProUGUI counter_text_before;

    

   
    void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        DontDestroyOnLoad(gameObject);

    }

    
    void Update()
    {
        counter_text = FindObjectOfType<TextMeshProUGUI>();
        

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.right * Time.deltaTime * playerSpeed * horizontalInput);
        transform.Translate(Vector2.up * Time.deltaTime * playerSpeed * verticalInput);

        
        

        //Counter text
        counter_text.SetText("Contador: " + counter);
        
    }
}
