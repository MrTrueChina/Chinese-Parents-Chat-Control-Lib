using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MtC.Mod.ChineseParents.ChatControlLib
{
    public class ChatData
    {
        /// <summary>
        /// 没有文本的文本 ID
        /// </summary>
        public const int NO_TEXT_ID = 2010001;

        /// <summary>
        /// 这个对话的 id，需要注意这个值在 XmlData 里是没有的
        /// </summary>
        public int id = 0;
        /// <summary>
        /// 这个对话的名称，主要是用于区分的
        /// </summary>
        public string name = "";
        /// <summary>
        /// 不确定内容，但是在原版代码中发现如果这个字段为 7000000 并且为试用版会有特殊处理，同时原版对话数据显示一串对话基本都有相同的 type
        /// </summary>
        public int type = 0;
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
        public string text = "0";
        /// <summary>
        /// 儿子版的对话内容 id
        /// </summary>
        public int text_id = NO_TEXT_ID;
        /// <summary>
        /// 女儿版的对话内容
        /// </summary>
        public string text_girl = "0";
        /// <summary>
        /// 女儿版的对话内容 id
        /// </summary>
        public int text_girl_id = NO_TEXT_ID;
        /// <summary>
        /// 儿子版这个对话完成后添加期望的 id
        /// </summary>
        public int add_task = 0;
        /// <summary>
        /// 儿子版中这个对话说话的人的名字
        /// </summary>
        public string player = "";
        /// <summary>
        /// 儿子版中这个对话说话的人的 ID
        /// </summary>
        public int player_id = 0;
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
        public string player_girl = "";
        /// <summary>
        /// 女儿版中这个对话说话的人的 ID
        /// </summary>
        public int player_girl_id = 0;
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

        /// <summary>
        /// 用于创建对话内容的构造方法，这个方法会尽可能的将儿子版和女儿版字段使用相同的数值
        /// </summary>
        /// <param name="text">对话的文本</param>
        /// <param name="player">说这段话的人的名字</param>
        /// <param name="player_id">说这段话的人的 id</param>
        /// <param name="playerImage">说这段话的人的图片</param>
        /// <param name="backgroundGraph">背景图</param>
        /// <param name="shake">弹出对话框效果，1 是弹出对话框，0 是不弹出对话框</param>
        /// <param name="lovingEffect">好感效果，1 是好感度提高，2 是好感度下降，0 是不播放好感变化动画</param>
        /// <param name="taskId">对话完成后添加期望的 id</param>
        /// <param name="effectId">对话完成后产生效果的 id</param>
        public ChatData(string text, string player, int player_id, string playerImage, string backgroundGraph, int shake, int lovingEffect, int taskId, int effectId)
        {
            this.text = text;
            this.text_girl = text;
            this.player = player;
            this.player_girl = player;
            this.player_id = player_id;
            this.player_girl_id = player_id;
            this.image = playerImage;
            this.image_girl = playerImage;
            this.graph = backgroundGraph;
            this.shake = shake;
            this.loving_effect = lovingEffect;
            this.add_task = taskId;
            this.add_task_girl = taskId;
            this.effect = effectId;

            //type = chatData.GetInt("type");
            //next_id = chatData.GetInt("next_id");
            //next_id_girl = chatData.GetInt("next_id_girl");
            //text_id = chatData.GetInt("text_id");
            //text_girl_id = chatData.GetInt("text_id");
        }

        /// <summary>
        /// 复制一个新的 <see cref="ChatData"/>
        /// </summary>
        /// <returns></returns>
        public ChatData Copy()
        {
            ChatData newChatData = new ChatData();

            newChatData.id = id;
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
}
