using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public int jarakRaycast = 20;
    private RaycastHit raycastHit;
    public float disableDuration = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        if (Physics.Raycast(ray, out raycastHit, jarakRaycast))
            {
                if (raycastHit.transform.CompareTag("Destroyable"))
            {
                Destroy(raycastHit.transform.gameObject);
            }

            if (raycastHit.transform.CompareTag("Temporary"))
            {
                StartCoroutine(TemporarilyDisableObject(raycastHit.transform.gameObject));
            }
        }
    }

    private IEnumerator TemporarilyDisableObject(GameObject obj)
    {
        obj.SetActive(false); // Disable the object
        yield return new WaitForSeconds(disableDuration); // Wait for the specified duration
        obj.SetActive(true); // Re-enable the object
    }
}
