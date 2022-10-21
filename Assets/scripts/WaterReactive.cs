using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Reaktion; 

public class WaterReactive : MonoBehaviour
{
    public ReaktorLink reaktor;


    public Renderer[] rends;

    public Vector4 amplitude;
    public Vector4 frequency;
    public Vector4 steepness;
    public Vector4 speed;
    public Vector4 directionAB ;
    public Vector4 directionCD ;

    public int interpolationFramesCount = 45; // Number of frames to completely interpolate between the 2 positions
    int elapsedFrames = 0;

    // Start is called before the first frame update
    void Start()
    {
        rends = GetComponentsInChildren<Renderer>(); 
    }

    // Update is called once per frame
    void Update()
    {

        float interpolationRatio = (float)elapsedFrames / interpolationFramesCount;
        Vector4 output = Vector4.Lerp(Vector4.zero, new Vector4(reaktor.Output, reaktor.Output, reaktor.Output, reaktor.Output), interpolationRatio);
        elapsedFrames = (elapsedFrames + 1) % (interpolationFramesCount + 1);  // reset elapsedFrames to zero after it reached (interpolationFramesCount + 1)

        amplitude = output;
        frequency = output;
        steepness = output;
        speed = output;
        directionAB = output;
        directionCD = output;


        foreach (var rend in rends)
        {
            rend.material.SetVector("_GAmplitude", amplitude);
            rend.material.SetVector("_GFrequency", frequency);
            rend.material.SetVector("_GSteepness", steepness);
            rend.material.SetVector("_GSpeed", speed);
            rend.material.SetVector("_GDirectionAB", directionAB);
            rend.material.SetVector("_GDirectionCD", directionCD);
        }

    }
}
