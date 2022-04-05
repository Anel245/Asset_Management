using UnityEngine;

public class Snowman : MonoBehaviour
{
    private void Update() {
        transform.position = Vector3.up * Mathf.Sin(Time.unscaledTime);
    }
}
