using UnityEngine;

public class ChangeColorObject : MonoBehaviour {
    public int jarakRaycast = 20;
    private RaycastHit raycastHit;
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
                if (raycastHit.transform.CompareTag("Colorable"))
            {
                Color randomColor = new Color(
                    Random.Range(0f, 1f), // Red component
                    Random.Range(0f, 1f), // Green component
                    Random.Range(0f, 1f)  // Blue component
                );
                GetComponent<Renderer>().material.color = randomColor;
            }
        }
    }
}