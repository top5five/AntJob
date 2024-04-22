﻿namespace AntJob.Data;

/// <summary>任务模型</summary>
public partial class TaskModel : ITask
{
    #region 属性
    /// <summary>编号</summary>
    public Int32 ID { get; set; }

    /// <summary>数据时间。定时调度的执行时间点，或者数据调度的开始时间</summary>
    public DateTime Time { get; set; }

    /// <summary>开始。大于等于</summary>
    public DateTime Start { get; set; }

    /// <summary>结束。小于，不等于</summary>
    public DateTime End { get; set; }

    /// <summary>批大小</summary>
    public Int32 BatchSize { get; set; }

    /// <summary>数据</summary>
    public String Data { get; set; }
    #endregion
}