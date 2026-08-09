namespace MIS.Application.Features.DataCollection.HouseholdInfo.Agricultures;

public class AgricultureCropDTO
{
    public Guid CropId { get; set; }
    public decimal? AreaInHectares { get; set; }
    public decimal? EstimatedYield { get; set; }
    public string? Notes { get; set; }
}   