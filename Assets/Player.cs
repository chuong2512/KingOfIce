using System;
using System.Collections;
using System.Collections.Generic;
using ChuongCustom;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1;
    [SerializeField] private float _forceJump = 3;
    [SerializeField] private SpriteRenderer _image;
    [SerializeField] private Sprite _left, _right;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0) && gameObject.activeSelf)
        {
            if (_rigidbody.velocity.y == 0)
            {
                _rigidbody.AddForce(Vector2.up * _forceJump, ForceMode2D.Impulse);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Left"))
        {
            ScoreManager.Score++;
        }
        else if (col.collider.CompareTag("Right"))
        {
            ScoreManager.Score++;
        }

        if (col.gameObject.CompareTag("LoseGame"))
        {
            Manager.InGame.Lose();
            col.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Star"))
        {
            Data.Player.Coin++;
            col.gameObject.SetActive(false);
        }

        if (col.gameObject.CompareTag("LoseGame"))
        {
            Manager.InGame.Lose();
            col.gameObject.SetActive(false);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Left"))
        {
            Rotate(false);
        }
        else if (collision.collider.CompareTag("Right"))
        {
            Rotate(true);
        }
    }

    public void Rotate(bool right)
    {
        _image.sprite = right ? _right : _left;

        _rigidbody.velocity = (right ? Vector2.right : Vector2.left) * _speed;
    }
}