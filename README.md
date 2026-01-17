NOTE---
untuk akun dummy hikam123@gmail.com pass: 12345
untuk akun dummy brilsyah@gmail.com pass : 54321
untuk akun dummy lain dibawah ini
(role : username password)
Admin : 1 1
Karyawan : 2 2
Customer : 3 3

tambahkan akun untuk memudahkan pengujian, misalnya email : 1 pass : 1
perhatikan hashing ketika menambahkannya secara manual menggunakan pgadmin

```bash
PBOBarberMate
?
??? Core (Domain Layer)
?   ??? Entities           <-- Plain Old CLR Objects (POCO), e.g., Presensi.cs
?   ??? Interfaces         <-- IRepository, IService, IBehavior
?   ??? Enums              <-- StatusPresensi, UserRole
?   ??? Common             <-- Konstanta atau Value Objects
?
??? Application (Logic Layer)
?   ??? DTOs               <-- Data Transfer Objects untuk komunikasi UI-Service
?   ??? Services           <-- Orchestrator logika bisnis (PresensiService.cs)
?   ??? Behaviors          <-- Implementasi Strategy Pattern untuk tiap role
?   ?   ??? Presensi
?   ?       ??? KaryawanPresensiBehavior.cs
?   ?       ??? AdminPresensiBehavior.cs
?   ??? Mappers            <-- Konversi Entity ke DTO (bisa pakai AutoMapper)
?
??? Infrastructure (Data Layer)
?   ??? Persistence        <-- DbContext, DB_ConnectionFactory
?   ??? Repositories       <-- Implementasi CRUD Database (PresensiRepository.cs)
?   ??? ExternalServices   <-- API pihak ketiga (jika ada)
?
??? Presentation (UI Layer - WinForms)
?   ??? Components         <-- Custom Control atau Reusable UI elements
?   ??? Views              <-- Form dan UserControl (Hanya UI & Event Binding)
?   ?   ??? Presensi
?   ?   ?   ??? PresensiHistoryUC.cs
?   ?   ??? MainApp.cs
?   ??? Presenters/ViewModels <-- Jembatan antara UI dan Application Layer
?   ??? Utils              <-- WinForms specific helpers (DataGridView sorter, etc.)
?
??? Program.cs             <-- Komposisi Root (Tempat Register DI)
??? App.config / Settings  <-- Konfigurasi String Koneksi
```