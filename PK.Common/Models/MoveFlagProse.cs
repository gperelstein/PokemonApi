﻿using PK.Common.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PK.Common.Models
{
    public class MoveFlagProse : NamedEntity
    {
        public int MoveFlagId { get; set; }
        public MoveFlag MoveFlag { get; set; }
        public int LocalLanguageId { get; set; }
        public Language LocalLanguage { get; set; }
        public string Description { get; set; }
    }
}