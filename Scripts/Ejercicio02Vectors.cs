using UnityEngine;

public class Ejercicio02Vectors : MonoBehaviour
{
    public Vector3 firstVector;
    public Vector3 secondVector;

    public float firstMagnitude;
    public float secondMagnitude;
    public float angleBetweenVectors;
    public float distanceBetweenVectors;
    public string highestVector;

    private Vector3 lastFirstVector;
    private Vector3 lastSecondVector;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lastFirstVector = new Vector3(-1, -1, -1);
        lastSecondVector = new Vector3(-1, -1, -1); // Los inicializamos con otros valores para que se muestre la primera información
    }

    // Update is called once per frame
    void Update()
    {
        if (lastFirstVector == firstVector && lastSecondVector == secondVector) 
            return;
        firstMagnitude = firstVector.magnitude;
        secondMagnitude = secondVector.magnitude;
        angleBetweenVectors = Vector3.Angle(firstVector, secondVector);
        distanceBetweenVectors = Vector3.Distance(firstVector, secondVector);

        Debug.Log($"First Vector Magnitude: {firstMagnitude}");
        Debug.Log($"Second Vector Magnitude: {secondMagnitude}");
        Debug.Log($"Angle: {angleBetweenVectors}");
        Debug.Log($"Distance: {distanceBetweenVectors}");

        if (firstVector.y > secondVector.y)
        {
            highestVector = "First vector";
            Debug.Log($"First vector is higher than second vector ({firstVector.y} > {secondVector.y})");
        } else if (firstVector.y < secondVector.y) 
        {
            highestVector = "Second vector";
            Debug.Log($"Second vector is higher than first vector ({secondVector.y} > {firstVector.y})");
        } else
        {
            highestVector = "Both";
            Debug.Log("Both vectors have the same height");
        }

        lastFirstVector = firstVector;
        lastSecondVector = secondVector;
    }
}
