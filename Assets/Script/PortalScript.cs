using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Level1");
    }
}
