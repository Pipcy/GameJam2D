//2.13.1
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//****

public class Menu : MonoBehaviour
{

    public void loadMenu() {
        SceneManager.LoadScene("Menu"); }

    public void loadPC(){
        SceneManager.LoadScene("pcInterface"); }

    public void loadSceneNormal2D(){
        SceneManager.LoadScene("Normal2D"); }

    public void loadFlipPath() {
        SceneManager.LoadScene("FlippedPath"); }

    public void loadFlipGravity() {
        SceneManager.LoadScene("Flipped_Grav"); }

    public void loadConvo1() {
        SceneManager.LoadScene("Conversation1"); }

    public void loadEnding() {
        SceneManager.LoadScene("Ending"); }

    



}