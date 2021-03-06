using System.Collections.Generic;
using AMS.Model.dto;
using AMS.Model.Enum;
using AMS.Model.poco;
using AMS.Model.Static;

namespace AMS.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ModelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ModelContext context)
        {
            //菜单数据
            if (!context.Menu.Any())
            {
                var defaultMenus = new List<Menu>()
                {
                    new Menu()
                    {
                        Id = Guid.NewGuid(),
                        Name = "维修接待",
                        OrderNum = 0,
                        Icon = "../../Content/img/common/service.png",
                        SubMenu = new List<Menu>()
                        {
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "维修管理",
                                OrderNum = 0,
                                Icon = "fa-gavel",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        OrderNum = 0,
                                        Name = "洗车开单",
                                        Url = CommonUrl.WashCarCreate,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Create.WashCar.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        OrderNum = 1,
                                        Name = "维修开单",
                                        Url = CommonUrl.RepairCreate,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Create.WashCar.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        OrderNum = 2,
                                        Name = "维修列表",
                                        Url = CommonUrl.RepairList,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Create.WashCar.png"
                                    }
                                }
                            },
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "预约管理",
                                OrderNum = 1,
                                Icon = "fa-book",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        OrderNum = 0,
                                        Name = "新建预约",
                                        Url = CommonUrl.BookingCreate,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Create.ServiceBooking.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        OrderNum = 1,
                                        Name = "预约列表",
                                        Url = CommonUrl.BookingList,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Index.ServiceBooking.png"
                                    }
                                }
                            },
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "历史查询",
                                OrderNum = 1,
                                Icon = "fa-file-text-o",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        OrderNum = 0,
                                        Name = "维修历史查询",
                                        Url = CommonUrl.RepairHistory,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Index.RepairHistory.png"
                                    }
                                }
                            }
                        }
                    },
                    new Menu()
                    {
                        Id = Guid.NewGuid(),
                        Name = "配件管理",
                        OrderNum = 1,
                        Icon = "../../Content/img/common/warehouse.png",
                        SubMenu = new List<Menu>()
                        {
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "基础数据",
                                OrderNum = 0,
                                Icon = "fa-cube",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        OrderNum = 0,
                                        Name = "供应商",
                                        Url = CommonUrl.Supplier,
                                        QuickMenuIcon = "../../Content/img/home/Part.Index.Supplier.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        OrderNum = 1,
                                        Name = "配件档案",
                                        Url = CommonUrl.PartDictionary,
                                        QuickMenuIcon = "../../Content/img/home/Part.Index.PartsDictionary.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        OrderNum = 2,
                                        Name = "库房",
                                        Url = CommonUrl.Warehouse,
                                        QuickMenuIcon = "../../Content/img/home/Part.Index.Warehouse.png"
                                    }
                                }
                            },
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "入库",
                                OrderNum = 1,
                                Icon = "fa-long-arrow-right",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        OrderNum = 0,
                                        Name = "采购入库",
                                        Url = CommonUrl.PartsBuy,
                                        QuickMenuIcon = "../../Content/img/home/Part.Index.PartsBuyWarehousing.png"
                                    }
                                }
                            },
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "出库",
                                OrderNum = 2,
                                Icon = "fa-long-arrow-left",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        OrderNum = 0,
                                        Name = "配件出库",
                                        Url = CommonUrl.PartsReturn,
                                        QuickMenuIcon = "../../Content/img/home/Part.Index.PartsOtherStackOut.png"
                                    }
                                }
                            },
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "库存预警",
                                OrderNum = 3,
                                Icon = "fa-bell",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        OrderNum = 0,
                                        Name = "预警查询",
                                        Url = CommonUrl.PartsWarning,
                                        QuickMenuIcon = "../../Content/img/home/Part.Index.PartsInventoryWarning.png"
                                    }
                                }
                            }
                        }
                    },
                    new Menu()
                    {
                        Id = Guid.NewGuid(),
                        Name = "客户关系",
                        OrderNum = 2,
                        Icon = "../../Content/img/common/customer.png",
                        SubMenu = new List<Menu>()
                        {
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "客户资料",
                                OrderNum = 0,
                                Icon = "fa-male",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "客户",
                                        OrderNum = 0,
                                        Url = CommonUrl.Customer,
                                        QuickMenuIcon = "../../Content/img/home/Customer.Index.Customer.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "车辆",
                                        OrderNum = 1,
                                        Url = CommonUrl.Car,
                                        QuickMenuIcon = "../../Content/img/home/Customer.Index.Car.png"
                                    }
                                }
                            },
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "业务办理",
                                OrderNum = 1,
                                Icon = "fa-street-view",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "预充值",
                                        OrderNum = 0,
                                        Url = CommonUrl.Charge,
                                        QuickMenuIcon = "../../Content/img/home/Member.MemberCharge.MemberCharge.png"
                                    }
                                }
                            }
                        }
                    },
                    new Menu()
                    {
                        Id = Guid.NewGuid(),
                        Name = "报表分析",
                        OrderNum = 3,
                        Icon = "../../Content/img/common/report.png",
                        SubMenu = new List<Menu>()
                        {
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "财务报表",
                                OrderNum = 0,
                                Icon = "fa-area-chart",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "维修统计日报",
                                        OrderNum = 0,
                                        Url = CommonUrl.DailyRepairReport,
                                        QuickMenuIcon = "../../Content/img/home/Report.RepairDailyReport.FinanceReport.png"
                                    }
                                }
                            },
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "运营报表",
                                OrderNum = 1,
                                Icon = "fa-area-chart",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "运营概况报表",
                                        OrderNum = 0,
                                        Url = CommonUrl.BusinessSituation,
                                        QuickMenuIcon = "../../Content/img/home/Report.GrossmarginReport.RepairReport.png"
                                    }
                                }
                            },
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "维修报表",
                                OrderNum = 2,
                                Icon = "fa-bar-chart",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "维修材料汇总",
                                        OrderNum = 0,
                                        Url = CommonUrl.RepairPartsSummary,
                                        QuickMenuIcon = "../../Content/img/home/Report.RepairMaterialSummarizing.RepairReport.png"
                                    }
                                }
                            },
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "库房报表",
                                OrderNum = 3,
                                Icon = "fa-line-chart",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "库存盘点汇总",
                                        OrderNum = 0,
                                        Url = CommonUrl.PartsInventoryCheckSummary,
                                        QuickMenuIcon = "../../Content/img/home/Part.Index.PartsSaleRanking.png"
                                    }
                                }
                            },
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "配件统计",
                                OrderNum = 4,
                                Icon = "fa-line-chart",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "配件销量排名",
                                        OrderNum = 0,
                                        Url = CommonUrl.PartsSaleRank,
                                        QuickMenuIcon = "../../Content/img/home/Part.Index.PartsSaleRanking.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "配件滞销排行",
                                        OrderNum = 1,
                                        Url = CommonUrl.PartsOverStokedRank,
                                        QuickMenuIcon = "../../Content/img/home/Part.Index.PartsSaleRanking.png"
                                    }
                                }
                            }
                        }
                    },
                    new Menu()
                    {
                        Id = Guid.NewGuid(),
                        Name = "基础资料",
                        OrderNum = 4,
                        Icon = "../../Content/img/common/baseinfo.png",
                        SubMenu = new List<Menu>()
                        {
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "公司管理",
                                OrderNum = 0,
                                Icon = "fa-home",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "组织结构",
                                        OrderNum = 0,
                                        Url = CommonUrl.OrgSchemaUrl,
                                        QuickMenuIcon = "../../Content/img/home/Users.Index.Organization.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "员工管理",
                                        OrderNum = 1,
                                        Url = CommonUrl.EmployeeManagement,
                                        QuickMenuIcon = "../../Content/img/home/Users.Index.Organization.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "岗位管理",
                                        OrderNum = 2,
                                        Url = CommonUrl.JobManagement,
                                        QuickMenuIcon = "../../Content/img/home/Users.Index.Organization.png"
                                    }
                                }
                            },
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "维修字典",
                                OrderNum = 1,
                                Icon = "fa-cogs",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "维修类型",
                                        OrderNum = 0,
                                        Url = CommonUrl.RepairType,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Index.RepairItemType.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "维修项目类型",
                                        OrderNum = 1,
                                        Url = CommonUrl.RepairItemType,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Index.RepairItemType.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "维修项目",
                                        OrderNum = 2,
                                        Url = CommonUrl.RepairItem,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Index.RepairItemType.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "洗车项目",
                                        OrderNum = 3,
                                        Url = CommonUrl.RepairItem,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Index.RepairItemType.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "结算方式",
                                        OrderNum = 4,
                                        Url = CommonUrl.ServiceAccountType,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Index.RepairItemType.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "付款方式",
                                        OrderNum = 5,
                                        Url = CommonUrl.PaymentType,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Index.RepairItemType.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "发票类型",
                                        OrderNum = 5,
                                        Url = CommonUrl.ServiceTicketType,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Index.RepairItemType.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "车型管理",
                                        OrderNum = 6,
                                        Url = CommonUrl.CarModel,
                                        QuickMenuIcon = "../../Content/img/home/Repair.Index.RepairItemType.png"
                                    }
                                }
                            },
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "配件字典",
                                OrderNum = 2,
                                Icon = "fa-cogs",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "配件类型",
                                        OrderNum = 0,
                                        Url = CommonUrl.PartsType,
                                        QuickMenuIcon = "../../Content/img/home/Part.Index.PartsType.png"
                                    }
                                }
                            }
                        }
                    },
                    new Menu()
                    {
                        Id = Guid.NewGuid(),
                        Name = "系统设置",
                        OrderNum = 5,
                        Icon = "../../Content/img/common/system.png",
                        SubMenu = new List<Menu>()
                        {
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "系统设置",
                                OrderNum = 0,
                                Icon = "fa-cogs",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "参数控制",
                                        OrderNum = 0,
                                        Url = CommonUrl.ParameterControl,
                                        QuickMenuIcon = "../../Content/img/home/System.ParametricControl.SystemSettings.png"
                                    },
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "单据号配置",
                                        OrderNum = 1,
                                        Url = CommonUrl.OrderNoSetting,
                                        QuickMenuIcon = "../../Content/img/home/System.ParametricControl.SystemSettings.png"
                                    }
                                }
                            },
                            new Menu()
                            {
                                Id = Guid.NewGuid(),
                                Name = "系统日志",
                                OrderNum = 1,
                                Icon = "fa-pencil",
                                SubMenu = new List<Menu>()
                                {
                                    new Menu()
                                    {
                                        Id = Guid.NewGuid(),
                                        Name = "操作日志",
                                        OrderNum = 0,
                                        Url = CommonUrl.OperationLog,
                                        QuickMenuIcon = "../../Content/img/home/System.ParametricControl.SystemSettings.png"
                                    }
                                }
                            }
                        }
                    }
                };
                context.Menu.AddRange(defaultMenus);
                context.SaveChanges();
            }
            //预填部门、员工、岗位默认数据
            if (!context.Organization.Any())
            {
                var defaultDepartment = new Organization()
                {
                    Id = Guid.NewGuid(),
                    Name = "默认部门",
                    OrderNum = 0,
                    OperationType = OperationTypeEnum.系统预置,
                    Description = "系统默认数据",
                    CreateTime = DateTime.Now,
                    OrgHope = "好的开始是成功的一半"
                };
                context.Organization.Add(defaultDepartment);
                if (!context.User.Any())
                {
                    var defaultUser = new User()
                    {
                        Id = Guid.NewGuid(),
                        Name = "系统管理员",
                        Account = "admin",
                        Password = "admin",
                        Description = "系统默认数据",
                        OperationType = OperationTypeEnum.系统预置,
                        Org = defaultDepartment,
                        CreateTime = DateTime.Now
                    };
                    context.User.Add(defaultUser);
                    if (!context.Job.Any())
                    {
                        var defaultJob = new Job()
                        {
                            Id = Guid.NewGuid(),
                            Name = "系统管理员",
                            Description = "系统默认数据",
                            OperationType = OperationTypeEnum.系统预置,
                            Org = defaultDepartment,
                            CreateTime = DateTime.Now
                        };
                        context.Job.Add(defaultJob);
                        if (!context.UserJob.Any())
                        {
                            var job = defaultJob;
                            var user = defaultUser;
                            var userJob=new UserJob()
                            {
                                Id = Guid.NewGuid(),
                                UserId = user.Id,
                                JobId = job.Id,
                                OperationType = OperationTypeEnum.系统预置
                            };
                            context.UserJob.Add(userJob);
                        }

                        if (!context.JobMenu.Any())
                        {
                            var jobMenus = new List<JobMenu>();
                            var job = defaultJob;
                            var menuIds = context.Menu.Select(i => i.Id);
                            foreach (var menuId in menuIds)
                            {
                                var jobMenu = new JobMenu()
                                {
                                    Id = Guid.NewGuid(),
                                    JobId = job.Id,
                                    MenuId = menuId,
                                    OperationType = OperationTypeEnum.系统预置
                                };
                                jobMenus.Add(jobMenu);
                            }
                            context.JobMenu.AddRange(jobMenus);
                        }
                    }
                }
            }
            //单据号默认数据
            if (!context.BillNoSetting.Any())
            {
                var billNoSettings=new List<BillNoSetting>()
                {
                    new BillNoSetting()
                    {
                        Id = Guid.NewGuid(),
                        Name = BillTypeName.采购入库.ToString(),
                        Prefix = "CR",
                        DateFormat = BillDateFormat.简洁年月日,
                        SerNoLength = BillSerNoLength.四位,
                        DailyReset = true,
                        BillNoPreview = "CR1805120001"
                    },
                    new BillNoSetting()
                    {
                        Id = Guid.NewGuid(),
                        Name = BillTypeName.配件出库.ToString(),
                        Prefix = "QC",
                        DateFormat = BillDateFormat.简洁年月日,
                        SerNoLength = BillSerNoLength.四位,
                        DailyReset = true,
                        BillNoPreview = "QC1805120001"
                    },
                    new BillNoSetting()
                    {
                        Id = Guid.NewGuid(),
                        Name = BillTypeName.预约单号.ToString(),
                        Prefix = "YY",
                        DateFormat = BillDateFormat.简洁年月日,
                        SerNoLength = BillSerNoLength.四位,
                        DailyReset = true,
                        BillNoPreview = "YY1805120001"
                    },
                    new BillNoSetting()
                    {
                        Id = Guid.NewGuid(),
                        Name = BillTypeName.接车单号.ToString(),
                        Prefix = "JC",
                        DateFormat = BillDateFormat.简洁年月日,
                        SerNoLength = BillSerNoLength.四位,
                        DailyReset = true,
                        BillNoPreview = "JC1805120001"
                    },
                    new BillNoSetting()
                    {
                        Id = Guid.NewGuid(),
                        Name = BillTypeName.会员充值.ToString(),
                        Prefix = "MC",
                        DateFormat = BillDateFormat.简洁年月日,
                        SerNoLength = BillSerNoLength.四位,
                        DailyReset = true,
                        BillNoPreview = "MC1805120001"
                    }
                };
                context.BillNoSetting.AddRange(billNoSettings);
            }
            //参数控制默认数据
            if (!context.ParameterControl.Any())
            {
                var parameterControls=new List<ParameterControl>()
                {
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "RepeatBooking",
                        Value1 = "false",
                        Value1Type1 = ParameterValueType.布尔
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "RepeatRepair",
                        Value1 = "false",
                        Value1Type1 = ParameterValueType.布尔
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "RequiredVin",
                        Value1 = "false",
                        Value1Type1 = ParameterValueType.布尔
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "RequiredMobile",
                        Value1 = "false",
                        Value1Type1 = ParameterValueType.布尔
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "RequiredInsuranceExpireTime",
                        Value1 = "false",
                        Value1Type1 = ParameterValueType.布尔
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "RequiredYearlyCheckTime",
                        Value1 = "false",
                        Value1Type1 = ParameterValueType.布尔
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "RequiredServiceMileage",
                        Value1 = "false",
                        Value1Type1 = ParameterValueType.布尔
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "RequiredNextMaintainMileage",
                        Value1 = "false",
                        Value1Type1 = ParameterValueType.布尔
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "PartsBuyPriceControl",
                        Value1 = "false",
                        Value1Type1 = ParameterValueType.布尔
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "ServiceTicketRate",
                        Value1 = "17.00",
                        Value1Type1 = ParameterValueType.浮点数
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "MaintainInterval",
                        Value1 = "5000",
                        Value1Type1 = ParameterValueType.整数
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "PartsCountAlert",
                        Value1 = "false",
                        Value1Type1 = ParameterValueType.布尔
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "BirthdayAlert",
                        Value1 = "true",
                        Value1Type1 = ParameterValueType.布尔,
                        Value2 = "3",
                        Value1Type2 = ParameterValueType.整数
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "InsuranceExpireTimeAlert",
                        Value1 = "true",
                        Value1Type1 = ParameterValueType.布尔,
                        Value2 = "7",
                        Value1Type2 = ParameterValueType.整数
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "MaintainMileageAlert",
                        Value1 = "true",
                        Value1Type1 = ParameterValueType.布尔,
                        Value2 = "7",
                        Value1Type2 = ParameterValueType.整数
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "MaintainDateAlert",
                        Value1 = "true",
                        Value1Type1 = ParameterValueType.布尔,
                        Value2 = "7",
                        Value1Type2 = ParameterValueType.整数
                    },
                    new ParameterControl()
                    {
                        Id = Guid.NewGuid(),
                        ParameterName = "YearlyCheckTimeAlert",
                        Value1 = "true",
                        Value1Type1 = ParameterValueType.布尔,
                        Value2 = "7",
                        Value1Type2 = ParameterValueType.整数
                    }
                };
                context.ParameterControl.AddRange(parameterControls);
            }
            //支付方式默认数据
            if (!context.PaymentType.Any())
            {
                var paymentTypes=new List<PaymentType>()
                {
                    new PaymentType()
                    {
                        Id = Guid.NewGuid(),
                        Name = "预存款",
                        IconUrl = "../../Content/img/payment/balance_red.png",
                        SelectedIconUrl = "../../Content/img/payment/balance_white.png",
                        OperationType = OperationTypeEnum.系统预置,
                        Description = "系统预置，不可删除"
                    },
                    new PaymentType()
                    {
                        Id = Guid.NewGuid(),
                        Name = "现金",
                        IconUrl = "../../Content/img/payment/crash_green.png",
                        SelectedIconUrl = "../../Content/img/payment/crash_white.png",
                        OperationType = OperationTypeEnum.系统预置,
                        Description = "系统预置，不可删除"
                    },
                    new PaymentType()
                    {
                        Id = Guid.NewGuid(),
                        Name = "银行卡",
                        IconUrl = "../../Content/img/payment/card_blue.png",
                        SelectedIconUrl = "../../Content/img/payment/card_white.png",
                        OperationType = OperationTypeEnum.系统预置,
                        Description = "系统预置，不可删除"
                    },
                    new PaymentType()
                    {
                        Id = Guid.NewGuid(),
                        Name = "微信支付",
                        IconUrl = "../../Content/img/payment/wechart_green.png",
                        SelectedIconUrl = "../../Content/img/payment/wechart_white.png",
                        OperationType = OperationTypeEnum.系统预置,
                        Description = "系统预置，不可删除"
                    }
                };
                context.PaymentType.AddRange(paymentTypes);
            }
        }
    }
}
