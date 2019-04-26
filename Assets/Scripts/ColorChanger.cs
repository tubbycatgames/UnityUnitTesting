using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    Material material;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        var startColor = material.color;
        var blueShift = Input.GetAxis("Vertical");
        var redShift = Input.GetAxis("Horizontal");
        var timeShift = Time.deltaTime;
    }
}
