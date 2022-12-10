
IHouseBuilder wood_builder = new WoodHouseBuilder();
House wood_house = wood_builder.BuildWindows(4).BuildWalls(4).BuildRoof().BuildDoors(3).BuildGarage().Build();
Console.WriteLine(wood_house);

wood_builder.Reset();
House simple_house = wood_builder.Build();
var Director = new Director(wood_builder);
Director.BuildHouseWithGarden();
Console.WriteLine(simple_house);









