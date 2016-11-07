using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour
{
    private float exitStopDelay = 0.1f;
    void OnTriggerEnter(Collider col)
    {
        GetComponent<AudioSource>().Play();
    }

    void OnTriggerExit(Collider col)
    {
        StartCoroutine(StopAfterDelay());
    }

    IEnumerator StopAfterDelay()
    {
        yield return new WaitForSeconds(exitStopDelay);
        GetComponent<AudioSource>().Stop();
    }
}
