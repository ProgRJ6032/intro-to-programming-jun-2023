namespace BusinessClockApi.Models;

public record GetStatusResponse
{
    public bool Open { get; init; }
    public DateTime? OpenAt { get; init; }

}