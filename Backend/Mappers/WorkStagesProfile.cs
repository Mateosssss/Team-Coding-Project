using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Mappers
{
    public class WorkStagesProfile:Profile
    {
        public WorkStagesProfile()
        {
            CreateMap<WorkStages,WorkStagesDto>()
                .ForMember(
                    dest=>dest.StageName,
                    opt=>opt.MapFrom(src=>src.StageName)
                )
                .ForMember(
                    dest=>dest.Description,
                    opt=>opt.MapFrom(src=>src.Description)
                )
                .ForMember(
                    dest=>dest.AssignedUserId,
                    opt=>opt.MapFrom(src=>src.AssignedUserId)
                )
                .ForMember(
                    dest=>dest.Deadline,
                    opt=>opt.MapFrom(src=>src.Deadline)
                )
                .ForMember(
                    dest=>dest.Status,
                    opt=>opt.MapFrom(src=>src.Status)
                )
                .ForMember(
                    dest=>dest.CompletedAt,
                    opt=>opt.MapFrom(src=>src.CompletedAt)
                )
                .ForMember(
                    dest=>dest.StartedAt,
                    opt=>opt.MapFrom(src=>src.StartedAt)
                );


            CreateMap<CreateWorkStagesDto,WorkStages>()
                .ForMember(
                    dest=>dest.StageName,
                    opt=>opt.MapFrom(src=>src.StageName)
                )
                .ForMember(
                    dest=>dest.Description,
                    opt=>opt.MapFrom(src=>src.Description)
                )
                .ForMember(
                    dest=>dest.AssignedUserId,
                    opt=>opt.MapFrom(src=>src.AssignedUserId)
                )
                .ForMember(
                    dest=>dest.Deadline,
                    opt=>opt.MapFrom(src=>src.Deadline)
                )
                .ForMember(
                    dest=>dest.Status,
                    opt=>opt.MapFrom(_=>Helpers.WorkStatus.NotStarted)
                )
                .ForMember(
                    dest=>dest.CompletedAt,
                    opt=>opt.MapFrom(_=>(DateTime?)null)
                )
                .ForMember(
                    dest=>dest.StartedAt,
                    opt=>opt.MapFrom(_=>DateTime.Now)
                );
        }
    }
}