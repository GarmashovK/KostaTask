using AutoMapper;
using EmployeServiceLib.Models;
using KostaWebTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KostaWebTask.App_Start {
    public static class AutoMapperBootstrapper {
        public static void Bootstrap() {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Employe, GetEmployeViewModel>()
                .ForMember(vm => vm.Age,
                    m => m.MapFrom(e => (DateTime.Now - e.BirthDay).Days / 365));
                cfg.CreateMap<AddEmployeViewModel, Employe>();
            });
        }
    }
}