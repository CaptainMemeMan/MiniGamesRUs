using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class HexagonMesh : MonoBehaviour
{
    void Start()
    {
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        Vector3[] vertices = new Vector3[7];
        int[] triangles = new int[18];

        float radius = 1f;
        float angleIncrement = Mathf.PI / 3f;

        vertices[0] = Vector3.zero; // Center vertex

        for (int i = 1; i < 7; i++)
        {
            float angle = angleIncrement * (i - 1);
            vertices[i] = new Vector3(Mathf.Cos(angle) * radius, 0, Mathf.Sin(angle) * radius);
        }

        for (int i = 0; i < 6; i++)
        {
            triangles[i * 3] = 0;
            triangles[i * 3 + 1] = i + 1;
            triangles[i * 3 + 2] = (i + 1) % 6 + 1;
        }

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
}
