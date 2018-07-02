@Code
    ViewData("Title") = "JQuerySample"
End Code

<script> //Global app setting
    $realta = {};
    gcBaseUrl = "http://localhost:50771";
    //gcBaseUrl = "https://localhost:44312";
    USERNAME = "R_BasicAuthToken";
    PASSWORD = "Realta.co.id";

    $realta.callService = function (pcUrl, poParam) {
        //$.ajax({
        //    type: "POST",
        //    url: pcUrl,
        //    data: JSON.stringify(poParam),
        //    contentType: "application/json; charset=utf-8",
        //    dataType: "json",
        //})
        //    .done(function (msg) {
        //        alert("Data Saved: " + msg);
        //    })
        //    .fail(function (jqXHR, textStatus) {
        //        alert("Request failed: " + textStatus);
        //    });

        return $.ajax({
            type: "POST",
            url: pcUrl,
            data: JSON.stringify(poParam),
            contentType: "application/json; charset=utf-8",
            dataType: "json",
        });
    }
</script>

<script> //Program specific script
    function btnGetList_click() {
        $realta.callService(gcBaseUrl + "/api/Test/GetList", {
            "piDataCount": 10
        });
    }

    function btnGetRecord_click() {
        $realta.callService(gcBaseUrl + "/api/Test/GetRecord", {});
    }

    function btnAdd_click() {
        $realta.callService(gcBaseUrl + "/api/Test/Add", {

        });
    }

    function btnEdit_click() {
        $realta.callService(gcBaseUrl + "/api/Test/Edit", {

        });
    }

    function btnDelete_click() {
        $realta.callService(gcBaseUrl + "/api/Test/Delete", {

        });
    }
</script>

<button type="button" onclick="btnGetList_click()">Get List</button>
<button type="button" onclick="btnGetRecord_click()">Get Record</button>
<button type="button" onclick="btnAdd_click()">Add</button>
<button type="button" onclick="btnEdit_click()">Edit</button>
<button type="button" onclick="btnDelete_click()">Delete</button>
