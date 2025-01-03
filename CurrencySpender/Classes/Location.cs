namespace CurrencySpender.Classes
{
    public class Location
    {
        public uint Id { get; set; }
        public uint MapId { get; set; }
        public uint TerritoryId { get; set; }
        public (float, float) Postion { get; set; }

        public required String Name { get; set; }

        public static Location retrieve(uint id) => locations.First(loc => loc.Id == id);

        public static List<Location> locations = [
            new Location { Id = 1, MapId = 11, TerritoryId = 128, Postion = (13.1f, 12.7f), Name = "Storm Quartermaster" },
            new Location { Id = 2, MapId = 2, TerritoryId = 132, Postion = (9.8f, 11.0f), Name = "Serpent Quartermaster" },
            new Location { Id = 3, MapId = 13, TerritoryId = 130, Postion = (8.3f, 9.0f), Name = "Flame Quartermaster" },
            new Location { Id = 4, MapId = 257, TerritoryId = 478, Postion = (5.7f, 5.3f), Name = "Hismena" },
            new Location { Id = 5, MapId = 366, TerritoryId = 635, Postion = (13.9f, 11.6f), Name = "Enna" },
            new Location { Id = 6, MapId = 51, TerritoryId = 250, Postion = (4.5f, 6.0f), Name = "Mark Quartermaster" },
            new Location { Id = 7, MapId = 856, TerritoryId = 1186, Postion = (8.6f, 13.5f), Name = "Zircon" },
        ];
    }
}
