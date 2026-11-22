using Microsoft.EntityFrameworkCore;
using VetKlinik.Web.Models;

namespace VetKlinik.Web.Data;

public class KlinikDbContext : DbContext
{
    public KlinikDbContext(DbContextOptions<KlinikDbContext> options) : base(options) { }

    public DbSet<Klinik> Klinikler => Set<Klinik>();
    public DbSet<Hizmet> Hizmetler => Set<Hizmet>();
    public DbSet<Veteriner> Veterinerler => Set<Veteriner>();
    public DbSet<MusaitlikSaati> MusaitlikSaatleri => Set<MusaitlikSaati>();
    public DbSet<Sahip> Sahipler => Set<Sahip>();
    public DbSet<Hayvan> Hayvanlar => Set<Hayvan>();
    public DbSet<Asi> Asilar => Set<Asi>();
    public DbSet<Randevu> Randevular => Set<Randevu>();
    public DbSet<MuayeneNotu> MuayeneNotlari => Set<MuayeneNotu>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Randevu silinirken veteriner/hizmet/hayvan zinciri kopmasin
        modelBuilder.Entity<Randevu>()
            .HasOne(r => r.Veteriner).WithMany(v => v.Randevular)
            .HasForeignKey(r => r.VeterinerId).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Randevu>()
            .HasOne(r => r.Hizmet).WithMany()
            .HasForeignKey(r => r.HizmetId).OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Randevu>()
            .HasOne(r => r.MuayeneNotu).WithOne(m => m.Randevu)
            .HasForeignKey<MuayeneNotu>(m => m.RandevuId);

        modelBuilder.Entity<Hizmet>().Property(h => h.Fiyat).HasPrecision(10, 2);
    }
}
