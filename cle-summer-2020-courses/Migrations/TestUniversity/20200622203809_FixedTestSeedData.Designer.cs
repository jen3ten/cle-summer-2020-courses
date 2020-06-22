﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cle_summer_2020_courses;

namespace cle_summer_2020_courses.Migrations.TestUniversity
{
    [DbContext(typeof(TestUniversityContext))]
    [Migration("20200622203809_FixedTestSeedData")]
    partial class FixedTestSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cle_summer_2020_courses.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Test Course Description 1",
                            InstructorId = 1,
                            Name = "Test Course 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Test Course Description 2",
                            InstructorId = 2,
                            Name = "Test Course 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Test Course Description 3",
                            InstructorId = 2,
                            Name = "Test Course 3"
                        });
                });

            modelBuilder.Entity("cle_summer_2020_courses.Models.CourseLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Building")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("RoomNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.ToTable("CourseLocations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Building = "Test Building 1",
                            CourseId = 1,
                            RoomNumber = "Test Room Number 1"
                        },
                        new
                        {
                            Id = 2,
                            Building = "Test Building 2",
                            CourseId = 2,
                            RoomNumber = "Test Room Number 2"
                        },
                        new
                        {
                            Id = 3,
                            Building = "Test Building 3",
                            CourseId = 3,
                            RoomNumber = "Test Room Number 3"
                        });
                });

            modelBuilder.Entity("cle_summer_2020_courses.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Test Instructor 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Test Instructor 2"
                        });
                });

            modelBuilder.Entity("cle_summer_2020_courses.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Test Student 1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Test Student 2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Test Student 3"
                        });
                });

            modelBuilder.Entity("cle_summer_2020_courses.Models.StudentCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            StudentId = 3
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 3,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 3,
                            StudentId = 3
                        });
                });

            modelBuilder.Entity("cle_summer_2020_courses.Models.Course", b =>
                {
                    b.HasOne("cle_summer_2020_courses.Models.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("cle_summer_2020_courses.Models.CourseLocation", b =>
                {
                    b.HasOne("cle_summer_2020_courses.Models.Course", "Course")
                        .WithOne("Location")
                        .HasForeignKey("cle_summer_2020_courses.Models.CourseLocation", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("cle_summer_2020_courses.Models.StudentCourse", b =>
                {
                    b.HasOne("cle_summer_2020_courses.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("cle_summer_2020_courses.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
