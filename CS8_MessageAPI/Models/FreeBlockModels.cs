namespace CS8_MessageAPI.Models;
/// <summary>
/// An Acedemic Block
/// </summary>
/// <param name="blockId">don't care</param>
/// <param name="name">Name of the block</param>
/// <param name="schoolLevel">upper or lower achool</param>
public record Block (
string blockId,
string name,
string schoolLevel);

/// <summary>
/// Time Period that you're free
/// </summary>
/// <param name="block">block information</param>
/// <param name="start">When the Free Block starts</param>
/// <param name="end">When the Free Block ends</param>
public record FreeBlock(
    Block block,
    DateTime start,
    DateTime end);
/// <summary>
/// Collection of FreeBlocks,
/// Response to a request for free-blocks in a given  range of dates
/// </summary>
/// <param name="freeBlocks"></param>
/// <param name="inRange"></param>
public record FreeBlockCollection(
    FreeBlock[] freeBlocks,
    DateOnly[] inRange);
