using UnityEngine;

public class SimpleHarmonicMotion : MonoBehaviour {

    Rigidbody2D rb;
    public bool running = false;
    float A = 1.0f;
    float w = 1.0f;
    float phi = 0.0f;
    float time = 0.0f;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void changeA(string value) {
        Debug.Log("A: " + value);
        if (float.TryParse(value, out float newValue)) {
            A = newValue;
        } else {
            Debug.LogError("Invalid input. A must be a valid float value.");
        }
    }
    
    public void changeW(string value) {
        Debug.Log("w: " + value);
        if (float.TryParse(value, out float newValue)) {
            w = newValue;
        } else {
            Debug.LogError("Invalid input. A must be a valid float value.");
        }
    }

    public void changePhi(string value) {
        Debug.Log("phi: " + value);
        if (float.TryParse(value, out float newValue)) {
            phi = newValue;
        } else {
            Debug.LogError("Invalid input. A must be a valid float value.");
        }
    }

    float simpleHarmonicMotion(float t, float A, float w, float phi) {
        return A * Mathf.Sin(w * t + phi);
    }

    void FixedUpdate() {
        if(running) {
            time += Time.fixedDeltaTime;
            rb.MovePosition(new Vector2(simpleHarmonicMotion(time, A, w, phi), 0.0f));
        } else {
            time = 0.0f;
        }
    }
}
