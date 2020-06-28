function showImage() {
    if (this.files && this.files[0]) {
        var obj = new FileReader();
        obj.onload = function (data) {
            var image = document.getElementById("image");
            image.src = data.target.result;
        }
        obj.readAsDataURL(this.files[0]);
    }
}
//$(document).ready(function () {
//    $("#check").click(function () {
//        let checkInDate = $(".checkIn").val();
//        let checkOutDate = $(".checkOut").val();
//        let count = $("#count").val();
//        alert(checkInDate + " " + checkOutDate + " " + count);
//        $.ajax({
//            url: "/Room/Index",
//            data: { startDate: checkInDate, endDate: checkOutDate, count: count },
//            method:"Get",
//        });
//    });
//});

$(document).ready(function () {
    $(document).on("change", "#university", function () {
        let data = $("#university").val();

        if (data) {
            $.ajax({
                url: "/Ajax/LoadFaculties",
                method: "GET",
                data: { universityId: data },
                success: function (res) {
                    $("#SelectedFaculty").html(res);
                }
            });
        }
        else {
            $("#SelectedFaculty").html("<option value=''>--Select Faculty--</option>");
        }
    });

    $(document).on("change", ".faculty", function () {
        let data = $(".faculty").val();
        if (data) {
            $.ajax({
                url: "/Ajax/LoadGroups",
                method: "GET",
                data: { facultyId: data },
                success: function (res) {
                    $("#SelectedGroup").html(res);
                }
            });
        }
        else {
            $("#SelectedGroup").html("<option value=''>--Select Group--</option>");
        }
    });

   
    $(document).on("change", "#count", function () {
        let checkInDate = $(".checkIn").val();
        let checkOutDate = $(".checkOut").val();
        let roomId = $("#roomId").val();
        let bedcount = $(".bed-count").text();
        let personCount = $("#count").val();

        if (checkInDate && checkOutDate && checkOutDate) {
            $.ajax({
                url: "/Ajax/GetPrice",
                data: { id: roomId, checkInDate: checkInDate, checkOutDate: checkOutDate, personCount: personCount },
                method: "GET",
                success: function (res) {
                    $(".room-order").html(res);
                }
            });
        }  
    });
});
