using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    /// <summary>
    /// 
    /// top left of the board is at pos 0|0
    /// |0|1|2|
    /// |3|4|5|
    /// |6|7|8|
    /// 
    /// </summary>
    public GameObject[] boardFields;
    public Material selectedMaterial;

    private Material[] oldMaterials = new Material[9];

    private Board board;

    // Start is called before the first frame update
    void Start()
    {
        board = new Board(3);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject selectedObject;
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                selectedObject = hit.transform.gameObject;
            }
        }
    }

    void showValidFields(GameObject selectedObject)
    {

    }
}
