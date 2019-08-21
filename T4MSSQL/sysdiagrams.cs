    //----------sysdiagrams开始----------
    
    using System;
    namespace MyProject.Entities 
    {
        /// <summary>
        /// [table]：sysdiagrams 
        /// </summary>
        [Serializable()]
        public class sysdiagrams
        {    
                         
            /// <summary>
            /// String:
            /// </summary>                       
            public String name {get;set;}   
                         
            /// <summary>
            /// Int32:
            /// </summary>                       
            public Int32 principal_id {get;set;}   
                         
            /// <summary>
            /// Int32:
            /// </summary>                       
            public Int32 diagram_id {get;set;}   
                         
            /// <summary>
            /// Int32:
            /// </summary>                       
            public Int32 version {get;set;}   
                         
            /// <summary>
            /// Byte[]:
            /// </summary>                       
            public Byte[] definition {get;set;}   
               
        }    
     }

    //----------sysdiagrams结束----------

    