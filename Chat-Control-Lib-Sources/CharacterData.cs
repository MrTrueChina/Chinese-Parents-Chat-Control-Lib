using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MtC.Mod.ChineseParents.ChatControlLib
{
    /// <summary>
    /// 人物数据
    /// </summary>
    public class CharacterData
    {
        /// <summary>
        /// 人物图片
        /// </summary>
        public string Image { get; private set; }
        /// <summary>
        /// 人物名称
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// 人物对话 id，这个 id 用于获取对话的讲话的人的名字
        /// </summary>
        public int PlayerId { get; private set; }
        private CharacterData(string graph, string name, int playerId)
        {
            Image = graph;
            Name = name;
            PlayerId = playerId;
        }

        /// <summary>
        /// 旁白君的数据
        /// </summary>
        public static readonly CharacterData NARRATOR = new CharacterData("0", "旁白君", 1022250);
        /// <summary>
        /// 儿子
        /// </summary>
        public static class Son
        {

        }
        /// <summary>
        /// 女儿
        /// </summary>
        public static class Daughter
        {
            /// <summary>
            /// 好心情数据
            /// </summary>
            public static readonly CharacterData GOOD = new CharacterData("chat_daughter_a","我", 1023892);
            /// <summary>
            /// 默认数据
            /// </summary>
            public static readonly CharacterData NORMAL = new CharacterData("chat_daughter", "我", 1023892);
            /// <summary>
            /// 坏心情数据
            /// </summary>
            public static readonly CharacterData BAD = new CharacterData("chat_daughter", "我", 1023892);
            /// <summary>
            /// 女儿当妈之后的数据
            /// </summary>
            public static readonly CharacterData MOM = new CharacterData("mom_girl", "妈 妈", 1025010);
        }
        /// <summary>
        /// 刘偏偏
        /// </summary>
        public static class LiuPianPian
        {
            /// <summary>
            /// 好心情数据
            /// </summary>
            public static readonly CharacterData GOOD = new CharacterData("chat_girl3_a", "刘偏偏", 1025104);
            /// <summary>
            /// 默认数据
            /// </summary>
            public static readonly CharacterData NORMAL = new CharacterData("chat_girl3", "刘偏偏", 1025104);
            /// <summary>
            /// 坏心情数据
            /// </summary>
            public static readonly CharacterData BAD = new CharacterData("chat_girl3_b", "刘偏偏", 1025104);
            /// <summary>
            /// 当妈之后的图片
            /// </summary>
            public static readonly CharacterData MOM = new CharacterData("chat_mom_1001", "妈 妈", 1025010);
        }
        /// <summary>
        /// 席梦来
        /// </summary>
        public static class XiMengLai
        {
            /// <summary>
            /// 好心情数据
            /// </summary>
            public static readonly CharacterData GOOD = new CharacterData("chat_girl4_a", "席梦来", 1025122);
            /// <summary>
            /// 默认数据
            /// </summary>
            public static readonly CharacterData NORMAL = new CharacterData("chat_girl4", "席梦来", 1025122);
            /// <summary>
            /// 坏心情数据
            /// </summary>
            public static readonly CharacterData BAD = new CharacterData("chat_girl4_b", "席梦来", 1025122);
        }
        /// <summary>
        /// 秦屿路
        /// </summary>
        public static class QinYuLu
        {
            /// <summary>
            /// 好心情数据
            /// </summary>
            public static readonly CharacterData GOOD = new CharacterData("chat_girl2_a", "秦屿路", 1025421);
            /// <summary>
            /// 默认数据
            /// </summary>
            public static readonly CharacterData NORMAL = new CharacterData("chat_girl2", "秦屿路", 1025421);
            /// <summary>
            /// 坏心情数据
            /// </summary>
            public static readonly CharacterData BAD = new CharacterData("chat_girl2_b", "秦屿路", 1025421);
        }
        /// <summary>
        /// 章涵之
        /// </summary>
        public static class ZhangHanZhi
        {
            /// <summary>
            /// 好心情数据
            /// </summary>
            public static readonly CharacterData GOOD = new CharacterData("chat_girl1_a", "章涵之", 1025429);
            /// <summary>
            /// 默认数据
            /// </summary>
            public static readonly CharacterData NORMAL = new CharacterData("chat_girl1", "章涵之", 1025429);
            /// <summary>
            /// 坏心情数据
            /// </summary>
            public static readonly CharacterData BAD = new CharacterData("chat_girl1_b", "章涵之", 1025429);
            /// <summary>
            /// 当妈之后的图片
            /// </summary>
            public static readonly CharacterData MON = new CharacterData("chat_mom_1006", "妈 妈", 1025429);
        }
        /// <summary>
        /// 王胜男
        /// </summary>
        public static class WangShengNan
        {
            /// <summary>
            /// 好心情数据
            /// </summary>
            public static readonly CharacterData GOOD = new CharacterData("chat_girl5_a", "王胜男", 1025426);
            /// <summary>
            /// 默认数据
            /// </summary>
            public static readonly CharacterData NORMAL = new CharacterData("chat_girl5", "王胜男", 1025426);
            /// <summary>
            /// 坏心情数据
            /// </summary>
            public static readonly CharacterData BAD = new CharacterData("chat_girl5_b", "王胜男", 1025426);
        }
        /// <summary>
        /// 李若放
        /// </summary>
        public static class LiRuoFang
        {
            /// <summary>
            /// 好心情数据
            /// </summary>
            public static readonly CharacterData GOOD = new CharacterData("chat_girl6_a", "李若放", 1025427);
            /// <summary>
            /// 默认数据
            /// </summary>
            public static readonly CharacterData NORMAL = new CharacterData("chat_girl6", "李若放", 1025427);
            /// <summary>
            /// 坏心情数据
            /// </summary>
            public static readonly CharacterData BAD = new CharacterData("chat_girl6_b", "李若放", 1025427);
        }
        /// <summary>
        /// 汤金娜
        /// </summary>
        public static class TangJinNa
        {
            /// <summary>
            /// 好心情数据
            /// </summary>
            public static readonly CharacterData GOOD = new CharacterData("chat_girl7_a", "汤金娜", 1025423);
            /// <summary>
            /// 默认数据
            /// </summary>
            public static readonly CharacterData NORMAL = new CharacterData("chat_girl7", "汤金娜", 1025423);
            /// <summary>
            /// 坏心情数据
            /// </summary>
            public static readonly CharacterData BAD = new CharacterData("chat_girl7_b", "汤金娜", 1025423);
        }
        /// <summary>
        /// 苏芳允
        /// </summary>
        public static class SuFangYun
        {
            /// <summary>
            /// 好心情数据
            /// </summary>
            public static readonly CharacterData GOOD = new CharacterData("chat_girl8_a", "苏芳允", 1029616);
            /// <summary>
            /// 默认数据
            /// </summary>
            public static readonly CharacterData NORMAL = new CharacterData("chat_girl8", "苏芳允", 1029616);
            /// <summary>
            /// 坏心情数据
            /// </summary>
            public static readonly CharacterData BAD = new CharacterData("chat_girl8_b", "苏芳允", 1029616);
        }
        /// <summary>
        /// 牧唯
        /// </summary>
        public static class MuWei
        {
            /// <summary>
            /// 好心情数据
            /// </summary>
            public static readonly CharacterData GOOD = new CharacterData("chat_girl9_a", "牧唯", 1030822);
            /// <summary>
            /// 默认数据
            /// </summary>
            public static readonly CharacterData NORMAL = new CharacterData("chat_girl9", "牧唯", 1030822);
            /// <summary>
            /// 坏心情数据
            /// </summary>
            public static readonly CharacterData BAD = new CharacterData("chat_girl9_b", "牧唯", 1030822);
        }
        /// <summary>
        /// 群演
        /// </summary>
        public static class MassActor
        {
            /// <summary>
            /// 有人物图片的
            /// </summary>
            public static class HaveImage
            {
                /// <summary>
                /// 同学A
                /// </summary>
                public static readonly CharacterData CLASSMATE_A = new CharacterData("chat_longtaojia", "同学A", 1022271);
                /// <summary>
                /// 同学甲
                /// </summary>
                public static readonly CharacterData CLASSMATE_JIA = new CharacterData("chat_longtaojia", "同学甲", 1030824);
                /// <summary>
                /// 同学乙
                /// </summary>
                public static readonly CharacterData CLASSMATE_YI = new CharacterData("chat_longtaoyi", "同学乙", 1030825);
                /// <summary>
                /// 龙套君A
                /// </summary>
                public static readonly CharacterData MASS_ACTOR_A = new CharacterData("chat_longtaoyi", "龙套君甲", 1029877);
                /// <summary>
                /// 龙套君B
                /// </summary>
                public static readonly CharacterData MASS_ACTOR_B = new CharacterData("chat_longtaojia", "龙套君B", 1030447);
            }
            /// <summary>
            /// 没有人物图片的
            /// </summary>
            public static class NotHaveImage
            {
                /// <summary>
                /// 女同学A
                /// </summary>
                public static readonly CharacterData GIRL_CLASSMATE_A = new CharacterData("0", "女同学甲", 1027773);
                /// <summary>
                /// 男同学B
                /// </summary>
                public static readonly CharacterData BOY_CLASSMATE_B = new CharacterData("0", "男同学乙", 1024998);
                /// <summary>
                /// 路人A
                /// </summary>
                public static readonly CharacterData PASSERBY_A = new CharacterData("0", "路人甲", 1024999);
            }
        }
        /// <summary>
        /// 其他角色
        /// </summary>
        public static class Other
        {
            /// <summary>
            /// 奶奶
            /// </summary>
            public static class Grandma
            {
                /// <summary>
                /// 奶奶默认数据
                /// </summary>
                public static readonly CharacterData NORMAL = new CharacterData("chat_grandma", "奶 奶", 1022233);
                /// <summary>
                /// 奶奶好心情数据
                /// </summary>
                public static readonly CharacterData GOOD = new CharacterData("chat_grandma2", "奶 奶", 1022233);
            }
            /// <summary>
            /// 大厨
            /// </summary>
            public static readonly CharacterData COOK = new CharacterData("chat_fengfeng", "大厨", 1030208);
            /// <summary>
            /// 日记
            /// </summary>
            public static readonly CharacterData DIARY = new CharacterData("chat_diary", "日记", 1022767);
            /// <summary>
            /// 秋达
            /// </summary>
            public static readonly CharacterData QIU_DA = new CharacterData("chat_qiuda", "秋达", 1022785);
            /// <summary>
            /// 富坚老贼，游戏里叫“主美”
            /// </summary>
            public static readonly CharacterData Fu_JINA = new CharacterData("chat_fujian", "主美", 1029874);
            /// <summary>
            /// 体育老师
            /// </summary>
            public static readonly CharacterData PF_TEACHER = new CharacterData("chat_tiyulaoshi", "体育老师", 1022698);
            /// <summary>
            /// 收音机，游戏里叫“电台之声”
            /// </summary>
            public static readonly CharacterData RADIO = new CharacterData("chat_radio", "电台之声", 1025379);
            /// <summary>
            /// 宫崎骏
            /// </summary>
            public static readonly CharacterData GONG_QI_JUN = new CharacterData("chat_gongqijun", "龚齐军", 1029875);
            /// <summary>
            /// 刘偏偏妈妈
            /// </summary>
            public static readonly CharacterData LIU_PIAN_PIAN_MOM = new CharacterData("chat_liumama", "刘妈妈", 1023882);
            /// <summary>
            /// 班主任
            /// </summary>
            public static readonly CharacterData TEACHER = new CharacterData("chat_teacher", "班主任", 1011129);
            /// <summary>
            /// 王胜男爷爷
            /// </summary>
            public static readonly CharacterData WANG_SHENG_NAN_GRANDPA = new CharacterData("chat_wangyeye", "王爷爷", 1024237);
        }
    }
}
