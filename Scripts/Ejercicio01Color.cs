using UnityEngine;

public class Ejercicio01Color : MonoBehaviour
{
    public int framesBeforeChange = 120;
    private int currentFrame = 0;
    private Renderer objectRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        objectRenderer.material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

    // Update is called once per frame
    void Update()
    {
        ++currentFrame;
        if (currentFrame >= framesBeforeChange) {
            currentFrame = 0;
            int position_to_modify = Random.Range(0, 3);
            Color new_color = objectRenderer.material.color;
            new_color[position_to_modify] =  Random.Range(0.0f, 1.0f); 
            objectRenderer.material.color = new_color; 
        }
    }
}
