﻿using Serenity;
using Serenity.Services;
using System;
using MyRequest = InPlan.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Administration.UserRow>;
using MyRow = InPlan.Administration.UserRow;


namespace InPlan.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }

        protected override void OnReturn()
        {
            base.OnReturn();

            if (Request.DataProtector != null &&
                Request.ClientHash != null &&
                Request.IncludeColumns != null &&
                Request.IncludeColumns.Contains("ImpersonationToken") &&
                Permissions.HasPermission("ImpersonateAs") &&
                !Response.Entities.IsEmptyOrNull())
            {
                foreach (var entity in Response.Entities)
                    if (string.Compare(entity.Username, "admin", StringComparison.OrdinalIgnoreCase) != 0)
                        entity.ImpersonationToken = UserHelper.GetImpersonationToken(Cache.Memory, Request.DataProtector,
                            Request.ClientHash, Context.User.Identity.Name, entity.Username);
            }
        }
    }
}