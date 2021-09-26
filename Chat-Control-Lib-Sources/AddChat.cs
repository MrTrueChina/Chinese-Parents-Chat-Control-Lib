using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MtC.Mod.ChineseParents.ChatControlLib
{
    /// <summary>
    /// 添加对话的类
    /// </summary>
    public static partial class ChatControl
    {
        /// <summary>
        /// 用于添加对话的参数
        /// </summary>
        public class AddChatPrams
        {
            /// <summary>
            /// 讲话的人
            /// </summary>
            public CharacterData player;
            /// <summary>
            /// 讲话的文本
            /// </summary>
            public string text;
            /// <summary>
            /// 背景
            /// </summary>
            public string backgound;
        }

        /// <summary>
        /// 添加长对话
        /// </summary>
        /// <param name="chatParams">对话数据</param>
        /// <param name="lovingEffect">对话播放完后播放的好感度变化特效，0 是不播放，1 是好感度上升，2 是好感度下降</param>
        /// <param name="effect">对话播放完后添加的效果的 ID，0 表示无效果</param>
        /// <param name="task">对话播放完后添加的期望的 ID，0 表示不添加期望</param>
        /// <returns></returns>
        public static List<int> AddChats(List<AddChatPrams> chatParams, int lovingEffect, int effect, int task)
        {
            // 获取足够的 id
            List<int> chatIds = ApplyChatIds(chatParams.Count);
            List<int> textIds = ApplyTextIds(chatParams.Count);

            // 准备对话数据的列表
            List<ChatData> chatDatas = new List<ChatData>();

            // 填充每一个对话数据的可以直接填充的内容并加入列表
            for(int i = 0;i < chatParams.Count; i++)
            {
                AddChatPrams chatParam = chatParams[i];
                
                // 生成对话数据
                ChatData chatData = new ChatData(chatIds[i], chatIds[i], "", chatParam.player.Name, chatParam.player.PlayerId, chatParam.player.Name, chatParam.player.PlayerId, chatParam.player.Image, chatParam.player.Image, chatParam.text, textIds[i], chatParam.text, textIds[i], chatParam.backgound, 0, 0, 0, 0, 0, 0, 0);
            }

            // 连接所有对话并设置弹出对话框特效
            for(int i = 0; i < chatDatas.Count; i++)
            {
                ChatData lastData = i > 0 ? chatDatas[i - 1] : null;
                ChatData currentData = chatDatas[i];
                ChatData nextData = i < chatDatas.Count - 1 ? chatDatas[i + 1] : null;

                // 弹出对话框特效，第一个对话和每一个和前一个对话说话人不一样的对话播放弹出框特效
                currentData.shake = (lastData == null || !object.Equals(currentData.player, lastData.player)) ? 1 : 0;

                // 下一个文本 id，按照顺序保存，最后一个对话保存 0，表示结束
                currentData.next_id = nextData != null ? nextData.id : 0;
                currentData.next_id_girl = nextData != null ? nextData.id : 0;
            }

            // 给最后一个对话设置播放结束后的特效和副作用
            chatDatas.Last().loving_effect = lovingEffect;
            chatDatas.Last().effect = effect;
            chatDatas.Last().add_task = task;
            chatDatas.Last().add_task_girl = task;

            // 将所有对话添加到对话管理器中
            chatDatas.ForEach(chat =>
            {
                ModifyChat(chat.id, (origin, before) => { return chat; });
            });

            // 返回对话 ID 列表
            return chatIds;
        }
    }
}
