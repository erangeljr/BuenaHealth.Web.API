﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenaHealth.Web.API.Models
{
    public class Profile
    {
        private List<Link> _links;

        public long? ProfileId { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public List<User> Associates { get; set; }

        public List<Link> Links
        {
            get { return _links ?? (_links = new List<Link>()); }
            set { _links = value; }
        }

        public void AddLink(Link link)
        {
            Links.Add(link);
        }
    }
}