using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SecondMicorService.Models
{
    public partial class ACESQAContext : DbContext
    {
        public ACESQAContext()
        {
        }

        public ACESQAContext(DbContextOptions<ACESQAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airline> Airline { get; set; }
        public virtual DbSet<BuildPathLocations> BuildPathLocations { get; set; }
        public virtual DbSet<CcInfo> CcInfo { get; set; }
        public virtual DbSet<CityCountry> CityCountry { get; set; }
        public virtual DbSet<CountryCodeName> CountryCodeName { get; set; }
        public virtual DbSet<CreditCardSwipeData> CreditCardSwipeData { get; set; }
        public virtual DbSet<Dm> Dm { get; set; }
        public virtual DbSet<DmData> DmData { get; set; }
        public virtual DbSet<Dmtier> Dmtier { get; set; }
        public virtual DbSet<Embargos> Embargos { get; set; }
        public virtual DbSet<FlightLibrary> FlightLibrary { get; set; }
        public virtual DbSet<MachineLocalization> MachineLocalization { get; set; }
        public virtual DbSet<Market> Market { get; set; }
        public virtual DbSet<MarketInfo> MarketInfo { get; set; }
        public virtual DbSet<PassportSwipeData> PassportSwipeData { get; set; }
        public virtual DbSet<PnrQueue> PnrQueue { get; set; }
        public virtual DbSet<PnrRecord> PnrRecord { get; set; }
        public virtual DbSet<QikLocationType> QikLocationType { get; set; }
        public virtual DbSet<QikPopupProperties> QikPopupProperties { get; set; }
        public virtual DbSet<QikPopups> QikPopups { get; set; }
        public virtual DbSet<SineIns> SineIns { get; set; }
        public virtual DbSet<TcId506894Aq32v> TcId506894Aq32v { get; set; }
        public virtual DbSet<TestConfigurationKv> TestConfigurationKv { get; set; }
        public virtual DbSet<VisaSwipeData> VisaSwipeData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=ESRDBS0001\\ACESQA;Initial Catalog=ACESQA;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airline>(entity =>
            {
                entity.Property(e => e.AirlineId).HasColumnName("Airline_Id");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.FriendlyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BuildPathLocations>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Path).IsRequired();

                entity.Property(e => e.Squad)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CcInfo>(entity =>
            {
                entity.HasKey(e => e.CcId)
                    .HasName("PK_CreditCard");

                entity.ToTable("CC_INFO");

                entity.Property(e => e.CcId).HasColumnName("CC_ID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CcType)
                    .IsRequired()
                    .HasColumnName("CC_Type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cid)
                    .HasColumnName("CID")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpMonth)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExpYear)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TestCcType)
                    .IsRequired()
                    .HasColumnName("Test_CC_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UseCase).IsUnicode(false);

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CityCountry>(entity =>
            {
                entity.ToTable("City_Country");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityCode)
                    .IsRequired()
                    .HasColumnName("city_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("country_code")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountryName)
                    .HasColumnName("country_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimeOffsetPhx).HasColumnName("TimeOffset_PHX");
            });

            modelBuilder.Entity<CountryCodeName>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CountryCode_Name");

                entity.Property(e => e.CountryCode)
                    .HasColumnName("Country_Code")
                    .HasMaxLength(255);

                entity.Property(e => e.CountryName)
                    .HasColumnName("Country_Name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<CreditCardSwipeData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CreditCard_Swipe_Data");

                entity.Property(e => e.CardSwipeData)
                    .IsRequired()
                    .HasColumnName("Card_Swipe_Data")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.CardType)
                    .IsRequired()
                    .HasColumnName("Card_Type")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.DataScenario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Index).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Dm>(entity =>
            {
                entity.ToTable("DM");

                entity.Property(e => e.DmId).HasColumnName("DM_ID");

                entity.Property(e => e.DmNumber)
                    .IsRequired()
                    .HasColumnName("DM_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DmTier)
                    .IsRequired()
                    .HasColumnName("DM_Tier")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DmData>(entity =>
            {
                entity.ToTable("DM_Data");

                entity.Property(e => e.DmDataId).HasColumnName("DM_Data_Id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AirlineCode)
                    .IsRequired()
                    .HasColumnName("Airline_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DmNumber)
                    .IsRequired()
                    .HasColumnName("DM_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DmtierId).HasColumnName("DMTier_Id");

                entity.Property(e => e.Environment)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("First_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("Full Name")
                    .HasMaxLength(50);

                entity.Property(e => e.FullTier)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("Last_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dmtier>(entity =>
            {
                entity.ToTable("DMTier");

                entity.Property(e => e.DmtierId).HasColumnName("DMTier_Id");

                entity.Property(e => e.DmTier1)
                    .IsRequired()
                    .HasColumnName("DM_Tier")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Embargos>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.Property(e => e.Airport)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FlightLibrary>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("Flight_Library");

                entity.Property(e => e.Aircraft)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AirlineCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ArrivalTimePhx).HasColumnName("ArrivalTimePHX");

                entity.Property(e => e.Classes)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DepartTimePhx).HasColumnName("DepartTimePHX");

                entity.Property(e => e.DestinationAirportCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DestinationCountry)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MarketId).HasColumnName("MarketID");

                entity.Property(e => e.OriginAirportCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OriginCountry)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MachineLocalization>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.Property(e => e.BagTag)
                    .IsRequired()
                    .HasColumnName("BAG_TAG")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Decs)
                    .IsRequired()
                    .HasColumnName("DECS")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Liniata)
                    .IsRequired()
                    .HasColumnName("LINIATA")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Squad)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ticket)
                    .IsRequired()
                    .HasColumnName("TICKET")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Market>(entity =>
            {
                entity.HasKey(e => e.PairId);

                entity.Property(e => e.PairId).HasColumnName("pair_id");

                entity.Property(e => e.ArrivalCountry)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepartureCountry)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MarketId).HasColumnName("MarketID");

                entity.HasOne(d => d.MarketNavigation)
                    .WithMany(p => p.Market)
                    .HasForeignKey(d => d.MarketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Market_Market_Info");
            });

            modelBuilder.Entity<MarketInfo>(entity =>
            {
                entity.HasKey(e => e.MarketId);

                entity.ToTable("Market_Info");

                entity.Property(e => e.MarketId).HasColumnName("MarketID");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.MarketName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PassportSwipeData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Passport_Swipe_Data");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasColumnName("Country_Code")
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.DataScenario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Index).ValueGeneratedOnAdd();

                entity.Property(e => e.SwipeData)
                    .IsRequired()
                    .HasColumnName("Swipe_Data")
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PnrQueue>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("PNR_Queue");

                entity.Property(e => e.Arrive)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.ClassOfService)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Depart)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Environment)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.OriginCountry)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Paxpnr)
                    .IsRequired()
                    .HasColumnName("PAXPNR")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<PnrRecord>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("PNR_Record");

                entity.Property(e => e.Arrive)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Depart)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Environment)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsFixedLength();

                entity.Property(e => e.Paxpnr)
                    .IsRequired()
                    .HasColumnName("PAXPNR")
                    .HasMaxLength(10);

                entity.Property(e => e.TestCase)
                    .HasMaxLength(15)
                    .IsFixedLength();
            });

            modelBuilder.Entity<QikLocationType>(entity =>
            {
                entity.ToTable("Qik_Location_Type");

                entity.Property(e => e.QikLocationTypeId).HasColumnName("Qik_Location_Type_ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationType)
                    .IsRequired()
                    .HasColumnName("Location_Type")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QikPopupProperties>(entity =>
            {
                entity.HasKey(e => e.IndexProp);

                entity.ToTable("QIK_Popup_Properties");

                entity.Property(e => e.HumanName).IsRequired();

                entity.Property(e => e.Qik16Name)
                    .IsRequired()
                    .HasColumnName("QIk16Name")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Qik32name)
                    .IsRequired()
                    .HasColumnName("QIK32Name")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.HasOne(d => d.IndexNavigation)
                    .WithMany(p => p.QikPopupProperties)
                    .HasForeignKey(d => d.Index)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QIK_Popup_Properties_QIK_Popups");
            });

            modelBuilder.Entity<QikPopups>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("QIK_Popups");

                entity.Property(e => e.PopupTitle).IsRequired();

                entity.Property(e => e.Program)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SineIns>(entity =>
            {
                entity.HasKey(e => e.Index);

                entity.ToTable("SINE_Ins");

                entity.Property(e => e.Index).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Environment)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Epr).HasColumnName("EPR");

                entity.Property(e => e.Keywords).IsRequired();

                entity.Property(e => e.Passcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TcId506894Aq32v>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TC_Id_506894_AQ32V");

                entity.Property(e => e.Environment).IsRequired();
            });

            modelBuilder.Entity<TestConfigurationKv>(entity =>
            {
                entity.HasKey(e => e.VarId);

                entity.ToTable("TestConfigurationKV");

                entity.Property(e => e.VarId).HasColumnName("Var_ID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.VarKey)
                    .IsRequired()
                    .HasColumnName("Var_Key")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VarValue)
                    .IsRequired()
                    .HasColumnName("Var_Value")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VisaSwipeData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Visa_Swipe_Data");

                entity.Property(e => e.DataScenario)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Index).ValueGeneratedOnAdd();

                entity.Property(e => e.VisaSwipeData1)
                    .IsRequired()
                    .HasColumnName("Visa_Swipe_Data")
                    .HasMaxLength(200)
                    .IsFixedLength();

                entity.Property(e => e.VisaType)
                    .IsRequired()
                    .HasColumnName("Visa_Type")
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
