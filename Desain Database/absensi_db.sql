/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     05/03/2019 22:40:49                          */
/*==============================================================*/


drop table if exists DABSENSI_PEGAWAI;

drop table if exists DABSENSI_SISWA;

drop table if exists DETAIL_JABATAN;

drop table if exists DPERIZINAN_PEGAWAI;

drop table if exists HABSENSI_PEGAWAI;

drop table if exists HABSENSI_SISWA;

drop table if exists HKELAS;

drop table if exists HPERIZINAN_PEGAWAI;

drop table if exists JABATAN;

drop table if exists JADWAL;

drop table if exists MAPEL;

drop table if exists MEMPUNYAI_KELAS;

drop table if exists MUTASI_SISWA;

drop table if exists PEGAWAI;

drop table if exists ROMBEL;

drop table if exists RUANG;

drop table if exists SISWA;

drop table if exists TAHUN_AJARAN;

/*==============================================================*/
/* Table: DABSENSI_PEGAWAI                                      */
/*==============================================================*/
create table DABSENSI_PEGAWAI
(
   ID_PEGAWAI           char(20) not null,
   ID_APEGAWAI          char(20) not null,
   JAM_MASUK            date,
   KETERLAMBATAN        numeric(8,0),
   STATUS               numeric(8,0),
   KETERANGAN           char(250),
   primary key (ID_PEGAWAI, ID_APEGAWAI)
);

/*==============================================================*/
/* Table: DABSENSI_SISWA                                        */
/*==============================================================*/
create table DABSENSI_SISWA
(
   ID_ASISWA            char(20) not null,
   ID_SISWA             char(20) not null,
   KETERLAMBATAN        numeric(8,0),
   STATUS               numeric(8,0),
   KETERANGAN           char(250),
   primary key (ID_ASISWA, ID_SISWA)
);

/*==============================================================*/
/* Table: DETAIL_JABATAN                                        */
/*==============================================================*/
create table DETAIL_JABATAN
(
   ID_MENJABAT          char(20) not null,
   ID_PEGAWAI           char(20) not null,
   ID_JABATAN           char(20) not null,
   AWAL_BAKTI           date,
   AKHIR_BAKTI          date,
   STATUS               numeric(8,0),
   primary key (ID_MENJABAT)
);

/*==============================================================*/
/* Table: DPERIZINAN_PEGAWAI                                    */
/*==============================================================*/
create table DPERIZINAN_PEGAWAI
(
   ID_PEGAWAI           char(20) not null,
   ID_IZIN              char(20) not null,
   LAMA_IZIN            numeric(8,0),
   TGL_IZIN             date,
   TGL_DISETUJUI        date,
   STATUS               numeric(8,0),
   KETERANGAN           char(250),
   primary key (ID_PEGAWAI, ID_IZIN)
);

/*==============================================================*/
/* Table: HABSENSI_PEGAWAI                                      */
/*==============================================================*/
create table HABSENSI_PEGAWAI
(
   ID_APEGAWAI          char(20) not null,
   TAHUN_AJARAN         char(20) not null,
   HARI                 char(20),
   TGL                  date,
   JAM_MASUK            date,
   TOTAL_HADIR          numeric(8,0),
   TOTAL_ALFA           numeric(8,0),
   STATUS               numeric(8,0),
   primary key (ID_APEGAWAI)
);

/*==============================================================*/
/* Table: HABSENSI_SISWA                                        */
/*==============================================================*/
create table HABSENSI_SISWA
(
   ID_ASISWA            char(20) not null,
   TAHUN_AJARAN         char(20) not null,
   HARI                 char(20),
   TGL                  date,
   JAM_MASUK            date,
   TOTAL_HADIR          numeric(8,0),
   TOTAL_ALFA           numeric(8,0),
   STATUS               numeric(8,0),
   primary key (ID_ASISWA)
);

/*==============================================================*/
/* Table: HKELAS                                                */
/*==============================================================*/
create table HKELAS
(
   ID_KELAS             char(20) not null,
   ID_PEGAWAI           char(20) not null,
   ID_ROMBEL            char(20) not null,
   ID_RUANG             char(20) not null,
   TAHUN_AJARAN         char(20) not null,
   TOTAL_SISWA          numeric(8,0),
   STATUS               numeric(8,0),
   primary key (ID_KELAS)
);

