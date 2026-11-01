using UnityEngine;

public class Paralax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float speed = 0.05f;
    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
