
function like(id) {
  console.log('ürün-id', id);


  // sayfa yenilenmeden action istek atma yöntemi. arka planda sayfa yenilenmeden c# ile haberleşme
  $.ajax({
    method: 'POST', // backend'e post atıcam
    url: '/Home/Like', // bu url gidicem, Controller/Action
    data: JSON.stringify(id), // veri olarak id göndericeğim. id JSON formatına döndüştrüdük. C# Json formatındaki değerleri okuyabiliyor.
    contentType: 'application/json', // json formatında veri göndereceğimizi söylemeliyiz. C# JSON result olarak bu kodu çalıştırsın diye yoksa 415 method izni yok hatası verir.
    success: function (response) { // işlem başarılı ise çalışan function
      console.log('response', response);
      // kalp ise gray galp değilse red kalp yap.

      // c# dan gelen değer success ise
      if (response.isSuccess) {
        // jquery ile yakalanan dive class vermek için addClass kodunu kullandık.
        $("#like_" + id).removeClass("heart-like");
        $("#like_" + id).removeClass("heart-unlike");
        $("#like_" + id).addClass(response.liked ? "heart-like" : "heart-unlike");
      }
      else {
        alert("Hata oluştu!. Tekrar Deneyiniz");
      }
    },
    error: function (err) { // işlemde hata varsa çalışan function
      console.log('err', err);
      // alert ile kullanıcıya hatayı göster.
      alert("Hata oluştu!. Tekrar Deneyiniz");
    }
  })

}

