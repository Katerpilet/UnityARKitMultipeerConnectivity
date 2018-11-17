using UnityEngine.XR.iOS;

public static class ARHitTestResultExtensions
{
    public static UnityARUserAnchorData ToUnityArUserAnchorData(this ARPlaneAnchorGameObject arHitTestResult)
    {
        var transform = UnityARMatrixOps.GetMatrix(arHitTestResult.planeAnchor.transform);
        var anchorData = new UnityARUserAnchorData
        {
            transform = transform
        };
        return anchorData;
    }
}
