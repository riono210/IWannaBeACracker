using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerLampFlash : MonoBehaviour {
    
    public GameObject lapm;  // ランプオブジェクト
    public float delay = 0f; // 遅延
    public int flashType;
    Material lampOn;  // 光るマテリアル
    Material lampOff;  // 光ってないマテリアル



	// Use this for initialization
	void Start () {
        // マテリアルを取得
        lampOn = Resources.Load("ServerLampOn") as Material;
        lampOff = Resources.Load("ServerLampOff") as Material;

        // 点滅種類切り替え
        switch(flashType){
            case 1:
                // 点滅
                StartCoroutine(Flash1(delay));
                break;

            case 2:
                // 点滅
                StartCoroutine(Flash2(delay));
                break;

            case 3:
                // 点滅
                StartCoroutine(Flash3(delay));
                break;

            default:
                // 点滅
                StartCoroutine(Flash2(delay));
                break;
        }             
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // 2点滅,1点滅
    private IEnumerator Flash1(float gap) {
        lapm.GetComponent<MeshRenderer>().material = lampOff;
        yield return new WaitForSeconds(gap);

        while (true) {

            lapm.GetComponent<MeshRenderer>().material = lampOn;
            yield return new WaitForSeconds(0.1f);

            lapm.GetComponent<MeshRenderer>().material = lampOff;
            yield return new WaitForSeconds(0.1f);

            lapm.GetComponent<MeshRenderer>().material = lampOn;
            yield return new WaitForSeconds(0.1f);

            lapm.GetComponent<MeshRenderer>().material = lampOff;
            yield return new WaitForSeconds(0.5f);

            lapm.GetComponent<MeshRenderer>().material = lampOn;
            yield return new WaitForSeconds(0.3f);

            lapm.GetComponent<MeshRenderer>().material = lampOff;
            yield return new WaitForSeconds(1f);

        }
    }

    // 1点滅
    private IEnumerator Flash2(float gap){
        lapm.GetComponent<MeshRenderer>().material = lampOff;
        yield return new WaitForSeconds(gap);

        while(true){

            lapm.GetComponent<MeshRenderer>().material = lampOn;
            yield return new WaitForSeconds(0.1f);

            lapm.GetComponent<MeshRenderer>().material = lampOff;
            yield return new WaitForSeconds(1f);
        }
    }


    // ゆっくり1点滅
    private IEnumerator Flash3(float gap) {
        lapm.GetComponent<MeshRenderer>().material = lampOff;
        yield return new WaitForSeconds(gap);

        while (true) {

            lapm.GetComponent<MeshRenderer>().material = lampOn;
            yield return new WaitForSeconds(0.5f);

            lapm.GetComponent<MeshRenderer>().material = lampOff;
            yield return new WaitForSeconds(5f);
        }
    }
}
