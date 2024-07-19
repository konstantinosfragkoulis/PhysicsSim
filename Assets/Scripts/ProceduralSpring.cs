using UnityEngine;

public class ProceduralSpring : MonoBehaviour {
    public Transform startTransform;
    public Transform endTransform;
    public GameObject segmentPrefab;
    public int segmentCount = 10;
    public float radius = 0.5f; // Radius of the spring=

    void Start() {
        GenerateSpring();
    }

    void GenerateSpring() {
        Vector3 direction = (endTransform.position - startTransform.position).normalized;
        float totalDistance = Vector3.Distance(startTransform.position, endTransform.position);
        
        

    }
}
