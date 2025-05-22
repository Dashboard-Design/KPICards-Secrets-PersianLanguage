# KPICards-Secrets: مجموعه حرفه‌ای کارت‌های KPI در Power BI  

![Power BI](https://img.shields.io/badge/Power_BI-F2C811?style=for-the-badge&logo=powerbi&logoColor=black)
![Tabular Editor](https://img.shields.io/badge/Tabular_Editor-2C2D72?style=for-the-badge)
![DAX](https://img.shields.io/badge/DAX-FF6F00?style=for-the-badge)

**پروژه‌ای برای نمایش تکنیک‌های پیشرفته طراحی کارت‌های KPI با استفاده از:**  
✅ DAX پیشرفته  
✅ اتوماسیون با C# در Tabular Editor  
✅ SVGهای تعاملی  
✅ پارامترهای پویا  

---

## فهرست مطالب
- [صفحات پروژه](#-صفحات-پروژه)
- [ویژگی‌های کلیدی](#-ویژگی‌های-کلیدی)
- [لینک‌های مفید](#-لینک‌های-مفید)
- [راهنمای اجرا](#-راهنمای-اجرا)

---

## 🖼️ صفحات پروژه

| صفحه | توضیحات |
|------|---------|
| **1. نمونه کارت اول** | نمایش ساده KPI با مقایسه ماه جاری و گذشته |
| **2. نمونه کارت دوم** | فرمت‌دهی شرطی بر اساس عملکرد |
| **3. کارت جدید** | ادغام DAX و SVG برای کارت‌های پویا |
| **4. مژر نوشتن گروهی با #C** | ساخت خودکار Measureها با اسکریپت‌های C# |
| **5. کارت جدید با کتگوری‌ها** | گروه‌بندی هوشمند بر اساس ابعاد |
| **6. کارت جدید با پارامترها** | مدیریت پارامترهای پویا در Tabular Editor |
| **7. کارت جدید با SVG** | استفاده از تمپلیت‌های SVG حرفه‌ای |
| **8. کارت با قابلیت فیلتر کردن** | فیلترگذاری داینامیک با Bookmarkها |

---

## 🚀 ویژگی‌های کلیدی

### 1. پارامترهای پویا
```csharp
// مثال: ساخت پارامتر زمانی در Tabular Editor
var timeParam = Model.AddCalculationGroup("پارامترهای زمانی");
timeParam.AddCalculationItem("ماه جاری", "SELECTEDMEASURE()");
