using UnityEngine;

public class MetaballController : MonoBehaviour
{
    Vector3 pos = new Vector3(0.5f, 0.5f, 0f);
	float radius = 0.1f;
    Material mat;

	void Awake()
    {
        mat = GetComponent<Renderer>().material;
        mat.SetFloat("_BlobRadius", radius);
    }

    void Update()
    {
        mat.SetVector("_BlobPos", pos);
    }
}
