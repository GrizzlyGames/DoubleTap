using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    public GameObject firstPointGO;
    public GameObject secondPointGO;
    public GameObject midPointGO;

    private int pointCounter = 0;
    private Vector2 firstPoint;
    private Vector2 secondPoint;
    public Vector2 midPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointCounter++;
            if (pointCounter % 2 != 0) // is an odd number --- first click ---
            {
                firstPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Instantiate(firstPointGO, firstPoint, Quaternion.identity);
            }            
            else // even number --- second click ---
            {
                secondPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Instantiate(secondPointGO, secondPoint, Quaternion.identity);

                midPoint = Vector2.Lerp(firstPoint, secondPoint, 0.5f);
                Instantiate(midPointGO, midPoint, Quaternion.identity);
            }          
        }
    }
}
