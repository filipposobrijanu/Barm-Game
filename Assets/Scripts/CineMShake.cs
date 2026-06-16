using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CineMShake : MonoBehaviour
{

    public CinemachineVirtualCamera cinemachineVirtualCamera;

    public float shakeTimer;

    public float shakeTimerTotal;

    public float startingintensity;

    public void ShakeCamera(float intensity, float time)
    {

        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
        cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = intensity;

        shakeTimer = time;

        shakeTimerTotal = time;

        startingintensity = intensity;

    }

    private void Update()
    {
        if (shakeTimer > 0)
        {
            shakeTimer -= Time.deltaTime;

            CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin = cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();

            cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = Mathf.Lerp(startingintensity, 0f, 1 - (shakeTimer / shakeTimerTotal));
        }
    }
}
