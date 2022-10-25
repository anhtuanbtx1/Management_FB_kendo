using System;
using System.Collections.Generic;
using PSafe.Core.Interface;

namespace PSafe.Core.SharedKernel
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        IGroupRepository GroupRepository { get; }
        IRoleRepository RoleRepository { get; }
        ICommandCenterRepository CommandCenterRepository { get; }
        ISystemUserRepository SystemUserRepository { get; }
        IUserRepository UserRepository { get; }
        IUserInRoleRepository UserInRoleRepository { get; }
        IHistorySystemRepository HistorySystemRepository { get; }
        IBlackListRepository BlackListRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }
        IPositionRepository PositionRepository { get; }
        IPatrolCameraCalendarRepository PatrolCameraCalendarRepository { get; }
        IPatrolCameraHistoryRepository PatrolCameraHistoryRepository { get; }
        ISiteRepository SiteRepository { get; }
    }
}
