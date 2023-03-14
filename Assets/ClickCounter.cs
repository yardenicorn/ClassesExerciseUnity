using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using Unity.VisualScripting;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    // set initial counter value
    private int counter = 0;
    // set initial shared counter value
    private static int sharedCounter = 0;
    // set initial hit points value
    public int hitPoints = 3;

    void Start()
    {
        // Initialed counter is printed to console
        Debug.Log("Counter: " + counter);
        // Initialed shared counter is printed to console
        Debug.Log("Shared Counter: " + sharedCounter);
        // Initialed game object hit points is printed to console
        Debug.Log(gameObject.name + " Hit Points: " + hitPoints);
    }

    private void OnMouseDown()
    {
        // increment counter and sharedcounter and print to console
        counter++;
        sharedCounter++;
        Debug.Log("Counter: " + counter);
        Debug.Log("Shared Counter: " + sharedCounter);

        DecreaseHP();
    }

    public void DecreaseHP()
    {
        // if hit points are bigger than zero, decrement hit points and print to console
        if (hitPoints > 0)
        {
            hitPoints--;
            Debug.Log(gameObject.name + " Hit Points: " + hitPoints);
        }

        // destroy the game object if hit points have reached zero
        if (hitPoints == 0)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        
    }
}
