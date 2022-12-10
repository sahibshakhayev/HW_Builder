using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Director
    {
          private IHouseBuilder houseBuilder;
    public Director(IHouseBuilder houseBuilder)
    {
        this.houseBuilder = houseBuilder;
    }

    public void BuildSimpleHouse(int walls = 4, int windows = 2, int doors = 1 )
    {
        houseBuilder.BuildWalls(walls);
        houseBuilder.BuildWindows(windows);
        houseBuilder.BuildDoors(doors);
        houseBuilder.BuildRoof();
    }

    public void BuildHouseWithPool(int walls = 4, int windows = 2, int doors = 1)
    {
        houseBuilder.BuildWalls(walls);
        houseBuilder.BuildWindows(windows);
        houseBuilder.BuildDoors(doors);
        houseBuilder.BuildRoof();
        houseBuilder.BuildPool();
    }

    public void BuildHouseWithGarden(int walls = 4, int windows = 2, int doors = 1)
    {
        houseBuilder.BuildWalls(walls);
        houseBuilder.BuildWindows(windows);
        houseBuilder.BuildDoors(doors);
        houseBuilder.BuildRoof();
        houseBuilder.BuildGarden();
    }

    public void BuildHouseWithGarage(int walls = 4, int windows = 2, int doors = 1)
    {
        houseBuilder.BuildWalls(walls);
        houseBuilder.BuildWindows(windows);
        houseBuilder.BuildDoors(doors);
        houseBuilder.BuildRoof();
        houseBuilder.BuildGarage();
    }



}

