﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;

namespace MtC.Mod.ChineseParents.ChatControlLib
{
    public static partial class ChatControl
    {
        /// <summary>
        /// 对话数据
        /// </summary>
        public class ChatData
        {
            /// <summary>
            /// 这个对话的名称，主要是用于区分的
            /// </summary>
            public string name = "第二代以后开场剧情";
            /// <summary>
            /// 不确定内容，但是在原版代码中发现如果这个字段为 7000000 并且为试用版会有特殊处理，同时原版对话数据显示一串对话基本都有相同的 type
            /// </summary>
            public int type = 59;
            /// <summary>
            /// 如果是儿子版，下一个对话的 ID
            /// </summary>
            public int next_id = 0;
            /// <summary>
            /// 如果是女儿版，下一个对话的 ID
            /// </summary>
            public int next_id_girl = 0;
            /// <summary>
            /// 儿子版的对话内容
            /// </summary>
            public string text = "转眼间，曾经的孩子已经长大成人，自己也做了父母，也有了一个可爱的宝宝。";
            /// <summary>
            /// 儿子版的对话内容 id
            /// </summary>
            public int text_id = 1018174;
            /// <summary>
            /// 女儿版的对话内容
            /// </summary>
            public string text_girl = "转眼间，曾经的孩子已经长大成人，自己也做了父母，也有了一个可爱的宝宝。";
            /// <summary>
            /// 女儿版的对话内容 id
            /// </summary>
            public int text_girl_id = 1020365;
            /// <summary>
            /// 儿子版这个对话完成后添加期望的 id
            /// </summary>
            public int add_task = 0;
            /// <summary>
            /// 儿子版中这个对话说话的人的名字
            /// </summary>
            public string player = "旁白君";
            /// <summary>
            /// 儿子版中这个对话说话的人的 ID
            /// </summary>
            public int player_id = 1022358;
            /// <summary>
            /// 儿子版中这个对话显示的人物图片
            /// </summary>
            public string image = "0";
            /// <summary>
            /// 女儿版这个对话完成后添加期望的 id
            /// </summary>
            public int add_task_girl = 0;
            /// <summary>
            /// 女儿版中这个对话说话的人的名字
            /// </summary>
            public string player_girl = "旁白君";
            /// <summary>
            /// 女儿版中这个对话说话的人的 ID
            /// </summary>
            public int player_girl_id = 1025134;
            /// <summary>
            /// 女儿版中这个对话显示的人物图片
            /// </summary>
            public string image_girl = "0";
            /// <summary>
            /// 好感度变化动画效果，1 是好感度提高，2 是好感度下降，0 是不播放好感变化动画
            /// </summary>
            public int loving_effect = 0;
            /// <summary>
            /// 背景图，如果是 "0" 则表示没有背景图
            /// </summary>
            public string graph = "0";
            /// <summary>
            /// 对话框弹出效果，1 是有弹出效果，0 是没有
            /// </summary>
            public int shake = 1;
            /// <summary>
            /// 对话完成后发出 Effect 的 id，这个 Effect 是 effect_data.Effect 方法使用的，而这个方法似乎有加属性、开工作选项等功能
            /// </summary>
            public int effect = 0;

            public ChatData() { }

            public ChatData(XmlData chatData)
            {
                name = chatData.GetString("name");
                type = chatData.GetInt("type");
                next_id = chatData.GetInt("next_id");
                next_id_girl = chatData.GetInt("next_id_girl");
                text = chatData.GetString("text");
                text_id = chatData.GetInt("text_id");
                text_girl = chatData.GetString("text_girl");
                text_girl_id = chatData.GetInt("text_girl_id");
                add_task = chatData.GetInt("add_task");
                player = chatData.GetString("player");
                player_id = chatData.GetInt("player_id");
                image = chatData.GetString("image");
                add_task_girl = chatData.GetInt("add_task_girl");
                player_girl = chatData.GetString("player_girl");
                player_girl_id = chatData.GetInt("player_girl_id");
                image_girl = chatData.GetString("image_girl");
                loving_effect = chatData.GetInt("loving_effect");
                graph = chatData.GetString("graph");
                shake = chatData.GetInt("shake");
                effect = chatData.GetInt("effect");
            }

