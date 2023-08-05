using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private void OntriggerEnter(Collider other)
    {
        PlayerController component = other.gameObject.GetComponent<PlayerController>();
        if(component != null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
