﻿
class BrickHouseBuilder : IHouseBuilder
{
    public House House { get; set; } = new House { Name = "Brick House" };


    public House Build()
    {
        return House;
    }

    public IHouseBuilder BuildDoors(int count)
    {
        House.Doors += count;
        return this;
    }

    public IHouseBuilder BuildGarage()
    {
        House.HasGarage = true;
        return this;
    }

    public IHouseBuilder BuildGarden()
    {
        House.HasGarden = true;
        return this;
    }

    public IHouseBuilder BuildPool()
    {
        House.HasPool = true;
        return this;
    }

    public IHouseBuilder BuildRoof()
    {
        House.HasRoof = true;
        return this;
    }

    public IHouseBuilder BuildWalls(int count)
    {
        House.Walls += count;
        return this;
    }

    public IHouseBuilder BuildWindows(int count)
    {
        House.Windows += count;
        return this;
    }

    public void Reset()
    {
        House = new House { Name = "Brick House" };
    }
}
