using Domain.Models;
using System.Collections.Generic;

public class LeaderBoardAdapter 
{
    public static LeaderBoardItem GetDomainItem(LeaderBoarItemDto dto)
    {
        return new LeaderBoardItem(dto.nickname, dto.maxScore);
    }
    public static LeaderBoarItemDto GetDtoItem(LeaderBoardItem item)
    {
        return new LeaderBoarItemDto()
        {
            nickname = item.GetName(),
            maxScore = item.GetScore()
        };
    }

    public static List<LeaderBoardItem> GetDomainItems(List<LeaderBoarItemDto> dtos)
    {
        List<LeaderBoardItem> items = new List<LeaderBoardItem>();
        foreach (var dto in dtos)
        {
            items.Add(GetDomainItem(dto));
        }
        return items;
    }
    public static List<LeaderBoarItemDto> GetDtoItems(List<LeaderBoardItem> items)
    {
        List<LeaderBoarItemDto> dtos = new List<LeaderBoarItemDto>();
        foreach (var item in items)
        {
            dtos.Add(GetDtoItem(item));
        }
        return dtos;
    }
}
