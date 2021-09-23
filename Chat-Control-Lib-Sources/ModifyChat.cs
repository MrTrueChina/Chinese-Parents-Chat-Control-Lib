using System;
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
            /// 这个对话的 ID
            /// </summary>
            public int id = 0;
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

            public ChatData(XmlData chatData)
            {
                id = chatData.GetInt("id");
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
            /// 返回这个对话数据的 <see cref="XmlData"/> 版
            /// </summary>
            /// <returns></returns>
            public XmlData ToXmlData()
            {
                XmlData xmlData = new XmlData();

                xmlData.value.Add("id", id.ToString());
                xmlData.value.Add("name", name != null ? name.ToString() : "0");
                xmlData.value.Add("type", type.ToString());
                xmlData.value.Add("next_id", next_id.ToString());
                xmlData.value.Add("next_id_girl", next_id_girl.ToString());
                xmlData.value.Add("text", text != null ? text.ToString() : "0");
                xmlData.value.Add("text_id", text_id.ToString());
                xmlData.value.Add("text_girl", text_girl != null ? text_girl.ToString() : "0");
                xmlData.value.Add("text_girl_id", text_girl_id.ToString());
                xmlData.value.Add("add_task", add_task.ToString());
                xmlData.value.Add("player", player != null ? player.ToString() : "0");
                xmlData.value.Add("player_id", player_id.ToString());
                xmlData.value.Add("image", image != null ? image.ToString() : "0");
                xmlData.value.Add("add_task_girl", add_task_girl.ToString());
                xmlData.value.Add("player_girl", player_girl != null ? player_girl.ToString() : "0");
                xmlData.value.Add("player_girl_id", player_girl_id.ToString());
                xmlData.value.Add("image_girl", image_girl != null ? image_girl.ToString() : "0");
                xmlData.value.Add("loving_effect", loving_effect.ToString());
                xmlData.value.Add("graph", graph != null ? graph.ToString() : "0");
                xmlData.value.Add("shake", shake.ToString());
                xmlData.value.Add("effect", effect.ToString());

                return xmlData;
            }
        }

        /// <summary>
        /// 需要修改的对话的列表，委托的格式是 处理后的对话数据 Func(原逻辑的对话数据, 经过前面的委托处理后的对话数据)
        /// </summary>
        internal static Dictionary<int, List<Func<ChatData, ChatData, ChatData>>> modifyChats = new Dictionary<int, List<Func<ChatData, ChatData, ChatData>>>();

        /// <summary>
        /// 修改指定的对话
        /// </summary>
        /// <param name="chatId">要修改的对话的 ID</param>
        /// <param name="modify">修改方法，格式是：修改后的对话数据 Modify(原逻辑获取到的原始对话数据, 经过前面的修改方法修改后的对话数据)</param>
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
        /// <param name="modify">修改方法，格式是：修改后的对话数据 Modify(原逻辑获取到的原始对话数据, 经过前面的修改方法修改后的对话数据)</param>
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

            // 如果这个对话有进行修改的方法，则依次进行调用进行修改
            if (ChatControl.modifyChats.ContainsKey(__state.id))
            {
                // 转化出对话数据
                ChatControl.ChatData originChatData = new ChatControl.ChatData(__result);
                ChatControl.ChatData modifiedChatData = new ChatControl.ChatData(__result);

                // 遍历修改
                ChatControl.modifyChats[__state.id].ForEach(modify =>
                {
                    modifiedChatData = modify.Invoke(originChatData, modifiedChatData);
                });

                // 用编辑后的对话数据替换原来的对话数据
                __result = modifiedChatData.ToXmlData();
            }
        }
    }
}
