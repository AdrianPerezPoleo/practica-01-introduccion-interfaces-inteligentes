using UnityEngine;

public class Ejercicio04DistanciaCuboCilindro : MonoBehaviour
{
    private Vector3 cylinderPosition;
    private Vector3 cubePosition;

    private Vector3 lastCylinderPosition;
    private Vector3 lastCubePosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cylinderPosition = GameObject.FindWithTag("Grey-Cylinder").transform.position;
        cubePosition = GameObject.FindWithTag("Colored Cube").transform.position;

        // Garantizamos que son diferentes para mostrar en la primera iteración.
        lastCylinderPosition = cylinderPosition + Vector3.forward;
        lastCubePosition = cubePosition + Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        cylinderPosition = GameObject.FindWithTag("Grey-Cylinder").transform.position;
        cubePosition = GameObject.FindWithTag("Colored Cube").transform.position;

        if (cylinderPosition == lastCylinderPosition && cubePosition == lastCubePosition) return;
        Debug.Log($"Distancia entre el cubo y el cilindro: {Vector3.Distance(cubePosition, cylinderPosition)}");
        lastCylinderPosition = cylinderPosition;
        lastCubePosition = cubePosition;
    }
}
