using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//класс для управления персонажем
public class Person : MonoBehaviour
{
    Animator animator;
    bool triggerOn;

    void Start()
    {
         animator = gameObject.GetComponent<Animator>();
         gameObject.SetActive(false);
         animator.speed = 0;
    }


    void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.tag == "personDestroy" && !triggerOn)
        {
            animator.speed = 0;
            Destroy(gameObject);
            triggerOn = true;
        }
    }
}