[![Screenshot-1.jpg](https://i.postimg.cc/XY2HF1Bf/Screenshot-1.jpg)]


نظام ادراة قسم تقنية المعلومات بالمؤسسات مبني علي ASP.NET Core سأشرح تخصصات المشروع.

المشروع هو لوحة تحكم لإدارة قسم تكنولوجيا المعلومات. يهدف المشروع إلى توفير واجهة مركزية لإدارة جوانب مختلفة من قسم تكنولوجيا المعلومات، بما في ذلك:

إدارة المخزون: تتبع وإدارة الأجهزة والبرامج والملحقات.
إدارة الأصول: تتبع وإدارة أصول تكنولوجيا المعلومات، مثل الخوادم وأجهزة الكمبيوتر المحمولة والطابعات.
نظام التذاكر: إدارة طلبات الدعم الفني والإبلاغ عن المشكلات.
التحليلات: عرض التقارير والرسوم البيانية حول أداء قسم تكنولوجيا المعلومات.
إدارة المستخدمين: إدارة حسابات المستخدمين والأذونات.
بالإضافة إلى ذلك، يحتوي المشروع على صفحة "All Reports" (جميع التقارير) التي تعرض تقارير واستبيانات خاصة بكل الأقسام، مع رسم بياني بسيط باستخدام Chart.js يمثل الطابعات (الجديدة، والمستخدمة، والعاطلة)، والأجهزة والملحقات، ونظام التذاكر (التذاكر المفتوحة، والمغلقة، والتي قيد المراجعة) ويملأ الصفحة، مع تسميات باللغة العربية.

طريقة التشغيل مرفقة + قاعدة البيانات كاملة

صنع بالحب في ليبيا. م. جمال الفيتوري.


تعليمات تشغيل المشروع:

1.  تأكد من تثبيت .NET SDK على جهازك.
2.  افتح موجه الأوامر أو المحطة الطرفية وانتقل إلى دليل المشروع.
3.  قم بتشغيل الأمر `dotnet run` لتشغيل المشروع.
4.  افتح متصفح الويب وانتقل إلى عنوان URL الذي يظهر في إخراج الأمر `dotnet run` (عادةً ما يكون `http://localhost:5252`).

في حالة حدوث أخطاء:

*   تحقق من إخراج الأمر `dotnet run` للحصول على رسائل الخطأ.
*   تأكد من أن لديك جميع التبعيات المطلوبة مثبتة. يمكنك استعادة التبعيات باستخدام الأمر `dotnet restore`.
*   إذا كنت لا تزال تواجه مشكلات، فحاول تنظيف المشروع وإعادة بنائه باستخدام الأوامر `dotnet clean` و `dotnet build`.
