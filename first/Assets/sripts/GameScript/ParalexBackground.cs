using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalexBackground : MonoBehaviour
{
    [SerializeField] private Vector2 parallaxEffectMultiplier;
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    private float textureUnitiSizeX;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        Texture2D texture = sprite.texture;
        textureUnitiSizeX = texture.width / sprite.pixelsPerUnit;
    }
        private void LateUpdate()
        {
            Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
            transform.position += new Vector3(deltaMovement.x* parallaxEffectMultiplier.x, deltaMovement.y * parallaxEffectMultiplier.y);
            lastCameraPosition = cameraTransform.position;

            if (Mathf.Abs(cameraTransform.position.x - transform.position.x) >= textureUnitiSizeX)
            {
            float offsetPositionX = (cameraTransform.position.x - transform.position.x) % textureUnitiSizeX;
            transform.position = new Vector3(cameraTransform.position.x + offsetPositionX, transform.position.y);
            }
        }

  }
