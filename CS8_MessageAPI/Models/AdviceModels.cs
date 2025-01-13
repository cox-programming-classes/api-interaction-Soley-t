namespace CS8_MessageAPI.Models;

public record Slip (
    int id,
    string advice);
    
public record SlipWrapper (Slip slip);