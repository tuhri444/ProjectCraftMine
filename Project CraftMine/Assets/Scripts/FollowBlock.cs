using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBlock : MonoBehaviour
{
    [SerializeField] private Vector3 Offset;
    private GameObject block;
    private Vector3 DesiredLocation;
    void Start()
    {
        block = FindObjectOfType<MovePlayer>().gameObject.GetComponentInChildren<Rigidbody>().gameObject;
    }

    void Update()
    {
        DesiredLocation = block.transform.position;
        DesiredLocation.y = 0;
        DesiredLocation += Offset;
        transform.position = DesiredLocation;
    }
}
