# Giriş Paneli

Bu program, bir giriş paneli uygulamasıdır. Kullanıcıdan, doğru kullanıcı adı ve şifreyi girdiği sürece sisteme giriş izni verir.

Program, while döngüsü kullanarak, kullanıcının giriş bilgilerini sürekli olarak alır ve kullanıcının girdiği bilgileri doğrular. Eğer doğru kullanıcı adı ve şifre girilirse, kullanıcı sisteme giriş yapabilir. Eğer kullanıcı adı veya şifre yanlış girilirse, program kullanıcıyı bilgilendirir ve tekrar giriş bilgilerini alır.

Program, brute-force saldırılarını önlemek için, kullanıcı adı veya şifre yanlış girildiğinde, hangisinin yanlış olduğuna dair bir bilgi vermez. Bu sayede, bir saldırganın doğru kullanıcı adı veya şifreyi bulmak için bir brute-force saldırısı gerçekleştirmesi daha zor hale gelir.

## Kullanım

Bu giriş paneli uygulaması, doğru kullanıcı adı ve şifre girildiği sürece sisteme giriş yapılmasını sağlar. Kullanıcı adı ve şifre istemlerine yanıt vermek için konsol penceresi kullanılır.

Uygulamayı çalıştırmak için, C# derleyicisi kullanılarak projenin derlenmesi gerekir. Daha sonra, derlenen dosyanın çalıştırılması ile program çalıştırılabilir. Kullanıcının doğru giriş bilgilerini girmesi gerektiği için, bu bilgiler önceden belirlenmiştir ve uygulama tarafından doğrulama işlemi gerçekleştirilir.

Uygulamayı kullanırken, yanlış kullanıcı adı veya şifre girerseniz, tekrar giriş bilgilerini girmeniz istenir. Doğru giriş bilgileri girildiğinde, uygulama kullanıcıya sisteme başarılı bir şekilde giriş yapıldığını bildirir. Ayrıca, uygulama brute-force saldırılarını önlemek için yanlış giriş bilgilerinin hangisinin yanlış olduğu hakkında herhangi bir bilgi vermez.

Uygulama, başlangıç seviyesi C# öğrenenler için hazırlanmıştır ve kaynak kodu açıktır. Geliştiricinin adı, sürüm numarası ve lisans bilgileri gibi ayrıntılar, kullanıcılara projenin kaynaklarını takip etmelerine yardımcı olmak için sağlanmıştır.

## Geliştirici Bilgileri

Bu uygulama, bir başlangıç seviyesi C# projesi olarak hazırlanmıştır. Geliştirici bilgileri aşağıdaki gibidir:

Geliştirici: Eren Yılmaz