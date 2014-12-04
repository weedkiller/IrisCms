// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Iris.Web.Areas.Admin.Controllers
{
    public partial class UserController
    {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected UserController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToActionPermanent(ActionResult result)
        {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoutePermanent(callInfo.RouteValueDictionary);
        }

        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult Detail()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Detail);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AutoCompleteSearch()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AutoCompleteSearch);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult AddUser()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddUser);
        }
        [NonAction]
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public virtual System.Web.Mvc.ActionResult EditUser()
        {
            return new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditUser);
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public UserController Actions { get { return MVC.Admin.User; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Admin";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "User";
        [GeneratedCode("T4MVC", "2.0")]
        public const string NameConst = "User";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass
        {
            public readonly string Index = "Index";
            public readonly string DataTable = "DataTable";
            public readonly string Detail = "Detail";
            public readonly string Search = "Search";
            public readonly string AutoCompleteSearch = "AutoCompleteSearch";
            public readonly string RenderNavBar = "RenderNavBar";
            public readonly string Add = "Add";
            public readonly string AddUser = "AddUser";
            public readonly string EditUser = "EditUser";
        }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNameConstants
        {
            public const string Index = "Index";
            public const string DataTable = "DataTable";
            public const string Detail = "Detail";
            public const string Search = "Search";
            public const string AutoCompleteSearch = "AutoCompleteSearch";
            public const string RenderNavBar = "RenderNavBar";
            public const string Add = "Add";
            public const string AddUser = "AddUser";
            public const string EditUser = "EditUser";
        }


        static readonly ActionParamsClass_DataTable s_params_DataTable = new ActionParamsClass_DataTable();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_DataTable DataTableParams { get { return s_params_DataTable; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_DataTable
        {
            public readonly string term = "term";
            public readonly string page = "page";
            public readonly string count = "count";
            public readonly string order = "order";
            public readonly string orderBy = "orderBy";
            public readonly string searchBy = "searchBy";
        }
        static readonly ActionParamsClass_Detail s_params_Detail = new ActionParamsClass_Detail();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_Detail DetailParams { get { return s_params_Detail; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_Detail
        {
            public readonly string userId = "userId";
        }
        static readonly ActionParamsClass_AutoCompleteSearch s_params_AutoCompleteSearch = new ActionParamsClass_AutoCompleteSearch();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AutoCompleteSearch AutoCompleteSearchParams { get { return s_params_AutoCompleteSearch; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AutoCompleteSearch
        {
            public readonly string term = "term";
            public readonly string searchBy = "searchBy";
        }
        static readonly ActionParamsClass_AddUser s_params_AddUser = new ActionParamsClass_AddUser();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_AddUser AddUserParams { get { return s_params_AddUser; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_AddUser
        {
            public readonly string userModel = "userModel";
        }
        static readonly ActionParamsClass_EditUser s_params_EditUser = new ActionParamsClass_EditUser();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionParamsClass_EditUser EditUserParams { get { return s_params_EditUser; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionParamsClass_EditUser
        {
            public readonly string userId = "userId";
            public readonly string userModel = "userModel";
        }
        static readonly ViewsClass s_views = new ViewsClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewsClass Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewsClass
        {
            static readonly _ViewNamesClass s_ViewNames = new _ViewNamesClass();
            public _ViewNamesClass ViewNames { get { return s_ViewNames; } }
            public class _ViewNamesClass
            {
                public readonly string _Add = "_Add";
                public readonly string _DataTable = "_DataTable";
                public readonly string _Detail = "_Detail";
                public readonly string _EditUser = "_EditUser";
                public readonly string _FilterBar = "_FilterBar";
                public readonly string _Index = "_Index";
                public readonly string _NavBar = "_NavBar";
                public readonly string _Search = "_Search";
            }
            public readonly string _Add = "~/Areas/Admin/Views/User/_Add.cshtml";
            public readonly string _DataTable = "~/Areas/Admin/Views/User/_DataTable.cshtml";
            public readonly string _Detail = "~/Areas/Admin/Views/User/_Detail.cshtml";
            public readonly string _EditUser = "~/Areas/Admin/Views/User/_EditUser.cshtml";
            public readonly string _FilterBar = "~/Areas/Admin/Views/User/_FilterBar.cshtml";
            public readonly string _Index = "~/Areas/Admin/Views/User/_Index.cshtml";
            public readonly string _NavBar = "~/Areas/Admin/Views/User/_NavBar.cshtml";
            public readonly string _Search = "~/Areas/Admin/Views/User/_Search.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public partial class T4MVC_UserController : Iris.Web.Areas.Admin.Controllers.UserController
    {
        public T4MVC_UserController() : base(Dummy.Instance) { }

        partial void IndexOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Index()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Index);
            IndexOverride(callInfo);
            return callInfo;
        }

        partial void DataTableOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string term, int page, int count, Iris.Servicelayer.EFServices.Enums.Order order, Iris.Servicelayer.EFServices.Enums.UserOrderBy orderBy, Iris.Servicelayer.EFServices.Enums.UserSearchBy searchBy);

        public override System.Web.Mvc.ActionResult DataTable(string term, int page, int count, Iris.Servicelayer.EFServices.Enums.Order order, Iris.Servicelayer.EFServices.Enums.UserOrderBy orderBy, Iris.Servicelayer.EFServices.Enums.UserSearchBy searchBy)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.DataTable);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "term", term);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "page", page);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "count", count);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "order", order);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "orderBy", orderBy);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "searchBy", searchBy);
            DataTableOverride(callInfo, term, page, count, order, orderBy, searchBy);
            return callInfo;
        }

        partial void DetailOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int userId);

        public override System.Web.Mvc.ActionResult Detail(int userId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Detail);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userId", userId);
            DetailOverride(callInfo, userId);
            return callInfo;
        }

        partial void SearchOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Search()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Search);
            SearchOverride(callInfo);
            return callInfo;
        }

        partial void AutoCompleteSearchOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, string term, Iris.Servicelayer.EFServices.Enums.UserSearchBy searchBy);

        public override System.Web.Mvc.ActionResult AutoCompleteSearch(string term, Iris.Servicelayer.EFServices.Enums.UserSearchBy searchBy)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AutoCompleteSearch);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "term", term);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "searchBy", searchBy);
            AutoCompleteSearchOverride(callInfo, term, searchBy);
            return callInfo;
        }

        partial void RenderNavBarOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult RenderNavBar()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.RenderNavBar);
            RenderNavBarOverride(callInfo);
            return callInfo;
        }

        partial void AddOverride(T4MVC_System_Web_Mvc_ActionResult callInfo);

        public override System.Web.Mvc.ActionResult Add()
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.Add);
            AddOverride(callInfo);
            return callInfo;
        }

        partial void AddUserOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Iris.Model.AdminModel.AddUserModel userModel);

        public override System.Web.Mvc.ActionResult AddUser(Iris.Model.AdminModel.AddUserModel userModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.AddUser);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userModel", userModel);
            AddUserOverride(callInfo, userModel);
            return callInfo;
        }

        partial void EditUserOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, int userId);

        public override System.Web.Mvc.ActionResult EditUser(int userId)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditUser);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userId", userId);
            EditUserOverride(callInfo, userId);
            return callInfo;
        }

        partial void EditUserOverride(T4MVC_System_Web_Mvc_ActionResult callInfo, Iris.Model.AdminModel.EditUserModel userModel);

        public override System.Web.Mvc.ActionResult EditUser(Iris.Model.AdminModel.EditUserModel userModel)
        {
            var callInfo = new T4MVC_System_Web_Mvc_ActionResult(Area, Name, ActionNames.EditUser);
            ModelUnbinderHelpers.AddRouteValues(callInfo.RouteValueDictionary, "userModel", userModel);
            EditUserOverride(callInfo, userModel);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591