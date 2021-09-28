using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace MtC.Mod.ChineseParents.ChatControlLib
{
    /// <summary>
    /// 发起对话方法。在这里后缀获取背景图即可进行修复
    /// </summary>
    [HarmonyPatch(typeof(chat_manager), "start_chat")]
    public static class chat_manager_start_chat
    {
        /// <summary>
        /// 上一个对话物体，原版对话的原理是每一句生成一个新的对话物体并销毁旧的对话物体，但那就导致在生成新对话后到渲染前，因为 Unity 的 Destroy 的延迟销毁特性会导致场上有两个对话物体，这个字段用来记录旧的那个
        /// </summary>
        private static GameObject lastChatObject;

        private static void Postfix(chat_manager __instance, GameObject ___PanelGameObject, GameObject ___aGameObject, int id)
        {
            // 如果 Mod 未启动则不处理
            if (!Main.enabled)
            {
                return;
            }

            // 获取对话物体，原逻辑对话的原理是每一句实例化一个对话物体并销毁上一个对话物体，而 Uniy 的 Destroy 是延迟到当前帧渲染前才真正销毁，这就导致从第二句开始场上都是同时存在两个对话物体的，而这里需要的是新的那个
            GameObject chatPanel = GameObject.FindObjectsOfType<GameObject>().Where(go => "Panel_chat(Clone)".Equals(go.name)).Where(go => go != lastChatObject).ToList().Last();

            // 更新旧的对话物体的记录
            lastChatObject = chatPanel;

            // 获取背景图物体
            GameObject backgoundGameObject =  chatPanel.transform.Find("bg").gameObject;

            // 如果背景图物体是禁用的，则说明这个对话没有背景图，不作处理
            if (!backgoundGameObject.activeSelf)
            {
                return;
            }

            // 获取背景图组件
            Image backgroundImage = backgoundGameObject.GetComponent<Image>();

            // 如果背景图组件里设置了图片，则说明背景图获取正常，不需要处理
            if(backgroundImage.sprite != null)
            {
                return;
            }

            // 获取对话数据
            XmlData data = ReadXml.GetData("chat", id);

            // 获取图片 URL
            string backgroundImageURL = data.GetString("graph");

            Main.ModEntry.Logger.Log("修复对话背景，对话背景 URL = " + backgroundImageURL);

            // 按照图片 URL 获取资源并设为背景
            backgroundImage.sprite = (Resources.Load(backgroundImageURL, typeof(Sprite)) as Sprite);
        }
    }
}
