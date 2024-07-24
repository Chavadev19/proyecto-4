using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField] private bool hasKey;
    [SerializeField] private Transform teleport;
    [SerializeField] private GameManager _gameManager;
    private void Start()
    {
        
        hasKey = false;
    }

    private void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Key"))
        {
            hasKey = true;
            Destroy(collision.gameObject);
            Debug.Log("Tocando llave");
        }

      

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Key"))
        {
            hasKey = true;
            Destroy(other.gameObject);
            Debug.Log("Tocando llave trigger");
        }

        if(other.gameObject.CompareTag("Teleport"))
        {
            Debug.Log("Tocando TP");
            gameObject.transform.position = new Vector3(teleport.position.x, teleport.position.y, teleport.position.z);
        }

        if(other.gameObject.CompareTag("Exit") && hasKey)
        {
            _gameManager.Victory();
        }
    }


}
