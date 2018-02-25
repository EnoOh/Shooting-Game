using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emitter : MonoBehaviour {

    public GameObject[] waves;
    //現在のwave
    private int currentWave;

    private IEnumerator Start()
    {
        if(waves.Length == 0)
        {
            //waveが無ければコルーチン終了
            yield break;
        }

        while (true)
        {
            //waveの生成
            GameObject wave = (GameObject)Instantiate(waves[currentWave], transform.position, Quaternion.identity);
            //waveをEmitterの子要素に
            wave.transform.parent = transform;

            while(wave.transform.childCount != 0)
            {
                //waveの子要素のEnemyが全滅するまで待機
                yield return new WaitForEndOfFrame();
            }
            Destroy(wave);

            //格納されているwaveを実行したら現在のwaveを0に
            if(waves.Length <= ++currentWave)
            {
                currentWave = 0;
            }
        }
    }

    void Update () {
		
	}
}
