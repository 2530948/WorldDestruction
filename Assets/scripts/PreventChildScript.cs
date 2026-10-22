using UnityEngine;

public class PreventChildFlip : MonoBehaviour
{
    private Transform parentTransform;
    private Vector3 initialLocalPosition;
    private Vector3 initialLocalScale;

    void Start()
    {
        parentTransform = transform.parent;
        // Save the exact starting positions and scales
        initialLocalPosition = transform.localPosition;
        initialLocalScale = transform.localScale;
    }

    void LateUpdate()
    {
        if (parentTransform != null)
        {
            // Determine if parent is facing right (1) or left (-1)
            float parentDirection = Mathf.Sign(parentTransform.localScale.x);

            // 1. Fix the scale so it doesn't mirror
            Vector3 correctedScale = initialLocalScale;
            correctedScale.x = initialLocalScale.x * parentDirection;
            transform.localScale = correctedScale;

            // 2. Fix the position offset by mirroring it manually
            Vector3 correctedPosition = initialLocalPosition;
            correctedPosition.x = initialLocalPosition.x * parentDirection;
            transform.localPosition = correctedPosition;
        }
    }
}