/*==============================================================*/
/* Table: HPERIZINAN_PEGAWAI                                    */
/*==============================================================*/
create table HPERIZINAN_PEGAWAI
(
   ID_IZIN              char(20) not null,
   TAHUN_AJARAN         char(20) not null,
   PERIODEAWAL          date,
   PERIODEAKHIR         date,
   TOTAL_IZIN           numeric(8,0),
   TOTAL_DISETUJUI      numeric(8,0),
   KETERANGAN           char(250),
   STATUS               numeric(8,0),
   primary key (ID_IZIN)
);

/*==============================================================*/
/* Table: JABATAN                                               */
/*==============================================================*/
create table JABATAN
(
   ID_JABATAN           char(20) not null,
   JABATAN              char(30),
   STATUS               numeric(8,0),
   primary key (ID_JABATAN)
);

/*==============================================================*/
/* Table: JADWAL                                                */
/*==============================================================*/
create table JADWAL
(
   ID_MAPEL             char(20) not null,
   ID_PEGAWAI           char(20) not null,
   ID_KELAS             char(20) not null,
   TAHUN_AJARAN         char(20) not null,
   HARI                 char(20),
   JAM_AWALMENGAJAR     time,
   JAM_AKHIRMENGAJAR    time,
   primary key (ID_MAPEL, ID_PEGAWAI, ID_KELAS, TAHUN_AJARAN)
);

/*==============================================================*/
/* Table: MAPEL                                                 */
/*==============================================================*/
create table MAPEL
(
   ID_MAPEL             char(20) not null,
   MAPEL                char(50),
   STATUS               numeric(8,0),
   primary key (ID_MAPEL)
);

/*==============================================================*/
/* Table: MEMPUNYAI_KELAS                                       */
/*==============================================================*/
create table MEMPUNYAI_KELAS
(
   ID_SISWA             char(20) not null,
   ID_KELAS             char(20) not null,
   primary key (ID_SISWA, ID_KELAS)
);

/*==============================================================*/
/* Table: MUTASI_SISWA                                          */
/*==============================================================*/
create table MUTASI_SISWA
(
   ID_MUTASI            char(20) not null,
   ID_SISWA             char(20),
   NO_INDUK             numeric(8,0),
   NISN                 numeric(8,0),
   NAMA_SISWA           char(100),
   ALAMAT               char(250),
   GENDER               char(20),
   AGAMA                char(20),
   TGL_MASUK            date,
   TGL_KELUAR           date,
   ASAL_SD              char(20),
   AYAH                 char(100),
   IBU                  char(100),
   TELP                 char(20),
   STATUS               numeric(8,0),
   primary key (ID_MUTASI)
);

/*==============================================================*/
/* Table: PEGAWAI                                               */
/*==============================================================*/
create table PEGAWAI
(
   ID_PEGAWAI           char(20) not null,
   NO_INDUK             numeric(8,0),
   NAMA                 char(250),
   GENDER               char(20),
   AGAMA                char(20),
   ALAMAT               char(250),
   TELP                 char(20),
   TGL_MASUK            date,
   STATUS               numeric(8,0),
   PASSWORD             char(30),
   primary key (ID_PEGAWAI)
);

/*==============================================================*/
/* Table: ROMBEL                                                */
/*==============================================================*/
create table ROMBEL
(
   ID_ROMBEL            char(20) not null,
   ROMBEL               char(20),
   STATUS               numeric(8,0),
   primary key (ID_ROMBEL)
);

/*==============================================================*/
/* Table: RUANG                                                 */
/*==============================================================*/
create table RUANG
(
   ID_RUANG             char(20) not null,
   RUANG                char(20),
   STATUS               numeric(8,0),
   primary key (ID_RUANG)
);

/*==============================================================*/
/* Table: SISWA                                                 */
/*==============================================================*/
create table SISWA
(
   ID_SISWA             char(20) not null,
   NO_INDUK             numeric(8,0),
   NISN                 numeric(8,0),
   NAMA_SISWA           char(100),
   ALAMAT               char(250),
   GENDER               char(20),
   AGAMA                char(20),
   TGL_MASUK            date,
   ASAL_SD              char(20),
   AYAH                 char(100),
   IBU                  char(100),
   TELP                 char(20),
   STATUS               numeric(8,0),
   primary key (ID_SISWA)
);

/*==============================================================*/
/* Table: TAHUN_AJARAN                                          */
/*==============================================================*/
create table TAHUN_AJARAN
(
   TAHUN_AJARAN         char(20) not null,
   TAHUN                char(20),
   SEMESTER             char(20),
   STATUS               numeric(8,0),
   primary key (TAHUN_AJARAN)
);

