using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektZespołówka.Models
{
    public class Helpers
    {
        public enum UserRole
        {
            ServiceWorker,
            Manager,
            Investor,
            Admin
        }
        public enum ProjectStatus
        {
            Planned,
            InProgress,
            Completed,
            OnHold,
            Cancelled
        }
        public enum OutletType
        {
            Electrical,
            Data,
            Telephone,
            Other
        }
        public enum CertificationStatus
        {
            Pending,
            Approved,
            Rejected
        }
        public enum OutletStatus
        {
            Active,
            Inactive,
            UnderMaintenance
        }
        public enum MeasurementType
        {
            Correct,
            Incorrect,
            With_Error_Margin
        }
        public enum WorkStatus
        {
            NotStarted,
            InProgress,
            Completed,
            Delayed
        }
        public enum EntityType
        {
            Outlet,
            Room,
            Floor,
            Stage
        }
        public enum CommentStatus
        {
            Open,
            Resolved,
            Closed
        }
    }
}