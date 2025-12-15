using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.DTOs;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Mappers
{
    public class ProjectProfile:Profile
    {
        public ProjectProfile()
        {
            CreateMap<Project,ProjectDto>()
                .ForMember(
                    dest=>dest.Title,
                    opt=>opt.MapFrom(src=>src.Title)
                ).ForMember(
                    dest=>dest.Description,
                    opt=>opt.MapFrom(src=>src.Description)
                ).ForMember(
                    dest=>dest.ContactPhone,
                    opt=>opt.MapFrom(src=>src.ContactPhone)
                ).ForMember(
                    dest=>dest.ContactEmail,
                    opt=>opt.MapFrom(src=>src.ContactEmail)
                ).ForMember(
                    dest=>dest.Status,
                    opt=>opt.MapFrom(src=>src.Status)
                ).ForMember(
                    dest=>dest.ManagerId,
                    opt=>opt.MapFrom(src=>src.ManagerId)
                ).ForMember(
                    dest=>dest.InvestorId,
                    opt=>opt.MapFrom(src=>src.InvestorId)
                ).ForMember(
                    dest=>dest.LocationId,
                    opt=>opt.MapFrom(src=>src.LocationId)
                );

                CreateMap<CreateProjectDto,Project>()
                .ForMember(
                    dest=>dest.Title,
                    opt=>opt.MapFrom(src=>src.Title)
                ).ForMember(
                    dest=>dest.Description,
                    opt=>opt.MapFrom(src=>src.Description)
                ).ForMember(
                    dest=>dest.ContactPhone,
                    opt=>opt.MapFrom(src=>src.ContactPhone)
                ).ForMember(
                    dest=>dest.ContactEmail,
                    opt=>opt.MapFrom(src=>src.ContactEmail)
                ).ForMember(
                    dest=>dest.ManagerId,
                    opt=>opt.MapFrom(src=>src.ManagerId)
                ).ForMember(
                    dest=>dest.InvestorId,
                    opt=>opt.MapFrom(src=>src.InvestorId)
                ).ForMember(
                    dest=>dest.LocationId,
                    opt=>opt.MapFrom(src=>src.LocationId)
                );
        }
    }
}