            //public ChatData()
            //{
            //    this.id = chatData.GetInt("id");
            //    this.name = chatData.GetString("name");
            //    this.type = chatData.GetInt("type");
            //    this.next_id = chatData.GetInt("next_id");
            //    this.next_id_girl = chatData.GetInt("next_id_girl");
            //    this.text = chatData.GetString("text");
            //    this.text_id = chatData.GetInt("text_id");
            //    this.text_girl = chatData.GetString("text_girl");
            //    this.text_girl_id = chatData.GetInt("text_girl_id");
            //    this.add_task = chatData.GetInt("add_task");
            //    this.player = chatData.GetString("player");
            //    this.player_id = chatData.GetInt("player_id");
            //    this.image = chatData.GetString("image");
            //    this.add_task_girl = chatData.GetInt("add_task_girl");
            //    this.player_girl = chatData.GetString("player_girl");
            //    this.player_girl_id = chatData.GetInt("player_girl_id");
            //    this.image_girl = chatData.GetString("image_girl");
            //    this.loving_effect = chatData.GetInt("loving_effect");
            //    this.graph = chatData.GetString("graph");
            //    this.shake = chatData.GetInt("shake");
            //    this.effect = chatData.GetInt("effect");
            //}

            /// <summary>
            /// 复制一个新的 <see cref="ChatData"/>
            /// </summary>
            /// <returns></returns>
            public ChatData Copy()
            {
                ChatData newChatData = new ChatData();

                newChatData.name = name;
                newChatData.type = type;
                newChatData.next_id = next_id;
                newChatData.next_id_girl = next_id_girl;
                newChatData.text = text;
                newChatData.text_id = text_id;
                newChatData.text_girl = text_girl;
                newChatData.text_girl_id = text_girl_id;
                newChatData.add_task = add_task;
                newChatData.player = player;
                newChatData.player_id = player_id;
                newChatData.image = image;
                newChatData.add_task_girl = add_task_girl;
                newChatData.player_girl = player_girl;
                newChatData.player_girl_id = player_girl_id;
                newChatData.image_girl = image_girl;
                newChatData.loving_effect = loving_effect;
                newChatData.graph = graph;
                newChatData.shake = shake;
                newChatData.effect = effect;

                return newChatData;
            }

            /// <summary>
            /// 返回这个对话数据的 <see cref="XmlData"/> 版
            /// </summary>
            /// <returns></returns>
            public XmlData ToXmlData()
            {
                // XmlData 的创建逻辑是用 Dictionary 作为参数创建，所以不能直接 new 一个 XmlData
                Dictionary<string, string> data = new Dictionary<string, string>();

                data.Add("name", name != null ? name.ToString() : "0");
                data.Add("type", type.ToString());
                data.Add("next_id", next_id.ToString());
                data.Add("next_id_girl", next_id_girl.ToString());
                data.Add("text", text != null ? text.ToString() : "0");
                data.Add("text_id", text_id.ToString());
                data.Add("text_girl", text_girl != null ? text_girl.ToString() : "0");
                data.Add("text_girl_id", text_girl_id.ToString());
                data.Add("add_task", add_task.ToString());
                data.Add("player", player != null ? player.ToString() : "0");
                data.Add("player_id", player_id.ToString());
                data.Add("image", image != null ? image.ToString() : "0");
                data.Add("add_task_girl", add_task_girl.ToString());
                data.Add("player_girl", player_girl != null ? player_girl.ToString() : "0");
                data.Add("player_girl_id", player_girl_id.ToString());
                data.Add("image_girl", image_girl != null ? image_girl.ToString() : "0");
                data.Add("loving_effect", loving_effect.ToString());
                data.Add("graph", graph != null ? graph.ToString() : "0");
                data.Add("shake", shake.ToString());
                data.Add("effect", effect.ToString());

                return new XmlData(data);
            }
        }

        /// <summary>
        /// 没有文本的文本 ID
        /// </summary>
        public const int NO_TEXT_ID = 2010001;

        /// <summary>
        /// 优先处理方法列表，这个列表中的方法将会优先于修改对话对【每一条】对话进行处理，参数格式与修改对话的方法一致
        /// </summary>
        internal static List<Func<ChatData, ChatData, ChatData>> beforeModify = new List<Func<ChatData, ChatData, ChatData>>();
        /// <summary>
        /// 需要修改的对话的列表，委托的格式是 处理后的对话数据 Func(原逻辑的对话数据, 经过前面的委托处理后的对话数据)
        /// </summary>
        internal static Dictionary<int, List<Func<ChatData, ChatData, ChatData>>> modifyChats = new Dictionary<int, List<Func<ChatData, ChatData, ChatData>>>();
        /// <summary>
        /// 文本 id 到对话 id 的映射表，儿子女儿文本共用
        /// </summary>
        internal static Dictionary<int, int> textIdToChatId = new Dictionary<int, int>();

