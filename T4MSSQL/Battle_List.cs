    //----------Battle_List开始----------
    
    using System;
    namespace MyProject.Entities 
    {
        /// <summary>
        /// [table]：Battle_List 
        /// </summary>
        [Serializable()]
        public class Battle_List
        {    
                         
            /// <summary>
            /// Int32:
            /// </summary>                       
            public Int32 Id {get;set;}   
                         
            /// <summary>
            /// Int32:
            /// </summary>                       
            public Int32 championId {get;set;}   
                         
            /// <summary>
            /// String:
            /// </summary>                       
            public String item0 {get;set;}   
                         
            /// <summary>
            /// String:
            /// </summary>                       
            public String item1 {get;set;}   
                         
            /// <summary>
            /// String:
            /// </summary>                       
            public String item2 {get;set;}   
                         
            /// <summary>
            /// String:
            /// </summary>                       
            public String item3 {get;set;}   
                         
            /// <summary>
            /// String:
            /// </summary>                       
            public String item4 {get;set;}   
                         
            /// <summary>
            /// String:
            /// </summary>                       
            public String item5 {get;set;}   
                         
            /// <summary>
            /// String:
            /// </summary>                       
            public String item6 {get;set;}   
                         
            /// <summary>
            /// Int32:
            /// </summary>                       
            public Int32 kills {get;set;}   
                         
            /// <summary>
            /// Int32:
            /// </summary>                       
            public Int32 deathss {get;set;}   
                         
            /// <summary>
            /// Int32:辅助次数
            /// </summary>                       
            public Int32 assist {get;set;}   
                         
            /// <summary>
            /// String:对局ID
            /// </summary>                       
            public String gameId {get;set;}   
                         
            /// <summary>
            /// DateTime:
            /// </summary>                       
            public DateTime gameCreationTime {get;set;}   
                         
            /// <summary>
            /// String:胜利Win或失败Fail
            /// </summary>                       
            public String win {get;set;}   
                         
            /// <summary>
            /// Double:
            /// </summary>                       
            public Double KDA {get;set;}   
                         
            /// <summary>
            /// Int32:0：正常，1：重开局
            /// </summary>                       
            public Int32 gameEndedInEarlySurrender {get;set;}   
               
        }    
     }

    //----------Battle_List结束----------

    