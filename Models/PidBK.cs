﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkadTechDomain
{
 public   class PidBk
    {
        public PidBk()
        {
            ComponentKit = new List<Component>();
        }

        public string FeaturesBk { get; set; }
     public string  PidNumber{ get; set; }
     public string InstallationSite { get; set; }
     public string Artikul { get; set; }
     public string NameProduct { get; set; }
        List<Component> ComponentKit;

     
    }
}
