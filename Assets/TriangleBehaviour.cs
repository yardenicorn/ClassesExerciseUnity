using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleBehaviour : MonoBehaviour
{
    [SerializeField] public ClickCounter clickcountercircle;
    [SerializeField] public ClickCounter clickcountersquare;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        clickcountercircle.DecreaseHP();
        clickcountersquare.DecreaseHP();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
