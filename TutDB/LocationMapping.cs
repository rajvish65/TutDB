using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutDB
{
    class LocationMapping
    {
        public long LocationId { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }
        public Nullable<long> isActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public List<tblRoomMaster> RoomList
        {
            get { return this.RoomList; }
            set { this.RoomList = value; }
        }

    }
}
