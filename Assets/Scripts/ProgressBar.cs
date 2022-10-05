using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ProgressBar : MonoBehaviour
{
    public Control player;
    public Transform Finish;
    public Slider progress;

    private float _startZ;

    private void Start()
    {
        _startZ = player.transform.position.z;
    }

    private void Update()
    {
        float currentZ = player.transform.position.z;
        float finishz = Finish.transform.position.z;
        float t =  Mathf.InverseLerp(_startZ, finishz, currentZ);
        progress.value = t;
    }
}
