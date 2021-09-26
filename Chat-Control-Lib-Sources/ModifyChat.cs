using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;

namespace MtC.Mod.ChineseParents.ChatControlLib
{
    /// <summary>
    /// 对话控制器
    /// </summary>
    public static partial class ChatControl
    {
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
        /// 对话 ID 计数器
        /// </summary>
        private static int chatIdCounter = -1;
        /// <summary>
        /// 文本 ID 计数器
        /// </summary>
        private static int textIdCounter = -1;

        /// <summary>
        /// 默认对话 ID，如果要获取的对话 ID 没有数据则替换为这个 ID
        /// </summary>
        internal const int DEFAULT_CHAT_ID = 10001;
        /// <summary>
        /// 默认文本 ID，如果要获取的文本 ID 没有数据则替换为这个 ID
        /// </summary>
        internal const int DEFAULT_TEXT_ID = 1018095;

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

        /// <summary>
        /// 申请一定数量的对话 id，这个对话 id 可以用来添加修改对话，如果不从这个方法申请 id 则可能由于 id 冲突发生对话修改错误
        /// </summary>
        /// <param name="number"></param>
        public static List<int> ApplyChatIds(int number)
        {
            List<int> chatIds = new List<int>();

            for (int i = 0; i < number; i++)
            {
                chatIdCounter--;
                chatIds.Add(chatIdCounter);
            }

            return chatIds;
        }

        /// <summary>
        /// 申请一定数量的文本 id，这个文本 id 可以用来添加修改对话，如果不从这个方法申请 id 则可能由于 id 冲突发生对话修改错误
        /// </summary>
        /// <param name="number"></param>
        public static List<int> ApplyTextIds(int number)
        {
            List<int> textIds = new List<int>();

            for (int i = 0; i < number; i++)
            {
                textIdCounter--;
                textIds.Add(textIdCounter);
            }

            return textIds;
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

        private static void Prefix(out GetDataParam __state, string fileName, ref int id)
        {
            // 将参数传给后缀，这是因为这个方法有可能在内部改变参数
            __state = new GetDataParam(fileName, id);

            // 如果 Mod 未启动则不作处理
            if (!Main.enabled)
            {
                return;
            }

            // 如果要获取的是对话数据 并且 没有要获取的 id 的对话，那么这个对话就是新添加的对话，将 id 替换为默认对话 id
            if ("chat".Equals(__state.fileName) && !ReadXml.HaveData(__state.fileName, __state.id))
            {
                id = ChatControl.DEFAULT_CHAT_ID;
                return;
            }

            // 如果要获取的是文本数据 并且 没有要获取的 id 的文本，那么这个文本就是新添加的对话的文本，将 id 替换为默认文本 id
            if ("language".Equals(__state.fileName) && !ReadXml.HaveData(__state.fileName, __state.id))
            {
                id = ChatControl.DEFAULT_TEXT_ID;
                return;
            }
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
            ChatData originChatData = new ChatData(__result);
            ChatData modifiedChatData = new ChatData(__result);

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
            if (!ChatControl.textIdToChatId.ContainsKey(modifiedChatData.text_id) && modifiedChatData.text_id != ChatData.NO_TEXT_ID)
            {
                ChatControl.textIdToChatId.Add(modifiedChatData.text_id, __state.id);
            }
            if (!ChatControl.textIdToChatId.ContainsKey(modifiedChatData.text_girl_id) && modifiedChatData.text_girl_id != ChatData.NO_TEXT_ID)
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
