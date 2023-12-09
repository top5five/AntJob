﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using NewLife;
using NewLife.Data;
using XCode;
using XCode.Cache;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace AntJob.Data.Entity;

/// <summary>作业错误</summary>
[Serializable]
[DataObject]
[Description("作业错误")]
[BindIndex("IX_JobError_AppID_ID", false, "AppID,ID")]
[BindIndex("IX_JobError_JobID_ID", false, "JobID,ID")]
[BindTable("JobError", Description = "作业错误", ConnName = "Ant", DbType = DatabaseType.None)]
public partial class JobError
{
    #region 属性
    private Int32 _ID;
    /// <summary>编号</summary>
    [DisplayName("编号")]
    [Description("编号")]
    [DataObjectField(true, true, false, 0)]
    [BindColumn("ID", "编号", "")]
    public Int32 ID { get => _ID; set { if (OnPropertyChanging("ID", value)) { _ID = value; OnPropertyChanged("ID"); } } }

    private Int32 _AppID;
    /// <summary>应用</summary>
    [DisplayName("应用")]
    [Description("应用")]
    [DataObjectField(false, false, false, 0)]
    [BindColumn("AppID", "应用", "")]
    public Int32 AppID { get => _AppID; set { if (OnPropertyChanging("AppID", value)) { _AppID = value; OnPropertyChanged("AppID"); } } }

    private Int32 _JobID;
    /// <summary>作业</summary>
    [DisplayName("作业")]
    [Description("作业")]
    [DataObjectField(false, false, false, 0)]
    [BindColumn("JobID", "作业", "")]
    public Int32 JobID { get => _JobID; set { if (OnPropertyChanging("JobID", value)) { _JobID = value; OnPropertyChanged("JobID"); } } }

    private Int32 _TaskID;
    /// <summary>作业项</summary>
    [DisplayName("作业项")]
    [Description("作业项")]
    [DataObjectField(false, false, false, 0)]
    [BindColumn("TaskID", "作业项", "")]
    public Int32 TaskID { get => _TaskID; set { if (OnPropertyChanging("TaskID", value)) { _TaskID = value; OnPropertyChanged("TaskID"); } } }

    private String _Client;
    /// <summary>客户端。IP加进程</summary>
    [DisplayName("客户端")]
    [Description("客户端。IP加进程")]
    [DataObjectField(false, false, true, 50)]
    [BindColumn("Client", "客户端。IP加进程", "")]
    public String Client { get => _Client; set { if (OnPropertyChanging("Client", value)) { _Client = value; OnPropertyChanged("Client"); } } }

    private DateTime _Start;
    /// <summary>开始。大于等于</summary>
    [DisplayName("开始")]
    [Description("开始。大于等于")]
    [DataObjectField(false, false, true, 0)]
    [BindColumn("Start", "开始。大于等于", "")]
    public DateTime Start { get => _Start; set { if (OnPropertyChanging("Start", value)) { _Start = value; OnPropertyChanged("Start"); } } }

    private DateTime _End;
    /// <summary>结束。小于，不等于</summary>
    [DisplayName("结束")]
    [Description("结束。小于，不等于")]
    [DataObjectField(false, false, true, 0)]
    [BindColumn("End", "结束。小于，不等于", "")]
    public DateTime End { get => _End; set { if (OnPropertyChanging("End", value)) { _End = value; OnPropertyChanged("End"); } } }

    private String _Data;
    /// <summary>数据</summary>
    [DisplayName("数据")]
    [Description("数据")]
    [DataObjectField(false, false, true, 2000)]
    [BindColumn("Data", "数据", "")]
    public String Data { get => _Data; set { if (OnPropertyChanging("Data", value)) { _Data = value; OnPropertyChanged("Data"); } } }

    private String _Server;
    /// <summary>服务器</summary>
    [DisplayName("服务器")]
    [Description("服务器")]
    [DataObjectField(false, false, true, 50)]
    [BindColumn("Server", "服务器", "")]
    public String Server { get => _Server; set { if (OnPropertyChanging("Server", value)) { _Server = value; OnPropertyChanged("Server"); } } }

    private Int32 _ProcessID;
    /// <summary>进程</summary>
    [DisplayName("进程")]
    [Description("进程")]
    [DataObjectField(false, false, false, 0)]
    [BindColumn("ProcessID", "进程", "")]
    public Int32 ProcessID { get => _ProcessID; set { if (OnPropertyChanging("ProcessID", value)) { _ProcessID = value; OnPropertyChanged("ProcessID"); } } }

    private String _Message;
    /// <summary>内容</summary>
    [DisplayName("内容")]
    [Description("内容")]
    [DataObjectField(false, false, true, 2000)]
    [BindColumn("Message", "内容", "")]
    public String Message { get => _Message; set { if (OnPropertyChanging("Message", value)) { _Message = value; OnPropertyChanged("Message"); } } }

