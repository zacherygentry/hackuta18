using UnityEngine;
using System.Collections;

public class OnClickInstantiate : MonoBehaviour
{
    public GameObject Prefab;
    public int InstantiateType;
    private string[] InstantiateTypeNames = {"Mine", "Scene"};

    public bool showGui;

    void OnClick()
    {
        if (!PhotonNetwork.inRoom)
        {
            // only use PhotonNetwork.Instantiate while in a room.
            return;
        }

        switch (InstantiateType)
        {
            case 0:
                var cube = PhotonNetwork.Instantiate(Prefab.name, InputToEvent.inputHitPos + new Vector3(0, 5f, 0), Quaternion.identity, 0);
                cube.AddComponent<ChangeColor>();
                break;
            case 1:
                var sceneCube = PhotonNetwork.InstantiateSceneObject(Prefab.name, InputToEvent.inputHitPos + new Vector3(0, 5f, 0), Quaternion.identity, 0, null);
                sceneCube.AddComponent<ChangeColor>();
                break;
        }
    }

    void OnGUI()
    {
        if (showGui)
        {
            GUILayout.BeginArea(new Rect(Screen.width - 180, 0, 180, 50));
            InstantiateType = GUILayout.Toolbar(InstantiateType, InstantiateTypeNames);
            GUILayout.EndArea();
        }
    }


}
