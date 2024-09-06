using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pumpkinMoves : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bigPumpkin;
    public GameObject roundPumpkin;
    public GameObject platform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    private void OnCollisionEnter2D(Collision2D other) {
            if(other.gameObject.CompareTag("platform")){
                Debug.Log("pumpkin guts REVEALED");
                Destroy(gameObject);
        }
    }

}