alter table DABSENSI_PEGAWAI add constraint FK_DABSENSI_PEGAWAI foreign key (ID_PEGAWAI)
      references PEGAWAI (ID_PEGAWAI) on delete restrict on update restrict;

alter table DABSENSI_PEGAWAI add constraint FK_DABSENSI_PEGAWAI2 foreign key (ID_APEGAWAI)
      references HABSENSI_PEGAWAI (ID_APEGAWAI) on delete restrict on update restrict;

alter table DABSENSI_SISWA add constraint FK_DABSENSI_SISWA foreign key (ID_ASISWA)
      references HABSENSI_SISWA (ID_ASISWA) on delete restrict on update restrict;

alter table DABSENSI_SISWA add constraint FK_DABSENSI_SISWA2 foreign key (ID_SISWA)
      references SISWA (ID_SISWA) on delete restrict on update restrict;

alter table DETAIL_JABATAN add constraint FK_MENDETAIL_JABATAN foreign key (ID_JABATAN)
      references JABATAN (ID_JABATAN) on delete restrict on update restrict;

alter table DETAIL_JABATAN add constraint FK_MENJABAT foreign key (ID_PEGAWAI)
      references PEGAWAI (ID_PEGAWAI) on delete restrict on update restrict;

alter table DPERIZINAN_PEGAWAI add constraint FK_DPERIZINAN_PEGAWAI foreign key (ID_PEGAWAI)
      references PEGAWAI (ID_PEGAWAI) on delete restrict on update restrict;

alter table DPERIZINAN_PEGAWAI add constraint FK_DPERIZINAN_PEGAWAI2 foreign key (ID_IZIN)
      references HPERIZINAN_PEGAWAI (ID_IZIN) on delete restrict on update restrict;

alter table HABSENSI_PEGAWAI add constraint FK_PERIODE_ABSENSI_PEGAWAI foreign key (TAHUN_AJARAN)
      references TAHUN_AJARAN (TAHUN_AJARAN) on delete restrict on update restrict;

alter table HABSENSI_SISWA add constraint FK_TAHUN_AJARAN_ABSENSI_SISWA foreign key (TAHUN_AJARAN)
      references TAHUN_AJARAN (TAHUN_AJARAN) on delete restrict on update restrict;

alter table HKELAS add constraint FK_KELOMPOK foreign key (ID_ROMBEL)
      references ROMBEL (ID_ROMBEL) on delete restrict on update restrict;

alter table HKELAS add constraint FK_MEMBINA_KELAS foreign key (ID_PEGAWAI)
      references PEGAWAI (ID_PEGAWAI) on delete restrict on update restrict;

alter table HKELAS add constraint FK_MENEMPATI foreign key (ID_RUANG)
      references RUANG (ID_RUANG) on delete restrict on update restrict;

alter table HKELAS add constraint FK_PERIODE_KELAS foreign key (TAHUN_AJARAN)
      references TAHUN_AJARAN (TAHUN_AJARAN) on delete restrict on update restrict;

alter table HPERIZINAN_PEGAWAI add constraint FK_TAHUN_AJARAN_PERIZINAN foreign key (TAHUN_AJARAN)
      references TAHUN_AJARAN (TAHUN_AJARAN) on delete restrict on update restrict;

alter table JADWAL add constraint FK_JADWAL foreign key (ID_MAPEL)
      references MAPEL (ID_MAPEL) on delete restrict on update restrict;

alter table JADWAL add constraint FK_JADWAL2 foreign key (ID_PEGAWAI)
      references PEGAWAI (ID_PEGAWAI) on delete restrict on update restrict;

alter table JADWAL add constraint FK_JADWAL3 foreign key (ID_KELAS)
      references HKELAS (ID_KELAS) on delete restrict on update restrict;

alter table JADWAL add constraint FK_JADWAL4 foreign key (TAHUN_AJARAN)
      references TAHUN_AJARAN (TAHUN_AJARAN) on delete restrict on update restrict;

alter table MEMPUNYAI_KELAS add constraint FK_MEMPUNYAI_KELAS foreign key (ID_SISWA)
      references SISWA (ID_SISWA) on delete restrict on update restrict;

alter table MEMPUNYAI_KELAS add constraint FK_MEMPUNYAI_KELAS2 foreign key (ID_KELAS)
      references HKELAS (ID_KELAS) on delete restrict on update restrict;

alter table MUTASI_SISWA add constraint FK_MUTASI foreign key (ID_SISWA)
      references SISWA (ID_SISWA) on delete restrict on update restrict;

