namespace MIS.Application.Features.Options.OptionItems;

public static class OptionItemMapper
{
    public static OptionItemDTO ToOptionItemDTO(this OptionItem optionItem)
    {
        return new OptionItemDTO
        {
            Id = optionItem.Id,
            OptionListId = optionItem.OptionListId,
            ChildOptionListId = optionItem.ChildOptionListId,
            Extra = optionItem.Extra,
            LabelEn = optionItem.LabelEn,
            LabelNe = optionItem.LabelNe

        };
    }
}