    private DateTime _CreateTime;
    /// <summary>创建时间</summary>
    [DisplayName("创建时间")]
    [Description("创建时间")]
    [DataObjectField(false, false, true, 0)]
    [BindColumn("CreateTime", "创建时间", "")]
    public DateTime CreateTime { get => _CreateTime; set { if (OnPropertyChanging("CreateTime", value)) { _CreateTime = value; OnPropertyChanged("CreateTime"); } } }

    private DateTime _UpdateTime;
    /// <summary>更新时间</summary>
    [DisplayName("更新时间")]
    [Description("更新时间")]
    [DataObjectField(false, false, true, 0)]
    [BindColumn("UpdateTime", "更新时间", "")]
    public DateTime UpdateTime { get => _UpdateTime; set { if (OnPropertyChanging("UpdateTime", value)) { _UpdateTime = value; OnPropertyChanged("UpdateTime"); } } }
    #endregion

    #region 获取/设置 字段值
    /// <summary>获取/设置 字段值</summary>
    /// <param name="name">字段名</param>
    /// <returns></returns>
    public override Object this[String name]
    {
        get => name switch
        {
            "ID" => _ID,
            "AppID" => _AppID,
            "JobID" => _JobID,
            "TaskID" => _TaskID,
            "Client" => _Client,
            "Start" => _Start,
            "End" => _End,
            "Data" => _Data,
            "Server" => _Server,
            "ProcessID" => _ProcessID,
            "Message" => _Message,
            "CreateTime" => _CreateTime,
            "UpdateTime" => _UpdateTime,
            _ => base[name]
        };
        set
        {
            switch (name)
            {
                case "ID": _ID = value.ToInt(); break;
                case "AppID": _AppID = value.ToInt(); break;
                case "JobID": _JobID = value.ToInt(); break;
                case "TaskID": _TaskID = value.ToInt(); break;
                case "Client": _Client = Convert.ToString(value); break;
                case "Start": _Start = value.ToDateTime(); break;
                case "End": _End = value.ToDateTime(); break;
                case "Data": _Data = Convert.ToString(value); break;
                case "Server": _Server = Convert.ToString(value); break;
                case "ProcessID": _ProcessID = value.ToInt(); break;
                case "Message": _Message = Convert.ToString(value); break;
                case "CreateTime": _CreateTime = value.ToDateTime(); break;
                case "UpdateTime": _UpdateTime = value.ToDateTime(); break;
                default: base[name] = value; break;
            }
        }
    }
    #endregion

    #region 关联映射
    #endregion

    #region 字段名
    /// <summary>取得作业错误字段信息的快捷方式</summary>
    public partial class _
    {
        /// <summary>编号</summary>
        public static readonly Field ID = FindByName("ID");

        /// <summary>应用</summary>
        public static readonly Field AppID = FindByName("AppID");

        /// <summary>作业</summary>
        public static readonly Field JobID = FindByName("JobID");

        /// <summary>作业项</summary>
        public static readonly Field TaskID = FindByName("TaskID");

        /// <summary>客户端。IP加进程</summary>
        public static readonly Field Client = FindByName("Client");

        /// <summary>开始。大于等于</summary>
        public static readonly Field Start = FindByName("Start");

        /// <summary>结束。小于，不等于</summary>
        public static readonly Field End = FindByName("End");

        /// <summary>数据</summary>
        public static readonly Field Data = FindByName("Data");

        /// <summary>服务器</summary>
        public static readonly Field Server = FindByName("Server");

        /// <summary>进程</summary>
        public static readonly Field ProcessID = FindByName("ProcessID");

        /// <summary>内容</summary>
        public static readonly Field Message = FindByName("Message");

        /// <summary>创建时间</summary>
        public static readonly Field CreateTime = FindByName("CreateTime");

        /// <summary>更新时间</summary>
        public static readonly Field UpdateTime = FindByName("UpdateTime");

        static Field FindByName(String name) => Meta.Table.FindByName(name);
    }

    /// <summary>取得作业错误字段名称的快捷方式</summary>
    public partial class __
    {
        /// <summary>编号</summary>
        public const String ID = "ID";

        /// <summary>应用</summary>
        public const String AppID = "AppID";

        /// <summary>作业</summary>
        public const String JobID = "JobID";

        /// <summary>作业项</summary>
        public const String TaskID = "TaskID";

        /// <summary>客户端。IP加进程</summary>
        public const String Client = "Client";

        /// <summary>开始。大于等于</summary>
        public const String Start = "Start";

        /// <summary>结束。小于，不等于</summary>
        public const String End = "End";

        /// <summary>数据</summary>
        public const String Data = "Data";

        /// <summary>服务器</summary>
        public const String Server = "Server";

        /// <summary>进程</summary>
        public const String ProcessID = "ProcessID";

        /// <summary>内容</summary>
        public const String Message = "Message";

        /// <summary>创建时间</summary>
        public const String CreateTime = "CreateTime";

        /// <summary>更新时间</summary>
        public const String UpdateTime = "UpdateTime";
    }
    #endregion
}
