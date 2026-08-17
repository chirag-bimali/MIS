namespace MIS.Application.Features.Options.OptionItems;

public class UpdateOptionItemDTO
{
  public string LabelEn { get; set; } = null!;

  public string LabelNe { get; set; } = null!;
  public Guid? ChildOptionListId { get; set; }

  public Dictionary<string, object>? Extra { get; set; }

}