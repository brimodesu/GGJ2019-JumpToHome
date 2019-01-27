using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseController : MonoBehaviour
{

    bool canInteract = true;
    Animator HouseAnimator;
    public CameraShake CameraShake;

    void Start()
    {
        HouseAnimator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player") && canInteract) {
            canInteract = false;
            Debug.Log("Derrumbe1");
            HouseAnimator.SetBool("DestruirCasa", true);
             StartCoroutine( CameraShake.Shake(3f,.4f));
        }
    }
}
