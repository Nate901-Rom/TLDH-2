using UnityEngine;
using UnityEngine.InputSystem;

public class MaterialSwitcher : MonoBehaviour
{
    public Material alternateMaterial;
    private Renderer rend;
    private Material originalMaterial;
    private bool usingAlternate;

    private void Awake()
    {
        rend = GetComponent<Renderer>();
        if(rend != null)
        {
            originalMaterial = rend.material; //stores a per-instance copy to avoid editing shared asset
        }
    }

    public void ToggleMaterial()
    {
        if (rend == null || alternateMaterial == null) return;

        if (usingAlternate)
        {
            rend.material = alternateMaterial;
            usingAlternate = true;
        }

        else
        {
            rend.material = originalMaterial;
            usingAlternate = false;
        }
    }
}
