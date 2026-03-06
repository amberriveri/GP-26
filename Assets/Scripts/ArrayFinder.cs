using UnityEngine;

public class ArrayFinder : MonoBehaviour
{
    GameObject[] cubes;

    void Start()
    {
        cubes = GameObject.FindGameObjectsWithTag("Cube");

        foreach (GameObject cube in cubes)
        {
            cube.transform.position += new Vector3(0, 2, 0);
        }
    }
}
