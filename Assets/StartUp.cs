using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class StartUp : MonoBehaviour
{
    
    [DllImport("networks")] private static extern void InitNetwork();
    [DllImport("networks")] private static extern void ApplyNetwork(ref float data, ref float output);

    // Start is called before the first frame update
    void Start()
    {
        InitNetwork();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void SomeFunction()
    {
        float[] input = new float[1 * 3 * 64 * 64];
        float[] output = new float[1 * 5 * 64 * 64];

        // Load input with whatever data you want
        for(int i=0; i<input.Length; i++)
        {
            input[i] = 0;
        }

	    ApplyNetwork(ref input[0], ref output[0]);


        // Do whatever you want with the output
    }
}
