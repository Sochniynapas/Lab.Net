namespace Lab.Net.Models
{
    public enum GarAddressLevel
    {
        Region, 
        AdministrativeArea, 
        MunicipalArea, 
        RuralUrbanSettlement, 
        City, 
        Locality, 
        ElementOfPlanningStructure, 
        ElementOfRoadNetwork, 
        Land, 
        Building, 
        Room, 
        RoomInRooms, 
        AutonomousRegionLevel, 
        IntracityLevel, 
        AdditionalTerritoriesLevel, 
        LevelOfObjectsInAdditionalTerritories, 
        CarPlace
    }
    public class SearchAddressModel
    {
        public int ObjectId { get; set; }
        public Guid ObjectGuide { get; set; }
        public string Text { get; set; }
        public GarAddressLevel ObjectLevel { get; set; }
        public string ObjectLevelText { get; set; }




    }
}
