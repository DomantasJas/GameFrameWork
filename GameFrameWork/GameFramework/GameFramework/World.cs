using System;
using System.Diagnostics;
using GameFramework.Objects;

namespace GameFramework
{
    public class World
    {
        public static World? _instance;
        public World(int? maxX, int? maxY, List<Spawn>? spawnThings = null)
        {
            MaxX = maxX;
            MaxY = maxY;
            SpawnThings = spawnThings ?? new List<Spawn>();
        }
        public static int DefaultMaxX { get; set; } = 100;
        public static int DefaultMaxY { get; set; } = 100;


        public int? MaxX { get; set; } = DefaultMaxX;
        public int? MaxY { get; set; } = DefaultMaxY;

        public List<Spawn> SpawnThings { get; set; }

        public static World CreateInstance(int maxX, int maxY, List<Spawn>? worldObjects)
        {
                if (_instance == null)
                {

                    _instance = new World(maxX, maxY, worldObjects);
                    Logger.GetInstance().Log(TraceEventType.Information, "World is created");
                }
                else
                {
                    throw new InvalidOperationException("Object instance is already created");
                }
            return _instance;
        }
        public static void SetDefaultValues(int maxX, int maxY)
        {
            DefaultMaxX = maxX;
            DefaultMaxY = maxY;
            Logger.GetInstance().Log(TraceEventType.Information, $"Default values for world are set. MaxX: {maxX}, MaxY: {maxY}");
        }
    }

    }
}

