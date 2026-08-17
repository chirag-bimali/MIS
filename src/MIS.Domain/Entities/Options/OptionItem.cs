using MIS.Domain.Common.Premitives;

public class OptionItem : BaseEntity
{
  public Guid OptionListId { get; set; }

  public string LabelEn { get; set; } = null!;

  public string LabelNe { get; set; } = null!;

  public Dictionary<string, object>? Extra { get; set; }
  public Guid? ChildOptionListId { get; set; } // FK to OptionList for child options, if any

  //Navigation property
  public OptionList OptionList { get; set; } = null!;
  public OptionList? ChildOptionList { get; set; }

}