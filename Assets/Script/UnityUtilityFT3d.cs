using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UnityUtilityFT3d 
{
    /// <summary>
    /// ゲームオブジェクトのマテリアルをセットします
    /// セットするゲームオブジェクトにはメッシュレンダラーコンポーネントを追加してください
    /// </summary>
    /// <param name="obj">マテリアルを設定するゲームオブジェクト</param>
    /// <param name="material">設定するマテリアル</param>
    public static void SetObjectMaterial(GameObject obj,Material material)
    {
        MeshRenderer mr = obj.GetComponent<MeshRenderer>();
        mr.material = material;
    }
}
