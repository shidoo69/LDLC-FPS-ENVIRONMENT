using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Renderer renderer;
    public float speed = 1.0f;
    public Color[] colors;

    private int currentIndex = 0;
    private float t = 0.0f;

    void Update()
    {
        t += Time.deltaTime * speed;

        // Interpolate between current and next color based on time
        Color currentColor = colors[currentIndex];
        Color nextColor = colors[(currentIndex + 1) % colors.Length];
        Color color = Color.Lerp(currentColor, nextColor, Mathf.PingPong(t, 1.0f));

        // Set object color
        renderer.material.color = color;

        // Check if we need to switch to next color
        if (t >= 1.0f)
        {
            t = 0.0f;
            currentIndex = (currentIndex + 1) % colors.Length;
        }
    }
}
