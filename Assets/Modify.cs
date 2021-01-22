using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Modify : MonoBehaviour
{
    public string selectedBlockName;

    public bool isLaser = false;

    Vector2 rot;

    void Update()
    {
        if (!isLaser) //1 click
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
                {
                    EditTerrain.SetBlock(hit, new BlockAir());
                }
            }
        }
        else //laser
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                RaycastHit hit;
                if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
                {
                    EditTerrain.SetBlock(hit, new BlockAir());
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
            {
                EditTerrain.SetBlock(hit, DefineSelectedBlock(selectedBlockName), true);
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        /*rot = new Vector2(
            rot.x + Input.GetAxis("Mouse X") * 3,
            rot.y + Input.GetAxis("Mouse Y") * 3);

        transform.localRotation = Quaternion.AngleAxis(rot.x, Vector3.up);
        transform.localRotation *= Quaternion.AngleAxis(rot.y, Vector3.left);

        transform.position += transform.forward * 3 * Input.GetAxis("Vertical");
        transform.position += transform.right * 3 * Input.GetAxis("Horizontal");*/
    }

    Block DefineSelectedBlock(string sBN)
    {
        switch (sBN)
        {
            case "grass":
                return(new BlockGrass());

            case "leaves":
                return(new BlockLeaves());

            case "wood":
                return(new BlockWood());

            case "emerald":
                return (new BlockEmerald());

            default:
                return(new BlockAir());
        }
    }

}