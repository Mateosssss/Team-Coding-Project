using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ProjektZespołówka.DTOs.Create;
using ProjektZespołówka.Models;

namespace ProjektZespołówka.Mappers
{
    public class RoomProfile:Profile
    {
        public RoomProfile()
        {
            CreateMap<Room,DTOs.RoomDto>()
                .ForMember(
                    dest=>dest.LevelId,
                    opt=>opt.MapFrom(src=>src.LevelId)
                )
                .ForMember(
                    dest=>dest.Number,
                    opt=>opt.MapFrom(src=>src.Number)
                )
                .ForMember(
                    dest=>dest.TechnicalName,
                    opt=>opt.MapFrom(src=>src.TechnicalName)
                )
                .ForMember(
                    dest=>dest.OutletCount,
                    opt=>opt.MapFrom(src=>src.OutletCount)
                )
                .ForMember(
                    dest=>dest.CoordinatesOnPlan,
                    opt=>opt.MapFrom(src=>src.CoordinatesOnPlan)
                )
                .ForMember(
                    dest=>dest.Description,
                    opt=>opt.MapFrom(src=>src.Description)
                );

            CreateMap<CreateRoomDto,Room>()
                .ForMember(
                    dest=>dest.LevelId,
                    opt=>opt.MapFrom(src=>src.LevelId)
                ).ForMember(
                    dest=>dest.Number,
                    opt=>opt.MapFrom(src=>src.Number)
                ).ForMember(
                    dest=>dest.TechnicalName,
                    opt=>opt.MapFrom(src=>src.TechnicalName)
                ).ForMember(
                    dest=>dest.OutletCount,
                    opt=>opt.MapFrom(src=>src.OutletCount)
                ).ForMember(
                    dest=>dest.CoordinatesOnPlan,
                    opt=>opt.MapFrom(src=>src.CoordinatesOnPlan)
                ).ForMember(
                    dest=>dest.Description,
                    opt=>opt.MapFrom(src=>src.Description)
                );
        }
    }
}