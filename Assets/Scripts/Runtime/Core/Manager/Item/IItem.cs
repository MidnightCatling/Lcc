﻿namespace LccModel
{
    public interface IItem
    {
        ItemType Type
        {
            get; set;
        }
        AObjectBase AObjectBase
        {
            get; set;
        }
    }
}