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
            /// 不确定内容，但是在原版代码中发现如果这个字段为 7000000 并且为试用版会有特殊处理
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
            public int add_task = 0;
            public string player = "旁白君";
            public int player_id = 1022358;
            public int image = 0;
            public int add_task_girl = 0;
            public string player_girl = "旁白君";
            public int player_girl_id = 1025134;
            public int image_girl = 0;
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
            public int effect = 0;
        }

        /// <summary>
        /// 需要修改的对话的列表
        /// </summary>
        internal static Dictionary<int, List<Func<XmlData, XmlData, XmlData>>> modifyChats = new Dictionary<int, List<Func<XmlData, XmlData, XmlData>>>();
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
        private static void Postfix(string fileName, int id)
        {
            // 如果 Mod 未启动则不作处理
            if (!Main.enabled)
            {
                return;
            }

            // 如果要获取的不是对话数据则不处理
            if (!"chat".Equals(fileName))
            {
                return;
            }

            // TODO：修改功能需要一个字典表，这个表记录了需要修改的 ID 和对应的修改方式的列表

            // TODO：需要测试获取没有数据的对话 ID 会怎么样，如果会报错的话就需要查一下 Harmony 有没有处理异常的能力，如果不会报错的话就看看会返回什么
            // 如果 Harmony 没有处理异常的能力的话，也可以考虑查一个肯定有的，因为这种情况应该是有新增的对话，而新对话应该是可以覆盖旧对话的
        }
    }
}
