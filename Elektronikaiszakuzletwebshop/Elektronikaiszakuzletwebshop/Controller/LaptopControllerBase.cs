﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElektronikaiSzakuzletWebShopV2.Entity;

namespace ElektronikaiSzakuzletWebShopV2.Controller
{
    public abstract class LaptopControllerBase<ENTITY> : ControllerBase where ENTITY : AbstractBaseEntity
    {
        [HttpGet]
        public abstract List<ENTITY> GetAll();
        [HttpGet("{id}")]
        public abstract ENTITY GetById(int id);
        [HttpPost]
        public abstract ENTITY Save([FromBody] ENTITY inputData);
        [HttpPut("{id}")]
        public abstract ENTITY Update(int id, [FromBody] ENTITY updateData);
        [HttpDelete("{id}")]
        public abstract void Delete(int id);
    }
}
