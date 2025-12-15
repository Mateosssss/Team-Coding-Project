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
    public class OutletProfile:Profile
    {
        public OutletProfile()
        {
            CreateMap<Outlet,OutletDto>()
                .ForMember(
                    dest=>dest.RoomId,
                    opt=>opt.MapFrom(src=>src.RoomId)
                )
                .ForMember(
                    dest=>dest.TechnicalName,
                    opt=>opt.MapFrom(src=>src.TechnicalName)
                )
                .ForMember(
                    dest=>dest.Type,
                    opt=>opt.MapFrom(src=>src.Type)
                )
                .ForMember(
                    dest=>dest.NearPhotoId,
                    opt=>opt.MapFrom(src=>src.NearPhotoId)
                ).ForMember(
                    dest=>dest.FarPhotoId,
                    opt=>opt.MapFrom(src=>src.FarPhotoId)
                ).ForMember(
                    dest=>dest.Status,
                    opt=>opt.MapFrom(src=>src.Status)
                ).ForMember(
                    dest=>dest.InstallationDate,
                    opt=>opt.MapFrom(src=>src.InstallationDate)
                ).ForMember(
                    dest=>dest.ServedById,
                    opt=>opt.MapFrom(src=>src.ServedById)
                );

                CreateMap<CreateOutletDto,Outlet>().ForMember(
                    dest=>dest.RoomId,
                    opt=>opt.MapFrom(src=>src.RoomId)
                ).ForMember(
                    dest=>dest.TechnicalName,
                    opt=>opt.MapFrom(src=>src.TechnicalName)
                ).ForMember(
                    dest=>dest.Type,
                    opt=>opt.MapFrom(src=>src.Type)
                ).ForMember(
                    dest=>dest.NearPhotoId,
                    opt=>opt.MapFrom(src=>src.NearPhotoId)
                ).ForMember(
                    dest=>dest.FarPhotoId,
                    opt=>opt.MapFrom(src=>src.FarPhotoId)
                ).ForMember(
                    dest=>dest.ServedById,
                    opt=>opt.MapFrom(src=>src.ServedById)
                );
        }
    }
}