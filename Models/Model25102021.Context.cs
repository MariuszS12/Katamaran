﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PBLKatamaran.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Katamaran25102021Entities : DbContext
    {
        public Katamaran25102021Entities()
            : base("name=Katamaran25102021Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DeepModule> DeepModule { get; set; }
        public virtual DbSet<ElmetronMeasurements> ElmetronMeasurements { get; set; }
        public virtual DbSet<IonSelectiveMeasurements> IonSelectiveMeasurements { get; set; }
        public virtual DbSet<MeasurementsRAW_Kwerenda> MeasurementsRAW_Kwerenda { get; set; }
        public virtual DbSet<ModbusFrames> ModbusFrames { get; set; }
        public virtual DbSet<Polls> Polls { get; set; }
        public virtual DbSet<RESET_ID> RESET_ID { get; set; }
        public virtual DbSet<Status> Status { get; set; }
    }
}