        /// <summary>
        /// 对所有对话进行修改，在指定修改之前进行
        /// </summary>
        /// <param name="modify">修改方法，格式是：修改后的对话数据 Modify(原逻辑获取到的原始对话数据, 经过前面的修改方法修改后的对话数据)<br/>注意这个方法不能修改 text_id 和 text_girl_id 可能导致深层的逻辑 Bug</param>
        public static void BeforeModifyChat(Func<ChatData, ChatData, ChatData> modify)
        {
            // 添加进优先处理方法列表里
            beforeModify.Add(modify);
        }

        /// <summary>
        /// 移除对所有对话进行修改的方法
        /// </summary>
        /// <param name="modify">修改方法，格式是：修改后的对话数据 Modify(原逻辑获取到的原始对话数据, 经过前面的修改方法修改后的对话数据)<br/>注意这个方法不能修改 text_id 和 text_girl_id 可能导致深层的逻辑 Bug</param>
        public static void RemoveBeforeModifyChat(Func<ChatData, ChatData, ChatData> modify)
        {
            // 从优先处理方法列表里移除
            beforeModify.Remove(modify);
        }

        /// <summary>
        /// 修改指定的对话
        /// </summary>
        /// <param name="chatId">要修改的对话的 ID</param>
        /// <param name="modify">修改方法，格式是：修改后的对话数据 Modify(原逻辑获取到的原始对话数据, 经过前面的修改方法修改后的对话数据)<br/>注意这个方法不能修改 text_id 和 text_girl_id 可能导致深层的逻辑 Bug</param>
        public static void ModifyChat(int chatId, Func<ChatData, ChatData, ChatData> modify)
        {
            // 如果没有修改这个 ID 对话的方法则先创建列表
            if (!modifyChats.ContainsKey(chatId))
            {
                modifyChats.Add(chatId, new List<Func<ChatData, ChatData, ChatData>>());
            }

            // 添加修改方法到列表里
            modifyChats[chatId].Add(modify);
        }

        /// <summary>
        /// 取消修改指定的对话
        /// </summary>
        /// <param name="chatId">要取消修改的对话的 ID</param>
        /// <param name="modify">修改方法，格式是：修改后的对话数据 Modify(原逻辑获取到的原始对话数据, 经过前面的修改方法修改后的对话数据)<br/>注意这个方法不能修改 text_id 和 text_girl_id 可能导致深层的逻辑 Bug</param>
        public static void RemoveModifyChat(int chatId, Func<ChatData, ChatData, ChatData> modify)
        {
            // 如果没有修改这个 ID 对话的方法则先创建列表
            if (!modifyChats.ContainsKey(chatId))
            {
                modifyChats.Add(chatId, new List<Func<ChatData, ChatData, ChatData>>());
            }

            // 添加修改方法到列表里
            modifyChats[chatId].Add(modify);
        }
    }

    /// <summary>
    /// 读取数据方法。对话内容通过这个方法读取，在这里后缀即可修改对话内容
    /// </summary>
    [HarmonyPatch(typeof(ReadXml), "GetData")]
    public static class ReadXml_GetData
    {
        /// <summary>
        /// 在前后缀之间传递 GetData 方法参数的类
        /// </summary>
        private class GetDataParam
        {
            public string fileName;
            public int id;

            public GetDataParam(string fileName, int id)
            {
                this.fileName = fileName;
                this.id = id;
            }
        }

        private static void Prefix(out GetDataParam __state, string fileName, int id)
        {
            // 将参数传给后缀，这是因为这个方法有可能在内部改变参数
            __state = new GetDataParam(fileName, id);
        }

