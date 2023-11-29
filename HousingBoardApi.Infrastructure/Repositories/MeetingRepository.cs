using HousingBoardApi.Application.Commands.Meeting.Create;
using HousingBoardApi.Application.Commands.Meeting.Delete;
using HousingBoardApi.Application.Queries.Meeting.Dto;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.ComponentModel.DataAnnotations;

namespace HousingBoardApi.Infrastructure.Repositories;

public class MeetingRepository : IMeetingRepository
{
    private readonly HousingBoardDbContext _db;

    public MeetingRepository(HousingBoardDbContext db)
    {
        _db = db;
    }

    MeetingEntity IMeetingRepository.Load(Guid id)
    {
        //var dbEntity = _db.MeetingEntities.AsNoTracking().FirstOrDefault(x => x.Id == id);
        var model = _db.MeetingEntities.FirstOrDefault(x => x.Id == id);

        //conditional operator : at vælge mellem to værdier eller udføre to forskellige handlinger afhængigt af en betingelse
        return model == null ? throw new Exception("Ingen meeting fundet i databasen") : model;
    }

    void IMeetingRepository.Update(MeetingEntity model)
    {
        _db.Update(model);
        _db.SaveChanges();
    }

    public MeetingGetQueryResultDto Get(Guid id)
    {
        //var model = _db.MeetingEntities.AsNoTracking().IgnoreQueryFilters().FirstOrDefault(x => x.Id == id);
        var model = _db.MeetingEntities.AsNoTracking().FirstOrDefault(x => x.Id == id);


        if (model == null) throw new Exception("Ingen meeting fundet i databasen");

        return new MeetingGetQueryResultDto
        {
            Id = model.Id,
            RowVersion = model.RowVersion,
            IsDeleted = model.IsDeleted,
            Title = model.Title,
            Description = model.Description,
            MeetingTime = model.MeetingTime,
            AddressLocation = model.AddressLocation
        };
    }

    public IEnumerable<MeetingGetAllQueryResultDto> GetAll()
    {
        foreach (var model in _db.MeetingEntities.AsNoTracking().ToList())
        {
            yield return new MeetingGetAllQueryResultDto
            {
                Id = model.Id,
                RowVersion = model.RowVersion,
                IsDeleted = model.IsDeleted,
                Title = model.Title,
                Description = model.Description,
                MeetingTime = model.MeetingTime,
                AddressLocation = model.AddressLocation
            };
        }
    }

    void IMeetingRepository.Delete(DeleteMeetingCommand request)
    {
        _db.Remove(_db.MeetingEntities.AsNoTracking().FirstOrDefault(x => x.Id == request.Id));
        _db.SaveChanges();
    }

    void IMeetingRepository.Add(CreateMeetingCommand request)
    {

        var meetingType = _db.MeetingTypeEntities.FirstOrDefault(x => x.Id == request.MeetingTypeId);
        var boardmember = _db.BoardMemberEntities.FirstOrDefault(x => x.Id == request.MeetingOwnerId);

        var model = new MeetingEntity
        {
            Title = request.Title,
            Description = request.Description,
            AddressLocation = request.AddressLocation,
            MeetingOwner = boardmember,
            MeetingType = meetingType,
            CreatedMeetingDate = DateTime.Now,
            MeetingTime = request.MeetingTime,
            IsDeleted = false,
            DeletedAt = null

        };

        _db.Add(model);
        _db.SaveChanges();
    }
}
