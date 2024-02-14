﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TripPlanner.API.Database;

#nullable disable

namespace TripPlanner.API.Migrations
{
    [DbContext(typeof(TripDatabaseContext))]
    [Migration("20240201121742_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("TripPlanner.API.Entities.Accomodation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookingId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CheckInId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CheckOutId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPrepaid")
                        .HasColumnType("INTEGER");

                    b.Property<TimeOnly?>("MaxCheckInTime")
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly?>("MaxCheckOutTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoomNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.HasIndex("CheckInId");

                    b.HasIndex("CheckOutId");

                    b.ToTable("Accomodations");
                });

            modelBuilder.Entity("TripPlanner.API.Entities.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<int>("DayNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DestinationId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsTimeExact")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT");

                    b.Property<int>("SequenceNumber")
                        .HasColumnType("INTEGER");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("TEXT");

                    b.Property<string>("TravelToInfo")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DestinationId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("TripPlanner.API.Entities.Attraction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ActivityId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BookingId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEating")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsEntering")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsTicketed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsVisited")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OpeningHours")
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("BookingId");

                    b.ToTable("Attractions");
                });

            modelBuilder.Entity("TripPlanner.API.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BookingReference")
                        .HasColumnType("TEXT");

                    b.Property<double>("Cost")
                        .HasColumnType("REAL");

                    b.Property<bool>("IsBooked")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("TripPlanner.API.Entities.Destination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("DepartureDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PreviousDestinationId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("TripId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("PreviousDestinationId");

                    b.HasIndex("TripId");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("TripPlanner.API.Entities.Transport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ArrivalId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookingId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DepartureId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RouteNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("SeatNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("TransitTime")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TransportationMode")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ArrivalId");

                    b.HasIndex("BookingId");

                    b.HasIndex("DepartureId");

                    b.ToTable("Transports");
                });

            modelBuilder.Entity("TripPlanner.API.Entities.Trip", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Trips");
                });

            modelBuilder.Entity("TripPlanner.API.Entities.Accomodation", b =>
                {
                    b.HasOne("TripPlanner.API.Entities.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TripPlanner.API.Entities.Activity", "CheckIn")
                        .WithMany()
                        .HasForeignKey("CheckInId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TripPlanner.API.Entities.Activity", "CheckOut")
                        .WithMany()
                        .HasForeignKey("CheckOutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("CheckIn");

                    b.Navigation("CheckOut");
                });

            modelBuilder.Entity("TripPlanner.API.Entities.Activity", b =>
                {
                    b.HasOne("TripPlanner.API.Entities.Destination", "Destination")
                        .WithMany("Activities")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Destination");
                });

            modelBuilder.Entity("TripPlanner.API.Entities.Attraction", b =>
                {
                    b.HasOne("TripPlanner.API.Entities.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TripPlanner.API.Entities.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId");

                    b.Navigation("Activity");

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("TripPlanner.API.Entities.Destination", b =>
                {
                    b.HasOne("TripPlanner.API.Entities.Destination", "PreviousDestination")
                        .WithMany()
                        .HasForeignKey("PreviousDestinationId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("TripPlanner.API.Entities.Trip", "Trip")
                        .WithMany("Destinations")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PreviousDestination");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("TripPlanner.API.Entities.Transport", b =>
                {
                    b.HasOne("TripPlanner.API.Entities.Activity", "Arrival")
                        .WithMany()
                        .HasForeignKey("ArrivalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TripPlanner.API.Entities.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TripPlanner.API.Entities.Activity", "Departure")
                        .WithMany()
                        .HasForeignKey("DepartureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arrival");

                    b.Navigation("Booking");

                    b.Navigation("Departure");
                });

            modelBuilder.Entity("TripPlanner.API.Entities.Destination", b =>
                {
                    b.Navigation("Activities");
                });

            modelBuilder.Entity("TripPlanner.API.Entities.Trip", b =>
                {
                    b.Navigation("Destinations");
                });
#pragma warning restore 612, 618
        }
    }
}