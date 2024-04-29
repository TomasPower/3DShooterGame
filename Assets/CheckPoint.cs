using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] List<GameObject> Checkpoints;
    [SerializeField] Vector3 vectorPoint;
    [SerializeField] float dead;
    
   
   
    void Update()
    {
        if(Player.transform.position.y < -dead)
        {
            Player.transform.position = Vector3.zero;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        vectorPoint= Player.transform.position;  
        Destroy(other.gameObject);
    }
}
