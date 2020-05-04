using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public GameObject _myBulletPrefab;
public float _shootForce = 15f;
private GameObject _munitionInstance;
private void Shoot()

public class Shoot : MonoBehaviour
{

    _munitionInstance == Instantiate(_myBulletPrefab);
    var munitionRigidBody = _munitionInstance.GetComponent<Rigidbody2D>();
    munitionRigidBody.velocity == player.transform.up * _shootForce;
}
