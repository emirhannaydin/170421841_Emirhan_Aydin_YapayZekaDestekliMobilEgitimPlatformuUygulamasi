# 🎓 EgitimPlatformuAI

**EgitimPlatformuAI**, Türkçe öğrenmek isteyen kullanıcılar için geliştirilen yapay zekâ destekli bir iOS eğitim uygulamasıdır. Uygulama; **Speaking**, **Reading**, **Writing** ve **Listening** olmak üzere dört temel dil becerisini kapsayan interaktif kurslar sunar.

## 📱 Özellikler

- 📚 Dört beceriye özel kurslar:  
  - **Speaking**: Yapay zekâ ile konuşma pratiği  
  - **Reading**: Okuma metinleri ve içerik soruları  
  - **Writing**: AI destekli yazma alıştırmaları ve anında geri bildirim  
  - **Listening**: Dinleme egzersizleri ve çoktan seçmeli sorular

- 🤖 OpenAI entegrasyonu ile kişisel asistan ve anlık geri bildirim sistemi

- 🧑‍🏫 Öğretmen paneli:  
  - Ders ve soru ekleme  
  - Öğrenci performanslarını görüntüleme  
  - Kurs içeriklerini düzenleme

- 👨‍🎓 Öğrenci paneli:  
  - Ders içeriklerini görüntüleme  
  - Test çözme ve yapay zekâ destekli değerlendirme alma

## 🛠️ Teknolojiler

| Katman        | Teknoloji                   |
|---------------|-----------------------------|
| Uygulama      | Swift, UIKit (programatik arayüz) |
| Mimarî        | MVVM-C (Model-View-ViewModel-Coordinator) |
| Yapay Zekâ    | OpenAI GPT, Whisper (Text-to-Speech & Speech-to-Text) |
| Animasyonlar  | Lottie                      |

## ⚙️ Kurulum

1. Bu repoyu klonlayın:
   ```bash
   git clone https://github.com/emirhannaydin/EgitimPlatformuAI.git

2. Kütüphaneleri indirin:
   ```bash
   pod install

# 🎓 Bitirme Projesi - .NET 8 + Docker + Katmanlı Mimari

Bu proje, mezuniyet çalışması olarak geliştirilmiş, Docker destekli, .NET 8 ile yazılmış bir web API mimarisidir. Temiz kod, test edilebilirlik ve sürdürülebilirlik esas alınarak modern bir katmanlı yapı kurulmuştur.

---

## 📦 Teknolojiler

- .NET 8 Web API
- Entity Framework Core
- Katmanlı Mimari (API, BLL, DAL)
- PostgreSQL veya MSSQL
- Docker ve Docker Compose
- Swagger
- JWT Authentication

---

## 🧱 Katmanlar

- **Bitirme.API**: Giriş noktası, controller ve middleware yapıları burada.
- **Bitirme.BLL**: İş kuralları, DTO’lar, servis arayüzleri ve validasyonlar.
- **Bitirme.DAL**: Entity’ler, interface tanımları, enumlar,DbContext, repository implementasyonları, migration işlemleri.

---

## 🚀 Projeyi Çalıştırma

### Gereksinimler

- .NET 8 SDK
- Docker
- PostgreSQL ya da MSSQL (Docker ile otomatik başlar)
- Visual Studio veya VS Code

### Adımlar

```bash
git clone https://github.com/dogukankiziltepe/Bitirme.git
cd Bitirme
docker-compose up --build
