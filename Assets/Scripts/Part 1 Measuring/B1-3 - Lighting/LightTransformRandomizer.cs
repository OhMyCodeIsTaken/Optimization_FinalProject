using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTransformRandomizer : MonoBehaviour
{
    private System.Random _rand = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        RandomizePositionValues();
        RandomizeRotationValues();
    }

    private void RandomizePositionValues()
    {
        Vector3 randomPosition = new Vector3(_rand.Next(-8, 8 + 1), _rand.Next(1, 5 + 1), _rand.Next(-8, 8 + 1));
        transform.position = randomPosition;
    }
    
     private void RandomizeRotationValues()
    {
        Vector3 randomRotation = new Vector3(_rand.Next(0, 360 + 1), _rand.Next(0, 360 + 1), 0);
        transform.Rotate(randomRotation);
    }
}
