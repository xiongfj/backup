﻿using IdentityDB.Model.CustomModel;
using MainTain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MainTain.App_Start
{
	[Description("AutoMapper配置")]
	public class AutoMapperProfile : AutoMapper.Profile
	{
		/*设置视图模型到实体模型的关联*/
		protected override void Configure()
		{
			//CreateMap<ApplicationPermission, PermissionViewModel>();
			//CreateMap<PermissionViewModel, ApplicationPermission>();
			//CreateMap<ApplicationRole, RoleViewModel>();
			//CreateMap<RoleViewModel, ApplicationRole>()
			//	.ForMember(
			//				dest => dest.Id,
			//				sour =>
			//				{
			//					sour.MapFrom(s => s.Id ?? System.Guid.NewGuid().ToString());
			//				});

			//CreateMap<ApplicationUser, EditUserRoleViewModel>();
			CreateMap<ApplicationUser, EditUserRoleViewModel>();    // 左转右
			CreateMap<RegisterViewModel, ApplicationUser>();
			CreateMap<UrlEditViewModel, Url>();
			CreateMap<Url, UrlEditViewModel>();
			//CreateMap<Department, DepartmentViewModel>();
			//CreateMap<DepartmentViewModel, Department>();
		}
	}

	[Description("AutoMapper匹配")]
	public class AutoMapperConfig
	{
		public static void Configure()
		{
			AutoMapper.Mapper.Initialize(cfg =>
			{
				cfg.AddProfile<AutoMapperProfile>();
			});
		}
	}
}