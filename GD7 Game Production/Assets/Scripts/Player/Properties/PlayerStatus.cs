using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    GameObject player;
    MeshRenderer mesh;
    PlayerMovement movement;
    CinemachineBrain camera;
    PlayerInteractor interact;

   

    bool isHidden = false;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        movement = player.GetComponent<PlayerMovement>();
        interact = player.GetComponent<PlayerInteractor>();
        mesh = player.GetComponent<MeshRenderer>();
        camera = GameObject.FindWithTag("Camera brain").GetComponent<CinemachineBrain>();
        isHidden = false;
    }

    public bool ReturnHidden() {
        return isHidden;
            }
    public void Hide() {
        SetMove(false);
        mesh.enabled = false;
    }
    public void Unhide()
    {
        Debug.Log("hey guys so");
        StartCoroutine(IEUnhide());
    }

    IEnumerator IEUnhide()
    {
        yield return new WaitForSeconds(1);

        Debug.Log("my balls are big");
        SetMove(true);
        mesh.enabled = true;
    }

    public bool CanLook() {
        return camera.enabled;
    }
    public void SetLook(bool enabled) {
        camera.enabled = enabled;
    }
    public bool CanMove()
    {
        return movement.enabled;
    }
    public void SetMove(bool enabled)
    {
        movement.enabled = enabled;
    }
    public bool CanInteract()
    {
        return interact.enabled;
    }
    public void SetInteract(bool enabled)
    {
        interact.enabled = enabled;
    }

}
