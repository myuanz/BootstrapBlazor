﻿using BootstrapBlazor.Components;
using BootstrapBlazor.WebConsole.Common;
using System.Collections.Generic;
using System.Linq;

namespace BootstrapBlazor.WebConsole.Pages
{
    /// <summary>
    /// 
    /// </summary>
    sealed partial class Menus
    {
        private IEnumerable<MenuItem> GetItems()
        {
            var ret = new List<MenuItem>();
            ret.Add(new MenuItem() { Text = "导航一" });
            ret.Add(new MenuItem() { Text = "导航二", IsActive = true });
            ret.Add(new MenuItem() { Text = "导航三" });

            ret[1].AddItem(new MenuItem() { Text = "子菜单一" });
            ret[1].AddItem(new MenuItem() { Text = "子菜单二" });
            ret[1].AddItem(new MenuItem() { Text = "子菜单三" });

            ret[1].Items.ElementAt(0).AddItem(new MenuItem() { Text = "孙菜单1一" });
            ret[1].Items.ElementAt(0).AddItem(new MenuItem() { Text = "孙菜单1二" });

            ret[1].Items.ElementAt(1).AddItem(new MenuItem() { Text = "孙菜单2一" });
            ret[1].Items.ElementAt(1).AddItem(new MenuItem() { Text = "孙菜单2二" });

            ret[1].Items.ElementAt(1).Items.ElementAt(1).AddItem(new MenuItem() { Text = "曾孙菜单一" });
            ret[1].Items.ElementAt(1).Items.ElementAt(1).AddItem(new MenuItem() { Text = "曾孙菜单二" });

            ret[1].Items.ElementAt(1).Items.ElementAt(1).Items.ElementAt(1).AddItem(new MenuItem() { Text = "曾曾孙菜单一" });
            ret[1].Items.ElementAt(1).Items.ElementAt(1).Items.ElementAt(1).AddItem(new MenuItem() { Text = "曾曾孙菜单二" });

            return ret;
        }

        private IEnumerable<MenuItem> GetIconItems()
        {
            var ret = new List<MenuItem>();
            ret.Add(new MenuItem() { Text = "导航一", Icon = "fa fa-life-bouy fa-fw" });
            ret.Add(new MenuItem() { Text = "导航二", Icon = "fa fa-fa fa-fw", IsActive = true });
            ret.Add(new MenuItem() { Text = "导航三", Icon = "fa fa-rebel fa-fw" });

            ret[1].AddItem(new MenuItem() { Text = "子菜单一", Icon = "fa fa-fa fa-fw" });
            ret[1].AddItem(new MenuItem() { Text = "子菜单二", Icon = "fa fa-fa fa-fw" });
            ret[1].AddItem(new MenuItem() { Text = "子菜单三", Icon = "fa fa-fa fa-fw" });

            return ret;
        }

        private IEnumerable<MenuItem> GetSideMenuItems()
        {
            var ret = new List<MenuItem>();
            ret.Add(new MenuItem() { Text = "导航一" });
            ret.Add(new MenuItem() { Text = "导航二" });
            ret.Add(new MenuItem() { Text = "导航三" });
            ret.Add(new MenuItem() { Text = "导航四" });

            ret[1].AddItem(new MenuItem() { Text = "子菜单一" });
            ret[1].AddItem(new MenuItem() { Text = "子菜单二" });
            ret[1].AddItem(new MenuItem() { Text = "子菜单三" });

            ret[3].AddItem(new MenuItem() { Text = "子菜单一" });
            ret[3].AddItem(new MenuItem() { Text = "子菜单二" });
            ret[3].AddItem(new MenuItem() { Text = "子菜单三" });

            ret[1].Items.ElementAt(0).AddItem(new MenuItem() { Text = "孙菜单1一" });
            ret[1].Items.ElementAt(0).AddItem(new MenuItem() { Text = "孙菜单1二" });

            ret[1].Items.ElementAt(1).AddItem(new MenuItem() { Text = "孙菜单2一" });
            ret[1].Items.ElementAt(1).AddItem(new MenuItem() { Text = "孙菜单2二" });

            ret[1].Items.ElementAt(0).Items.ElementAt(0).AddItem(new MenuItem() { Text = "曾孙菜单一" });
            ret[1].Items.ElementAt(0).Items.ElementAt(0).AddItem(new MenuItem() { Text = "曾孙菜单二" });

            ret[1].Items.ElementAt(0).Items.ElementAt(0).Items.ElementAt(0).AddItem(new MenuItem() { Text = "曾曾孙菜单一" });
            ret[1].Items.ElementAt(0).Items.ElementAt(0).Items.ElementAt(0).AddItem(new MenuItem() { Text = "曾曾孙菜单二" });

            return ret;
        }

        private IEnumerable<MenuItem> GetIconSideMenuItems()
        {
            var ret = new List<MenuItem>();
            ret.Add(new MenuItem() { Text = "系统设置", IsActive = true, Icon = "fa fa-fw fa-gears" });
            ret.Add(new MenuItem() { Text = "权限设置", Icon = "fa fa-fw fa-users" });
            ret.Add(new MenuItem() { Text = "日志设置", Icon = "fa fa-fw fa-database" });

            ret[0].AddItem(new MenuItem() { Text = "网站设置", Icon = "fa fa-fw fa-fa" });
            ret[0].AddItem(new MenuItem() { Text = "任务设置", Icon = "fa fa-fw fa-tasks" });

            ret[1].AddItem(new MenuItem() { Text = "用户设置", Icon = "fa fa-fw fa-user" });
            ret[1].AddItem(new MenuItem() { Text = "菜单设置", Icon = "fa fa-fw fa-dashboard" });
            ret[1].AddItem(new MenuItem() { Text = "角色设置", Icon = "fa fa-fw fa-sitemap" });

            ret[2].AddItem(new MenuItem() { Text = "访问日志", Icon = "fa fa-fw fa-bars" });
            ret[2].AddItem(new MenuItem() { Text = "登录日志", Icon = "fa fa-fw fa-user-circle-o" });
            ret[2].AddItem(new MenuItem() { Text = "操作日志", Icon = "fa fa-fw fa-edit" });

            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private IEnumerable<AttributeItem> GetAttributes()
        {
            return new AttributeItem[]
            {
                new AttributeItem()
                {
                    Name = "Items",
                    Description = "菜单组件数据集合",
                    Type = "IEnumerable<MenuItem>",
                    ValueList = " — ",
                    DefaultValue = " — "
                },
                new AttributeItem()
                {
                    Name = "IsVertical",
                    Description = "是否为侧栏",
                    Type = "bool",
                    ValueList = "true|false",
                    DefaultValue = "false"
                },
                new AttributeItem() {
                    Name = "IsAccordion",
                    Description = "是否手风琴效果",
                    Type = "bool",
                    ValueList = "true|false",
                    DefaultValue = "false"
                }
            };
        }
    }
}