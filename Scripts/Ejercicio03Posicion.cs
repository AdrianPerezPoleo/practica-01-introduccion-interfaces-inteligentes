using UnityEngine;
using TMPro;

public class Ejercicio03Posicion : MonoBehaviour
{
    public TextMeshProUGUI positionText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (positionText != null)
        {
            positionText.text = $"Posición: {transform.position}";
        }        
    }

    // Update is called once per frame
    void Update()
    {
        positionText.text = $"Posición: {transform.position}";
    }
}
