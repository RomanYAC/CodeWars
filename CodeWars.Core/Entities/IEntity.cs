﻿namespace CodeWars.Core.Entities
{
    public interface IEntity<T> where T : struct
    {
        T Id { get; set; }
    }
}
