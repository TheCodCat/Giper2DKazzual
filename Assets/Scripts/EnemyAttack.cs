using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour
{
    public string playerTag;
    public string nameScene;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.transform.tag == playerTag) LoadScene();
    }
    private void LoadScene()
    {
        StartCoroutine(SceneLoading());

        IEnumerator SceneLoading()
        {
            ControllerGame.isPause = true;
            Time.timeScale = 0;
            SceneManager.LoadSceneAsync(nameScene);
            yield return new WaitForSeconds(1);
        }
    }
}
