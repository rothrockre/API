﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkoutDataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RAWorkoutEntities : DbContext
    {
        public RAWorkoutEntities()
            : base("name=RAWorkoutEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<UserGoal> UserGoals { get; set; }
        public virtual DbSet<UserMax> UserMaxes { get; set; }
        public virtual DbSet<UserMuscleFatigue> UserMuscleFatigues { get; set; }
        public virtual DbSet<UserPerm> UserPerms { get; set; }
        public virtual DbSet<UserWorkout> UserWorkouts { get; set; }
        public virtual DbSet<Workout> Workouts { get; set; }
    }
}
