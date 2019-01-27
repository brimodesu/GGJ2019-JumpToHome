﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public CameraFollow cameraFollow;

    public IEnumerator Shake(float duration, float magnitude) {
        Vector3 originalPos = transform.localPosition;
        float elapsed = 0.0f;
        cameraFollow.followTarget = false;
        while (elapsed < duration) {
            float x = Random.Range(-1f,1f) * magnitude;
            float y = Random.Range(-0.5f,0.5f) * magnitude;
            transform.localPosition = new Vector3(x,y,originalPos.z);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = originalPos;
        cameraFollow.followTarget = true;
    }
}
