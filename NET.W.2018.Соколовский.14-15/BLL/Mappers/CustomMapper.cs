﻿using System.ComponentModel;
using AutoMapper;
using BLL.Interface;
using BLL.Interface.Entities;
using DAL.Interface.DTO;
using DAL.Interface.Enums;

namespace BLL.Mappers
{
    public static class CustomMapper
    {
        static CustomMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<BankAccount, BankAccountDTO>().ReverseMap();
                cfg.CreateMap<BankAccountTypes, BankAccountTypesDTO>().ReverseMap();
            });
        }

        public static void Init()
        {
        }
    }
}