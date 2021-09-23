using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MtC.Mod.ChineseParents.ChatControlLib
{
    /// <summary>
    /// 背景图片记录，不保证完全，不保证更新
    /// </summary>
    public static class BackgroundGraphs
    {
        /// <summary>
        /// 学校内部的背景图
        /// </summary>
        public static class InSchool
        {
            /// <summary>
            /// 教室
            /// </summary>
            public static class ClassRoom
            {
                /// <summary>
                /// 从窗外俯视小学教室（儿子版小学背景之一）
                /// </summary>
                public const string LITTLE_SCHOOL_CLASS_ROOM_OUT_OF_WINDOW = "home_bg7";
                /// <summary>
                /// 小学教室内部靠窗（儿子版小学背景之一）
                /// </summary>
                public const string LITTLE_SCHOOL_CLASS_ROOM = "home_bg7_G2";
                /// <summary>
                /// 女儿版初中教室内（黄昏那个）
                /// </summary>
                public const string GIRL_MIDDLE_SCHOOL_CLASS_ROOM = "girl_homebg10";
                /// <summary>
                /// 广角镜拍摄的挂着国旗的教室（应该是某个背景，但没见过）
                /// </summary>
                public const string SCHOOL_CLASS_ROOM_WITH_FLAG = "home_bg10";
                /// <summary>
                /// 女儿版小学教室内（摄像机对着窗户，女儿后面一个男同学趴头睡那个）
                /// </summary>
                public const string GIRL_LITTLE_SCHOOL_CLASS_ROOM = "girl_homebg7";
            }
            /// <summary>
            /// 走廊和楼梯
            /// </summary>
            public static class CorridorAndStair
            {
                /// <summary>
                /// 初中学校走廊（有“初一2班”的门牌）
                /// </summary>
                public const string MIDDLE_SCHOOL_CORRIDOR = "comedy_middleschool";
                /// <summary>
                /// 女儿版初中走廊（有“初二(5)班”字样
                /// </summary>
                public const string GIRL_MIDDLE_SCHOOL_CORRIDOR = "girl_homebg13";
                /// <summary>
                /// 学校楼梯口（左侧是关着的门，右边是上下楼梯）
                /// </summary>
                public const string SCHOOL_STAIR = "comedy_schoolrest";
                /// <summary>
                /// 学校通往天台的楼梯（有天台门的楼梯转交）
                /// </summary>
                public const string SCHOOL_ROOFTOP_STAIR = "comedy_schoolloving";
            }
            /// <summary>
            /// 操场
            /// </summary>
            public static class Playground
            {
                /// <summary>
                /// 操场旁边（儿子版初中背景之一）
                /// </summary>
                public const string PLAYGROUND_SIDE_2 = "home_bg13";
                /// <summary>
                /// 学校操场旁边（苏芳允线最后出现过的操场旁边背景）
                /// </summary>
                public const string PLAYGROUND_SIDE = "comdy_playground";
                /// <summary>
                /// 体育场旁边停自行车的地方（儿子版初中背景之一）
                /// </summary>
                public const string PLAYGROUND_SIDE_3_BICYCLE = "home_bg10_G2";
            }
            /// <summary>
            /// 办公室
            /// </summary>
            public static class Office
            {
                /// <summary>
                /// 科学老师办公室（有大量的模型、黑板上写了公式、柜子里是很多文件和书）
                /// </summary>
                public const string SCIENCE_TEACHER_OFFICE = "end_science";
            }
            /// <summary>
            /// 建筑物内
            /// </summary>
            public static class InBuilding
            {
                /// <summary>
                /// 学校体育馆（篮球）（体育线的那个学校篮球馆）
                /// </summary>
                public const string SCHOOL_GYMNASIUNM = "end_basketball";
                /// <summary>
                /// 图书馆（艺术线第一个事件的图书馆）
                /// </summary>
                public const string LIBRARY = "comedy_library";
            }
            /// <summary>
            /// 宿舍
            /// </summary>
            public static class Dormitory
            {
                /// <summary>
                /// 男生宿舍（儿子版背景之一）
                /// </summary>
                public const string BOY_DORMITORY = "home_bg13_G2";
            }
        }
        /// <summary>
        /// 室外的背景图
        /// </summary>
        public static class Outdoor
        {
            /// <summary>
            /// 夜晚街道（刘偏偏第一个事件的碰面的位置）
            /// </summary>
            public const string NIGHT_STREET = "end_nighttown";
            /// <summary>
            /// 天桥红绿灯白天（升小学对话的背景）
            /// </summary>
            public const string FOOTBRIDGE_TRAFFIC_LIGHTS = "comedy_littleschool";
            /// <summary>
            /// 金融产业区（金牛大雕塑，理财线结尾、席梦来线中途出现过）
            /// </summary>
            public const string FINANCE = "end_finance";
            /// <summary>
            /// 俱乐部街道（厨艺线第一个事件的背景）
            /// </summary>
            public const string CLUB_STREET = "comedy_club";
            /// <summary>
            /// 体育中心/大型露天体育馆 门口（夜晚，左侧是河，右边是体育馆）
            /// </summary>
            public const string SPORTS_CENTER = "comedy_arena";
            /// <summary>
            /// 地下商业街
            /// </summary>
            public const string UNDERGROUND_MALL = "comedy_mall";
            /// <summary>
            /// 夜晚的野外（席梦来线最后，能看到城市夜景的野外）
            /// </summary>
            public const string WILD_NIGHT = "comedy_skynight";
            /// <summary>
            /// 高中门口
            /// </summary>
            public const string HIGHT_SCHOOL = "comedy_highschool";
        }
        /// <summary>
        /// 室内的背景图
        /// </summary>
        public static class Indoor
        {
            /// <summary>
            /// 家里的背景图
            /// </summary>
            public static class Home
            {
                /// <summary>
                /// 个人电脑房（编程线开发游戏时候的背景）
                /// </summary>
                public const string CMOPUTER_ROOM = "end_freelancer";
                /// <summary>
                /// 家庭生日会场
                /// </summary>
                public const string BIRTHDAY = "comedy_birthday";
                /// <summary>
                /// 女儿版高中卧室
                /// </summary>
                public const string GIRL_HIGH_SCHOOL_BEDROOM = "girl_homebg16";
            }
            /// <summary>
            /// 幼儿园背景
            /// </summary>
            public static class Kindergarten
            {
                /// <summary>
                /// 幼儿园（幼儿园背景之一）
                /// </summary>
                public const string KIDERGARTEN = "home_bg3_G2";
                /// <summary>
                /// 幼儿园（幼儿园背景之一）
                /// </summary>
                public const string KIDERGARTEN_2 = "home_bg3";
                /// <summary>
                /// 幼儿园（幼儿园背景之一）
                /// </summary>
                public const string KIDERGARTEN_3 = "girl_homebg3";
            }
            /// <summary>
            /// 综艺节目或演唱会
            /// </summary>
            public static class VarietyShow
            {
                /// <summary>
                /// 演唱会现场
                /// </summary>
                public const string LIVE = "end_showbar";
                /// <summary>
                /// 好声音现场（类似中国好声音的那种评委转身的节目现场，有四个椅子）
                /// </summary>
                public const string NICE_VOICE = "end_nicevoice";
                /// <summary>
                /// 走秀宣传海报
                /// </summary>
                public const string BIG_SHOW = "end_bigshow";
            }
            /// <summary>
            /// 比较常规的背景
            /// </summary>
            public static class Normal
            {
                /// <summary>
                /// 艺术馆
                /// </summary>
                public const string ART_GALLERY = "comedy_art";
                /// <summary>
                /// 工厂（有机械臂那个工厂流水线，席梦来线出现过）
                /// </summary>
                public const string FACTORY = "end_factory";
                /// <summary>
                /// 办公室（一排排电脑的办公室，如果当个白领结局就是这个背景）
                /// </summary>
                public const string OFFICE = "end_office";
                /// <summary>
                /// 化妆室（拍的是镜子）
                /// </summary>
                public const string DRESSING_ROOM = "comedy_huazhuang";
                /// <summary>
                /// 日式道场（忍者线那个道场）
                /// </summary>
                public const string DOJO = "end_ninja";
                /// <summary>
                /// 高层单人办公室（金融线的，豪华办公室）
                /// </summary>
                public const string HIGH_LEVEL_OFFICE = "end_highoffice";
                /// <summary>
                /// 证券交易所（金融线出现过）
                /// </summary>
                public const string STOCK_EXCHANGE = "comedy_market";
                /// <summary>
                /// 厨房（美食线的那个餐厅厨房）
                /// </summary>
                public const string KITCHEN = "comedy_kitchen";
            }
        }
        /// <summary>
        /// 在交通工具内的背景图
        /// </summary>
        public static class Vehicle
        {
            /// <summary>
            /// 地铁内
            /// </summary>
            public const string METRO = "end_underground";
        }
        /// <summary>
        /// 特殊背景图
        /// </summary>
        public static class Especial
        {
            /// <summary>
            /// 纯白
            /// </summary>
            public const string WHITE = "comedy_birthdayWhite";
            /// <summary>
            /// 纯黑
            /// </summary>
            public const string BLACK = "comedy_birthdayBlack";
            /// <summary>
            /// 结局时录取通知书的背景桌子
            /// </summary>
            public const string DESK = "end_bg";
            /// <summary>
            /// 心理阴影漫后的坏结局背景
            /// </summary>
            public const string BAD_END = "bad_end_bg";
            /// <summary>
            /// 上下黑条中间灰色的背景（相亲进度条的背景）
            /// </summary>
            public const string BLACK_GRAY_BLACK = "dating_bg";
            /// <summary>
            /// 开场动画的睁眼背景（朦胧的光晕）
            /// </summary>
            public const string OPEN_EYE = "transition_birth_bg";
        }
    }
}