        private static void Postfix(GetDataParam __state, ref XmlData __result)
        {
            // 如果 Mod 未启动则不作处理
            if (!Main.enabled)
            {
                return;
            }

            // 如果要获取的不是对话数据则不处理
            if (!"chat".Equals(__state.fileName))
            {
                return;
            }

            // 转化出对话数据
            ChatControl.ChatData originChatData = new ChatControl.ChatData(__result);
            ChatControl.ChatData modifiedChatData = new ChatControl.ChatData(__result);

            // 进行优先处理
            ChatControl.beforeModify.ForEach(modify =>
            {
                modifiedChatData = modify.Invoke(originChatData, modifiedChatData);
            });

            // 如果这个对话有针对性进行修改的方法，则依次进行调用进行修改
            if (ChatControl.modifyChats.ContainsKey(__state.id))
            {
                Main.ModEntry.Logger.Log("发现 id 为 " + __state.id + " 的对话需要针对性修改");

                // 遍历修改
                ChatControl.modifyChats[__state.id].ForEach(modify =>
                {
                    modifiedChatData = modify.Invoke(originChatData, modifiedChatData);
                });
            }

            // 用编辑后的对话数据替换原来的对话数据
            __result = modifiedChatData.ToXmlData();

            // 记录文本 id 到对话 id 的映射。如果是无文本 id 则不记录，如果已有文本 id 的映射也不改变，理论上只要思路上没有出现问题应该不会有人给不同的对话安排相同的文本 id
            if (!ChatControl.textIdToChatId.ContainsKey(modifiedChatData.text_id) && modifiedChatData.text_id != ChatControl.NO_TEXT_ID)
            {
                ChatControl.textIdToChatId.Add(modifiedChatData.text_id, __state.id);
            }
            if (!ChatControl.textIdToChatId.ContainsKey(modifiedChatData.text_girl_id) && modifiedChatData.text_girl_id != ChatControl.NO_TEXT_ID)
            {
                ChatControl.textIdToChatId.Add(modifiedChatData.text_girl_id, __state.id);
            }
        }
    }

    /// <summary>
    /// 读取数据方法。对话内容通过这个方法读取，在这里后缀即可修改对话内容
    /// </summary>
    [HarmonyPatch(typeof(XmlData), "GetStringLanguage", new Type[] { typeof(string), typeof(bool) })]
    public static class XmlData_GetStringLanguage
    {
        /// <summary>
        /// 在前后缀之间传递 GetStringLanguage 方法参数的类
        /// </summary>
        private class GetStringLanguageParam
        {
            public string name;
            public bool sex;

            public GetStringLanguageParam(string name, bool sex)
            {
                this.name = name;
                this.sex = sex;
            }
        }

        private static void Prefix(out GetStringLanguageParam __state, string name, bool sex)
        {
            // 将参数传给后缀，这是因为这个方法有可能在内部改变参数
            __state = new GetStringLanguageParam(name, sex);
        }

        private static void Postfix(GetStringLanguageParam __state, XmlData __instance, ref string __result)
        {
            // 如果 Mod 未启动则不作处理
            if (!Main.enabled)
            {
                return;
            }

            // 如果要获取的不是对话文本则不处理
            if (!"text".Equals(__state.name) || !__state.sex)
            {
                return;
            }

            // 通过映射表获取对话 id
            int chatId = int.MinValue;
            if (ChatControl.textIdToChatId.ContainsKey(__instance.GetInt("text_id")))
            {
                chatId = ChatControl.textIdToChatId[__instance.GetInt("text_id")];
                Main.ModEntry.Logger.Log("发现使用了 id 为 " + __instance.GetInt("text_id") + " 的对话，对话 id = " + chatId);
            }
            else if (ChatControl.textIdToChatId.ContainsKey(__instance.GetInt("text_girl_id")))
            {
                chatId = ChatControl.textIdToChatId[__instance.GetInt("text_girl_id")];
                Main.ModEntry.Logger.Log("发现使用了 id 为 " + __instance.GetInt("text_girl_id") + " 的对话，对话 id = " + chatId);
            }

            // 如果没找到这个文本所属的对话，则说明这个文本所属的对话并不需要修改，那么这个文本也不作处理
            if(chatId == int.MinValue)
            {
                return;
            }

            // 如果不使用旧版文本，而且这个文本不是针对性修改的文本，不作处理
            if(!Main.settings.useOldChatText && !ChatControl.modifyChats.ContainsKey(chatId))
            {
                return;
            }

            // 获取对话内容
            XmlData chatData = ReadXml.GetData("chat", chatId);

            // 根据性别修改返回值为对话文本
            if (record_manager.InstanceManagerRecord.IsBoy())
            {
                __result = chatData.GetString("text");
            }
            else
            {
                __result = chatData.GetString("text_girl");
            }
        }
    }
}
