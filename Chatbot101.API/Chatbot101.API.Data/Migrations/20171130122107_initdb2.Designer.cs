﻿// <auto-generated />
using Chatbot101.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Chatbot101.API.Data.Migrations
{
    [DbContext(typeof(Chatbot101DataContext))]
    [Migration("20171130122107_initdb2")]
    partial class initdb2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Chatbot101.API.Data.Entity.ActivityLog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<string>("ActivityId");

                    b.Property<string>("ChannelId");

                    b.Property<string>("ConversationId");

                    b.Property<bool>("ConversationIsGroup");

                    b.Property<string>("ConversationName");

                    b.Property<string>("FromChannelAccountId");

                    b.Property<string>("FromChannelAccountName");

                    b.Property<string>("InputHint");

                    b.Property<string>("Locale");

                    b.Property<string>("Name");

                    b.Property<string>("RecipientChannelAccountId");

                    b.Property<string>("RecipientChannelAccountName");

                    b.Property<string>("ReplyToId");

                    b.Property<string>("ServiceUrl");

                    b.Property<string>("Speak");

                    b.Property<string>("Summary");

                    b.Property<string>("Text");

                    b.Property<string>("TextFormat");

                    b.Property<string>("TopicName");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("ActivityLogs");
                });

            modelBuilder.Entity("Chatbot101.API.Data.Entity.IncomingData", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsProcessed");

                    b.Property<string>("RawData");

                    b.Property<string>("ReferenceID");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("ID");

                    b.ToTable("IncomingData");
                });
#pragma warning restore 612, 618
        }
    }
}
