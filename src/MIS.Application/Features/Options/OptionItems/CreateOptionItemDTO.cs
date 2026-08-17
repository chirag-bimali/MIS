namespace MIS.Application.Features.Options.OptionItems;


public class CreateOptionItemDTO
{
  public Guid OptionListId { get; set; }
  public string LabelEn { get; set; } = null!;

  public string LabelNe { get; set; } = null!;
  public Guid? ChildOptionListId { get; set; }

  public Dictionary<string, object>? Extra { get; set; }

}